using System;
using XIV.Global.Log;

namespace XIV.Global.Handler
{
    public static class ExceptionHandler
    {
        private static readonly Logger Log = new Logger(typeof(ExceptionHandler));
        public static void HandleException(Exception exc)
        {
            //For now, just log it.
            Log.Fatal(exc.Message + Environment.NewLine + exc.StackTrace);
        }
    }
}
