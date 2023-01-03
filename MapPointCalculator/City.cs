using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MapPointCalculator {
    internal class City {
        public int x { get; } 
        public int y { get; }
        public string name { get; }
        
        public List<Connection> connections { get; }
        public City(int x, int y, string name) {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public int getDistance(int clickX, int clickY) {
            return (int)Math.Sqrt(Math.Pow(clickX - x, 2) + Math.Pow(clickY - y, 2));
        }

        public static bool operator == (City a , City b) {
            if(a.name ==  b.name) {
                return true;
            }
            return false;
        }

        public static bool operator !=(City a, City b) {
            if (a.name == b.name) {
                return false;
            }
            return true;
        }

    }
}
