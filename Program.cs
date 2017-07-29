using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChemicalElement Li = new ChemicalElement("Li");
                ChemicalElement Nb = new ChemicalElement("Nb");
                ChemicalElement O = new ChemicalElement("O");
                // ChemicalElement Oerr = new ChemicalElement("Oo"); // Exception!
                ChemicalSystem LiNbO = new ChemicalSystem(new ChemicalElement[] { Li, Nb, O });
                // ChemicalSystem LiNbONberr = new ChemicalSystem(new ChemicalElement[] { Li, Nb, O, Nb }); // Exception!
                // new Quantity(0);     // Exception
                // new Quantity(2, 1);   // Exception
                ChemicalSubstance LiNbO3 = new ChemicalSubstance(LiNbO,
                    new Quantity[] { new Quantity(1), new Quantity(1), new Quantity(3) });
                // ChemicalSubstance LiNbO3err = new ChemicalSubstance(LiNbO, new Quantity[] { new Quantity(1), new Quantity(1), new Quantity(3), new Quantity(3) }); // Exception!

                ChemicalModification LiNbO3_Hexagonal = new ChemicalModification(LiNbO3,
                    CrystalSystemType.Hexagonal
                    );
                ChemicalModification LiNbO3_Orthorhombic = new ChemicalModification(LiNbO3_Hexagonal,
                    CrystalSystemType.Orthorhombic
                    );

                Console.WriteLine("System: " + LiNbO);
                Console.WriteLine("Substance: " + LiNbO3 + ", html: " + LiNbO3.SubstanceNameHtml);
                Console.WriteLine("Modification1: " + LiNbO3_Hexagonal);
                Console.WriteLine("Modification2: " + LiNbO3_Orthorhombic);
                Console.WriteLine("Modification2 as system: " + LiNbO3_Orthorhombic.SystemName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception({ex.GetType()}): {ex.Message} at {ex.StackTrace}");
            }

        }
    }
}
