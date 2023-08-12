using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloj
{
    public class TimeZoneService
    {
        public DateTime obtenerTimeZone(string p_timeZone)
        {
            var timeZone = TimeZoneInfo.FindSystemTimeZoneById(p_timeZone);
            return TimeZoneInfo.ConvertTime(DateTime.Now, timeZone);
        }
    }
}
