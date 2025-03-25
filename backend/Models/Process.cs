using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Process
{
    public int Id { get; set; }

    public int ChartId { get; set; }

    public string ProcessName { get; set; } = null!;

    public string? Shape { get; set; }

    public decimal? Time { get; set; }

    public decimal? Distance { get; set; }

    public bool? ValueAdded { get; set; }

    public bool? NonValueAdded { get; set; }

    public virtual Chart Chart { get; set; } = null!;
}
