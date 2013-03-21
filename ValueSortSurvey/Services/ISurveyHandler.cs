using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ValueSortSurvey.ViewModels;

namespace ValueSortSurvey.Services {
    interface ISurveyHandler {
        SurveyViewModel PopulateInitialSurvey(string userId);
        SurveyViewModel PopulateContinuingSurvey(string userId, List<string> options);
    }
}