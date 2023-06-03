using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dictinary : MonoBehaviour
{
   [SerializeField] private GameObject _prefabePlayer;
    [SerializeField] private GameObject _prefabePlayerTwo;
    [SerializeField] private GameObject _namesPlayers;
    private Dictionary<GameObject, GameObject> _nickNamesObject = new Dictionary<GameObject, GameObject>();
    private Dictionary<string, int> _nickNamesUI = new Dictionary<string, int>();
    public TMP_Text namesDisplay; 
    
    public void Start()
    {
        DisplayNames();
    }

    public void DisplayNames()
    {
        namesDisplay.text = ""; 
        foreach (var item in _nickNamesUI)
        {
            namesDisplay.text += "Item: " + item.Key + "             Quantity: " + item.Value + "\n";
        }
    }

    public void AddMike()
    {
        Debug.Log("sjfhdjdfhfj");
        GameObject player = Instantiate(_prefabePlayer);
        _nickNamesObject.Add(player, _namesPlayers);
        
        if (_nickNamesUI.ContainsKey("Mike"))
        {
            _nickNamesUI["Mike"]++;
        }
        else
        {
            _nickNamesUI.Add("Mike", 1);
        }
        DisplayNames();
    }
    
    public void RemoveMike()
    {
        if (_nickNamesUI.ContainsKey("Mike"))
        {
            _nickNamesUI["Mike"]--;
            
            if (_nickNamesUI["Mike"] <= 0)
            {
                _nickNamesUI.Remove("Mike");
            }
        }

        DisplayNames();
    }
}
