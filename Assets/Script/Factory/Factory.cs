using System;
using UnityEngine;

namespace Script.Factory
{
    public class Factory : MonoBehaviour
    {
        [SerializeField] private GameObject _progpamPrefab;

        private void Start()
        {
            Instantiate(_progpamPrefab);
        }
    }
}