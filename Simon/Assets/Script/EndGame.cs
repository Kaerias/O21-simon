using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

	int[] Ia;
	bool WinGame;
	public GameObject Board;
	public Text text;

	private void Start()
	{
		WinGame = true;
		Ia = new int[6];
	}

	public void Test()
	{
		int nbr = 0;

		foreach (int i in GetComponent<Player>().GetListButton())
		{
			nbr++;
		}
		Ia = new int[nbr + 1];
		Ia[nbr] = -1;
		GetComponent<Player>().GetListButton().CopyTo(Ia);
		nbr = 0;
		foreach (int i in GetComponent<LightController>().GetListButton())
		{
			//réaliser la condtion suivante : si Ia[nbr] est différent de -1
			{
				//réaliser la condtion suivante : si "i" est différent de Ia[nbr];
					//mettre la Variable "WinGame" à false;
				//fermer la condition avant le "nbr++";
				nbr++;
			}
		}
		if (WinGame == true && Ia[0] != -1)
		{
			//changer le text de la variable "text". mettre "You Win" si "WinGame == true" sinon "You Lose"
			//mettre text ici;
		}
		else {
			//et la ici aussi;
		}
		Board.SetActive(false);
	}

	public void Retry()
	{
		//réalisez les appel fonctions : "SetIsPlayerTurn", "SetIsChoose", "ListClear" et "SetTurn", en leurs donnant les bon arguments grâçe un component, indice : le component et "LightController" 

		Board.SetActive(true);
	}
}
