using System;

namespace UserTokenScope
{
    public enum EScope
    {
        Notify = 1,
        Friends = 2,
        Photos = 4,
        Video = 8,
        Files = 16,
        Documents = 32,
    }

    public static class Scope
    {
        public static bool IsScope(this int value, EScope scope)
        {
            int number = (int)scope;

            return (value & number) == number;
        }

        public static int ScopesToInt(EScope[] scopes)
        {
            int result = 0;

            foreach (var scope in scopes)
            {
                result += (int)scope;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EScope[] scopes = { EScope.Notify, EScope.Documents };

            var scope = Scope.ScopesToInt(scopes);

            Console.WriteLine($"{nameof(EScope.Notify)} {scope.IsScope(EScope.Notify)}");
            Console.WriteLine($"{nameof(EScope.Friends)} {scope.IsScope(EScope.Friends)}");
            Console.WriteLine($"{nameof(EScope.Photos)} {scope.IsScope(EScope.Photos)}");
            Console.WriteLine($"{nameof(EScope.Video)} {scope.IsScope(EScope.Video)}");
            Console.WriteLine($"{nameof(EScope.Files)} {scope.IsScope(EScope.Files)}");
            Console.WriteLine($"{nameof(EScope.Documents)} {scope.IsScope(EScope.Documents)}");
        }
    }
}
