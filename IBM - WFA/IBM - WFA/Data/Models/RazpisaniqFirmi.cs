using System;
using System.Collections.Generic;

namespace IBM___WFA.Data.Models;

public partial class RazpisaniqFirmi
{
    public int IdMarshrut { get; set; }

    public int IdFirma { get; set; }

    public virtual Firmi IdFirmaNavigation { get; set; } = null!;

    public virtual Razpisaniq IdMarshrutNavigation { get; set; } = null!;
}
