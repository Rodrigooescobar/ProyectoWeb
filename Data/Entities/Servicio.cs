using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Servicio
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public bool? Activo { get; set; }
}
