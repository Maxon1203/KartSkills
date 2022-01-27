using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class MenuGonshika : Form
    {
        public MenuGonshika()
        {
            InitializeComponent();
            panelKontakti.Visible = false;
        }

        private void btKontakti_Click(object sender, EventArgs e)
        {
            panelKontakti.Visible = true;
        }

        private void pBZacrit_Click(object sender, EventArgs e)
        {
            panelKontakti.Visible = false;
        }
    }
}
