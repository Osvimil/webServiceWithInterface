using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CRUDwithJSON_CLIENT.Models
{
    public class Product
    {

        [Display(Name ="id")]
        public int id
        {
            get;
            set;
        }
        [Display(Name = "name")]
        public string name
        {
            get;
            set;
        }
        [Display(Name = "price")]
        public decimal price
        {
            get;
            set;
        }
        [Display(Name = "quantity")]
        public int quantity
        {
            get;
            set;
        }
    }
}