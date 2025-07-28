namespace BankProject
{
    partial class UserForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            slidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuBtn = new PictureBox();
            panel3 = new Panel();
            btnHome = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            btnCardDetails = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel2 = new Panel();
            panel10 = new Panel();
            btnLogOut = new Button();
            SliderBarTimer = new System.Windows.Forms.Timer(components);
            btnDeposit = new Button();
            btnTransfer = new Button();
            btnWithdrawl = new Button();
            txtCurrentBalance = new TextBox();
            ListBoxTransactionHis = new ListBox();
            lblCurrentBalance = new Label();
            m4mohem = new Label();
            lblGreetings = new Label();
            slidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // slidebar
            // 
            slidebar.BackColor = Color.DarkRed;
            slidebar.Controls.Add(panel1);
            slidebar.Controls.Add(panel3);
            slidebar.Controls.Add(panel5);
            slidebar.Controls.Add(panel6);
            slidebar.Controls.Add(panel7);
            slidebar.Controls.Add(panel8);
            slidebar.Controls.Add(panel9);
            slidebar.Controls.Add(panel2);
            slidebar.Controls.Add(panel10);
            slidebar.Dock = DockStyle.Left;
            slidebar.Location = new Point(0, 0);
            slidebar.MaximumSize = new Size(278, 725);
            slidebar.MinimumSize = new Size(83, 725);
            slidebar.Name = "slidebar";
            slidebar.Size = new Size(278, 725);
            slidebar.TabIndex = 1;
            slidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 125);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 43);
            label1.Name = "label1";
            label1.Size = new Size(90, 38);
            label1.TabIndex = 5;
            label1.Text = "Menu";
            // 
            // MenuBtn
            // 
            MenuBtn.Image = (Image)resources.GetObject("MenuBtn.Image");
            MenuBtn.Location = new Point(9, 37);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(58, 52);
            MenuBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MenuBtn.TabIndex = 0;
            MenuBtn.TabStop = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnHome);
            panel3.Location = new Point(3, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 60);
            panel3.TabIndex = 5;
            // 
            // btnHome
            // 
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(-10, -13);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 0, 0, 0);
            btnHome.Size = new Size(296, 84);
            btnHome.TabIndex = 4;
            btnHome.Text = "         Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += button2_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 200);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 60);
            panel5.TabIndex = 7;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-10, -13);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(296, 84);
            button4.TabIndex = 4;
            button4.Text = "         Accounts ";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCardDetails);
            panel6.Location = new Point(3, 266);
            panel6.Name = "panel6";
            panel6.Size = new Size(275, 60);
            panel6.TabIndex = 8;
            // 
            // btnCardDetails
            // 
            btnCardDetails.FlatStyle = FlatStyle.Flat;
            btnCardDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCardDetails.ForeColor = SystemColors.ButtonHighlight;
            btnCardDetails.Image = (Image)resources.GetObject("btnCardDetails.Image");
            btnCardDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.Location = new Point(-10, -13);
            btnCardDetails.Name = "btnCardDetails";
            btnCardDetails.Padding = new Padding(30, 0, 0, 0);
            btnCardDetails.Size = new Size(296, 84);
            btnCardDetails.TabIndex = 4;
            btnCardDetails.Text = "         Card Details";
            btnCardDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.UseVisualStyleBackColor = true;
            btnCardDetails.Click += button1_Click;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 332);
            panel7.Name = "panel7";
            panel7.Size = new Size(275, 60);
            panel7.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Location = new Point(3, 398);
            panel8.Name = "panel8";
            panel8.Size = new Size(275, 60);
            panel8.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.Location = new Point(3, 464);
            panel9.Name = "panel9";
            panel9.Size = new Size(275, 35);
            panel9.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 505);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 60);
            panel2.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnLogOut);
            panel10.Location = new Point(3, 571);
            panel10.Name = "panel10";
            panel10.Size = new Size(275, 60);
            panel10.TabIndex = 5;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ButtonHighlight;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(-10, -13);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(30, 0, 0, 0);
            btnLogOut.Size = new Size(296, 84);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "         Log out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // SliderBarTimer
            // 
            SliderBarTimer.Interval = 1;
            SliderBarTimer.Tick += SliderBar_Tick;
            // 
            // btnDeposit
            // 
            btnDeposit.FlatStyle = FlatStyle.Popup;
            btnDeposit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeposit.ForeColor = Color.Linen;
            btnDeposit.Location = new Point(326, 643);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(231, 57);
            btnDeposit.TabIndex = 6;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.FlatStyle = FlatStyle.Popup;
            btnTransfer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransfer.ForeColor = Color.Linen;
            btnTransfer.Location = new Point(598, 643);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(231, 57);
            btnTransfer.TabIndex = 7;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnWithdrawl
            // 
            btnWithdrawl.FlatStyle = FlatStyle.Popup;
            btnWithdrawl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdrawl.ForeColor = Color.Linen;
            btnWithdrawl.Location = new Point(894, 643);
            btnWithdrawl.Name = "btnWithdrawl";
            btnWithdrawl.Size = new Size(231, 57);
            btnWithdrawl.TabIndex = 9;
            btnWithdrawl.Text = "Withdraw";
            btnWithdrawl.UseVisualStyleBackColor = true;
            btnWithdrawl.Click += btnWithdrawl_Click;
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCurrentBalance.Location = new Point(561, 554);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(292, 44);
            txtCurrentBalance.TabIndex = 10;
            txtCurrentBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // ListBoxTransactionHis
            // 
            ListBoxTransactionHis.BackColor = Color.Black;
            ListBoxTransactionHis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            ListBoxTransactionHis.ForeColor = Color.Transparent;
            ListBoxTransactionHis.FormattingEnabled = true;
            ListBoxTransactionHis.ItemHeight = 28;
            ListBoxTransactionHis.Location = new Point(284, 211);
            ListBoxTransactionHis.Name = "ListBoxTransactionHis";
            ListBoxTransactionHis.Size = new Size(930, 284);
            ListBoxTransactionHis.TabIndex = 11;
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            lblCurrentBalance.Location = new Point(573, 105);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(0, 38);
            lblCurrentBalance.TabIndex = 13;
            lblCurrentBalance.Click += lblCurrentBalance_Click;
            // 
            // m4mohem
            // 
            m4mohem.AutoSize = true;
            m4mohem.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            m4mohem.Location = new Point(326, 105);
            m4mohem.Name = "m4mohem";
            m4mohem.Size = new Size(398, 38);
            m4mohem.TabIndex = 12;
            m4mohem.Text = "Current Balance:                L.E.";
            // 
            // lblGreetings
            // 
            lblGreetings.AutoSize = true;
            lblGreetings.Font = new Font("Vivaldi", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGreetings.Location = new Point(317, 9);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(261, 55);
            lblGreetings.TabIndex = 14;
            lblGreetings.Text = "Greetings, user!";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1237, 728);
            Controls.Add(lblGreetings);
            Controls.Add(lblCurrentBalance);
            Controls.Add(m4mohem);
            Controls.Add(ListBoxTransactionHis);
            Controls.Add(txtCurrentBalance);
            Controls.Add(btnWithdrawl);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(slidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            FormClosing += UserForm_FormClosing;
            Load += UserForm_Load;
            slidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel slidebar;
        private Panel panel1;
        private Panel panel2;
        private Button btnCardDetails;
        private Panel panel3;
        private Button btnHome;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Button btnLogOut;
        private PictureBox MenuBtn;
        private System.Windows.Forms.Timer SliderBarTimer;
        private Button btnDeposit;
        private Button btnTransfer;
        private Button btnWithdrawl;
        private TextBox txtCurrentBalance;
        private ListBox ListBoxTransactionHis;
        private Label lblCurrentBalance;
        private Label m4mohem;
        private Label lblGreetings;
    }
}