using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class coin_spawner : MonoBehaviour
{
    public GameObject coin;
     
    float minX = -8.5f;
    float maxX = 8.5f;
    float minY = -4.5f;
    float maxY = 4.5f;
    
    void Start()
    {
       Instantiate();     
    }

    void Instantiate(){      
        for (int i = 0; i < 15; i++)
        {
            Vector2 random_pos = new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxY));
            PhotonNetwork.Instantiate(coin.name,random_pos,Quaternion.identity);
              
        }        
    }

    
}
