using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UBERPOINTERIZER
{
    public class Cab
    {
        public String cabIdentifier;
        public List<Double> lat;
        public List<Double> lon;
        public List<int> updateType;
        public List<float> heading;
        public List<long> epoch;

        public Cab()
        {
            lat = new List<Double>();
            lon = new List<Double>();
            updateType = new List<int>();
            heading = new List<float>();
            epoch = new List<long>();
        }
    }
}
