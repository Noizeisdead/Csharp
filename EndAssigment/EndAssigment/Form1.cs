using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EndAssigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Thread t = new Thread(new ThreadStart(StartForm));
            //t.Start();  
            //Thread.Sleep(5000);
            InitializeComponent();
            //t.Interrupt();
        }


        public void StartForm()
        {
            Application.Run(new Form2());
        }

        private void CalcPrice_Click(object sender, EventArgs e)
        {
            //If this button is clicked the price of the entered drive will be calculated and shown in label5
            DateTime StartTime = StartTimePick.Value;
            DateTime EndTime = EndTimePick.Value;
            DateTime Day = DayPick.Value;
            double Distance = Convert.ToDouble(DistanceInput.Text);
            double price;

            if ((int)Day.DayOfWeek <= 1 && (int)Day.DayOfWeek >= 5)
            {
                //If StartTime is between 7 am monday and 10 pm friday.
                double priceDistance = Distance * 0.50; 
                double priceMinute = (EndTime - StartTime).TotalMinutes * 0.17;
                price = priceDistance + priceMinute;
                CompanyText.Text = price.ToString();
            }else if ((int)Day.DayOfWeek > 1 && (int)Day.DayOfWeek < 5){
                //if StartTime is between 10 pm friday and 7am monday.
                double priceDistance = Distance * 0.50;
                double priceMinute = (EndTime - StartTime).TotalMinutes * 0.17;
                double suufa = (priceDistance + priceMinute/ 100) * 15;
                price = suufa + priceDistance + priceMinute;
                CompanyText.Text = price.ToString();
                return price
            }

            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Noize\source\repos\EndAssigment\EndAssigment\Database1.mdf;Integrated Security=True";
            string sql = "insert into Taxi ([Id], [Start time], [End time], [Day], [Distance], [Price]) values(@Id, @StartTime, @EndTime, @Day, @Distance, @Price)";
            using (SqlConnection cnn = new SqlConnection(constring))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = StartTimePick.Text;
                cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = EndTimePick.Text;
                cmd.Parameters.Add("@Day", SqlDbType.NVarChar).Value = DayPick.Text;
                cmd.Parameters.Add("@Distance", SqlDbType.Decimal).Value = DistanceInput.Text;
                cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;
                cmd.CommandType = CommandType.Text;
                int rowsAdded = cmd.ExecuteNonQuery();
                if (rowsAdded > 0)
                {
                    MessageBox.Show("Taxi " + TaxiIDInput.Text + " has been added.");
                }

            }

        }

        private void income_Click(object sender, EventArgs e)
        {
            //If this button is clicked the total income of the company will be shown in a label
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Noize\source\repos\EndAssigment\EndAssigment\Database1.mdf;Integrated Security=True";
            string sql = "select price from Drive";
            using (SqlConnection cnn = new SqlConnection(constring))
            {
                try
                {
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    { 
                        int rowsFetched = cmd.ExecuteNonQuery();
                        if (rowsFetched > 0)
                        {
                            MessageBox.Show("Rows fetched!");
                        }
                        else
                        {
                            MessageBox.Show("No rows fetched!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
                cnn.Close();
            }
        }

        private void addTaxi_Click(object sender, EventArgs e)
        {
            //If ths button is clicked a taxi will be added in the tabel 
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Noize\source\repos\EndAssigment\EndAssigment\Database1.mdf;Integrated Security=True";
            string sql = "insert into Taxi ([number]) values(@Id)";
            string sql2 = "Select number from Taxi";
                
            using (SqlConnection cnn = new SqlConnection(constring))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = TaxiIDInput.Text;
                cmd.CommandType = CommandType.Text;
                int rowsAdded = cmd.ExecuteNonQuery();
                if (rowsAdded > 0)
                {
                    MessageBox.Show("Taxi " + TaxiIDInput.Text + " has been added.");
                }

                SqlCommand cmd2 = new SqlCommand(sql2, cnn);
                SqlDataReader sReader;
                sReader = cmd2.ExecuteReader();

                while (sReader.Read())
                {
                    TaxiText.Text += "========Taxi========" +'\n';
                    TaxiText.Text += sReader["number"].ToString() + '\n';
                    //TaxiText.Text += "Drives: " + ;
                }
                cnn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e){
            //If this button is clicked a taxi and drive will be linked together in a tabel of the database
            //A drive that is already linked cant be linked again 
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Noize\source\repos\EndAssigment\EndAssigment\Database1.mdf;Integrated Security=True";
            string sql = "insert into Taxi ([Id]) values(@Id)";
            using (SqlConnection cnn = new SqlConnection(constring))
            {
                try
                {
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        int input = Convert.ToInt32(addTaxi.Text);
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Int32.Parse(TaxiIDInput.Text);

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Row inserted!");
                        }
                        else
                        {
                            MessageBox.Show("No row inserted!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
                cnn.Close();
            }
        }

        private void LongestDrive_Click(object sender, EventArgs e){
            //If this button is clicked the longest drive in the whole company will be shown
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Noize\source\repos\EndAssigment\EndAssigment\Database1.mdf;Integrated Security=True";
            string sql = "insert into Taxi ([Id]) values(@Id)";
            using (SqlConnection cnn = new SqlConnection(constring))
            {
                try
                {
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        int input = Convert.ToInt32(addTaxi.Text);
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Int32.Parse(TaxiIDInput.Text);

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Row inserted!");
                        }
                        else
                        {
                            MessageBox.Show("No row inserted!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
                cnn.Close();
            }
        }

        private void AverageDistance_Click(object sender, EventArgs e){
            //If this button is clicked the average driving distance of all the drives will be calculated and shown
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Noize\source\repos\EndAssigment\EndAssigment\Database1.mdf;Integrated Security=True";
            string sql = "insert into Taxi ([Id]) values(@Id)";
            using (SqlConnection cnn = new SqlConnection(constring))
            {
                try
                {
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        int input = Convert.ToInt32(addTaxi.Text);
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Int32.Parse(TaxiIDInput.Text);

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Row inserted!");
                        }
                        else
                        {
                            MessageBox.Show("No row inserted!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
                cnn.Close();
            }
        }
    }
}
