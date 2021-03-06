﻿namespace Well_Trajectory_Visualization
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Wells");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allViewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annnotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpestPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.resetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteNodeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.wellsTreeView = new System.Windows.Forms.TreeView();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.defaultPagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageSourceReference = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowThreeViewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Show3DViewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.defaultPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.imageSourceReference.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1172, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.openFileToolStripMenuItem.Text = "&Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allViewsToolStripMenuItem,
            this.mainViewToolStripMenuItem,
            this.leftViewToolStripMenuItem,
            this.topViewToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.saveAsToolStripMenuItem.Text = "&Save View...";
            // 
            // allViewsToolStripMenuItem
            // 
            this.allViewsToolStripMenuItem.Name = "allViewsToolStripMenuItem";
            this.allViewsToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.allViewsToolStripMenuItem.Text = "All";
            this.allViewsToolStripMenuItem.Click += new System.EventHandler(this.SaveViewOnTabPage);
            // 
            // mainViewToolStripMenuItem
            // 
            this.mainViewToolStripMenuItem.Name = "mainViewToolStripMenuItem";
            this.mainViewToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.mainViewToolStripMenuItem.Text = "Main";
            this.mainViewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // leftViewToolStripMenuItem
            // 
            this.leftViewToolStripMenuItem.Name = "leftViewToolStripMenuItem";
            this.leftViewToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.leftViewToolStripMenuItem.Text = "Left";
            this.leftViewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // topViewToolStripMenuItem
            // 
            this.topViewToolStripMenuItem.Name = "topViewToolStripMenuItem";
            this.topViewToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.topViewToolStripMenuItem.Text = "Top";
            this.topViewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.CheckOnClick = true;
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annnotationToolStripMenuItem,
            this.sharpestPointToolStripMenuItem,
            this.convertToToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.displayToolStripMenuItem.Text = "&Display";
            // 
            // annnotationToolStripMenuItem
            // 
            this.annnotationToolStripMenuItem.CheckOnClick = true;
            this.annnotationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.annnotationToolStripMenuItem.Name = "annnotationToolStripMenuItem";
            this.annnotationToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.annnotationToolStripMenuItem.Text = "&Annnotation";
            this.annnotationToolStripMenuItem.Click += new System.EventHandler(this.AnnnotationToolStripMenuItem_Click);
            // 
            // sharpestPointToolStripMenuItem
            // 
            this.sharpestPointToolStripMenuItem.CheckOnClick = true;
            this.sharpestPointToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sharpestPointToolStripMenuItem.Name = "sharpestPointToolStripMenuItem";
            this.sharpestPointToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.sharpestPointToolStripMenuItem.Text = "Sharpest Point";
            this.sharpestPointToolStripMenuItem.Click += new System.EventHandler(this.SharpestPointToolStripMenuItem_Click);
            // 
            // convertToToolStripMenuItem
            // 
            this.convertToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meterToolStripMenuItem,
            this.feetToolStripMenuItem});
            this.convertToToolStripMenuItem.Name = "convertToToolStripMenuItem";
            this.convertToToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.convertToToolStripMenuItem.Text = "Convert To &Unit...";
            // 
            // meterToolStripMenuItem
            // 
            this.meterToolStripMenuItem.Name = "meterToolStripMenuItem";
            this.meterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.meterToolStripMenuItem.Text = "&Meter";
            this.meterToolStripMenuItem.Click += new System.EventHandler(this.MeterToolStripMenuItem_Click);
            // 
            // feetToolStripMenuItem
            // 
            this.feetToolStripMenuItem.Name = "feetToolStripMenuItem";
            this.feetToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.feetToolStripMenuItem.Text = "&Feet";
            this.feetToolStripMenuItem.Click += new System.EventHandler(this.FeetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSourceToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // viewSourceToolStripMenuItem
            // 
            this.viewSourceToolStripMenuItem.Name = "viewSourceToolStripMenuItem";
            this.viewSourceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.viewSourceToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.viewSourceToolStripMenuItem.Text = "View &Source";
            this.viewSourceToolStripMenuItem.Click += new System.EventHandler(this.ViewSourceToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.saveToolStripButton,
            this.deleteNodeToolStripButton,
            this.toolStripSeparator1,
            this.resetToolStripButton,
            this.toolStripSeparator2,
            this.ShowThreeViewToolStripButton,
            this.Show3DViewToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1172, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "toolStripButton2";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveViewOnTabPage);
            // 
            // resetToolStripButton
            // 
            this.resetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("resetToolStripButton.Image")));
            this.resetToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.resetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetToolStripButton.Name = "resetToolStripButton";
            this.resetToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.resetToolStripButton.Text = "toolStripButton2";
            this.resetToolStripButton.ToolTipText = "Reset zoom";
            this.resetToolStripButton.Click += new System.EventHandler(this.ResetToolStripButton_Click);
            // 
            // deleteNodeToolStripButton
            // 
            this.deleteNodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteNodeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteNodeToolStripButton.Image")));
            this.deleteNodeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteNodeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteNodeToolStripButton.Name = "deleteNodeToolStripButton";
            this.deleteNodeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteNodeToolStripButton.Text = "toolStripButton2";
            this.deleteNodeToolStripButton.ToolTipText = "Delete tree node";
            this.deleteNodeToolStripButton.Click += new System.EventHandler(this.DeleteNodeToolStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1172, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.defaultPagePanel);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1172, 599);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.wellsTreeView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchTextbox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(164, 599);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // wellsTreeView
            // 
            this.wellsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wellsTreeView.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wellsTreeView.Indent = 25;
            this.wellsTreeView.ItemHeight = 20;
            this.wellsTreeView.LineColor = System.Drawing.Color.LightCoral;
            this.wellsTreeView.Location = new System.Drawing.Point(3, 33);
            this.wellsTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wellsTreeView.Name = "wellsTreeView";
            treeNode2.Name = "Root";
            treeNode2.Text = "Wells";
            this.wellsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.wellsTreeView.Size = new System.Drawing.Size(158, 562);
            this.wellsTreeView.TabIndex = 0;
            this.wellsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.WellsTreeView_NodeMouseClick);
            this.wellsTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.WellsTreeView_NodeMouseDoubleClick);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextbox.Location = new System.Drawing.Point(3, 3);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(158, 23);
            this.searchTextbox.TabIndex = 2;
            this.searchTextbox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // defaultPagePanel
            // 
            this.defaultPagePanel.ColumnCount = 2;
            this.defaultPagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defaultPagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defaultPagePanel.Controls.Add(this.label8, 0, 4);
            this.defaultPagePanel.Controls.Add(this.label4, 0, 4);
            this.defaultPagePanel.Controls.Add(this.label1, 0, 1);
            this.defaultPagePanel.Controls.Add(this.label2, 0, 2);
            this.defaultPagePanel.Controls.Add(this.label3, 0, 3);
            this.defaultPagePanel.Controls.Add(this.pictureBox1, 0, 0);
            this.defaultPagePanel.Controls.Add(this.label5, 1, 1);
            this.defaultPagePanel.Controls.Add(this.label6, 1, 2);
            this.defaultPagePanel.Controls.Add(this.label7, 1, 3);
            this.defaultPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultPagePanel.Location = new System.Drawing.Point(0, 0);
            this.defaultPagePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.defaultPagePanel.Name = "defaultPagePanel";
            this.defaultPagePanel.RowCount = 5;
            this.defaultPagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.12173F));
            this.defaultPagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96957F));
            this.defaultPagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96957F));
            this.defaultPagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96957F));
            this.defaultPagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96957F));
            this.defaultPagePanel.Size = new System.Drawing.Size(1003, 599);
            this.defaultPagePanel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(332, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "View Source Files :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(504, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ctrl + F7";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(346, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load Trajectory :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(394, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save View :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(221, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Open Customized View Editor :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.defaultPagePanel.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.ContextMenuStrip = this.imageSourceReference;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(997, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // imageSourceReference
            // 
            this.imageSourceReference.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.imageSourceReference.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referenceToolStripMenuItem});
            this.imageSourceReference.Name = "imageSourceReference";
            this.imageSourceReference.Size = new System.Drawing.Size(135, 26);
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.referenceToolStripMenuItem.Text = "Reference";
            this.referenceToolStripMenuItem.Click += new System.EventHandler(this.ReferenceToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(504, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ctrl + Shift + O";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(504, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ctril + Shift + S";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(504, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ctrl + Shift + E";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1003, 599);
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawTabHeaderText_DrawItem);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawCloseIcon_MouseDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "CSV Files|*.csv|TXT Files|*.txt";
            this.openFileDialog.Multiselect = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpeg|PNG Files|*.png";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ShowThreeViewToolStripButton
            // 
            this.ShowThreeViewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowThreeViewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowThreeViewToolStripButton.Image")));
            this.ShowThreeViewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowThreeViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowThreeViewToolStripButton.Name = "ShowThreeViewToolStripButton";
            this.ShowThreeViewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ShowThreeViewToolStripButton.Text = "toolStripButton2";
            this.ShowThreeViewToolStripButton.Click += new System.EventHandler(this.ShowThreeViewToolStripButton_Click);
            // 
            // Show3DViewToolStripButton
            // 
            this.Show3DViewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Show3DViewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Show3DViewToolStripButton.Image")));
            this.Show3DViewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Show3DViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Show3DViewToolStripButton.Name = "Show3DViewToolStripButton";
            this.Show3DViewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Show3DViewToolStripButton.Text = "toolStripButton3";
            this.Show3DViewToolStripButton.Click += new System.EventHandler(this.Show3DViewToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 670);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(875, 628);
            this.Name = "MainForm";
            this.Text = "Well Trajectory Visualizer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.defaultPagePanel.ResumeLayout(false);
            this.defaultPagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.imageSourceReference.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TableLayoutPanel defaultPagePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSourceToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip imageSourceReference;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem allViewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topViewToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annnotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpestPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton resetToolStripButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView wellsTreeView;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.ToolStripButton deleteNodeToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ShowThreeViewToolStripButton;
        private System.Windows.Forms.ToolStripButton Show3DViewToolStripButton;
    }
}

