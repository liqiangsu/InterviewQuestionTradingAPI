using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewQuestionTradingAPI
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Rounding down a datetime into the nearest giving interval
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public static DateTime RoundDown(this DateTime dateTime, TimeSpan interval)
        {
            var delta = dateTime.Ticks % interval.Ticks;
            return new DateTime(dateTime.Ticks - delta, dateTime.Kind);
        }
    }
}
