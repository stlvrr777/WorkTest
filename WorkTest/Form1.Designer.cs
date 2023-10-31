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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridWorkers = new System.Windows.Forms.DataGridView();
            this.label_fio = new System.Windows.Forms.Label();
            this.label_tab = new System.Windows.Forms.Label();
            this.label_dolzh = new System.Windows.Forms.Label();
            this.label_podr = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_datein = new System.Windows.Forms.Label();
            this.label_dateout = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.textBox_tab = new System.Windows.Forms.TextBox();
            this.textBox_dolzh = new System.Windows.Forms.TextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.comboBox_podr = new System.Windows.Forms.ComboBox();
            this.button_changeworkers = new System.Windows.Forms.Button();
            this.dateTimePicker_in = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_out = new System.Windows.Forms.DateTimePicker();
            this.button_delete_worker = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 622);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(1176, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // dataGridWorkers
            // 
            this.dataGridWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorkers.Location = new System.Drawing.Point(-4, 0);
            this.dataGridWorkers.Name = "dataGridWorkers";
            this.dataGridWorkers.Size = new System.Drawing.Size(985, 596);
            this.dataGridWorkers.TabIndex = 0;
            // 
            // label_fio
            // 
            this.label_fio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_fio.AutoSize = true;
            this.label_fio.Location = new System.Drawing.Point(987, 58);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(34, 13);
            this.label_fio.TabIndex = 1;
            this.label_fio.Text = "ФИО";
            // 
            // label_tab
            // 
            this.label_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tab.AutoSize = true;
            this.label_tab.Location = new System.Drawing.Point(987, 106);
            this.label_tab.Name = "label_tab";
            this.label_tab.Size = new System.Drawing.Size(40, 13);
            this.label_tab.TabIndex = 2;
            this.label_tab.Text = "Таб.№";
            // 
            // label_dolzh
            // 
            this.label_dolzh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_dolzh.AutoSize = true;
            this.label_dolzh.Location = new System.Drawing.Point(987, 154);
            this.label_dolzh.Name = "label_dolzh";
            this.label_dolzh.Size = new System.Drawing.Size(65, 13);
            this.label_dolzh.TabIndex = 3;
            this.label_dolzh.Text = "Должность";
            // 
            // label_podr
            // 
            this.label_podr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_podr.AutoSize = true;
            this.label_podr.Location = new System.Drawing.Point(987, 206);
            this.label_podr.Name = "label_podr";
            this.label_podr.Size = new System.Drawing.Size(87, 13);
            this.label_podr.TabIndex = 4;
            this.label_podr.Text = "Подразделение";
            // 
            // label_mail
            // 
            this.label_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(989, 258);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(32, 13);
            this.label_mail.TabIndex = 5;
            this.label_mail.Text = "Email";
            // 
            // label_phone
            // 
            this.label_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(987, 309);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(52, 13);
            this.label_phone.TabIndex = 6;
            this.label_phone.Text = "Телефон";
            // 
            // label_datein
            // 
            this.label_datein.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_datein.AutoSize = true;
            this.label_datein.Location = new System.Drawing.Point(987, 363);
            this.label_datein.Name = "label_datein";
            this.label_datein.Size = new System.Drawing.Size(74, 13);
            this.label_datein.TabIndex = 7;
            this.label_datein.Text = "Дата приема";
            // 
            // label_dateout
            // 
            this.label_dateout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_dateout.AutoSize = true;
            this.label_dateout.Location = new System.Drawing.Point(987, 416);
            this.label_dateout.Name = "label_dateout";
            this.label_dateout.Size = new System.Drawing.Size(95, 13);
            this.label_dateout.TabIndex = 8;
            this.label_dateout.Text = "Дата увольнения";
            // 
            // label_id
            // 
            this.label_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(987, 8);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 9;
            this.label_id.Text = "ID";
            // 
            // textBox_id
            // 
            this.textBox_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_id.Location = new System.Drawing.Point(990, 24);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(180, 20);
            this.textBox_id.TabIndex = 10;
            // 
            // textBox_fio
            // 
            this.textBox_fio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_fio.Location = new System.Drawing.Point(990, 74);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(180, 20);
            this.textBox_fio.TabIndex = 11;
            // 
            // textBox_tab
            // 
            this.textBox_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_tab.Location = new System.Drawing.Point(990, 122);
            this.textBox_tab.Name = "textBox_tab";
            this.textBox_tab.Size = new System.Drawing.Size(180, 20);
            this.textBox_tab.TabIndex = 12;
            // 
            // textBox_dolzh
            // 
            this.textBox_dolzh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dolzh.Location = new System.Drawing.Point(990, 170);
            this.textBox_dolzh.Name = "textBox_dolzh";
            this.textBox_dolzh.Size = new System.Drawing.Size(180, 20);
            this.textBox_dolzh.TabIndex = 13;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_mail.Location = new System.Drawing.Point(990, 274);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(180, 20);
            this.textBox_mail.TabIndex = 15;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_phone.Location = new System.Drawing.Point(990, 325);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(180, 20);
            this.textBox_phone.TabIndex = 16;
            // 
            // comboBox_podr
            // 
            this.comboBox_podr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_podr.FormattingEnabled = true;
            this.comboBox_podr.Location = new System.Drawing.Point(990, 223);
            this.comboBox_podr.Name = "comboBox_podr";
            this.comboBox_podr.Size = new System.Drawing.Size(180, 21);
            this.comboBox_podr.TabIndex = 19;
            // 
            // button_changeworkers
            // 
            this.button_changeworkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_changeworkers.Location = new System.Drawing.Point(990, 474);
            this.button_changeworkers.Name = "button_changeworkers";
            this.button_changeworkers.Size = new System.Drawing.Size(180, 41);
            this.button_changeworkers.TabIndex = 20;
            this.button_changeworkers.Text = "Изменить";
            this.button_changeworkers.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_in
            // 
            this.dateTimePicker_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_in.Location = new System.Drawing.Point(992, 380);
            this.dateTimePicker_in.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_in.Name = "dateTimePicker_in";
            this.dateTimePicker_in.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker_in.TabIndex = 21;
            this.dateTimePicker_in.Value = new System.DateTime(2023, 10, 31, 0, 0, 0, 0);
            // 
            // dateTimePicker_out
            // 
            this.dateTimePicker_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_out.Location = new System.Drawing.Point(990, 432);
            this.dateTimePicker_out.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_out.Name = "dateTimePicker_out";
            this.dateTimePicker_out.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker_out.TabIndex = 22;
            this.dateTimePicker_out.Value = new System.DateTime(2023, 10, 31, 0, 0, 0, 0);
            // 
            // button_delete_worker
            // 
            this.button_delete_worker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete_worker.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete_worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete_worker.Location = new System.Drawing.Point(1088, 552);
            this.button_delete_worker.Name = "button_delete_worker";
            this.button_delete_worker.Size = new System.Drawing.Size(82, 41);
            this.button_delete_worker.TabIndex = 23;
            this.button_delete_worker.Text = "УДАЛИТЬ";
            this.button_delete_worker.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 646);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Учет сотрудников";
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
    }
}

