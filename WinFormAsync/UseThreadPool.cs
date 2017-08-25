using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormAsync
{
    public static class UseThreadPool
    {
        public class State
        {
            public EventWaitHandle eventWaitHandle = new ManualResetEvent(false);
            public long result;
            public object[] parameters;
            public Func<int, long> fun;
        }

        private static void PerformUserWorkItem(Object stateObject)
        {
            State state = stateObject as State;
            if (state != null)
            {
                // do something lengthy with state.parameters...
                state.result = state.fun.Invoke(5000);
                state.eventWaitHandle.Set(); // signal we're done
            }

        }

        public static State DoWorkSynchronous(Func<int, long> fun)
        {
            State state = new State();
            state.fun = fun;
            ThreadPool.QueueUserWorkItem(PerformUserWorkItem, state);

            return state;

        }
    }
}
