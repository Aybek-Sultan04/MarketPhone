﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.States;

public enum Condition:byte
{
    New = 1,
    Used,
    Invalid
}
