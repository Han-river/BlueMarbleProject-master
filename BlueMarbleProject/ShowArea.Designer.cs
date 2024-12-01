namespace BlueMarbleProject
{
    partial class ShowArea
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbAngel = new System.Windows.Forms.Label();
            this.lbEscape = new System.Windows.Forms.Label();
            this.지역이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.건물이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.지역이름,
            this.건물이름});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(406, 247);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lbAngel
            // 
            this.lbAngel.AutoSize = true;
            this.lbAngel.Location = new System.Drawing.Point(63, 310);
            this.lbAngel.Name = "lbAngel";
            this.lbAngel.Size = new System.Drawing.Size(54, 18);
            this.lbAngel.TabIndex = 1;
            this.lbAngel.Text = "label1";
            // 
            // lbEscape
            // 
            this.lbEscape.AutoSize = true;
            this.lbEscape.Location = new System.Drawing.Point(63, 350);
            this.lbEscape.Name = "lbEscape";
            this.lbEscape.Size = new System.Drawing.Size(54, 18);
            this.lbEscape.TabIndex = 1;
            this.lbEscape.Text = "label1";
            // 
            // 지역이름
            // 
            this.지역이름.Text = "지역이름";
            // 
            // 건물이름
            // 
            this.건물이름.Text = "건물이름";
            // 
            // ShowArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbEscape);
            this.Controls.Add(this.lbAngel);
            this.Controls.Add(this.listView1);
            this.Name = "ShowArea";
            this.Text = "ShowArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbAngel;
        private System.Windows.Forms.Label lbEscape;
        private System.Windows.Forms.ColumnHeader 지역이름;
        private System.Windows.Forms.ColumnHeader 건물이름;
    }
}