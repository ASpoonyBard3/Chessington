using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var position = board.FindPiece(this);
            var availableMoves = new List<Square>();

            for (int column = 0; column <= 7; column++)
            {
                availableMoves.Add(Square.At(position.Row, column));
            }

            for (int row = 0; row <= 7; row++)
            {
                availableMoves.Add(Square.At(row, position.Col));
            }


            return availableMoves;
        }
    }
}