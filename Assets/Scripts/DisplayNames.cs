using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class NamesOutput : MonoBehaviour
{
    protected int _count = 0;
    // [SerializeField] private GameObject _prefabeMiki;
    // [SerializeField] private GameObject _prefabeShrek;
    protected Dictionary<int, GameObject> _nickNamesObject = new Dictionary<int, GameObject>();
    public TMP_Text namesDisplay;
    // [SerializeField] private Transform _addMiki;
    // [SerializeField] private Transform _addShrek;

    public void Start()
    {
        DisplayNames();
    }

    public void DisplayNames()
    {
        namesDisplay.text = "";
        foreach (var item in _nickNamesObject)
        {
            namesDisplay.text += "Item: " + item.Key + " Quantity: " + item.Value + "\n";
        }

        //namesDisplay.text += "Item: Mike Quantity: " + _nickNamesObject.Count + "\n";
    }

    // public void AddMike()
    // {
    //     GameObject player = Instantiate(_prefabeMiki, _addMiki.position, _addMiki.rotation);
    //     _nickNamesObject.Add(_count++, player);
    //     DisplayNames();
    // }
    //
    // public void RemoveMike()
    // {
    //     int names = _nickNamesObject.Keys.Last();
    //     _nickNamesObject.Remove(names);
    //     Destroy(GameObject.Find("mickey-mouse(Clone)"));
    //     DisplayNames();
    // }
    //
    // public void AddShrek()
    // {
    //     GameObject player = Instantiate(_prefabeShrek, _addShrek.position, _addShrek.rotation);
    //     _nickNamesObject.Add(_count++, player);
    //     DisplayNames();
    // }
    //
    // public void RemoveShrek()
    // {
    //     int names = _nickNamesObject.Keys.Last();
    //     _nickNamesObject.Remove(names);
    //     Destroy(GameObject.Find("Shrek(Clone)"));
    //     DisplayNames();
    // }
}
