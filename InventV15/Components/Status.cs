using System;
using System.Collections.Generic;

namespace InventV15.Components;

public partial class Status
{
    public int Statusid { get; set; }

    public string Statusname { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
