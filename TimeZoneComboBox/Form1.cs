using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZoneComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


           // timeZoneCombo1.TimeZone = TimeZoneInfo.Local.Id.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(timeZoneCombo1.TimeZone);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //timeZoneCombo1.changeTimeZone("Alaskan Standard Time");
            timeZoneCombo1.TimeZone = "Alaskan Standard Time";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            timeZoneCombo1.TimeZone = TimeZoneInfo.Local.Id.ToString();
        }
    }
}
