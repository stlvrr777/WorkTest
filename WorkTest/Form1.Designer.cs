namespace WorkTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_date_out = new System.Windows.Forms.TextBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            this.button_delete_worker = new System.Windows.Forms.Button();
            this.dateTimePicker_out = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_in = new System.Windows.Forms.DateTimePicker();
            this.button_changeworkers = new System.Windows.Forms.Button();
            this.comboBox_podr = new System.Windows.Forms.ComboBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_dolzh = new System.Windows.Forms.TextBox();
            this.textBox_tab = new System.Windows.Forms.TextBox();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_dateout = new System.Windows.Forms.Label();
            this.label_datein = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_podr = new System.Windows.Forms.Label();
            this.label_dolzh = new System.Windows.Forms.Label();
            this.label_tab = new System.Windows.Forms.Label();
            this.label_fio = new System.Windows.Forms.Label();
            this.dataGridWorkers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_addworker = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_sort = new System.Windows.Forms.Label();
            this.comboBox_sort = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_stats = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_showstats = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1396, 792);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_showstats);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.comboBox_stats);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.comboBox_sort);
            this.tabPage1.Controls.Add(this.label_sort);
            this.tabPage1.Controls.Add(this.button_search);
            this.tabPage1.Controls.Add(this.textBox_search);
            this.tabPage1.Controls.Add(this.label_search);
            this.tabPage1.Controls.Add(this.button_refresh);
            this.tabPage1.Controls.Add(this.button_addworker);
            this.tabPage1.Controls.Add(this.textBox_date_out);
            this.tabPage1.Controls.Add(this.comboBox_status);
            this.tabPage1.Controls.Add(this.label_status);
            this.tabPage1.Controls.Add(this.button_delete_worker);
            this.tabPage1.Controls.Add(this.dateTimePicker_out);
            this.tabPage1.Controls.Add(this.dateTimePicker_in);
            this.tabPage1.Controls.Add(this.button_changeworkers);
            this.tabPage1.Controls.Add(this.comboBox_podr);
            this.tabPage1.Controls.Add(this.textBox_phone);
            this.tabPage1.Controls.Add(this.textBox_mail);
            this.tabPage1.Controls.Add(this.textBox_dolzh);
            this.tabPage1.Controls.Add(this.textBox_tab);
            this.tabPage1.Controls.Add(this.textBox_fio);
            this.tabPage1.Controls.Add(this.textBox_id);
            this.tabPage1.Controls.Add(this.label_id);
            this.tabPage1.Controls.Add(this.label_dateout);
            this.tabPage1.Controls.Add(this.label_datein);
            this.tabPage1.Controls.Add(this.label_phone);
            this.tabPage1.Controls.Add(this.label_mail);
            this.tabPage1.Controls.Add(this.label_podr);
            this.tabPage1.Controls.Add(this.label_dolzh);
            this.tabPage1.Controls.Add(this.label_tab);
            this.tabPage1.Controls.Add(this.label_fio);
            this.tabPage1.Controls.Add(this.dataGridWorkers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1388, 766);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_date_out
            // 
            this.textBox_date_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_date_out.Location = new System.Drawing.Point(1202, 432);
            this.textBox_date_out.Name = "textBox_date_out";
            this.textBox_date_out.ReadOnly = true;
            this.textBox_date_out.Size = new System.Drawing.Size(180, 20);
            this.textBox_date_out.TabIndex = 26;
            this.textBox_date_out.Click += new System.EventHandler(this.textBox_date_out_Click);
            this.textBox_date_out.DoubleClick += new System.EventHandler(this.textBox_date_out_DoubleClick);
            // 
            // comboBox_status
            // 
            this.comboBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_status.Enabled = false;
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_status.Location = new System.Drawing.Point(1199, 479);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(180, 21);
            this.comboBox_status.TabIndex = 25;
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(1196, 463);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(100, 13);
            this.label_status.TabIndex = 24;
            this.label_status.Text = "Состояние записи";
            // 
            // button_delete_worker
            // 
            this.button_delete_worker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete_worker.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete_worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete_worker.Location = new System.Drawing.Point(1300, 552);
            this.button_delete_worker.Name = "button_delete_worker";
            this.button_delete_worker.Size = new System.Drawing.Size(82, 41);
            this.button_delete_worker.TabIndex = 23;
            this.button_delete_worker.Text = "УДАЛИТЬ";
            this.button_delete_worker.UseVisualStyleBackColor = false;
            this.button_delete_worker.Click += new System.EventHandler(this.button_delete_worker_Click);
            // 
            // dateTimePicker_out
            // 
            this.dateTimePicker_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_out.Location = new System.Drawing.Point(1202, 432);
            this.dateTimePicker_out.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_out.Name = "dateTimePicker_out";
            this.dateTimePicker_out.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker_out.TabIndex = 22;
            this.dateTimePicker_out.Value = new System.DateTime(2023, 10, 31, 0, 0, 0, 0);
            this.dateTimePicker_out.Visible = false;
            // 
            // dateTimePicker_in
            // 
            this.dateTimePicker_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_in.Enabled = false;
            this.dateTimePicker_in.Location = new System.Drawing.Point(1204, 380);
            this.dateTimePicker_in.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_in.Name = "dateTimePicker_in";
            this.dateTimePicker_in.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker_in.TabIndex = 21;
            this.dateTimePicker_in.Value = new System.DateTime(2023, 10, 31, 0, 0, 0, 0);
            // 
            // button_changeworkers
            // 
            this.button_changeworkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_changeworkers.Location = new System.Drawing.Point(1200, 505);
            this.button_changeworkers.Name = "button_changeworkers";
            this.button_changeworkers.Size = new System.Drawing.Size(180, 41);
            this.button_changeworkers.TabIndex = 20;
            this.button_changeworkers.Text = "Изменить";
            this.button_changeworkers.UseVisualStyleBackColor = true;
            this.button_changeworkers.Click += new System.EventHandler(this.button_changeworkers_Click);
            // 
            // comboBox_podr
            // 
            this.comboBox_podr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_podr.Enabled = false;
            this.comboBox_podr.FormattingEnabled = true;
            this.comboBox_podr.Location = new System.Drawing.Point(1202, 223);
            this.comboBox_podr.Name = "comboBox_podr";
            this.comboBox_podr.Size = new System.Drawing.Size(180, 21);
            this.comboBox_podr.TabIndex = 19;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_phone.Location = new System.Drawing.Point(1202, 325);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.ReadOnly = true;
            this.textBox_phone.Size = new System.Drawing.Size(180, 20);
            this.textBox_phone.TabIndex = 16;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_mail.Location = new System.Drawing.Point(1202, 274);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.ReadOnly = true;
            this.textBox_mail.Size = new System.Drawing.Size(180, 20);
            this.textBox_mail.TabIndex = 15;
            // 
            // textBox_dolzh
            // 
            this.textBox_dolzh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dolzh.Location = new System.Drawing.Point(1202, 170);
            this.textBox_dolzh.Name = "textBox_dolzh";
            this.textBox_dolzh.ReadOnly = true;
            this.textBox_dolzh.Size = new System.Drawing.Size(180, 20);
            this.textBox_dolzh.TabIndex = 13;
            // 
            // textBox_tab
            // 
            this.textBox_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_tab.Location = new System.Drawing.Point(1202, 122);
            this.textBox_tab.Name = "textBox_tab";
            this.textBox_tab.ReadOnly = true;
            this.textBox_tab.Size = new System.Drawing.Size(180, 20);
            this.textBox_tab.TabIndex = 12;
            // 
            // textBox_fio
            // 
            this.textBox_fio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_fio.Location = new System.Drawing.Point(1202, 74);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.ReadOnly = true;
            this.textBox_fio.Size = new System.Drawing.Size(180, 20);
            this.textBox_fio.TabIndex = 11;
            // 
            // textBox_id
            // 
            this.textBox_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_id.Location = new System.Drawing.Point(1202, 24);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(180, 20);
            this.textBox_id.TabIndex = 10;
            // 
            // label_id
            // 
            this.label_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(1199, 8);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 9;
            this.label_id.Text = "ID";
            // 
            // label_dateout
            // 
            this.label_dateout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_dateout.AutoSize = true;
            this.label_dateout.Location = new System.Drawing.Point(1199, 416);
            this.label_dateout.Name = "label_dateout";
            this.label_dateout.Size = new System.Drawing.Size(95, 13);
            this.label_dateout.TabIndex = 8;
            this.label_dateout.Text = "Дата увольнения";
            // 
            // label_datein
            // 
            this.label_datein.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_datein.AutoSize = true;
            this.label_datein.Location = new System.Drawing.Point(1199, 363);
            this.label_datein.Name = "label_datein";
            this.label_datein.Size = new System.Drawing.Size(74, 13);
            this.label_datein.TabIndex = 7;
            this.label_datein.Text = "Дата приема";
            // 
            // label_phone
            // 
            this.label_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(1199, 309);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(52, 13);
            this.label_phone.TabIndex = 6;
            this.label_phone.Text = "Телефон";
            // 
            // label_mail
            // 
            this.label_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(1201, 258);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(32, 13);
            this.label_mail.TabIndex = 5;
            this.label_mail.Text = "Email";
            // 
            // label_podr
            // 
            this.label_podr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_podr.AutoSize = true;
            this.label_podr.Location = new System.Drawing.Point(1199, 206);
            this.label_podr.Name = "label_podr";
            this.label_podr.Size = new System.Drawing.Size(87, 13);
            this.label_podr.TabIndex = 4;
            this.label_podr.Text = "Подразделение";
            // 
            // label_dolzh
            // 
            this.label_dolzh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_dolzh.AutoSize = true;
            this.label_dolzh.Location = new System.Drawing.Point(1199, 154);
            this.label_dolzh.Name = "label_dolzh";
            this.label_dolzh.Size = new System.Drawing.Size(65, 13);
            this.label_dolzh.TabIndex = 3;
            this.label_dolzh.Text = "Должность";
            // 
            // label_tab
            // 
            this.label_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tab.AutoSize = true;
            this.label_tab.Location = new System.Drawing.Point(1199, 106);
            this.label_tab.Name = "label_tab";
            this.label_tab.Size = new System.Drawing.Size(40, 13);
            this.label_tab.TabIndex = 2;
            this.label_tab.Text = "Таб.№";
            // 
            // label_fio
            // 
            this.label_fio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_fio.AutoSize = true;
            this.label_fio.Location = new System.Drawing.Point(1199, 58);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(34, 13);
            this.label_fio.TabIndex = 1;
            this.label_fio.Text = "ФИО";
            // 
            // dataGridWorkers
            // 
            this.dataGridWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorkers.Location = new System.Drawing.Point(-4, 0);
            this.dataGridWorkers.Name = "dataGridWorkers";
            this.dataGridWorkers.Size = new System.Drawing.Size(883, 766);
            this.dataGridWorkers.TabIndex = 0;
            this.dataGridWorkers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridWorkers_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подразделения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_addworker
            // 
            this.button_addworker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_addworker.Location = new System.Drawing.Point(15, 656);
            this.button_addworker.Name = "button_addworker";
            this.button_addworker.Size = new System.Drawing.Size(180, 62);
            this.button_addworker.TabIndex = 27;
            this.button_addworker.Text = "Добавить Сотрудника";
            this.button_addworker.UseVisualStyleBackColor = true;
            this.button_addworker.Click += new System.EventHandler(this.button_addworker_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_refresh.Location = new System.Drawing.Point(15, 576);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(86, 61);
            this.button_refresh.TabIndex = 28;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(910, 27);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(166, 13);
            this.label_search.TabIndex = 29;
            this.label_search.Text = "Введите имя или номер табеля";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(913, 56);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(191, 20);
            this.textBox_search.TabIndex = 30;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(913, 83);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 31;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_sort
            // 
            this.label_sort.AutoSize = true;
            this.label_sort.Location = new System.Drawing.Point(910, 154);
            this.label_sort.Name = "label_sort";
            this.label_sort.Size = new System.Drawing.Size(182, 13);
            this.label_sort.TabIndex = 32;
            this.label_sort.Text = "Отсортировать по подразделению";
            // 
            // comboBox_sort
            // 
            this.comboBox_sort.FormattingEnabled = true;
            this.comboBox_sort.Location = new System.Drawing.Point(913, 181);
            this.comboBox_sort.Name = "comboBox_sort";
            this.comboBox_sort.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sort.TabIndex = 33;
            this.comboBox_sort.SelectedIndexChanged += new System.EventHandler(this.comboBox_sort_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(913, 325);
            this.dateTimePicker1.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(914, 372);
            this.dateTimePicker2.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker2.TabIndex = 35;
            this.dateTimePicker2.Value = new System.DateTime(2023, 10, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(911, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Вывести статистику:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(910, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Дата начала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(910, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Дата конца";
            // 
            // comboBox_stats
            // 
            this.comboBox_stats.FormattingEnabled = true;
            this.comboBox_stats.Location = new System.Drawing.Point(914, 416);
            this.comboBox_stats.Name = "comboBox_stats";
            this.comboBox_stats.Size = new System.Drawing.Size(121, 21);
            this.comboBox_stats.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(910, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Подразделение";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(914, 450);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 296);
            this.richTextBox1.TabIndex = 41;
            this.richTextBox1.Text = "";
            // 
            // button_showstats
            // 
            this.button_showstats.Location = new System.Drawing.Point(1052, 414);
            this.button_showstats.Name = "button_showstats";
            this.button_showstats.Size = new System.Drawing.Size(75, 23);
            this.button_showstats.TabIndex = 42;
            this.button_showstats.Text = "Отобразить";
            this.button_showstats.UseVisualStyleBackColor = true;
            this.button_showstats.Click += new System.EventHandler(this.button_showstats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 797);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Учет сотрудников";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridWorkers;
        private System.Windows.Forms.Label label_dateout;
        private System.Windows.Forms.Label label_datein;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_podr;
        private System.Windows.Forms.Label label_dolzh;
        private System.Windows.Forms.Label label_tab;
        private System.Windows.Forms.Label label_fio;
        private System.Windows.Forms.ComboBox comboBox_podr;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_dolzh;
        private System.Windows.Forms.TextBox textBox_tab;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_changeworkers;
        private System.Windows.Forms.Button button_delete_worker;
        private System.Windows.Forms.DateTimePicker dateTimePicker_out;
        private System.Windows.Forms.DateTimePicker dateTimePicker_in;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.TextBox textBox_date_out;
        private System.Windows.Forms.Button button_addworker;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.ComboBox comboBox_sort;
        private System.Windows.Forms.Label label_sort;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox_stats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_showstats;
    }
}

