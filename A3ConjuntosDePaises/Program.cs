using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3ConjuntosDePaises
{
    class Program
    {
        static void Main(string[] args)
        {
            var paises = GetPaises();

            ISet<string> conjuntoIngles = new HashSet<string>(paises.Where(p => p.Lingua == "en").Select(p => p.Nome));
            ISet<string> conjuntoFrances = new HashSet<string>(paises.Where(p => p.Lingua == "fr").Select(p => p.Nome));
            ISet<string> conjuntoAlemao = new HashSet<string>(paises.Where(p => p.Lingua == "de").Select(p => p.Nome));

            Console.WriteLine("PAÍSES QUE FALAM ALEMÃO");
            foreach (var pais in conjuntoAlemao)
            {
                Console.WriteLine(pais);
            }
            Console.WriteLine();

            Console.WriteLine("PAÍSES QUE FALAM FRANCÊS **E** ALEMÃO");
            var francesEAlemao = conjuntoFrances.Intersect(conjuntoAlemao);
            foreach (var pais in francesEAlemao)
            {
                Console.WriteLine(pais);
            }
            Console.WriteLine();

            Console.WriteLine("PAÍSES QUE FALAM FRANCÊS **OU** ALEMÃO");
            var francesOUAlemao = new HashSet<string>(conjuntoFrances);
            francesOUAlemao.UnionWith(conjuntoAlemao);
            foreach (var pais in francesOUAlemao)
            {
                Console.WriteLine(pais);
            }
            Console.WriteLine();

            Console.WriteLine("ALGUM PAÍS FALA INGLÊS **E** ALEMÃO?");
            Console.WriteLine(conjuntoIngles.Overlaps(conjuntoAlemao));
            Console.WriteLine();

            HashSet<string> estadosUnidosECanada = new HashSet<string> { "Estados Unidos", "Canadá" };
            Console.WriteLine("ESTADOS UNIDOS E CANADÁ FALAM INGLÊS?");
            Console.WriteLine(estadosUnidosECanada.IsSubsetOf(conjuntoIngles));

            Console.ReadKey();
        }

        public static List<Pais> GetPaises()
        {
            List<Pais> paises = new List<Pais>();
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo getCulture in getCultureInfo)
            {
                RegionInfo GetRegionInfo = new RegionInfo(getCulture.LCID);
                if (!(paises.Where(p => 
                (p.Lingua == getCulture.TwoLetterISOLanguageName 
                && p.Nome == GetRegionInfo.DisplayName)).Any()))
                {
                    if (GetRegionInfo.DisplayName != "Djibuti")
                    {
                        paises.Add(new Pais(getCulture.TwoLetterISOLanguageName, GetRegionInfo.DisplayName));
                    }
                }
            }
            return paises.Distinct().ToList();
        }
    }

    class Pais
    {
        public Pais(string lingua, string nome)
        {
            Lingua = lingua;
            Nome = nome;
        }

        public string Lingua { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return string.Format("[{0} - {1}]", Lingua, Nome);
        }
    }
}
