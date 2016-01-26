namespace Reso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(29, 52);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(138, 20);
            this.txtDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(196, 52);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(71, 20);
            this.txtTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(29, 122);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(131, 20);
            this.txtFName.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(196, 122);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(131, 20);
            this.txtLName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of Guests";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 9;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(32, 245);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(295, 38);
            this.cmdSearch.TabIndex = 10;
            this.cmdSearch.Text = "Search Reservation";
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(32, 306);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(295, 38);
            this.cmdInsert.TabIndex = 11;
            this.cmdInsert.Text = "Insert Reservation";
            this.cmdInsert.UseVisualStyleBackColor = true;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(32, 367);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(295, 38);
            this.cmdUpdate.TabIndex = 12;
            this.cmdUpdate.Text = "Update Reservation";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(32, 428);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(295, 38);
            this.cmdDelete.TabIndex = 13;
            this.cmdDelete.Text = "Delete Reservation";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(348, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 446);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 479);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RESO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.ListBox listBox1;
    }
}

