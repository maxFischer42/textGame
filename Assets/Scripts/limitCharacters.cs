using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class limitCharacters : MonoBehaviour {

    public Text text; 

    public void clearHistory()
    {
        text.text = "";
    }

}
