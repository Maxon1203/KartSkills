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
    public partial class SpisokOrganizacii : Form
    {
        public SpisokOrganizacii()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void SpisokOrganizacii_Load(object sender, EventArgs e)
        {
            LoadCharity();
        }
        public string constr = @"Data Source=DESKTOP-HAMFGR7\GATSKANMAX;Initial Catalog = KartSkills; Integrated Security = True";
        public int top = 200;
        public void LoadCharity()
        {

            SqlConnection connection = new SqlConnection(this.constr);

            try
            {
                connection.Open();

                SqlDataAdapter adapter1 = new SqlDataAdapter("Select Charity_Name, Charity_Description, Charity_Logo FROM Charity", connection);
                DataSet dataset1 = new DataSet();
                adapter1.Fill(dataset1);
                //  dataGridView1.DataSource = dataset1.Tables[0];
                List<String> MassName = new List<String>();
                List<String> MassDesc = new List<String>();
                List<String> MassLogo = new List<String>();
                foreach (DataRow row in dataset1.Tables[0].Rows)
                {

                    MassName.Add(row.Field<string>("Charity_Name"));
                    MassDesc.Add(row.Field<string>("Charity_Description"));
                    MassLogo.Add(row.Field<string>("Charity_Logo"));
                }
                Image image;
                for (int i = 0; i < MassName.ToArray().Length; i++)
                {
                    //if (dataset1.Tables[0].Rows[i].Field<string>(dataset1.Tables[0].Columns[3]) == "")
                    //{
                        image = Image.FromFile("C:\\Users\\gatsk\\OneDrive\\Рабочий стол\\Митасов\\Сессия 3\\kart-skills-2016-charity-data (логотипы благотворительных)\\marathon-skills-2016-charity-data\\" + MassLogo[i]);

                    //}
                    //else
                    //{
                    //    image = Image.FromFile($@"{dataset1.Tables[0].Rows[i].Field<string>(dataset1.Tables[0].Columns[3])}");

                    //}
                    PictureBox picture = new PictureBox();
                    Label labelName = new Label();
                    Label labelDesk = new Label();

                    labelDesk.Size = new Size(500, 100);
                    labelDesk.Location = new Point(330, 160 + top);
                    labelDesk.Text = MassDesc[i];
                    labelDesk.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);

                    labelName.Size = new Size(500, 200);
                    labelName.Location = new Point(330, 120 + top);
                    labelName.Text = MassName[i];
                    labelName.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold);

                    picture.Size = new Size(200, 200);
                    picture.Location = new Point(100, 100 + top);
                    picture.Image = image;
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;

                    this.Controls.Add(labelDesk);
                    this.Controls.Add(labelName);
                    this.Controls.Add(picture);

                    top += 250;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.DateTime date1 = new System.DateTime(2022, 6, 20);// показывает 03.06.1996 22:15:00
            System.TimeSpan diff1 = date1 - DateTime.Now;
            DateTime rel = new DateTime(diff1.Ticks);
            Time.Text = string.Format("До начала события осталось {0} лет, {1} месяцев, {2} дней, {3} часов, {4} минут, {5} секунд", rel.Year - 1, rel.Month - 1, rel.Day - 1, rel.Hour, rel.Minute, rel.Second);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

