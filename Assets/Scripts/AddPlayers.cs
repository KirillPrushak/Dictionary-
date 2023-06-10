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
namespace DefaultNamespace
{
    public class AddPlayers : NamesOutput
    {
        [SerializeField] private GameObject _prefabePlayers;
        [SerializeField] private Transform _positionPlayers;
        public void AddNewPlayers()
        {
            GameObject player = Instantiate(_prefabePlayers, _positionPlayers.position, _positionPlayers.rotation);
            _nickNamesObject.Add(_count++, player);
            DisplayNames();
        }
    }
}