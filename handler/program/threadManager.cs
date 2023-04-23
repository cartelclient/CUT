using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace CUT.handler.program
{
    internal class threadManager
    {
        /// <param name="function">Function you want to run in a new thread. Make sure not to add () after the function name</param>
        public static void createThread(Action function)
        {
            Thread thread = new Thread(new ThreadStart(function));
            thread.Start();
        }


        /// <param name="function">Function you want to run in a task. Make sure not to add () after the function name</param>
        public static void createTask(Action function)
        {
            Task.Factory.StartNew(() => function());
        }
    }
}
