using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            StartButton.Text = this.Size.Width + " x " + this.Size.Height;
            StartButton.Size = new Size(100, 100);
            //StartButton.Height = 100;
            this.BoxSize = this.Size;

            StartButton.Location = new Point(((this.BoxSize.Width - StartButton.Size.Width) / 2),((this.BoxSize.Height - StartButton.Size.Height) / 2));
            //StartButton.Location = new Point(((this.BoxSize.Width / 2) ), ((this.BoxSize.Height / 2)));
            ReactButton.Hide();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Hide();
            int ReactSize = this.Random.Next(20, 200);
            ReactButton.Size = new Size(ReactSize, ReactSize);
            ReactButton.Location = new Point(this.Random.Next(0, this.BoxSize.Width - ReactSize), this.Random.Next(0, this.BoxSize.Height - ReactSize));
            ReactButton.Show();
        }

        private void ReactButton_Click(object sender, EventArgs e)
        {
            ReactButton.Hide();
            StartButton.Show();
        }
    }
}
