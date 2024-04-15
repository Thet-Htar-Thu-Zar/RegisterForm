namespace RegisterForm
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
            panel1 = new Panel();
            btnregister = new Button();
            cborole = new ComboBox();
            txtemail = new TextBox();
            txtusername = new TextBox();
            lblusername = new Label();
            lblemail = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnregister);
            panel1.Controls.Add(cborole);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(lblusername);
            panel1.Controls.Add(lblemail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(7, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 408);
            panel1.TabIndex = 0;
            // 
            // btnregister
            // 
            btnregister.BackColor = Color.FromArgb(255, 128, 255);
            btnregister.Font = new Font("Corbel", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnregister.Location = new Point(366, 287);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(107, 49);
            btnregister.TabIndex = 7;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += btnregister_Click;
            // 
            // cborole
            // 
            cborole.FormattingEnabled = true;
            cborole.Items.AddRange(new object[] { "user ", "admin" });
            cborole.Location = new Point(282, 229);
            cborole.Name = "cborole";
            cborole.Size = new Size(151, 28);
            cborole.TabIndex = 6;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(282, 161);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(151, 27);
            txtemail.TabIndex = 5;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(282, 94);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(151, 27);
            txtusername.TabIndex = 4;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(169, 101);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(78, 20);
            lblusername.TabIndex = 3;
            lblusername.Text = "Username:";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(169, 168);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(49, 20);
            lblemail.TabIndex = 2;
            lblemail.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 232);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "User Role:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(193, 20);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 0;
            label1.Text = "Register Form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 415);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Register Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnregister;
        private ComboBox cborole;
        private TextBox txtemail;
        private TextBox txtusername;
        private Label lblusername;
        private Label lblemail;
        private Label label2;
        private Label label1;
    }
}
