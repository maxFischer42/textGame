using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/GameEnd")]
public class GameEnd : InputAction
{
    

    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        GameObject.FindGameObjectWithTag("BG").GetComponent<SpriteRenderer>().enabled = true;
    }

}