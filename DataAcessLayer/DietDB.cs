using DataAcessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection;
using System.Text;

namespace Common
{
    class DietDB : DbContext
    {
        public DietDB() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\DietDB.mdf;Integrated Security=True;Connect Timeout=30")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Criação de uma CONFIGURAÇÃO que diz que a partir de agora
            //o EF mapeará strings utilizando NOT NULL e VARCHAR.
            modelBuilder.Properties().Where(c => c.PropertyType == typeof(string)).Configure(c => c.IsRequired().IsUnicode(false));

            modelBuilder.Properties().Where(c => c.PropertyType == typeof(string)).Configure(c => c.HasColumnType("DATETIME2"));

            //Adiciona todas as configurações existentes no projeto DAL
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

            //Adiciona todas as convenções existentes no projeto DAL
            modelBuilder.Conventions.AddFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Food> Foods { get; set; }
        public DbSet<User> Users { get; set; }
    }

    class CPFConvention : Convention
    {
        public CPFConvention()
        {
            this.Properties().Where(C => C.PropertyType == typeof(string) && C.Name == "CPF").Configure(c => c.IsFixedLength().HasMaxLength(11));
        }
    }

}