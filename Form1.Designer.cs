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
            comboBox1 = new ComboBox();
            buttonMove = new Button();
            numericUpDownX = new NumericUpDown();
            numericUpDownY = new NumericUpDown();
            numericUpDownWidth = new NumericUpDown();
            numericUpDownHeight = new NumericUpDown();
            buttonResize = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonMove
            // 
            buttonMove.Location = new Point(264, 41);
            buttonMove.Name = "buttonMove";
            buttonMove.Size = new Size(75, 23);
            buttonMove.TabIndex = 2;
            buttonMove.Text = "Move";
            buttonMove.UseVisualStyleBackColor = true;
            buttonMove.Click += buttonMove_Click;
            // 
            // numericUpDownX
            // 
            numericUpDownX.Location = new Point(12, 41);
            numericUpDownX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(120, 23);
            numericUpDownX.TabIndex = 3;
            // 
            // numericUpDownY
            // 
            numericUpDownY.Location = new Point(138, 41);
            numericUpDownY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(120, 23);
            numericUpDownY.TabIndex = 3;
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(12, 70);
            numericUpDownWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(120, 23);
            numericUpDownWidth.TabIndex = 3;
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(138, 70);
            numericUpDownHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(120, 23);
            numericUpDownHeight.TabIndex = 3;
            // 
            // buttonResize
            // 
            buttonResize.Location = new Point(264, 70);
            buttonResize.Name = "buttonResize";
            buttonResize.Size = new Size(75, 23);
            buttonResize.TabIndex = 2;
            buttonResize.Text = "Resize";
            buttonResize.UseVisualStyleBackColor = true;
            buttonResize.Click += buttonResize_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(264, 12);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUpdate);
            Controls.Add(numericUpDownHeight);
            Controls.Add(numericUpDownWidth);
            Controls.Add(numericUpDownY);
            Controls.Add(numericUpDownX);
            Controls.Add(buttonResize);
            Controls.Add(buttonMove);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private Button buttonMove;
        private NumericUpDown numericUpDownX;
        private NumericUpDown numericUpDownY;
        private NumericUpDown numericUpDownWidth;
        private NumericUpDown numericUpDownHeight;
        private Button buttonResize;
        private Button buttonUpdate;
    }
}
