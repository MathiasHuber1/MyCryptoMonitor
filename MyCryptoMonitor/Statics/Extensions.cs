﻿using System;

namespace MyCryptoMonitor.Statics
{
    public static class Extensions
    {
        public static decimal ConvertToDecimal(this string source)
        {
            if (string.IsNullOrWhiteSpace(source))
                return 0;

            decimal.TryParse(source, System.Globalization.NumberStyles.Float, null, out var result);
            return result;
        }

        public static int ConvertToInt(this string source)
        {
            if (string.IsNullOrWhiteSpace(source))
                return 0;

            Int32.TryParse(source, System.Globalization.NumberStyles.Integer, null, out var result);
            return result;
        }

        public static string ConvertToString(this decimal source, int maxDecimalPlaces)
        {
            var index = source.ToString().IndexOf(".");
            var places = source.ToString().Substring(index + 1).Length;

            if (places > maxDecimalPlaces)
                return Decimal.Round(source, maxDecimalPlaces).ToString();

            if (places < 2 || index == -1)
                return Decimal.Round(source, 2).ToString("0.00");

            return Decimal.Round(source, places).ToString();
        }

        public static bool ExtEquals(this string source, string toCheck) => source?.Equals(toCheck, StringComparison.OrdinalIgnoreCase) ?? false;

        public static decimal SafeDivision(this decimal source, decimal numerator) => source == 0 ? 0 : numerator / source;
    }
}