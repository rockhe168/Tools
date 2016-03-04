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
            this.dgvColumn = new System.Windows.Forms.DataGridView();
            this.gpButton = new System.Windows.Forms.GroupBox();
            this.btnNormalGenerator = new System.Windows.Forms.Button();
            this.gpConfig = new System.Windows.Forms.GroupBox();
            this.btnGeneratePO = new System.Windows.Forms.Button();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumn)).BeginInit();
            this.gpButton.SuspendLayout();
            this.gpConfig.SuspendLayout();
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
            this.tvTrees.CheckBoxes = true;
            this.tvTrees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTrees.Location = new System.Drawing.Point(0, 0);
            this.tvTrees.Name = "tvTrees";
            this.tvTrees.Size = new System.Drawing.Size(299, 610);
            this.tvTrees.TabIndex = 0;
            this.tvTrees.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTrees_NodeMouseClick);
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
            // gpButton
            // 
            this.gpButton.Controls.Add(this.btnGeneratePO);
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
            this.btnNormalGenerator.Click += new System.EventHandler(this.btnNormalGenerator_Click);
            // 
            // gpConfig
            // 
            this.gpConfig.Controls.Add(this.label1);
            this.gpConfig.Controls.Add(this.txtNameSpace);
            this.gpConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpConfig.Location = new System.Drawing.Point(0, 0);
            this.gpConfig.Name = "gpConfig";
            this.gpConfig.Size = new System.Drawing.Size(733, 55);
            this.gpConfig.TabIndex = 0;
            this.gpConfig.TabStop = false;
            this.gpConfig.Text = "配置";
            // 
            // btnGeneratePO
            // 
            this.btnGeneratePO.Location = new System.Drawing.Point(115, 19);
            this.btnGeneratePO.Name = "btnGeneratePO";
            this.btnGeneratePO.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratePO.TabIndex = 1;
            this.btnGeneratePO.Text = "生产PO";
            this.btnGeneratePO.UseVisualStyleBackColor = true;
            this.btnGeneratePO.Click += new System.EventHandler(this.btnGeneratePO_Click);
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(67, 20);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(230, 21);
            this.txtNameSpace.TabIndex = 0;
            this.txtNameSpace.Text = "Package.Vendor.VBooking.DataRepository";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "命名空间";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumn)).EndInit();
            this.gpButton.ResumeLayout(false);
            this.gpConfig.ResumeLayout(false);
            this.gpConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gpButton;
        private System.Windows.Forms.GroupBox gpConfig;
        private System.Windows.Forms.Button btnNormalGenerator;
        private System.Windows.Forms.TreeView tvTrees;
        private System.Windows.Forms.DataGridView dgvColumn;
        private System.Windows.Forms.Button btnGeneratePO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSpace;
    }
}