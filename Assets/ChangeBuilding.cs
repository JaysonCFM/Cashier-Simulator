using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBuilding : MonoBehaviour {

    public float ChangeSoFar;

    public Text text;

    public bool IsDisplay;

    public GenerateMoney howMuchYouStarted;

    public GiveCashier customerChange;

    public GenerateCorrectness calculations;

    private void Update()
    {
        if (IsDisplay)
        {
            DisplayChange();
        }
    }

    public void AddChangeToAmount(float AddChange)
    {
        ChangeSoFar += AddChange;
    }

    private void DisplayChange()
    {
        text.text = ChangeSoFar.ToString("C");
    }

    public void EndTransaction()
    {
       if (howMuchYouStarted.Money + ChangeSoFar == customerChange.Money)
        {
            ChangeSoFar = 0;
            calculations.Correct++;
            howMuchYouStarted.Transaction();
        }
       else if (howMuchYouStarted.Money + ChangeSoFar < customerChange.Money)
        {
            calculations.Incorrect++;
            ChangeSoFar = 0;
            howMuchYouStarted.Transaction();
        }
        else if (howMuchYouStarted.Money + ChangeSoFar > customerChange.Money)
        {
            calculations.Incorrect++;
            ChangeSoFar = 0;
            howMuchYouStarted.Transaction();
        }
    }
}
