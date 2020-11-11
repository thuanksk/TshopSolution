﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TshopSolution.Data.Entites
{
   public class Language
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
