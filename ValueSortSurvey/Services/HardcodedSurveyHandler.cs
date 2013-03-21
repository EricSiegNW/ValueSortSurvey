using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ValueSortSurvey.ViewModels;

namespace ValueSortSurvey.Services {
    public class HardcodedSurveyHandler : ISurveyHandler {


        public SurveyViewModel PopulateInitialSurvey(string userId) {
            SurveyViewModel result = new SurveyViewModel();
            result.MinSelectedItems = 3;
            result.MaxSelectedItems = 5;
            result.UserID = userId;
            result.AllValues = new Dictionary<string, string>() {
                { "Honesty", "Cool stuff yeah" },
            };
            return result;
        }

        public SurveyViewModel PopulateContinuingSurvey(string userId, List<string> options) {
            SurveyViewModel result = new SurveyViewModel();
            result.MinSelectedItems = 1;
            result.MaxSelectedItems = 2;
            result.UserID = userId;
            result.AllValues = new Dictionary<string, string>();
            return result;
        }
    }
}