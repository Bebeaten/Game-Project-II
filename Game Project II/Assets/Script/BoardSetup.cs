using UnityEngine;

public class BoardSetup : MonoBehaviour
{
	public GameObject BlackBishopPrefab;
	public GameObject BlackKingPrefab;
	public GameObject BlackKnightPrefab;
	public GameObject BlackPawnPrefab;
	public GameObject BlackQueenPrefab;
	public GameObject BlackRookPrefab;
	public GameObject WhiteBishopPrefab;
	public GameObject WhiteKingPrefab;
	public GameObject WhiteKnightPrefab;
	public GameObject WhitePawnPrefab;
	public GameObject WhiteQueenPrefab;
	public GameObject WhiteRookPrefab;
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		PlacePieceOnSpot("White Queen", "Spot_3_7");
		PlacePieceOnSpot("White Rook 1", "Spot_0_7");
		PlacePieceOnSpot("White Rook 2", "Spot_7_7");
		PlacePieceOnSpot("White Bishop 1", "Spot_2_7");
		PlacePieceOnSpot("White Bishop 2", "Spot_5_7");
		PlacePieceOnSpot("White King", "Spot_4_7");
		PlacePieceOnSpot("White Knight 1", "Spot_1_7");
		PlacePieceOnSpot("White Knight 2", "Spot_6_7");
        PlacePieceOnSpot("White Pawn 1", "Spot_0_6");
        PlacePieceOnSpot("White Pawn 2", "Spot_1_6");
		PlacePieceOnSpot("White Pawn 3", "Spot_2_6");
		PlacePieceOnSpot("White Pawn 4", "Spot_3_6");
		PlacePieceOnSpot("White Pawn 5", "Spot_4_6");
		PlacePieceOnSpot("White Pawn 6", "Spot_5_6");
		PlacePieceOnSpot("White Pawn 7", "Spot_6_6");
		PlacePieceOnSpot("White Pawn 8", "Spot_7_6");
        
		PlacePieceOnSpot("Black Queen", "Spot_3_0");
		PlacePieceOnSpot("Black Rook 1", "Spot_0_0");
		PlacePieceOnSpot("Black Rook 2", "Spot_7_0");
		PlacePieceOnSpot("Black Bishop 1", "Spot_2_0");
		PlacePieceOnSpot("Black Bishop 2", "Spot_5_0");
		PlacePieceOnSpot("Black King", "Spot_4_0");
		PlacePieceOnSpot("Black Knight 1", "Spot_1_0");
		PlacePieceOnSpot("Black Knight 2", "Spot_6_0");
        PlacePieceOnSpot("Black Pawn 1", "Spot_0_1");
        PlacePieceOnSpot("Black Pawn 2", "Spot_1_1");
		PlacePieceOnSpot("Black Pawn 3", "Spot_2_1");
		PlacePieceOnSpot("Black Pawn 4", "Spot_3_1");
		PlacePieceOnSpot("Black Pawn 5", "Spot_4_1");
		PlacePieceOnSpot("Black Pawn 6", "Spot_5_1");
		PlacePieceOnSpot("Black Pawn 7", "Spot_6_1");
		PlacePieceOnSpot("Black Pawn 8", "Spot_7_1");
        
    }

    void PlacePieceOnSpot(string pieceName, string spotName)
    {
        GameObject piece = GameObject.Find(pieceName);
        GameObject spot = GameObject.Find(spotName);

        if (piece == null)
        {
            Debug.LogError("Could not find piece or spot: " + pieceName);
            return;
        }
		if (spot == null)
        {
            Debug.LogError("Could not find piece or spot: " + spotName);
            return;
        }

        SpotsOnBoard spotScript = spot.GetComponent<SpotsOnBoard>();
        PieceData pieceData = piece.GetComponent<PieceData>();

        // Move piece to spot
        piece.transform.position = spot.transform.position;
        piece.transform.SetParent(spot.transform);

        // Assign currentSpot
        pieceData.currentSpot = spotScript;
    }
}
