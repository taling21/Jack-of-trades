using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Over : MonoBehaviour
{
    public AudioSource aa;
    public CanvasGroup cg;
    bool notPlayed=true;
    float timer=0f;
    float ff=0;
    public bool game_ended = false;
    public static float restart_delay =5f;
    public void EndGame()
    {
        if(!game_ended){
            game_ended = true;
        }
    }
    void Update(){
        if(game_ended)
        {
            timer+=Time.deltaTime;
            cg.alpha=timer/ff;
            if(notPlayed)
            {
                aa.Play();
                notPlayed=false;
            }
        }
    }
}
