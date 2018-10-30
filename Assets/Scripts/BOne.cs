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
            GameObject.FindGameObjectWithTag("BG1").GetComponent<SpriteRenderer>().enabled = true;
        }

        return false;
    }
}