namespace SOLID_NET.Ideas.I.Fixed
{
    interface ICaller
    {
        void Call();
    }

    interface IInstagrammer
    {
        void UserInstagram();
    }

    internal class OldMobilePhone : ICaller
    {
        public void Call()
        {
            Console.WriteLine("Calling...");
        }
    }

    internal class SmartPhone : ICaller, IInstagrammer
    {
        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        public void UserInstagram()
        {
            Console.WriteLine("Sharing my new story...");
        }
    }

    class MyOldGoodFriend
    {
        public void Call(ICaller caller)
        {
            caller.Call();
        }
    }
}
