using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Utilitarios.Util
{
    /// <summary>
    /// Classe referente as mensagens de "regra de negócio".
    /// </summary>
    public enum MSG
    {
        [Description("Não existe divisores do número 0.")]
        NumeroZero = 1
    }

    public static class MSGD
    {
        public static string GetDescription(System.Enum value)
        {
            var enumMember = value.GetType().GetMember(value.ToString()).FirstOrDefault();
            var descriptionAttribute =
                enumMember == null
                    ? default(DescriptionAttribute)
                    : enumMember.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
            return
                descriptionAttribute == null
                    ? value.ToString()
                    : descriptionAttribute.Description;
        }
    }
}
