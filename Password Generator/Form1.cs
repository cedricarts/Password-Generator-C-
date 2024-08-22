using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length;
            length = Convert.ToInt32(txtLength.Text);

                // Initialize the list of characters for the password
                List<string> pass1 = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "!", "@", "#", "$", "%", "^", "&", "*" };

                // Initialize an empty password string
                string password = "";

                // Create a random number generator
                Random random = new Random();

                // Loop to generate a 16-character password
                for (int x = 0; x < length; x++)
                {
                    // Select a random character from the list
                    string randomChar = pass1[random.Next(pass1.Count)];

                    // Add the selected character to the password
                    password += randomChar;
                }

                // Output the generated password
                lstDisplayPassword.Items.Add("Your new password is:");
                lstDisplayPassword.Items.Add(password);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstDisplayPassword.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
