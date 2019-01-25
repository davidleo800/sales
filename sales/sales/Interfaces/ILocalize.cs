namespace sales.Interfaces
{
        using System.Globalization;

        public interface ILocalize
        {
            CultureInfo GetCurrentCultureInfo();//aqui devuelve en que idioma esta el telefono
            void SetLocale(CultureInfo ci);//Cambia la configuracion del telefono
        }
}
