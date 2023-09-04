namespace Figure.Shared;



    public class Knight : IFigure
    {
        private char figureSymbol = 'H';
        public ConsoleColor color{get; set;}

        public Knight(ConsoleColor color)
        {
            this.color = color;
        }

        public  char GetSymbol()
        {
            return figureSymbol;
        }
         
        public  bool CanMoveToPosition(int[] newPosition, int[] coordinates)
        {
            int dx = Math.Abs(newPosition[0] - coordinates[0]);
            int dy = Math.Abs(newPosition[1] - coordinates[1]);
            return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
        }

        public  void Attack() { }
        public  void Move() { }
     
    }

