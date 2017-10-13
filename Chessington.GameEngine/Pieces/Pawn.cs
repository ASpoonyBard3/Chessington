﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var position = board.FindPiece(this);
            var availableMoves = new List<Square>();
            if (Player == Player.Black)
            {
                availableMoves.Add(Square.At(position.Row + 1, position.Col));
            }
            else
            {
                availableMoves.Add(Square.At(position.Row - 1, position.Col));
            }

            return availableMoves;
        }

    }
}
