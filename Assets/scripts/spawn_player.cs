using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawn_player : MonoBehaviour
{
    public GameObject player_prefeb;

    float minX = -8.5f;
    float maxX = 8.5f;
    float minY = -4.5f;
    float maxY = 4.5f;

    void Start()
    {
        Vector2 randomPos = new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxY));
        PhotonNetwork.Instantiate(player_prefeb.name,randomPos,Quaternion.identity);
    }

    
}
