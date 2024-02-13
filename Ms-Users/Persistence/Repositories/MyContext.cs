using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;


public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyContext).Assembly);
    }

    //Bloque DbSet
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<Permiso> Permisos { get; set; }
    public DbSet<RolPermiso> RolPermisos { get; set; }
}

//Definiciones que toma encuenta el bloque DbSet
public class Usuario
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Correo { get; set; }
    public required string Contrasena { get; set; }
}

public class Rol
{
    public int Id {get; set;}
    public required string Nombre {get; set;}
    public required string Descripcion {get; set;}
}

public class Permiso
{
    public int Id {get; set;}
    public required string Nombre {get; set;}
    public required string Descripcion {get; set;}
}

public class RolPermiso
{
    public int RolId {get; set;}
      public int PermisoId {get; set;}
      public required Rol Rol {get; set;}
      public required Permiso Permiso {get; set;}
}


//Bloque de configuración de entidad
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Nombre).HasMaxLength(30);
        builder.Property(u => u.Correo).HasMaxLength(25);
        builder.Property(u => u.Contrasena).HasMaxLength(12);
    }
}

public class RolConfiguration : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Nombre).HasMaxLength(20);
        builder.Property(r => r.Descripcion).HasMaxLength(30);
    }
}
public class Configuracion : IEntityTypeConfiguration<Permiso>
{
    public void Configure(EntityTypeBuilder<Permiso> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p=>p.Nombre).HasMaxLength(20);
        builder.Property(p => p.Descripcion).HasMaxLength(30);
    }
}




