using System.Reactive.Subjects;
using System.Text;

namespace WindowResizer
{
    public class WindowService
    {
        private readonly BehaviorSubject<Window[]> windows;

        public BehaviorSubject<Window[]> Windows { get { return windows; } }

        public WindowService()
        {
            windows = new BehaviorSubject<Window[]>(GetWindows());
        }

        public void Refresh()
        {
            windows.OnNext(GetWindows());
        }

        private Window[] GetWindows()
        {
            var windows = new List<Window>();

            Win32.EnumWindows((hWnd, lParam) =>
            {
                if (Win32.IsWindowVisible(hWnd))
                {
                    int length = Win32.GetWindowTextLength(hWnd);
                    var sb = new StringBuilder(length + 1);
                    Win32.GetWindowText(hWnd, sb, sb.Capacity);
                    windows.Add(new Window(hWnd, sb.ToString()));
                }
                return true;
            }, IntPtr.Zero);

            return [.. windows];
        }
    }
}
