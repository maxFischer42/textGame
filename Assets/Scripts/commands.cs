using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/commands")]
public class commands : InputAction
{

    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        controller.LogStringWithReturn("Commands: \n go \n take \n examine \n use \n inventory \n commands \n quit \n Press up arrow to clone previous command \n all commands are 1 word long or 2 words long.");
    }
}