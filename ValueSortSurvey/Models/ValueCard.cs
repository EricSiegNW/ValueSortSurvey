using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValueSortSurvey.Models {
    public class ValueCard {
        [Key]
        public int ValueCardId { get; set; }
        public string Name { get; set; }
        public string Tooltip { get; set; }
    }
}