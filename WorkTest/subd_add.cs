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
    public partial class subd_add : Form
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

        public subd_add()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(textBox_name.Text) ||
                string.IsNullOrWhiteSpace(comboBox_head.Text) ||
                string.IsNullOrWhiteSpace(comboBox_director.Text))
            {
                MessageBox.Show("Не все поля заполнены.", "Внимание!", MessageBoxButtons.OK);
            }
            else
            {
                connection();
                nCmd = new NpgsqlCommand();
                nCmd.Connection = nCon;

                string sqlQuerry = "INSERT INTO subdivisions (name, head_subd, director, status) VALUES " +
                    "(@name, (SELECT id FROM subdivisions WHERE name = @head_subd), (SELECT id FROM workers" +
                    " WHERE fio = @director), (CAST(@status AS state_type)));";


                if (comboBox_head.TabIndex == 0)
                {
                    nCmd.Parameters.Add(new NpgsqlParameter("@headsubd", NpgsqlDbType.Text));
                    nCmd.Parameters["@headsubd"].Value = DBNull.Value;
                }
                else
                {
                    nCmd.Parameters.Add(new NpgsqlParameter("@head_subd", NpgsqlDbType.Text));
                    nCmd.Parameters["@head_subd"].Value = comboBox_head.Text;
                }


                if (comboBox_director.TabIndex == 0)
                {
                    nCmd.Parameters.Add(new NpgsqlParameter("@director", NpgsqlDbType.Text));
                    nCmd.Parameters["@director"].Value = DBNull.Value;
                }
                else
                {
                    nCmd.Parameters.Add(new NpgsqlParameter("@director", NpgsqlDbType.Text));
                    nCmd.Parameters["@director"].Value = comboBox_director.Text;
                }

                nCmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlDbType.Text));
                nCmd.Parameters["@name"].Value = textBox_name.Text;
             
                nCmd.Parameters.Add(new NpgsqlParameter("@status", NpgsqlDbType.Varchar));
                nCmd.Parameters["@status"].Value = "Действующая";

                nCmd.CommandText = sqlQuerry;

                NpgsqlDataReader dr = nCmd.ExecuteReader();

                Form1 form1 = new Form1();
                form1.refreshGrid();

                MessageBox.Show("Данные успешно добавлены.", "Успех", MessageBoxButtons.OK);
            }
        }

        private void subd_add_Load(object sender, EventArgs e)
        {
            connection();
            comboBox_head.Items.Clear();
            comboBox_director.Items.Clear();

            comboBox_head.Items.Add("Нет");
            comboBox_director.Items.Add("Нет");


            DataTable dtgetdata = new DataTable();

            dtgetdata = getdata("SELECT fio FROM workers ORDER BY fio");
            if (dtgetdata.Rows.Count > 0)
            {
                foreach (DataRow row in dtgetdata.Rows)
                {
                    comboBox_director.Items.Add(row["fio"].ToString());
                }
            }


            dtgetdata = getdata("SELECT name from subdivisions");
            if (dtgetdata.Rows.Count > 0)
            {
                foreach (DataRow row in dtgetdata.Rows)
                {
                    comboBox_head.Items.Add(row["name"].ToString());
                }
            }
        }
    }
}
