using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Cracker
{
    public partial class frmPasswordCracker : Form
    {

        public frmPasswordCracker()
        {
            InitializeComponent();
        }
        const int MaxPasswords = 10;
        const string fail = "*Fail*";
    

        List<password> passwords = new List<password>()
        {
            new password ("123456","e10adc3949ba59abbe56e057f20f883e"),
            new password ("123456789", "25f9e794323b453885f5181f1b624d0b"),
            new password ("qwerty","d8578edf8458ce06fbc5bb76a58c5ca4"),
            new password ("111111","96e79218965eb72c92a549dd5a330112"),
            new password ("password","5f4dcc3b5aa765d61d8327deb882cf99"),
            new password ( "qwertyuiop","6eea9b7ef19179a06954edd0f6c05ceb"),
            new password ("123321","c8837b23ff8aaa8a2dde915473ce0991"),
            new password ("google", "c822c1b63853ed273b89687ac505f9fa"),
            new password ("P@ssw0rd","161ebd7d45089b3446ee4e0d86dbcf92" ),
            new password ("Tr0ub4dor&3","4ece57a61323b52ccffdbef021956754")
        };


        private void btnCrack_Click(object sender, EventArgs e)
        {
            int position = SearchPasswords();
            if (position >= 0 && position <= MaxPasswords)
            {
                CrackPassword(position);
            }
            else
            {
                PasswordNotFound();
            }
        }
        private int SearchPasswords()
        {
            string st = txtHash.Text.Trim();
            for (int lcv = 0; lcv < MaxPasswords; lcv++)
            {
                if (passwords[lcv].GetHash().ToLower() == st)
                {
                    return lcv;
                }
            }

            return -1;
        }
        private void PasswordNotFound()
        {
            lbError.Items.Add(fail);
        }
        private void CrackPassword( int position)
        {
            lbError.Items.Clear();
            lbError.Items.Add(passwords[position].GetRaw());
            

        }
        
    }
}
