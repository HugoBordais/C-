using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing ;
using System.IO;

namespace TPFichierImage
{
    class GGBitmap
    {
        public static  void SavePictureGGFormat(Image i, string filePath)
        {
            // Format fichier :
            /*
             * largeur en pixels (UInt16)
             * hauteur en pixels (UInt16)
             * chaîne de contrôle (2 octets) : GG
             * taille en octets du commentaire (Int32)
             * commentaire (taille variable)
             * Données de l'image : chaque pixel a sa valeur de couleur codée sur un Int32
              * chaîne de contrôle (2 octets) : AK
             * 
            */

            // Sauvegarde de l'image selon le format décrit ci-dessus : à coder


        }

        // Chargement du fichier et construction d'une instance de Image selon le format de fichier décrit ci-dessus
        public static Image LoadPictureGGFormat(string p) // String p équivaut à la référance du fichier
        {
            BinaryReader binaryReader = new BinaryReader(File.Open(p, FileMode.Open)); // Ouvre le fichier en binaire

            int width = binaryReader.ReadUInt16(); // Largeur lu en binaire (int 16)
            int height = binaryReader.ReadUInt16(); // Hauteur lu en binaire (int 16)

            string test1 = new string(binaryReader.ReadChars(2)); // Lis la chaine de contrôle de type char, d'une valeur de 2 en binaire
            int comentSize = binaryReader.ReadInt32(); // Taille du commentaire lu en binaire (int 32)
            string coment = new string(binaryReader.ReadChars(comentSize)); // Récupère le commentaire selon sa taille

            Bitmap image = new Bitmap(width, height); // Format d'image, lui passent comme valeur la longueur et la largeur 
           
            for (int widthIndex = 0; widthIndex < width; widthIndex++) // Parcourt la largeur de l'image
            {
                for (int heightIndex = 0; heightIndex < height; heightIndex++) // Parcourt la hauteur de l'image
                {
                    image.SetPixel(widthIndex, heightIndex, Color.FromArgb(binaryReader.ReadInt32())); // Ajoute un pixel à une coordonnée largeurIndex en lui injéctant un couleur lu en binaire (int 32)
                }
            }
            string test2 = new string(binaryReader.ReadChars(2)); // Lis la chaine de contrôle de type char d'une valeur de 2 en binaire

            Console.WriteLine("Image :");
            Console.WriteLine("Largeur de l'image :" + width); // Affiche largeur de l'image
            Console.WriteLine("Hauteur de l'image :" + height); // Affiche hauteur de l'image
            Console.WriteLine("1er contrôle :" + test1); // Affiche contrôle n°1
            Console.WriteLine("Longueur du commentaire :" + comentSize); // Affiche taille du commentaire
            Console.WriteLine("Commentaire :" + coment); // Affiche commentaire
            Console.WriteLine("2eme contrôle:" + test2); // Affiche contrôle n°2

            return image;
        }

        public static Image SavePictureGGFormat(string p) 
        {
            return null;
        }
    }
}
