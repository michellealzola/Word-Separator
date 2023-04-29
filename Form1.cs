using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Separator
{
    public partial class frmWordSeparator : Form
    {
        public frmWordSeparator()
        {
            InitializeComponent();
        }

        private void btnSeparateWord_Click(object sender, EventArgs e)
        {
            lblOutSeparatedWord.Text = "";

            string word = tboxEntryWord.Text.Trim();

            List<string> charList = new List<string>();

            charList.Add(word[0].ToString());

            for(int i = 1; i < word.Length; i++)
            {
                char c = word[i];

                if(char.IsUpper(c))
                {
                    char lower = char.ToLower(c);
                    charList.Add(" " + lower.ToString());
                }
                else
                {
                    charList.Add(c.ToString());
                }
            }

            for(int i = 0;i < charList.Count;i++)
            {
                lblOutSeparatedWord.Text += charList[i];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxEntryWord.Text = "";
            lblOutSeparatedWord.Text = "";

            tboxEntryWord.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
