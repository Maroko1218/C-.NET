namespace StoreSystem {
    partial class StoreSystem {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.StoreListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.addItemAttributeCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.addItemTypeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addItemCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.addItemPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteItemNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.selectItemLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addItemAttributeCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteItemNumericUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 471);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PurchaseButton);
            this.tabPage1.Controls.Add(this.RemoveButton);
            this.tabPage1.Controls.Add(this.AddButton);
            this.tabPage1.Controls.Add(this.CartListBox);
            this.tabPage1.Controls.Add(this.StoreListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cashier Mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PurchaseButton.Location = new System.Drawing.Point(267, 414);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(109, 23);
            this.PurchaseButton.TabIndex = 4;
            this.PurchaseButton.Text = "Finalize Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(240, 203);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "<<";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(333, 203);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = ">>";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // CartListBox
            // 
            this.CartListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(414, 3);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(231, 439);
            this.CartListBox.TabIndex = 1;
            // 
            // StoreListBox
            // 
            this.StoreListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StoreListBox.FormattingEnabled = true;
            this.StoreListBox.Location = new System.Drawing.Point(3, 3);
            this.StoreListBox.Name = "StoreListBox";
            this.StoreListBox.Size = new System.Drawing.Size(231, 439);
            this.StoreListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.addItemAttributeCountNumericUpDown);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.addItemTypeTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.addItemCountNumericUpDown);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.addItemPriceNumericUpDown);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.addItemNameTextBox);
            this.tabPage2.Controls.Add(this.deleteItemNumericUpdown);
            this.tabPage2.Controls.Add(this.selectItemLabel);
            this.tabPage2.Controls.Add(this.deleteButton);
            this.tabPage2.Controls.Add(this.inventoryListBox);
            this.tabPage2.Controls.Add(this.addItemButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventory Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Number of extra fields";
            // 
            // addItemAttributeCountNumericUpDown
            // 
            this.addItemAttributeCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemAttributeCountNumericUpDown.Location = new System.Drawing.Point(492, 69);
            this.addItemAttributeCountNumericUpDown.Name = "addItemAttributeCountNumericUpDown";
            this.addItemAttributeCountNumericUpDown.Size = new System.Drawing.Size(106, 20);
            this.addItemAttributeCountNumericUpDown.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Item Type";
            // 
            // addItemTypeTextBox
            // 
            this.addItemTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemTypeTextBox.Location = new System.Drawing.Point(374, 68);
            this.addItemTypeTextBox.Name = "addItemTypeTextBox";
            this.addItemTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.addItemTypeTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Item Count";
            // 
            // addItemCountNumericUpDown
            // 
            this.addItemCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemCountNumericUpDown.Location = new System.Drawing.Point(587, 24);
            this.addItemCountNumericUpDown.Name = "addItemCountNumericUpDown";
            this.addItemCountNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.addItemCountNumericUpDown.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item Price";
            // 
            // addItemPriceNumericUpDown
            // 
            this.addItemPriceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemPriceNumericUpDown.Location = new System.Drawing.Point(492, 24);
            this.addItemPriceNumericUpDown.Name = "addItemPriceNumericUpDown";
            this.addItemPriceNumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.addItemPriceNumericUpDown.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item name";
            // 
            // addItemNameTextBox
            // 
            this.addItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemNameTextBox.Location = new System.Drawing.Point(374, 24);
            this.addItemNameTextBox.Name = "addItemNameTextBox";
            this.addItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addItemNameTextBox.TabIndex = 6;
            // 
            // deleteItemNumericUpdown
            // 
            this.deleteItemNumericUpdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteItemNumericUpdown.Location = new System.Drawing.Point(380, 195);
            this.deleteItemNumericUpdown.Name = "deleteItemNumericUpdown";
            this.deleteItemNumericUpdown.Size = new System.Drawing.Size(114, 20);
            this.deleteItemNumericUpdown.TabIndex = 5;
            // 
            // selectItemLabel
            // 
            this.selectItemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectItemLabel.AutoSize = true;
            this.selectItemLabel.Location = new System.Drawing.Point(377, 177);
            this.selectItemLabel.Name = "selectItemLabel";
            this.selectItemLabel.Size = new System.Drawing.Size(165, 13);
            this.selectItemLabel.TabIndex = 4;
            this.selectItemLabel.Text = "Select an ID you want to manage";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(514, 193);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryListBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 15;
            this.inventoryListBox.Location = new System.Drawing.Point(3, 3);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.inventoryListBox.Size = new System.Drawing.Size(365, 439);
            this.inventoryListBox.TabIndex = 1;
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemButton.Location = new System.Drawing.Point(374, 94);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 0;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // StoreSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 471);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(672, 510);
            this.Name = "StoreSystem";
            this.ShowIcon = false;
            this.Text = "StoreSystem";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addItemAttributeCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteItemNumericUpdown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox StoreListBox;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.NumericUpDown deleteItemNumericUpdown;
        private System.Windows.Forms.Label selectItemLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addItemNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown addItemAttributeCountNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addItemTypeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown addItemCountNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown addItemPriceNumericUpDown;
    }
}

