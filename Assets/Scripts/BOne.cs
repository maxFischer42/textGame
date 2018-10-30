using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/ActionResponses/Bone")]
public class BOne : ActionResponse
{
    public string requiredString;


    public override bool DoActionResponse(GameController controller)
    {
        if (controller.roomNavigation.currentRoom.roomName == requiredString)
        {
            GameObject.Find("tenor2_0").GetComponent<SpriteRenderer>().enabled = true;
            controller.LogStringWithReturn("Here is a present!");
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("Score") + 3500);
            return true; 
        }

        return false;
    }
}