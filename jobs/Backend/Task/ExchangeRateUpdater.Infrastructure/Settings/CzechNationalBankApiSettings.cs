﻿namespace ExchangeRateUpdater.Infrastructure.Settings
{
    internal class CzechNationalBankApiSettings
    {
        public string BaseUrl { get; set; }

        public int TimeoutSec { get; set; }

        public int RetryCount { get; set; }

        public TimeSpan NewExchangeRatesAt { get; set; }
    }
}