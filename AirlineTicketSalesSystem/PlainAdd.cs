using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTicketSalesSystem
{
    public partial class PlainAdd : Form
    {
        PlainProcess plainProcess = new PlainProcess();
        RouteProcess routeProcess = new RouteProcess();
        public PlainAdd()
        {
            InitializeComponent();
        }



        private void btn_add_Click(object sender, EventArgs e)
        {

            Plain plain = new Plain();


            if (!String.IsNullOrWhiteSpace(txt_Id.Text) && !String.IsNullOrWhiteSpace(txt_route_ıd.Text) && !String.IsNullOrWhiteSpace(txt_seat_piece.Text) && !String.IsNullOrWhiteSpace(txtDepertureTime.Text) && !String.IsNullOrWhiteSpace(txt_price.Text))
            {
                plain.Id = Convert.ToInt32(txt_Id.Text);
                plain.RouteID = Convert.ToInt32(txt_route_ıd.Text);
                plain.seatPiece = Convert.ToInt32(txt_seat_piece.Text);
                plain.DepertureTime = (txtDepertureTime.Text).ToString();
                plain.Price = Convert.ToDouble(txt_price.Text);

                if (plainProcess.Add(plain))
                {
                    MessageBox.Show("Plain Add Successful");
                    txt_Id.Clear();
                    txt_route_ıd.Clear();
                    txt_seat_piece.Clear();
                    txtDepertureTime.Clear();
                    txt_price.Clear();
                    PlainListt();
                }
                else
                {
                    MessageBox.Show("Route Add Failed");
                }
            }
            else
            {
                MessageBox.Show("Değerler Boş geçilemez");
            }
        }
        public void PlainListt()
        {
            PlainList.Items.Clear();
            foreach (var plain in plainProcess.List().ToList())
            {
                PlainList.Items.Add("Plain : " + plain.Id + "  Route : " + plain.RouteID + "  Seat Piece :  " + plain.seatPiece + "Deperture Time : " + plain.DepertureTime + " Plain Price :  " + plain.Price);
            }
            
        }

        public void RouteListt()
        {
            RouteList.Items.Clear();
            foreach (var route in routeProcess.List().ToList())
            {
                RouteList.Items.Add(route.Id + "  " + route.startPoint + " " + route.endPoint);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var routee in DbContext.RouteList.ToList())
            {
                RouteList.Items.Add(routee);
            }
            RouteListt();

            foreach(var plains in DbContext.PlainList.ToList())
            {
                PlainList.Items.Add(plains);
            }
            PlainListt();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txt_Id.Text);

            if (plainProcess.Delete(id))
            {
                MessageBox.Show("Plain Delete Successful");
                PlainListt();
            }
            else
            {
                MessageBox.Show("Not Found Plain");
            }
        }

        private void PlainAdd_Load(object sender, EventArgs e)
        {
            DbContext db = new DbContext();
        }
    }
}
