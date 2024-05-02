﻿namespace RapidApiNewProject.Models
{
    public class ExchangeViewModel
    {
        public Data data { get; set; }
        public class Data
        {
            public string base_currency_date { get; set; }
            public Exchange_Rates[] exchange_rates { get; set; }
            public string base_currency { get; set; }
        }

        public class Exchange_Rates
        {
            public string exchange_rate_buy { get; set; }
            public string currency { get; set; }
        }

    }
}