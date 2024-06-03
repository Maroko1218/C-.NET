using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreSystem {
    public partial class StoreSystem : Form {
        private StoreBackend backend;
        private int[] IDlist;
        public StoreSystem() {
            backend = new StoreBackend();
            IDlist = backend.getAllIDs();
            InitializeComponent();
            UpdateListBoxes();
        }

        private void UpdateListBoxes() {
            foreach (int ID in IDlist) {
                StoreListBox.Items.Add(
                    backend.getName(ID)
                );
                inventoryListBox.Items.Add(
                    String.Format("ID: {0,2} Count: {1,2} Price: {2,3} Name: {3}", ID, backend.getCount(ID), backend.getPrice(ID), backend.getName(ID))
                );   
            }
        }

        private void addItemButton_Click(object sender, EventArgs e) {

        }
    }
}
