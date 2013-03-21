using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ValueSortSurvey.Models;

namespace ValueSortSurvey.DataLayer {
    public class SurveyContextInitializer : DropCreateDatabaseIfModelChanges<SurveyContext> {
        protected override void Seed(SurveyContext context) {
            List<ValueCard> values = new List<ValueCard>() {
                new ValueCard { Name="Acceptance", Tooltip="to be accepted as I am" },
                new ValueCard { Name="Accuracy", Tooltip="to be accurate in my opinions and beliefs" },
                new ValueCard { Name="Achievement", Tooltip="to have important accomplishments" },
                new ValueCard { Name="Adventure", Tooltip="to have new and exciting experiences" },
                new ValueCard { Name="Attractiveness", Tooltip="to be physically attractive" },
                new ValueCard { Name="Authority", Tooltip="to be in charge of and responsible for others" },
                new ValueCard { Name="Autonomy", Tooltip="to be self-determined and independent" },
                new ValueCard { Name="Beauty", Tooltip="to appreciate beauty around me" },
                new ValueCard { Name="Caring", Tooltip="to take care of others" },
                new ValueCard { Name="Comfort", Tooltip="to have a pleasant and comfortable life" },
                new ValueCard { Name="Commitment", Tooltip="to make enduring, meaningful commitments" },
                new ValueCard { Name="Compassion", Tooltip="to feel and act on concern for others" }
            };
            foreach (ValueCard value in values) {
                context.ValueCards.Add(value);
            }
            context.SaveChanges();
        }
    }
}