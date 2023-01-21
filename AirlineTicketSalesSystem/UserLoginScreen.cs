using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirlineTicketSalesSystem
{
    public partial class UserLoginScreen : Form
    {
        User user = new User();
   
        public UserLoginScreen()
        {
            InitializeComponent();
        }
        bool status = false;
        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            User user1 = new User()
            {
                Id = 1,
                Name = "Irem",
                Surname = "Erbaş",
                UserName = "irem",
                Password = "123",
                Email = "erbasireem@gmailcom."
            };
            DbContext.UserList.Add(user1);

            User user2 = new User()
            {
                Id = 2,
                Name = "Eymen",
                Surname = "Erbaş",
                UserName = "eymen",
                Password = "123",
                Email = "eymenerbas@gmailcom."
            };
            DbContext.UserList.Add(user2);


            
            foreach (var users in DbContext.UserList.ToList())
            {
                if (txt_username.Text == users.UserName.ToString() && txt_password.Text == users.Password.ToString())
                {
                    status = true;
                    users.OpenClose = true;
                    txt_username.Clear();
                    txt_password.Clear();
                }

            }
            if (status)
            {
                //CustomerTicket customerTicket = new CustomerTicket();
                //this.Hide();
                //customerTicket.ShowDialog();
                //this.Show();

                AirlineTicketSalesSystem airlineTicketSalesSystem = new AirlineTicketSalesSystem();
                this.Hide();
                airlineTicketSalesSystem.ShowDialog();
                this.Show();


                //CustomerLogin customerLogin = new CustomerLogin();
                //this.Hide();
                //customerLogin.ShowDialog();
                //this.Show();
                status = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalı");
            }























        }

    }
}
