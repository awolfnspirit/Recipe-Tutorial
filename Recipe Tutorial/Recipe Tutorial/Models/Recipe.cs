using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeTutorial
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
    }
}
