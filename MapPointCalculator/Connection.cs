using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapPointCalculator {
    internal class Connection {
        public City origin { get; }
        public City destination { get; }
        public int lenght { get; }

        public Color? color1 { get; set; }
        public Color? color2 { get; set; }

        public bool build1 = false;
        public bool build2 = false;
        public Connection(City origin, City destination, int length,Color? color1, Color? color2) {
            this.origin = origin;
            this.destination = destination;
            this.lenght = length;
            this.color1 = color1;
            this.color2 = color2;
        }
    }
}
