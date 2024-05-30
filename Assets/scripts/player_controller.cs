using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using Photon.Pun;

public class player_controller : MonoBehaviour
{
    public float move_speed;
    Score_manager score_Manager;
    PhotonView view;

    private void Start() 
    {
      score_Manager = FindObjectOfType<Score_manager>();
      view = GetComponent<PhotonView>();
      
    }

    void Update()
    {
        if(view.IsMine)
        {
         //Player movement//
         float horizontal = Input.GetAxis("Horizontal");
         float vertical = Input.GetAxis("Vertical");
         transform.position += new Vector3(horizontal,vertical,0)*move_speed*Time.fixedDeltaTime;

         // to stop player from going outside the screen//
         transform.position =  new Vector3(Mathf.Clamp(transform.position.x,-8.5f,8.5f),Mathf.Clamp(transform.position.y,-4.5f,4.5f),transform.position.z);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("coin")){
            Destroy(other.gameObject);
            score_Manager.score++;
            score_Manager.text.text = score_Manager.score.ToString();// for upadating the score ui //
        }
    }
}
