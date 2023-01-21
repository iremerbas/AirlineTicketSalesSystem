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
    public partial class RouteAdd : Form
    {
        RouteProcess routeProcess = new RouteProcess();
        public RouteAdd()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Route route = new Route();
        

            if (!String.IsNullOrWhiteSpace(txt_Id.Text) && !String.IsNullOrWhiteSpace(txt_startPoint.Text) && !String.IsNullOrWhiteSpace(txt_endPoint.Text))
            {
                route.Id = Convert.ToInt32(txt_Id.Text);
                route.startPoint = txt_startPoint.Text;
                route.endPoint = txt_endPoint.Text;
                
                if (routeProcess.Add(route))
                {
                    MessageBox.Show("Route Add Successful");
                    txt_Id.Clear();
                    txt_startPoint.Clear();
                    txt_endPoint.Clear();
                    RouteListt();
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

        public void RouteListt()
        {
            RouteList.Items.Clear();
            foreach (var route in routeProcess.List().ToList())
            {
                RouteList.Items.Add(route.Id + "  " + route.startPoint + " " + route.endPoint);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txt_Id.Text);

            if (routeProcess.Delete(id))
            {
                MessageBox.Show("Route Delete Successful");
                RouteListt();
            }
            else
            {
                MessageBox.Show("Not Found Route");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var routee in DbContext.RouteList.ToList())
            {
                RouteList.Items.Add(routee);
            }
            RouteListt();
        }

        private void RouteAdd_Load(object sender, EventArgs e)
        {
            DbContext db = new DbContext();
        }
    }
}
