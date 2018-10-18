using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Stats")]
public class Stats : InputAction
{
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        controller.DisplayStats();
    }
}