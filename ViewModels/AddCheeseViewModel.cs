﻿using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }

        //CheeseCategory newCheeseCategory = context.Categories;
        //Single(c => c.ID == addCheeseViewModel.CategoryID); 


        public List<SelectListItem> Categories { get; set; }

        public AddCheeseViewModel()
        {
        }

        public AddCheeseViewModel(IEnumerable<CheeseCategory> categories)
        {

            Categories = new List<SelectListItem>();
            foreach (var category in categories)
            {
                Categories.Add(new SelectListItem { Value = category.ID.ToString(), Text = category.Name }); //was category.ToString()
            }
        }
 

        
            
    }
}
