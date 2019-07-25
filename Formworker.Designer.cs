namespace WindowsFormsApplication1
{
    partial class Formworker
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtf = new System.Windows.Forms.TextBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btsend = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btser = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.txtser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(360, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 0;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(360, 81);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(100, 20);
            this.txtf.TabIndex = 1;
            this.txtf.TextChanged += new System.EventHandler(this.txtf_TextChanged);
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(360, 122);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(100, 20);
            this.txtl.TabIndex = 2;
            this.txtl.TextChanged += new System.EventHandler(this.txtl_TextChanged);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(360, 164);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 3;
            this.txtc.TextChanged += new System.EventHandler(this.txtc_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 230);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "תעודת זהות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "שם פרטי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "שם משפחה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "כתובת";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // btsend
            // 
            this.btsend.Location = new System.Drawing.Point(433, 273);
            this.btsend.Name = "btsend";
            this.btsend.Size = new System.Drawing.Size(75, 23);
            this.btsend.TabIndex = 11;
            this.btsend.Text = "הוספה";
            this.btsend.UseVisualStyleBackColor = true;
            this.btsend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(122, 299);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(75, 23);
            this.btedit.TabIndex = 12;
            this.btedit.Text = "עדכון";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btser
            // 
            this.btser.Location = new System.Drawing.Point(72, 270);
            this.btser.Name = "btser";
            this.btser.Size = new System.Drawing.Size(75, 23);
            this.btser.TabIndex = 13;
            this.btser.Text = "חיפוש";
            this.btser.UseVisualStyleBackColor = true;
            this.btser.Click += new System.EventHandler(this.btser_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(41, 299);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 14;
            this.btdelete.Text = "מחיקה";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // txtser
            // 
            this.txtser.Location = new System.Drawing.Point(169, 273);
            this.txtser.Name = "txtser";
            this.txtser.Size = new System.Drawing.Size(100, 20);
            this.txtser.TabIndex = 15;
            // 
            // Formworker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 338);
            this.Controls.Add(this.txtser);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btser);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btsend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.txtid);
            this.Name = "Formworker";
            this.Text = "Formworker";
            this.Load += new System.EventHandler(this.Formworker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btser;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.TextBox txtser;
    }
}