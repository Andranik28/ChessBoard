using System;
using static System.Console;
using Figure.Shared;
using ChessBoardClass.Shared;
using System.Diagnostics;

RunChess();
RunKnightMoveCheck();


void RunChess()
{
    int [] cordinates = new int[2];
    King king;
    Queen queen;
    Rook rook;
    Knight knight;

    ChessBoard chessBoard = new ChessBoard();
    WriteLine("Choose Figure from H K Q R");
    char figureLetter = Convert.ToChar(ReadLine());
    WriteLine("Set Color W or B");
    char coltext = Convert.ToChar(ReadLine());
    WriteLine("Write Cordinate A B C D E F G H");
    cordinates[0] = Convert.ToUInt16(ReadLine());
    WriteLine("Write Cordinate 1 2 3 4 5 6 7 8");
    cordinates[1] = Convert.ToUInt16(ReadLine());
    ConsoleColor figureColor = coltext == 'W' ? ConsoleColor.White : ConsoleColor.Black;

    switch(figureLetter)
    {
        case 'H':
            knight = new Knight(figureColor);
            chessBoard.SetFigureAtPosition(knight.GetSymbol(), figureColor,cordinates[1],cordinates[0] );
            chessBoard.PrintBoard();
            break;

        case 'K':
            king = new King(figureColor);
            chessBoard.SetFigureAtPosition(king.GetSymbol(),figureColor, cordinates[1],cordinates[0] );
            chessBoard.PrintBoard();
            break;
                    
        case 'Q':
            queen = new Queen(figureColor);
            chessBoard.SetFigureAtPosition(queen.GetSymbol(),figureColor, cordinates[0],cordinates[1] );
            chessBoard.PrintBoard();
            break;

        case 'R':
            rook = new Rook(figureColor);
            chessBoard.SetFigureAtPosition(rook.GetSymbol(),figureColor, cordinates[0],cordinates[1] );
            chessBoard.PrintBoard();
            break;
    }                   
}

void RunKnightMoveCheck()
{
    ChessBoard chessBoard = new ChessBoard();
    Knight knight = new Knight(ConsoleColor.White);
    int[] initpos = {1,1};
    int[] destpos = {2,3};

    if(knight.CanMoveToPosition(initpos, destpos))
    {
        WriteLine($"Move from {initpos[0]},{initpos[1]} to {destpos[0]},{destpos[1]} is possible");
    }
    else
    {
        WriteLine("Move is not possible");
    }
}
