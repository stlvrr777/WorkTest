using Npgsql;
using NpgsqlTypes;
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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (string.IsNullOrWhiteSpace(textBox_id.Text) ||
                string.IsNullOrWhiteSpace(textBox_fio.Text) ||
                string.IsNullOrWhiteSpace(textBox_tab.Text) ||
                string.IsNullOrWhiteSpace(textBox_dolzh.Text) ||
                string.IsNullOrWhiteSpace(comboBox_podr.Text) ||
                string.IsNullOrWhiteSpace(textBox_mail.Text) ||
                string.IsNullOrWhiteSpace(textBox_phone.Text) ||
                string.IsNullOrWhiteSpace(comboBox_status.Text))
                {
                MessageBox.Show("Не все поля заполнены.", "Внимание!", MessageBoxButtons.OK);
                }
            else
            {
                connection();
                nCmd = new NpgsqlCommand();
                nCmd.Connection = nCon;

                string sqlQuerry = "UPDATE workers SET fio = @fio, tab_num = @tab_num, post = @post, " +
                     "subdivision = (SELECT id FROM subdivisions WHERE name = @subdivision), " +
                     "email = @email, phone = @phone, date_in = @date_in, " +
                     $"status = (CAST(@status as \"state_type\")), date_out = @date_out WHERE id = @id";


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

                if (textBox_date_out.Visible)
                {
                    nCmd.Parameters.Add(new NpgsqlParameter("@date_out", NpgsqlDbType.Date));
                    nCmd.Parameters["@date_out"].Value = DBNull.Value;                    
                }
                else
                {
                    nCmd.Parameters.Add(new NpgsqlParameter("@date_out", NpgsqlDbType.Date));
                    nCmd.Parameters["@date_out"].Value = dateTimePicker_out.Value;                    
                }


                nCmd.Parameters.Add(new NpgsqlParameter("@status", NpgsqlDbType.Varchar));
                nCmd.Parameters["@status"].Value = comboBox_status.Text;

                nCmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlDbType.Integer));
                nCmd.Parameters["@id"].Value = int.Parse(textBox_id.Text);

                nCmd.CommandText = sqlQuerry;

                NpgsqlDataReader dr = nCmd.ExecuteReader();

                MessageBox.Show("Данные успешно обновлены.", "Успех", MessageBoxButtons.OK);

                refreshGrid();

                //updateSql(sqlQuerry);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection();
            refreshGrid();
        }

        public void refreshGrid()
        {
            DataTable dtgetdata = new DataTable();

            dtgetdata = getdata("select a.id, a.fio as ФИО, a.tab_num as \"Таб.№\", a.post as Должность, " +
                "b.name as Подразделение, a.email as Email, a.phone as Телефон, a.date_in as \"Дата приема\", " +
                "a.date_out as \"Дата увольнения\", a.status as \"Состояние записи\" from workers a left join " +
                "subdivisions b on a.subdivision = b.id order by id asc;");
            dataGridWorkers.DataSource = dtgetdata;
            dataGridWorkers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dataGridWorkers.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dtgetdata = getdata("select a.id, a.name as Название, b.name as \"Головное подразделение\", c.fio as Начальник, a.status as \"Состояние записи\" from Subdivisions a left join subdivisions b  on a.head_subd = b.id left join workers c on a.director = c.id order by id asc");
            dataGridView_subd.DataSource = dtgetdata;
            dataGridView_subd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Для каждой колонки:
            foreach (DataGridViewColumn column in dataGridView_subd.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


            comboBox_podr.Items.Clear();
            comboBox_status.Items.Clear();
            comboBox_sort.Items.Clear();
            comboBox_stats.Items.Clear();

            comboBox_director_subd.Items.Clear();
            comboBox_headsubd.Items.Clear();
            comboBox_statesubd.Items.Clear();

            comboBox_stats.Items.Add("Все".ToString());
            comboBox_stats.SelectedIndex = 0;

            comboBox_headsubd.Items.Add("Нет".ToString());
            comboBox_stats.SelectedIndex = 0;

            comboBox_director_subd.Items.Add("Нет".ToString());
            comboBox_stats.SelectedIndex = 0;

            dtgetdata = getdata("SELECT DISTINCT name FROM subdivisions ORDER BY name");
            if (dtgetdata.Rows.Count > 0)
            {
                foreach (DataRow row in dtgetdata.Rows)
                {
                    comboBox_podr.Items.Add(row["name"].ToString());
                    comboBox_sort.Items.Add(row["name"].ToString());
                    comboBox_stats.Items.Add(row["name"].ToString());
                    comboBox_headsubd.Items.Add(row["name"].ToString());
                }
            }

            dtgetdata = getdata("SELECT unnest(enum_range(NULL::state_type))::text as name;");
            if (dtgetdata.Rows.Count > 0)
            {
                foreach (DataRow row in dtgetdata.Rows)
                {
                    comboBox_status.Items.Add(row["name"].ToString());
                    comboBox_statesubd.Items.Add(row["name"].ToString());
                }
            }

            dtgetdata = getdata("SELECT fio from workers ORDER by fio;");
            if (dtgetdata.Rows.Count > 0)
            {
                foreach (DataRow row in dtgetdata.Rows)
                {
                    comboBox_director_subd.Items.Add(row["fio"].ToString());

                }
            }

            dtgetdata = getdata("SELECT count(id) from workers where date_out is null;");
            if (dtgetdata.Rows.Count > 0)
            {
                foreach (DataRow row in dtgetdata.Rows)
                {
                    label_count_all.Text = row["count"].ToString();

                }
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void dataGridWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //textBox_id.ReadOnly = false;
                textBox_fio.ReadOnly = false;
                textBox_tab.ReadOnly = false;
                textBox_dolzh.ReadOnly = false;
                textBox_phone.ReadOnly = false;
                textBox_mail.ReadOnly = false;
                comboBox_podr.Enabled = true;
                comboBox_status.Enabled = true;
                dateTimePicker_in.Enabled = true;
                button_changeworkers.Enabled = true;
                button_delete_worker.Enabled = true;


                DataGridViewRow selectedRow = dataGridWorkers.Rows[e.RowIndex];            
                textBox_id.Text = selectedRow.Cells["id"].Value.ToString();
                textBox_fio.Text = selectedRow.Cells["ФИО"].Value.ToString();
                textBox_tab.Text = selectedRow.Cells["Таб.№"].Value.ToString();
                textBox_dolzh.Text = selectedRow.Cells["Должность"].Value.ToString();
                comboBox_podr.Text = selectedRow.Cells["Подразделение"].Value.ToString();
                textBox_mail.Text = selectedRow.Cells["Email"].Value.ToString();
                textBox_phone.Text = selectedRow.Cells["Телефон"].Value.ToString();
                string dateValue = selectedRow.Cells["Дата приема"].Value.ToString(); 
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

                string dateoutValue = selectedRow.Cells["Дата увольнения"].Value.ToString(); 
                

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
            if (string.IsNullOrWhiteSpace(textBox_id.Text))
            {

            }
            else
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

        private void button_addworker_Click(object sender, EventArgs e)
        {
            worker_add newForm = new worker_add();
            newForm.ShowDialog(); 
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void button_delete_worker_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox_id.Text))
            {

            }
            else
            {
                DialogResult result = MessageBox.Show("Вы собираетесь удалить данные о сотруднике! Вы уверены? Отменить действие невозможно", "ВНИМАНИЕ", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM workers WHERE id = @id";
                    connection();
                    nCmd = new NpgsqlCommand();
                    nCmd.Connection = nCon;


                    nCmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlDbType.Integer));
                    nCmd.Parameters["@id"].Value = int.Parse(textBox_id.Text);

                    nCmd.CommandText = sql;

                    NpgsqlDataReader dr = nCmd.ExecuteReader();

                    MessageBox.Show("Данные удалены.", "Успех", MessageBoxButtons.OK);

                    refreshGrid();
                }
            }
            

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataTable dtgetdata = new DataTable();

            dtgetdata = getdata($"select a.id, a.fio as ФИО, a.tab_num as \"Таб.№\", a.post as Должность, b.name as Подразделение, a.email as Email, a.phone as Телефон, a.date_in as \"Дата приема\", a.date_out as \"Дата увольнения\", a.status as \"Состояние записи\" from workers a left join subdivisions b on a.subdivision = b.id where a.fio ILIKE '%{textBox_search.Text}%' OR a.tab_num ILIKE '%{textBox_search.Text}%' order by id asc;");
            dataGridWorkers.DataSource = dtgetdata;
        }

        private void comboBox_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtgetdata = new DataTable();

            dtgetdata = getdata($"select a.id, a.fio as ФИО, a.tab_num as \"Таб.№\", a.post as Должность, b.name as Подразделение, a.email as Email, a.phone as Телефон, a.date_in as \"Дата приема\", a.date_out as \"Дата увольнения\", a.status as \"Состояние записи\" from workers a left join subdivisions b on a.subdivision = b.id where b.name = '{comboBox_sort.Text}' order by id asc;");
            dataGridWorkers.DataSource = dtgetdata;
        }

        private void button_showstats_Click(object sender, EventArgs e)
        {
            DataTable dtgetdata = new DataTable();

            string querry_a = "select 'Устроились' AS Статус, a.id, a.fio as ФИО, a.tab_num as \"Таб.№\", " +
                "a.post as Должность, b.name as Подразделение, a.email as Email, a.phone as Телефон, a.date_in as" +
                " \"Дата приема\", a.date_out as \"Дата увольнения\", a.status as \"Состояние записи\" from workers " +
                $"a left join subdivisions b on a.subdivision = b.id WHERE date_in BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}' ";

            string querry_b = "UNION ALL select 'Уволились' AS Статус, NULL AS id, NULL AS ФИО, NULL AS \"Таб.№\", " +
                "NULL AS Должность, NULL AS Подразделение, NULL AS Email, NULL AS Телефон, NULL AS" +
                " \"Дата приема\", NULL AS \"Дата увольнения\", NULL AS \"Состояние записи\" ";


            string querry_c = $"UNION ALL select 'Уволились' AS Статус, a.id, a.fio as ФИО, a.tab_num as \"Таб.№\", " +
                "a.post as Должность, b.name as Подразделение, a.email as Email, a.phone as Телефон, a.date_in as" +
                "\"Дата приема\", a.date_out as \"Дата увольнения\", a.status as \"Состояние записи\" from workers " +
                $"a left join subdivisions b on a.subdivision = b.id WHERE date_out BETWEEN '{dateTimePicker1.Value}' AND '{dateTimePicker2.Value}' ";
             string querry_d = $" order by \"Статус\",\"Дата приема\"  asc;";

            string dop_q =   $"AND b.name = '{comboBox_stats.Text}' ";


            if (comboBox_stats.SelectedIndex == 0)
            {
                dtgetdata = getdata(querry_a + querry_b + querry_c + querry_d );
                dataGridWorkers.DataSource = dtgetdata;

                int count = 0;
                int count_a = -1;

                string targetValue = "Устроились";
                string targetValue_a = "Уволились";             

                foreach (DataGridViewRow row in dataGridWorkers.Rows)
                {
                    if (row.Cells["Статус"].Value != null && row.Cells["Статус"].Value.ToString() == targetValue)
                    {
                        count++;
                    }
                }

                foreach (DataGridViewRow row in dataGridWorkers.Rows)
                {
                    if (row.Cells["Статус"].Value != null && row.Cells["Статус"].Value.ToString() == targetValue_a)
                    {
                        count_a++;
                    }
                }

                richTextBox1.Text = $"За период с {dateTimePicker1.Value.Date.ToShortDateString()} по {dateTimePicker2.Value.Date.ToShortDateString()} сотрудников на работу \nУстроились: \n{count}; \nУволились: \n{count_a}.";
            }
            else
            {
                dtgetdata = getdata(querry_a + dop_q + querry_b + querry_c + dop_q + querry_d);
                dataGridWorkers.DataSource = dtgetdata;

                int count = 0;
                int count_a = -1;

                string targetValue = "Устроились";
                string targetValue_a = "Уволились";

                foreach (DataGridViewRow row in dataGridWorkers.Rows)
                {
                    if (row.Cells["Статус"].Value != null && row.Cells["Статус"].Value.ToString() == targetValue)
                    {
                        count++;
                    }
                }

                foreach (DataGridViewRow row in dataGridWorkers.Rows)
                {
                    if (row.Cells["Статус"].Value != null && row.Cells["Статус"].Value.ToString() == targetValue_a)
                    {
                        count_a++;
                    }
                }
                richTextBox1.Text = $"За период с {dateTimePicker1.Value.Date.ToShortDateString()} по {dateTimePicker2.Value.Date.ToShortDateString()} сотрудников на работу в отдел {comboBox_stats.Text} \nУстроились: \n{count}; \nУволились: \n{count_a}.";
                }
            
        }

        private void button_delete_uvol_Click(object sender, EventArgs e)
        {
            textBox_date_out.Visible = true;
            dateTimePicker_out.Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_subd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //textBox_id.ReadOnly = false;
                textBox_name_subd.ReadOnly = false;
                comboBox_headsubd.Enabled = true;
                comboBox_director_subd.Enabled = true;
                comboBox_statesubd.Enabled = true;
                


                DataGridViewRow selectedRow = dataGridView_subd.Rows[e.RowIndex];

                textBox_idsubd.Text = selectedRow.Cells["id"].Value.ToString();

                textBox_name_subd.Text = selectedRow.Cells["Название"].Value.ToString();

                comboBox_headsubd.Text = selectedRow.Cells["Головное подразделение"].Value.ToString();
                comboBox_director_subd.Text = selectedRow.Cells["Начальник"].Value.ToString();
                comboBox_statesubd.Text = selectedRow.Cells["Состояние записи"].Value.ToString();
           
            }
        }

        private void button_change_subd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_idsubd.Text) ||
                string.IsNullOrWhiteSpace(textBox_name_subd.Text) ||
                string.IsNullOrWhiteSpace(comboBox_headsubd.Text) ||
                string.IsNullOrWhiteSpace(comboBox_director_subd.Text) ||
                string.IsNullOrWhiteSpace(comboBox_statesubd.Text))
            {
                MessageBox.Show("Не все поля заполнены.", "Внимание!", MessageBoxButtons.OK);
            }
            else
            {
                connection();
                nCmd = new NpgsqlCommand();
                nCmd.Connection = nCon;

                string sqlQuerry = "UPDATE subdivisions SET name = @name, head_subd = (select id from subdivisions where name = @headsubd), director = (select id from workers where fio = @director), status = (CAST(@status as \"state_type\")) WHERE id = @id";

                nCmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlDbType.Integer));
                nCmd.Parameters["@id"].Value = int.Parse(textBox_idsubd.Text);            

                nCmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlDbType.Text));
                nCmd.Parameters["@name"].Value = textBox_name_subd.Text;

                nCmd.Parameters.Add(new NpgsqlParameter("@headsubd", NpgsqlDbType.Text));
                nCmd.Parameters["@headsubd"].Value = comboBox_headsubd.Text;

                nCmd.Parameters.Add(new NpgsqlParameter("@director", NpgsqlDbType.Text));
                nCmd.Parameters["@director"].Value = comboBox_director_subd.Text;

                nCmd.Parameters.Add(new NpgsqlParameter("@status", NpgsqlDbType.Varchar));
                nCmd.Parameters["@status"].Value = comboBox_statesubd.Text;

                

                nCmd.CommandText = sqlQuerry;

                NpgsqlDataReader dr = nCmd.ExecuteReader();

                MessageBox.Show("Данные успешно обновлены.", "Успех", MessageBoxButtons.OK);

                refreshGrid();

                //updateSql(sqlQuerry);
            }
        }

        private void button_refresh_subd_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void button_delete_subd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_idsubd.Text))
            {

            }
            else
            {
                DialogResult result = MessageBox.Show("Вы собираетесь удалить данные о сотруднике! Вы уверены? Отменить действие невозможно", "ВНИМАНИЕ", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM subdivisions WHERE id = @id";
                    connection();
                    nCmd = new NpgsqlCommand();
                    nCmd.Connection = nCon;


                    nCmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlDbType.Integer));
                    nCmd.Parameters["@id"].Value = int.Parse(textBox_idsubd.Text);

                    nCmd.CommandText = sql;

                    NpgsqlDataReader dr = nCmd.ExecuteReader();

                    MessageBox.Show("Данные удалены.", "Успех", MessageBoxButtons.OK);

                    refreshGrid();
                }
            }
        }

        private void button_add_subd_Click(object sender, EventArgs e)
        {
            subd_add new_form = new subd_add();
            new_form.ShowDialog();


        }
    }
}
