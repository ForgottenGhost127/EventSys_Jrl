using System;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public class Weapon : Items, IUsable
    {
        #region Properties
        [field: SerializeField] public float Damage { get; set; }
        #endregion

        #region Public Methods
        public void Attack()
        {
            Debug.Log("Do Attack");
        }

        public void Use()
        {
            Attack();
        }
        #endregion

    }
}