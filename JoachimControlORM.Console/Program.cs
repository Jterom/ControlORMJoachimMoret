using System;
using JoachimControlORM.ORM;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JoachimControlORM.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContextBDD())
            {
                var r1 = from c in db.Jeus
                         join o in db.LienJeuClients on c.IdJeu equals o.IdLienJeuClient
                         join u in db.Clients on o.IdLienJeuClient equals u.IdClient
                         where o.Aquisition = 1
                         select c;
            }
        }
    }
}

