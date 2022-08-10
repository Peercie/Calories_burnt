//35244119, van der Merwe, P.R
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_burnt
{
    public partial class frmMain : Form
    {
        const double CYCLING = 1.0;
        const double RUNNING = 1.2;
        const double ROWING = 1.5;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstbxOutput.Items.Add("Minutes" + "\t" + "Calories burned");
        }

        private void btnCalories_Click(object sender, EventArgs e)
        {
            int minutes;
            double weight, calories, total;
            weight = double.Parse(txtbxWeight.Text);
            minutes = 0;
            total=0;
            for (int i = 1; i < 6; i++)
            {
                minutes += 10;
                if (rbtnCycling.Checked)
                {
                    calories = weight * CYCLING;
                    total = calories * i;
                }
                else if (rbtnRunning.Checked)
                {
                    calories = weight * RUNNING;
                    total = calories * i;
                }
                else if (rbtnRowing.Checked)
                {
                    calories = weight * ROWING;
                    total = calories * i;
                }
                else
                {
                    MessageBox.Show("Choose an exercise");
                }

                lstbxOutput.Items.Add(minutes +"\t"+Math.Round(total,0));
               
            }
            lstbxOutput.Items.Add("");
        }

        private void frmMain_LocationChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
