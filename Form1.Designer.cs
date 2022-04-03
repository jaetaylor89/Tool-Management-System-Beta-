namespace Tool_Management_System__Beta_
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
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblEmpNum = new System.Windows.Forms.Label();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.txbEmpFname = new System.Windows.Forms.TextBox();
            this.txbEmpLname = new System.Windows.Forms.TextBox();
            this.txbEmpNum = new System.Windows.Forms.TextBox();
            this.txbCheckout = new System.Windows.Forms.TextBox();
            this.txbCheckin = new System.Windows.Forms.TextBox();
            this.DatabaseLogs = new System.Windows.Forms.ListBox();
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnToolDB = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnUpdateTool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(37, 38);
            this.lblFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(202, 20);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "Employee First Name:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(37, 93);
            this.lblLname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(198, 20);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Employee Last Name:";
            // 
            // lblEmpNum
            // 
            this.lblEmpNum.AutoSize = true;
            this.lblEmpNum.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNum.Location = new System.Drawing.Point(37, 147);
            this.lblEmpNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpNum.Name = "lblEmpNum";
            this.lblEmpNum.Size = new System.Drawing.Size(126, 20);
            this.lblEmpNum.TabIndex = 2;
            this.lblEmpNum.Text = "Employee ID:";
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.Location = new System.Drawing.Point(37, 203);
            this.lblCheckout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(145, 20);
            this.lblCheckout.TabIndex = 3;
            this.lblCheckout.Text = "Item Checkout:";
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckin.Location = new System.Drawing.Point(37, 255);
            this.lblCheckin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(123, 20);
            this.lblCheckin.TabIndex = 4;
            this.lblCheckin.Text = "Item Return:";
            // 
            // txbEmpFname
            // 
            this.txbEmpFname.Location = new System.Drawing.Point(307, 35);
            this.txbEmpFname.Name = "txbEmpFname";
            this.txbEmpFname.Size = new System.Drawing.Size(227, 29);
            this.txbEmpFname.TabIndex = 5;
            this.txbEmpFname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbEmpLname
            // 
            this.txbEmpLname.Location = new System.Drawing.Point(307, 90);
            this.txbEmpLname.Name = "txbEmpLname";
            this.txbEmpLname.Size = new System.Drawing.Size(227, 29);
            this.txbEmpLname.TabIndex = 6;
            // 
            // txbEmpNum
            // 
            this.txbEmpNum.Location = new System.Drawing.Point(307, 144);
            this.txbEmpNum.Name = "txbEmpNum";
            this.txbEmpNum.Size = new System.Drawing.Size(227, 29);
            this.txbEmpNum.TabIndex = 7;
            // 
            // txbCheckout
            // 
            this.txbCheckout.Location = new System.Drawing.Point(307, 200);
            this.txbCheckout.Name = "txbCheckout";
            this.txbCheckout.Size = new System.Drawing.Size(227, 29);
            this.txbCheckout.TabIndex = 8;
            // 
            // txbCheckin
            // 
            this.txbCheckin.Location = new System.Drawing.Point(307, 252);
            this.txbCheckin.Name = "txbCheckin";
            this.txbCheckin.Size = new System.Drawing.Size(227, 29);
            this.txbCheckin.TabIndex = 9;
            // 
            // DatabaseLogs
            // 
            this.DatabaseLogs.FormattingEnabled = true;
            this.DatabaseLogs.HorizontalScrollbar = true;
            this.DatabaseLogs.ItemHeight = 20;
            this.DatabaseLogs.Location = new System.Drawing.Point(814, 35);
            this.DatabaseLogs.Name = "DatabaseLogs";
            this.DatabaseLogs.ScrollAlwaysVisible = true;
            this.DatabaseLogs.Size = new System.Drawing.Size(655, 584);
            this.DatabaseLogs.TabIndex = 10;
            // 
            // btnEmp
            // 
            this.btnEmp.Location = new System.Drawing.Point(624, 65);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(121, 54);
            this.btnEmp.TabIndex = 11;
            this.btnEmp.Text = "Employee Database";
            this.btnEmp.UseVisualStyleBackColor = true;
            // 
            // btnToolDB
            // 
            this.btnToolDB.Location = new System.Drawing.Point(624, 144);
            this.btnToolDB.Name = "btnToolDB";
            this.btnToolDB.Size = new System.Drawing.Size(121, 54);
            this.btnToolDB.TabIndex = 12;
            this.btnToolDB.Text = "Tool Database";
            this.btnToolDB.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(143, 342);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(207, 55);
            this.btnUpdateEmp.TabIndex = 13;
            this.btnUpdateEmp.Text = "Update Employee Info";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.Location = new System.Drawing.Point(143, 438);
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(207, 58);
            this.btnUpdateTool.TabIndex = 14;
            this.btnUpdateTool.Text = "Mange Tool Database";
            this.btnUpdateTool.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 632);
            this.Controls.Add(this.btnUpdateTool);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.btnToolDB);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.DatabaseLogs);
            this.Controls.Add(this.txbCheckin);
            this.Controls.Add(this.txbCheckout);
            this.Controls.Add(this.txbEmpNum);
            this.Controls.Add(this.txbEmpLname);
            this.Controls.Add(this.txbEmpFname);
            this.Controls.Add(this.lblCheckin);
            this.Controls.Add(this.lblCheckout);
            this.Controls.Add(this.lblEmpNum);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblEmpNum;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.TextBox txbEmpFname;
        private System.Windows.Forms.TextBox txbEmpLname;
        private System.Windows.Forms.TextBox txbEmpNum;
        private System.Windows.Forms.TextBox txbCheckout;
        private System.Windows.Forms.TextBox txbCheckin;
        private System.Windows.Forms.ListBox DatabaseLogs;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Button btnToolDB;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnUpdateTool;
    }
}

