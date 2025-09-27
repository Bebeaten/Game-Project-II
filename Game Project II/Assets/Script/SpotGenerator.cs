using UnityEngine;

public class SpotGenerator : MonoBehaviour
{
	[Header("Spot Mechanics")]
	public GameObject spotPrefab; // Your invisible prefab
    public Transform boardOrigin; // Where your board starts (bottom-left corner)
    public int boardSize = 8;
    public float tileSize = 1.0f;

    void Start()
    {
        GenerateOverlay();
    }

    void GenerateOverlay()
    {
        for (int x = 0; x < boardSize; x++)
        {
            for (int z = 0; z < boardSize; z++)
            {
                Vector3 position = boardOrigin.position + new Vector3(x * tileSize, 0.01f, z * tileSize); // Slightly above board
                GameObject spot = Instantiate(spotPrefab, position, Quaternion.identity, this.transform);
                spot.name = $"Spot_{x}_{z}";

                SpotsOnBoard spotScript = spot.GetComponent<SpotsOnBoard>();
                if (spotScript != null)
                {
                    spotScript.boardX = x;
                    spotScript.boardZ = z;
                }
            }
        }
    }
}