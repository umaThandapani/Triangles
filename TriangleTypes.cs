using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class TriangleTypes
    {
        public string DoAnotherThing(int side1, int side2, int side3)
        {
            string result = "";
            if (side1 == side2 && side2 == side3)
                result = "Equilateral";
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                result = "Isosceles";
            else
                result = "Scalene";
            return result;
        }

        
    }
}
