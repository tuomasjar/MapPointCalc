using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapPointCalculator {
   
    internal class MapLogic {
        public List<Connection> connections;
        public List<City> cities;
        public MapLogic() {
            connections = new List<Connection>();
            cities = new List<City>();
            try {
                using (StreamReader inputFile = File.OpenText("Cities.txt")) {
                    while (!inputFile.EndOfStream) {
                        string inputLine = inputFile.ReadLine();
                        string[] parts = inputLine.Split(",");

                        int x = Convert.ToInt32(parts[1]);
                        int y = Convert.ToInt32(parts[2]);
                        City city = new City(x, y, parts[0]);
                        cities.Add(city);
                    }
                }
            }catch(Exception e) {
                MessageBox.Show(e.Message);
            }
            try {
                using (StreamReader inputFile = File.OpenText("Connections.txt")) {
                    while (!inputFile.EndOfStream) {
                        string inputLine = inputFile.ReadLine();
                        string[] parts = inputLine.Split(",");
                        City Origin = getCityFromString(parts[0]);
                        City Dest = getCityFromString(parts[1]);
                        int length = Convert.ToInt32(parts[2]);
                        Color? color1 = getColorFromString(parts[3]);
                        Color? color2 = getColorFromString(parts[4]);
                        Connection connect = new Connection(Origin, Dest, length, color1, color2);
                        connections.Add(connect);
                    }
                }
            }catch(Exception e) {
                MessageBox.Show(e.Message);
            }
        }


        public City getCityFromString(string str) {
            foreach(City city in cities) {
                if(city.name==str) return city;
            }
            return null;
        }

        public City getNearestCity(int x,int y) {
            City nearest = null;
            int minLength = Int32.MaxValue;
            foreach(City city in cities) {
                if (city.getDistance(x, y) < minLength) {
                    nearest = city;
                    minLength = city.getDistance(x, y);
                }
            }
            return nearest;
        }

        public Connection getConnection(City a, City b) {
            foreach(Connection conn in connections) {
                if((conn.origin == a && conn.destination == b) || (conn.destination == a && conn.origin == b)){
                    return conn;
                }
            }
            return null;
        }

        public Color? getColorFromString(string str) {
            int alpha = 50;
            switch (str.Trim()) {
                case "Red":
                    return Color.FromArgb(alpha, Color.Red);
                case "Black":
                    return Color.FromArgb(alpha, Color.Black);
                case "Blue":
                    return Color.FromArgb(alpha, Color.Blue);
                case "Green":
                    return Color.FromArgb(alpha, Color.Green);
                case "Purple":
                    return Color.FromArgb(alpha, Color.Purple);
                case "Orange":
                    return Color.FromArgb(alpha, Color.Orange);
                case "White":
                    return Color.FromArgb(alpha, Color.White);
                case "Yellow":
                    return Color.FromArgb(alpha, Color.Yellow);
                case "Gray":
                    return Color.FromArgb(alpha, Color.Gray);
                case "null":
                    return null;
                default:
                    throw new ArgumentOutOfRangeException(str);
            }
        }

        public int trainsToPoints(int trains) {
            switch(trains) {
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
