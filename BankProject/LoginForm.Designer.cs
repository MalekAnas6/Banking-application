namespace BankProject
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            ProjectName = new Label();
            lblusername = new Label();
            lblpassword = new Label();
            txtUsername = new TextBox();
            txtPassowrd = new TextBox();
            btnLogIn = new Button();
            bindingSource1 = new BindingSource(components);
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ProjectName
            // 
            ProjectName.AutoSize = true;
            ProjectName.Font = new Font("Vivaldi", 46.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ProjectName.Location = new Point(-14, 145);
            ProjectName.Name = "ProjectName";
            ProjectName.Size = new Size(821, 92);
            ProjectName.TabIndex = 0;
            ProjectName.Text = "Celestia International Bank";
            ProjectName.Click += ProjectName_Click;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(148, 255);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(166, 41);
            lblusername.TabIndex = 2;
            lblusername.Text = "Username:";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.Location = new Point(148, 383);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(158, 41);
            lblpassword.TabIndex = 3;
            lblpassword.Text = "Password:";
            lblpassword.Click += lblpassword_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(156, 310);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(448, 27);
            txtUsername.TabIndex = 4;
            toolTip1.SetToolTip(txtUsername, "Enter Username");
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassowrd
            // 
            txtPassowrd.Location = new Point(156, 440);
            txtPassowrd.Name = "txtPassowrd";
            txtPassowrd.PasswordChar = '*';
            txtPassowrd.Size = new Size(448, 27);
            txtPassowrd.TabIndex = 5;
            toolTip1.SetToolTip(txtPassowrd, "Enter Password ");
            txtPassowrd.TextChanged += txtPassowrd_TextChanged;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DarkGray;
            btnLogIn.FlatStyle = FlatStyle.Popup;
            btnLogIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.Black;
            btnLogIn.Location = new Point(130, 528);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(236, 66);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "Log in";
            toolTip1.SetToolTip(btnLogIn, "Click on the button");
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Info";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(433, 528);
            button1.Name = "button1";
            button1.Size = new Size(236, 66);
            button1.TabIndex = 9;
            button1.Text = "Create account";
            toolTip1.SetToolTip(button1, "Click on the button ya baba");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1237, 728);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(ProjectName);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(lblusername);
            panel1.Controls.Add(lblpassword);
            panel1.Controls.Add(txtPassowrd);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(225, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 642);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(503, 483);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bank__2_;
            pictureBox2.Location = new Point(313, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1237, 728);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CIB";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label ProjectName;
        private Label lblusername;
        private Label lblpassword;
        private TextBox txtUsername;
        private TextBox txtPassowrd;
        private Button btnLogIn;
        private BindingSource bindingSource1;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private Button button1;
    }
}
