using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var position = board.FindPiece(this);
            var availableMoves = new List<Square>();
            
            for (var i = 1; i < 8; i++)
            {
                availableMoves.Add(Square.At(position.Row + i, position.Col + i));
                availableMoves.Add(Square.At(position.Row - i, position.Col - i));
                availableMoves.Add(Square.At(position.Row + i, position.Col - i));
                availableMoves.Add(Square.At(position.Row - i, position.Col + i));
            }

            availableMoves.RemoveAll(square => !IsSquareOnBoard(square));

            return availableMoves;
        }
    }
}