using UnityEngine;

public class PieceSelected : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public static PieceSelected Instance { get; private set; }

    private GameObject selectedObject;

    void Awake()
    {
        // Singleton setup
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void SetSelectedObject(GameObject obj)
    {
        selectedObject = obj;
        print("Selected object: " + selectedObject.name);
    }

    public GameObject GetSelectedObject()
    {
		return selectedObject;
    }
	
}
