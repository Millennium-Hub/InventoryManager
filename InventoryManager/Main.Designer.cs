
namespace InventoryManager
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ptcCat = new System.Windows.Forms.PictureBox();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ptcUsers = new System.Windows.Forms.PictureBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ptcOrd = new System.Windows.Forms.PictureBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ptcCust = new System.Windows.Forms.PictureBox();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptcProd = new System.Windows.Forms.PictureBox();
            this.btnProducts = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttons3 = new InventoryManager.SkerrUI.Buttons();
            this.sidebar.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcCat)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcUsers)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcOrd)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcCust)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcProd)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Location = new System.Drawing.Point(1, 1);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 450);
            this.sidebar.MinimumSize = new System.Drawing.Size(60, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 450);
            this.sidebar.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ptcCat);
            this.panel6.Controls.Add(this.btnCategories);
            this.panel6.Location = new System.Drawing.Point(1, 332);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 55);
            this.panel6.TabIndex = 9;
            // 
            // ptcCat
            // 
            this.ptcCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptcCat.BackColor = System.Drawing.Color.Black;
            this.ptcCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcCat.Image = global::InventoryManager.Properties.Resources.categ_30px;
            this.ptcCat.Location = new System.Drawing.Point(4, 7);
            this.ptcCat.Name = "ptcCat";
            this.ptcCat.Size = new System.Drawing.Size(37, 40);
            this.ptcCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcCat.TabIndex = 4;
            this.ptcCat.TabStop = false;
            this.ptcCat.Click += new System.EventHandler(this.ptcCat_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Black;
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(39, 8);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(137, 39);
            this.btnCategories.TabIndex = 3;
            this.btnCategories.Text = "CATEGORIES";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.userLabel);
            this.panel7.Location = new System.Drawing.Point(1, 393);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(196, 44);
            this.panel7.TabIndex = 11;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Location = new System.Drawing.Point(68, 15);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(80, 17);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "FULLNAME";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 65);
            this.panel1.TabIndex = 9;
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Black;
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Image = global::InventoryManager.Properties.Resources.hmb;
            this.menuBtn.Location = new System.Drawing.Point(6, 13);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(31, 35);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBtn.TabIndex = 4;
            this.menuBtn.TabStop = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "DASHBOARD";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ptcUsers);
            this.panel5.Controls.Add(this.btnUsers);
            this.panel5.Location = new System.Drawing.Point(1, 271);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 55);
            this.panel5.TabIndex = 8;
            // 
            // ptcUsers
            // 
            this.ptcUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptcUsers.BackColor = System.Drawing.Color.Black;
            this.ptcUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcUsers.Image = global::InventoryManager.Properties.Resources.customer_30px;
            this.ptcUsers.Location = new System.Drawing.Point(4, 7);
            this.ptcUsers.Name = "ptcUsers";
            this.ptcUsers.Size = new System.Drawing.Size(37, 40);
            this.ptcUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcUsers.TabIndex = 4;
            this.ptcUsers.TabStop = false;
            this.ptcUsers.Click += new System.EventHandler(this.ptcUsers_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Black;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(39, 8);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(137, 39);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "USERS";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ptcOrd);
            this.panel4.Controls.Add(this.btnOrder);
            this.panel4.Location = new System.Drawing.Point(1, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 55);
            this.panel4.TabIndex = 7;
            // 
            // ptcOrd
            // 
            this.ptcOrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptcOrd.BackColor = System.Drawing.Color.Black;
            this.ptcOrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcOrd.Image = global::InventoryManager.Properties.Resources.order_50px;
            this.ptcOrd.Location = new System.Drawing.Point(4, 7);
            this.ptcOrd.Name = "ptcOrd";
            this.ptcOrd.Size = new System.Drawing.Size(37, 40);
            this.ptcOrd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcOrd.TabIndex = 4;
            this.ptcOrd.TabStop = false;
            this.ptcOrd.Click += new System.EventHandler(this.ptcOrd_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Black;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(39, 8);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(137, 39);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "ORDERS";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ptcCust);
            this.panel3.Controls.Add(this.btnCustomers);
            this.panel3.Location = new System.Drawing.Point(1, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 55);
            this.panel3.TabIndex = 6;
            // 
            // ptcCust
            // 
            this.ptcCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptcCust.BackColor = System.Drawing.Color.Black;
            this.ptcCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcCust.Image = global::InventoryManager.Properties.Resources.user_30px;
            this.ptcCust.Location = new System.Drawing.Point(4, 7);
            this.ptcCust.Name = "ptcCust";
            this.ptcCust.Size = new System.Drawing.Size(37, 40);
            this.ptcCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcCust.TabIndex = 4;
            this.ptcCust.TabStop = false;
            this.ptcCust.Click += new System.EventHandler(this.ptcCust_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Black;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(39, 8);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(137, 39);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "CUSTOMERS";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptcProd);
            this.panel2.Controls.Add(this.btnProducts);
            this.panel2.Location = new System.Drawing.Point(1, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 55);
            this.panel2.TabIndex = 5;
            // 
            // ptcProd
            // 
            this.ptcProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptcProd.BackColor = System.Drawing.Color.Black;
            this.ptcProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptcProd.Image = global::InventoryManager.Properties.Resources.product_50px;
            this.ptcProd.Location = new System.Drawing.Point(4, 7);
            this.ptcProd.Name = "ptcProd";
            this.ptcProd.Size = new System.Drawing.Size(37, 40);
            this.ptcProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcProd.TabIndex = 4;
            this.ptcProd.TabStop = false;
            this.ptcProd.Click += new System.EventHandler(this.ptcProd_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Black;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(39, 8);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(137, 39);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "PRODUCTS";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 12;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Black;
            this.panelMain.Controls.Add(this.buttons3);
            this.panelMain.Location = new System.Drawing.Point(204, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(596, 450);
            this.panelMain.TabIndex = 3;
            // 
            // buttons3
            // 
            this.buttons3.BackColor = System.Drawing.Color.Black;
            this.buttons3.BackgroundColor = System.Drawing.Color.Black;
            this.buttons3.BackgroundImage = global::InventoryManager.Properties.Resources.logo;
            this.buttons3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttons3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttons3.BorderRadius = 10;
            this.buttons3.BorderSize = 0;
            this.buttons3.FlatAppearance.BorderSize = 0;
            this.buttons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons3.ForeColor = System.Drawing.Color.White;
            this.buttons3.Location = new System.Drawing.Point(92, 70);
            this.buttons3.Name = "buttons3";
            this.buttons3.Size = new System.Drawing.Size(411, 317);
            this.buttons3.TabIndex = 3;
            this.buttons3.TextColor = System.Drawing.Color.White;
            this.buttons3.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Main_Load);
            this.sidebar.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcCat)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcUsers)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcOrd)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcCust)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcProd)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptcProd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox ptcUsers;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox ptcOrd;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ptcCust;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox ptcCat;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Panel panelMain;
        private SkerrUI.Buttons buttons3;
    }
}