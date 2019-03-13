using System.Collections.Generic;

namespace TP2._2_thegame
{
    public class Partie
    {
        private int id;
        public List<Joueur> Participants { get; }

        public Partie()
        {
            Participants = new List<Joueur>();
        }
        
        public void Participe(Joueur joueur)
        {
            Participants.Add(joueur);
        }
    
        public override string ToString()
        {
            string theReturn = "Verif : [PartieMultiJoueurs]";
            
            foreach (var participant in Participants)
            {
                theReturn += "\n[Joueur] " + participant.Login + " - Connected : " + participant.Connected;
            }

            return theReturn;
        }
      
        public void Save( string filePath ){}
        public Partie Load(string filePath)
        {
            return new Partie();
        }
    }
}