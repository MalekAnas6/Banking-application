namespace BankProject
{
    partial class CardDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDetails));
            SliderBar = new FlowLayoutPanel();
            panMenu = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            MenuBtn = new PictureBox();
            panHome = new Panel();
            BtnHome = new Button();
            panTranscations = new Panel();
            btnCardDetails = new Button();
            panAccounts = new Panel();
            button2 = new Button();
            SliderBarTimer = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            pictureBox1 = new PictureBox();
            lblCardNumber = new Label();
            lblDate = new Label();
            lblName = new Label();
            lblCVV = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SliderBar.SuspendLayout();
            panMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            panHome.SuspendLayout();
            panTranscations.SuspendLayout();
            panAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SliderBar
            // 
            SliderBar.BackColor = Color.FromArgb(50, 47, 45);
            SliderBar.Controls.Add(panMenu);
            SliderBar.Controls.Add(panHome);
            SliderBar.Controls.Add(panTranscations);
            SliderBar.Controls.Add(panAccounts);
            SliderBar.ForeColor = SystemColors.ButtonHighlight;
            SliderBar.Location = new Point(0, 0);
            SliderBar.MaximumSize = new Size(278, 726);
            SliderBar.MinimumSize = new Size(83, 726);
            SliderBar.Name = "SliderBar";
            SliderBar.Size = new Size(278, 726);
            SliderBar.TabIndex = 0;
            SliderBar.Paint += SliderBar_Tick;
            // 
            // panMenu
            // 
            panMenu.Controls.Add(panel1);
            panMenu.Location = new Point(3, 3);
            panMenu.Name = "panMenu";
            panMenu.Size = new Size(307, 148);
            panMenu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuBtn);
            panel1.Location = new Point(-1, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 123);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
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
            label1.Click += label1_Click;
            // 
            // MenuBtn
            // 
            MenuBtn.Image = (Image)resources.GetObject("MenuBtn.Image");
            MenuBtn.Location = new Point(9, 38);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(58, 52);
            MenuBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MenuBtn.TabIndex = 0;
            MenuBtn.TabStop = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // panHome
            // 
            panHome.Controls.Add(BtnHome);
            panHome.Location = new Point(3, 157);
            panHome.Name = "panHome";
            panHome.Size = new Size(273, 93);
            panHome.TabIndex = 0;
            // 
            // BtnHome
            // 
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHome.ForeColor = Color.LightGray;
            BtnHome.Image = (Image)resources.GetObject("BtnHome.Image");
            BtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHome.Location = new Point(-16, -9);
            BtnHome.Name = "BtnHome";
            BtnHome.Padding = new Padding(30, 0, 0, 0);
            BtnHome.Size = new Size(389, 123);
            BtnHome.TabIndex = 2;
            BtnHome.Text = "       Home";
            BtnHome.TextAlign = ContentAlignment.MiddleLeft;
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += MenuBtn_Click;
            // 
            // panTranscations
            // 
            panTranscations.Controls.Add(btnCardDetails);
            panTranscations.Location = new Point(3, 256);
            panTranscations.Name = "panTranscations";
            panTranscations.Size = new Size(282, 77);
            panTranscations.TabIndex = 0;
            // 
            // btnCardDetails
            // 
            btnCardDetails.FlatStyle = FlatStyle.Flat;
            btnCardDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCardDetails.ForeColor = SystemColors.ButtonHighlight;
            btnCardDetails.Image = (Image)resources.GetObject("btnCardDetails.Image");
            btnCardDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.Location = new Point(-17, -2);
            btnCardDetails.Name = "btnCardDetails";
            btnCardDetails.Padding = new Padding(30, 0, 0, 0);
            btnCardDetails.Size = new Size(296, 84);
            btnCardDetails.TabIndex = 5;
            btnCardDetails.Text = "         Card Details";
            btnCardDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.UseVisualStyleBackColor = true;
            // 
            // panAccounts
            // 
            panAccounts.BackgroundImageLayout = ImageLayout.None;
            panAccounts.Controls.Add(button2);
            panAccounts.Location = new Point(3, 339);
            panAccounts.Name = "panAccounts";
            panAccounts.Size = new Size(247, 97);
            panAccounts.TabIndex = 5;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightGray;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-17, -9);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(389, 123);
            button2.TabIndex = 4;
            button2.Text = "       Accounts";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SliderBarTimer
            // 
            SliderBarTimer.Enabled = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(50, 47, 45);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(223, 211, 201);
            button3.Location = new Point(567, 625);
            button3.Name = "button3";
            button3.Size = new Size(391, 68);
            button3.TabIndex = 1;
            button3.Text = "Reveal Card information";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(952, 616);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblCardNumber
            // 
            lblCardNumber.BackColor = Color.White;
            lblCardNumber.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardNumber.ForeColor = SystemColors.ActiveCaptionText;
            lblCardNumber.Location = new Point(581, 168);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(356, 36);
            lblCardNumber.TabIndex = 3;
            lblCardNumber.Text = "      6574   2039    4309    5674";
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.White;
            lblDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.ActiveCaptionText;
            lblDate.Location = new Point(839, 213);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(89, 47);
            lblDate.TabIndex = 4;
            lblDate.Text = "01/26";
            lblDate.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblName
            // 
            lblName.BackColor = Color.White;
            lblName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(567, 246);
            lblName.Name = "lblName";
            lblName.Size = new Size(266, 41);
            lblName.TabIndex = 5;
            lblName.Text = "   Name +Surname";
            // 
            // lblCVV
            // 
            lblCVV.BackColor = Color.White;
            lblCVV.ForeColor = SystemColors.ActiveCaptionText;
            lblCVV.Location = new Point(897, 469);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(40, 25);
            lblCVV.TabIndex = 6;
            lblCVV.Text = "598";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(567, 166);
            label2.Name = "label2";
            label2.Size = new Size(370, 36);
            label2.TabIndex = 7;
            label2.Text = "********************************************************************************************************************";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.ImageAlign = ContentAlignment.BottomRight;
            label3.Location = new Point(839, 212);
            label3.Name = "label3";
            label3.Size = new Size(89, 51);
            label3.TabIndex = 8;
            label3.Text = "****";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(567, 246);
            label4.Name = "label4";
            label4.Size = new Size(266, 41);
            label4.TabIndex = 9;
            label4.Text = "************************************************************************************";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(881, 468);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 10;
            label5.Text = "***********************************";
            // 
            // CardDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 211, 201);
            ClientSize = new Size(1237, 728);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCVV);
            Controls.Add(lblName);
            Controls.Add(lblDate);
            Controls.Add(lblCardNumber);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(SliderBar);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CardDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CardDetails";
            FormClosing += CardDetails_FormClosing;
            FormClosed += CardDetails_FormClosed;
            Load += CardDetails_Load;
            SliderBar.ResumeLayout(false);
            panMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            panHome.ResumeLayout(false);
            panTranscations.ResumeLayout(false);
            panAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel SliderBar;
        private Panel panMenu;
        private Button BtnHome;
        private Button button2;
        private Panel panHome;
        private Panel panTranscations;
        private Panel panAccounts;
        private Panel panel1;
        private Label label1;
        private PictureBox MenuBtn;
        private System.Windows.Forms.Timer SliderBarTimer;
        private Button button3;
        private PictureBox pictureBox1;
        private Label lblCardNumber;
        private Label lblDate;
        private Label lblName;
        private Label lblCVV;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCardDetails;
    }
}