namespace Notepad2024 {
    partial class Notepad2024Form {
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            TextBox = new TextBox();
            CharacterLabel = new Label();
            CharacterNoSpaceLabel = new Label();
            WordLabel = new Label();
            LinesLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(869, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, newWindowToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(37, 20);
            FileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(145, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(145, 22);
            newWindowToolStripMenuItem.Text = "New Window";
            newWindowToolStripMenuItem.Click += newWindowToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(145, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(145, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(145, 22);
            saveAsToolStripMenuItem.Text = "Save as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(145, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // TextBox
            // 
            TextBox.Dock = DockStyle.Fill;
            TextBox.Location = new Point(4, 3);
            TextBox.Margin = new Padding(4, 3, 4, 3);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.ScrollBars = ScrollBars.Both;
            TextBox.Size = new Size(861, 681);
            TextBox.TabIndex = 1;
            TextBox.WordWrap = false;
            TextBox.TextChanged += TextBox_TextChanged;
            // 
            // CharacterLabel
            // 
            CharacterLabel.AutoSize = true;
            CharacterLabel.Location = new Point(4, 0);
            CharacterLabel.Margin = new Padding(4, 0, 4, 0);
            CharacterLabel.Name = "CharacterLabel";
            CharacterLabel.Size = new Size(75, 15);
            CharacterLabel.TabIndex = 2;
            CharacterLabel.Text = "Characters: 0";
            // 
            // CharacterNoSpaceLabel
            // 
            CharacterNoSpaceLabel.AutoSize = true;
            CharacterNoSpaceLabel.Location = new Point(219, 0);
            CharacterNoSpaceLabel.Margin = new Padding(4, 0, 4, 0);
            CharacterNoSpaceLabel.Name = "CharacterNoSpaceLabel";
            CharacterNoSpaceLabel.Size = new Size(133, 15);
            CharacterNoSpaceLabel.TabIndex = 2;
            CharacterNoSpaceLabel.Text = "Characters No Spaces: 0";
            // 
            // WordLabel
            // 
            WordLabel.AutoSize = true;
            WordLabel.Location = new Point(434, 0);
            WordLabel.Margin = new Padding(4, 0, 4, 0);
            WordLabel.Name = "WordLabel";
            WordLabel.Size = new Size(53, 15);
            WordLabel.TabIndex = 2;
            WordLabel.Text = "Words: 0";
            // 
            // LinesLabel
            // 
            LinesLabel.AutoSize = true;
            LinesLabel.Location = new Point(649, 0);
            LinesLabel.Margin = new Padding(4, 0, 4, 0);
            LinesLabel.Name = "LinesLabel";
            LinesLabel.Size = new Size(46, 15);
            LinesLabel.TabIndex = 2;
            LinesLabel.Text = "Lines: 1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.Size = new Size(869, 716);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(CharacterLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(LinesLabel, 3, 0);
            tableLayoutPanel2.Controls.Add(CharacterNoSpaceLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(WordLabel, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 690);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.Size = new Size(861, 23);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // Notepad2024Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 740);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Notepad2024Form";
            Text = "Notepad2024";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label CharacterLabel;
        private System.Windows.Forms.Label CharacterNoSpaceLabel;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label LinesLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
