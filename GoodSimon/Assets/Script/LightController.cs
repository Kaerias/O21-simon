using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

	public GameObject[] LightButton;
	private bool _isOn;
	private bool _isPlayerTurn;
	private int timerMax;
	private int turn;
	private int turnMax;
	private int length;
	private bool _isChoosed;
	private ArrayList ListButton;
	private float ligthTimer;

	// Use this for initialization
	void Start () {
		_isPlayerTurn = false;
		_isOn = false;
		timerMax = 2;
		turn = 0;
		ligthTimer = 0;
		_isChoosed = false;
		length = LightButton.Length;
		ListButton = new ArrayList();
	}

	// Update is called once per frame
	void Update () {
		if (!_isChoosed)
		{
			turnMax = Random.Range(4, 6);
			print("turnMax = " + turnMax);
			_isChoosed = true;
		}
		IaTurn();
	}

	private void IaTurn()
	{
		int nbr = 0;
		if (!_isPlayerTurn)
		{
			ligthTimer = this.GetComponent<Timer>().GetStartimer();
			nbr = Random.Range(1, 4);
			TurnOnLight(nbr);
		}
		else if (ligthTimer <= 1)
		{
			LightOff();
		}
	}

	public void TurnOnLight(int nbr)
	{
		for (int i = 0; i < length && !_isOn; i++)
		{
			if (LightButton[i].GetComponent<Light>().isActiveAndEnabled)
				_isOn = true;
		}
		if (!_isOn && ligthTimer == timerMax)
		{
			if (turn == turnMax)
				_isPlayerTurn = true;
			else
			{
				LightButton[nbr].GetComponent<Light>().enabled = true;
				ListButton.Add(nbr);
				turn++;
			}
		}
		if (ligthTimer <= 1)
		{
			LightOff();
		}
	}

	public void PrintList()
	{
		foreach (int i in ListButton)
		{
			print(LightButton[i].name + " = " + i);
		}
	}

	public void LightOff()
	{
		foreach (GameObject Light in LightButton)
		{
			Light.GetComponent<Light>().enabled = false;
		}
		_isOn = false;
	}

	public bool GetIsPlayerTurn()
	{
		return _isPlayerTurn;
	}

	public void SetIsPlayerTurn(bool b)
	{
		_isPlayerTurn = b;
	}

	public ArrayList GetListButton()
	{
		return ListButton;
	}

	public GameObject[] GetLightObject()
	{
		return LightButton;
	}

	public void SetIsChoose(bool b)
	{
		_isChoosed = false;
	}

	public void SetTurn()
	{
		turn = 0;
	}

	public void ListClear()
	{
		ListButton.Clear();
	}
}
