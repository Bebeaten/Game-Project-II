using UnityEngine;

public class SpotsSelected : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	 public static SpotsSelected Instance { get; private set; }

    private GameObject selectedSpot;

    void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
            Instance = this;
    }

    public void SetSelectedSpot(GameObject spot)
    {
        selectedSpot = spot;
        Debug.Log("Selected spot: " + spot.name);
    }

    public GameObject GetSelectedSpot()
    {
        return selectedSpot;
    }

    public void ClearSpotSelection()
    {
        selectedSpot = null;
    }
}
