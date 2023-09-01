using System;
using System.Collections.Generic;

namespace InventV15.Components;

public partial class Cabinet
{
    public int Cabinetid { get; set; }

    public string Cabinetname { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
