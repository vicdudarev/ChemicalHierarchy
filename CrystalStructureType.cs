using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalHierarchy
{
    /// <summary>
    /// описание кристаллической структуры
    /// </summary>
    public class ChemicalCrystalStructure : ChemicalModification
    {
        /// <summary>
        /// пространственная группа
        /// </summary>
        public string SpaceGroup { get; }

        /// <summary>
        /// Число формульных единиц в элементарной ячейки (осмысленное значение всегда строго больше нуля)
        /// </summary>
        public double NumberOfFormulaUnits { get; }

        public ChemicalCrystalStructure(ChemicalModification modification, string spaceGroup,
            double numberOfFormulaUnits) : base(modification)
        {

        }


        public override string ToString()
        {
            return base.ToString() + " SpaceGroup: " + SpaceGroup + (NumberOfFormulaUnits>0 ? " NumberOfFormulaUnits: " + NumberOfFormulaUnits : "");
        }
    }

}
