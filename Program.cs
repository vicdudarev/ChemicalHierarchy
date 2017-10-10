using System;

namespace ChemicalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
Console.WriteLine("= TEST for Chemical Entities =");
ChemicalElement Ba = new ChemicalElement("Ba");
ChemicalElement Ti = new ChemicalElement("Ti");
ChemicalElement O = new ChemicalElement("O");
// ChemicalElement Oerr = new ChemicalElement("Oo"); // Exception!
ChemicalSystem BaTiO = new ChemicalSystem(Ba, Ti, O); // new ChemicalSystem(false, new ChemicalElement[] { Ba, Ti, O });
// ChemicalSystem BaTiONberr = new ChemicalSystem(new ChemicalElement[] { Ba, Ti, O, Ti }); // Exception!
// new Quantity(0);     // Exception
// new Quantity(2, 1);   // Exception
ChemicalSubstance BaTiO3 = new ChemicalSubstance(BaTiO,
    new Quantity(1), new Quantity(1), new Quantity(3)   //new Quantity[] { new Quantity(1), new Quantity(1), new Quantity(3) }
    );
// ChemicalSubstance LiNbO3err = new ChemicalSubstance(LiNbO, new Quantity[] { new Quantity(1), new Quantity(1), new Quantity(3), new Quantity(3) }); // Exception!

ChemicalCrystalSystem BaTiO3_Hexagonal = new ChemicalCrystalSystem(BaTiO3,
    CrystalSystemType.Hexagonal
    );
ChemicalCrystalSystem BaTiO3_Tetragonal = new ChemicalCrystalSystem(BaTiO3_Hexagonal,
    CrystalSystemType.Tetragonal
    );
ChemicalCrystalSystem BaTiO3_Trigonal = new ChemicalCrystalSystem(BaTiO3_Tetragonal,
    CrystalSystemType.Trigonal
    );

Console.WriteLine("System: " + BaTiO);
Console.WriteLine("Substance: " + BaTiO3 + ", html: " + BaTiO3.SubstanceNameHtml);
Console.WriteLine("Modification1: " + BaTiO3_Hexagonal);
Console.WriteLine("Modification2: " + BaTiO3_Tetragonal);
Console.WriteLine("Modification2 as system: " + BaTiO3_Tetragonal.SystemName);

Console.WriteLine("= TEST for IComparable =");
ChemicalSystem BaTiO_norm = new ChemicalSystem(true, Ba, Ti, O); // new ChemicalSystem(false, new ChemicalElement[] { Ba, Ti, O });
Console.WriteLine($"System: \"{BaTiO_norm}\".CompareTo(\"{BaTiO}\") = " + BaTiO_norm.CompareTo(BaTiO));
ChemicalSubstance BaTiO3_norm = new ChemicalSubstance(true,
    new ChemicalSystem(Ba, Ti, O), 
    new Quantity(1), new Quantity(1), new Quantity(3)   //new Quantity[] { new Quantity(1), new Quantity(1), new Quantity(3) }
    );
Console.WriteLine($"Substance: \"{BaTiO3_norm}\".CompareTo(\"{BaTiO3}\") = " + BaTiO3_norm.CompareTo(BaTiO3));
Console.WriteLine($"Modification: \"{BaTiO3_Hexagonal}\".CompareTo(\"{BaTiO3_Tetragonal}\") = " + BaTiO3_Hexagonal.CompareTo(BaTiO3_Tetragonal));
Console.WriteLine($"Modification: \"{BaTiO3_Hexagonal}\".CompareTo(\"{BaTiO3_Trigonal}\") = " + BaTiO3_Hexagonal.CompareTo(BaTiO3_Trigonal));

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception({ex.GetType()}): {ex.Message} at {ex.StackTrace}");
            }

        }
    }
}
