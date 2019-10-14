using System;


namespace RuntimeCheck
{
    public static class Assert
    {
        public static void True(bool condition, string message, params object[] args)
        {
            if (!condition)
            {
                throw ExceptionHelper.CreateException<ViolatedAssertionException>(message, args);
            }
        }

        public static void True<T>(bool condition, string message, params object[] args) where T:Exception
        {
            if(!condition)
            {
                throw ExceptionHelper.CreateException<T>(message, args);
            }
        }

    }


}
