using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Mail { get; set; } = null!;

    public int IdRol { get; set; }

    public int? Codigo { get; set; }

    public bool Activo { get; set; }

    public virtual Role IdRolNavigation { get; set; } = null!;
}
