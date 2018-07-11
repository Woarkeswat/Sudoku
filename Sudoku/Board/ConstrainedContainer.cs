
namespace Board
{
    public abstract class ConstrainedContainer
    {
        private int _id;
        private Square[] square;
        private int i = 0;

        public ConstrainedContainer(int id, int boardSize)
        {
            _id = id;
            square = new Square[boardSize];
        }

        public void Add(ref Square s)
        {
            square[i++] = s;
        }

        public int id { get { return _id; }}
        public Square[] sq { get { return square; }}
    }
}
