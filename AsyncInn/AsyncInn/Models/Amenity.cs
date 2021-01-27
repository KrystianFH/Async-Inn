﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Amenity
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Amenity>().HasData(
         //       new Amenity { ID = 1, Name = "Mini Fridge" },
         //       new Amenity { ID = 2, Name = "Whirlpool Tub" }
         //       );
       // }

    }
}
