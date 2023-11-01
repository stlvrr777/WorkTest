using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTest
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }



        private void button_changeworkers_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection();
            DataTable dtgetdata = new DataTable();
            dtgetdata = getdata("select a.id, a.fio as ФИО, a.tab_num as \"Таб.№\", a.post as Должность, b.name as Подразделение, a.email as Email, a.phone as Телефон, a.date_in as \"Дата приема\", a.date_out as \"Дата увольнения\", a.status as \"Состояние записи\" from workers a left join subdivisions b on a.subdivision = b.id order by id asc;");
            dataGridWorkers.DataSource = dtgetdata;

           



        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void dataGridWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox_id.ReadOnly = false;
                textBox_fio.ReadOnly = false;
                textBox_tab.ReadOnly = false;
                textBox_dolzh.ReadOnly = false;
                textBox_phone.ReadOnly = false;
                textBox_mail.ReadOnly = false;


                DataGridViewRow selectedRow = dataGridWorkers.Rows[e.RowIndex];            
                textBox_id.Text = selectedRow.Cells["id"].Value.ToString();
                textBox_fio.Text = selectedRow.Cells["ФИО"].Value.ToString();
                textBox_tab.Text = selectedRow.Cells["Таб.№"].Value.ToString();
                textBox_dolzh.Text = selectedRow.Cells["Должность"].Value.ToString();
                comboBox_podr.Text = selectedRow.Cells["Подразделение"].Value.ToString();
                textBox_mail.Text = selectedRow.Cells["Email"].Value.ToString();
                textBox_phone.Text = selectedRow.Cells["Телефон"].Value.ToString();
                string dateValue = selectedRow.Cells["Дата приема"].Value.ToString(); // Замените "название_столбца_даты" на актуальное имя столбца с датой
                DateTime datein, dateout;

                if (DateTime.TryParse(dateValue, out datein))
                {
                    dateTimePicker_in.Value = datein;
                }
                else
                {
                    dateTimePicker_in.Value = DateTime.Now;
                }
                //textBox_fio.Text = selectedRow.Cells["date_out"].Value.ToString();
                comboBox_status.Text = selectedRow.Cells["Состояние записи"].Value.ToString();

                string dateoutValue = selectedRow.Cells["Дата увольнения"].Value.ToString(); // Замените "название_столбца_даты" на актуальное имя столбца с датой
                

                if (DateTime.TryParse(dateoutValue, out dateout))
                {

                    dateTimePicker_out.Value = dateout;
                    dateTimePicker_out.Visible = true;
                    textBox_date_out.Visible = false;
                }
                else
                {
                    dateTimePicker_out.Visible = false;
                    textBox_date_out.Visible = true;
                }
                
                //textBox_fio.Text = selectedRow.Cells["date_out"].Value.ToString();
                //comboBox_status.Text = selectedRow.Cells["status"].Value.ToString();
            }
        }

        private void textBox_date_out_Click(object sender, EventArgs e)
        {

        }

        private void textBox_date_out_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы собираетесь уволить сотрудника! Вы уверены? Отменить действие невозможно", "ВНИМАНИЕ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Выбран вариант "Да"
                // Добавьте здесь код для обработки варианта "Да"
                textBox_date_out.Visible = false;
                dateTimePicker_out.Visible = true;
            }      
        }
    }
}
