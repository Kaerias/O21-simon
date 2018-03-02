using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

	public int nbrButton;

	private void OnMouseDown()
	{
		GameObject.Find("GameBoard").GetComponent<Player>().SetButton(nbrButton);
	}
}
