using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int playerStrength = 1;
    public int playerIntellect = 1;
    public int playerHealth = 1;

    public Text displayText;
    public InputAction[] inputActions;

    [HideInInspector] public RoomNavigation roomNavigation;
    [HideInInspector] public List<string> interactionDescriptionsInRoom = new List<string>();
    [HideInInspector] public InteractableItems interactableItems;

    List<string> actionLog = new List<string>();


    // Use this for initialization
    void Awake()
    {
        interactableItems = GetComponent<InteractableItems>();
        roomNavigation = GetComponent<RoomNavigation>();
    }

    void Start()
    {
        PlayerPrefs.SetInt("score", 10000);
        DisplayRoomText();
        DisplayLoggedText();
    }

    public void DisplayLoggedText()
    {

        string logAsText = string.Join("\n", actionLog.ToArray());

        displayText.text = logAsText;
    }

    public void DisplayRoomText()
    {

        

        ClearCollectionsForNewRoom();

        UnpackRoom();

        string joinedInteractionDescriptions = string.Join("\n", interactionDescriptionsInRoom.ToArray());

        string combinedText = "";

        /*if (roomNavigation.currentRoom.name == "Throne" && !interactableItems.nounsInInventory.Contains("blade"))
        {
            combinedText = combinedText + " The knight sees you with no weapons and slays you on the spot. You lose.";
        }
        else
        {*/
        combinedText = roomNavigation.currentRoom.description + "\n" + joinedInteractionDescriptions;
        
        if (displayText.text.Length > 15000)
        {
            Debug.Log("cleared history to not cause errors");
            GetComponent<limitCharacters>().clearHistory();
            actionLog = new List<string>();
        }
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") - (PlayerPrefs.GetInt("score") / 15));
        LogStringWithReturn(combinedText);

    }




    public void DisplayStats()
    {
        LogStringWithReturn("Current Stats: \n Strength " + playerStrength + "\n Intellect " + playerIntellect + "\n Health " + playerHealth);


    }

    void UnpackRoom()
    {
        roomNavigation.UnpackExitsInRoom();
        PrepareObjectsToTakeOrExamine(roomNavigation.currentRoom);

        

    }

    void PrepareObjectsToTakeOrExamine(Room currentRoom)
    {
        for (int i = 0; i < currentRoom.interactableObjectsInRoom.Length; i++)
        {
            string descriptionNotInInventory = interactableItems.GetObjectsNotInInventory(currentRoom, i);
            if (descriptionNotInInventory != null)
            {
                interactionDescriptionsInRoom.Add(descriptionNotInInventory);
            }

            InteractableObject interactableInRoom = currentRoom.interactableObjectsInRoom[i];

            for (int j = 0; j < interactableInRoom.interactions.Length; j++)
            {
                Interaction interaction = interactableInRoom.interactions[j];
                if (interaction.inputAction.keyWord == "examine")
                {
                    interactableItems.examineDictionary.Add(interactableInRoom.noun, interaction.textResponse);
                }

                if (interaction.inputAction.keyWord == "take")
                {
                    interactableItems.takeDictionary.Add(interactableInRoom.noun, interaction.textResponse);
                }

            }
        }
    }

    public string TestVerbDictionaryWithNoun(Dictionary<string, string> verbDictionary, string verb, string noun)
    {
        if (verbDictionary.ContainsKey(noun))
        {
            return verbDictionary[noun];
        }

        return "You can't " + verb + " " + noun;
    }

    void ClearCollectionsForNewRoom()
    {
        interactableItems.ClearCollections();
        interactionDescriptionsInRoom.Clear();
        roomNavigation.ClearExits();
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }
}