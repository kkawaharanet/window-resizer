namespace WindowResizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonMove = new Button();
            contextMenuStripButtonMove = new ContextMenuStrip(components);
            move00ToolStripMenuItem = new ToolStripMenuItem();
            move88ToolStripMenuItem = new ToolStripMenuItem();
            move1616ToolStripMenuItem = new ToolStripMenuItem();
            numericUpDownX = new NumericUpDown();
            numericUpDownY = new NumericUpDown();
            numericUpDownWidth = new NumericUpDown();
            numericUpDownHeight = new NumericUpDown();
            buttonResize = new Button();
            contextMenuStripResize = new ContextMenuStrip(components);
            resize640x480ToolStripMenuItem = new ToolStripMenuItem();
            resize1280x720ToolStripMenuItem = new ToolStripMenuItem();
            resize1920x1080ToolStripMenuItem = new ToolStripMenuItem();
            resize1920x1200ToolStripMenuItem = new ToolStripMenuItem();
            buttonRefresh = new Button();
            listBoxWindows = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBoxFilter = new TextBox();
            contextMenuStripButtonMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            contextMenuStripResize.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonMove
            // 
            buttonMove.ContextMenuStrip = contextMenuStripButtonMove;
            buttonMove.Location = new Point(258, 22);
            buttonMove.Name = "buttonMove";
            buttonMove.Size = new Size(75, 23);
            buttonMove.TabIndex = 2;
            buttonMove.Text = "Move";
            buttonMove.UseVisualStyleBackColor = true;
            buttonMove.Click += buttonMove_Click;
            // 
            // contextMenuStripButtonMove
            // 
            contextMenuStripButtonMove.Items.AddRange(new ToolStripItem[] { move00ToolStripMenuItem, move88ToolStripMenuItem, move1616ToolStripMenuItem });
            contextMenuStripButtonMove.Name = "contextMenuStripButtonMove";
            contextMenuStripButtonMove.Size = new Size(146, 70);
            // 
            // move00ToolStripMenuItem
            // 
            move00ToolStripMenuItem.Name = "move00ToolStripMenuItem";
            move00ToolStripMenuItem.Size = new Size(145, 22);
            move00ToolStripMenuItem.Text = "Move (0, 0)";
            move00ToolStripMenuItem.Click += move00ToolStripMenuItem_Click;
            // 
            // move88ToolStripMenuItem
            // 
            move88ToolStripMenuItem.Name = "move88ToolStripMenuItem";
            move88ToolStripMenuItem.Size = new Size(145, 22);
            move88ToolStripMenuItem.Text = "Move (8, 8)";
            move88ToolStripMenuItem.Click += move88ToolStripMenuItem_Click;
            // 
            // move1616ToolStripMenuItem
            // 
            move1616ToolStripMenuItem.Name = "move1616ToolStripMenuItem";
            move1616ToolStripMenuItem.Size = new Size(145, 22);
            move1616ToolStripMenuItem.Text = "Move (16, 16)";
            move1616ToolStripMenuItem.Click += move1616ToolStripMenuItem_Click;
            // 
            // numericUpDownX
            // 
            numericUpDownX.Location = new Point(6, 22);
            numericUpDownX.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownX.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(120, 23);
            numericUpDownX.TabIndex = 3;
            // 
            // numericUpDownY
            // 
            numericUpDownY.Location = new Point(132, 22);
            numericUpDownY.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownY.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(120, 23);
            numericUpDownY.TabIndex = 3;
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(6, 22);
            numericUpDownWidth.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownWidth.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(120, 23);
            numericUpDownWidth.TabIndex = 3;
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(132, 22);
            numericUpDownHeight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownHeight.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(120, 23);
            numericUpDownHeight.TabIndex = 3;
            // 
            // buttonResize
            // 
            buttonResize.ContextMenuStrip = contextMenuStripResize;
            buttonResize.Location = new Point(258, 22);
            buttonResize.Name = "buttonResize";
            buttonResize.Size = new Size(75, 23);
            buttonResize.TabIndex = 2;
            buttonResize.Text = "Resize";
            buttonResize.UseVisualStyleBackColor = true;
            buttonResize.Click += buttonResize_Click;
            // 
            // contextMenuStripResize
            // 
            contextMenuStripResize.Items.AddRange(new ToolStripItem[] { resize640x480ToolStripMenuItem, resize1280x720ToolStripMenuItem, resize1920x1080ToolStripMenuItem, resize1920x1200ToolStripMenuItem });
            contextMenuStripResize.Name = "contextMenuStrip1";
            contextMenuStripResize.Size = new Size(164, 92);
            // 
            // resize640x480ToolStripMenuItem
            // 
            resize640x480ToolStripMenuItem.Name = "resize640x480ToolStripMenuItem";
            resize640x480ToolStripMenuItem.Size = new Size(163, 22);
            resize640x480ToolStripMenuItem.Text = "Resize 640x480";
            resize640x480ToolStripMenuItem.Click += resize640x480ToolStripMenuItem_Click;
            // 
            // resize1280x720ToolStripMenuItem
            // 
            resize1280x720ToolStripMenuItem.Name = "resize1280x720ToolStripMenuItem";
            resize1280x720ToolStripMenuItem.Size = new Size(163, 22);
            resize1280x720ToolStripMenuItem.Text = "Resize 1280x720";
            resize1280x720ToolStripMenuItem.Click += resize1280x720ToolStripMenuItem_Click;
            // 
            // resize1920x1080ToolStripMenuItem
            // 
            resize1920x1080ToolStripMenuItem.Name = "resize1920x1080ToolStripMenuItem";
            resize1920x1080ToolStripMenuItem.Size = new Size(163, 22);
            resize1920x1080ToolStripMenuItem.Text = "Resize 1920x1080";
            resize1920x1080ToolStripMenuItem.Click += resize1920x1080ToolStripMenuItem_Click;
            // 
            // resize1920x1200ToolStripMenuItem
            // 
            resize1920x1200ToolStripMenuItem.Name = "resize1920x1200ToolStripMenuItem";
            resize1920x1200ToolStripMenuItem.Size = new Size(163, 22);
            resize1920x1200ToolStripMenuItem.Text = "Resize 1920x1200";
            resize1920x1200ToolStripMenuItem.Click += resize1920x1200ToolStripMenuItem_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(12, 12);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // listBoxWindows
            // 
            listBoxWindows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxWindows.FormattingEnabled = true;
            listBoxWindows.Location = new Point(12, 41);
            listBoxWindows.Name = "listBoxWindows";
            listBoxWindows.Size = new Size(340, 304);
            listBoxWindows.TabIndex = 5;
            listBoxWindows.SelectedIndexChanged += listBoxWindows_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(numericUpDownX);
            groupBox1.Controls.Add(numericUpDownY);
            groupBox1.Controls.Add(buttonMove);
            groupBox1.Location = new Point(12, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 60);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Move";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(numericUpDownWidth);
            groupBox2.Controls.Add(numericUpDownHeight);
            groupBox2.Controls.Add(buttonResize);
            groupBox2.Location = new Point(12, 426);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 60);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resize";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilter.Location = new Point(93, 12);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(259, 23);
            textBoxFilter.TabIndex = 7;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 498);
            Controls.Add(textBoxFilter);
            Controls.Add(buttonRefresh);
            Controls.Add(groupBox2);
            Controls.Add(listBoxWindows);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Window Resizer";
            contextMenuStripButtonMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            contextMenuStripResize.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonMove;
        private NumericUpDown numericUpDownX;
        private NumericUpDown numericUpDownY;
        private NumericUpDown numericUpDownWidth;
        private NumericUpDown numericUpDownHeight;
        private Button buttonResize;
        private Button buttonRefresh;
        private ContextMenuStrip contextMenuStripButtonMove;
        private ToolStripMenuItem move00ToolStripMenuItem;
        private ContextMenuStrip contextMenuStripResize;
        private ToolStripMenuItem resize640x480ToolStripMenuItem;
        private ToolStripMenuItem resize1280x720ToolStripMenuItem;
        private ToolStripMenuItem resize1920x1080ToolStripMenuItem;
        private ToolStripMenuItem resize1920x1200ToolStripMenuItem;
        private ListBox listBoxWindows;
        private ToolStripMenuItem move88ToolStripMenuItem;
        private ToolStripMenuItem move1616ToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxFilter;
    }
}
