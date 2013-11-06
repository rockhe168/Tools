namespace CtripDataBaseDictionary
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvTrees = new System.Windows.Forms.TreeView();
            this.gpButton = new System.Windows.Forms.GroupBox();
            this.btnNormalGenerator = new System.Windows.Forms.Button();
            this.gpConfig = new System.Windows.Forms.GroupBox();
            this.dgvColumn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvTrees);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvColumn);
            this.splitContainer1.Panel2.Controls.Add(this.gpButton);
            this.splitContainer1.Panel2.Controls.Add(this.gpConfig);
            this.splitContainer1.Size = new System.Drawing.Size(1036, 610);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvTrees
            // 
            this.tvTrees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTrees.Location = new System.Drawing.Point(0, 0);
            this.tvTrees.Name = "tvTrees";
            this.tvTrees.Size = new System.Drawing.Size(299, 610);
            this.tvTrees.TabIndex = 0;
            this.tvTrees.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTrees_NodeMouseClick);
            // 
            // gpButton
            // 
            this.gpButton.Controls.Add(this.btnNormalGenerator);
            this.gpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpButton.Location = new System.Drawing.Point(0, 554);
            this.gpButton.Name = "gpButton";
            this.gpButton.Size = new System.Drawing.Size(733, 56);
            this.gpButton.TabIndex = 2;
            this.gpButton.TabStop = false;
            // 
            // btnNormalGenerator
            // 
            this.btnNormalGenerator.Location = new System.Drawing.Point(15, 20);
            this.btnNormalGenerator.Name = "btnNormalGenerator";
            this.btnNormalGenerator.Size = new System.Drawing.Size(75, 23);
            this.btnNormalGenerator.TabIndex = 0;
            this.btnNormalGenerator.Text = "生成";
            this.btnNormalGenerator.UseVisualStyleBackColor = true;
            // 
            // gpConfig
            // 
            this.gpConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpConfig.Location = new System.Drawing.Point(0, 0);
            this.gpConfig.Name = "gpConfig";
            this.gpConfig.Size = new System.Drawing.Size(733, 55);
            this.gpConfig.TabIndex = 0;
            this.gpConfig.TabStop = false;
            this.gpConfig.Text = "配置";
            // 
            // dgvColumn
            // 
            this.dgvColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumn.Location = new System.Drawing.Point(0, 55);
            this.dgvColumn.Name = "dgvColumn";
            this.dgvColumn.RowTemplate.Height = 23;
            this.dgvColumn.Size = new System.Drawing.Size(733, 499);
            this.dgvColumn.TabIndex = 3;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 610);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gpButton;
        private System.Windows.Forms.GroupBox gpConfig;
        private System.Windows.Forms.Button btnNormalGenerator;
        private System.Windows.Forms.TreeView tvTrees;
        private System.Windows.Forms.DataGridView dgvColumn;
    }
}