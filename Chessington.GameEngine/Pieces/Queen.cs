using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
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
            for (var i = 1; i < 8; i++)
            {
                availableMoves.Add(Square.At(position.Row + i, position.Col + i));
                availableMoves.Add(Square.At(position.Row - i, position.Col - i));
                availableMoves.Add(Square.At(position.Row + i, position.Col - i));
                availableMoves.Add(Square.At(position.Row - i, position.Col + i));
            }

            availableMoves.RemoveAll(square => !IsSquareOnBoard(square));

            var availableMoves = list.GroupBy(x => x)
                .where(IGrouping =>>)

            return availableMoves;

        }
    }
}