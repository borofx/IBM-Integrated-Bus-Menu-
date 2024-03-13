using System;
using System.Collections.Generic;

namespace IBM___WFA.Data.Models;

public partial class Razpisaniq
{
    public int IdMarshrut { get; set; }

    public string ZaminavaOt { get; set; } = null!;

    public string PristigaV { get; set; } = null!;

    public TimeOnly ChasPristigane { get; set; }

    public TimeOnly ChasZaminavane { get; set; }
}
