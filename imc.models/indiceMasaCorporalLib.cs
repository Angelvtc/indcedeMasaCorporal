

namespace imc.models
{
    public static class indiceMasaCorporalLib
    {
        public static decimal IndiceDemasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }


        public static string DeterminaEstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "peso bajo";
            }
            else if (imc < 25.00m)
            {
                return "peso normal";
            }
            else if (imc < 30.0m)
            {
                return "sobre peso";
            }
            else if (imc < 40.00m)
            {
                return "obesidad";
            }
            else
            {
                return "obesidad extrema";
            }
        }
    }
}
