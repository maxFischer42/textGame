/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Eat")]
public class Eat : InputAction {

    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        Dictionary<string, string> takeDictionary = controller.interactableItems.Eat(separatedInputWords);

        if (takeDictionary != null)
        {
            controller.LogStringWithReturn(controller.TestVerbDictionaryWithNoun(takeDictionary, "eat", separatedInputWords[1]));
        }
    }

}*/
