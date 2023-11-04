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
            this.button_showstats = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox_stats = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_sort = new System.Windows.Forms.ComboBox();
            this.label_sort = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_addworker = new System.Windows.Forms.Button();
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
            this.button_delete_uvol = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox_statesubd = new System.Windows.Forms.ComboBox();
            this.label_statesubd = new System.Windows.Forms.Label();
            this.comboBox_director_subd = new System.Windows.Forms.ComboBox();
            this.label_director_subd = new System.Windows.Forms.Label();
            this.comboBox_headsubd = new System.Windows.Forms.ComboBox();
            this.label_headsubd = new System.Windows.Forms.Label();
            this.textBox_name_subd = new System.Windows.Forms.TextBox();
            this.label_namesubd = new System.Windows.Forms.Label();
            this.textBox_idsubd = new System.Windows.Forms.TextBox();
            this.label_id_subd = new System.Windows.Forms.Label();
            this.button_delete_subd = new System.Windows.Forms.Button();
            this.button_change_subd = new System.Windows.Forms.Button();
            this.button_add_subd = new System.Windows.Forms.Button();
            this.button_refresh_subd = new System.Windows.Forms.Button();
            this.dataGridView_subd = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label_count_all = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subd)).BeginInit();
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
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_count_all);
            this.tabPage1.Controls.Add(this.label5);
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
            this.tabPage1.Controls.Add(this.button_delete_uvol);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1388, 766);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_showstats
            // 
            this.button_showstats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_showstats.Location = new System.Drawing.Point(1052, 414);
            this.button_showstats.Name = "button_showstats";
            this.button_showstats.Size = new System.Drawing.Size(75, 23);
            this.button_showstats.TabIndex = 42;
            this.button_showstats.Text = "Отобразить";
            this.button_showstats.UseVisualStyleBackColor = true;
            this.button_showstats.Click += new System.EventHandler(this.button_showstats_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(914, 450);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 296);
            this.richTextBox1.TabIndex = 41;
            this.richTextBox1.Text = "";
            // 
            // comboBox_stats
            // 
            this.comboBox_stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_stats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stats.FormattingEnabled = true;
            this.comboBox_stats.Location = new System.Drawing.Point(914, 416);
            this.comboBox_stats.Name = "comboBox_stats";
            this.comboBox_stats.Size = new System.Drawing.Size(121, 21);
            this.comboBox_stats.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(910, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Подразделение";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(910, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Дата конца";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(910, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Дата начала";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(911, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Вывести статистику:";
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
            // comboBox_sort
            // 
            this.comboBox_sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sort.FormattingEnabled = true;
            this.comboBox_sort.Location = new System.Drawing.Point(913, 243);
            this.comboBox_sort.Name = "comboBox_sort";
            this.comboBox_sort.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sort.TabIndex = 33;
            this.comboBox_sort.SelectedIndexChanged += new System.EventHandler(this.comboBox_sort_SelectedIndexChanged);
            // 
            // label_sort
            // 
            this.label_sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sort.AutoSize = true;
            this.label_sort.Location = new System.Drawing.Point(910, 216);
            this.label_sort.Name = "label_sort";
            this.label_sort.Size = new System.Drawing.Size(182, 13);
            this.label_sort.TabIndex = 32;
            this.label_sort.Text = "Отсортировать по подразделению";
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.Location = new System.Drawing.Point(913, 145);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 31;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(913, 118);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(191, 20);
            this.textBox_search.TabIndex = 30;
            // 
            // label_search
            // 
            this.label_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(910, 89);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(166, 13);
            this.label_search.TabIndex = 29;
            this.label_search.Text = "Введите имя или номер табеля";
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
            // textBox_date_out
            // 
            this.textBox_date_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_date_out.Location = new System.Drawing.Point(1202, 432);
            this.textBox_date_out.Name = "textBox_date_out";
            this.textBox_date_out.ReadOnly = true;
            this.textBox_date_out.Size = new System.Drawing.Size(152, 20);
            this.textBox_date_out.TabIndex = 26;
            this.textBox_date_out.Click += new System.EventHandler(this.textBox_date_out_Click);
            this.textBox_date_out.DoubleClick += new System.EventHandler(this.textBox_date_out_DoubleClick);
            // 
            // comboBox_status
            // 
            this.comboBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.button_delete_worker.Enabled = false;
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
            this.dateTimePicker_out.Size = new System.Drawing.Size(152, 20);
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
            this.button_changeworkers.Enabled = false;
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
            this.comboBox_podr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.dataGridWorkers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorkers.Location = new System.Drawing.Point(-4, 0);
            this.dataGridWorkers.Name = "dataGridWorkers";
            this.dataGridWorkers.Size = new System.Drawing.Size(883, 766);
            this.dataGridWorkers.TabIndex = 0;
            this.dataGridWorkers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridWorkers_CellClick);
            // 
            // button_delete_uvol
            // 
            this.button_delete_uvol.Image = global::WorkTest.Properties.Resources.x;
            this.button_delete_uvol.Location = new System.Drawing.Point(1360, 432);
            this.button_delete_uvol.Name = "button_delete_uvol";
            this.button_delete_uvol.Size = new System.Drawing.Size(20, 20);
            this.button_delete_uvol.TabIndex = 43;
            this.button_delete_uvol.UseVisualStyleBackColor = true;
            this.button_delete_uvol.Click += new System.EventHandler(this.button_delete_uvol_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox_statesubd);
            this.tabPage2.Controls.Add(this.label_statesubd);
            this.tabPage2.Controls.Add(this.comboBox_director_subd);
            this.tabPage2.Controls.Add(this.label_director_subd);
            this.tabPage2.Controls.Add(this.comboBox_headsubd);
            this.tabPage2.Controls.Add(this.label_headsubd);
            this.tabPage2.Controls.Add(this.textBox_name_subd);
            this.tabPage2.Controls.Add(this.label_namesubd);
            this.tabPage2.Controls.Add(this.textBox_idsubd);
            this.tabPage2.Controls.Add(this.label_id_subd);
            this.tabPage2.Controls.Add(this.button_delete_subd);
            this.tabPage2.Controls.Add(this.button_change_subd);
            this.tabPage2.Controls.Add(this.button_add_subd);
            this.tabPage2.Controls.Add(this.button_refresh_subd);
            this.tabPage2.Controls.Add(this.dataGridView_subd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1388, 766);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подразделения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox_statesubd
            // 
            this.comboBox_statesubd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_statesubd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_statesubd.Enabled = false;
            this.comboBox_statesubd.FormattingEnabled = true;
            this.comboBox_statesubd.Location = new System.Drawing.Point(1200, 453);
            this.comboBox_statesubd.Name = "comboBox_statesubd";
            this.comboBox_statesubd.Size = new System.Drawing.Size(180, 21);
            this.comboBox_statesubd.TabIndex = 14;
            // 
            // label_statesubd
            // 
            this.label_statesubd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_statesubd.AutoSize = true;
            this.label_statesubd.Location = new System.Drawing.Point(1199, 437);
            this.label_statesubd.Name = "label_statesubd";
            this.label_statesubd.Size = new System.Drawing.Size(100, 13);
            this.label_statesubd.TabIndex = 13;
            this.label_statesubd.Text = "Состояние записи";
            // 
            // comboBox_director_subd
            // 
            this.comboBox_director_subd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_director_subd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_director_subd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_director_subd.Enabled = false;
            this.comboBox_director_subd.FormattingEnabled = true;
            this.comboBox_director_subd.Location = new System.Drawing.Point(1200, 399);
            this.comboBox_director_subd.Name = "comboBox_director_subd";
            this.comboBox_director_subd.Size = new System.Drawing.Size(180, 21);
            this.comboBox_director_subd.TabIndex = 12;
            // 
            // label_director_subd
            // 
            this.label_director_subd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_director_subd.AutoSize = true;
            this.label_director_subd.Location = new System.Drawing.Point(1199, 383);
            this.label_director_subd.Name = "label_director_subd";
            this.label_director_subd.Size = new System.Drawing.Size(62, 13);
            this.label_director_subd.TabIndex = 11;
            this.label_director_subd.Text = "Начальник";
            // 
            // comboBox_headsubd
            // 
            this.comboBox_headsubd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_headsubd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_headsubd.FormattingEnabled = true;
            this.comboBox_headsubd.Location = new System.Drawing.Point(1200, 345);
            this.comboBox_headsubd.Name = "comboBox_headsubd";
            this.comboBox_headsubd.Size = new System.Drawing.Size(180, 21);
            this.comboBox_headsubd.TabIndex = 10;
            // 
            // label_headsubd
            // 
            this.label_headsubd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_headsubd.AutoSize = true;
            this.label_headsubd.Location = new System.Drawing.Point(1199, 329);
            this.label_headsubd.Name = "label_headsubd";
            this.label_headsubd.Size = new System.Drawing.Size(136, 13);
            this.label_headsubd.TabIndex = 9;
            this.label_headsubd.Text = "Головное подразделение";
            // 
            // textBox_name_subd
            // 
            this.textBox_name_subd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name_subd.Location = new System.Drawing.Point(1202, 294);
            this.textBox_name_subd.Name = "textBox_name_subd";
            this.textBox_name_subd.ReadOnly = true;
            this.textBox_name_subd.Size = new System.Drawing.Size(180, 20);
            this.textBox_name_subd.TabIndex = 8;
            // 
            // label_namesubd
            // 
            this.label_namesubd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_namesubd.AutoSize = true;
            this.label_namesubd.Location = new System.Drawing.Point(1199, 278);
            this.label_namesubd.Name = "label_namesubd";
            this.label_namesubd.Size = new System.Drawing.Size(57, 13);
            this.label_namesubd.TabIndex = 7;
            this.label_namesubd.Text = "Название";
            // 
            // textBox_idsubd
            // 
            this.textBox_idsubd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_idsubd.Location = new System.Drawing.Point(1202, 246);
            this.textBox_idsubd.Name = "textBox_idsubd";
            this.textBox_idsubd.ReadOnly = true;
            this.textBox_idsubd.Size = new System.Drawing.Size(180, 20);
            this.textBox_idsubd.TabIndex = 6;
            // 
            // label_id_subd
            // 
            this.label_id_subd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id_subd.AutoSize = true;
            this.label_id_subd.Location = new System.Drawing.Point(1199, 230);
            this.label_id_subd.Name = "label_id_subd";
            this.label_id_subd.Size = new System.Drawing.Size(18, 13);
            this.label_id_subd.TabIndex = 5;
            this.label_id_subd.Text = "ID";
            // 
            // button_delete_subd
            // 
            this.button_delete_subd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete_subd.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete_subd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete_subd.Location = new System.Drawing.Point(1300, 552);
            this.button_delete_subd.Name = "button_delete_subd";
            this.button_delete_subd.Size = new System.Drawing.Size(82, 41);
            this.button_delete_subd.TabIndex = 4;
            this.button_delete_subd.Text = "УДАЛИТЬ";
            this.button_delete_subd.UseVisualStyleBackColor = false;
            this.button_delete_subd.Click += new System.EventHandler(this.button_delete_subd_Click);
            // 
            // button_change_subd
            // 
            this.button_change_subd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_change_subd.Location = new System.Drawing.Point(1200, 505);
            this.button_change_subd.Name = "button_change_subd";
            this.button_change_subd.Size = new System.Drawing.Size(180, 41);
            this.button_change_subd.TabIndex = 3;
            this.button_change_subd.Text = "Изменить";
            this.button_change_subd.UseVisualStyleBackColor = true;
            this.button_change_subd.Click += new System.EventHandler(this.button_change_subd_Click);
            // 
            // button_add_subd
            // 
            this.button_add_subd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add_subd.Location = new System.Drawing.Point(15, 656);
            this.button_add_subd.Name = "button_add_subd";
            this.button_add_subd.Size = new System.Drawing.Size(180, 62);
            this.button_add_subd.TabIndex = 2;
            this.button_add_subd.Text = "Добавить подразделение";
            this.button_add_subd.UseVisualStyleBackColor = true;
            this.button_add_subd.Click += new System.EventHandler(this.button_add_subd_Click);
            // 
            // button_refresh_subd
            // 
            this.button_refresh_subd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_refresh_subd.Location = new System.Drawing.Point(15, 576);
            this.button_refresh_subd.Name = "button_refresh_subd";
            this.button_refresh_subd.Size = new System.Drawing.Size(86, 61);
            this.button_refresh_subd.TabIndex = 1;
            this.button_refresh_subd.Text = "Обновить";
            this.button_refresh_subd.UseVisualStyleBackColor = true;
            this.button_refresh_subd.Click += new System.EventHandler(this.button_refresh_subd_Click);
            // 
            // dataGridView_subd
            // 
            this.dataGridView_subd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_subd.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_subd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_subd.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView_subd.Name = "dataGridView_subd";
            this.dataGridView_subd.Size = new System.Drawing.Size(1175, 766);
            this.dataGridView_subd.TabIndex = 0;
            this.dataGridView_subd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_subd_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(913, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Всего сотрудников:";
            // 
            // label_count_all
            // 
            this.label_count_all.AutoSize = true;
            this.label_count_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_count_all.Location = new System.Drawing.Point(914, 41);
            this.label_count_all.Name = "label_count_all";
            this.label_count_all.Size = new System.Drawing.Size(57, 20);
            this.label_count_all.TabIndex = 45;
            this.label_count_all.Text = "label6";
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subd)).EndInit();
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
        private System.Windows.Forms.Button button_delete_uvol;
        private System.Windows.Forms.DataGridView dataGridView_subd;
        private System.Windows.Forms.Button button_delete_subd;
        private System.Windows.Forms.Button button_change_subd;
        private System.Windows.Forms.Button button_add_subd;
        private System.Windows.Forms.Button button_refresh_subd;
        private System.Windows.Forms.Label label_id_subd;
        private System.Windows.Forms.TextBox textBox_name_subd;
        private System.Windows.Forms.Label label_namesubd;
        private System.Windows.Forms.TextBox textBox_idsubd;
        private System.Windows.Forms.ComboBox comboBox_statesubd;
        private System.Windows.Forms.Label label_statesubd;
        private System.Windows.Forms.ComboBox comboBox_director_subd;
        private System.Windows.Forms.Label label_director_subd;
        private System.Windows.Forms.ComboBox comboBox_headsubd;
        private System.Windows.Forms.Label label_headsubd;
        private System.Windows.Forms.Label label_count_all;
        private System.Windows.Forms.Label label5;
    }
}

