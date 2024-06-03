namespace Calculator2024 {
    public partial class Calculator2024Form : Form {
        const int MAXNUMLENGTH = 10;

        int[] textnumberinput = new int[MAXNUMLENGTH];
        Int64 inputnumber = 0;
        Int64 storednumber = 0;

        Button lastpressedbutton;
        bool ongoingEquals = false;

        public Calculator2024Form() {
            InitializeComponent();
            lastpressedbutton = ResetButton;
        }
        private void NumberButton_Click(object sender, EventArgs e) {
            Button[] buttonlist = new Button[] {ZeroButton, OneButton, TwoButton, ThreeButton, FourButton, FiveButton, SixButton, SevenButton, EightButton, NineButton}; 
            for (int i = 0; i < buttonlist.Length; i++) {
                if (sender == buttonlist[i]) {
                    if (textnumberinput[MAXNUMLENGTH - 1] == 0) {
                        for (int j = MAXNUMLENGTH - 1; j > 0; j--) {
                            textnumberinput[j] = textnumberinput[j - 1];
                        }
                        textnumberinput[0] = i;
                    } else {
                        MessageBox.Show("Maximum number length reached!");
                    }
                }
            }
            inputnumber = 0;
            for (int i = 0; i < MAXNUMLENGTH; i++) {
                inputnumber += textnumberinput[i] * (Int64)Math.Pow(10, i);
            }
            InputTextBox.Text = inputnumber.ToString();
        }
        private void ClearButton_Click(object sender, EventArgs e) {
            ongoingEquals = false;
            lastpressedbutton = ResetButton;
            for (int i = 0; i < textnumberinput.Length; i++) {
                textnumberinput[i] = 0;
            }
            inputnumber = 0;
            storednumber = 0;
            InputTextBox.Text = "";
            StoredNumberLabel.Text = "";
        }

        private void PlusButton_Click(object sender, EventArgs e) {
            try {
                additionOperation();
                ongoingEquals = false;
                lastpressedbutton = PlusButton;
                StoredNumberLabel.Text += " +";
            } catch {
                MessageBox.Show("Your number was too big/small");
                ClearButton_Click(ResetButton, EventArgs.Empty);
            } 
        }
        private void MinusButton_Click(object sender, EventArgs e) {
            try {
                subtractionOperation();
                ongoingEquals = false;
                lastpressedbutton = MinusButton;
                StoredNumberLabel.Text += " -";
            } catch {
                MessageBox.Show("Your number was too big/small");
                ClearButton_Click(ResetButton, EventArgs.Empty);
            } 
        }
        private void MultButton_Click(object sender, EventArgs e) {
            try {
                multiplicationOperation();
                ongoingEquals = false;
                lastpressedbutton = MultButton;
                StoredNumberLabel.Text += " X";
            } catch {
                MessageBox.Show("Your number was too big/small");
                ClearButton_Click(ResetButton, EventArgs.Empty);
            } 
        }
        private void DivideButton_Click(object sender, EventArgs e) {
            try {
                divisionOperation();
                ongoingEquals = false;
                lastpressedbutton = DivideButton;
                StoredNumberLabel.Text += " /";
            } catch {
                MessageBox.Show("Your number was too big/small");
                ClearButton_Click(ResetButton, EventArgs.Empty);
            } 
        }

        private void EqualsButton_Click(object sender, EventArgs e) {
            ongoingEquals = false;
            try {
                if (lastpressedbutton == PlusButton) {
                    additionOperation();
                } else if (lastpressedbutton == MinusButton) {
                    subtractionOperation();
                } else if (lastpressedbutton == MultButton) {
                    multiplicationOperation();
                } else {
                    divisionOperation();
                }
                ongoingEquals = true;
            } catch {
                MessageBox.Show("Your number was too big/small");
                ClearButton_Click(ResetButton, EventArgs.Empty);
            } 
        }

        private void cleanupOperation() {
            for (int i = 0; i < textnumberinput.Length; i++) {
                textnumberinput[i] = 0;
            }
            InputTextBox.Text = "";
        }
        private void additionOperation() {
            if (ongoingEquals) {
                return;
            }
            checked {
                storednumber += inputnumber;
            }
            StoredNumberLabel.Text = storednumber.ToString();
            cleanupOperation();
        }

        private void subtractionOperation() {
            if (ongoingEquals) {
                return;
            }
            if (lastpressedbutton == ResetButton) {
                storednumber += inputnumber;
            } else {
                checked {
                    storednumber -= inputnumber;
                }
            }                
            StoredNumberLabel.Text = storednumber.ToString();
            cleanupOperation();
        }

        private void multiplicationOperation() {
            if (ongoingEquals) {
                return;
            }
            if (lastpressedbutton == ResetButton) {
                storednumber += inputnumber;
            } else {
                checked {
                    storednumber *= inputnumber;
                }
            }
            StoredNumberLabel.Text = storednumber.ToString();
            cleanupOperation();
        }

        private void divisionOperation() {
            if (ongoingEquals) {
                return;
            }
            if (lastpressedbutton == ResetButton) { 
                storednumber += inputnumber;
            } else {
                if (inputnumber == 0) {
                    ClearButton_Click(ResetButton, EventArgs.Empty);
                    StoredNumberLabel.Text = "DivBy0 Error";
                    return;
                }
                checked {
                    storednumber /= inputnumber;
                }
            }
            StoredNumberLabel.Text = storednumber.ToString();
            cleanupOperation();
        }


    }
}
