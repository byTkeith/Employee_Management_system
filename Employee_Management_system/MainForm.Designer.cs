namespace Employee_Management_system
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sighnout = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.salary_btn = new System.Windows.Forms.Button();
            this.addEmployee_btn = new System.Windows.Forms.Button();
            this.dasboard_btn = new System.Windows.Forms.Button();
            this.greet_user = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.salary1 = new Employee_Management_system.Salary();
            this.addEmployee1 = new Employee_Management_system.AddEmployee();
            this.dashboard1 = new Employee_Management_system.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 29);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Mangement System";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(1061, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.sighnout);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.salary_btn);
            this.panel2.Controls.Add(this.addEmployee_btn);
            this.panel2.Controls.Add(this.dasboard_btn);
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 571);
            this.panel2.TabIndex = 1;
            // 
            // sighnout
            // 
            this.sighnout.AutoSize = true;
            this.sighnout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sighnout.Location = new System.Drawing.Point(52, 537);
            this.sighnout.Name = "sighnout";
            this.sighnout.Size = new System.Drawing.Size(59, 13);
            this.sighnout.TabIndex = 6;
            this.sighnout.Text = "SIGN OUT";
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Navy;
            this.logout_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.BackgroundImage")));
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.Navy;
            this.logout_btn.Location = new System.Drawing.Point(3, 518);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(50, 50);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // salary_btn
            // 
            this.salary_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.salary_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salary_btn.BackgroundImage")));
            this.salary_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salary_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salary_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salary_btn.Location = new System.Drawing.Point(12, 268);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.Size = new System.Drawing.Size(200, 33);
            this.salary_btn.TabIndex = 4;
            this.salary_btn.Text = "SALARY";
            this.salary_btn.UseVisualStyleBackColor = false;
            this.salary_btn.Click += new System.EventHandler(this.salary_btn_Click);
            // 
            // addEmployee_btn
            // 
            this.addEmployee_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addEmployee_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEmployee_btn.BackgroundImage")));
            this.addEmployee_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addEmployee_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addEmployee_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployee_btn.Location = new System.Drawing.Point(12, 221);
            this.addEmployee_btn.Name = "addEmployee_btn";
            this.addEmployee_btn.Size = new System.Drawing.Size(200, 33);
            this.addEmployee_btn.TabIndex = 3;
            this.addEmployee_btn.Text = "ADD EMPLOYEE";
            this.addEmployee_btn.UseVisualStyleBackColor = false;
            this.addEmployee_btn.Click += new System.EventHandler(this.addEmployee_btn_Click);
            // 
            // dasboard_btn
            // 
            this.dasboard_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dasboard_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dasboard_btn.BackgroundImage")));
            this.dasboard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dasboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dasboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dasboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dasboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dasboard_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dasboard_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dasboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dasboard_btn.Location = new System.Drawing.Point(12, 174);
            this.dasboard_btn.Name = "dasboard_btn";
            this.dasboard_btn.Size = new System.Drawing.Size(200, 33);
            this.dasboard_btn.TabIndex = 2;
            this.dasboard_btn.Text = "DASHBOARD";
            this.dasboard_btn.UseVisualStyleBackColor = false;
            this.dasboard_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.greet_user.Location = new System.Drawing.Point(52, 143);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(115, 19);
            this.greet_user.TabIndex = 1;
            this.greet_user.Text = "Welcome, User";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(55, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dashboard1);
            this.panel4.Controls.Add(this.addEmployee1);
            this.panel4.Controls.Add(this.salary1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(225, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(875, 571);
            this.panel4.TabIndex = 2;
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(875, 571);
            this.salary1.TabIndex = 0;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(-3, -3);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(875, 571);
            this.addEmployee1.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(-3, -3);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(875, 571);
            this.dashboard1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.Button dasboard_btn;
        private System.Windows.Forms.Button salary_btn;
        private System.Windows.Forms.Button addEmployee_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label sighnout;
        private System.Windows.Forms.Panel panel4;
        private Salary salary1;
        private AddEmployee addEmployee1;
        private Dashboard dashboard1;
    }
}