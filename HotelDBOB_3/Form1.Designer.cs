namespace HotelDBOB_3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Facility_ID_textBox = new System.Windows.Forms.TextBox();
            this.Facility_Name_textBox = new System.Windows.Forms.TextBox();
            this.Hotel_No_textBox = new System.Windows.Forms.TextBox();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Show_all_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Find_textBox = new System.Windows.Forms.TextBox();
            this.Find_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facility_ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Facility Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotel_No";
            // 
            // Facility_ID_textBox
            // 
            this.Facility_ID_textBox.Location = new System.Drawing.Point(111, 74);
            this.Facility_ID_textBox.Name = "Facility_ID_textBox";
            this.Facility_ID_textBox.Size = new System.Drawing.Size(100, 20);
            this.Facility_ID_textBox.TabIndex = 4;
            this.Facility_ID_textBox.TextChanged += new System.EventHandler(this.Facility_ID_textBox_TextChanged);
            // 
            // Facility_Name_textBox
            // 
            this.Facility_Name_textBox.Location = new System.Drawing.Point(111, 100);
            this.Facility_Name_textBox.Name = "Facility_Name_textBox";
            this.Facility_Name_textBox.Size = new System.Drawing.Size(100, 20);
            this.Facility_Name_textBox.TabIndex = 5;
            // 
            // Hotel_No_textBox
            // 
            this.Hotel_No_textBox.Location = new System.Drawing.Point(111, 128);
            this.Hotel_No_textBox.Name = "Hotel_No_textBox";
            this.Hotel_No_textBox.Size = new System.Drawing.Size(100, 20);
            this.Hotel_No_textBox.TabIndex = 6;
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(30, 300);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(75, 23);
            this.Insert_button.TabIndex = 8;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(111, 300);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 9;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(192, 300);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 10;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Show_all_button
            // 
            this.Show_all_button.Location = new System.Drawing.Point(30, 357);
            this.Show_all_button.Name = "Show_all_button";
            this.Show_all_button.Size = new System.Drawing.Size(75, 23);
            this.Show_all_button.TabIndex = 11;
            this.Show_all_button.Text = "Show All";
            this.Show_all_button.UseVisualStyleBackColor = true;
            this.Show_all_button.Click += new System.EventHandler(this.Show_all_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Red;
            this.Exit_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Exit_button.Location = new System.Drawing.Point(192, 357);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 12;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 277);
            this.dataGridView1.TabIndex = 13;
            // 
            // Find_textBox
            // 
            this.Find_textBox.Location = new System.Drawing.Point(353, 77);
            this.Find_textBox.Name = "Find_textBox";
            this.Find_textBox.Size = new System.Drawing.Size(336, 20);
            this.Find_textBox.TabIndex = 14;
            // 
            // Find_button
            // 
            this.Find_button.Location = new System.Drawing.Point(695, 74);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(75, 23);
            this.Find_button.TabIndex = 15;
            this.Find_button.Text = "Find";
            this.Find_button.UseVisualStyleBackColor = true;
            this.Find_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Find_button);
            this.Controls.Add(this.Find_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Show_all_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Hotel_No_textBox);
            this.Controls.Add(this.Facility_Name_textBox);
            this.Controls.Add(this.Facility_ID_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Facility_ID_textBox;
        private System.Windows.Forms.TextBox Facility_Name_textBox;
        private System.Windows.Forms.TextBox Hotel_No_textBox;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Show_all_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Find_textBox;
        private System.Windows.Forms.Button Find_button;
    }
}

