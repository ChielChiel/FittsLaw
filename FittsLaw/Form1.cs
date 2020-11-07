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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void ReactButton_Click(object sender, EventArgs e)
        {

        }
    }
}
