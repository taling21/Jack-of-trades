using UnityEngine;
using UnityEngine.SceneManagement;
public class PQ : MonoBehaviour
{
    public void play()
    {
        Debug.Log("playing");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);

    }
    public void quit(){
        Debug.Log("quitting");
        Application.Quit();
        
    }
}
