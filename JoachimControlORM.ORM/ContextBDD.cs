﻿using System;
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
    }
}