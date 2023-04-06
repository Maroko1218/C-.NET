using System.Windows.Forms;

namespace LottoNumbersFrameworkEdition
{
    partial class LottoNumbersFrameworkEditionForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainFormPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LottoNumberPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LottoNumber1TextBox = new System.Windows.Forms.TextBox();
            this.LottoNumber2TextBox = new System.Windows.Forms.TextBox();
            this.LottoNumber3TextBox = new System.Windows.Forms.TextBox();
            this.LottoNumber4TextBox = new System.Windows.Forms.TextBox();
            this.LottoNumber5TextBox = new System.Windows.Forms.TextBox();
            this.LottoNumber6TextBox = new System.Windows.Forms.TextBox();
            this.LottoNumber7TextBox = new System.Windows.Forms.TextBox();
            this.LottoNumberLabel = new System.Windows.Forms.Label();
            this.PullCountPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PullCountLabel = new System.Windows.Forms.Label();
            this.PullCountButton = new System.Windows.Forms.Button();
            this.PullCountTextBox = new System.Windows.Forms.TextBox();
            this.ResultsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FiveRightLabel = new System.Windows.Forms.Label();
            this.FiveRightCountLabel = new System.Windows.Forms.Label();
            this.SixRightCountLabel = new System.Windows.Forms.Label();
            this.SevenRightLabel = new System.Windows.Forms.Label();
            this.SevenRightCountLabel = new System.Windows.Forms.Label();
            this.SixRightLabel = new System.Windows.Forms.Label();
            this.MainFormPanel.SuspendLayout();
            this.LottoNumberPanel.SuspendLayout();
            this.PullCountPanel.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormPanel
            // 
            this.MainFormPanel.ColumnCount = 1;
            this.MainFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainFormPanel.Controls.Add(this.LottoNumberPanel, 0, 0);
            this.MainFormPanel.Controls.Add(this.PullCountPanel, 0, 1);
            this.MainFormPanel.Controls.Add(this.ResultsPanel, 0, 2);
            this.MainFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormPanel.Location = new System.Drawing.Point(0, 0);
            this.MainFormPanel.Name = "MainFormPanel";
            this.MainFormPanel.RowCount = 3;
            this.MainFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainFormPanel.Size = new System.Drawing.Size(363, 94);
            this.MainFormPanel.TabIndex = 0;
            // 
            // LottoNumberPanel
            // 
            this.LottoNumberPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LottoNumberPanel.ColumnCount = 8;
            this.LottoNumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.LottoNumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LottoNumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LottoNumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LottoNumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LottoNumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LottoNumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LottoNumberPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LottoNumberPanel.Controls.Add(this.LottoNumber1TextBox, 1, 0);
            this.LottoNumberPanel.Controls.Add(this.LottoNumber2TextBox, 2, 0);
            this.LottoNumberPanel.Controls.Add(this.LottoNumber3TextBox, 3, 0);
            this.LottoNumberPanel.Controls.Add(this.LottoNumber4TextBox, 4, 0);
            this.LottoNumberPanel.Controls.Add(this.LottoNumber5TextBox, 5, 0);
            this.LottoNumberPanel.Controls.Add(this.LottoNumber6TextBox, 6, 0);
            this.LottoNumberPanel.Controls.Add(this.LottoNumber7TextBox, 7, 0);
            this.LottoNumberPanel.Controls.Add(this.LottoNumberLabel, 0, 0);
            this.LottoNumberPanel.Location = new System.Drawing.Point(3, 3);
            this.LottoNumberPanel.Name = "LottoNumberPanel";
            this.LottoNumberPanel.RowCount = 1;
            this.LottoNumberPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LottoNumberPanel.Size = new System.Drawing.Size(357, 26);
            this.LottoNumberPanel.TabIndex = 0;
            // 
            // LottoNumber1TextBox
            // 
            this.LottoNumber1TextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LottoNumber1TextBox.Location = new System.Drawing.Point(123, 3);
            this.LottoNumber1TextBox.Name = "LottoNumber1TextBox";
            this.LottoNumber1TextBox.Size = new System.Drawing.Size(27, 20);
            this.LottoNumber1TextBox.TabIndex = 1;
            // 
            // LottoNumber2TextBox
            // 
            this.LottoNumber2TextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LottoNumber2TextBox.Location = new System.Drawing.Point(156, 3);
            this.LottoNumber2TextBox.Name = "LottoNumber2TextBox";
            this.LottoNumber2TextBox.Size = new System.Drawing.Size(27, 20);
            this.LottoNumber2TextBox.TabIndex = 1;
            // 
            // LottoNumber3TextBox
            // 
            this.LottoNumber3TextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LottoNumber3TextBox.Location = new System.Drawing.Point(189, 3);
            this.LottoNumber3TextBox.Name = "LottoNumber3TextBox";
            this.LottoNumber3TextBox.Size = new System.Drawing.Size(27, 20);
            this.LottoNumber3TextBox.TabIndex = 1;
            // 
            // LottoNumber4TextBox
            // 
            this.LottoNumber4TextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LottoNumber4TextBox.Location = new System.Drawing.Point(222, 3);
            this.LottoNumber4TextBox.Name = "LottoNumber4TextBox";
            this.LottoNumber4TextBox.Size = new System.Drawing.Size(27, 20);
            this.LottoNumber4TextBox.TabIndex = 1;
            // 
            // LottoNumber5TextBox
            // 
            this.LottoNumber5TextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LottoNumber5TextBox.Location = new System.Drawing.Point(255, 3);
            this.LottoNumber5TextBox.Name = "LottoNumber5TextBox";
            this.LottoNumber5TextBox.Size = new System.Drawing.Size(27, 20);
            this.LottoNumber5TextBox.TabIndex = 1;
            // 
            // LottoNumber6TextBox
            // 
            this.LottoNumber6TextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LottoNumber6TextBox.Location = new System.Drawing.Point(288, 3);
            this.LottoNumber6TextBox.Name = "LottoNumber6TextBox";
            this.LottoNumber6TextBox.Size = new System.Drawing.Size(27, 20);
            this.LottoNumber6TextBox.TabIndex = 1;
            // 
            // LottoNumber7TextBox
            // 
            this.LottoNumber7TextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LottoNumber7TextBox.Location = new System.Drawing.Point(323, 3);
            this.LottoNumber7TextBox.Name = "LottoNumber7TextBox";
            this.LottoNumber7TextBox.Size = new System.Drawing.Size(29, 20);
            this.LottoNumber7TextBox.TabIndex = 1;
            // 
            // LottoNumberLabel
            // 
            this.LottoNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LottoNumberLabel.AutoSize = true;
            this.LottoNumberLabel.Location = new System.Drawing.Point(40, 0);
            this.LottoNumberLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.LottoNumberLabel.Name = "LottoNumberLabel";
            this.LottoNumberLabel.Size = new System.Drawing.Size(77, 20);
            this.LottoNumberLabel.TabIndex = 0;
            this.LottoNumberLabel.Text = "Pick your lotto number:";
            // 
            // PullCountPanel
            // 
            this.PullCountPanel.ColumnCount = 3;
            this.PullCountPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PullCountPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.PullCountPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PullCountPanel.Controls.Add(this.PullCountLabel, 0, 0);
            this.PullCountPanel.Controls.Add(this.PullCountButton, 2, 0);
            this.PullCountPanel.Controls.Add(this.PullCountTextBox, 1, 0);
            this.PullCountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PullCountPanel.Location = new System.Drawing.Point(3, 38);
            this.PullCountPanel.Name = "PullCountPanel";
            this.PullCountPanel.RowCount = 1;
            this.PullCountPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PullCountPanel.Size = new System.Drawing.Size(357, 29);
            this.PullCountPanel.TabIndex = 1;
            // 
            // PullCountLabel
            // 
            this.PullCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PullCountLabel.AutoSize = true;
            this.PullCountLabel.Location = new System.Drawing.Point(10, 5);
            this.PullCountLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.PullCountLabel.Name = "PullCountLabel";
            this.PullCountLabel.Size = new System.Drawing.Size(112, 13);
            this.PullCountLabel.TabIndex = 0;
            this.PullCountLabel.Text = "Amount of simulations:";
            // 
            // PullCountButton
            // 
            this.PullCountButton.Location = new System.Drawing.Point(235, 3);
            this.PullCountButton.Name = "PullCountButton";
            this.PullCountButton.Size = new System.Drawing.Size(96, 20);
            this.PullCountButton.TabIndex = 2;
            this.PullCountButton.Text = "Start Simulation";
            this.PullCountButton.UseVisualStyleBackColor = true;
            this.PullCountButton.Click += new System.EventHandler(this.PullCountButton_Click);
            // 
            // PullCountTextBox
            // 
            this.PullCountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PullCountTextBox.Location = new System.Drawing.Point(128, 3);
            this.PullCountTextBox.MaximumSize = new System.Drawing.Size(258, 4);
            this.PullCountTextBox.Name = "PullCountTextBox";
            this.PullCountTextBox.Size = new System.Drawing.Size(101, 4);
            this.PullCountTextBox.TabIndex = 1;
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultsPanel.ColumnCount = 6;
            this.ResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultsPanel.Controls.Add(this.FiveRightLabel, 0, 0);
            this.ResultsPanel.Controls.Add(this.FiveRightCountLabel, 1, 0);
            this.ResultsPanel.Controls.Add(this.SixRightCountLabel, 3, 0);
            this.ResultsPanel.Controls.Add(this.SevenRightLabel, 4, 0);
            this.ResultsPanel.Controls.Add(this.SevenRightCountLabel, 5, 0);
            this.ResultsPanel.Controls.Add(this.SixRightLabel, 2, 0);
            this.ResultsPanel.Location = new System.Drawing.Point(3, 73);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.RowCount = 1;
            this.ResultsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.ResultsPanel.Size = new System.Drawing.Size(357, 18);
            this.ResultsPanel.TabIndex = 2;
            // 
            // FiveRightLabel
            // 
            this.FiveRightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FiveRightLabel.AutoSize = true;
            this.FiveRightLabel.Location = new System.Drawing.Point(12, 2);
            this.FiveRightLabel.Name = "FiveRightLabel";
            this.FiveRightLabel.Size = new System.Drawing.Size(44, 13);
            this.FiveRightLabel.TabIndex = 0;
            this.FiveRightLabel.Text = "5 Right:";
            // 
            // FiveRightCountLabel
            // 
            this.FiveRightCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FiveRightCountLabel.AutoSize = true;
            this.FiveRightCountLabel.Location = new System.Drawing.Point(62, 2);
            this.FiveRightCountLabel.Name = "FiveRightCountLabel";
            this.FiveRightCountLabel.Size = new System.Drawing.Size(13, 13);
            this.FiveRightCountLabel.TabIndex = 1;
            this.FiveRightCountLabel.Text = "0";
            // 
            // SixRightCountLabel
            // 
            this.SixRightCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SixRightCountLabel.AutoSize = true;
            this.SixRightCountLabel.Location = new System.Drawing.Point(180, 2);
            this.SixRightCountLabel.Name = "SixRightCountLabel";
            this.SixRightCountLabel.Size = new System.Drawing.Size(13, 13);
            this.SixRightCountLabel.TabIndex = 1;
            this.SixRightCountLabel.Text = "0";
            // 
            // SevenRightLabel
            // 
            this.SevenRightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SevenRightLabel.AutoSize = true;
            this.SevenRightLabel.Location = new System.Drawing.Point(248, 2);
            this.SevenRightLabel.Name = "SevenRightLabel";
            this.SevenRightLabel.Size = new System.Drawing.Size(44, 13);
            this.SevenRightLabel.TabIndex = 0;
            this.SevenRightLabel.Text = "7 Right:";
            // 
            // SevenRightCountLabel
            // 
            this.SevenRightCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SevenRightCountLabel.AutoSize = true;
            this.SevenRightCountLabel.Location = new System.Drawing.Point(298, 2);
            this.SevenRightCountLabel.Name = "SevenRightCountLabel";
            this.SevenRightCountLabel.Size = new System.Drawing.Size(13, 13);
            this.SevenRightCountLabel.TabIndex = 1;
            this.SevenRightCountLabel.Text = "0";
            // 
            // SixRightLabel
            // 
            this.SixRightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SixRightLabel.AutoSize = true;
            this.SixRightLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SixRightLabel.Location = new System.Drawing.Point(130, 2);
            this.SixRightLabel.Name = "SixRightLabel";
            this.SixRightLabel.Size = new System.Drawing.Size(44, 13);
            this.SixRightLabel.TabIndex = 0;
            this.SixRightLabel.Text = "6 Right:";
            this.SixRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LottoNumbersFrameworkEditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 94);
            this.Controls.Add(this.MainFormPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 133);
            this.Name = "LottoNumbersFrameworkEditionForm";
            this.ShowIcon = false;
            this.Text = "Lotto Simulator";
            this.MainFormPanel.ResumeLayout(false);
            this.LottoNumberPanel.ResumeLayout(false);
            this.LottoNumberPanel.PerformLayout();
            this.PullCountPanel.ResumeLayout(false);
            this.PullCountPanel.PerformLayout();
            this.ResultsPanel.ResumeLayout(false);
            this.ResultsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainFormPanel;
        private TableLayoutPanel LottoNumberPanel;
        private Label LottoNumberLabel;
        private TextBox LottoNumber1TextBox;
        private TextBox LottoNumber2TextBox;
        private TextBox LottoNumber3TextBox;
        private TextBox LottoNumber4TextBox;
        private TextBox LottoNumber5TextBox;
        private TextBox LottoNumber6TextBox;
        private TextBox LottoNumber7TextBox;
        private TableLayoutPanel PullCountPanel;
        private Label PullCountLabel;
        private TextBox PullCountTextBox;
        private Button PullCountButton;
        private TableLayoutPanel ResultsPanel;
        private Label FiveRightLabel;
        private Label FiveRightCountLabel;
        private Label SixRightLabel;
        private Label SixRightCountLabel;
        private Label SevenRightLabel;
        private Label SevenRightCountLabel;
    }
}

