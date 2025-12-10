using UnityEngine;

public static class MoveValidator
{
    public static bool IsValidMove(PieceData piece, Vector2Int from, Vector2Int to)
    {
        int dx = to.x - from.x;
        int dz = to.y - from.y;

        switch (piece.pieceType)
        {
            case ChessPieceType.Rook:
                return (dx == 0 || dz == 0);

            case ChessPieceType.Bishop:
                return Mathf.Abs(dx) == Mathf.Abs(dz);

            case ChessPieceType.Queen:
                return (dx == 0 || dz == 0) || (Mathf.Abs(dx) == Mathf.Abs(dz));

            case ChessPieceType.Knight:
                return (Mathf.Abs(dx) == 2 && Mathf.Abs(dz) == 1) ||
                       (Mathf.Abs(dx) == 1 && Mathf.Abs(dz) == 2);

            case ChessPieceType.King:
                return Mathf.Abs(dx) <= 1 && Mathf.Abs(dz) <= 1;

            case ChessPieceType.Pawn:
                return Mathf.Abs(dx) <= 1;

            default:
                return false;
        }
    }
}
