
namespace EasyMenuAccess
{
    partial class Display
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
            this.displaybtn = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.displaybtn)).BeginInit();
            this.SuspendLayout();
            // 
            // displaybtn
            // 
            this.displaybtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.displaybtn.Image = global::EasyMenuAccess.Properties.Resources.hope;
            this.displaybtn.Location = new System.Drawing.Point(0, 0);
            this.displaybtn.Name = "displaybtn";
            this.displaybtn.Size = new System.Drawing.Size(29, 25);
            this.displaybtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displaybtn.TabIndex = 2;
            this.displaybtn.TabStop = false;
            this.displaybtn.Click += new System.EventHandler(this.displaybtn_Click);
            this.displaybtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.displaybtn_MouseClick);
            this.displaybtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.displaybtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(31, 23);
            this.Controls.Add(this.displaybtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Display";
            this.Text = "Display";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.SaddleBrown;
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displaybtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox displaybtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}