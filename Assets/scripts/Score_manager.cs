using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score_manager : MonoBehaviour
{
   public TextMeshProUGUI text;
   public int score = 0;
   
    void Start()
    {
        text.text = score.ToString();
    }

}
