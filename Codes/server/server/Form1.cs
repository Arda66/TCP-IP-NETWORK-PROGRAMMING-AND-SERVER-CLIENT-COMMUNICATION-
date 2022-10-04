using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

                         // Arda Dumanoğlu 190315072
namespace server
{
    public partial class Form1 : Form
    {
        public  Socket server;
        private byte[] data = new byte[10];
        private static int squareRoot = 15; // flag'ların etrafında 15 x 15 'lik bir alan belirliyor
        private int areaSize = squareRoot * 2;
        private int fCounter = 0;
        private Boolean attackTurn = false;
        private string enemyAttackResult;
        private int destroyedFlags = 0;
        private int maxAreaCount = 5; //başlangıçta maksimum seçilebilecek alan sayısı
        private Boolean areaChooseMode = true;
        private List<int> coordinates = new List<int>();
        private List<List<string>> AREAS = new List<List<string>>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Server - Player 2";
            Control.CheckForIllegalCrossThreadCalls = false;
            
            attackButton.Click += new EventHandler(attackButton_click);
            attackCoords.Click += new EventHandler(coor_In);

            attackButton.Enabled = false;
            attackCoords.Enabled = false;

        }

        private void attackButton_click(object sender, EventArgs e)
        {
            byte[] message = Encoding.ASCII.GetBytes(attackCoords.Text);
            attackCoords.Clear();
            ENEMY_RESULT.Text = "";
            server.BeginSend(message, 0, message.Length, 0,
            new AsyncCallback(sendInfo), server);
        }

        void AcceptConn(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            server = oldserver.EndAccept(iar);
            Console.WriteLine("Connection from: " + server.RemoteEndPoint.ToString());
            Thread receiver = new Thread(new ThreadStart(receiveInfo));
            receiver.Start();
        }
        void Connected(IAsyncResult iar)
        {
            try
            {
                server.EndConnect(iar);
                Console.WriteLine("Connected to: " + server.RemoteEndPoint.ToString());
                Thread receiver = new Thread(new ThreadStart(receiveInfo));
                receiver.Start();
            }
            catch (SocketException)
            {
                Console.WriteLine("Error connecting");
            }
        }

        void sendInfo(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
        }

        private void coor_In(object sender, EventArgs e)
        {
            ENEMY_RESULT.Text = "";
            PLAYER_RESULT.Text = "";
        }

        void receiveInfo()
        {
            int receive = 0;
            string receivedInfo;
            while (true)
            {
                receive = server.Receive(data);
                receivedInfo = Encoding.ASCII.GetString(data, 0, receive);
                enemyAttackResult = receivedInfo;
                Console.WriteLine(enemyAttackResult);

                
                if (receivedInfo == "win")
                {
                    attackTurn = false;

                    attackButton.Enabled = false;

                    attackCoords.Enabled = false;

                    PLAYER_RESULT.Text = " Player 2 Lose !";

                    ENEMY_RESULT.Text = "Player 1 Win !";
                }

               else if (attackTurn)
                {
                    PLAYER_RESULT.Text = "";

                    if (enemyAttackResult != "missed")
                    {
                        destroyedFlags++;

                        PLAYER_RESULT.Text = "Successful Hit!";

                        capturedFlagCount.Text = destroyedFlags + "";

                        if (capturedFlagCount.Text == maxAreaCount + "")
                        {
                            ENEMY_RESULT.Text = "Player 1 Lose !";
                            
                            PLAYER_RESULT.Text = "Player 2 Win !";
                            
                            server.Send(Encoding.ASCII.GetBytes("win"));
                        }
                    }
                    else
                    {
                        PLAYER_RESULT.Text = "Missed!";
                    }

                    attackTurn = false;
                    attackButton.Enabled = false;
                    attackCoords.Enabled = false;
                }
                else
                {
                    isCaptured();
                }
                enemyAttackResult = "";
            }
          
            return;
        }

        private void isCaptured()
        {
            Boolean captured = false, alreadyCaptured = false;
            int flagOrder = -1;
            string flagCoords = "missed";
            for (int flagIndex = 0; flagIndex < AREAS.Count; flagIndex++)
            {
                if (AREAS.ElementAt(flagIndex).Contains(enemyAttackResult))
                {

                    if (!(FLAGS.Items[flagIndex] + "").Contains("Lose"))
                    {
                        captured = true;
                        
                        ENEMY_RESULT.Text = "Successful Hit!";
                      
                        flagOrder = flagIndex;
                        ENEMY_RESULT.Text = "Successful Hit!";
                        
                        flagCoords = FLAGS.Items[flagIndex] + "";

                        FLAGS.Items.RemoveAt(flagIndex);
                        FLAGS.Items.Insert(flagIndex, flagCoords + " - Lose ");
                    }
                }
            }
            if (captured == false && alreadyCaptured == false)
            {
                ENEMY_RESULT.Text = "Missed !";
            }

            server.Send(Encoding.ASCII.GetBytes(flagCoords));
            attackTurn = true;
            attackButton.Enabled = true;
            attackCoords.Enabled = true;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArguments = (MouseEventArgs)e;
            Point coors = mouseEventArguments.Location;
            var MousePos = coors.X + "," + coors.Y;

            if (areaChooseMode)
            {
                fCounter++;
                FLAGS.Items.Add(MousePos);
                var temp = MousePos.Split(',');

                this.coordinates.Add(int.Parse(temp[0]));
                this.coordinates.Add(int.Parse(temp[1]));

                List<string> flag = new List<string>();
                for (int x = this.coordinates.ElementAt(0) - areaSize / 2; x < this.coordinates.ElementAt(0) + areaSize / 2; x++)
                {
                    for (int y = this.coordinates.ElementAt(1) - areaSize / 2; y < this.coordinates.ElementAt(1) + areaSize / 2; y++)
                    {
                        var coord_temp = x + "," + y;
                        flag.Add(coord_temp);
                    }
                }
                AREAS.Add(flag);
                this.coordinates.Clear();
                if (fCounter == maxAreaCount)
                {
                    areaChooseMode = false;

                    attackButton.Enabled = attackTurn;

                    attackCoords.Enabled = attackTurn;

                    for (int i = 0; i < AREAS.Count; i++)
                    {
                        Console.WriteLine((i+1)+". (");
                        for (int j = 0; j < areaSize*areaSize; j++) { 
                            Console.Write(AREAS.ElementAt(i).ElementAt(j) + " - ");
                        }
                        Console.WriteLine(")");
                    }
                }
            }
            else { attackCoords.Text = MousePos; }
        }

        private void listen_Click(object sender, EventArgs e)
        {
            Console.WriteLine("“Listening for a client...”");
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            newsock.Bind(iep);
            newsock.Listen(5);
            newsock.BeginAccept(new AsyncCallback(AcceptConn), newsock);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("“Listening for a client...”");
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            server.Bind(iep);
            server.Listen(5);
            server.BeginAccept(new AsyncCallback(AcceptConn), server);
        }
    }
}