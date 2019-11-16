using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZoneComboBox
{
    public partial class TimeZoneCombo : UserControl
    {
        
        public TimeZoneCombo()
        {
            InitializeComponent();
        }

        private void TimeZoneCombo_Load(object sender, EventArgs e)
        {

            lstTimezones.DataSource = TimeZoneInfo.GetSystemTimeZones();
            lstTimezones.DisplayMember = "DisplayName";
            lstTimezones.ValueMember = "Id";

            lstTimezones.SelectedValue = TimeZoneInfo.Local.Id;
            
        }

        public string TimeZone { 
            get {
                return (lstTimezones.SelectedValue != null) ? lstTimezones.SelectedValue.ToString() : null ;                
            }
            set
            {
                if (value != null)
                {
                    lstTimezones.SelectedValue = value;
                }
            }
        }

        private void lstTimezones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
