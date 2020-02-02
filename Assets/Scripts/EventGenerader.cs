using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventGenerader : MonoBehaviour
{
    public Transform PrefabForEvent;
    public Transform MainObject;
    private void OnEnable()
    {
        Messenger.AddListener<string>(Events.EventHappened, MakeEvent);
    }
    private void OnDisable()
    {
        Messenger.AddListener<string>(Events.EventHappened, MakeEvent);
    }
    void MakeEvent(string name)
    {
        if(name == "heart")
        {
            Vector3 Place = new Vector3(-4.8f, 2.14f);
            Instantiate(PrefabForEvent,Place,Quaternion.identity,MainObject);
            Messenger.Broadcast<string>(Events.Dialogue, "AfterBraveHeart");
            
        }
    }
}
