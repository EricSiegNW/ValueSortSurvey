using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ValueSortSurvey.DataLayer;
using ValueSortSurvey.Models;
using ValueSortSurvey.ViewModels;

namespace ValueSortSurvey.Services {
    public class DbInitSurveyHandler : ISurveyHandler {

        private SurveyContext _context;

        public DbInitSurveyHandler() {
            _context = new SurveyContext();
        }

        public SurveyViewModel PopulateInitialSurvey(string userId) {
            SurveyViewModel result = new SurveyViewModel();
            result.AllValues = new Dictionary<string, string>();
            result.MinSelectedItems = 7;
            result.MaxSelectedItems = 30;
            List<ValueCard> cards = (from vc in _context.ValueCards
                                     select vc).ToList();
            foreach (var card in cards) {
                result.AllValues.Add(card.Name, card.Tooltip);
            }
            return result;
        }

        public SurveyViewModel PopulateContinuingSurvey(string userId, List<string> options) {
            return new SurveyViewModel();
        }

    }
}