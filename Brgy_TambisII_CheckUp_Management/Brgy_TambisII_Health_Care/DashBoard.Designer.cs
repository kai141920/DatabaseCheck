namespace Brgy_TambisII_Health_Care
{
    partial class DashBoard
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
            this.btnAppointmentSched = new System.Windows.Forms.Button();
            this.btnAppointRecords = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAppointmentSched
            // 
            this.btnAppointmentSched.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAppointmentSched.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnAppointmentSched.Location = new System.Drawing.Point(147, 145);
            this.btnAppointmentSched.Name = "btnAppointmentSched";
            this.btnAppointmentSched.Size = new System.Drawing.Size(219, 98);
            this.btnAppointmentSched.TabIndex = 0;
            this.btnAppointmentSched.Text = "Appointment Scheduling";
            this.btnAppointmentSched.UseVisualStyleBackColor = false;
            this.btnAppointmentSched.Click += new System.EventHandler(this.btnAppointmentSched_Click);
            // 
            // btnAppointRecords
            // 
            this.btnAppointRecords.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAppointRecords.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnAppointRecords.Location = new System.Drawing.Point(147, 272);
            this.btnAppointRecords.Name = "btnAppointRecords";
            this.btnAppointRecords.Size = new System.Drawing.Size(219, 98);
            this.btnAppointRecords.TabIndex = 2;
            this.btnAppointRecords.Text = "Appointment Records";
            this.btnAppointRecords.UseVisualStyleBackColor = false;
            this.btnAppointRecords.Click += new System.EventHandler(this.btnAppointRecords_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnLogOut.Location = new System.Drawing.Point(443, 272);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(219, 98);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHECKUP MANAGEMENT";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.button2.Location = new System.Drawing.Point(443, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 98);
            this.button2.TabIndex = 6;
            this.button2.Text = "All List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Brgy_TambisII_Health_Care.Properties.Resources.rm373batch15_bg_11_kqaiv1bm;
            this.ClientSize = new System.Drawing.Size(806, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAppointRecords);
            this.Controls.Add(this.btnAppointmentSched);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppointmentSched;
        private System.Windows.Forms.Button btnAppointRecords;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}