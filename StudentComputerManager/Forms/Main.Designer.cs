namespace StudentComputerManager
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
            this.label2 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_cps = new System.Windows.Forms.TextBox();
            this.b_search1 = new System.Windows.Forms.Button();
            this.b_search2 = new System.Windows.Forms.Button();
            this.b_addStudent = new System.Windows.Forms.Button();
            this.b_addComputer = new System.Windows.Forms.Button();
            this.b_removeComputer = new System.Windows.Forms.Button();
            this.b_removeStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID:";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(200, 145);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 20);
            this.text_id.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "or";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPS:";
            // 
            // text_cps
            // 
            this.text_cps.Location = new System.Drawing.Point(200, 195);
            this.text_cps.Name = "text_cps";
            this.text_cps.Size = new System.Drawing.Size(100, 20);
            this.text_cps.TabIndex = 4;
            // 
            // b_search1
            // 
            this.b_search1.Location = new System.Drawing.Point(306, 143);
            this.b_search1.Name = "b_search1";
            this.b_search1.Size = new System.Drawing.Size(37, 23);
            this.b_search1.TabIndex = 6;
            this.b_search1.Text = "Go";
            this.b_search1.UseVisualStyleBackColor = true;
            // 
            // b_search2
            // 
            this.b_search2.Location = new System.Drawing.Point(306, 193);
            this.b_search2.Name = "b_search2";
            this.b_search2.Size = new System.Drawing.Size(37, 23);
            this.b_search2.TabIndex = 7;
            this.b_search2.Text = "Go";
            this.b_search2.UseVisualStyleBackColor = true;
            // 
            // b_addStudent
            // 
            this.b_addStudent.Location = new System.Drawing.Point(136, 257);
            this.b_addStudent.Name = "b_addStudent";
            this.b_addStudent.Size = new System.Drawing.Size(113, 23);
            this.b_addStudent.TabIndex = 8;
            this.b_addStudent.Text = "Add Student";
            this.b_addStudent.UseVisualStyleBackColor = true;
            this.b_addStudent.Click += new System.EventHandler(this.b_addStudent_Click);
            // 
            // b_addComputer
            // 
            this.b_addComputer.Location = new System.Drawing.Point(136, 286);
            this.b_addComputer.Name = "b_addComputer";
            this.b_addComputer.Size = new System.Drawing.Size(113, 23);
            this.b_addComputer.TabIndex = 9;
            this.b_addComputer.Text = "Add Computer";
            this.b_addComputer.UseVisualStyleBackColor = true;
            this.b_addComputer.Click += new System.EventHandler(this.b_addComputer_Click);
            // 
            // b_removeComputer
            // 
            this.b_removeComputer.Location = new System.Drawing.Point(255, 286);
            this.b_removeComputer.Name = "b_removeComputer";
            this.b_removeComputer.Size = new System.Drawing.Size(105, 23);
            this.b_removeComputer.TabIndex = 11;
            this.b_removeComputer.Text = "Remove Computer";
            this.b_removeComputer.UseVisualStyleBackColor = true;
            // 
            // b_removeStudent
            // 
            this.b_removeStudent.Location = new System.Drawing.Point(255, 257);
            this.b_removeStudent.Name = "b_removeStudent";
            this.b_removeStudent.Size = new System.Drawing.Size(105, 23);
            this.b_removeStudent.TabIndex = 10;
            this.b_removeStudent.Text = "Remove Student";
            this.b_removeStudent.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.b_removeComputer);
            this.Controls.Add(this.b_removeStudent);
            this.Controls.Add(this.b_addComputer);
            this.Controls.Add(this.b_addStudent);
            this.Controls.Add(this.b_search2);
            this.Controls.Add(this.b_search1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_cps);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_cps;
        private System.Windows.Forms.Button b_search1;
        private System.Windows.Forms.Button b_search2;
        private System.Windows.Forms.Button b_addStudent;
        private System.Windows.Forms.Button b_addComputer;
        private System.Windows.Forms.Button b_removeComputer;
        private System.Windows.Forms.Button b_removeStudent;
    }
}

