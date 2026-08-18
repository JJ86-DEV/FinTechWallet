using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FintechWallet.Infrastructure.Persistence;
//hereda de DbContext, que es la clase base para trabajar con Entity Framework Core
//y representa una sesión con la base de datos.
public class ApplicationDbContext : DbContext 
{
    //confifuración de la base de datos, como la cadena de conexión y otras opciones.
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    //Busca en este proyecto todas las clases que implementen IEntityTypeConfiguration<T> y aplicalas.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(ApplicationDbContext).Assembly);
    }
}
