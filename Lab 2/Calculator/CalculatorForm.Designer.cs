namespace Calculator
{
    partial class CalculatorForm
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
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FourthRowControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ThirdRowControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NineButton = new System.Windows.Forms.Button();
            this.MultButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SecondRowControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SixButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FirstRowControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.ResultsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.StoredNumberLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.MainTableLayout.SuspendLayout();
            this.FourthRowControlPanel.SuspendLayout();
            this.ThirdRowControlPanel.SuspendLayout();
            this.SecondRowControlPanel.SuspendLayout();
            this.FirstRowControlPanel.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.Controls.Add(this.FourthRowControlPanel, 0, 4);
            this.MainTableLayout.Controls.Add(this.ThirdRowControlPanel, 0, 3);
            this.MainTableLayout.Controls.Add(this.SecondRowControlPanel, 0, 2);
            this.MainTableLayout.Controls.Add(this.FirstRowControlPanel, 0, 1);
            this.MainTableLayout.Controls.Add(this.ResultsPanel, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 5;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayout.Size = new System.Drawing.Size(334, 411);
            this.MainTableLayout.TabIndex = 0;
            // 
            // FourthRowControlPanel
            // 
            this.FourthRowControlPanel.ColumnCount = 4;
            this.FourthRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FourthRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FourthRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FourthRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FourthRowControlPanel.Controls.Add(this.EqualsButton, 0, 0);
            this.FourthRowControlPanel.Controls.Add(this.DivideButton, 0, 0);
            this.FourthRowControlPanel.Controls.Add(this.ResetButton, 0, 0);
            this.FourthRowControlPanel.Controls.Add(this.ZeroButton, 0, 0);
            this.FourthRowControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourthRowControlPanel.Location = new System.Drawing.Point(3, 331);
            this.FourthRowControlPanel.Name = "FourthRowControlPanel";
            this.FourthRowControlPanel.RowCount = 1;
            this.FourthRowControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FourthRowControlPanel.Size = new System.Drawing.Size(328, 77);
            this.FourthRowControlPanel.TabIndex = 4;
            // 
            // EqualsButton
            // 
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EqualsButton.Location = new System.Drawing.Point(167, 3);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(76, 71);
            this.EqualsButton.TabIndex = 4;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivideButton.Location = new System.Drawing.Point(249, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(76, 71);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(3, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(76, 71);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "C";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZeroButton.Location = new System.Drawing.Point(85, 3);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(76, 71);
            this.ZeroButton.TabIndex = 1;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ThirdRowControlPanel
            // 
            this.ThirdRowControlPanel.ColumnCount = 4;
            this.ThirdRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ThirdRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ThirdRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ThirdRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ThirdRowControlPanel.Controls.Add(this.NineButton, 0, 0);
            this.ThirdRowControlPanel.Controls.Add(this.MultButton, 0, 0);
            this.ThirdRowControlPanel.Controls.Add(this.SevenButton, 0, 0);
            this.ThirdRowControlPanel.Controls.Add(this.EightButton, 0, 0);
            this.ThirdRowControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThirdRowControlPanel.Location = new System.Drawing.Point(3, 249);
            this.ThirdRowControlPanel.Name = "ThirdRowControlPanel";
            this.ThirdRowControlPanel.RowCount = 1;
            this.ThirdRowControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ThirdRowControlPanel.Size = new System.Drawing.Size(328, 76);
            this.ThirdRowControlPanel.TabIndex = 3;
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NineButton.Location = new System.Drawing.Point(167, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(76, 70);
            this.NineButton.TabIndex = 4;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // MultButton
            // 
            this.MultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultButton.Location = new System.Drawing.Point(249, 3);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(76, 70);
            this.MultButton.TabIndex = 3;
            this.MultButton.Text = "X";
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(76, 70);
            this.SevenButton.TabIndex = 2;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EightButton.Location = new System.Drawing.Point(85, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(76, 70);
            this.EightButton.TabIndex = 1;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // SecondRowControlPanel
            // 
            this.SecondRowControlPanel.ColumnCount = 4;
            this.SecondRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondRowControlPanel.Controls.Add(this.SixButton, 0, 0);
            this.SecondRowControlPanel.Controls.Add(this.MinusButton, 0, 0);
            this.SecondRowControlPanel.Controls.Add(this.FourButton, 0, 0);
            this.SecondRowControlPanel.Controls.Add(this.FiveButton, 0, 0);
            this.SecondRowControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondRowControlPanel.Location = new System.Drawing.Point(3, 167);
            this.SecondRowControlPanel.Name = "SecondRowControlPanel";
            this.SecondRowControlPanel.RowCount = 1;
            this.SecondRowControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SecondRowControlPanel.Size = new System.Drawing.Size(328, 76);
            this.SecondRowControlPanel.TabIndex = 2;
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SixButton.Location = new System.Drawing.Point(167, 3);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(76, 70);
            this.SixButton.TabIndex = 4;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinusButton.Location = new System.Drawing.Point(249, 3);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(76, 70);
            this.MinusButton.TabIndex = 3;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FourButton.Location = new System.Drawing.Point(3, 3);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(76, 70);
            this.FourButton.TabIndex = 2;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiveButton.Location = new System.Drawing.Point(85, 3);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(76, 70);
            this.FiveButton.TabIndex = 1;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // FirstRowControlPanel
            // 
            this.FirstRowControlPanel.ColumnCount = 4;
            this.FirstRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FirstRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FirstRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FirstRowControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FirstRowControlPanel.Controls.Add(this.PlusButton, 3, 0);
            this.FirstRowControlPanel.Controls.Add(this.ThreeButton, 2, 0);
            this.FirstRowControlPanel.Controls.Add(this.TwoButton, 1, 0);
            this.FirstRowControlPanel.Controls.Add(this.OneButton, 0, 0);
            this.FirstRowControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstRowControlPanel.Location = new System.Drawing.Point(3, 85);
            this.FirstRowControlPanel.Name = "FirstRowControlPanel";
            this.FirstRowControlPanel.RowCount = 1;
            this.FirstRowControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FirstRowControlPanel.Size = new System.Drawing.Size(328, 76);
            this.FirstRowControlPanel.TabIndex = 1;
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlusButton.Location = new System.Drawing.Point(249, 3);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(76, 70);
            this.PlusButton.TabIndex = 3;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThreeButton.Location = new System.Drawing.Point(167, 3);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(76, 70);
            this.ThreeButton.TabIndex = 2;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TwoButton.Location = new System.Drawing.Point(85, 3);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(76, 70);
            this.TwoButton.TabIndex = 1;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OneButton.Location = new System.Drawing.Point(3, 3);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(76, 70);
            this.OneButton.TabIndex = 0;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.ColumnCount = 2;
            this.ResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.ResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ResultsPanel.Controls.Add(this.InputTextBox, 0, 0);
            this.ResultsPanel.Controls.Add(this.StoredNumberLabel, 1, 0);
            this.ResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsPanel.Location = new System.Drawing.Point(3, 3);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.RowCount = 1;
            this.ResultsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultsPanel.Size = new System.Drawing.Size(328, 76);
            this.ResultsPanel.TabIndex = 0;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputTextBox.Location = new System.Drawing.Point(3, 14);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ReadOnly = true;
            this.InputTextBox.Size = new System.Drawing.Size(240, 48);
            this.InputTextBox.TabIndex = 0;
            // 
            // StoredNumberLabel
            // 
            this.StoredNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StoredNumberLabel.AutoSize = true;
            this.StoredNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StoredNumberLabel.Location = new System.Drawing.Point(249, 24);
            this.StoredNumberLabel.Name = "StoredNumberLabel";
            this.StoredNumberLabel.Size = new System.Drawing.Size(76, 28);
            this.StoredNumberLabel.TabIndex = 1;
            this.StoredNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.MainTableLayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "CalculatorForm";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.MainTableLayout.ResumeLayout(false);
            this.FourthRowControlPanel.ResumeLayout(false);
            this.ThirdRowControlPanel.ResumeLayout(false);
            this.SecondRowControlPanel.ResumeLayout(false);
            this.FirstRowControlPanel.ResumeLayout(false);
            this.ResultsPanel.ResumeLayout(false);
            this.ResultsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainTableLayout;
        private TableLayoutPanel FourthRowControlPanel;
        private TableLayoutPanel ThirdRowControlPanel;
        private TableLayoutPanel SecondRowControlPanel;
        private TableLayoutPanel FirstRowControlPanel;
        private TableLayoutPanel ResultsPanel;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button EqualsButton;
        private Button DivideButton;
        private Button ResetButton;
        private Button ZeroButton;
        private Button NineButton;
        private Button MultButton;
        private Button SevenButton;
        private Button EightButton;
        private Button SixButton;
        private Button MinusButton;
        private Button FourButton;
        private Button FiveButton;
        private Button PlusButton;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private TextBox InputTextBox;
        private Label StoredNumberLabel;
    }
}