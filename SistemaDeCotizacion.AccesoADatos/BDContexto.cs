﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entity
using Microsoft.EntityFrameworkCore;
using SistemaDeCotizacion.EntidadesDeNegocio;

namespace SistemaDeCotizacion.AccesoADatos
{
    public class BDContexto: DbContext
    {
       public DbSet<Rol> Rol { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string conexion pc
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-URUNQ5U\SQLEXPRESS;Initial Catalog=CotizacionBD;Integrated Security=True");

            // string conexion pc remota azure
            //optionsBuilder.UseSqlServer(@"Data Source=Windows2016\SQLEXPRESS;Initial Catalog=CotizacionBD;Integrated Security=True");
        }
    }
}
