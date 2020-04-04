namespace CreateControls
{
    partial class createControls
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
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.panelNumberOfControls = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtNumberOfCols = new System.Windows.Forms.TextBox();
            this.txtNumberOfRows = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearControls = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTextBoxControls = new System.Windows.Forms.ToolStripMenuItem();
            this.createLabelControls = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelNumberOfControls.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControls
            // 
            this.grpControls.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpControls.Location = new System.Drawing.Point(0, 27);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(482, 497);
            this.grpControls.TabIndex = 0;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // panelNumberOfControls
            // 
            this.panelNumberOfControls.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelNumberOfControls.Controls.Add(this.btnCreate);
            this.panelNumberOfControls.Controls.Add(this.txtNumberOfCols);
            this.panelNumberOfControls.Controls.Add(this.txtNumberOfRows);
            this.panelNumberOfControls.Controls.Add(this.label4);
            this.panelNumberOfControls.Controls.Add(this.label3);
            this.panelNumberOfControls.Controls.Add(this.label1);
            this.panelNumberOfControls.Location = new System.Drawing.Point(123, 27);
            this.panelNumberOfControls.Name = "panelNumberOfControls";
            this.panelNumberOfControls.Size = new System.Drawing.Size(238, 154);
            this.panelNumberOfControls.TabIndex = 3;
            this.panelNumberOfControls.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.Location = new System.Drawing.Point(69, 116);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 35);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtNumberOfCols
            // 
            this.txtNumberOfCols.Location = new System.Drawing.Point(168, 78);
            this.txtNumberOfCols.MaxLength = 1;
            this.txtNumberOfCols.Name = "txtNumberOfCols";
            this.txtNumberOfCols.Size = new System.Drawing.Size(26, 20);
            this.txtNumberOfCols.TabIndex = 4;
            this.txtNumberOfCols.Text = "0";
            // 
            // txtNumberOfRows
            // 
            this.txtNumberOfRows.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNumberOfRows.Location = new System.Drawing.Point(168, 49);
            this.txtNumberOfRows.MaxLength = 1;
            this.txtNumberOfRows.Name = "txtNumberOfRows";
            this.txtNumberOfRows.Size = new System.Drawing.Size(26, 20);
            this.txtNumberOfRows.TabIndex = 3;
            this.txtNumberOfRows.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of Cols:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of Rows:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Controls";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearControls,
            this.exitApplication});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearControls
            // 
            this.clearControls.Name = "clearControls";
            this.clearControls.ShortcutKeyDisplayString = "Ctrl+Shift+C";
            this.clearControls.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.clearControls.Size = new System.Drawing.Size(223, 22);
            this.clearControls.Text = "Clear Controls";
            this.clearControls.Click += new System.EventHandler(this.clearControlsToolStripMenuItem_Click);
            // 
            // exitApplication
            // 
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.ShortcutKeyDisplayString = "Ctrl+Shift+E";
            this.exitApplication.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exitApplication.Size = new System.Drawing.Size(223, 22);
            this.exitApplication.Text = "Exit";
            this.exitApplication.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTextBoxControls,
            this.createLabelControls});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // createTextBoxControls
            // 
            this.createTextBoxControls.Name = "createTextBoxControls";
            this.createTextBoxControls.ShortcutKeyDisplayString = "Ctrl+Shift+T";
            this.createTextBoxControls.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.createTextBoxControls.Size = new System.Drawing.Size(190, 22);
            this.createTextBoxControls.Text = "Text Box";
            this.createTextBoxControls.Click += new System.EventHandler(this.createTextBoxControls_Click);
            // 
            // createLabelControls
            // 
            this.createLabelControls.Name = "createLabelControls";
            this.createLabelControls.ShortcutKeyDisplayString = "Ctrl+Shift+L";
            this.createLabelControls.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.createLabelControls.Size = new System.Drawing.Size(190, 22);
            this.createLabelControls.Text = "Label";
            this.createLabelControls.Click += new System.EventHandler(this.createLabelControls_Click);
            // 
            // createControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 517);
            this.Controls.Add(this.panelNumberOfControls);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "createControls";
            this.Text = "Create Controls";
            this.panelNumberOfControls.ResumeLayout(false);
            this.panelNumberOfControls.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearControls;
        private System.Windows.Forms.ToolStripMenuItem exitApplication;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTextBoxControls;
        private System.Windows.Forms.ToolStripMenuItem createLabelControls;
        private System.Windows.Forms.Panel panelNumberOfControls;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtNumberOfCols;
        private System.Windows.Forms.TextBox txtNumberOfRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

