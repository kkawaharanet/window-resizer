using System.Runtime.InteropServices;
using System.Text;

namespace WindowResizer
{
    public class Window
    {
        public IntPtr Handle { get; }
        public string Text { get; }

        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private static readonly IntPtr HWND_TOP = IntPtr.Zero;
        private static readonly uint SWP_NOSIZE = 0x0001;
        private static readonly uint SWP_NOMOVE = 0x0002;
        private static readonly uint SWP_NOZORDER = 0x0004;
        private static readonly uint SWP_SHOWWINDOW = 0x0040;

        public Window(IntPtr handle, string text)
        {
            Handle = handle;
            Text = text;
        }

        public Window Resize(int width, int height)
        {
            SetWindowPos(Handle, HWND_TOP, 0, 0, width, height, SWP_NOMOVE | SWP_NOZORDER | SWP_SHOWWINDOW);
            return this;
        }

        public Window Move(int x, int y)
        {
            SetWindowPos(Handle, HWND_TOP, x, y, 0, 0, SWP_NOSIZE | SWP_NOZORDER | SWP_SHOWWINDOW);
            return this;
        }

        public int X
        {
            get
            {
                GetWindowRect(Handle, out RECT rect);
                return rect.Left;
            }
        }

        public int Y
        {
            get
            {
                GetWindowRect(Handle, out RECT rect);
                return rect.Top;
            }
        }

        public int Width
        {
            get
            {
                GetWindowRect(Handle, out RECT rect);
                return rect.Right - rect.Left;
            }
        }

        public int Height
        {
            get
            {
                GetWindowRect(Handle, out RECT rect);
                return rect.Bottom - rect.Top;
            }
        }

        public static Window[] GetWindows()
        {
            var windows = new List<Window>();

            EnumWindows((hWnd, lParam) =>
            {
                if (IsWindowVisible(hWnd))
                {
                    int length = GetWindowTextLength(hWnd);
                    var sb = new StringBuilder(length + 1);
                    GetWindowText(hWnd, sb, sb.Capacity);
                    windows.Add(new Window(hWnd, sb.ToString()));
                }
                return true;
            }, IntPtr.Zero);

            return windows.ToArray();
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
