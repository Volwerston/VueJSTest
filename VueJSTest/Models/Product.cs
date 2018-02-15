﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VueJSTest.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                     Id = 1,
                     Name = "Spaghetti",
                     Price = 19.75M
                },
                new Product()
                {
                     Id = 2,
                     Name = "Umbrella",
                     Price = 75.50M
                },
                new Product()
                {
                     Id = 3,
                     Name = "Sofa",
                     Price = 1215.00M
                }
            };
        }
    }
}