using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanges : MonoBehaviour
{
    private void OnEnable()
    {
        Messenger.AddListener<string>(Events.changeScene, changeS);
    }
    private void OnDisable()
    {
        Messenger.RemoveListener<string>(Events.changeScene, changeS);
    }
    void changeS(string name)
    {
        if (name == gameObject.scene.name){
            for (int a = 0; a < transform.childCount; a++)
            {
                transform.GetChild(a).gameObject.SetActive(true);
            }
        }
        else
        {
            for (int a = 0; a < transform.childCount; a++)
            {
                transform.GetChild(a).gameObject.SetActive(false);
            }
        }
    }
}
