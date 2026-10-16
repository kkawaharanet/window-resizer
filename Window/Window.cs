using System.Runtime.InteropServices;

namespace WindowResizer
{
    public class Window
    {
        public IntPtr Handle { get; }
        public string Text { get; }
        private int x;
        private int y;
        private int width;
        private int height;

        public Window(IntPtr handle, string text)
        {
            Handle = handle;
            Text = text;

            RefreshRect();
        }

        public Window Resize(int width, int height)
        {
            // クライアント領域を指定サイズにする。
            // 独自にタイトルバーや枠を描画するウィンドウ(Chromeなど)にも対応するため、
            // AdjustWindowRectExではなくウィンドウとクライアント領域の差を実測する
            Win32.GetWindowRect(Handle, out Win32.RECT win);
            Win32.GetClientRect(Handle, out Win32.RECT client);
            int extraW = (win.Right - win.Left) - client.Right;
            int extraH = (win.Bottom - win.Top) - client.Bottom;

            int newW = width + extraW;
            int newH = height + extraH;
            Win32.SetWindowPos(Handle, Win32.HWND_TOP, 0, 0, newW, newH, Win32.SWP_NOMOVE | Win32.SWP_NOZORDER | Win32.SWP_SHOWWINDOW);

            // リサイズ後にクライアント領域を測り直し、ずれがあれば補正する
            Win32.GetClientRect(Handle, out client);
            int diffW = width - client.Right;
            int diffH = height - client.Bottom;
            if (diffW != 0 || diffH != 0)
            {
                Win32.SetWindowPos(Handle, Win32.HWND_TOP, 0, 0, newW + diffW, newH + diffH, Win32.SWP_NOMOVE | Win32.SWP_NOZORDER | Win32.SWP_SHOWWINDOW);
            }
            return RefreshRect();
        }

        public Window Move(int x, int y)
        {
            // DWMの拡張フレームによるオフセットを求める
            Win32.DwmGetWindowAttribute(Handle, Win32.DWMWA_EXTENDED_FRAME_BOUNDS, out Win32.RECT frame, Marshal.SizeOf<Win32.RECT>());
            Win32.GetWindowRect(Handle, out Win32.RECT win);
            int offsetX = frame.Left - win.Left;
            int offsetY = frame.Top - win.Top;

            Win32.SetWindowPos(Handle, Win32.HWND_TOP, x - offsetX, y - offsetY, 0, 0, Win32.SWP_NOSIZE | Win32.SWP_NOZORDER | Win32.SWP_SHOWWINDOW);
            return RefreshRect();
        }

        public Window RefreshRect()
        {
            // 位置は見えている枠(DWMの拡張フレーム)の左上、サイズはResizeと同じくクライアント領域
            Win32.DwmGetWindowAttribute(Handle, Win32.DWMWA_EXTENDED_FRAME_BOUNDS, out Win32.RECT frame, Marshal.SizeOf<Win32.RECT>());
            Win32.GetClientRect(Handle, out Win32.RECT client);
            x = frame.Left;
            y = frame.Top;
            width = client.Right;
            height = client.Bottom;
            return this;
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Text))
            {
                return $"[{Handle}]No name";
            }
            return $"[{Handle}]{Text}";
        }
    }
}
