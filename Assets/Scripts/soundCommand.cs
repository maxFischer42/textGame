using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Sound")]
public class soundCommand : InputAction
{
    public AudioClip Aud;
    public GameObject refer;

    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        GameObject ne = (GameObject)Instantiate(refer,Vector2.zero,Quaternion.identity);
        ne.GetComponent<AudioSource>().PlayOneShot(Aud);
        Destroy(ne,6.5f);
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + (PlayerPrefs.GetInt("score") / 100));
    }
}