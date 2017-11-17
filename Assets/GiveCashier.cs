using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveCashier : MonoBehaviour {

    public Text text;

    public GenerateMoney MoneyDue;

    public float Money;

    // Use this for initialization
    void Start () {
        GiveMeMoney();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GiveMeMoney()
    {
        Money = GenerateAmount();

        if (Money >= MoneyDue.Money)
        {
            text.text = "$" + Money.ToString();
        }
        else if (Money < MoneyDue.Money)
        {
            Money = GenerateAmount();
        }
    }

    private float GenerateAmount()
    {
        Money = Random.Range(1, 21);

        Money = Mathf.Round(Money);
        return Money;
    }
}
