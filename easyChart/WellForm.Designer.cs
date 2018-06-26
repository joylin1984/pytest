namespace easyChart
{
    partial class WellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WellForm));
            this.fillter_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.well_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fillter_button
            // 
            this.fillter_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fillter_button.Image = ((System.Drawing.Image)(resources.GetObject("fillter_button.Image")));
            this.fillter_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fillter_button.Location = new System.Drawing.Point(155, 5);
            this.fillter_button.Name = "fillter_button";
            this.fillter_button.Size = new System.Drawing.Size(83, 25);
            this.fillter_button.TabIndex = 1;
            this.fillter_button.Text = "筛选";
            this.fillter_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fillter_button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(4, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 2;
            // 
            // well_listBox
            // 
            this.well_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.well_listBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.well_listBox.FormattingEnabled = true;
            this.well_listBox.ItemHeight = 17;
            this.well_listBox.Location = new System.Drawing.Point(4, 35);
            this.well_listBox.Name = "well_listBox";
            this.well_listBox.Size = new System.Drawing.Size(234, 327);
            this.well_listBox.TabIndex = 0;
            // 
            // WellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 375);
            this.CloseButtonVisible = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fillter_button);
            this.Controls.Add(this.well_listBox);
            this.Name = "WellForm";
            this.TabText = "井号/区块";
            this.Text = "WellForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button fillter_button;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListBox well_listBox;

    }
}