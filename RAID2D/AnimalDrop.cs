﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAID2D.Resources
{
    internal class AnimalDrop
    {
        public string name { get; set; }
        public int healthSize { get; set; }
        public Image image { get; set; }
        public int spawnChance { get; set; }
        public AnimalDrop(string name, int value, int spawnChance, Image image)
        {
            this.name = name;
            this.healthSize = value;
            this.image = image;
            this.spawnChance = spawnChance;
        }
    }
}
