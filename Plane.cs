using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Plane
    {
        public string Name;
        public string Country;
        public string Producer;
        public int Seats;
        public double Max_speed;
        public double Time;
        public bool Toilet;
        public bool Duty_free;
        public double GetDistance()
        {
            return Max_speed * Time;
        }
public double Distance
        {
            get
            {
                return GetDistance();
            }
        }
    }
}
