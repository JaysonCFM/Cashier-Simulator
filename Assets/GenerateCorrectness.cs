using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateCorrectness : MonoBehaviour {

    public Text text;

    public int Correct, Incorrect;

    public float Average;
	
	// Update is called once per frame
	void Update () {
        text.text = "Correct: " + Correct.ToString() + " Incorrect: " + Incorrect.ToString() + " % Correct: " + Average.ToString();
	}
}
