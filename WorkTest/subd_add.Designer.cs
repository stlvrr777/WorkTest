namespace WorkTest
{
    partial class subd_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_dolzh = new System.Windows.Forms.Label();
            this.label_tab = new System.Windows.Forms.Label();
            this.label_fio = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.comboBox_head = new System.Windows.Forms.ComboBox();
            this.comboBox_director = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(89, 44);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(180, 20);
            this.textBox_name.TabIndex = 29;
            // 
            // label_dolzh
            // 
            this.label_dolzh.AutoSize = true;
            this.label_dolzh.Location = new System.Drawing.Point(86, 124);
            this.label_dolzh.Name = "label_dolzh";
            this.label_dolzh.Size = new System.Drawing.Size(62, 13);
            this.label_dolzh.TabIndex = 24;
            this.label_dolzh.Text = "Начальник";
            // 
            // label_tab
            // 
            this.label_tab.AutoSize = true;
            this.label_tab.Location = new System.Drawing.Point(86, 76);
            this.label_tab.Name = "label_tab";
            this.label_tab.Size = new System.Drawing.Size(136, 13);
            this.label_tab.TabIndex = 23;
            this.label_tab.Text = "Головное подразделение";
            // 
            // label_fio
            // 
            this.label_fio.AutoSize = true;
            this.label_fio.Location = new System.Drawing.Point(86, 28);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(57, 13);
            this.label_fio.TabIndex = 22;
            this.label_fio.Text = "Название";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(91, 193);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(178, 39);
            this.button_add.TabIndex = 36;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(12, 7);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(60, 30);
            this.button_back.TabIndex = 37;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // comboBox_head
            // 
            this.comboBox_head.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_head.FormattingEnabled = true;
            this.comboBox_head.Location = new System.Drawing.Point(89, 92);
            this.comboBox_head.Name = "comboBox_head";
            this.comboBox_head.Size = new System.Drawing.Size(180, 21);
            this.comboBox_head.TabIndex = 38;
            // 
            // comboBox_director
            // 
            this.comboBox_director.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_director.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_director.FormattingEnabled = true;
            this.comboBox_director.Location = new System.Drawing.Point(89, 140);
            this.comboBox_director.Name = "comboBox_director";
            this.comboBox_director.Size = new System.Drawing.Size(180, 21);
            this.comboBox_director.TabIndex = 39;
            // 
            // subd_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 267);
            this.Controls.Add(this.comboBox_director);
            this.Controls.Add(this.comboBox_head);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_dolzh);
            this.Controls.Add(this.label_tab);
            this.Controls.Add(this.label_fio);
            this.Name = "subd_add";
            this.Text = "Добавить Подразление";
            this.Load += new System.EventHandler(this.subd_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_dolzh;
        private System.Windows.Forms.Label label_tab;
        private System.Windows.Forms.Label label_fio;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ComboBox comboBox_head;
        private System.Windows.Forms.ComboBox comboBox_director;
    }
}