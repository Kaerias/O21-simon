using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

	int[] Ia;
	bool WinGame;

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
			if (Ia[nbr] != -1)
			{
				if (i != Ia[nbr])
					WinGame = false;
				nbr++;
			}
		}
		if (WinGame == true && Ia[0] != -1)
			print("You Win");
		else
			print("You Lose");
		GetComponent<LightController>().SetIsPlayerTurn(false);
		GetComponent<LightController>().SetIsChoose(false);
		GetComponent<LightController>().SetTurn();
		GetComponent<LightController>().ListClear();
	}
}
