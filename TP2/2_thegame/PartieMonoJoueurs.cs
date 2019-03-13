namespace TP2._2_thegame
{
    public class PartieMonoJoueurs : Partie
    {
        public PartieMonoJoueurs() : base() {}

        public void Participe( Joueur joueur )
        {
            if (Participants.Count < 1)
            {
                base.Participe(joueur);
            }
        }
    }
}