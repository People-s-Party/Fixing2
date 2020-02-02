using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemInform : MonoBehaviour
{
    public int itemtype;
    public string needName = "";
    public string dialogueNum = "";
    public string sceneName;
    private void Start()
    {

    }
    private void OnEnable()
    {
        Messenger.AddListener<string>(Events.Epressed, action);
    }
    private void OnDisable()
    {
        Messenger.RemoveListener<string>(Events.Epressed, action);
    }
    void action(string name)
    {

        if (gameObject.name == name)
        {
            if (itemtype == 0)
            {
                bool hasPickedUp = false;
                if (needName == "")
                {
                    Messenger.Broadcast<string, Sprite>(Events.itemget, gameObject.name, GetComponent<SpriteRenderer>().sprite);
                    Destroy(this.gameObject);
                }
                else
                {
                    for (int i = 1; i < 8; i++)
                    {
                        GameObject invTemp = GameObject.Find("Inv" + i);
                        if (needName == invTemp.GetComponent<InventoryInform>().itemName)
                        {
                            Messenger.Broadcast<string, Sprite>(Events.itemget, gameObject.name, GetComponent<SpriteRenderer>().sprite);
                            hasPickedUp = true;
                            GameObject.Find("Ename").SetActive(false);
                            Destroy(this.gameObject);

                        }
                        else if(!hasPickedUp)
                        {
                            Messenger.Broadcast<string>(Events.Dialogue, dialogueNum);

                        }

                    }
                    
                }

            }
            if (itemtype == 1)
            {

            }
            if (itemtype == 2)
            {
                if (needName == "")
                {
                    Messenger.Broadcast<string>(Events.changeScene, sceneName);
                }
                else
                {
                    for (int i = 1; i < 8; i++)
                    {
                        GameObject invTemp = GameObject.Find("Inv" + i);
                        if (needName == invTemp.GetComponent<InventoryInform>().itemName)
                        {
                            Messenger.Broadcast<string>(Events.changeScene, sceneName);
                        }
                        else
                        {
                            Messenger.Broadcast<string>(Events.Dialogue, dialogueNum);

                        }

                    }
                }
            }
        }
    }
}
