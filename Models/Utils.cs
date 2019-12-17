namespace GPC.Models
{
    public class Utils
    {
        public static string removeBadChars(string campo){
            if(campo != null){
                campo = campo.Replace(">", " ")
                            .Replace("<", " ")
                            .Replace("'", " ")
                            .Replace('"', ' ')
                            .Replace(">", " ");
                return campo;
            }
            return null;
        }
    }
}