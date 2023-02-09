using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string userId = id.Text;
            string userPassword = password.Text;
            



            if (userId.Equals("MyId") && userPassword.Equals("MyPassword"))
            {
                MessageBox.Show("로그인에 성공했습니다.", "로그인");
            }
            else if (userId.Equals("qjatn147852")&&userPassword.Equals("iu1563"))
            {
                MessageBox.Show("You Have Being Accessed Administrator Account.", "관리자 계정 접속");

            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "로그인");
            }


        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            
        }
     

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            

          
        }

        private void id_MouseClick(object sender, MouseEventArgs e)
        {

 
        }
    }
}
