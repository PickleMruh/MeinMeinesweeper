using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeinMinesweeper
{
    public partial class MeinMenu : Form
    {
        public MeinMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
        }

        private void PresetEasy_Click(object sender, EventArgs e)
        {
            sizeX.Value = 8;
            sizeY.Value = 8;
            minesNumber.Value = 10;
            isTimeSet.Checked = false;
        }

        private void PresetMedium_Click(object sender, EventArgs e)
        {
            sizeX.Value = 16;
            sizeY.Value = 16;
            minesNumber.Value = 30;
            isTimeSet.Checked = true;
            timeLimit.Value = 10;
        }

        private void PresetHard_Click(object sender, EventArgs e)
        {
            sizeX.Value = 30;
            sizeY.Value = 16;
            minesNumber.Value = 99;
            isTimeSet.Checked = true;
            timeLimit.Value = 10;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isTimeSet.Checked == true)
            {
                timeLimit.Enabled = false;
            }
            else
            {
                timeLimit.Enabled = true;
            }

        }

        private void SizeX_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
