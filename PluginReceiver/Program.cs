using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PluginReceiver
{
    class Program
    {
        static Thread PipeListenerThread;
        static Thread TimeoutThread;
        static bool DebugMode = false;
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                DebugMode = true;
            }
            PipeListenerThread = new Thread(PipeListener);
            TimeoutThread = new Thread(Timeout);
            PipeListenerThread.IsBackground = true;
            TimeoutThread.IsBackground = true;
            PipeListenerThread.Start();
            TimeoutThread.Start();
            TimeoutThread.Join();
            if (DebugMode == true)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void PipeListener()
        {
            try
            {
                NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "NowPlayingTunes", PipeDirection.InOut, PipeOptions.None);
                StreamString ss = new StreamString(pipeClient);
                pipeClient.Connect();
                String rettext = ss.ReadString();
                Console.WriteLine(rettext);
                pipeClient.Close();
                pipeClient.Dispose();
            }
            catch (Exception ex)
            {

            }
            if (DebugMode == false)
            {
                if (TimeoutThread.IsAlive == true)
                {
                    TimeoutThread.Abort();
                }
            }
        }

        static void Timeout()
        {
            Thread.Sleep(1000);
            if (PipeListenerThread.IsAlive == true)
            {
                PipeListenerThread.Abort();
            }
        }
    }
}
