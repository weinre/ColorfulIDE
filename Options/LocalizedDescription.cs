﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTeam.ColorfulIDE.Options
{
    class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        public LocalizedDescriptionAttribute(string resourceId)
            : base(GetMessageFromResource(resourceId))
        { }

        private static string GetMessageFromResource(string resourceId)
        {
            // TODO: Return the string from the resource file
            return Properties.Resources.ResourceManager.GetString(resourceId);
        }
    }
}
