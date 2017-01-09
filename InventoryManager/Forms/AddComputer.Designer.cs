namespace StudentComputerManager
{
    partial class AddComputer
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
            this.txt_cps = new System.Windows.Forms.TextBox();
            this.txt_sn = new System.Windows.Forms.TextBox();
            this.l_cps = new System.Windows.Forms.Label();
            this.l_sn = new System.Windows.Forms.Label();
            this.b_submitComp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cps
            // 
            this.txt_cps.Location = new System.Drawing.Point(67, 56);
            this.txt_cps.Name = "txt_cps";
            this.txt_cps.Size = new System.Drawing.Size(100, 20);
            this.txt_cps.TabIndex = 0;
            // 
            // txt_sn
            // 
            this.txt_sn.Location = new System.Drawing.Point(67, 105);
            this.txt_sn.Name = "txt_sn";
            this.txt_sn.Size = new System.Drawing.Size(100, 20);
            this.txt_sn.TabIndex = 1;
            // 
            // l_cps
            // 
            this.l_cps.AutoSize = true;
            this.l_cps.Location = new System.Drawing.Point(64, 40);
            this.l_cps.Name = "l_cps";
            this.l_cps.Size = new System.Drawing.Size(71, 13);
            this.l_cps.TabIndex = 2;
            this.l_cps.Text = "CPS Number:";
            this.l_cps.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_sn
            // 
            this.l_sn.AutoSize = true;
            this.l_sn.Location = new System.Drawing.Point(64, 89);
            this.l_sn.Name = "l_sn";
            this.l_sn.Size = new System.Drawing.Size(76, 13);
            this.l_sn.TabIndex = 3;
            this.l_sn.Text = "Serial Number:";
            // 
            // b_submitComp
            // 
            this.b_submitComp.Location = new System.Drawing.Point(79, 154);
            this.b_submitComp.Name = "b_submitComp";
            this.b_submitComp.Size = new System.Drawing.Size(75, 23);
            this.b_submitComp.TabIndex = 4;
            this.b_submitComp.Text = "Submit";
            this.b_submitComp.UseVisualStyleBackColor = true;
            this.b_submitComp.Click += new System.EventHandler(this.b_submitComp_Click);
            // 
            // AddComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.b_submitComp);
            this.Controls.Add(this.l_sn);
            this.Controls.Add(this.l_cps);
            this.Controls.Add(this.txt_sn);
            this.Controls.Add(this.txt_cps);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 250);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "AddComputer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AddComputer";
            this.Load += new System.EventHandler(this.AddComputer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cps;
        private System.Windows.Forms.TextBox txt_sn;
        private System.Windows.Forms.Label l_cps;
        private System.Windows.Forms.Label l_sn;
        private System.Windows.Forms.Button b_submitComp;
    }
}