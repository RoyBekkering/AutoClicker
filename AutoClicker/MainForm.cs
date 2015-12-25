using System;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MainForm : Form    
    {
        KeyListener listener;

        public MainForm() {
            InitializeComponent();
            listener = new KeyListener(this);
        }

        public void DisplayListenerKey(string key) {
            textBox_Keybind.Text = key;
            button_Keybind_Set.Text = "Set";
        }

        private void button_Keybind_Set_Click(object sender, System.EventArgs e) {
            button_Keybind_Set.Text = "Listening...";
            listener.Listen();
        }

        private void numericUpDown_Delay_ValueChanged(object sender, System.EventArgs e) {
            listener.Delay = Convert.ToInt32((sender as NumericUpDown).Value);
        }

        private void numericUpDown_Amount_ValueChanged(object sender, EventArgs e) {
            listener.Amount = Convert.ToInt32((sender as NumericUpDown).Value);
        }

        private void radioButton_Mode_Sequence_CheckedChanged(object sender, EventArgs e) {
            if((sender as RadioButton).Checked) {
                listener.CMode = Clickmode.Sequence;
                label_Amount.Enabled = true;
                numericUpDown_Amount.Enabled = true;

                label_Keymode.Enabled = false;
                tableLayoutPanel_Keymode.Enabled = false;
            }
        }

        private void radioButton_Mode_Continuous_CheckedChanged(object sender, EventArgs e) {
            if((sender as RadioButton).Checked) {
                listener.CMode = Clickmode.Continuous;
                label_Keymode.Enabled = true;
                tableLayoutPanel_Keymode.Enabled = true;

                label_Amount.Enabled = false;
                numericUpDown_Amount.Enabled = false;
            }
        }

        private void radioButton_Keymode_HoldDown_CheckedChanged(object sender, EventArgs e) {
            if((sender as RadioButton).Checked) {
                listener.KMode = Keymode.Hold;
            }
        }

        private void radioButton_Keymode_Toggle_CheckedChanged(object sender, EventArgs e) {
            if((sender as RadioButton).Checked) {
                listener.KMode = Keymode.Toggle;
            }
        }
    }

    
}
