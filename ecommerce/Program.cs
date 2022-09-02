using System;
using ecommerce;

namespace ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario("jango", "batatatinha123");
            // Console.WriteLine($"{u.GetUsername()},{u.GetHash()}");
            // Console.WriteLine(u.Serialize());
            Usuario p = new Usuario("jango2", "batatatinha456");
            Usuario q = new Usuario("jango3", "batatatinha789");
            Usuario r = new Usuario("jango4", "batatatinha321");
            UserBase myBase = new UserBase("userbase.txt");
            myBase.AddUser(p);
            myBase.AddUser(q);
            myBase.AddUser(r);
            myBase.Save();

        }
    }
}
