using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public abstract class Piece
    {
        protected Piece(Player player)
        {
            Player = player;
        }

        public Player Player { get; private set; }

        public bool PieceMoved { get; set; }

        public abstract IEnumerable<Square> GetAvailableMoves(Board board);

        public void MoveTo(Board board, Square newSquare)
        {
            PieceMoved = true;
            var currentSquare = board.FindPiece(this);
            board.MovePiece(currentSquare, newSquare);
        }

        public bool IsSquareOnBoard(Square square)
        {
            if (square.Col >= 8)
            {
                return false;
            }
            if (square.Col < 0)
            {
                return false;
            }
            if (square.Row >= 8)
            {
                return false;
            }
            if (square.Row < 0)
            {
                return false;
            }
            return true;
        }
    }
}