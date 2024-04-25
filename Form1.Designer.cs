namespace MatrixIDZ
{
    partial class Matrix
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dimensionNumericUpDown = new NumericUpDown();
            dimensionLabel = new Label();
            dataGridA = new DataGridView();
            dataGridB = new DataGridView();
            dataGridC = new DataGridView();
            determinantLabelB = new Label();
            determinantLabelC = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dimensionNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridC).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(dimensionNumericUpDown);
            panel1.Controls.Add(dimensionLabel);
            panel1.Controls.Add(dataGridA);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 955);
            panel1.TabIndex = 0;
            // 
            // dimensionNumericUpDown
            // 
            dimensionNumericUpDown.Location = new Point(208, 198);
            dimensionNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            dimensionNumericUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            dimensionNumericUpDown.Name = "dimensionNumericUpDown";
            dimensionNumericUpDown.Size = new Size(120, 23);
            dimensionNumericUpDown.TabIndex = 2;
            dimensionNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            dimensionNumericUpDown.ValueChanged += dimensionNumericUpDown_ValueChanged;
            // 
            // dimensionLabel
            // 
            dimensionLabel.AutoSize = true;
            dimensionLabel.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            dimensionLabel.ForeColor = Color.Black;
            dimensionLabel.Location = new Point(231, 149);
            dimensionLabel.Name = "dimensionLabel";
            dimensionLabel.Size = new Size(78, 25);
            dimensionLabel.TabIndex = 1;
            dimensionLabel.Text = "Размер";
            // 
            // dataGridA
            // 
            dataGridA.AllowUserToAddRows = false;
            dataGridA.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.GhostWhite;
            dataGridViewCellStyle1.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridA.BackgroundColor = SystemColors.ControlLight;
            dataGridA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridA.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridA.ImeMode = ImeMode.NoControl;
            dataGridA.Location = new Point(64, 269);
            dataGridA.Name = "dataGridA";
            dataGridA.ReadOnly = true;
            dataGridA.RowHeadersWidth = 23;
            dataGridA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridA.ScrollBars = ScrollBars.None;
            dataGridA.Size = new Size(412, 412);
            dataGridA.TabIndex = 0;
            // 
            // dataGridB
            // 
            dataGridB.AllowUserToAddRows = false;
            dataGridB.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.GhostWhite;
            dataGridB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridB.BackgroundColor = SystemColors.Control;
            dataGridB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridB.ImeMode = ImeMode.NoControl;
            dataGridB.Location = new Point(680, 34);
            dataGridB.Name = "dataGridB";
            dataGridB.ReadOnly = true;
            dataGridB.RowHeadersWidth = 23;
            dataGridB.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridB.ScrollBars = ScrollBars.None;
            dataGridB.Size = new Size(412, 412);
            dataGridB.TabIndex = 3;
            // 
            // dataGridC
            // 
            dataGridC.AllowUserToAddRows = false;
            dataGridC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.GhostWhite;
            dataGridC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridC.BackgroundColor = SystemColors.Control;
            dataGridC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridC.ImeMode = ImeMode.NoControl;
            dataGridC.Location = new Point(680, 507);
            dataGridC.Name = "dataGridC";
            dataGridC.ReadOnly = true;
            dataGridC.RowHeadersWidth = 23;
            dataGridC.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridC.ScrollBars = ScrollBars.None;
            dataGridC.Size = new Size(412, 412);
            dataGridC.TabIndex = 4;
            // 
            // determinantLabelB
            // 
            determinantLabelB.AutoSize = true;
            determinantLabelB.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            determinantLabelB.Location = new Point(1172, 233);
            determinantLabelB.Name = "determinantLabelB";
            determinantLabelB.Size = new Size(95, 43);
            determinantLabelB.TabIndex = 5;
            determinantLabelB.Text = "D = ";
            // 
            // determinantLabelC
            // 
            determinantLabelC.AutoSize = true;
            determinantLabelC.Font = new Font("Cascadia Code SemiBold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            determinantLabelC.Location = new Point(1172, 692);
            determinantLabelC.Name = "determinantLabelC";
            determinantLabelC.Size = new Size(95, 43);
            determinantLabelC.TabIndex = 6;
            determinantLabelC.Text = "D = ";
            // 
            // Matrix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1457, 955);
            Controls.Add(determinantLabelC);
            Controls.Add(determinantLabelB);
            Controls.Add(dataGridC);
            Controls.Add(dataGridB);
            Controls.Add(panel1);
            Name = "Matrix";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dimensionNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridA;
        private NumericUpDown dimensionNumericUpDown;
        private Label dimensionLabel;
        private DataGridView dataGridB;
        private DataGridView dataGridC;
        private Label determinantLabelB;
        private Label determinantLabelC;
    }
}
