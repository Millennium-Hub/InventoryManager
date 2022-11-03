
namespace InventoryManager
{
    partial class Products
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttons2 = new InventoryManager.SkerrUI.Buttons();
            this.buttons1 = new InventoryManager.SkerrUI.Buttons();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttons2);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 351);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttons1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 69);
            this.panel2.TabIndex = 1;
            // 
            // buttons2
            // 
            this.buttons2.BackColor = System.Drawing.Color.Purple;
            this.buttons2.BackgroundColor = System.Drawing.Color.Purple;
            this.buttons2.BorderColor = System.Drawing.Color.Purple;
            this.buttons2.BorderRadius = 16;
            this.buttons2.BorderSize = 3;
            this.buttons2.FlatAppearance.BorderSize = 0;
            this.buttons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons2.ForeColor = System.Drawing.Color.White;
            this.buttons2.Location = new System.Drawing.Point(176, 3);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(78, 37);
            this.buttons2.TabIndex = 1;
            this.buttons2.Text = "buttons2";
            this.buttons2.TextColor = System.Drawing.Color.White;
            this.buttons2.UseVisualStyleBackColor = false;
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.Color.Olive;
            this.buttons1.BackgroundColor = System.Drawing.Color.Olive;
            this.buttons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttons1.BorderRadius = 5;
            this.buttons1.BorderSize = 0;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.ForeColor = System.Drawing.Color.White;
            this.buttons1.Location = new System.Drawing.Point(176, 29);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(78, 37);
            this.buttons1.TabIndex = 0;
            this.buttons1.Text = "buttons1";
            this.buttons1.TextColor = System.Drawing.Color.White;
            this.buttons1.UseVisualStyleBackColor = false;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Products";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private SkerrUI.Buttons buttons1;
        private SkerrUI.Buttons buttons2;
    }
}