namespace desktop_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_item1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveParametersToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSolutionToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProcedureFromDllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeComputationsInOtherThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeComputationsInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.anotherProjectsLink = new System.Windows.Forms.LinkLabel();
            this.assetsNumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.assetsGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.periodTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.removeRow = new System.Windows.Forms.Button();
            this.answerGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.answerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item1,
            this.editToolStripMenuItem,
            this.actionsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menu_item1
            // 
            this.menu_item1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadFileToolStripMenuItem,
            this.saveParametersToFileToolStripMenuItem,
            this.saveSolutionToFileToolStripMenuItem});
            this.menu_item1.Name = "menu_item1";
            resources.ApplyResources(this.menu_item1, "menu_item1");
            this.menu_item1.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // uploadFileToolStripMenuItem
            // 
            this.uploadFileToolStripMenuItem.Name = "uploadFileToolStripMenuItem";
            resources.ApplyResources(this.uploadFileToolStripMenuItem, "uploadFileToolStripMenuItem");
            this.uploadFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
            // 
            // saveParametersToFileToolStripMenuItem
            // 
            this.saveParametersToFileToolStripMenuItem.Name = "saveParametersToFileToolStripMenuItem";
            resources.ApplyResources(this.saveParametersToFileToolStripMenuItem, "saveParametersToFileToolStripMenuItem");
            // 
            // saveSolutionToFileToolStripMenuItem
            // 
            this.saveSolutionToFileToolStripMenuItem.Name = "saveSolutionToFileToolStripMenuItem";
            resources.ApplyResources(this.saveSolutionToFileToolStripMenuItem, "saveSolutionToFileToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProcedureFromDllToolStripMenuItem,
            this.makeComputationsInOtherThreadToolStripMenuItem,
            this.makeComputationsInToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            resources.ApplyResources(this.actionsToolStripMenuItem, "actionsToolStripMenuItem");
            // 
            // loadProcedureFromDllToolStripMenuItem
            // 
            this.loadProcedureFromDllToolStripMenuItem.Name = "loadProcedureFromDllToolStripMenuItem";
            resources.ApplyResources(this.loadProcedureFromDllToolStripMenuItem, "loadProcedureFromDllToolStripMenuItem");
            // 
            // makeComputationsInOtherThreadToolStripMenuItem
            // 
            this.makeComputationsInOtherThreadToolStripMenuItem.Name = "makeComputationsInOtherThreadToolStripMenuItem";
            resources.ApplyResources(this.makeComputationsInOtherThreadToolStripMenuItem, "makeComputationsInOtherThreadToolStripMenuItem");
            // 
            // makeComputationsInToolStripMenuItem
            // 
            this.makeComputationsInToolStripMenuItem.Name = "makeComputationsInToolStripMenuItem";
            resources.ApplyResources(this.makeComputationsInToolStripMenuItem, "makeComputationsInToolStripMenuItem");
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.removeRow);
            this.tabPage1.Controls.Add(this.addRowButton);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.filenameBox);
            this.tabPage1.Controls.Add(this.anotherProjectsLink);
            this.tabPage1.Controls.Add(this.assetsNumTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.assetsGrid);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.capitalTextBox);
            this.tabPage1.Controls.Add(this.periodTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // filenameBox
            // 
            resources.ApplyResources(this.filenameBox, "filenameBox");
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // anotherProjectsLink
            // 
            resources.ApplyResources(this.anotherProjectsLink, "anotherProjectsLink");
            this.anotherProjectsLink.Name = "anotherProjectsLink";
            this.anotherProjectsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // assetsNumTextBox
            // 
            resources.ApplyResources(this.assetsNumTextBox, "assetsNumTextBox");
            this.assetsNumTextBox.Name = "assetsNumTextBox";
            this.assetsNumTextBox.TextChanged += new System.EventHandler(this.assetsNumTextBox_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // assetsGrid
            // 
            this.assetsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.assetsGrid, "assetsGrid");
            this.assetsGrid.Name = "assetsGrid";
            this.assetsGrid.RowTemplate.Height = 24;
            this.assetsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // capitalTextBox
            // 
            resources.ApplyResources(this.capitalTextBox, "capitalTextBox");
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // periodTextBox
            // 
            resources.ApplyResources(this.periodTextBox, "periodTextBox");
            this.periodTextBox.Name = "periodTextBox";
            this.periodTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.answerGridView);
            this.tabPage2.Controls.Add(this.answerBox);
            this.tabPage2.Controls.Add(this.label5);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // answerBox
            // 
            resources.ApplyResources(this.answerBox, "answerBox");
            this.answerBox.Name = "answerBox";
            this.answerBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addRowButton
            // 
            resources.ApplyResources(this.addRowButton, "addRowButton");
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // removeRow
            // 
            resources.ApplyResources(this.removeRow, "removeRow");
            this.removeRow.Name = "removeRow";
            this.removeRow.UseVisualStyleBackColor = true;
            this.removeRow.Click += new System.EventHandler(this.removeRow_Click);
            // 
            // answerGridView
            // 
            this.answerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.answerGridView, "answerGridView");
            this.answerGridView.Name = "answerGridView";
            this.answerGridView.ReadOnly = true;
            this.answerGridView.RowTemplate.Height = 24;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.answerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_item1;
        private System.Windows.Forms.ToolStripMenuItem uploadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProcedureFromDllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeComputationsInOtherThreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeComputationsInToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.TextBox periodTextBox;
        private System.Windows.Forms.DataGridView assetsGrid;
        private System.Windows.Forms.TextBox assetsNumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem saveParametersToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSolutionToFileToolStripMenuItem;
        private System.Windows.Forms.LinkLabel anotherProjectsLink;
        private System.Windows.Forms.LinkLabel.Link link1 = new System.Windows.Forms.LinkLabel.Link(0, int.MaxValue, "https://github.com/nizhikebinesi");
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button removeRow;
        private System.Windows.Forms.DataGridView answerGridView;
    }
}

