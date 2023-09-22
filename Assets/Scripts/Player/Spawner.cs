using System;
using UnityEngine;
using Zenject;

namespace Zenject_Lesson.Scripts
{
    public class Spawner : MonoBehaviour
    {
        [Inject] private DiContainer _container;
        
        [SerializeField] private GameObject _playerPrefab;
        [SerializeField] private Transform _spawnPoint;

        private void Start()
        {
            _container.InstantiatePrefab(
                _playerPrefab,
                _spawnPoint.position,
                Quaternion.identity,
                null);


            // Instantiate(
            //     _playerPrefab,
            //     _spawnPoint.position,
            //     Quaternion.identity,
            //     null);
        }
    }
}