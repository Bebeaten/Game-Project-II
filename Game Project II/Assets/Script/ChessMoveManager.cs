using UnityEngine;

public class ChessMoveManager : MonoBehaviour
{
    public void MoveSelectedPieceToSpot()
    {
        GameObject pieceObj = PieceSelected.Instance.GetSelectedObject();
        GameObject spotObj = SpotsSelected.Instance.GetSelectedSpot();

        if (pieceObj == null)
        {
            Debug.LogError("No piece selected!");
            return;
        }

        if (spotObj == null)
        {
            Debug.LogError("No target spot selected!");
            return;
        }

        PieceData pieceData = pieceObj.GetComponent<PieceData>();
        if (pieceData == null)
        {
            Debug.LogError("Selected piece does not have PieceData!");
            return;
        }

        SpotsOnBoard fromSpot = pieceData.currentSpot;
        SpotsOnBoard toSpot = spotObj.GetComponent<SpotsOnBoard>();

        if (fromSpot == null)
        {
            Debug.LogError("Selected piece is not assigned to any spot!");
            return;
        }

        if (toSpot == null)
        {
            Debug.LogError("Selected spot does not have SpotsOnBoard component!");
            return;
        }

        Vector2Int from = new Vector2Int(fromSpot.boardX, fromSpot.boardZ);
        Vector2Int to = new Vector2Int(toSpot.boardX, toSpot.boardZ);

        if (!MoveValidator.IsValidMove(pieceData, from, to))
        {
            Debug.Log("Invalid move!");
            return;
        }

		if (toSpot.transform.childCount > 0)
		{
			GameObject capturedPiece = toSpot.transform.GetChild(0).gameObject;
			PieceData capturedData = capturedPiece.GetComponent<PieceData>();

			if (capturedData.pieceType == ChessPieceType.King)
			{
				string winner = capturedData.isWhite ? "Black" : "White";
				GameOver(winner);
			}

			Destroy(capturedPiece);
		}

        pieceObj.transform.position = toSpot.transform.position;
        pieceObj.transform.SetParent(toSpot.transform);

        pieceData.currentSpot = toSpot;

        PieceSelected.Instance.ClearSelection();
        SpotsSelected.Instance.ClearSpotSelection();

        Debug.Log($"Moved {pieceObj.name} from {fromSpot.name} to {toSpot.name}");
    }
	private void GameOver(string winningColor)
	{
		PieceSelected.Instance.ClearSelection();
		SpotsSelected.Instance.ClearSpotSelection();

		Debug.Log("Game Over! " + winningColor + " wins!");

		this.enabled = false;

	}

}
