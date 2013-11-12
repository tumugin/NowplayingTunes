using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace NowplayingTunes.Core
{
    public class Debugger
    {
        public class TextBoxTraceListener : TraceListener
        {
            private TextBox tBox;

            public TextBoxTraceListener(TextBox box)
            {
                this.tBox = box;
            }

            public override void Write(string msg)
            {
                //allows tBox to be updated from different thread
                tBox.Parent.Invoke(new MethodInvoker(delegate()
                {
                    tBox.Text += msg;
                }));
            }

            public override void WriteLine(string msg)
            {
                Write(msg + "\r\n");
            }
        }
    }
}
