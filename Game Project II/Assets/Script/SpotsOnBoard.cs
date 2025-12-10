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
        SpotsSelected.Instance.SetSelectedSpot(this.gameObject);
        Debug.Log($"Clicked Spot ({boardX}, {boardZ})");
    }
	
}
