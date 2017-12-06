using CppeDb.DataAccess.Models;
using System.Collections.Generic;

namespace PfmFacadeApi.Data
{
    public class DataSources
    {
        public List<ForecastWellRisk> ForecastWellRisks { get; set; }

        private static DataSources instance = null;

        public static DataSources Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataSources();
                }
                return instance;
            }
        }

        private DataSources()
        {
            Reset();
            Initialize();
        }

        public void Reset()
        {
            ForecastWellRisks = new List<ForecastWellRisk>();
        }

        public void Initialize()
        {
            ForecastWellRisks.AddRange(
                new List<ForecastWellRisk>
                {
                    new ForecastWellRisk
                    {
                        ScenarioWellId = 1,
                        ForecastWellRiskId = 1,
                        Oil = 100,
                        Gas = 200
                    }
                }
            );
        }
    }
}