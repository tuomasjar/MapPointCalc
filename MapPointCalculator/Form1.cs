namespace MapPointCalculator {
    public partial class v : Form {
        public Graphics g;
        public Graphics g2;
        Pen p = new Pen(Color.Red, 5);
        Pen playerPen = new Pen(Color.Red,3);
        Point mousePos = new Point();
        MapLogic mapLogic;
        bool drawing;
        City Origin;
        City Destination;
        List<Connection> connections = new List<Connection>();
        List<Player> players = new List<Player>();
        Player currentPlayer;
        public v() {
            mapLogic = new MapLogic();
            InitializeComponent();
            g = panel1.CreateGraphics();
            for (int i = 0; i < 5; i++) {
                players.Add(new Player(i));
            }
            currentPlayer = players[0];
            playerPen = new Pen(currentPlayer.color, 3);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            Origin = mapLogic.getNearestCity(e.X, e.Y);
            drawing = true;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (drawing) {
                panel1.Invalidate();
                g.DrawLine(playerPen, Origin.x, Origin.y, e.X, e.Y);
                mousePos.X = e.X;
                mousePos.Y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) {
            Destination = mapLogic.getNearestCity(e.X, e.Y);
            if(Origin == Destination) {
                drawing= false;
                panel1.Invalidate();
                return;
            }
            drawing = false;
            Connection build = mapLogic.getConnection(Origin,Destination);
            if(build == null) {
                drawing=false;
                panel1.Invalidate();
                return;
            }
            if (build.lenght > currentPlayer.trains) {
                drawing = false;
                panel1.Invalidate();
                return;
            }
            if(build.color1 == currentPlayer.color) {
                drawing = false;
                panel1.Invalidate();
                return;
            }
            if(!build.build1) {
                build.color1 = currentPlayer.color;
                build.build1 = true;
                currentPlayer.addPoint(build.lenght);
            }else if(build.color2 != null && !build.build2) {
                build.color2 = currentPlayer.color;
                build.build2 = true;
                currentPlayer.addPoint(build.lenght);
            }
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
            foreach (Connection connection in mapLogic.connections) {
                Color color1 = Color.Gray;
                Color color2 = Color.Gray;
                if (connection.color1 != null) color1 = (Color)connection.color1;
                if (connection.color2 != null) color2 = (Color)connection.color2;
                g.DrawLine(new Pen(color1, 3), connection.origin.x, connection.origin.y, connection.destination.x, connection.destination.y);
                if(connection.color2!=null)g.DrawLine(new Pen(color2, 3), connection.origin.x -7, connection.origin.y + 7, connection.destination.x - 7, connection.destination.y + 7);
            }
            foreach (City city in mapLogic.cities) {
                g.FillEllipse(new SolidBrush(Color.Red), city.x-10, city.y-10, 20, 20);
                g.DrawString(city.name,new Font("Arial",10),new SolidBrush(Color.Black),city.x-20, city.y-20);
            }
            if (drawing) {
                g.DrawLine(playerPen, Origin.x, Origin.y, mousePos.X, mousePos.Y);
            }

            lblBlue.Text = players[0].points.ToString();
            lblRed.Text = players[1].points.ToString();
            lblGreen.Text = players[2].points.ToString();
            lblYellow.Text= players[3].points.ToString();
            lblBlack.Text= players[4].points.ToString();

            lblTrainBlue.Text = players[0].trains.ToString();
            lblTrainRed.Text = players[1].trains.ToString();
            lblTrainGreen.Text = players[2].trains.ToString();
            lblTrainYellow.Text = players[3].trains.ToString();
            lblTrainBlack.Text = players[4].trains.ToString();

        }

        private void btnBlue_Click(object sender, EventArgs e) {
            currentPlayer = players[0];
            playerPen = new Pen(currentPlayer.color, 3);
        }

        private void btnRed_Click(object sender, EventArgs e) {
            currentPlayer = players[1];
            playerPen = new Pen(currentPlayer.color, 3);
        }

        private void btnGreen_Click(object sender, EventArgs e) {
            currentPlayer = players[2];
            playerPen = new Pen(currentPlayer.color, 3);
        }

        private void btnYellow_Click(object sender, EventArgs e) {
            currentPlayer = players[3];
            playerPen = new Pen(currentPlayer.color, 3);
        }

        private void btnBlack_Click(object sender, EventArgs e) {
            currentPlayer = players[4];
            playerPen = new Pen(currentPlayer.color, 3);
        }

        private void btnReset_Click(object sender, EventArgs e) {
            mapLogic = new MapLogic();
            foreach(Player player in players) {
                player.points = 0;
                player.trains = 45;
            }
            panel1.Invalidate();
        }
    }
}