namespace Employee_Management_system
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEmployee_importBtn = new System.Windows.Forms.Button();
            this.addEmployee_picture = new System.Windows.Forms.Panel();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployee_phoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmployee_fullName = new System.Windows.Forms.TextBox();
            this.addEmployee_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 326);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Database";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.addEmployee_importBtn);
            this.panel2.Controls.Add(this.addEmployee_picture);
            this.panel2.Controls.Add(this.addEmployee_position);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addEmployee_phoneNumber);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addEmployee_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addEmployee_fullName);
            this.panel2.Controls.Add(this.addEmployee_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 175);
            this.panel2.TabIndex = 1;
            // 
            // addEmployee_importBtn
            // 
            this.addEmployee_importBtn.BackColor = System.Drawing.Color.Navy;
            this.addEmployee_importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addEmployee_importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addEmployee_importBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_importBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_importBtn.Location = new System.Drawing.Point(691, 128);
            this.addEmployee_importBtn.Name = "addEmployee_importBtn";
            this.addEmployee_importBtn.Size = new System.Drawing.Size(75, 23);
            this.addEmployee_importBtn.TabIndex = 11;
            this.addEmployee_importBtn.Text = "import";
            this.addEmployee_importBtn.UseVisualStyleBackColor = false;
            // 
            // addEmployee_picture
            // 
            this.addEmployee_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_picture.Location = new System.Drawing.Point(691, 22);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(100, 100);
            this.addEmployee_picture.TabIndex = 10;
            // 
            // addEmployee_position
            // 
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.addEmployee_position.Location = new System.Drawing.Point(458, 69);
            this.addEmployee_position.Name = "addEmployee_position";
            this.addEmployee_position.Size = new System.Drawing.Size(174, 21);
            this.addEmployee_position.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Position:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addEmployee_phoneNumber
            // 
            this.addEmployee_phoneNumber.Location = new System.Drawing.Point(458, 24);
            this.addEmployee_phoneNumber.Name = "addEmployee_phoneNumber";
            this.addEmployee_phoneNumber.Size = new System.Drawing.Size(174, 20);
            this.addEmployee_phoneNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addEmployee_gender
            // 
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.addEmployee_gender.Location = new System.Drawing.Point(114, 114);
            this.addEmployee_gender.Name = "addEmployee_gender";
            this.addEmployee_gender.Size = new System.Drawing.Size(174, 21);
            this.addEmployee_gender.TabIndex = 5;
            this.addEmployee_gender.Text = "Select Dropdown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Full Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addEmployee_fullName
            // 
            this.addEmployee_fullName.Location = new System.Drawing.Point(114, 66);
            this.addEmployee_fullName.Name = "addEmployee_fullName";
            this.addEmployee_fullName.Size = new System.Drawing.Size(174, 20);
            this.addEmployee_fullName.TabIndex = 2;
            // 
            // addEmployee_id
            // 
            this.addEmployee_id.Location = new System.Drawing.Point(114, 21);
            this.addEmployee_id.Name = "addEmployee_id";
            this.addEmployee_id.Size = new System.Drawing.Size(174, 20);
            this.addEmployee_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee\'s ID:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(213, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(496, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(402, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(311, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(875, 571);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployee_fullName;
        private System.Windows.Forms.TextBox addEmployee_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmployee_phoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addEmployee_importBtn;
        private System.Windows.Forms.Panel addEmployee_picture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}
