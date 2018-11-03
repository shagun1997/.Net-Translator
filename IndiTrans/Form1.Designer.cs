namespace IndiTrans
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_main = new System.Windows.Forms.TabPage();
            this.tb_settings = new System.Windows.Forms.TabPage();
            this.tb_about = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_api = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_from = new System.Windows.Forms.RichTextBox();
            this.cb_lang = new System.Windows.Forms.ComboBox();
            this.btn_trans = new System.Windows.Forms.Button();
            this.rb_to = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tb_main.SuspendLayout();
            this.tb_settings.SuspendLayout();
            this.tb_about.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "IndiTranslator";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_main);
            this.tabControl1.Controls.Add(this.tb_settings);
            this.tabControl1.Controls.Add(this.tb_about);
            this.tabControl1.Location = new System.Drawing.Point(18, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 393);
            this.tabControl1.TabIndex = 1;
            // 
            // tb_main
            // 
            this.tb_main.Controls.Add(this.button5);
            this.tb_main.Controls.Add(this.button4);
            this.tb_main.Controls.Add(this.button3);
            this.tb_main.Controls.Add(this.button2);
            this.tb_main.Controls.Add(this.rb_to);
            this.tb_main.Controls.Add(this.btn_trans);
            this.tb_main.Controls.Add(this.cb_lang);
            this.tb_main.Controls.Add(this.rb_from);
            this.tb_main.Location = new System.Drawing.Point(4, 22);
            this.tb_main.Name = "tb_main";
            this.tb_main.Padding = new System.Windows.Forms.Padding(3);
            this.tb_main.Size = new System.Drawing.Size(961, 367);
            this.tb_main.TabIndex = 0;
            this.tb_main.Text = "Translator";
            this.tb_main.UseVisualStyleBackColor = true;
            // 
            // tb_settings
            // 
            this.tb_settings.AutoScroll = true;
            this.tb_settings.Controls.Add(this.button1);
            this.tb_settings.Controls.Add(this.groupBox1);
            this.tb_settings.Location = new System.Drawing.Point(4, 22);
            this.tb_settings.Name = "tb_settings";
            this.tb_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tb_settings.Size = new System.Drawing.Size(961, 367);
            this.tb_settings.TabIndex = 1;
            this.tb_settings.Text = "Settings";
            this.tb_settings.UseVisualStyleBackColor = true;
            // 
            // tb_about
            // 
            this.tb_about.Controls.Add(this.groupBox2);
            this.tb_about.Location = new System.Drawing.Point(4, 22);
            this.tb_about.Name = "tb_about";
            this.tb_about.Padding = new System.Windows.Forms.Padding(3);
            this.tb_about.Size = new System.Drawing.Size(961, 367);
            this.tb_about.TabIndex = 2;
            this.tb_about.Text = "About";
            this.tb_about.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_api);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Azure Translate Text API";
            // 
            // tb_api
            // 
            this.tb_api.Location = new System.Drawing.Point(7, 20);
            this.tb_api.Name = "tb_api";
            this.tb_api.Size = new System.Drawing.Size(936, 20);
            this.tb_api.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(323, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 189);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(68, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "IndiTranslator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version: 1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Developed by: Shagun";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rb_from
            // 
            this.rb_from.Location = new System.Drawing.Point(7, 8);
            this.rb_from.MaxLength = 50000;
            this.rb_from.Name = "rb_from";
            this.rb_from.Size = new System.Drawing.Size(463, 315);
            this.rb_from.TabIndex = 0;
            this.rb_from.Text = "";
            // 
            // cb_lang
            // 
            this.cb_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_lang.FormattingEnabled = true;
            this.cb_lang.Items.AddRange(new object[] {
            "English",
            "Hindi"});
            this.cb_lang.Location = new System.Drawing.Point(476, 302);
            this.cb_lang.Name = "cb_lang";
            this.cb_lang.Size = new System.Drawing.Size(463, 21);
            this.cb_lang.TabIndex = 3;
            // 
            // btn_trans
            // 
            this.btn_trans.Location = new System.Drawing.Point(864, 330);
            this.btn_trans.Name = "btn_trans";
            this.btn_trans.Size = new System.Drawing.Size(75, 23);
            this.btn_trans.TabIndex = 4;
            this.btn_trans.Text = "Translate";
            this.btn_trans.UseVisualStyleBackColor = true;
            this.btn_trans.Click += new System.EventHandler(this.btn_trans_Click);
            // 
            // rb_to
            // 
            this.rb_to.Location = new System.Drawing.Point(476, 8);
            this.rb_to.Name = "rb_to";
            this.rb_to.Size = new System.Drawing.Size(463, 288);
            this.rb_to.TabIndex = 5;
            this.rb_to.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Import";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Read aloud";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(252, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tb_main.ResumeLayout(false);
            this.tb_settings.ResumeLayout(false);
            this.tb_about.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_main;
        private System.Windows.Forms.TabPage tb_settings;
        private System.Windows.Forms.TabPage tb_about;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_api;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rb_from;
        private System.Windows.Forms.ComboBox cb_lang;
        private System.Windows.Forms.Button btn_trans;
        private System.Windows.Forms.RichTextBox rb_to;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

