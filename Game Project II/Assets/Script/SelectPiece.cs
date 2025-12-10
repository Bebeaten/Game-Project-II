using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPiece : MonoBehaviour
{
	
	void OnMouseEnter(){
		//print("Piece:OnMouseEnter()");
		
	}
	
	void OnMouseExit(){
		//print("Piece:OnMouseExit()");
		
	}
	
	void OnMouseDown(){
        PieceSelected.Instance.SetSelectedObject(this.gameObject);
	}
	
}
