using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class MenuAdministratora : Form
    {
        public MenuAdministratora()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.DateTime date1 = new System.DateTime(2022, 6, 20);// показывает 03.06.1996 22:15:00
            System.TimeSpan diff1 = date1 - DateTime.Now;
            DateTime rel = new DateTime(diff1.Ticks);
            Time.Text = string.Format("До начала события осталось {0} лет, {1} месяцев, {2} дней, {3} часов, {4} минут, {5} секунд", rel.Year - 1, rel.Month - 1, rel.Day - 1, rel.Hour, rel.Minute, rel.Second);

        }
    }
}
