using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Producto
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal? Precio { get; set; }

    public int Stock { get; set; }

    public string? Imagen { get; set; }

    public bool? Activo { get; set; }
}
