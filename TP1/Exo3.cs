using System;

namespace TP1
{
    public class Exo3
    {
        private char[] theWord;
        private char[] theCryptedWord;
        private int theWordSize;
        private int nbTries;
        private bool wordEqual = false;
        
        public Exo3()
        {
            GetTheWord();
            GetTheNbTries();
            CryptTheWord( theWord.Length );

            while ( nbTries > 0 && !wordEqual )
            {
                Console.WriteLine( "Joueur 2, entrez des lettres pour essayer de deviner le mot");
                Console.WriteLine( "Il vous reste " + nbTries + " essais");
                Console.WriteLine( WriteCharArray(theCryptedWord) );

                char letter = char.Parse(Console.ReadLine());
                bool isFind = FindLetter(letter);

                if (!isFind)
                {
                    nbTries--;
                }
                
                TryEqualWords();
            }

            if (wordEqual)
            {
                Console.WriteLine( "Bravo c'est gagné !!!");
            }
            else
            {
                Console.WriteLine( "Rententez, vous avez perdu !!!");
            }
        }

        private void GetTheWord()
        {
            Console.WriteLine( "Le joueur 1 doit entrer un mot : " );
            string word = Console.ReadLine();
            
            theWord = word.ToCharArray();
            
            Console.WriteLine( "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" );
        }

        private void GetTheNbTries()
        {
            Console.WriteLine( "Le joueur 1 doit entrer le nombre d'essais pour deviner le mot : " );
            nbTries = int.Parse(Console.ReadLine());
            
            Console.WriteLine( "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" );
        }
        
        private void CryptTheWord( int nbLetters )
        {
            theCryptedWord = new char[nbLetters];
            for (int i = 0; i < nbLetters; i++)
            {
                theCryptedWord[i] = '_';
            }
        }

        private string WriteCharArray( char[] charArray )
        {
            string returnString = "";
            
            foreach (var elem in charArray)
            {
                returnString += elem + " ";
            }

            return returnString;
        }

        private void TryEqualWords()
        {
            string cryptedWord = new string( theCryptedWord );
            string word = new string( theWord );

            if (cryptedWord == word)
            {
                wordEqual = true;
            }
        }

        private bool FindLetter( char letter )
        {
            bool isFind = false;
            
            for (int i = 0; i < theWord.Length; i++)
            {
                if (theWord[i] == letter && theCryptedWord[i] == '_')
                {
                    isFind = true;
                    theCryptedWord[i] = theWord[i];
                }
            }

            return isFind;
        }
    }
}