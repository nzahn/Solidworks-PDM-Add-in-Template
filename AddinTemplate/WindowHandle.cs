using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AddinTemplate
{
    //Wrapper class to use SOLIDWORKS PDM Professional as the parent window
    class WindowHandle : IWin32Window
    {
        private IntPtr mHwnd;

        public WindowHandle(int hWnd)
        {
            mHwnd = new IntPtr(hWnd);
        }
        public IntPtr Handle
        {
            get { return mHwnd; }
        }
    }
}
