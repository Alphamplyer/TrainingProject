using UnityEngine;

namespace ScriptableObjects.Buildings
{
    [CreateAssetMenu(fileName = "Defensive_Building", menuName = "Scriptable Objects/Buildings/Defensive Building", order = 0)]
    public class DefensiveBuildingSO : BaseBuildingSO
    {
        public int damage;
        public float attackRange;
        public float attackSpeed;
    }
}