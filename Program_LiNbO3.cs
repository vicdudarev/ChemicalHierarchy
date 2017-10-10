//using System;

//namespace ChemicalHierarchy
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//Console.WriteLine("= TEST for Chemical Entities =");
//ChemicalElement Li = new ChemicalElement("Li");
//ChemicalElement Nb = new ChemicalElement("Nb");
//ChemicalElement O = new ChemicalElement("O");
//// ChemicalElement Oerr = new ChemicalElement("Oo"); // Exception!
//ChemicalSystem LiNbO = new ChemicalSystem(Li, Nb, O); // new ChemicalSystem(false, new ChemicalElement[] { Li, Nb, O });
//// ChemicalSystem LiNbONberr = new ChemicalSystem(new ChemicalElement[] { Li, Nb, O, Nb }); // Exception!
//// new Quantity(0);     // Exception
//// new Quantity(2, 1);   // Exception
//ChemicalSubstance LiNbO3 = new ChemicalSubstance(LiNbO,
//    new Quantity(1), new Quantity(1), new Quantity(3)   //new Quantity[] { new Quantity(1), new Quantity(1), new Quantity(3) }
//    );
//// ChemicalSubstance LiNbO3err = new ChemicalSubstance(LiNbO, new Quantity[] { new Quantity(1), new Quantity(1), new Quantity(3), new Quantity(3) }); // Exception!

//ChemicalCrystalSystem LiNbO3_Hexagonal = new ChemicalCrystalSystem(LiNbO3,
//    CrystalSystemType.Hexagonal
//    );
//ChemicalCrystalSystem LiNbO3_Rhombohedral = new ChemicalCrystalSystem(LiNbO3_Hexagonal,
//    CrystalSystemType.Rhombohedral
//    );

//Console.WriteLine("System: " + LiNbO);
//Console.WriteLine("Substance: " + LiNbO3 + ", html: " + LiNbO3.SubstanceNameHtml);
//Console.WriteLine("Modification1: " + LiNbO3_Hexagonal);
//Console.WriteLine("Modification2: " + LiNbO3_Rhombohedral);
//Console.WriteLine("Modification2 as system: " + LiNbO3_Rhombohedral.SystemName);

//Console.WriteLine("= TEST for IComparable =");
//ChemicalSystem LiNbO_norm = new ChemicalSystem(true, Li, Nb, O); // new ChemicalSystem(false, new ChemicalElement[] { Li, Nb, O });
//Console.WriteLine($"System: \"{LiNbO_norm}\".CompareTo(\"{LiNbO}\") = " + LiNbO_norm.CompareTo(LiNbO));
//ChemicalSubstance LiNbO3_norm = new ChemicalSubstance(true,
//    new ChemicalSystem(Li, Nb, O), 
//    new Quantity(1), new Quantity(1), new Quantity(3)   //new Quantity[] { new Quantity(1), new Quantity(1), new Quantity(3) }
//    );
//Console.WriteLine($"Substance: \"{LiNbO3_norm}\".CompareTo(\"{LiNbO3}\") = " + LiNbO3_norm.CompareTo(LiNbO3));
//Console.WriteLine($"Modification: \"{LiNbO3_Hexagonal}\".CompareTo(\"{LiNbO3_Rhombohedral}\") = " + LiNbO3_Hexagonal.CompareTo(LiNbO3_Rhombohedral));

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Exception({ex.GetType()}): {ex.Message} at {ex.StackTrace}");
//            }

//        }
//    }
//}
