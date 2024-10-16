using System;
using System.Collections.Generic;

namespace CASO3SinScaffolding21100534.Core.Entities;

public partial class JobOffer
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public double? Salary { get; set; }

    public string? Location { get; set; }
}
