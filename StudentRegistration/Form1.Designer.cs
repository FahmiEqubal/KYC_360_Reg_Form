namespace StudentRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.GroupBox();
            this.country = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Form";
            // 
            // Registration
            // 
            this.Registration.Controls.Add(this.country);
            this.Registration.Controls.Add(this.sname);
            this.Registration.Controls.Add(this.address);
            this.Registration.Controls.Add(this.mname);
            this.Registration.Controls.Add(this.fname);
            this.Registration.Controls.Add(this.label6);
            this.Registration.Controls.Add(this.label5);
            this.Registration.Controls.Add(this.label4);
            this.Registration.Controls.Add(this.label3);
            this.Registration.Controls.Add(this.label2);
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.Location = new System.Drawing.Point(30, 99);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(329, 262);
            this.Registration.TabIndex = 1;
            this.Registration.TabStop = false;
            this.Registration.Text = "KYC360 Employee Registration Form";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(154, 172);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(160, 27);
            this.country.TabIndex = 8;
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(154, 133);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(160, 27);
            this.sname.TabIndex = 7;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(154, 213);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(160, 27);
            this.address.TabIndex = 6;
            this.address.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(154, 93);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(160, 27);
            this.mname.TabIndex = 2;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(154, 43);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(160, 27);
            this.fname.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.EDIT,
            this.DELETE});
            this.dataGridView1.Location = new System.Drawing.Point(415, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 262);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FIRST NAME";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 95;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MIDDLE NAME";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 105;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SURNAME";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "COUNTRY";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 66;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ADDRESS";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // EDIT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.DefaultCellStyle = dataGridViewCellStyle1;
            this.EDIT.HeaderText = "EDIT";
            this.EDIT.MinimumWidth = 6;
            this.EDIT.Name = "EDIT";
            this.EDIT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EDIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseColumnTextForButtonValue = true;
            this.EDIT.Width = 66;
            // 
            // DELETE
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.DefaultCellStyle = dataGridViewCellStyle2;
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.Text = "DELETE";
            this.DELETE.UseColumnTextForButtonValue = true;
            this.DELETE.Width = 66;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(988, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(873, 45);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(149, 22);
            this.searchTextBox.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1060, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Registration.ResumeLayout(false);
            this.Registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Registration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button4;
    }
}

