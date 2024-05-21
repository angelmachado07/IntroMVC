﻿using System;
using System.Collections.Generic;

namespace ProyectoIntroMVC.Models;

public partial class Role
{
    public int RolId { get; set; }

    public string? RolDescripcion { get; set; }

    public string RolStatus { get; set; } = null!;

    public virtual ICollection<Personaje> Personajes { get; set; } = new List<Personaje>();
}
