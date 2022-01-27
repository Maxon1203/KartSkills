using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class MenuAvtorizacii : Form
    {
        public MenuAvtorizacii()
        {
            InitializeComponent();
            timer1.Start();
        }
        public string constr = @"Data Source=DESKTOP-HAMFGR7\GATSKANMAX;Initial Catalog = KartSkills; Integrated Security = True";
        private void timer1_Tick(object sender, EventArgs e)
        {
            System.DateTime date1 = new System.DateTime(2022, 6, 20);// показывает 03.06.1996 22:15:00
            System.TimeSpan diff1 = date1 - DateTime.Now;
            DateTime rel = new DateTime(diff1.Ticks);
            Time.Text = string.Format("До начала события осталось {0} лет, {1} месяцев, {2} дней, {3} часов, {4} минут, {5} секунд", rel.Year - 1, rel.Month - 1, rel.Day - 1, rel.Hour, rel.Minute, rel.Second);

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.constr);

            try
            {
                connection.Open();

                SqlDataAdapter adapterEamil = new SqlDataAdapter($"SELECT [User].Email FROM [User] WHERE Email='{tbEmail.Text}'", connection);
                DataSet dataset = new DataSet();
                adapterEamil.Fill(dataset);
                SqlDataAdapter adapterPass = new SqlDataAdapter($"SELECT [User].Password FROM [User] WHERE Password ='{tbParoll.Text}'", connection);
                DataSet datasetPass = new DataSet();
                adapterPass.Fill(datasetPass);
                SqlDataAdapter adapterRole = new SqlDataAdapter($"SELECT [User].ID_Role FROM [User] WHERE Email ='{tbEmail.Text}'", connection);
                DataSet datasetRole = new DataSet();
                adapterRole.Fill(datasetRole);

                List<String> massRole = new List<String>();
                List<String> massPass = new List<String>();
                List<String> massEmail = new List<String>();
                foreach (DataRow row in datasetRole.Tables[0].Rows)
                {
                    massRole.Add(row.Field<string>("ID_Role"));
                }
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    massEmail.Add(row.Field<string>("Email"));
                }
                foreach (DataRow row in datasetPass.Tables[0].Rows)
                {
                    massPass.Add(row.Field<string>("Password"));
                }
                if (massEmail[0] == tbEmail.Text && massPass[0] == tbParoll.Text)
                {
                    if (massRole[0] == "R")
                    {
                        MenuGonshika form = new MenuGonshika();

                        // EditRunnerProfile email = new EditRunnerProfile();
                        //EmailUser.Email = textBoxEmail.Text;
                        // form.labelEmail.Text = textBoxEmail.Text;
                        form.Show();
                        //   Close();
                        // email.Show();
                    }
                    if (massRole[0] == "A")
                    {
                        MenuGonshika form = new MenuGonshika();
                        // AdminestratorMenu form = new AdminestratorMenu();
                        //  EmailUser.Email = textBoxEmail.Text;
                        form.Show();
                        Close();
                    }
                    if (massRole[0] == "C")
                    {
                        MenuGonshika form = new MenuGonshika();
                      //  CordinatorMenu form = new CordinatorMenu();
                     //   EmailUser.Email = textBoxEmail.Text;
                        form.Show();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("НеРаботает");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте данные");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
