using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace WindowResizer
{
    public partial class Form1 : Form
    {
        private readonly WindowService windowService = new WindowService();
        private readonly BehaviorSubject<Window?> selectedWindow = new BehaviorSubject<Window?>(null);
        private readonly BehaviorSubject<string> filter = new BehaviorSubject<string>(string.Empty);
        private readonly List<IDisposable> subscription = new List<IDisposable>();

        public Form1()
        {
            InitializeComponent();

            var w = windowService.Windows.CombineLatest(filter, (_windows, _filter) =>
            {
                if (_filter == string.Empty)
                {
                    return _windows;
                }
                return _windows.Where(w => w.Text.ToLower().Contains(_filter.ToLower())).ToArray();
            });

            subscription.Add(w.Subscribe(value =>
            {
                listBoxWindows.Items.Clear();
                listBoxWindows.Items.AddRange(value);
                if (value.Length >= 1)
                {
                    listBoxWindows.SelectedIndex = 0;
                }
            }));

            subscription.Add(selectedWindow.Subscribe(value =>
            {
                if (value == null)
                {
                    return;
                }
                numericUpDownX.Value = value.X;
                numericUpDownY.Value = value.Y;
                numericUpDownWidth.Value = value.Width;
                numericUpDownHeight.Value = value.Height;
            }));
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            selectedWindow.Value?.Move(Decimal.ToInt32(numericUpDownX.Value), Decimal.ToInt32(numericUpDownY.Value));
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            selectedWindow.Value?.Resize(Decimal.ToInt32(numericUpDownWidth.Value), Decimal.ToInt32(numericUpDownHeight.Value));
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            windowService.Refresh();
        }

        private void move00ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedWindow.Value == null)
            {
                return;
            }
            selectedWindow.Value.Move(0, 0);
            selectedWindow.OnNext(selectedWindow.Value);
        }

        private void move88ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedWindow.Value == null)
            {
                return;
            }
            selectedWindow.Value.Move(8, 8);
            selectedWindow.OnNext(selectedWindow.Value);
        }

        private void move1616ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedWindow.Value == null)
            {
                return;
            }
            selectedWindow.Value.Move(16, 16);
            selectedWindow.OnNext(selectedWindow.Value);
        }

        private void resize640x480ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedWindow.Value == null)
            {
                return;
            }
            selectedWindow.Value.Resize(640, 480);
            selectedWindow.OnNext(selectedWindow.Value);
        }

        private void resize1280x720ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedWindow.Value == null)
            {
                return;
            }
            selectedWindow.Value.Resize(1280, 720);
            selectedWindow.OnNext(selectedWindow.Value);
        }

        private void resize1920x1080ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedWindow.Value == null)
            {
                return;
            }
            selectedWindow.Value.Resize(1920, 1080);
            selectedWindow.OnNext(selectedWindow.Value);
        }

        private void resize1920x1200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedWindow.Value == null)
            {
                return;
            }
            selectedWindow.Value.Resize(1920, 1200);
            selectedWindow.OnNext(selectedWindow.Value);
        }

        private void listBoxWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBoxWindows.SelectedItem as Window;
            selectedWindow.OnNext(selectedItem);
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            filter.OnNext(textBoxFilter.Text);
        }
    }
}
