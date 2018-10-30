using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class up : MonoBehaviour {

    public InputField go;
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            go.text = PlayerPrefs.GetString("record");
            Debug.Log("Copied line :" + PlayerPrefs.GetString("record"));
        }
	}
}
