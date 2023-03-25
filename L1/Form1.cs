using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace L1
{
    public partial class Form1 : Form
    {
        private string connectionString =
            @"Server=ANICCA\SQLEXPRESS;Database=Bar;Integrated Security=true;";
        
        private DataSet ds = new DataSet();

        private SqlDataAdapter restrictii = new SqlDataAdapter();
        private SqlDataAdapter client = new SqlDataAdapter();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    ///MessageBox.Show(connection.State.ToString());
                    client.SelectCommand = new SqlCommand("select * from  Client", connection);
                    client.Fill(ds, "Client");
                    clientsCombo.DisplayMember = "nume";
                    clientsCombo.DataSource = ds.Tables["Client"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void clientsCombo_Selectat(object sender, EventArgs e)
        {
            DataRowView drv = clientsCombo.SelectedItem as DataRowView;
            if (drv != null)
            {
                int idClient = Convert.ToInt32(drv["id_client"]);
                //MessageBox.Show(idClient.ToString());
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        
                        connection.Open();
                        restrictii.SelectCommand = new SqlCommand("select * from Restrictii where id_client = @val", connection);
                        restrictii.SelectCommand.Parameters.AddWithValue("@val", idClient);
                        if(ds.Tables.Contains("Restrictii"))
                            ds.Tables["Restrictii"].Clear();
                        restrictii.Fill(ds, "Restrictii");
                        restrictiiCombo.DisplayMember = "id_restrictie";
                        restrictiiCombo.DataSource = ds.Tables["Restrictii"];
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void restrictiiCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = restrictiiCombo.SelectedItem as DataRowView;
            if (drv != null)
            {
                int idRestrictie = Convert.ToInt32(drv["id_restrictie"]);
                id_Text.Text = idRestrictie.ToString();
                motiv_text.Text = drv["motiv"].ToString();
                expirarePick.Value = Convert.ToDateTime(drv["expirare"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drv = restrictiiCombo.SelectedItem as DataRowView;
            if (drv != null)
            {
                int idRestrictie = Convert.ToInt32(drv["id_restrictie"]);
                string motivNou = motiv_text.Text;
                DateTime dateTimeNou = expirarePick.Value;
                id_Text.Text = idRestrictie.ToString();
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        
                        connection.Open();
                        restrictii.UpdateCommand = new SqlCommand("update Restrictii set motiv = @motiv, expirare = @expirare where id_restrictie = @val", connection);
                        restrictii.UpdateCommand.Parameters.AddWithValue("@val", idRestrictie);
                        restrictii.UpdateCommand.Parameters.AddWithValue("@motiv", motivNou);
                        restrictii.UpdateCommand.Parameters.AddWithValue("@expirare", dateTimeNou);
                        restrictii.UpdateCommand.ExecuteNonQuery();
                        restrictiiCombo.DisplayMember = "id_restrictie";
                        restrictiiCombo.DataSource = ds.Tables["Restrictii"];
                        connection.Close();
                        Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView drv = restrictiiCombo.SelectedItem as DataRowView;
            if (drv != null)
            {
                int idRestrictie = Convert.ToInt32(drv["id_restrictie"]);
                string motivNou = motiv_text.Text;
                DateTime dateTimeNou = expirarePick.Value;
                id_Text.Text = idRestrictie.ToString();
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        
                        connection.Open();
                        restrictii.DeleteCommand = new SqlCommand("delete from Restrictii where id_restrictie = @val", connection);
                        restrictii.DeleteCommand.Parameters.AddWithValue("@val", idRestrictie);
                        restrictii.DeleteCommand.ExecuteNonQuery();
                        restrictiiCombo.DisplayMember = "id_restrictie";
                        restrictiiCombo.DataSource = ds.Tables["Restrictii"];
                        clientsCombo_Selectat(null, null);
                        motiv_text.Text = "";
                        expirarePick.Value = DateTime.Now;
                        connection.Close();
                        Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRowView drv = clientsCombo.SelectedItem as DataRowView;
            if (drv != null)
            {
                int idClient = Convert.ToInt32(drv["id_client"]);
                //MessageBox.Show(idClient.ToString());
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        connection.Open();
                        restrictii.InsertCommand =
                            new SqlCommand(
                                "insert into Restrictii(id_client, motiv, expirare) values(@val, @motiv, @expirare)",
                                connection);
                        restrictii.InsertCommand.Parameters.AddWithValue("@val", idClient);
                        restrictii.InsertCommand.Parameters.AddWithValue("@motiv", motiv_text.Text);
                        restrictii.InsertCommand.Parameters.AddWithValue("@expirare", expirarePick.Value);
                        restrictii.InsertCommand.ExecuteNonQuery();
                        Refresh();
                        clientsCombo_Selectat(null, null);
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}