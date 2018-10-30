using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Lick")]
public class Lick : InputAction
{

    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        controller.interactableItems.Lick(separatedInputWords);
    }

}