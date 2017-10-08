using System; 

namespace ChemicalHierarchy
{

    /// <summary>
    /// химическая модификация (добавляем к ChemicalSubstance тип кристаллической структуры)
    /// </summary>
    public class ChemicalModification : ChemicalSubstance, IComparable<ChemicalModification>, IComparable
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


        #region реализация интерфейсов IComparable<ChemicalModification> и IComparable
        public int CompareTo(ChemicalModification other)
        {
            if (other == null) return 1;
            int retVal = (this as ChemicalSubstance).CompareTo(other as ChemicalSubstance);
            if (retVal != 0)
                return retVal;
            return CrystalSystem.CompareTo(other.CrystalSystem);
        }
        public new int CompareTo(object obj)
        {
            return (this as IComparable<ChemicalModification>).CompareTo(obj as ChemicalModification);
        }
        #endregion
    }
}
