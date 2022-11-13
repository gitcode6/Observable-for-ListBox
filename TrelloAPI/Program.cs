using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manatee.Trello;

namespace TrelloAPI
{
    internal class Program
    {
        static async void Task(string[] args)
        {
            Console.WriteLine("test");

            IMe me = await TaskAsync();
            Console.WriteLine(me.FullName);
            Console.ReadLine();
        }


        



        static async Task<IMe> TaskAsync()
        {
            TrelloAuthorization.Default.UserToken = "386e5c895b33721981b00b1345915b3e4367dae9c13c7550017fb4bc3390afad";

            TrelloAuthorization.Default.AppKey = "70b3c09bd028145e9f6e0f0d6ad1e7e9";

            ITrelloFactory factory = new TrelloFactory();

            var me = await factory.Me();

            return me;

        }
    }
}
