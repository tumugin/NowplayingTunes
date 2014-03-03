using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PluginReciver
{
    class Program
    {
        static Thread PipeListenerThread;
        static Thread TimeoutThread;

        static void Main(string[] args)
        {
            PipeListenerThread = new Thread(PipeListener);
            TimeoutThread = new Thread(Timeout);
            PipeListenerThread.IsBackground = true;
            TimeoutThread.IsBackground = true;
            PipeListenerThread.Start();
            TimeoutThread.Start();
            TimeoutThread.Join();
            if (args.Length == 0)
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
