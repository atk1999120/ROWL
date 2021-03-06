using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public Dialogue Dialogue;

    public GameFlagDefine.GameFlag GameFlag;

    private void OnTriggerEnter(Collider other)
    {
        if (!GameFlagDefine.GetGameFlag(GameFlag))
        {
            GameFlagDefine.SetGameFlag(GameFlag);
        }
        else
        {
            return;
        }
        Dialogue.DisplayDialogue("正面玄関の鍵を取得した");
    }
}