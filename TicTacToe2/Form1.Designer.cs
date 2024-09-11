namespace TicTacToe2
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
            TopLeft = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            TopCenter = new Button();
            activePlaterLabel = new Label();
            TopRight = new Button();
            CenterLeft = new Button();
            CenterCenter = new Button();
            CenterRight = new Button();
            BottomLeft = new Button();
            BottomCenter = new Button();
            BottomRight = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TopLeft
            // 
            TopLeft.Font = new Font("Segoe UI", 50F);
            TopLeft.Location = new Point(3, 23);
            TopLeft.Name = "TopLeft";
            TopLeft.Size = new Size(179, 147);
            TopLeft.TabIndex = 0;
            TopLeft.Text = " ";
            TopLeft.UseVisualStyleBackColor = true;
            TopLeft.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(TopLeft, 0, 1);
            tableLayoutPanel1.Controls.Add(activePlaterLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(TopRight, 2, 1);
            tableLayoutPanel1.Controls.Add(CenterLeft, 0, 2);
            tableLayoutPanel1.Controls.Add(CenterCenter, 1, 2);
            tableLayoutPanel1.Controls.Add(CenterRight, 2, 2);
            tableLayoutPanel1.Controls.Add(BottomLeft, 0, 3);
            tableLayoutPanel1.Controls.Add(BottomCenter, 1, 3);
            tableLayoutPanel1.Controls.Add(BottomRight, 2, 3);
            tableLayoutPanel1.Controls.Add(TopCenter, 1, 1);
            tableLayoutPanel1.Location = new Point(92, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(558, 480);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // TopCenter
            // 
            TopCenter.Font = new Font("Segoe UI", 50F);
            TopCenter.Location = new Point(188, 23);
            TopCenter.Name = "TopCenter";
            TopCenter.Size = new Size(180, 147);
            TopCenter.TabIndex = 1;
            TopCenter.Text = " ";
            TopCenter.UseVisualStyleBackColor = true;
            TopCenter.Click += button1_Click;
            // 
            // activePlaterLabel
            // 
            activePlaterLabel.Location = new Point(188, 0);
            activePlaterLabel.Name = "activePlaterLabel";
            activePlaterLabel.Size = new Size(180, 20);
            activePlaterLabel.TabIndex = 2;
            activePlaterLabel.Text = "Aktywny Gracz: O";
            activePlaterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TopRight
            // 
            TopRight.Font = new Font("Segoe UI", 50F);
            TopRight.Location = new Point(374, 23);
            TopRight.Name = "TopRight";
            TopRight.Size = new Size(179, 147);
            TopRight.TabIndex = 3;
            TopRight.Text = " ";
            TopRight.UseVisualStyleBackColor = true;
            TopRight.Click += button1_Click;
            // 
            // CenterLeft
            // 
            CenterLeft.Font = new Font("Segoe UI", 50F);
            CenterLeft.Location = new Point(3, 176);
            CenterLeft.Name = "CenterLeft";
            CenterLeft.Size = new Size(179, 147);
            CenterLeft.TabIndex = 4;
            CenterLeft.Text = " ";
            CenterLeft.UseVisualStyleBackColor = true;
            CenterLeft.Click += button1_Click;
            // 
            // CenterCenter
            // 
            CenterCenter.Font = new Font("Segoe UI", 50F);
            CenterCenter.Location = new Point(188, 176);
            CenterCenter.Name = "CenterCenter";
            CenterCenter.Size = new Size(179, 147);
            CenterCenter.TabIndex = 5;
            CenterCenter.Text = " ";
            CenterCenter.UseVisualStyleBackColor = true;
            CenterCenter.Click += button1_Click;
            // 
            // CenterRight
            // 
            CenterRight.Font = new Font("Segoe UI", 50F);
            CenterRight.Location = new Point(374, 176);
            CenterRight.Name = "CenterRight";
            CenterRight.Size = new Size(179, 147);
            CenterRight.TabIndex = 6;
            CenterRight.Text = " ";
            CenterRight.UseVisualStyleBackColor = true;
            CenterRight.Click += button1_Click;
            // 
            // BottomLeft
            // 
            BottomLeft.Font = new Font("Segoe UI", 50F);
            BottomLeft.Location = new Point(3, 329);
            BottomLeft.Name = "BottomLeft";
            BottomLeft.Size = new Size(179, 147);
            BottomLeft.TabIndex = 7;
            BottomLeft.Text = " ";
            BottomLeft.UseVisualStyleBackColor = true;
            BottomLeft.Click += button1_Click;
            // 
            // BottomCenter
            // 
            BottomCenter.Font = new Font("Segoe UI", 50F);
            BottomCenter.Location = new Point(188, 329);
            BottomCenter.Name = "BottomCenter";
            BottomCenter.Size = new Size(179, 147);
            BottomCenter.TabIndex = 8;
            BottomCenter.Text = " ";
            BottomCenter.UseVisualStyleBackColor = true;
            BottomCenter.Click += button1_Click;
            // 
            // BottomRight
            // 
            BottomRight.Font = new Font("Segoe UI", 50F);
            BottomRight.Location = new Point(374, 329);
            BottomRight.Name = "BottomRight";
            BottomRight.Size = new Size(179, 147);
            BottomRight.TabIndex = 9;
            BottomRight.Text = " ";
            BottomRight.UseVisualStyleBackColor = true;
            BottomRight.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 667);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button TopLeft;
        private TableLayoutPanel tableLayoutPanel1;
        private Button TopCenter;
        private Label activePlaterLabel;
        private Button TopRight;
        private Button CenterLeft;
        private Button CenterCenter;
        private Button CenterRight;
        private Button BottomLeft;
        private Button BottomCenter;
        private Button BottomRight;
    }
}
