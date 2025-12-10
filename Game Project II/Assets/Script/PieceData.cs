using UnityEngine;

public enum ChessPieceType
{
    Pawn, Rook, Knight, Bishop, Queen, King
}

public class PieceData : MonoBehaviour
{
    public ChessPieceType pieceType;
    public bool isWhite;
	
	public SpotsOnBoard currentSpot;
}