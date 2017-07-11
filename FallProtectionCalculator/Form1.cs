using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallProtectionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VarsOfCalc vrs = new VarsOfCalc();
        }

        private void ReqFallDist_TextChanged(object sender, EventArgs e)
        {

        }

        private void LanyardLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void DecelDist_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkerHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void SftyFct_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DD = Convert.ToInt32(DecelDist.Text);
            int WH = Convert.ToInt32(WorkerHeight.Text);
            int SF = Convert.ToInt32(SftyFct.Text);


            if (ReqFallDist == null && LanyardLength == null)
            {
                MessageBox.Show("No Numbers Entered, Please enter values into the text boxes in feet");
            }
            else if (String.IsNullOrEmpty(ReqFallDist.Text))
            {
                int LL = Convert.ToInt32(LanyardLength.Text);
                
                CalcFallDist(LL, DD, WH, SF);
                ReqFallDist.Text = CalcFallDist(LL, DD, WH, SF).ToString() + " Feet";
                ReqFallDist.ForeColor = System.Drawing.Color.Red;
            }
            else if (String.IsNullOrEmpty(LanyardLength.Text))
            {
                int RFD = Convert.ToInt32(ReqFallDist.Text);
                CalcLanyardLenght(RFD, DD, WH, SF);
                LanyardLength.Text = CalcLanyardLenght(RFD, DD, WH, SF).ToString() + " Feet Max.";
                LanyardLength.ForeColor = System.Drawing.Color.Red;
            }
            
        }

        VarsOfCalc vrs = new VarsOfCalc();

        public int CalcFallDist(int LL, int DD, int WorkerHeight, int SF)
        {

            int FallDist = LL + DD + WorkerHeight + SF;

            vrs.ReqDist = FallDist;
            return vrs.ReqDist;
        }

        public int CalcLanyardLenght(int RD, int DD, int PersonHeight, int SafFact)
        {
            int LanLeng = RD - DD - PersonHeight - SafFact;
            vrs.ReqLanLeng = LanLeng;
            return vrs.ReqLanLeng;
        }


    }
}

