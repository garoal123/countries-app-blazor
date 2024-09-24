using System;

namespace AppCountries.Utils
{
    public class Utils
    {
        public Utils()
        {
        }

        // Función para traducir el nombre del continente de inglés a español
        public static string TraducirContinente(string continenteIngles)
        {
            return continenteIngles switch
            {
                "Africa" => "África",
                "Americas" => "América",
                "Antarctic" => "Antártida",
                "Asia" => "Asia",
                "Europe" => "Europa",
                "Oceania" => "Oceanía",
                _ => "Admin" // O cualquier otro valor predeterminado
            };
        }

        public static Dictionary<string, string> ContinentTranslations = new Dictionary<string, string>
{
        { "Africa", "África" },
        { "Americas", "América" },
        { "Antarctic", "Antártida" },
        { "Asia", "Asia" },
        { "Europe", "Europa" },
        { "Oceania", "Oceanía" }
    };
    }
}
