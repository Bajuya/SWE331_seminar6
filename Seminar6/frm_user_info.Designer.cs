namespace Seminar6
{
    partial class frm_user_info
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
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Хэрэглэгчийн төрөл");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Хэрэглэгчийн бүртгэл");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Хэрэглэгч", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Бүтээгдэхүүний төрөл");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Бүтээгдэхүүний бүртгэл");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Бүтээгдэхүүний үнэ");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Бүтээгдэхүүн", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Борлуулалт");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Худалдан авалт");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Ажил Гүйлгээ", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Эд хөрөнгийн төрөл");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Эд хөрөнгийн бүртгэл");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Эд хөрөнгө", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1, 1);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 449);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Tag = "hello";
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(3, 0);
            this.treeView2.Name = "treeView2";
            treeNode27.Name = "Her_turul";
            treeNode27.Tag = "user_type";
            treeNode27.Text = "Хэрэглэгчийн төрөл";
            treeNode28.Name = "Her_burtgel";
            treeNode28.Text = "Хэрэглэгчийн бүртгэл";
            treeNode29.ContextMenuStrip = this.contextMenuStrip1;
            treeNode29.Name = "Hereglegch";
            treeNode29.Text = "Хэрэглэгч";
            treeNode30.Name = "but_turul";
            treeNode30.Text = "Бүтээгдэхүүний төрөл";
            treeNode31.Name = "but_burtgel";
            treeNode31.Text = "Бүтээгдэхүүний бүртгэл";
            treeNode32.Name = "but_une";
            treeNode32.Text = "Бүтээгдэхүүний үнэ";
            treeNode33.Checked = true;
            treeNode33.Name = "Buteegdehuun";
            treeNode33.Text = "Бүтээгдэхүүн";
            treeNode34.Name = "borluulalt";
            treeNode34.Text = "Борлуулалт";
            treeNode35.Name = "hudaldan_avalt";
            treeNode35.Text = "Худалдан авалт";
            treeNode36.Name = "ajil_guilgee";
            treeNode36.Text = "Ажил Гүйлгээ";
            treeNode37.Name = "ed_turul";
            treeNode37.Text = "Эд хөрөнгийн төрөл";
            treeNode38.Name = "ed_burtgel";
            treeNode38.Text = "Эд хөрөнгийн бүртгэл";
            treeNode39.Name = "ed_hurungu";
            treeNode39.Text = "Эд хөрөнгө";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode33,
            treeNode36,
            treeNode39});
            this.treeView2.Size = new System.Drawing.Size(260, 450);
            this.treeView2.TabIndex = 0;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 52);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 446);
            this.panel1.TabIndex = 0;
            // 
            // frm_user_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frm_user_info";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}