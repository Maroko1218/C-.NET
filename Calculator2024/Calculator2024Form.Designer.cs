namespace Calculator2024 {
    partial class Calculator2024Form {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            MainTableLayout = new TableLayoutPanel();
            FourthRowControlPanel = new TableLayoutPanel();
            EqualsButton = new Button();
            DivideButton = new Button();
            ResetButton = new Button();
            ZeroButton = new Button();
            ThirdRowControlPanel = new TableLayoutPanel();
            NineButton = new Button();
            MultButton = new Button();
            SevenButton = new Button();
            EightButton = new Button();
            SecondRowControlPanel = new TableLayoutPanel();
            SixButton = new Button();
            MinusButton = new Button();
            FourButton = new Button();
            FiveButton = new Button();
            FirstRowControlPanel = new TableLayoutPanel();
            PlusButton = new Button();
            ThreeButton = new Button();
            TwoButton = new Button();
            OneButton = new Button();
            ResultsPanel = new TableLayoutPanel();
            InputTextBox = new TextBox();
            StoredNumberLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            MainTableLayout.SuspendLayout();
            FourthRowControlPanel.SuspendLayout();
            ThirdRowControlPanel.SuspendLayout();
            SecondRowControlPanel.SuspendLayout();
            FirstRowControlPanel.SuspendLayout();
            ResultsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayout
            // 
            MainTableLayout.ColumnCount = 1;
            MainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            MainTableLayout.Controls.Add(FourthRowControlPanel, 0, 4);
            MainTableLayout.Controls.Add(ThirdRowControlPanel, 0, 3);
            MainTableLayout.Controls.Add(SecondRowControlPanel, 0, 2);
            MainTableLayout.Controls.Add(FirstRowControlPanel, 0, 1);
            MainTableLayout.Controls.Add(ResultsPanel, 0, 0);
            MainTableLayout.Dock = DockStyle.Fill;
            MainTableLayout.Location = new Point(0, 0);
            MainTableLayout.Margin = new Padding(4, 3, 4, 3);
            MainTableLayout.Name = "MainTableLayout";
            MainTableLayout.RowCount = 5;
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainTableLayout.Size = new Size(334, 411);
            MainTableLayout.TabIndex = 0;
            // 
            // FourthRowControlPanel
            // 
            FourthRowControlPanel.ColumnCount = 4;
            FourthRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FourthRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FourthRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FourthRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FourthRowControlPanel.Controls.Add(EqualsButton, 0, 0);
            FourthRowControlPanel.Controls.Add(DivideButton, 0, 0);
            FourthRowControlPanel.Controls.Add(ResetButton, 0, 0);
            FourthRowControlPanel.Controls.Add(ZeroButton, 0, 0);
            FourthRowControlPanel.Dock = DockStyle.Fill;
            FourthRowControlPanel.Location = new Point(4, 331);
            FourthRowControlPanel.Margin = new Padding(4, 3, 4, 3);
            FourthRowControlPanel.Name = "FourthRowControlPanel";
            FourthRowControlPanel.RowCount = 1;
            FourthRowControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FourthRowControlPanel.Size = new Size(326, 77);
            FourthRowControlPanel.TabIndex = 4;
            // 
            // EqualsButton
            // 
            EqualsButton.Dock = DockStyle.Fill;
            EqualsButton.Font = new Font("Segoe UI", 23F);
            EqualsButton.Location = new Point(166, 3);
            EqualsButton.Margin = new Padding(4, 3, 4, 3);
            EqualsButton.Name = "EqualsButton";
            EqualsButton.Size = new Size(73, 71);
            EqualsButton.TabIndex = 4;
            EqualsButton.Text = "=";
            EqualsButton.UseVisualStyleBackColor = true;
            EqualsButton.Click += EqualsButton_Click;
            // 
            // DivideButton
            // 
            DivideButton.Dock = DockStyle.Fill;
            DivideButton.Font = new Font("Segoe UI", 23F);
            DivideButton.Location = new Point(247, 3);
            DivideButton.Margin = new Padding(4, 3, 4, 3);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(75, 71);
            DivideButton.TabIndex = 3;
            DivideButton.Text = "/";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += DivideButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Dock = DockStyle.Fill;
            ResetButton.Font = new Font("Segoe UI", 23F);
            ResetButton.Location = new Point(4, 3);
            ResetButton.Margin = new Padding(4, 3, 4, 3);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(73, 71);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "C";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ClearButton_Click;
            // 
            // ZeroButton
            // 
            ZeroButton.Dock = DockStyle.Fill;
            ZeroButton.Font = new Font("Segoe UI", 23F);
            ZeroButton.Location = new Point(85, 3);
            ZeroButton.Margin = new Padding(4, 3, 4, 3);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(73, 71);
            ZeroButton.TabIndex = 1;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = true;
            ZeroButton.Click += NumberButton_Click;
            // 
            // ThirdRowControlPanel
            // 
            ThirdRowControlPanel.ColumnCount = 4;
            ThirdRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ThirdRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ThirdRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ThirdRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ThirdRowControlPanel.Controls.Add(NineButton, 0, 0);
            ThirdRowControlPanel.Controls.Add(MultButton, 0, 0);
            ThirdRowControlPanel.Controls.Add(SevenButton, 0, 0);
            ThirdRowControlPanel.Controls.Add(EightButton, 0, 0);
            ThirdRowControlPanel.Dock = DockStyle.Fill;
            ThirdRowControlPanel.Location = new Point(4, 249);
            ThirdRowControlPanel.Margin = new Padding(4, 3, 4, 3);
            ThirdRowControlPanel.Name = "ThirdRowControlPanel";
            ThirdRowControlPanel.RowCount = 1;
            ThirdRowControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ThirdRowControlPanel.Size = new Size(326, 76);
            ThirdRowControlPanel.TabIndex = 3;
            // 
            // NineButton
            // 
            NineButton.Dock = DockStyle.Fill;
            NineButton.Font = new Font("Segoe UI", 23F);
            NineButton.Location = new Point(166, 3);
            NineButton.Margin = new Padding(4, 3, 4, 3);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(73, 70);
            NineButton.TabIndex = 4;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = true;
            NineButton.Click += NumberButton_Click;
            // 
            // MultButton
            // 
            MultButton.Dock = DockStyle.Fill;
            MultButton.Font = new Font("Segoe UI", 23F);
            MultButton.Location = new Point(247, 3);
            MultButton.Margin = new Padding(4, 3, 4, 3);
            MultButton.Name = "MultButton";
            MultButton.Size = new Size(75, 70);
            MultButton.TabIndex = 3;
            MultButton.Text = "X";
            MultButton.UseVisualStyleBackColor = true;
            MultButton.Click += MultButton_Click;
            // 
            // SevenButton
            // 
            SevenButton.Dock = DockStyle.Fill;
            SevenButton.Font = new Font("Segoe UI", 23F);
            SevenButton.Location = new Point(4, 3);
            SevenButton.Margin = new Padding(4, 3, 4, 3);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(73, 70);
            SevenButton.TabIndex = 2;
            SevenButton.Text = "7";
            SevenButton.UseVisualStyleBackColor = true;
            SevenButton.Click += NumberButton_Click;
            // 
            // EightButton
            // 
            EightButton.Dock = DockStyle.Fill;
            EightButton.Font = new Font("Segoe UI", 23F);
            EightButton.Location = new Point(85, 3);
            EightButton.Margin = new Padding(4, 3, 4, 3);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(73, 70);
            EightButton.TabIndex = 1;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = true;
            EightButton.Click += NumberButton_Click;
            // 
            // SecondRowControlPanel
            // 
            SecondRowControlPanel.ColumnCount = 4;
            SecondRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            SecondRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            SecondRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            SecondRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            SecondRowControlPanel.Controls.Add(SixButton, 0, 0);
            SecondRowControlPanel.Controls.Add(MinusButton, 0, 0);
            SecondRowControlPanel.Controls.Add(FourButton, 0, 0);
            SecondRowControlPanel.Controls.Add(FiveButton, 0, 0);
            SecondRowControlPanel.Dock = DockStyle.Fill;
            SecondRowControlPanel.Location = new Point(4, 167);
            SecondRowControlPanel.Margin = new Padding(4, 3, 4, 3);
            SecondRowControlPanel.Name = "SecondRowControlPanel";
            SecondRowControlPanel.RowCount = 1;
            SecondRowControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            SecondRowControlPanel.Size = new Size(326, 76);
            SecondRowControlPanel.TabIndex = 2;
            // 
            // SixButton
            // 
            SixButton.Dock = DockStyle.Fill;
            SixButton.Font = new Font("Segoe UI", 23F);
            SixButton.Location = new Point(166, 3);
            SixButton.Margin = new Padding(4, 3, 4, 3);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(73, 70);
            SixButton.TabIndex = 4;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = true;
            SixButton.Click += NumberButton_Click;
            // 
            // MinusButton
            // 
            MinusButton.Dock = DockStyle.Fill;
            MinusButton.Font = new Font("Segoe UI", 23F);
            MinusButton.Location = new Point(247, 3);
            MinusButton.Margin = new Padding(4, 3, 4, 3);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(75, 70);
            MinusButton.TabIndex = 3;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // FourButton
            // 
            FourButton.Dock = DockStyle.Fill;
            FourButton.Font = new Font("Segoe UI", 23F);
            FourButton.Location = new Point(4, 3);
            FourButton.Margin = new Padding(4, 3, 4, 3);
            FourButton.Name = "FourButton";
            FourButton.Size = new Size(73, 70);
            FourButton.TabIndex = 2;
            FourButton.Text = "4";
            FourButton.UseVisualStyleBackColor = true;
            FourButton.Click += NumberButton_Click;
            // 
            // FiveButton
            // 
            FiveButton.Dock = DockStyle.Fill;
            FiveButton.Font = new Font("Segoe UI", 23F);
            FiveButton.Location = new Point(85, 3);
            FiveButton.Margin = new Padding(4, 3, 4, 3);
            FiveButton.Name = "FiveButton";
            FiveButton.Size = new Size(73, 70);
            FiveButton.TabIndex = 1;
            FiveButton.Text = "5";
            FiveButton.UseVisualStyleBackColor = true;
            FiveButton.Click += NumberButton_Click;
            // 
            // FirstRowControlPanel
            // 
            FirstRowControlPanel.ColumnCount = 4;
            FirstRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FirstRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FirstRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FirstRowControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FirstRowControlPanel.Controls.Add(PlusButton, 3, 0);
            FirstRowControlPanel.Controls.Add(ThreeButton, 2, 0);
            FirstRowControlPanel.Controls.Add(TwoButton, 1, 0);
            FirstRowControlPanel.Controls.Add(OneButton, 0, 0);
            FirstRowControlPanel.Dock = DockStyle.Fill;
            FirstRowControlPanel.Location = new Point(4, 85);
            FirstRowControlPanel.Margin = new Padding(4, 3, 4, 3);
            FirstRowControlPanel.Name = "FirstRowControlPanel";
            FirstRowControlPanel.RowCount = 1;
            FirstRowControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FirstRowControlPanel.Size = new Size(326, 76);
            FirstRowControlPanel.TabIndex = 1;
            // 
            // PlusButton
            // 
            PlusButton.Dock = DockStyle.Fill;
            PlusButton.Font = new Font("Segoe UI", 23F);
            PlusButton.Location = new Point(247, 3);
            PlusButton.Margin = new Padding(4, 3, 4, 3);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(75, 70);
            PlusButton.TabIndex = 3;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += PlusButton_Click;
            // 
            // ThreeButton
            // 
            ThreeButton.Dock = DockStyle.Fill;
            ThreeButton.Font = new Font("Segoe UI", 23F);
            ThreeButton.Location = new Point(166, 3);
            ThreeButton.Margin = new Padding(4, 3, 4, 3);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(73, 70);
            ThreeButton.TabIndex = 2;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = true;
            ThreeButton.Click += NumberButton_Click;
            // 
            // TwoButton
            // 
            TwoButton.Dock = DockStyle.Fill;
            TwoButton.Font = new Font("Segoe UI", 23F);
            TwoButton.Location = new Point(85, 3);
            TwoButton.Margin = new Padding(4, 3, 4, 3);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(73, 70);
            TwoButton.TabIndex = 1;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = true;
            TwoButton.Click += NumberButton_Click;
            // 
            // OneButton
            // 
            OneButton.Dock = DockStyle.Fill;
            OneButton.Font = new Font("Segoe UI", 23F);
            OneButton.Location = new Point(4, 3);
            OneButton.Margin = new Padding(4, 3, 4, 3);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(73, 70);
            OneButton.TabIndex = 0;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = true;
            OneButton.Click += NumberButton_Click;
            // 
            // ResultsPanel
            // 
            ResultsPanel.ColumnCount = 2;
            ResultsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            ResultsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ResultsPanel.Controls.Add(InputTextBox, 0, 0);
            ResultsPanel.Controls.Add(StoredNumberLabel, 1, 0);
            ResultsPanel.Dock = DockStyle.Fill;
            ResultsPanel.Location = new Point(4, 3);
            ResultsPanel.Margin = new Padding(4, 3, 4, 3);
            ResultsPanel.Name = "ResultsPanel";
            ResultsPanel.RowCount = 1;
            ResultsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ResultsPanel.Size = new Size(326, 76);
            ResultsPanel.TabIndex = 0;
            // 
            // InputTextBox
            // 
            InputTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            InputTextBox.Font = new Font("Segoe UI", 23F);
            InputTextBox.Location = new Point(4, 14);
            InputTextBox.Margin = new Padding(4, 3, 4, 3);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.ReadOnly = true;
            InputTextBox.Size = new Size(236, 48);
            InputTextBox.TabIndex = 0;
            // 
            // StoredNumberLabel
            // 
            StoredNumberLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StoredNumberLabel.AutoSize = true;
            StoredNumberLabel.Font = new Font("Segoe UI", 15F);
            StoredNumberLabel.Location = new Point(248, 24);
            StoredNumberLabel.Margin = new Padding(4, 0, 4, 0);
            StoredNumberLabel.Name = "StoredNumberLabel";
            StoredNumberLabel.Size = new Size(74, 28);
            StoredNumberLabel.TabIndex = 1;
            StoredNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // Calculator2024Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(MainTableLayout);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(350, 450);
            Name = "Calculator2024Form";
            ShowIcon = false;
            Text = "Calculator 2024";
            MainTableLayout.ResumeLayout(false);
            FourthRowControlPanel.ResumeLayout(false);
            ThirdRowControlPanel.ResumeLayout(false);
            SecondRowControlPanel.ResumeLayout(false);
            FirstRowControlPanel.ResumeLayout(false);
            ResultsPanel.ResumeLayout(false);
            ResultsPanel.PerformLayout();
            ResumeLayout(false);
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
