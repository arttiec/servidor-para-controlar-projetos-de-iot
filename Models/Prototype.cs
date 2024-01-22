using System;
using System.Collections.Generic;

namespace PrototypeControlStem.Models;

public partial class Prototype
{
    public string CodPrototype { get; set; } = null!;

    public string NamePrototype { get; set; } = null!;

    public string LocalPrototype { get; set; } = null!;

    public DateTime LastConnectionPrototype { get; set; }

    public bool StatusPrototype { get; set; }
}
