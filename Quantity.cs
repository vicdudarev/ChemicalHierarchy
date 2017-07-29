using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalHierarchy
{
    /// <summary>
    /// количественное содержание элемента в веществе (растворе, смеси)
    /// может задаваться в диапазоне [Min, Max]
    /// </summary>
    public class Quantity
    {
        /// <summary>
        /// минимальное содержание элемента в веществе
        /// </summary>
        public double Min { get; }
        /// <summary>
        /// максимальное содержание элемента в веществе
        /// </summary>
        public double Max { get; }

        public Quantity(double min, double max) {
            if (min > max || min<=0) throw new ApplicationException("min > max || min <= 0");
            Min = min;
            Max = max;
        }
        public Quantity(int quantity)
        {
            if (quantity <= 0) throw new ApplicationException("quantity <= 0");
            Min = Max = quantity;
        }


        public string ToHtmlString
        {
            get
            {
                return Min == Max
                    ? (Max == 1 ? "" : "<sub>" + Max + "</sub>")
                    : "<sub>" + Min + "-" + Max + "</sub>";
            }
        }

        public override string ToString()
        {
            return Min == Max
                ? Max.ToString()
                : Min.ToString() + "-" + Max.ToString();
        }
    }
}
