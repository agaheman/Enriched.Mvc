﻿using System;
using System.Collections.Generic;

namespace Enriched.MvcUtilities
{
    internal class ControllerActionInfo
    {
        internal string AreaName { get; set; }
        internal string Namespace { get; set; }
        internal string ControllerName { get; set; }
        internal string ActionName { get; set; }
        internal Type ActionReturnType { get; set; }
        internal ICollection<Attribute> ActionAttributes { get; set; }
        internal ICollection<Attribute> ControllerAttributes { get; set; }
    }
}