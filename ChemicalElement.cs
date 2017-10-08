using System;
using System.Collections.Specialized;
using System.IO;

namespace ChemicalHierarchy
{
    /// <summary>
    /// химический элемент
    /// </summary>
    public sealed class ChemicalElement : IComparable<ChemicalElement>, IComparable
    {
        /// <summary>
        /// файл со списком допустимых элементов
        /// </summary>
        public const string ElementsFileName = "..\\..\\elements.txt";

        /// <summary>
        /// список всех химических элементов Периодической системы (из БД), упорядоченный по возрастанию атомного номера
        /// _elements = {"H", "He", ...};
        /// </summary>
        private readonly static string[] _elements;
        /// <summary>
        /// Статический конструктор (инициализация списка допустимых химичеких элементов)
        /// В папке с решением должен быть файл elements.txt
        /// </summary>
        static ChemicalElement()
        {
            if (!File.Exists(ElementsFileName))
                throw new ApplicationException("Не найден файл со списком допустимых элементов: " + ElementsFileName);
            _elements = File.ReadAllLines(ElementsFileName);
        }
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
            int num = Array.IndexOf(_elements, name); // StringComparison.InvariantCulture
            if (num < 1 || num > 255)
                throw new ApplicationException("Не найден атомный номер по названию элемента: " + name);
            AtomicNumber = (byte)(num + 1);
            Name = name;
        }
        /// <summary>
        /// создание элемента по атомному номеру
        /// </summary>
        /// <param name="atomicNumber">Атомный номер элемента</param>
        public ChemicalElement(int atomicNumber)
        {
            Name = _elements[AtomicNumber = (byte)(atomicNumber - 1)]; // если атомный номер неправильный => IndexOutOfRangeException
        }

        public override string ToString()
        {
            return Name;
        }

        #region реализация интерфейсов IComparable<ChemicalElement> и IComparable
        public int CompareTo(ChemicalElement other)
        {
            if (other == null) return 1;
            return AtomicNumber.CompareTo(other.AtomicNumber);
        }

        public int CompareTo(object obj)
        {
            return (this as IComparable<ChemicalElement>).CompareTo(obj as ChemicalElement);
        }
        #endregion
    }
}
