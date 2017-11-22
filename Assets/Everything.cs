using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Everything : MonoBehaviour {

    double Subtotal, CustomerMoney, Total;

    public Text SubtotalDisplay, CustomerDisplay, ChangeGiven, Statistics;

    private int Correct, Incorrect;

	// Use this for initialization
	void Start () {
        Reset();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        ChangeGiven.text = Total.ToString("C");
	}

    void GenerateSubtotal()
    {
        int Pos1, Pos2, Pos3;
        string combinePos;

        Pos1 = UnityEngine.Random.Range(0, 10);
        Pos2 = UnityEngine.Random.Range(0, 10);
        Pos3 = UnityEngine.Random.Range(0, 10);

        combinePos = Pos1.ToString() + Pos2.ToString() + Pos3.ToString();

        Subtotal = double.Parse(combinePos) / 100;

        SubtotalDisplay.text = Subtotal.ToString("C");
    }

    void GenerateCustomer()
    {

        CustomerMoney = UnityEngine.Random.Range(0, 21);

        if (CustomerMoney <= Subtotal)
        {
            GenerateCustomer();
        } else
        {
            CustomerDisplay.text = CustomerMoney.ToString("C");
        }
    }

    public void AddToTotal(float amount)
    {
        Total += amount;
    }

    public void VoidTransaction()
    {
        Total = 0;
    }

    public void FinishTransaction()
    {
        Total = Math.Round(Total, 2);
        Subtotal = Math.Round(Subtotal, 2);
        CustomerMoney = Math.Round(CustomerMoney, 2);

        if ((Total + Subtotal) == CustomerMoney)
        {
            Correct++;
            Reset();
        }
        else
        {
            Incorrect++;
            Reset();
        }
    }

    private void Reset()
    {
        Statistics.text = "Correct: " + Correct +  " \n Incorrect: " + Incorrect;
        Total = 0;
        GenerateSubtotal();
        GenerateCustomer();
    }
}
