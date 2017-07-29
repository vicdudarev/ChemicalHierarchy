using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalHierarchy
{

    /// <summary>
    /// химическая модификация (добавляем к ChemicalSubstance тип кристаллической структуры)
    /// </summary>
    public class ChemicalModification : ChemicalSubstance
    {
        /// <summary>
        /// описание кристаллической структуры
        /// </summary>
        public CrystalSystemType CrystalSystem { get; }

        /// <summary>
        /// формула вещества и модификация 
        /// </summary>
        public string ModificationName {
            get {
                return base.ToString() + " " + CrystalSystem;
            }
        }

        /// <summary>
        /// формула вещества и модификация в HTML
        /// </summary>
        public string ModificationNameHtml {
            get {
                return base.SubstanceNameHtml + " " + CrystalSystem;
            }
        }

        /// <summary>
        /// конструктор модификации
        /// </summary>
        /// <param name="substance">вещество</param>
        /// <param name="cs"></param>
        public ChemicalModification(ChemicalSubstance substance, CrystalSystemType cs) : base(substance)
        {
            CrystalSystem = cs;
        }

        /// <summary>
        /// конструктор копирования модификации
        /// </summary>
        /// <param name="modification">химическая модификация</param>
        public ChemicalModification(ChemicalModification modification) : base(modification)
        {
            CrystalSystem = modification.CrystalSystem;
        }

        public override string ToString()
        {
            return ModificationName;
        }
    }
}
