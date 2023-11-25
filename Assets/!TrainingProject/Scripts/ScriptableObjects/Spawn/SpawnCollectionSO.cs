using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Spawn
{
    [CreateAssetMenu(fileName = "Spawn_Collection", menuName = "Scriptable Objects/Spawn/Spawn Collection", order = 0)]
    public class SpawnCollectionSO : ScriptableObject
    {
        public List<SpawnableGroupSO> groups = new List<SpawnableGroupSO>();
    }
}