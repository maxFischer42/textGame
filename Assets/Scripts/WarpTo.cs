using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/ActionResponses/WarpRoom")]
public class WarpTo : ActionResponse {
    public Room roomToChangeTo;

    public override bool DoActionResponse(GameController controller)
    {
            controller.roomNavigation.currentRoom = roomToChangeTo;
            controller.DisplayRoomText();
            return true;
    }

}
