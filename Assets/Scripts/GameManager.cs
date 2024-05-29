using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private int level;
    private int lives;
    private int score;

    private void Start(){
        DontDestroyOnLoad(gameObject);
        NewGame();
    }

    private void NewGame(){
        lives = 3;
        score = 0;
        LoadLevel(1);
    }

    private void LoadLevel(int index){
        level = index;
        Camera camera = Camera.main;
        if (camera != null) {
            camera.cullingMask = 0;
        }

        //Invoke(nameof(LoadScene), 1f);
    
    }

    private void LoadScene(){
        SceneManager.LoadScene(level);
    }

    public void LevelComplete(){
        score += 1000; 
        int nextLevel = level + 1;
        //LoadLevel(nextLevel);

        if(score == 1000){
            SceneManager.LoadScene("GoodEnding");
        }
    }

    public void LevelFailed(){
        lives--;
        if(lives <= 0){
            SceneManager.LoadScene("BadEnding");
            NewGame();
        }
        else{
            SceneManager.LoadScene("Level1");
        }
    }
}
