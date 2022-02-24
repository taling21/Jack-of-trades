using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour{

private int tScore= 0;

  public void UpdateScore(int score)
  {
     tScore+=score;
  }

   public void OnGUI()
   {
     GUI.contentColor = Color.yellow;
     GUI.Box(new Rect(5, 5, 20, 20), "Score: " + tScore);
   }
}