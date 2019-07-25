namespace WindowsFormsApplication1
{
    partial class menuworker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuworker));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.לקוחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuclient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.הצגפריטיםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDatagridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.אלפוןלקוחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.דוחמכירותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.לקוחותToolStripMenuItem,
            this.menuitem,
            this.listDatagridToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // לקוחותToolStripMenuItem
            // 
            this.לקוחותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menusales,
            this.menuclient});
            this.לקוחותToolStripMenuItem.Name = "לקוחותToolStripMenuItem";
            this.לקוחותToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.לקוחותToolStripMenuItem.Text = "לקוחות";
            // 
            // menusales
            // 
            this.menusales.Name = "menusales";
            this.menusales.Size = new System.Drawing.Size(152, 22);
            this.menusales.Text = "ביצוע הזמנה";
            this.menusales.Click += new System.EventHandler(this.menusales_Click);
            // 
            // menuclient
            // 
            this.menuclient.Name = "menuclient";
            this.menuclient.Size = new System.Drawing.Size(152, 22);
            this.menuclient.Text = "רישום לקוח";
            this.menuclient.Click += new System.EventHandler(this.menuclient_Click);
            // 
            // menuitem
            // 
            this.menuitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הצגפריטיםToolStripMenuItem});
            this.menuitem.Name = "menuitem";
            this.menuitem.Size = new System.Drawing.Size(56, 20);
            this.menuitem.Text = "פריטים";
            // 
            // הצגפריטיםToolStripMenuItem
            // 
            this.הצגפריטיםToolStripMenuItem.Name = "הצגפריטיםToolStripMenuItem";
            this.הצגפריטיםToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.הצגפריטיםToolStripMenuItem.Text = "הצגת פריטים";
            this.הצגפריטיםToolStripMenuItem.Click += new System.EventHandler(this.הצגפריטיםToolStripMenuItem_Click);
            // 
            // listDatagridToolStripMenuItem
            // 
            this.listDatagridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.אלפוןלקוחותToolStripMenuItem,
            this.דוחמכירותToolStripMenuItem});
            this.listDatagridToolStripMenuItem.Name = "listDatagridToolStripMenuItem";
            this.listDatagridToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // אלפוןלקוחותToolStripMenuItem
            // 
            this.אלפוןלקוחותToolStripMenuItem.Name = "אלפוןלקוחותToolStripMenuItem";
            this.אלפוןלקוחותToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // דוחמכירותToolStripMenuItem
            // 
            this.דוחמכירותToolStripMenuItem.Name = "דוחמכירותToolStripMenuItem";
            this.דוחמכירותToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 354);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuworker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "menuworker";
            this.Text = "menuworker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem לקוחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menusales;
        private System.Windows.Forms.ToolStripMenuItem menuclient;
        private System.Windows.Forms.ToolStripMenuItem menuitem;
        private System.Windows.Forms.ToolStripMenuItem הצגפריטיםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDatagridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem אלפוןלקוחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem דוחמכירותToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}