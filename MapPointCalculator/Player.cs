using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapPointCalculator {
    internal class Player {
        public Color color;
        public int points { get; set; } = 0;
        public int trains { get; set; } = 45;
        public Player(int nro) {
            switch (nro) {
                case 0:
                    color = Color.Blue; break;
                case 1:
                    color = Color.Red; break;
                case 2:
                    color = Color.Green; break;
                case 3:
                    color = Color.Yellow; break;
                case 4:
                    color = Color.Black; break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        public void addPoint(int trains) {
            this.points += trainsToPoints(trains);
            this.trains -= trains;
        }
        public int trainsToPoints(int trains) {
            switch (trains) {
                case 1: return 1;
                case 2: return 2;
                case 3: return 4;
                case 4: return 7;
                case 5: return 10;
                case 6: return 15;
                default:
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
