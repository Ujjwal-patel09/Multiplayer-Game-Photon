using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;


public class create_and_join_room : MonoBehaviourPunCallbacks
{
   public TMP_InputField create_input;
   public TMP_InputField join_input;

   public void createRoom()
   {
      PhotonNetwork.CreateRoom(create_input.text);
   }

   public void JoinRoom()
   {
      PhotonNetwork.JoinRoom(join_input.text);
   }

   public override void OnJoinedRoom()
   {
      PhotonNetwork.LoadLevel("play");
   }
}
