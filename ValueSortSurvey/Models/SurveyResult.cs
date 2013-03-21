using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValueSortSurvey.Models {
    public class SurveyResult {
        [Key]
        public int SurveyResultId { get; set; }
        public string UserId { get; set; }
        public string UserIpAddress { get; set; } // Storing this to make it easier to back out someone trying to pollute data. Might not even wire it up though.
        public ValueCard FirstChoice { get; set; }
        public ValueCard SecondChoice;
        public ValueCard ThirdChoice;
        public ValueCard FourthChoice;
        public ValueCard FifthChoice;
        public ValueCard SixthChoice;
        public ValueCard SeventhChoice;
    }
}