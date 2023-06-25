using System;
using System.Collections.Generic;
using System.Linq;


namespace Sudoku
{
  class Program
  {
    static void Main()
    {
      int[][] initialBoard =
      {
        new[] {0, 0, 0, 0, 0, 2, 1, 0, 0},
        new[] {0, 0, 4, 0, 0, 8, 7, 0, 0},
        new[] {0, 2, 0, 3, 0, 0, 9, 0, 0},
        new[] {6, 0, 2, 0, 0, 3, 0, 4, 0},
        new[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
        new[] {0, 5, 0, 6, 0, 0, 3, 0, 1},
        new[] {0, 0, 3, 0, 0, 5, 0, 8, 0},
        new[] {0, 0, 8, 2, 0, 0, 5, 0, 0},
        new[] {0, 0, 9, 7, 0, 0, 0, 0, 0}
      };

      Console.WriteLine("Attempting to solve board");
      PrintBoard(initialBoard);
      Console.WriteLine();

      var stack = new Stack<int[][]>();
      stack.Push(initialBoard);

      while (stack.Any())
      {
        var currentBoard = stack.Pop();
        var firstEmptySlot = GetEmptySlot(currentBoard);

        if (firstEmptySlot == null)
        {
          Console.WriteLine("Success");
          PrintBoard(currentBoard);
          break;
        }

        for (int attempt = 1; attempt <= 9; attempt++)
        {
          if (ValidInSlot(currentBoard, firstEmptySlot, attempt))
          {
            stack.Push(UpdateBoard(currentBoard, firstEmptySlot, attempt));
          }
        }
      }

      Console.ReadLine();
    }

    private static Tuple<int, int> GetEmptySlot(int[][] currentBoard)
    {
      for (int y = 0; y < currentBoard.Length; y++)
      {
        for (int x = 0; x < currentBoard[y].Length; x++)
        {
          if (currentBoard[y][x] == 0)
          {
            return Tuple.Create(y, x);
          }
        }
      }

      return null;
    }

    private static void PrintBoard(int[][] currentBoard)
    {

      Console.WriteLine("*** TODO ***");
     
    }

    private static bool ValidInSlot(int[][] board, Tuple<int, int> slot, int value)
    {
      return DoesNotExistInRow(board[slot.Item1], value) &&
             DoesNotExistInColumn(board, slot.Item2, value) &&
             DoesNotExistInSquare(board, slot, value);
    }

    private static bool DoesNotExistInRow(int[] row, int value)
    {
      // TODO implement a check that value not already in specified row
      return true;
    }

    private static bool DoesNotExistInColumn(int[][] board, int column, int value)
    {
      // TODO implement a check that value not already in specified column
      return true;
    }

    private static bool DoesNotExistInSquare(int[][] board, Tuple<int, int> slot, int value)
    {
      // TODO implement a check that value not already in current square
      return true;
    }

    private static int[][] UpdateBoard(int[][] board, Tuple<int, int> slot, int value)
    {
      var newBoard = board.Select(row => (int[]) row.Clone()).ToArray();
      newBoard[slot.Item1][slot.Item2] = value;
      return newBoard;
    }

  }
}
