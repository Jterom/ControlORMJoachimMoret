using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoachimControlORM.ORM
{
    public class lienJeuClient
    {
        [Key]
        public int IdLienJeuClient { get; set; }

        public virtual Jeu Jeus { get; set; }
        
        public virtual Client Clients { get; set; }

        public bool Echange { get; set; }

        public bool Aquisition { get; set; }


    }
}
