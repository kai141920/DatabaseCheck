namespace Brgy_TambisII_Health_Care
{
    partial class All_List_Patient_And_Illnesses
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
            this.dgvAllList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllList
            // 
            this.dgvAllList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAllList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllList.Location = new System.Drawing.Point(22, 231);
            this.dgvAllList.Name = "dgvAllList";
            this.dgvAllList.RowHeadersWidth = 62;
            this.dgvAllList.RowTemplate.Height = 28;
            this.dgvAllList.Size = new System.Drawing.Size(1194, 508);
            this.dgvAllList.TabIndex = 0;
            this.dgvAllList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALL LIST";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashBoardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.dashBoardToolStripMenuItem.ForeColor = System.Drawing.Color.SandyBrown;
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.dashBoardToolStripMenuItem.Text = "DashBoard";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click);
            // 
            // TbxSearch
            // 
            this.TbxSearch.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.TbxSearch.Location = new System.Drawing.Point(877, 176);
            this.TbxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(234, 41);
            this.TbxSearch.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::Brgy_TambisII_Health_Care.Properties.Resources.search;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSearch.Location = new System.Drawing.Point(1141, 171);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 46);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(771, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // All_List_Patient_And_Illnesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Brgy_TambisII_Health_Care.Properties.Resources.images__26_;
            this.ClientSize = new System.Drawing.Size(1228, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbxSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAllList);
            this.Name = "All_List_Patient_And_Illnesses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_List_Patient_And_Illnesses";
            this.Load += new System.EventHandler(this.All_List_Patient_And_Illnesses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.TextBox TbxSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button button1;
    }
}