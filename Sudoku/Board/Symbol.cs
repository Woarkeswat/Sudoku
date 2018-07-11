
namespace Board
{
    public class Symbol
    {
        string symbols;

        public Symbol(string characters)
        {
            symbols = characters;
        }

        public string sym { get { return symbols; } set { symbols = value; } }
    }
}
