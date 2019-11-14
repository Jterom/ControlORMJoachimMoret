using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoachimControlORM.ORM
{
    public class ContextBDD : DbContext
    {
        public ContextBDD()
            : base("ChaineDeConnexion")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Jeu> Jeus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<lienJeuClient> LienJeuClients { get; set; }

    }
}
