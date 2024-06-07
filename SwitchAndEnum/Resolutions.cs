using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndEnum
{
    internal enum Resolutions
    {
        SD = 720,
        HD = 1920,
        UHD = 3840
        // the values are implicitly assigned to 0, 1, 2,
        // but can be explicitly assigned like this for example:
        // SD = 720x480,
        // HD = 1920x1080,
        // UHD = 3840x2160
    }
}
