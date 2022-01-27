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
    public partial class SponsorRunner : Form
    {
        public SponsorRunner()
        {
            InitializeComponent();
            LoadRunner();
            comboBox1.SelectedIndex = cbGonshik.SelectedIndex;
            comboBox1.Visible = false;
        }
        public string constr = @"Data Source=DESKTOP-HAMFGR7\GATSKANMAX;Initial Catalog = KartSkills; Integrated Security = True";
        public void LoadRunner()
        {

            SqlConnection connection = new SqlConnection(this.constr);

            try
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT CONCAT (First_Name,' ',Last_Name,' ',Result.BidNumber,' - ','(',Country.Country_Name,')') as FINUM , Registration.ID_Racer FROM[Result] INNER JOIN[Registration] ON[Registration].ID_Registration = [Result].ID_Registration INNER JOIN Racer ON Racer.ID_Racer = [Registration].[ID_Racer] INNER JOIN Country ON Country.ID_Country = Racer.ID_Country", connection);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                cbGonshik.DataSource = dataset.Tables[0];
                cbGonshik.DisplayMember = "FINUM";
                cbGonshik.ValueMember = "FINUM";

                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT Racer.ID_Racer, Charity.Charity_Name FROM Registration INNER JOIN Racer ON Racer.[ID_Racer] = [Registration].[ID_Racer] INNER JOIN [Charity] ON [Charity].[ID_Сharity]= [Registration].[ID_Charity]", connection);
                DataSet dataset1 = new DataSet();
                adapter1.Fill(dataset1);
                comboBox1.DataSource = dataset1.Tables[0];
                comboBox1.DisplayMember = "Charity_Name";
                comboBox1.ValueMember = "Charity_Name";
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
        private void SponsorRunner_Load(object sender, EventArgs e)
        {

        }

        private void buttonZaplatit_Click(object sender, EventArgs e)
        {
            //DateTime dateNow = DateTime.Now;
            //var month = dateNow.Month;
            //var year = dateNow.Year;
           
          
            
            //    int textNum = Convert.ToInt32(mTBNomerKarti.Text);
            //    int textYear = Convert.ToInt32(mTBGodKarti.Text);
                //if (textNum >= month && textYear >= year && textNum <= 12)
                //{
                    MessageBox.Show("Меньше");
                    FormSpasibo form1 = new FormSpasibo();
                    form1.labelImaGonshika.Text = Convert.ToString(this.cbGonshik.SelectedValue.ToString());
                    form1.labelSumma.Text = this.labelSumma1.Text;
                    form1.labelImaFonda.Text = this.labeImaFonda.Text;
                    form1.ShowDialog();
                //}
                //else
                //{
                //    MessageBox.Show("Проверьте данные");
                //}
            
        }

        private void cbGonshik_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedIndex = cbGonshik.SelectedIndex;
                var text = comboBox1.Text;
                labeImaFonda.Text = text.ToString();

            }
            catch
            {


                // MessageBox.Show(exp.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGonshik.SelectedIndex = comboBox1.SelectedIndex;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (summ <= 0)
            {
                tbSummaPojertvovania.Text = "0";
            }
            else
            {
                int summFond = 10;
                summ -= summFond;
                tbSummaPojertvovania.Text = summ.ToString();
                labelSumma1.Text = "$" + tbSummaPojertvovania.Text;
                if (tbSummaPojertvovania.TextLength > 4)
                {
                    MessageBox.Show("Немного");
                    tbSummaPojertvovania.Text = "10000";
                }
            }
        }
        public int summ = 0;
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int summFond = 10;
            summ += summFond;
            if (summ > 10000)
            {
                tbSummaPojertvovania.Text = "10000";
                MessageBox.Show("много");
                summ -= summFond;
            }
            else
            {
                tbSummaPojertvovania.Text = summ.ToString();
                labelSumma1.Text = "$" + tbSummaPojertvovania.Text;
            }
        }
        public void ProverkaBukvi(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
                e.Handled = true;
        }
        /// <summary>
        /// Проверка на цифры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TolKoChifri(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;

        }

        private void tbSummaPojertvovania_TextChanged(object sender, EventArgs e)
        {
            try
            {


                labelSumma1.Text = "$" + tbSummaPojertvovania.Text;
                summ = Convert.ToInt32(tbSummaPojertvovania.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Немного помедленнее");
            }
        }

        private void tbSummaPojertvovania_KeyPress(object sender, KeyPressEventArgs e)
        {
            TolKoChifri(sender, e);
        }
    }
}
