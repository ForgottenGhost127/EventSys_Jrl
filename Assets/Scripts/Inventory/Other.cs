using System;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public class Other : Items, ISellable
    {
        [field: SerializeField] public float Price { get; set; }

        public float Sell()
        {
            Debug.Log("Has conseguido " + Price + "$!");
            return Price;
        }

    }
}