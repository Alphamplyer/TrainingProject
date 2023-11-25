using UnityEngine;

namespace ScriptableObjects.Buildings
{
    [CreateAssetMenu(fileName = "Building", menuName = "Scriptable Objects/Buildings/Basic Building", order = 0)]
    public class BaseBuildingSO : ScriptableObject
    {
        public int id;
        public string displayName;
        
        public int healthPoints;
        
        public GameObject prefab;
    }
}