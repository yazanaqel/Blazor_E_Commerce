﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blazor_E_Commerce.Shared;
public class Edition
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
