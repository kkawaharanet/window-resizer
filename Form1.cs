using System.Runtime.InteropServices;
using System.Text;

namespace WindowResizer
{
    public partial class Form1 : Form
    {
        private Window[] windows = Window.GetWindows();

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(windows);
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            var window = windows.FirstOrDefault(w => w.Text == comboBox1.SelectedItem?.ToString());
            window?.Move(Decimal.ToInt32(numericUpDownX.Value), Decimal.ToInt32(numericUpDownY.Value));
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            var window = windows.FirstOrDefault(w => w.Text == comboBox1.SelectedItem?.ToString());
            window?.Resize(Decimal.ToInt32(numericUpDownWidth.Value), Decimal.ToInt32(numericUpDownHeight.Value));
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            windows = Window.GetWindows();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownX.Value = (comboBox1.SelectedItem as Window)?.X ?? 0;
            numericUpDownY.Value = (comboBox1.SelectedItem as Window)?.Y ?? 0;
            numericUpDownWidth.Value = (comboBox1.SelectedItem as Window)?.Width ?? 0;
            numericUpDownHeight.Value = (comboBox1.SelectedItem as Window)?.Height ?? 0;
        }
    }
}
