﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        private List<string> _basket;

        public Core()
        {
            _basket = new List<string>();
        }

        public int MaxCapacity { get; set; } = 3;

        public int BasketCapacity { get { return _basket.Count; } } 

        public bool AddBagel(string bagel)
        {
            if(_basket.Contains(bagel)) { 
                return false;
            }else if(BasketCapacity >= MaxCapacity)
            {
                return false;
            }
            else
            {
                _basket.Add(bagel);
                return true;
            }
        }
        /// <summary>
        /// removes the bagel returns true if sucess otherwise false || if bagel doesnt exist returns false
        /// </summary>
        /// <param name="bagel"></param>
        /// <returns></returns>
        public bool RemoveBagelFromBasket(string bagel)
        {
            return _basket.Remove(bagel);
        }

        public List<string> Basket {
            get {
                return _basket;
          }
        }

    }
}
