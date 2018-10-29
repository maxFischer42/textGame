using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Quit")]
public class quit : InputAction
{


    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        Application.Quit();
    }
}