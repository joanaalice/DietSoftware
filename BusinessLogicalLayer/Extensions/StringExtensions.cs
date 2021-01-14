using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicalLayer.Extensions
{
    static class StringExtensions
    {
        public static string UserNameValidator(this string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                return "O nome deve ser informado.";
            } else if(name.Length < 3 || name.Length > 40)
            {
                return "O nome deve ter entre 3 e 40 caractéres.";
            }
            return "";
        }
    }
}
