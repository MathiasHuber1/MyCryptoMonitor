using System;
using System.Threading.Tasks;

namespace MyCryptoMonitor.Statics
{
    public static class TimeoutTask
    {
        public static async Task<T> DelayTaskGenAsync<T>(Task<T> task, int timeout, T defaultValue = default(T))
        {
            try
            {
                var firstTask = await Task.WhenAny(task, Task.Delay(timeout)).ConfigureAwait(false);
                if (firstTask == task)
                {
                    return task.Result;
                }
                else
                {
                    return defaultValue;
                }
            }
            catch (Exception ex)
            {
                return defaultValue;
            }
        }
    }
}