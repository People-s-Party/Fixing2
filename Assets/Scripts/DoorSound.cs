using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        Messenger.AddListener<string,string>(Events.changeScene, PlaySound);
    }

    void PlaySound(string name,string sth)
    {
        Invoke("DoorFinal",0.05f);
    }
    void DoorFinal()
    {
<<<<<<< HEAD
        GetComponent<AudioSource>().Play();
        if (GetComponent<DoorInform>().doorDir == "left") GameObject.Find("Player").transform.position = new Vector3(8, 0, 0);
        else if (GetComponent<DoorInform>().doorDir == "right") GameObject.Find("Player").transform.position = new Vector3(-10, 0, 0);
        else if (GetComponent<DoorInform>().doorDir == "up") GameObject.Find("Player").transform.position = new Vector3(0, -5, 0);
        else if (GetComponent<DoorInform>().doorDir == "down") GameObject.Find("Player").transform.position = new Vector3(0, 5, 0);

=======
        GetComponent<AudioSource>().Play();        
>>>>>>> 775661e03b8ab4bd524be3b7707856c916e3de5b
    }
}
