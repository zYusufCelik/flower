using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class Chart
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();
}
