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
        Invoke("DoorFinal",0.05f);
        if (GetComponent<DoorInform>().doorDir == "left") GameObject.Find("Player").transform.position = new Vector3(8, 0, 0);
        if (GetComponent<DoorInform>().doorDir == "right") GameObject.Find("Player").transform.position = new Vector3(-10, 0, 0);
        if (GetComponent<DoorInform>().doorDir == "up") GameObject.Find("Player").transform.position = new Vector3(0, -5, 0);
        if (GetComponent<DoorInform>().doorDir == "down") GameObject.Find("Player").transform.position = new Vector3(0, 5, 0);
    }
    void DoorFinal()
    {
        GetComponent<AudioSource>().Play();        
    }
}
