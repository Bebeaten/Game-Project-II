using UnityEngine;

public class PiecePlacer : MonoBehaviour
{
    
    public GameObject piecePrefab;

    public void PlacePieceOnSelectedSpot()
    {
        GameObject spotObj = SpotsSelected.Instance.GetSelectedSpot();
        if (spotObj == null)
        {
            Debug.LogWarning("No spot selected!");
            return;
        }

        SpotsOnBoard targetSpot = spotObj.GetComponent<SpotsOnBoard>();
        if (targetSpot == null)
        {
            Debug.LogError("Selected spot does not have SpotsOnBoard component!");
            return;
        }

        
        if (targetSpot.transform.childCount > 0)
        {
            Destroy(targetSpot.transform.GetChild(0).gameObject);
        }

        GameObject newPiece = Instantiate(piecePrefab, targetSpot.transform.position, Quaternion.identity);
        newPiece.transform.SetParent(targetSpot.transform);

        PieceData data = newPiece.GetComponent<PieceData>();
        if (data != null)
        {
            data.currentSpot = targetSpot;
        }

        Debug.Log("Spawned new piece on: " + targetSpot.name);
    }
}