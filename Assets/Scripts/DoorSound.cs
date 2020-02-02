using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        Messenger.AddListener<string>(Events.changeScene, PlaySound);
    }

    void PlaySound(string name)
    {
        GetComponent<AudioSource>().Play();
    }
}
