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
		//initialisez les variables qu'il ne le sont pas (mettre les valeur par défaut)
		_isPlayerTurn = ;
		_isOn = ;
		timerMax = 2;
		turn = 0;
		ligthTimer = 0;
		_isChoosed = ;
		length = LightButton.Length;
		ListButton = new ArrayList();
	}

	// Update is called once per frame
	void Update () {
		if (!_isChoosed)
		{
			//réalisez un random entre 1 et 4, indice : Random. ;
			turnMax = ;
			//affichez le résultat de ce random grâce à la fonction, indice : "print("texte" + ma variable)";
			print();
			_isChoosed = true;
		}
		//appellez la fonction "IaTurn";

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
		// réalisez un "for" avec la condition : "tant que i inférieure à length
		for ()
		{
			if (LightButton[/*remplacer ce commentaire ma votre variable créé dans le "for"*/].GetComponent<Light>().isActiveAndEnabled)
				_isOn = true;
		}
		//réalisez un "if" avec pour condition : "si _isOn est égale à "false" et si la variable ligthTimer est égale à la variable timerMax"
		if ()
		{
			if (turn == turnMax)
				_isPlayerTurn = true;
			else
			{
				//complétez l'instruction ci-dessous, indice : tu dois activer le composant si dessous"
				LightButton[nbr].GetComponent<Light>(). ;
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

	//Réaliser les "Getter" et "Setter" des variables "_isPlayerTurn" et "SetIsChoose" /!\ ne pas oublier de mettre "public" devant la fonction" 

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

	public void SetTurn()
	{
		turn = 0;
	}

	public void ListClear()
	{
		ListButton.Clear();
	}
}
