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

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-87HOQRL\\SQLEXPRESS02; Initial Catalog=kyc_emp; User Id=sa; Password=equbal");
        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter drr;
        string id;
        bool Mode = true;
        string sql;



        public void LoadData()
        {
            try
            {
                sql = "select * from kyc_360";
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                read = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();

                while(read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4]);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



        public void getID(String id)
        {
            sql = "select * from kyc_360 where id = @id"; 
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id); 
            conn.Open();
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                fname.Text = read[1].ToString();
                mname.Text = read[2].ToString();
                sname.Text = read[3].ToString();
                country.Text = read[4].ToString();
                address.Text = read[5].ToString();
            }
            conn.Close();
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = fname.Text;
            string name2 = mname.Text;
            string name3 = sname.Text;
            string country1 = country.Text;
            string address1 = address.Text;

            if(Mode == true)
            {
                sql = "insert into kyc_360(fname, mname, sname, country, address) values(@fname, @mname, @sname, @country, @address)";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fname", name);
                cmd.Parameters.AddWithValue("@mname", name2);
                cmd.Parameters.AddWithValue("@sname", name3);
                cmd.Parameters.AddWithValue("@country", country1);
                cmd.Parameters.AddWithValue("@address", address1);
                MessageBox.Show("Record Added....");
                cmd.ExecuteNonQuery();

                fname.Clear();
                mname.Clear();
                sname.Clear();
                country.Clear();
                address.Clear();


            }
            else
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "update kyc_360 set fname = @fname, mname = @mname, sname =  @sname, country = @country, address = @address where id = @id";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fname", name);
                cmd.Parameters.AddWithValue("@mname", name2);
                cmd.Parameters.AddWithValue("@sname", name3);
                cmd.Parameters.AddWithValue("@country", country1);
                cmd.Parameters.AddWithValue("@address", address1);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("Record Updated....");
                cmd.ExecuteNonQuery();

                fname.Clear();
                mname.Clear();
                sname.Clear();
                country.Clear();
                address.Clear();
                button1.Text = "Save";
                Mode = true;

            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["EDIT"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getID(id);
                button1.Text = "EDIT";
            }
            else if (e.ColumnIndex == dataGridView1.Columns["DELETE"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from kyc_360 where id = @id";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted...");
                conn.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            fname.Clear();
            mname.Clear();
            sname.Clear();
            country.Clear();
            address.Clear();
            button1.Text = "Save";
            Mode = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim(); 

            if (!string.IsNullOrEmpty(searchTerm))
            {
                try
                {
                    sql = "select * from kyc_360 where fname like @searchTerm";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); 

                    conn.Open();
                    read = cmd.ExecuteReader();
                    dataGridView1.Rows.Clear();

                    while (read.Read())
                    {
                        dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4]);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                LoadData();
            }
        }
    }
}
