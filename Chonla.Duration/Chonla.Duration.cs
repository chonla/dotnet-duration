using System;
using System.Text.RegularExpressions;

namespace Chonla.Duration
{
    public class Duration
    {
        public TimeSpan Parse(string value) {
            string pattern = @"^(-?\d+)(.+)$";
            Match match = Regex.Match(value, pattern);
            int dur = 0;
            if (match.Success) {
                if (!int.TryParse(match.Groups[1].Value, out dur)) {
                    dur = 0;
                }
                switch (match.Groups[2].Value) {
                    case "ms":
                        return TimeSpan.FromMilliseconds(dur);
                    case "s":
                        return TimeSpan.FromSeconds(dur);
                    case "m":
                        return TimeSpan.FromMinutes(dur);
                    case "h":
                        return TimeSpan.FromHours(dur);
                    case "d":
                        return TimeSpan.FromDays(dur);
                }
            } 
            return TimeSpan.FromMilliseconds(0);
        }
    }
}
