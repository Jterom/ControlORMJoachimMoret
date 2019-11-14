using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoachimControlORM.ORM
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Mdp { get; set; }

        [Required]
        [StringLength(50)]
        public string Identifiant { get; set; }

        public virtual ICollection<Jeu> Jeus { get; set; }


    }
}
