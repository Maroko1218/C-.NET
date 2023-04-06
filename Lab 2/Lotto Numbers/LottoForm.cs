namespace Lotto_Numbers {

    class DuplicateError : Exception {
        public DuplicateError() { }
    }
    public partial class LottoForm : Form {
        public LottoForm() {
            InitializeComponent();
        }

        private void PullCountButton_Click(object sender, EventArgs e) {
            int[] lottonumbers = new int[7];
            int[] simulatedlottonumbers = new int[7];
            int simulations = 0;
            int fives = 0;
            int sixes = 0;
            int sevens = 0;


            Random r = new Random();
            TextBox[] textfields = new TextBox[] {LottoNumber1TextBox, LottoNumber2TextBox, LottoNumber3TextBox, LottoNumber4TextBox, LottoNumber5TextBox, LottoNumber6TextBox, LottoNumber7TextBox,};

            for (int i = 0; i < lottonumbers.Length; i++) {
                try {
                    lottonumbers[i] = int.Parse(textfields[i].Text);
                    for (int j = 0; j < i; j++) {
                        if (lottonumbers[j] == lottonumbers[i]) {
                            throw new DuplicateError();
                        }
                    }
                    if (lottonumbers[i] <= 0 || lottonumbers[i] > 35) {
                        throw new IndexOutOfRangeException();
                    }
                } catch (DuplicateError z) {
                    MessageBox.Show("You can't have duplicate numbers");
                    textfields[i].Focus();
                    break;
                } catch (IndexOutOfRangeException z) {
                    MessageBox.Show("The number has to be between 1 and 35");
                    textfields[i].Focus();
                    break;
                }  catch {
                    MessageBox.Show("Please enter a valid number");
                    textfields[i].Focus();
                    break;
                }
            }
            try {
                simulations = int.Parse(PullCountTextBox.Text);
            } catch {
                MessageBox.Show("Please enter a valid number");
                PullCountTextBox.Focus();
            }
            for (int simulation = 0; simulation < simulations; simulation++) {
                for (int i = 0; i < simulatedlottonumbers.Length; i++) {
                    simulatedlottonumbers[i] = r.Next(1, 36);
                    bool duplicates;
                    do {
                        duplicates = false;
                        for (int j = 0; j < i; j++) {
                            if (simulatedlottonumbers[i] == simulatedlottonumbers[j]) {
                                duplicates = true; break;
                            }
                        }
                        if (duplicates) {
                            simulatedlottonumbers[i] = r.Next(1,36);
                        }
                    } while (duplicates);
                }
                int counter = 0;
                foreach (int predictnum in lottonumbers) {
                    foreach (int simulatednum in simulatedlottonumbers) {
                        if (predictnum == simulatednum) {
                            counter++;
                            break;
                        }
                    }
                }
                if (counter == 7) {
                    sevens++;
                } else if (counter == 6) {
                    sixes++;
                } else if (counter == 5) {
                    fives++;
                }
            }
            SevenRightCountLabel.Text = sevens.ToString();
            SixRightCountLabel.Text = sixes.ToString();
            FiveRightCountLabel.Text = fives.ToString();
        }
    }
}