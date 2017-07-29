using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalHierarchy
{
    /// <summary>
    /// химическая система
    /// </summary>
    public class ChemicalSystem
    {
        /// <summary>
        /// название системы (это перечисление хим. элементов через тире, например, As-Ga)
        /// </summary>
        public string SystemName {
            get { return string.Join("-", Array.ConvertAll(Elements, x => x.Name));  } 
        }

        /// <summary>
        /// массив химических элементов
        /// </summary>
        public ChemicalElement[] Elements { get; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="el"></param>
        public ChemicalSystem(ChemicalElement[] el)
        {
            if (el.Length!=el.Distinct().Count())
                throw new ApplicationException("Найдены повторяющиеся элементы");
            Elements = el;
        }

    }
}

