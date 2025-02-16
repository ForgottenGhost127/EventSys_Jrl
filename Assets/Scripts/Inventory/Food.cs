using System;
using UnityEngine;

namespace Inventory
{
    public interface IConsumable { }

    [Serializable]
    public class Food : Items, IUsable, ISellable
    {
        #region Properties
        [field: SerializeField] public float HealPoints { get; set; }
        [field: SerializeField] public float Price { get; set; }

        public float Sell()
        {
            Debug.Log("Has conseguido " + Price + "$!");
            return Price;
        }

        public void Use()
        {
            Debug.Log("Has consumido " + Name + " y has ganado " + HealPoints + " de vida!");
        }
        #endregion

    }
}