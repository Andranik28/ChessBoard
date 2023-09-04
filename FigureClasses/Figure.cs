namespace Figure.Shared;

public interface IFigure
{   
    public char GetSymbol();
    public void Attack();
    public void Move();
    public  bool CanMoveToPosition(int[] newPosition, int[] coordinates);   
}
