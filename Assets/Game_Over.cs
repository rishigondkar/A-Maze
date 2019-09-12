using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Game_Over : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("AAAGameobject").SendMessage("Finish");
    }
}
