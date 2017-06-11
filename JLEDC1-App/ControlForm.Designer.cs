namespace JLEDC1_App
{
    partial class ControlForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseNewConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.redBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.greenLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.blueLabel = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseNewConnectionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // chooseNewConnectionToolStripMenuItem
            // 
            this.chooseNewConnectionToolStripMenuItem.Name = "chooseNewConnectionToolStripMenuItem";
            this.chooseNewConnectionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.chooseNewConnectionToolStripMenuItem.Text = "Choose new connection";
            this.chooseNewConnectionToolStripMenuItem.Click += new System.EventHandler(this.chooseNewConnectionToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(692, 348);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.infoBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 176);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.redBar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 57);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(226, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "200";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redBar
            // 
            this.redBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redBar.LargeChange = 64;
            this.redBar.Location = new System.Drawing.Point(0, 0);
            this.redBar.Maximum = 253;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(226, 57);
            this.redBar.SmallChange = 16;
            this.redBar.TabIndex = 3;
            this.redBar.TickFrequency = 64;
            this.redBar.Scroll += new System.EventHandler(this.redBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 172);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.greenBar);
            this.panel4.Controls.Add(this.greenLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 57);
            this.panel4.TabIndex = 1;
            // 
            // greenBar
            // 
            this.greenBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greenBar.LargeChange = 64;
            this.greenBar.Location = new System.Drawing.Point(0, 0);
            this.greenBar.Maximum = 253;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(226, 57);
            this.greenBar.SmallChange = 16;
            this.greenBar.TabIndex = 3;
            this.greenBar.TickFrequency = 64;
            this.greenBar.Scroll += new System.EventHandler(this.greenBar_Scroll);
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.SystemColors.Control;
            this.greenLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.greenLabel.ForeColor = System.Drawing.Color.Green;
            this.greenLabel.Location = new System.Drawing.Point(226, 0);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(29, 57);
            this.greenLabel.TabIndex = 0;
            this.greenLabel.Text = "200";
            this.greenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.blueBar);
            this.panel5.Controls.Add(this.blueLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(0, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 57);
            this.panel5.TabIndex = 2;
            // 
            // blueBar
            // 
            this.blueBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueBar.LargeChange = 64;
            this.blueBar.Location = new System.Drawing.Point(0, 0);
            this.blueBar.Maximum = 253;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(226, 57);
            this.blueBar.SmallChange = 16;
            this.blueBar.TabIndex = 3;
            this.blueBar.TickFrequency = 64;
            this.blueBar.Scroll += new System.EventHandler(this.blueBar_Scroll);
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.SystemColors.Control;
            this.blueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.blueLabel.ForeColor = System.Drawing.Color.Blue;
            this.blueLabel.Location = new System.Drawing.Point(226, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(29, 57);
            this.blueLabel.TabIndex = 0;
            this.blueLabel.Text = "200";
            this.blueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoBox
            // 
            this.infoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoBox.Location = new System.Drawing.Point(0, 0);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(255, 176);
            this.infoBox.TabIndex = 0;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 372);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem chooseNewConnectionToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar greenBar;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.Label label1;
    }
}

