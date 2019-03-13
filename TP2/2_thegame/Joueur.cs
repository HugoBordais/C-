namespace TP2._2_thegame
{
    public class Joueur
    {
        public string Login { get; }
        private string password;
        public bool Connected { get; private set; }

        public Joueur( string login, string password )
        {
            Login = login;
            this.password = password;
            Connected = false;
        }

        public bool Connect( Partie partie )
        {
            partie.Participe( this );
            Connected = true;
            return true;
        }
    }
}