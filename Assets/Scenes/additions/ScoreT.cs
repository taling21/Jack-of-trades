using UnityEngine;
using UnityEngine.UI;
public class ScoreT : MonoBehaviour
{  
    public bool tr=false;
    public int sc=0; 
    public Text score;
    public ScoreManager t;
    void Start(){
        
    }
    public void Try()
    {
        tr=true;
    }
    void Update(){
            if(tr==true){
            sc=t.GetScore();
            tr=false;}

    }
    
    void FixedUpdate()
    {   
        
        score.text = sc.ToString();
    }
    
}
