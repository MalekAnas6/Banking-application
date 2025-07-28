using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms.VisualStyles;
using System.Runtime.CompilerServices;

namespace BankProject
{
    public partial class UserForm : Form
    {
        private Client client;
        public UserForm(Client client)
        {
            InitializeComponent();
            this.client = client;

            lblGreetings.Text = $"Greetings, {client.Name}!";

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            slidebar.BackColor = ColorTranslator.FromHtml("#322f2d");
        }



        private void UserForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#dfd3c9");
            ListBoxTransactionHis.ForeColor = ColorTranslator.FromHtml("#322f2d");
            ListBoxTransactionHis.BackColor = ColorTranslator.FromHtml("#dfd3c9");
            btnDeposit.BackColor = ColorTranslator.FromHtml("#322f2d");
            btnTransfer.BackColor = ColorTranslator.FromHtml("#322f2d");
            btnWithdrawl.BackColor = ColorTranslator.FromHtml("#322f2d");

            if (File.Exists($"balance_{client.Username}.txt"))
            {
                string savedBalance = File.ReadAllText($"balance_{client.Username}.txt");
                if (decimal.TryParse(savedBalance, out decimal balance))
                {
                    client.Account.Balance = balance;
                }
            }
            ListBoxTransactionHis.Items.Clear();
            // Load transaction history
            foreach (var item in client.Account.GetHistory())
            {
                ListBoxTransactionHis.Items.Add(item);
            }

            LoadSavedData();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardDetails cards = new CardDetails(client);
            cards.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accounts accountsForm = new Accounts(client);
            accountsForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult LogOut = MessageBox.Show("Are you sure you want to log out ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (LogOut == DialogResult.Yes)
            {
                exitConfirmed = true; 
                Application.OpenForms[0].Show();
                this.Close();  
            }
            else
            {
                MessageBox.Show("Log out unsuccesful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        bool SliderBarExpand;

        private void SliderBar_Tick(object sender, EventArgs e)
        {
            if (SliderBarExpand) // checks if the sidebar is expanded
            {
                slidebar.Width -= 10; // decreases the width by 10px each timer click 

                if (slidebar.Width == slidebar.MinimumSize.Width) // law el sidebar reached min width 
                {
                    SliderBarExpand = false; // keda 5alas el sidebar collapsed 
                    SliderBarTimer.Stop();   // stops the timer bema 2n el animation 5elset 
                }
            }
            else
            {
                slidebar.Width += 10; // Expands the sidebar 
                if (slidebar.Width == slidebar.MaximumSize.Width) // law el sidebar reached max width 
                {
                    SliderBarExpand = true; // keda 5alas el sidebar expanded
                    SliderBarTimer.Stop();  // stops the timer bema 2n el animation 5elset 
                }
            }
        }

        private void SideBar(object sender, PaintEventArgs e)
        {

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            SliderBarTimer.Start(); // Starts the timer of the animation
        }



        private void BlnceHistotry_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCurrentBalance.Text))
                {
                    MessageBox.Show("Please enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal Deposit = Convert.ToDecimal(txtCurrentBalance.Text);
                decimal Balance = client.Account.Balance;
                DialogResult Dr = MessageBox.Show($"Are you sure you want to Deposit {Deposit} L.E.?", "Confirmation", MessageBoxButtons.YesNo);
                if (Dr == DialogResult.Yes)
                {
                    if (client.Account.Deposit(Deposit))
                    {
                        UpdateHistoryGUI();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Deposit Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lblCurrentBalance.Text = Balance.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //private void btnDeposit_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(txtCurrentBalance.Text))
        //        {
        //            MessageBox.Show("Please enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        decimal Deposit = Convert.ToDecimal(txtCurrentBalance.Text);
        //        decimal Balance = client.Account.Balance;
        //        DialogResult Dr = MessageBox.Show($"Are you sure you want to Deposit {Deposit} L.E.?", "Confirmation", MessageBoxButtons.YesNo);
        //        if (Dr == DialogResult.Yes)
        //        {
        //            if (client.Account.Deposit(Deposit))
        //            {
        //                UpdateHistoryGUI();
        //                return;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Deposit Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        lblCurrentBalance.Text = Balance.ToString();


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Please enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        private void btnWithdrawl_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCurrentBalance.Text))
                {
                    MessageBox.Show("Please enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                decimal Withdrawal = Convert.ToDecimal(txtCurrentBalance.Text);
                decimal Balance = client.Account.Balance;

                DialogResult Dr = MessageBox.Show($"Are you sure you want to withdrawl {Withdrawal} L.E.?", "Confirmation", MessageBoxButtons.YesNo);
                if (Dr == DialogResult.Yes)
                {
                    if (client.Account.Withdraw(Withdrawal))
                    {
                        UpdateHistoryGUI();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Insufficent amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtCurrentBalance.Text = null;

                }
                else
                {
                    MessageBox.Show("Withdraw Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lblCurrentBalance.Text = Balance.ToString();

            }
            catch
            {
                MessageBox.Show("Please enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SaveData(Client c)
        {
            string filePath = $"balance_{c.Username}.txt";
            File.WriteAllText(filePath, c.Account.Balance.ToString());
        }
        private void LoadSavedData()
        {
            string filePath = $"balance_{client.Username}.txt";
            if (File.Exists(filePath))
            {
                lblCurrentBalance.Text = File.ReadAllText(filePath);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            decimal val;

            // decimal error checking

            try
            {
                val = Convert.ToDecimal(txtCurrentBalance.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Not a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // money check
            if (val > client.Account.Balance)
            {
                MessageBox.Show("Balance Insufficient", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (val <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string receiverUsername = Interaction.InputBox("Enter the username of the reciever: ", "Transfer Operation", "", -1, -1);

            // name input check
            if (string.IsNullOrEmpty(receiverUsername))
            {
                MessageBox.Show("Please enter the username of the reciever", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // sending to oneself
            if (client.Username == receiverUsername)
            {
                MessageBox.Show("You cannot transfer to yourself!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Client receiver = LoginForm.clients.FirstOrDefault(c => c.Username == receiverUsername);

            // reciever not found
            if (receiverUsername == null)
            {
                MessageBox.Show("Account DOES NOT exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string FilPathReceiver = $"balance_{receiverUsername}.txt";

            if (!File.Exists(FilPathReceiver))
            {
                MessageBox.Show("Receiver account does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Read receiver's current balance
                string receiverBalanceText = File.ReadAllText(FilPathReceiver);
                if (!decimal.TryParse(receiverBalanceText, out decimal receiverBalance))
                {
                    MessageBox.Show("Receiver's balance file is corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                receiverBalance += val;
                client.Account.Balance -= val;


                File.WriteAllText(FilPathReceiver, receiverBalance.ToString());
                SaveData(client);

                client.Account.history.Add($"Transferred: {val} EGP to {receiverUsername} on {DateTime.Now}");
                UpdateHistoryGUI();

                //MessageBox.Show($"Successfully transferred {val} L.E. to {receiverUsername}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Transfer failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






            //if (client.Account.Transfer(receiver, val))
            //{
            //    //UpdateReceiverBalanceFile(receiver);
            //   // File.WriteAllText(FilPathReceiver,receiverUsername.1)
            //    UpdateHistoryGUI();
            //    SaveData(receiver);
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Something went wrong.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }
        private void UpdateHistoryGUI()
        {
            lblCurrentBalance.Text = client.Account.Balance.ToString();
            ListBoxTransactionHis.Items.Clear();
            foreach (var item in client.Account.GetHistory())
            {
                ListBoxTransactionHis.Items.Add(item);
            }
            SaveData(client);
            txtCurrentBalance.Text = null;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCurrentBalance_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxTransactionHis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool exitConfirmed = false;
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitConfirmed)
            {
                DialogResult LogOut = MessageBox.Show("Are you sure you want to exit the program?","Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (LogOut == DialogResult.Yes)
                {
                    exitConfirmed = true; 
                    Application.Exit();   
                }
                else
                {
                    e.Cancel = true; 
                }
            }



        }
    }
}
