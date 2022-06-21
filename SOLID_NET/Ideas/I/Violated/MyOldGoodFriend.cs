namespace SOLID_NET.Ideas.I.Violated
{
    interface IPhone
    {
        void Call();

        void UserInstagram();
    }

    // violation ISP.
    // Because class implements interface which whereis not all functionality is required in this class.
    // i.e. method TakePhoto
    internal class OldMobilePhone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        public void UserInstagram()
        {
            // violates also LSP
            throw new NotImplementedException("I am an old phone which can not take a photo");
        }
    }

    internal class SmartPhone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        public void UserInstagram()
        {
            Console.WriteLine("Taking a photo...");
        }
    }

    class MyOldGoodFriend
    {
        public void Call(IPhone phone)
        {
            phone.Call();
        }
    }
}
