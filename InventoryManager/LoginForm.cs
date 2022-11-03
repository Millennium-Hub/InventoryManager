using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace InventoryManager
{
    public partial class LoginForm : Form
    {
        MySqlConnection Conn = new MySqlConnection("server=localhost;user id=root;database=employeedatabase");
        MySqlCommand Cmd = new MySqlCommand();
        MySqlDataReader Dr;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                tPass.UseSystemPasswordChar = true;
            else
                tPass.UseSystemPasswordChar = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tUser.Clear();
            tPass.Clear();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Applicaton", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        { 
            try
        {
                
            Cmd = new MySqlCommand("SELECT * FROM `login` WHERE `username`=@username AND `password`=@password", Conn);
            Cmd.Parameters.AddWithValue("@username", tUser.Text);
            Cmd.Parameters.AddWithValue("@password", tPass.Text);
            Conn.Open();
            Dr = Cmd.ExecuteReader();
            Dr.Read();
            if (Dr.HasRows)
            {
               // MessageBox.Show("Welcome " + Dr["Fullname"].ToString() + " | ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "ACCESS DENITED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Conn.Close();
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            BringToFront();
        }
    }
}
