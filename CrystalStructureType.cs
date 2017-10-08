using System;

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
            if (string.IsNullOrEmpty(spaceGroup))
                throw new ApplicationException("ChemicalCrystalStructure: spaceGroup is empty");
            if (numberOfFormulaUnits <= 0)
                throw new ApplicationException("ChemicalCrystalStructure: numberOfFormulaUnits<=0");
            SpaceGroup = spaceGroup;
            NumberOfFormulaUnits = numberOfFormulaUnits;
        }


        public override string ToString()
        {
            return base.ToString() + " SpaceGroup: " + SpaceGroup + (NumberOfFormulaUnits>0 ? " NumberOfFormulaUnits: " + NumberOfFormulaUnits : "");
        }

    }

}
