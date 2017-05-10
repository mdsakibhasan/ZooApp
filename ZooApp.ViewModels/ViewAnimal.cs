﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;

namespace ZooApp.ViewModels
{
    public class ViewAnimal
    {
        public ViewAnimal(Animal animal)
        {
            Id = animal.Id;
            Name = animal.Name;
            Quantity = animal.Quantity;
            Origin = animal.Origin;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public int Quantity { get; set; }
    }
}
