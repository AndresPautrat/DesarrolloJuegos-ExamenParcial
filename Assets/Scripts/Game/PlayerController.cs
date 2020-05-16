using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField]
    private GameObject uno;
    [SerializeField]
    private GameObject dos;
    [SerializeField]
    private GameObject tres;
    [SerializeField]
    private GameObject cuarto;
    [SerializeField]
    private GameObject quinto;
    void Start()
    {
        //string monster = JSON.decode(PlayerPref.GetIntentExtra("player"));
        string monster = PlayerPrefs.GetString("player");
        GameObject monsterGO = new GameObject();
        if(monster == "1" ){
            monsterGO = uno;
        }
        if(monster == "2"){
            monsterGO = dos;
        }
        if(monster == "3"){ 
            monsterGO = tres;
        }
        if(monster == "4"){
            monsterGO = cuarto;
        }
        if (monster == "5")
        {
            monsterGO = quinto;
        }
        Instantiate(monsterGO, gameObject.transform.position, Quaternion.identity);
        //Creation(monsterGO,position,identity);
    }

}
