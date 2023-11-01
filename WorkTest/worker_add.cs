using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTest
{
    public partial class worker_add : Form

    {
        string connstring = String.Format("Server=localhost; Port=5432; User Id=postgres; Password=1; Database=myorg;");
        NpgsqlConnection nCon;
        NpgsqlCommand nCmd;

        private void connection()
        {
            nCon = new NpgsqlConnection();
            nCon.ConnectionString = connstring;
            if (nCon.State == ConnectionState.Closed)
            {
                nCon.Open();
            }
        }

        public DataTable getdata(string sql)
        {
            DataTable dt = new DataTable();
            connection();
            nCmd = new NpgsqlCommand();
            nCmd.Connection = nCon;
            nCmd.CommandText = sql;

            NpgsqlDataReader dr = nCmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }


        public worker_add()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void worker_add_Load(object sender, EventArgs e)
        {
            connection();
            comboBox_podr.Items.Clear();
            
            DataTable dtgetdata = new DataTable();

            dtgetdata = getdata("SELECT DISTINCT name FROM subdivisions ORDER BY name");
            if (dtgetdata.Rows.Count > 0)
            {
                foreach (DataRow row in dtgetdata.Rows)
                {
                    comboBox_podr.Items.Add(row["name"].ToString());
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            connection();
            nCmd = new NpgsqlCommand();
            nCmd.Connection = nCon;

            string sqlQuerry = "INSERT INTO workers (fio, tab_num, post, subdivision, email, phone, date_in," +
                " status) VALUES (@fio, @tab_num, @post, (SELECT id FROM subdivisions WHERE name = @subdivision)," +
                " @email, @phone, @date_in, (CAST(@status AS state_type)));";     


            nCmd.Parameters.Add(new NpgsqlParameter("@fio", NpgsqlDbType.Text));
            nCmd.Parameters["@fio"].Value = textBox_fio.Text;

            nCmd.Parameters.Add(new NpgsqlParameter("@tab_num", NpgsqlDbType.Text));
            nCmd.Parameters["@tab_num"].Value = textBox_tab.Text;

            nCmd.Parameters.Add(new NpgsqlParameter("@post", NpgsqlDbType.Text));
            nCmd.Parameters["@post"].Value = textBox_dolzh.Text;

            nCmd.Parameters.Add(new NpgsqlParameter("@subdivision", NpgsqlDbType.Text));
            nCmd.Parameters["@subdivision"].Value = comboBox_podr.Text;

            nCmd.Parameters.Add(new NpgsqlParameter("@email", NpgsqlDbType.Text));
            nCmd.Parameters["@email"].Value = textBox_mail.Text;

            nCmd.Parameters.Add(new NpgsqlParameter("@phone", NpgsqlDbType.Text));
            nCmd.Parameters["@phone"].Value = textBox_phone.Text;

            nCmd.Parameters.Add(new NpgsqlParameter("@date_in", NpgsqlDbType.Date));
            nCmd.Parameters["@date_in"].Value = dateTimePicker_in.Value;        


            nCmd.Parameters.Add(new NpgsqlParameter("@status", NpgsqlDbType.Varchar));
            nCmd.Parameters["@status"].Value = "Действующая";        

            nCmd.CommandText = sqlQuerry;

            NpgsqlDataReader dr = nCmd.ExecuteReader();

            Form1 form1 = new Form1();
            form1.refreshGrid();

            MessageBox.Show("Данные успешно добавлены.", "Успех", MessageBoxButtons.OK);
        }

        
    }
}
