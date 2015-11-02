using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ShanbayWordListToolKit
{
    class NativeMethods
    {
        //导入系统dll文件
        [DllImport("user32")]
        private static extern bool GetCaretPos(out Point lpPoint);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr GetFocus();
        [DllImport("user32.dll")]
        private static extern IntPtr AttachThreadInput(int idAttach, int idAttachTo, int fAttach);
        [DllImport("user32.dll")]
        private static extern int GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        [DllImport("kernel32.dll")]
        private static extern int GetCurrentThreadId();
        [DllImport("user32.dll")]
        private static extern int ClientToScreen(IntPtr hWnd, ref Point p);

        //获取光标位于屏幕的位置
        public Point CaretPos()
        {
            IntPtr ptr = GetForegroundWindow();
            Point p = new Point();

            //得到Caret在屏幕上的位置   
            if (ptr.ToInt32() != 0)
            {
                int targetThreadID = GetWindowThreadProcessId(ptr, IntPtr.Zero);
                int localThreadID = GetCurrentThreadId();

                if (localThreadID != targetThreadID)
                {
                    AttachThreadInput(localThreadID, targetThreadID, 1);
                    ptr = GetFocus();
                    if (ptr.ToInt32() != 0)
                    {
                        GetCaretPos(out   p);
                        ClientToScreen(ptr, ref   p);
                    }
                    AttachThreadInput(localThreadID, targetThreadID, 0);
                }
            }
            return p;
        }
    }
}
