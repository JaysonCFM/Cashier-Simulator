using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateMoney : MonoBehaviour {

    public Text text;

    public float Money;

    // Use this for initialization
    void Start () {
        Transaction();
	}

    public void Transaction()
    {
        Money = Random.Range(0.00f, 10.00f);

        Money = Mathf.Round(Money * 100f) / 100f;

        text.text = Money.ToString("C");
    }
}
