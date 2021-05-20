﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Crypt_decrypt
{
    public class FileReadWriteHandler
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


        public static string leerXml(string ruta)
        {


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(ruta);
            XmlNodeList clave = xDoc.GetElementsByTagName("clave");
            return clave[0].InnerText;

        }

        public static void exportarXml(string alName, string clavePrivadaTexto1, string ruta)
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

            clavePrivada.InnerText = clavePrivadaTexto1;
            alTag.AppendChild(clavePrivada);
            doc.InsertBefore(xmlDeclaration, root);
            doc.AppendChild(alTag);
            doc.Save(ruta);
        }
    }
}
