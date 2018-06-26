namespace easyChart
{
    partial class LineForm
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("数据项");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.up_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(5, 33);
            this.treeView1.Name = "treeView1";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "节点1";
            treeNode2.Text = "数据项";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(318, 331);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // up_button
            // 
            this.up_button.Image = ((System.Drawing.Image)(resources.GetObject("up_button.Image")));
            this.up_button.Location = new System.Drawing.Point(7, 2);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(27, 25);
            this.up_button.TabIndex = 1;
            this.up_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.up_button.UseVisualStyleBackColor = true;
            // 
            // down_button
            // 
            this.down_button.Image = ((System.Drawing.Image)(resources.GetObject("down_button.Image")));
            this.down_button.Location = new System.Drawing.Point(40, 2);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(27, 25);
            this.down_button.TabIndex = 2;
            this.down_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Image = ((System.Drawing.Image)(resources.GetObject("add_button.Image")));
            this.add_button.Location = new System.Drawing.Point(73, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(27, 25);
            this.add_button.TabIndex = 3;
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // del_button
            // 
            this.del_button.Image = ((System.Drawing.Image)(resources.GetObject("del_button.Image")));
            this.del_button.Location = new System.Drawing.Point(106, 2);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(27, 25);
            this.del_button.TabIndex = 4;
            this.del_button.UseVisualStyleBackColor = true;
            // 
            // edit_button
            // 
            this.edit_button.Image = ((System.Drawing.Image)(resources.GetObject("edit_button.Image")));
            this.edit_button.Location = new System.Drawing.Point(139, 2);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(27, 25);
            this.edit_button.TabIndex = 5;
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "101-database.png");
            this.imageList1.Images.SetKeyName(1, "156-stats-dots.png");
            // 
            // LineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 368);
            this.CloseButtonVisible = false;
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.treeView1);
            this.Name = "LineForm";
            this.TabText = "数据分项";
            this.Text = "LineForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.Button up_button;
        public System.Windows.Forms.Button down_button;
        public System.Windows.Forms.Button add_button;
        public System.Windows.Forms.Button del_button;
        public System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.ImageList imageList1;

    }
}