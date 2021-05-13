using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Crypt_decrypt
{
    public class LeectorArchivos
    {

        public static void guardarTxt(string texto, string ruta)
        {


            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }

            using (StreamWriter file = new StreamWriter(ruta, true))
            {
                file.WriteLine(texto);// TODO pasarlo a base 64
                file.Close();
            }
        }

        public static void exportarXml(string alName, string clavePrivadaTexto1, string clavePrivadaTexto2, string clavePrivadaTexto3, string clavePublicaTexto, string ruta)
        {
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }

            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            XmlElement alTag = doc.CreateElement(string.Empty, alName, string.Empty);
            XmlElement clavePrivada = doc.CreateElement(string.Empty, "clave", string.Empty);
            XmlElement clavePrivada2 = doc.CreateElement(string.Empty, "clave2", string.Empty);
            XmlElement clavePrivada3 = doc.CreateElement(string.Empty, "clave3", string.Empty);

            clavePrivada.InnerText = clavePrivadaTexto1;
            clavePrivada2.InnerText = clavePrivadaTexto2;
            clavePrivada3.InnerText = clavePrivadaTexto3;

            XmlElement clavePublica = doc.CreateElement(string.Empty, "clavePublica", string.Empty);
            clavePublica.InnerText = clavePublicaTexto;
            alTag.AppendChild(clavePrivada);
            if (alName.Equals("AES"))
            {

                alTag.AppendChild(clavePublica);
            }
            else
            {
                alTag.AppendChild(clavePrivada2);
                alTag.AppendChild(clavePrivada3);
            }




            doc.InsertBefore(xmlDeclaration, root);
            doc.AppendChild(alTag);
            doc.Save(ruta);
        }
    }
}
