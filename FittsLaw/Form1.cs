using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;

/* PROGRAMM LOGIC
 * backColor = black
 * StartButton.show, StartButton.click -> Start loop; i=0;
 * While(i<=20) {
 *  StartButton.hide
 *  Timer.start
 *  ReactButton.show (random size and pos)
 *  ReactButton.click -> Timer.stop
 *  ReactButton.hide
 *  StartButton.show
 *  StartButton.click -> i++
 * }

*/

namespace FittsLaw
{
    public partial class FittsBox : Form
    {

        private Size BoxSize;
        private Random Random;
        private int TrialNumber = 1;
        private TrialData CurrentTrial;
        private List<TrialData> FullTrial = new List<TrialData>();
        private Stopwatch stopwatch = new Stopwatch();


        public FittsBox()
        {
            InitializeComponent();
            this.BackColor = Color.Gray;
            this.HelpButton = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.BackColor = Color.Red;

            ReactButton.FlatStyle = FlatStyle.Flat;
            ReactButton.BackColor = Color.Green;
            ReactButton.ForeColor = ReactButton.BackColor;
            ReactButton.Text = "nice";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Random = new Random();
            //StartButton.Text = this.Size.Width + " x " + this.Size.Height;
            StartButton.Size = new Size(100, 100);
            this.BoxSize = this.Size;
            StartButton.Location = new Point(((this.BoxSize.Width - StartButton.Size.Width) / 2),((this.BoxSize.Height - StartButton.Size.Height) / 2));
            ReactButton.Hide();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Start dus weer nieuwe trial
            StartButton.Text = this.TrialNumber + "/20";
            if (this.TrialNumber <= 20)
            {
                StartButton.Hide();


                int ReactSize = this.Random.Next(20, 200);
                ReactButton.Size = new Size(ReactSize, ReactSize);
                ReactButton.Location = new Point(this.Random.Next(0, this.BoxSize.Width - ReactSize), this.Random.Next(0, this.BoxSize.Height - ReactSize));
                Point MousePosition = Control.MousePosition;
                Console.WriteLine(MousePosition.ToString());

                double Distance = this.CalculateDistance(MousePosition, ReactButton.Location, ReactSize / 2);
                this.TrialNumber = this.TrialNumber + 1;
                this.CurrentTrial = new TrialData
                {
                    TrialNumber = this.TrialNumber,
                    D = Distance,
                    W = ReactSize,
                    ID = Math.Log(1 + Distance / ReactSize, 2),
                };

                ReactButton.Show();
                //start timer
                stopwatch.Start();
            }
            else 
            {
                Console.WriteLine("Test results are in!!");
                foreach (TrialData Trial in this.FullTrial)
                {
                    Console.WriteLine("D: " + Trial.D + " W: " + Trial.W + " ID: " + Trial.ID + " T: " + Trial.T);
                }
                Console.WriteLine("Done!!");
            }
        }

        private void ReactButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            long ElapsedTime = stopwatch.ElapsedMilliseconds;

            this.CurrentTrial.T = ElapsedTime;
            this.FullTrial.Add(this.CurrentTrial);
            ReactButton.Hide();
            StartButton.Show();
            Console.WriteLine(this.CurrentTrial.ID);
        }

        private double CalculateDistance(Point MousePosition, Point ReactPos, int Radius) 
        {
            double CurrentX = MousePosition.X; //BoxSize.Width / 2;
            double CurrentY = MousePosition.Y; //BoxSize.Height / 2

            double Distance = Math.Sqrt(Math.Pow(((double)(ReactPos.X - CurrentX)) , 2.0) + Math.Pow(((double)(ReactPos.Y - CurrentY)), 2.0));

            return Distance - (double)Radius;
        }

    }

    public class TrialData
    {
        public int TrialNumber { get; set; }
        public double D { get; set; } //Distance van Mouse naar center ReactKnop, +/- ReactKnop.width
        public double W { get; set; } //Width van ReactKnop
        public double ID { get; set; }
        public long T { get; set; } // Time between clicks
    }

}
