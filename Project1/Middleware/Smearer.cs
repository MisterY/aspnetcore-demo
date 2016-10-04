using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Middleware
{
    /// <summary>
    /// Garbles any text by encoding it in base 64.
    /// </summary>
    public class Smearer
    {
        public string Garble(string content)
        {
            byte[] byteArray = Encoding.ASCII.GetBytes(content);
            return Convert.ToBase64String(byteArray);
        }
    }
}
