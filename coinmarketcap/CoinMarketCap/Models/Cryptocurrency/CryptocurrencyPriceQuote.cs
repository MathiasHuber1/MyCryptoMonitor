﻿using System;
using Newtonsoft.Json;

namespace CoinMarketCap.Models.Cryptocurrency
{
    public class CryptocurrencyPriceQuote
    {
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("volume_24h")]
        public long? Volume24H { get; set; }

        [JsonProperty("percent_change_1h")]
        public decimal? PercentChange1H { get; set; }

        [JsonProperty("percent_change_24h")]
        public decimal? PercentChange24H { get; set; }

        [JsonProperty("percent_change_7d")]
        public decimal? PercentChange7D { get; set; }

        [JsonProperty("market_cap")]
        public long? MarketCap { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset? LastUpdated { get; set; }
    }
}