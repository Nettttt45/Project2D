using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour  
{
    [SerializeField] GameObject pauseMenu;

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0; 
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1; 
    }

    public void Home()
    {
        Time.timeScale = 1; 
        SceneManager.LoadScene("Main Menu");
    }

    public void Restart()
    {
        Time.timeScale = 1; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

