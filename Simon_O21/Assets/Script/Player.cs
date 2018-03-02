using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	bool[] button;
	GameObject[] LightObject;
	float lightTimer;
	private ArrayList ListButton;
	private bool _isOn = false;

	public ArrayList GetListButton()
	{
		return ListButton;
	}

	// Use this for initialization
	void Start () {
		lightTimer = 0;
		button = new bool[4];
		LightObject = this.GetComponent<LightController>().GetLightObject();
		ListButton = new ArrayList();
	}

	// Update is called once per frame
	void Update () {
		if (this.GetComponent<LightController>().GetIsPlayerTurn())
		{
			int i = 0;

			lightTimer = this.GetComponent<Timer>().GetStartimer();
			foreach (GameObject light in LightObject)
			{
				if (light.GetComponent<Light>().isActiveAndEnabled)
					_isOn = true;
			}
			if (!_isOn)
			{
				foreach (bool b in button)
				{
					if (b == true)
					{
						TurnLigthOn(i);
						ListButton.Add(i);
						button[i] = false;
					}
					i++;
				}
			}
			else
			{
				if (lightTimer <= 0.5f)
				{
					foreach (GameObject light in LightObject)
					{
						light.GetComponent<Light>().enabled = false;
					}
					_isOn = false;
				}
			}
		}
		else
		{
			ListButton.Clear();
		}
	}

	private void TurnLigthOn(int nbr)
	{
		LightObject[nbr].GetComponent<Light>().enabled = true;
	}

	public void SetButton(int nbrButton)
	{
		if (this.GetComponent<LightController>().GetIsPlayerTurn())
			button[nbrButton] = true;
	}
}