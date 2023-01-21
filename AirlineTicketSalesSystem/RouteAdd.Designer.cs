namespace AirlineTicketSalesSystem
{
    partial class RouteAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RouteList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_endPoint = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_startPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RouteList
            // 
            this.RouteList.FormattingEnabled = true;
            this.RouteList.ItemHeight = 16;
            this.RouteList.Location = new System.Drawing.Point(388, 82);
            this.RouteList.Name = "RouteList";
            this.RouteList.Size = new System.Drawing.Size(365, 244);
            this.RouteList.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 28);
            this.button2.TabIndex = 30;
            this.button2.Text = "LİST";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(51, 238);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 28);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_endPoint
            // 
            this.txt_endPoint.Location = new System.Drawing.Point(168, 184);
            this.txt_endPoint.Multiline = true;
            this.txt_endPoint.Name = "txt_endPoint";
            this.txt_endPoint.Size = new System.Drawing.Size(170, 28);
            this.txt_endPoint.TabIndex = 25;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(168, 79);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(170, 28);
            this.txt_Id.TabIndex = 20;
            // 
            // txt_startPoint
            // 
            this.txt_startPoint.Location = new System.Drawing.Point(168, 127);
            this.txt_startPoint.Multiline = true;
            this.txt_startPoint.Name = "txt_startPoint";
            this.txt_startPoint.Size = new System.Drawing.Size(170, 28);
            this.txt_startPoint.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "End Point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Start Point";
            // 
            // RouteAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 490);
            this.Controls.Add(this.RouteList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_endPoint);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_startPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "RouteAdd";
            this.Text = "RouteAdd";
            this.Load += new System.EventHandler(this.RouteAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RouteList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_endPoint;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_startPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}