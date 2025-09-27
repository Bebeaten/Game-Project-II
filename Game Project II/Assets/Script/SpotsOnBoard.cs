using UnityEngine;

public class SpotsOnBoard : MonoBehaviour
{
	public int boardX;
    public int boardZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        print($"Clicked Spot at ({boardX}, {boardZ})");
        // Call manager or piece logic here if needed
    }
	
}
