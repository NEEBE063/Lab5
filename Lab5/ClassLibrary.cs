using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Bicycle
    {
        public string Model { get; set; }
        public string Frame { get; set; }
        public int Broadcast { get; set; }
        public string Fork { get; set; }
        public string Handlebars { get; set; }
        public bool Ring { get; set; }
        public bool Has3Wheels { get; set; }

        public int Cost()
        {
            return Broadcast * 1 / 2 * 100;
        }

        public int Value
        {
            get { return Cost(); }
            set { }
        }
        public Bicycle()
        {
        }

        public Bicycle(string model, string frame, int broadcast, string fork, string handlebars, bool ring, bool has3Wheels)
        {
            Model = model;
            Frame = frame;
            Broadcast = broadcast;
            Fork = fork;
            Handlebars = handlebars;
            Ring = ring;
            Has3Wheels = has3Wheels;
        }
    }      
}
