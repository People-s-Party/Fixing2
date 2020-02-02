using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanges : MonoBehaviour
{
    Transform TFS;
    private void OnEnable()
    {
    }
    void changeS(string name)
    {
        if (name == gameObject.scene.name){
            gameObject.GetComponentsInChildren<Transform>();
        }
    }
}
