﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInform : MonoBehaviour
{
    public int itemtype;
    public string needName = "";
    public int dialogueNum = 0;
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
                if (needName == "")
                {
                    Debug.Log(gameObject.name);
                    Debug.Log(GetComponent<SpriteRenderer>().sprite);
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
                            Destroy(this.gameObject);

                        }

                    }
                }

            }
        }
    }
}