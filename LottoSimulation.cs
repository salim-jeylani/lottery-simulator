using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class LottoProgram : Form
    {
        private int fiveMatches;
        private int sixMatches;
        private int sevenMatches;
        private Random random;
        HashSet<int> pickedNumbers = new HashSet<int>();


        public LottoProgram()
        {
            InitializeComponent();
            random = new Random();
            pickedNumbers = new HashSet<int>();
            fiveMatches = 0;
            sixMatches = 0;
            sevenMatches = 0;
        }

        private void LottoProgram_Load(object sender, EventArgs e)
        {
            row1.Value = random.Next(1, 36);
            row2.Value = random.Next(1, 36);
            row3.Value = random.Next(1, 36);
            row4.Value = random.Next(1, 36);
            row5.Value = random.Next(1, 36);
            row6.Value = random.Next(1, 36);
            row7.Value = random.Next(1, 36);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            pickedNumbers.Clear();
            pickedNumbers.Add((int)row1.Value);
            if (!pickedNumbers.Add((int)row2.Value)) { MessageBox.Show("Rad 2 är en dubblett!"); return; }
            if (!pickedNumbers.Add((int)row3.Value)) { MessageBox.Show("Rad 3 är en dubblett!"); return; }
            if (!pickedNumbers.Add((int)row4.Value)) { MessageBox.Show("Rad 4 är en dubblett!"); return; }
            if (!pickedNumbers.Add((int)row5.Value)) { MessageBox.Show("Rad 5 är en dubblett!"); return; }
            if (!pickedNumbers.Add((int)row6.Value)) { MessageBox.Show("Rad 6 är en dubblett!"); return; }
            if (!pickedNumbers.Add((int)row7.Value)) { MessageBox.Show("Rad 7 är en dubblett!"); return; }



            for (int i = 0; i < (int)turns.Value; i++)
            {
                SimulateLotto();
            }

            five.Text = fiveMatches.ToString();
            six.Text = sixMatches.ToString();
            seven.Text = sevenMatches.ToString();

            fiveMatches = 0;
            sixMatches = 0;
            sevenMatches = 0;

            

        }

        private void SimulateLotto()
        {
            int[] lottoNumbers = new int[] { 
                random.Next(1, 36), 
                random.Next(1, 36), 
                random.Next(1, 36), 
                random.Next(1, 36), 
                random.Next(1, 36), 
                random.Next(1, 36), 
                random.Next(1, 36) 
            };
            int matches = pickedNumbers.Intersect(lottoNumbers).Count();
            if (matches == 5)
                fiveMatches++;
            else if (matches == 6)
                sixMatches++;
            else if (matches == 7)
                sevenMatches++;
        }

       
    }
}
