using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace ChemicalHierarchy
{
    /// <summary>
    /// химический элемент
    /// </summary>
    public sealed class ChemicalElement
    {
        /// <summary>
        /// список всех химических элементов Периодической системы (из БД), упорядоченный по возрастанию атомного номера
        /// </summary>
        //private readonly string[] _elements = {"H", "He", ...};
        private readonly string[] _elements = File.ReadAllLines("..\\..\\elements.txt");
        /// <summary>
        /// обозначение элемента (H, He, ...)
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Атомный номер элемента
        /// </summary>
        public byte AtomicNumber { get; }
        /// <summary>
        /// свойства химического элемента (из БД)
        /// </summary>
        public NameValueCollection Properties { get; set; }
        /// <summary>
        /// создание элемента по имени (обозначению)
        /// </summary>
        /// <param name="name">имя элемента, например: "H", "He" и т.п.</param>
        public ChemicalElement(string name)
        {
            int num = Array.IndexOf(_elements, name);
            if (num < 1 || num>255)
                throw new ApplicationException("Не найден атомный номер по названию элемента: " + name);
            AtomicNumber = (byte)(num+1);
            Name = name;
        }
        /// <summary>
        /// создание элемента по атомному номеру
        /// </summary>
        /// <param name="atomicNumber">Атомный номер элемента</param>
        public ChemicalElement(int atomicNumber)
        {
            Name = _elements[AtomicNumber = (byte)(atomicNumber-1)]; // если атомный номер неправильный => IndexOutOfRangeException
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
