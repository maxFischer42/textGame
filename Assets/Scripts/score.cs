using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Score")]
public class score : InputAction
{
    public int m_score = 10000;

    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        controller.LogStringWithReturn("Your current score = " + PlayerPrefs.GetInt("score"));
    }
}