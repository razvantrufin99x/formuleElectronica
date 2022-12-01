using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formuleElectronica
{
   public class OhmLawDC
    {
        public float I(float U, float R)
        {
            return U / R;
        }
        public float U(float I, float R)
        {
            return I * R;
        }
        public float R(float U, float I)
        {
            return U / I;
        }
        public float P(float U, float I)
        {
            return U * I;
        }
        public float W(float P, float t)
        {
            return P * t;
        }

    }
}
