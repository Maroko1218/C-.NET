
namespace StoreSystem2024 {
    partial class StoreSystem2024 {
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            PurchaseButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            CartListBox = new ListBox();
            StoreListBox = new ListBox();
            tabPage2 = new TabPage();
            orderMoreButton = new Button();
            addItemTypeComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            addItemCountNumericUpDown = new NumericUpDown();
            label2 = new Label();
            addItemPriceNumericUpDown = new NumericUpDown();
            label1 = new Label();
            addItemNameTextBox = new TextBox();
            deleteItemNumericUpdown = new NumericUpDown();
            selectItemLabel = new Label();
            deleteButton = new Button();
            inventoryListBox = new ListBox();
            addItemButton = new Button();
            APIButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addItemCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addItemPriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteItemNumericUpdown).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(765, 543);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(PurchaseButton);
            tabPage1.Controls.Add(RemoveButton);
            tabPage1.Controls.Add(AddButton);
            tabPage1.Controls.Add(CartListBox);
            tabPage1.Controls.Add(StoreListBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(757, 515);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cashier Mode";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // PurchaseButton
            // 
            PurchaseButton.Anchor = AnchorStyles.Bottom;
            PurchaseButton.Location = new Point(196, 478);
            PurchaseButton.Margin = new Padding(4, 3, 4, 3);
            PurchaseButton.Name = "PurchaseButton";
            PurchaseButton.Size = new Size(127, 27);
            PurchaseButton.TabIndex = 4;
            PurchaseButton.Text = "Finalize Purchase";
            PurchaseButton.UseVisualStyleBackColor = true;
            PurchaseButton.Click += PurchaseButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(100, 478);
            RemoveButton.Margin = new Padding(4, 3, 4, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(88, 27);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "-";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddButton.Location = new Point(4, 478);
            AddButton.Margin = new Padding(4, 3, 4, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(88, 27);
            AddButton.TabIndex = 2;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Dock = DockStyle.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(331, 3);
            CartListBox.Margin = new Padding(4, 3, 4, 3);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(422, 509);
            CartListBox.TabIndex = 1;
            // 
            // StoreListBox
            // 
            StoreListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            StoreListBox.FormattingEnabled = true;
            StoreListBox.ItemHeight = 15;
            StoreListBox.Location = new Point(4, 3);
            StoreListBox.Margin = new Padding(4, 3, 4, 3);
            StoreListBox.Name = "StoreListBox";
            StoreListBox.Size = new Size(319, 469);
            StoreListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(APIButton);
            tabPage2.Controls.Add(orderMoreButton);
            tabPage2.Controls.Add(addItemTypeComboBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(addItemCountNumericUpDown);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(addItemPriceNumericUpDown);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(addItemNameTextBox);
            tabPage2.Controls.Add(deleteItemNumericUpdown);
            tabPage2.Controls.Add(selectItemLabel);
            tabPage2.Controls.Add(deleteButton);
            tabPage2.Controls.Add(inventoryListBox);
            tabPage2.Controls.Add(addItemButton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(757, 515);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inventory Mode";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // orderMoreButton
            // 
            orderMoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orderMoreButton.Location = new Point(443, 276);
            orderMoreButton.Margin = new Padding(4, 3, 4, 3);
            orderMoreButton.Name = "orderMoreButton";
            orderMoreButton.Size = new Size(88, 27);
            orderMoreButton.TabIndex = 15;
            orderMoreButton.Text = "Order More";
            orderMoreButton.UseVisualStyleBackColor = true;
            orderMoreButton.Click += orderMoreButton_Click;
            // 
            // addItemTypeComboBox
            // 
            addItemTypeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addItemTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addItemTypeComboBox.ForeColor = Color.Black;
            addItemTypeComboBox.FormattingEnabled = true;
            addItemTypeComboBox.Items.AddRange(new object[] { "Book", "Game", "Movie" });
            addItemTypeComboBox.Location = new Point(436, 79);
            addItemTypeComboBox.Name = "addItemTypeComboBox";
            addItemTypeComboBox.Size = new Size(121, 23);
            addItemTypeComboBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(436, 60);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 13;
            label4.Text = "Item Type";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(681, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 11;
            label3.Text = "Item Count";
            // 
            // addItemCountNumericUpDown
            // 
            addItemCountNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addItemCountNumericUpDown.Location = new Point(685, 28);
            addItemCountNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            addItemCountNumericUpDown.Name = "addItemCountNumericUpDown";
            addItemCountNumericUpDown.Size = new Size(68, 23);
            addItemCountNumericUpDown.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(570, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Item Price";
            // 
            // addItemPriceNumericUpDown
            // 
            addItemPriceNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addItemPriceNumericUpDown.Location = new Point(574, 28);
            addItemPriceNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            addItemPriceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            addItemPriceNumericUpDown.Name = "addItemPriceNumericUpDown";
            addItemPriceNumericUpDown.Size = new Size(82, 23);
            addItemPriceNumericUpDown.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(433, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 7;
            label1.Text = "Item name";
            // 
            // addItemNameTextBox
            // 
            addItemNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addItemNameTextBox.Location = new Point(436, 28);
            addItemNameTextBox.Margin = new Padding(4, 3, 4, 3);
            addItemNameTextBox.Name = "addItemNameTextBox";
            addItemNameTextBox.Size = new Size(116, 23);
            addItemNameTextBox.TabIndex = 6;
            addItemNameTextBox.TextChanged += addItemNameTextBox_TextChanged;
            // 
            // deleteItemNumericUpdown
            // 
            deleteItemNumericUpdown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteItemNumericUpdown.Location = new Point(443, 225);
            deleteItemNumericUpdown.Margin = new Padding(4, 3, 4, 3);
            deleteItemNumericUpdown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            deleteItemNumericUpdown.Name = "deleteItemNumericUpdown";
            deleteItemNumericUpdown.Size = new Size(133, 23);
            deleteItemNumericUpdown.TabIndex = 5;
            deleteItemNumericUpdown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // selectItemLabel
            // 
            selectItemLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectItemLabel.AutoSize = true;
            selectItemLabel.Location = new Point(440, 204);
            selectItemLabel.Margin = new Padding(4, 0, 4, 0);
            selectItemLabel.Name = "selectItemLabel";
            selectItemLabel.Size = new Size(180, 15);
            selectItemLabel.TabIndex = 4;
            selectItemLabel.Text = "Select an ID you want to manage";
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Location = new Point(600, 276);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 27);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete Item";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // inventoryListBox
            // 
            inventoryListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inventoryListBox.Font = new Font("Cascadia Mono", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 15;
            inventoryListBox.Location = new Point(4, 3);
            inventoryListBox.Margin = new Padding(4, 3, 4, 3);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.SelectionMode = SelectionMode.None;
            inventoryListBox.Size = new Size(425, 499);
            inventoryListBox.TabIndex = 1;
            // 
            // addItemButton
            // 
            addItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addItemButton.Location = new Point(600, 75);
            addItemButton.Margin = new Padding(4, 3, 4, 3);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(88, 27);
            addItemButton.TabIndex = 0;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // APIButton
            // 
            APIButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            APIButton.Location = new Point(443, 475);
            APIButton.Margin = new Padding(4, 3, 4, 3);
            APIButton.Name = "APIButton";
            APIButton.Size = new Size(109, 27);
            APIButton.TabIndex = 16;
            APIButton.Text = "Update From HQ";
            APIButton.UseVisualStyleBackColor = true;
            APIButton.Click += APIButton_Click;
            // 
            // StoreSystem2024
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 543);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(781, 582);
            Name = "StoreSystem2024";
            ShowIcon = false;
            Text = "StoreSystem";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addItemCountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)addItemPriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteItemNumericUpdown).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown addItemCountNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown addItemPriceNumericUpDown;
        private ComboBox addItemTypeComboBox;
        private Button orderMoreButton;
        private Button APIButton;
    }
}
