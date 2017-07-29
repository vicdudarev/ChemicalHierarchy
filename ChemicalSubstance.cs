using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalHierarchy
{
    /// <summary>
    /// химическое вещество (раствор, гетерогенная смесь)
    /// </summary>
    public class ChemicalSubstance : ChemicalSystem
    {
        /// <summary>
        /// формула вещества (это перечисление элементов через тире с указанием количественного состава, например, LiNbO<sub>3</sub>)
        /// </summary>
        public string SubstanceName {
            get {
                string st = "";
                for (int i = 0; i < Elements.Length; i++)
                    st += Elements[i] + Quantities[i].ToString();
                return st;
            }
        }

        /// <summary>
        /// формула вещества в HTML
        /// </summary>
        public string SubstanceNameHtml
        {
            get
            {
                string st = "";
                for (int i = 0; i < Elements.Length; i++)
                    st += Elements[i] + Quantities[i].ToHtmlString;
                return st;
            }
        }

        /// <summary>
        /// массив количественного содержания химических элементов из унаследованного массива ChemicalElement[] Elements (Внимание! Размеры массивов должны совпадать)
        /// </summary>
        public Quantity[] Quantities { get; }

        /// <summary>
        /// конструктор вещества
        /// </summary>
        /// <param name="system">химическая система</param>
        /// <param name="q">количественное описание</param>
        public ChemicalSubstance(ChemicalSystem system, Quantity[] q) : base(system.Elements)
        {
            if (system.Elements.Length!=q.Length)
                throw new ApplicationException("Несовпадение размеров массивов качественного и количественного описания");
            Quantities = q;
        }

        /// <summary>
        /// конструктор копирования вещества
        /// </summary>
        /// <param name="substance">химическое вещество</param>
        public ChemicalSubstance(ChemicalSubstance substance) : base(substance.Elements)
        {
            Quantities = substance.Quantities;
        }

        public override string ToString()
        {
            return SubstanceName;
        }
    }
}
