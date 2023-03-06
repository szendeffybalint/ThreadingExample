using System.ComponentModel;

namespace ThreadingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Init
            _backgroundWorker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            //Add events
            _backgroundWorker.DoWork += backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            btn_do.Click += new EventHandler(btn_do_Click_1);
            btn_stop.Click += new EventHandler(btn_stop_Click_1);
        }
        private readonly BackgroundWorker _backgroundWorker;
        private void Form1_Disposed(object sender, EventArgs e)
        {
            //uninit
            _backgroundWorker.Dispose();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Init Commands
            IDictionary<int, string> Commands = new Dictionary<int, string>();

            Commands.Add(1, "{1}");
            Commands.Add(2, "{2}");
            Commands.Add(3, "{3}");
            Commands.Add(4, "{4}");
            Commands.Add(5, "{5}");
            Commands.Add(6, " ");
            Commands.Add(7, "W");
            Commands.Add(8, "S");

            //w8 at start
            Thread.Sleep(6000);
            var backgroundWorker = (BackgroundWorker)sender;
            int step = 2;
            //while --> true
            for (int i = 0; i < step; i++)
            {
                step++;
                //randomize w8 time too
                Random rnd = new Random();
                int waittime = rnd.Next(1, 10);

                //milisecs
                waittime = waittime * 1000;

                //Stop the whole task
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                //50% to call cmd
                RandomizeCode(getCommand(Commands), waittime);
            }
        }
        /// <summary>
        /// Get the correct command string
        /// </summary>
        /// <param name="commands"></param>
        /// <returns> A random cmd </returns>
        private string getCommand(IDictionary<int, string> commands)
        {
            string cmd = "";
            Random rnd = new Random();
            int nmbr = rnd.Next(1, commands.Count + 1);
            cmd = commands[nmbr];
            return cmd;
        }

        /// <summary>
        /// Random do the command or not
        /// </summary>
        /// <param name="command"> command to do </param>
        /// <param name="waittime"> waittime between steps </param>
        private void RandomizeCode(string command, int waittime)
        {
            Random rnd = new Random();
            int percentage = rnd.Next(1, 101);
            if (percentage < 50) return;
            //do command
            SendKeys.SendWait(command);
            //w8
            Thread.Sleep(waittime);
            if (command == "W")
            {
                SendKeys.SendWait("S");
                SendKeys.SendWait("S");
            }
            else if (command == "S")
            {
                SendKeys.SendWait("S");
                SendKeys.SendWait("W");
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //cancel if stop btn clicked
            if (e.Cancelled)
            {
                btn_do.Visible = true;
                btn_stop.Visible = false;
            }
            //just to check, never been here :D 
            if (e.Error != null)
            {
                MessageBox.Show("Hiba: Totál szar");
            }
        }
        //IF want any stop and continue
        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (!_backgroundWorker.IsBusy)
            {
                _backgroundWorker.RunWorkerAsync();
            }
        }
        //START
        private void btn_do_Click_1(object sender, EventArgs e)
        {
            lb_done.Visible = false;
            btn_do.Visible = false;
            btn_stop.Visible = true;
            if (!_backgroundWorker.IsBusy)
            {
                _backgroundWorker.RunWorkerAsync();
            }
        }
        //STOP
        private void btn_stop_Click_1(object sender, EventArgs e)
        {
            lb_done.Visible = true;
            btn_do.Visible = true;
            btn_stop.Visible = false;
            _backgroundWorker.CancelAsync();
        }
    }
}