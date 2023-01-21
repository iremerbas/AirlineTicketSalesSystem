using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTicketSalesSystem
{
    public partial class AirlineTicketSalesSystem : Form
    {
        bool status = false;
        SelectedtTicket selectedTicket = new SelectedtTicket();

        bool IsTicket = false;
        public AirlineTicketSalesSystem()
        {
            InitializeComponent();
        }
        Route routee = new Route();
        Customer customer = new Customer();



        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var customers in DbContext.CustomerList.ToList())
            {
                if (txt_TC.Text == customers.TC.ToString())
                {
                    status = true;
                    customers.OpenClose = true;
                }
            }

            if (status)
            {
                if (!String.IsNullOrWhiteSpace(cmb_nereden.Text) && !String.IsNullOrWhiteSpace(cmb_nereye.Text) && !String.IsNullOrWhiteSpace(cmb_Yolcu.Text) && !String.IsNullOrWhiteSpace(txt_TC.Text))
                {
                    int selectedRoute = Route(cmb_nereden.SelectedItem.ToString(), cmb_nereye.SelectedItem.ToString());
                    int[] avaible_plains = Plain(selectedRoute);
                    SelectedtTicket selectedtTicket = new SelectedtTicket();
                    int ylocation = 10;





                    foreach (var plain in DbContext.PlainList.ToList())
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (avaible_plains[i] == plain.Id)
                            {
                                IsTicket = true;
                                GroupBox ticket = new GroupBox()
                                {
                                    Name = "btn_deneme",
                                    Text = "Flight Ticket Times",
                                    Location = new Point(10, ylocation),
                                    Size = new System.Drawing.Size(1200, 200)
                                };
                                ylocation += 220;
                                selectedTicket.Controls.Add(ticket);

                                Label depertureTime = new Label()
                                {
                                    AutoSize = true,
                                    Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                    Location = new System.Drawing.Point(26, 54),
                                    Margin = new System.Windows.Forms.Padding(4, 0, 4, 0),
                                    Name = "zaman_lbl",
                                    Size = new System.Drawing.Size(55, 20),
                                    //TabIndex = 129,
                                    Text = plain.DepertureTime.ToString()

                                };
                                ticket.Controls.Add(depertureTime);

                                Label startPoint = new Label()
                                {
                                    AutoSize = true,
                                    Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                    ForeColor = System.Drawing.Color.DimGray,
                                    Location = new System.Drawing.Point(21, 100),
                                    Margin = new System.Windows.Forms.Padding(4, 0, 4, 0),
                                    Name = "nereden2",
                                    Size = new System.Drawing.Size(58, 18),
                                    TabIndex = 134,
                                    Text = cmb_nereden.Text
                                };
                                ticket.Controls.Add(startPoint);

                                Label direkt = new Label()
                                {
                                    AutoSize = true,
                                    ForeColor = System.Drawing.Color.DimGray,
                                    Location = new System.Drawing.Point(168, 54),
                                    Margin = new System.Windows.Forms.Padding(4, 0, 4, 0),
                                    Name = "label16",
                                    Size = new System.Drawing.Size(42, 16),
                                    TabIndex = 124,
                                    Text = "Direkt"
                                };
                                ticket.Controls.Add(direkt);

                                Label cizgi = new Label()
                                {
                                    AutoSize = true,
                                    BackColor = System.Drawing.Color.White,
                                    Location = new System.Drawing.Point(84, 73),
                                    Margin = new System.Windows.Forms.Padding(4, 0, 4, 0),
                                    Name = "label20",
                                    Size = new System.Drawing.Size(203, 16),
                                    TabIndex = 117,
                                    Text = "____________________________"
                                };
                                ticket.Controls.Add(cizgi);

                                Label nereye = new Label()
                                {
                                    AutoSize = true,
                                    Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                    ForeColor = System.Drawing.Color.DimGray,
                                    Location = new System.Drawing.Point(357, 89),
                                    Margin = new System.Windows.Forms.Padding(4, 0, 4, 0),
                                    Name = "nereye3",
                                    Size = new System.Drawing.Size(54, 18),
                                    TabIndex = 120,
                                    Text = cmb_nereye.Text
                                };
                                ticket.Controls.Add(nereye);

                                Button TicketSelect = new Button()
                                {
                                    BackColor = System.Drawing.Color.Red,
                                    Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                    ForeColor = System.Drawing.Color.White,
                                    Location = new System.Drawing.Point(856, 54),
                                    Margin = new System.Windows.Forms.Padding(4),
                                    Name = "button" + plain.Id.ToString(),
                                    Size = new System.Drawing.Size(224, 43),
                                    TabIndex = 130,
                                    Text = "Book a flight"

                                };
                                TicketSelect.Click += TicketSelect_Click;
                                ticket.Controls.Add(TicketSelect);



                                Label Price = new Label()
                                {
                                    AutoSize = true,
                                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                    Location = new System.Drawing.Point(619, 70),
                                    Margin = new System.Windows.Forms.Padding(4, 0, 4, 0),
                                    Name = "label29",
                                    Size = new System.Drawing.Size(132, 25),
                                    TabIndex = 127,
                                    Text = "TRY" + " " + plain.Price.ToString()
                                };
                                ticket.Controls.Add(Price);
                            }

                        }
                        customer.OpenClose = false;
                    }
                    this.Hide();
                    selectedTicket.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Değerler boş geçilmez");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir müşteri sistemimizde kayıtlı değildir.");
            }

        }


        private void TicketSelect_Click(object sender, EventArgs e)
        {
            bool status = false;
            int selectedRoute = Route(cmb_nereden.SelectedItem.ToString(), cmb_nereye.SelectedItem.ToString());
            int[] avaible_plains = Plain(selectedRoute);


            //foreach (var customers in DbContext.CustomerList.ToList())
            //{
            //    if (txt_TC.Text == customers.TC.ToString())
            //    {
            //        status = true;
            //        customers.OpenClose = true;
            //    }
            //}

            foreach (var customer in DbContext.CustomerList.ToList())
            {
                if (customer.OpenClose)
                {
                    foreach (var plain in DbContext.PlainList.ToList())
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (avaible_plains[i] == plain.Id)
                            {
                                Button clickButton = (Button)sender;
                                for (int k = 0; k < plain.DepertureTime.Length; k++)
                                {
                                    int saat = Convert.ToInt32(DateTime.Now.ToString("HHmm"));
                                    int yenisaat = Convert.ToInt32(plain.DepertureTime.Replace(":", ""));

                                    if (yenisaat > saat)
                                    {
                                        if (clickButton.Name == "button" + plain.Id)
                                        {
                                            if (plain.seatPiece >= Convert.ToInt32(cmb_Yolcu.Text))
                                            {
                                                plain.seatPiece -= Convert.ToInt32(cmb_Yolcu.Text);

                                                if (customer.Balance >= (Convert.ToInt32(cmb_Yolcu.Text) * plain.Price))
                                                {
                                                    customer.Balance -= (Convert.ToInt32(cmb_Yolcu.Text) * plain.Price);
                                                    TicketReceipt ticketReceipt = new TicketReceipt();

                                                    Label title = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                                        Location = new System.Drawing.Point(278, 20),
                                                        Name = "lbl_HavaYollari",
                                                        Size = new System.Drawing.Size(238, 29),
                                                        TabIndex = 0,
                                                        Text = "RM HAVA YOLLARI",
                                                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))))
                                                    };
                                                    ticketReceipt.Controls.Add(title);

                                                    Label passenger = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                                        Location = new System.Drawing.Point(22, 73),
                                                        Name = "lbl_passenger",
                                                        Size = new System.Drawing.Size(102, 17),
                                                        Text = "PASSENGER",
                                                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))))
                                                    };
                                                    ticketReceipt.Controls.Add(passenger);

                                                    Label flight = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                                        Location = new System.Drawing.Point(22, 191),
                                                        Name = "lbl_flight",
                                                        Size = new System.Drawing.Size(63, 17),
                                                        TabIndex = 0,
                                                        Text = "FLIGHT",
                                                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))))


                                                    };
                                                    ticketReceipt.Controls.Add(flight);

                                                    Label flight_id = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Location = new System.Drawing.Point(22, 229),
                                                        Name = "label5",
                                                        Size = new System.Drawing.Size(57, 17),
                                                        TabIndex = 0,
                                                        Text = plain.Id.ToString()
                                                    };
                                                    ticketReceipt.Controls.Add(flight_id);

                                                    Label from = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                                        Location = new System.Drawing.Point(214, 191),
                                                        Name = "lbl_from",
                                                        Size = new System.Drawing.Size(52, 17),
                                                        TabIndex = 0,
                                                        Text = "FROM",
                                                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))))
                                                    };
                                                    ticketReceipt.Controls.Add(from);


                                                    Label from_nereden = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Location = new System.Drawing.Point(214, 229),
                                                        Name = "label7",
                                                        Size = new System.Drawing.Size(61, 17),
                                                        TabIndex = 0,
                                                        Text = cmb_nereden.Text
                                                    };
                                                    ticketReceipt.Controls.Add(from_nereden);

                                                    Label to = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                                        Location = new System.Drawing.Point(404, 191),
                                                        Name = "label8",
                                                        Size = new System.Drawing.Size(30, 17),
                                                        TabIndex = 0,
                                                        Text = "TO",
                                                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))))
                                                    };
                                                    ticketReceipt.Controls.Add(to);

                                                    Label to_nereye = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Location = new System.Drawing.Point(404, 229),
                                                        Name = "label9",
                                                        Size = new System.Drawing.Size(52, 17),
                                                        TabIndex = 0,
                                                        Text = cmb_nereye.Text,
                                                    };
                                                    ticketReceipt.Controls.Add(to_nereye);

                                                    Label date = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                                        Location = new System.Drawing.Point(22, 297),
                                                        Name = "label10",
                                                        Size = new System.Drawing.Size(49, 17),
                                                        TabIndex = 0,
                                                        Text = "DATE",
                                                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))))
                                                    };
                                                    ticketReceipt.Controls.Add(date);

                                                    Label datetime = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Location = new System.Drawing.Point(22, 335),
                                                        Name = "label13",
                                                        Size = new System.Drawing.Size(64, 17),
                                                        TabIndex = 0,
                                                        Text = DateTime.Now.ToShortDateString()

                                                    };
                                                    ticketReceipt.Controls.Add(datetime);

                                                    Label time = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                                        Location = new System.Drawing.Point(214, 297),
                                                        Name = "label11",
                                                        Size = new System.Drawing.Size(44, 17),
                                                        TabIndex = 0,
                                                        Text = "TIME",
                                                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))))
                                                    };
                                                    ticketReceipt.Controls.Add(time);

                                                    Label time_ = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Location = new System.Drawing.Point(214, 335),
                                                        Name = "label14",
                                                        Size = new System.Drawing.Size(44, 17),
                                                        TabIndex = 0,
                                                        Text = plain.DepertureTime
                                                    };
                                                    ticketReceipt.Controls.Add(time_);


                                                    Label seat = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                                        Location = new System.Drawing.Point(404, 297),
                                                        Name = "label12",
                                                        Size = new System.Drawing.Size(48, 17),
                                                        TabIndex = 0,
                                                        Text = "SEAT",
                                                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))))
                                                    };
                                                    ticketReceipt.Controls.Add(seat);

                                                    Label seat_ = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Location = new System.Drawing.Point(404, 335),
                                                        Name = "label15",
                                                        Size = new System.Drawing.Size(16, 17),
                                                        TabIndex = 0,
                                                        Text = cmb_Yolcu.Text
                                                    };
                                                    ticketReceipt.Controls.Add(seat_);


                                                    Label nameSurname = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Location = new System.Drawing.Point(22, 111),
                                                        Name = "label2",
                                                        Size = new System.Drawing.Size(119, 17),
                                                        TabIndex = 0,
                                                        Text = customer.Name + " " + customer.Surname
                                                    };
                                                    ticketReceipt.Controls.Add(nameSurname);

                                                    Label tc = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Location = new System.Drawing.Point(237, 73),
                                                        Name = "label4",
                                                        Size = new System.Drawing.Size(46, 17),
                                                        Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                                                        TabIndex = 9,
                                                        Text = "TC",
                                                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))))
                                                    };
                                                    ticketReceipt.Controls.Add(tc);

                                                    Label tc_ = new Label()
                                                    {
                                                        AutoSize = true,
                                                        Location = new System.Drawing.Point(237, 111),
                                                        Name = "label6",
                                                        Size = new System.Drawing.Size(46, 17),
                                                        TabIndex = 9,
                                                        Text = customer.TC
                                                    };
                                                    ticketReceipt.Controls.Add(tc_);


                                                    MessageBox.Show("Bilet Satıldı");


                                                    ticketReceipt.Show();
                                                    break;
                                                    this.Hide();
                                                    status = true;
                                                    break;

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Yetersiz Bakiye");
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Yeterli koltuk yok. Boş koltuk sayısı : " + plain.seatPiece);
                                            }
                                            break;
                                        }


                                    }
                                    //if (yenisaat < saat)
                                    //{
                                    //    MessageBox.Show("Saat geçti");

                                    //    break;
                                    //}
                                }

                            }
                        }

                    }
                }
            }
        }


        private void AirlineTicketSalesSystem_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToShortDateString();
            DbContext db = new DbContext();
        }

        public int Route(string start, string end)
        {

            int deger = 0;
            foreach (var route in DbContext.RouteList.ToList())
            {
                if (route.startPoint == start && route.endPoint == end)
                {
                    return route.Id;
                }
            }

            return -1;
        }

        public int[] Plain(int roouteId)   // uçakta istenilen route id ve uçağın route id ile eşit mi eşit se atama işlemleri başlasın.
        {
            int routeCount = 0;
            int selectedRoute = Route(cmb_nereden.SelectedItem.ToString(), cmb_nereye.SelectedItem.ToString());
            foreach (var item in DbContext.PlainList.ToList())
            {

                if (selectedRoute == item.RouteID)
                {
                    routeCount++;
                }
            }

            int[] gotoPlain = new int[routeCount];
            int i = 0;
            foreach (var plain in DbContext.PlainList.ToList())
            {
                if (plain.RouteID == roouteId)
                {
                    gotoPlain[i] = plain.Id;
                    i++;
                }
            }
            return gotoPlain;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            RouteAdd routeAdd = new RouteAdd();
            this.Hide();
            routeAdd.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlainAdd plainAdd = new PlainAdd();
            this.Hide();
            plainAdd.ShowDialog();
            this.Show();
        }
    }
}
