using UnityEngine;

namespace ScriptableObjects.Units
{
    [CreateAssetMenu(fileName = "Unit", menuName = "Scriptable Objects/Units/Basic Unit", order = 0)]
    public class UnitSO : ScriptableObject
    {
        public int id;
        public string displayName;
        
        public int healthPoints;
        
        public int damage;
        public float attackRange;
        public float attackSpeed;
        
        public float baseSpeed;
        
        public GameObject prefab;
    }
}