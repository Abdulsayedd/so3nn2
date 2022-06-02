namespace so3nn2
{
    partial class Form1
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
            this.bigtxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.balancetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insbtn = new System.Windows.Forms.Button();
            this.readbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.rebtn = new System.Windows.Forms.Button();
            this.clsbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bigtxt
            // 
            this.bigtxt.Location = new System.Drawing.Point(12, 199);
            this.bigtxt.Multiline = true;
            this.bigtxt.Name = "bigtxt";
            this.bigtxt.Size = new System.Drawing.Size(342, 347);
            this.bigtxt.TabIndex = 0;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(12, 39);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 20);
            this.idtxt.TabIndex = 1;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(134, 39);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 20);
            this.nametxt.TabIndex = 1;
            // 
            // balancetxt
            // 
            this.balancetxt.Location = new System.Drawing.Point(254, 39);
            this.balancetxt.Name = "balancetxt";
            this.balancetxt.Size = new System.Drawing.Size(100, 20);
            this.balancetxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance:";
            // 
            // insbtn
            // 
            this.insbtn.Location = new System.Drawing.Point(21, 65);
            this.insbtn.Name = "insbtn";
            this.insbtn.Size = new System.Drawing.Size(75, 23);
            this.insbtn.TabIndex = 3;
            this.insbtn.Text = "Insert";
            this.insbtn.UseVisualStyleBackColor = true;
            this.insbtn.Click += new System.EventHandler(this.insbtn_Click);
            // 
            // readbtn
            // 
            this.readbtn.Location = new System.Drawing.Point(147, 65);
            this.readbtn.Name = "readbtn";
            this.readbtn.Size = new System.Drawing.Size(75, 23);
            this.readbtn.TabIndex = 3;
            this.readbtn.Text = "Read";
            this.readbtn.UseVisualStyleBackColor = true;
            this.readbtn.Click += new System.EventHandler(this.readbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(267, 65);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(21, 94);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 23);
            this.delbtn.TabIndex = 3;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // rebtn
            // 
            this.rebtn.Location = new System.Drawing.Point(147, 94);
            this.rebtn.Name = "rebtn";
            this.rebtn.Size = new System.Drawing.Size(75, 23);
            this.rebtn.TabIndex = 3;
            this.rebtn.Text = "Rewrite";
            this.rebtn.UseVisualStyleBackColor = true;
            this.rebtn.Click += new System.EventHandler(this.rebtn_Click);
            // 
            // clsbtn
            // 
            this.clsbtn.Location = new System.Drawing.Point(267, 94);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(75, 23);
            this.clsbtn.TabIndex = 3;
            this.clsbtn.Text = "Close";
            this.clsbtn.UseVisualStyleBackColor = true;
            this.clsbtn.Click += new System.EventHandler(this.clsbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 558);
            this.Controls.Add(this.rebtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.clsbtn);
            this.Controls.Add(this.readbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.insbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balancetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.bigtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bigtxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox balancetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insbtn;
        private System.Windows.Forms.Button readbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button rebtn;
        private System.Windows.Forms.Button clsbtn;
    }
}

