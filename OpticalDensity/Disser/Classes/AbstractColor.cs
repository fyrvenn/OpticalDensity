using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disser.Classes
{
    abstract public class AbstractColor
    {
        abstract public Lab ToLab();
        abstract public RGB ToRGB();
        abstract public XYZ ToXYZ();
    }
}

