﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCMiniAgenda.Models
{
    public class AgendaContext : DbContext
    {
        public DbSet<Usuarios> LosUsuarios { get; set; }
    }
}