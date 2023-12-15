namespace format_filename
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstBox_files = new ListBox();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            button3 = new Button();
            txt_folderPath = new TextBox();
            progressBar1 = new ProgressBar();
            lbl_progressbar = new Label();
            button2 = new Button();
            radioButton1 = new RadioButton();
            txt_txt = new TextBox();
            radioButton2 = new RadioButton();
            txt_newDivider = new TextBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label3 = new Label();
            txt_old_div = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstBox_files
            // 
            lstBox_files.FormattingEnabled = true;
            lstBox_files.ItemHeight = 15;
            lstBox_files.Location = new Point(3, 62);
            lstBox_files.Name = "lstBox_files";
            lstBox_files.Size = new Size(190, 349);
            lstBox_files.TabIndex = 0;
            lstBox_files.SelectedIndexChanged += lstBox_files_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(190, 23);
            button1.TabIndex = 1;
            button1.Text = "Ordner Auswählen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lstBox_files);
            panel1.Location = new Point(588, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 426);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 3;
            label2.Text = "Gefundene Dateien";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.open_in_new_FILL0_wght400_GRAD0_opsz24;
            button3.Location = new Point(169, 34);
            button3.Name = "button3";
            button3.Size = new Size(25, 26);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_folderPath
            // 
            txt_folderPath.BorderStyle = BorderStyle.FixedSingle;
            txt_folderPath.Enabled = false;
            txt_folderPath.Location = new Point(12, 28);
            txt_folderPath.Name = "txt_folderPath";
            txt_folderPath.Size = new Size(570, 23);
            txt_folderPath.TabIndex = 3;
            txt_folderPath.Tag = "Folder Path";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 415);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(416, 23);
            progressBar1.TabIndex = 4;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // lbl_progressbar
            // 
            lbl_progressbar.AutoSize = true;
            lbl_progressbar.Location = new Point(12, 397);
            lbl_progressbar.Name = "lbl_progressbar";
            lbl_progressbar.Size = new Size(0, 15);
            lbl_progressbar.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(434, 415);
            button2.Name = "button2";
            button2.Size = new Size(148, 23);
            button2.TabIndex = 6;
            button2.Text = "Ändern";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(104, 76);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hinzufügen";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txt_txt
            // 
            txt_txt.BorderStyle = BorderStyle.FixedSingle;
            txt_txt.Location = new Point(12, 97);
            txt_txt.Name = "txt_txt";
            txt_txt.Size = new Size(261, 23);
            txt_txt.TabIndex = 8;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(197, 76);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Entfernen";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // txt_newDivider
            // 
            txt_newDivider.BorderStyle = BorderStyle.FixedSingle;
            txt_newDivider.Enabled = false;
            txt_newDivider.Location = new Point(315, 157);
            txt_newDivider.Name = "txt_newDivider";
            txt_newDivider.Size = new Size(267, 23);
            txt_newDivider.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(315, 132);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Divider ändern (z.B.: - -> _) ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 12;
            label1.Text = "Ordner Pfad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 13;
            label3.Text = "Text";
            // 
            // txt_old_div
            // 
            txt_old_div.BorderStyle = BorderStyle.FixedSingle;
            txt_old_div.Location = new Point(315, 97);
            txt_old_div.Name = "txt_old_div";
            txt_old_div.Size = new Size(267, 23);
            txt_old_div.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 80);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 15;
            label4.Text = "Aktueller Divider (z.B.: -, _)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txt_old_div);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(txt_newDivider);
            Controls.Add(radioButton2);
            Controls.Add(txt_txt);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(lbl_progressbar);
            Controls.Add(progressBar1);
            Controls.Add(txt_folderPath);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBox_files;
        private Button button1;
        private Panel panel1;
        private TextBox txt_folderPath;
        private ProgressBar progressBar1;
        private Label lbl_progressbar;
        private Button button2;
        private RadioButton radioButton1;
        private TextBox txt_txt;
        private RadioButton radioButton2;
        private Button button3;
        private TextBox txt_newDivider;
        private CheckBox checkBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txt_old_div;
        private Label label4;
    }
}