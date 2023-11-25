using System.Collections.Generic;
using ScriptableObjects.Units;
using UnityEngine;

namespace ScriptableObjects.Spawn
{
    [CreateAssetMenu(fileName = "Spawnable_Group", menuName = "Scriptable Objects/Spawn/Spawnable Group", order = 1)]
    public class SpawnableGroupSO : ScriptableObject
    {
        [System.Serializable]
        public struct SpawnableEnemy
        {
            public UnitSO enemy;
            public int quantity;
            public float spawnInterval;
        }
        
        public int quantity = 1;
        public float beginSpawnAt = 0;
        public float spawnInterval = 300;
        public int concurrentSpawn = 1;
        public List<SpawnableEnemy> enemies = new List<SpawnableEnemy>();

        private void OnValidate()
        {
            if (quantity < 1)
            {
                quantity = 1;
            }
            
            if (beginSpawnAt < 0)
            {
                beginSpawnAt = 0;
            }

            if (spawnInterval < 0)
            {
                spawnInterval = 0;
            }

            if (concurrentSpawn < 1)
            {
                concurrentSpawn = 1;
            }
        }
    }
}