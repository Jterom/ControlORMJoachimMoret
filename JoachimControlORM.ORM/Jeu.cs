using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoachimControlORM.ORM
{
    public class Jeu
    {
        [Key]
        public int IdJeu { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom { get; set; }

        [Required]
        [StringLength(50)]
        public string Platforme { get; set; }

        [Required]
        [StringLength(50)]
        public string Statu { get; set; }


    }
}
