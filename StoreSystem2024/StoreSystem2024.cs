using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace StoreSystem2024 {
    public partial class StoreSystem2024 : Form {
        static readonly HttpClient client = new HttpClient();
        private StoreBackend backend;
        private int[] IDlist;
        private Dictionary<int, int> cart;
        public StoreSystem2024() {
            backend = new StoreBackend();
            IDlist = backend.getAllIDs();
            cart = new Dictionary<int, int>();
            InitializeComponent();
            UpdateListBoxes();
            addItemTypeComboBox.SelectedIndex = 0;
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            backend.gracefulExit();
            base.OnFormClosing(e);
        }

        private void UpdateListBoxes() {
            IDlist = backend.getAllIDs();
            StoreListBox.Items.Clear();
            inventoryListBox.Items.Clear();
            foreach (int ID in IDlist) {
                StoreListBox.Items.Add(
                    String.Format("Count: {0,2} {1}", backend.getCount(ID), backend.getName(ID))
                );
                inventoryListBox.Items.Add(
                    String.Format("ID: {0,2} Count: {1,2} Price: {2,3} Name: {3}", ID, backend.getCount(ID), backend.getPrice(ID), backend.getName(ID))
                );
            }
        }

        private void addItemButton_Click(object sender, EventArgs e) {
            string buffer = "";
            if (addItemNameTextBox.Text == "") {
                MessageBox.Show("Please give the product a name");
                addItemNameTextBox.Focus();
                return;
            } else if (addItemPriceNumericUpDown.Value <= 0) {
                MessageBox.Show("Please enter a valid price");
                addItemPriceNumericUpDown.Focus();
                return;
            } else if (addItemCountNumericUpDown.Value <= 0) {
                MessageBox.Show("Please enter a valid count");
                addItemCountNumericUpDown.Focus();
                return;
            }
            switch (addItemTypeComboBox.SelectedIndex) {
                case 0: //Book
                    DialogResult result = InputBox("Adding Book", "Please enter the author's name", ref buffer);
                    if (result != DialogResult.OK) { break; }
                    string author = buffer;
                    if (author == "") { MessageBox.Show("Obligatory field was left empty"); break; }

                    result = InputBox("Adding Book", "Please enter the book's genre", ref buffer);
                    if (result != DialogResult.OK) { break; }
                    string genre = buffer;
                    if (genre == "") { MessageBox.Show("Obligatory field was left empty"); break; }

                    result = InputBox("Adding Book", "Please enter the book's format (Optional, leave blank and press OK to continue)", ref buffer);
                    if (result != DialogResult.OK) { break; }
                    string format = buffer;

                    result = InputBox("Adding Book", "Please enter the book's language (Optional, leave blank and press OK to continue)", ref buffer);
                    if (result != DialogResult.OK) { break; }
                    string language = buffer;

                    Dictionary<string, string> attributes = new Dictionary<string, string> {
                        { "type", "book" },
                        { "author", author },
                        { "genre", genre }
                    };

                    if (format != "") {
                        attributes.Add("format", format);
                    }
                    if (language != "") {
                        attributes.Add("language", language);
                    }
                    backend.addItem(addItemNameTextBox.Text, (int)addItemPriceNumericUpDown.Value, (int)addItemCountNumericUpDown.Value, attributes);
                    break;

                case 1: //Game
                    result = InputBox("Adding Game", "Please enter the game's platform", ref buffer);
                    if (result != DialogResult.OK) { break; }
                    string platform = buffer;
                    if (platform == "") { MessageBox.Show("Obligatory field was left empty"); break; }
                    attributes = new Dictionary<string, string> {
                        { "type", "game" },
                        { "platform", platform }
                    };
                    backend.addItem(addItemNameTextBox.Text, (int)addItemPriceNumericUpDown.Value, (int)addItemCountNumericUpDown.Value, attributes);
                    break;

                case 2: //Movie
                    result = InputBox("Adding Movie", "Please enter the movie's format", ref buffer);
                    if (result != DialogResult.OK) { break; }
                    format = buffer;
                    if (format == "") { MessageBox.Show("Obligatory field was left empty"); break; }

                    result = InputBox("Adding Movie", "Please enter the movie's playtime (Optional, leave blank and press OK to continue)\nOnly enter a number for minutes of playtime.", ref buffer);
                    if (result != DialogResult.OK) { break; }
                    string playtime = buffer;
                    attributes = new Dictionary<string, string> {
                        { "type", "movie" },
                        {"format", format }
                    };
                    if (playtime != "") {
                        try {
                            if (int.Parse(playtime) <= 0) { MessageBox.Show("Invalid playtime"); break; }

                        } catch {
                            MessageBox.Show("Please only enter a number!"); break;
                        }
                        attributes.Add("playtime", playtime + " min");
                    }
                    backend.addItem(addItemNameTextBox.Text, (int)addItemPriceNumericUpDown.Value, (int)addItemCountNumericUpDown.Value, attributes);
                    break;
            }
            UpdateListBoxes();
        }

        public DialogResult InputBox(string title, string promptText, ref string value) { //https://www.makeuseof.com/winforms-input-dialog-box-create-display/
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            form.Text = title;
            label.Text = promptText;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);
            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Controls.AddRange([label, textBox, buttonOk, buttonCancel]);
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            textBox.TextChanged += addItemNameTextBox_TextChanged;
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void addItemNameTextBox_TextChanged(object sender, EventArgs e) {
            var tb = sender as TextBox;
            tb.Text = tb.Text.Replace(",", "");
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            int id = (int)deleteItemNumericUpdown.Value;
            if (backend.getAllIDs().Contains(id)) {
                if (backend.getCount(id) != 0) {
                    DialogResult result = MessageBox.Show("Do you really want to remove this item?", "WARNING!", MessageBoxButtons.YesNo);
                    if (result != DialogResult.Yes) {
                        return;
                    }
                }
                backend.removeItem(id);
                UpdateListBoxes();
                cart.Clear();
                UpdateShoppingCart();
            }
        }

        private void orderMoreButton_Click(object sender, EventArgs e) {
            int id = (int)deleteItemNumericUpdown.Value;
            if (backend.getAllIDs().Contains(id)) {
                string buffer = "";
                DialogResult result = InputBox("Request shipment", "How much of " + backend.getName(id) + " should we order?", ref buffer);
                if (result == DialogResult.OK) {
                    int count = 0;
                    try {
                        count = int.Parse(buffer);
                        if (count <= 0) { throw new Exception(); }
                    } catch {
                        MessageBox.Show("Please enter a valid number!");
                        return;
                    }
                    backend.addCount(id, count);
                    UpdateListBoxes();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e) {
            int id;
            try {
                id = IDlist[StoreListBox.SelectedIndex];
            } catch {
                return;
            }
            try {
                if (cart[id] >= backend.getCount(id)) {
                    MessageBox.Show("Can't add more to cart than we have in stock!");
                    return;
                }
                cart[id]++;
            } catch {
                if (backend.getCount(id) <= 0) {
                    MessageBox.Show("Can't add more to cart than we have in stock!");
                    return;
                }
                cart.Add(id, 1);
            }
            UpdateShoppingCart();
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            int id;
            try {
                id = IDlist[StoreListBox.SelectedIndex];
            } catch {
                return;
            }
            try {
                if (cart[id] <= 1) {
                    cart.Remove(id);
                    UpdateShoppingCart();
                    return;
                }
                cart[id]--;
            } catch {
                //Do nothing
            }
            UpdateShoppingCart();
        }

        private void UpdateShoppingCart() {
            CartListBox.Items.Clear();
            foreach (int id in cart.Keys) {
                CartListBox.Items.Add(
                    String.Format("{0} *{1}", backend.getName(id), cart[id])
                );
            }
        }

        private void PurchaseButton_Click(object sender, EventArgs e) {
            foreach (int id in cart.Keys) {
                backend.addCount(id, cart[id] * -1);
            }
            UpdateListBoxes();
            cart.Clear();
            UpdateShoppingCart();
        }

     

        private async void APIButton_Click(object sender, EventArgs e) {
            cart.Clear();
            UpdateShoppingCart();
            XmlDocument doc = new XmlDocument();
            try {
                string responseBody = await client.GetStringAsync("https://hex.cse.kau.se/~jonavest/csharp-api/");
                if (responseBody.Contains("<error>")) {
                    throw new HttpRequestException("API error");
                }
                doc.LoadXml(responseBody);
            } catch (HttpRequestException ex) {
                MessageBox.Show("Error getting the latest inventory, Please verify your internet connection.\n" + ex.Message);
                return;
            }
            bool first = true;
            foreach (XmlElement elem in doc.FirstChild.ChildNodes) {
                if (first) { first = false; continue; }
                foreach (XmlNode product in elem.ChildNodes) {
                    int id = 0;
                    foreach (XmlElement attribute in product.ChildNodes) {
                        if (attribute.Name == "id" && IDlist.Contains(int.Parse(attribute.InnerText))) {
                            id = int.Parse(attribute.InnerText);
                        }
                        if (attribute.Name == "price" && id != 0) {
                            backend.setPrice(id, int.Parse(attribute.InnerText));
                            
                        }
                        if (attribute.Name == "stock" && id != 0) {
                            backend.addCount(id, int.Parse(attribute.InnerText) - backend.getCount(id));
                            
                        }
                    }
                }
            }
            UpdateListBoxes();
        }
    }
}
