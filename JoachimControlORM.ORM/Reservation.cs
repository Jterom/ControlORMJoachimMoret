using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoachimControlORM.ORM
{
    public class Reservation
    {
        [Key]
        public int IdResevation { get; set; }

        public DateTime DateDeReservation { get; set; }

        public virtual Client Clients { get; set; }

        public virtual Jeu Jeus { get; set; }
    }
}
