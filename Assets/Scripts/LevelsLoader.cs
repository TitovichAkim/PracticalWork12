using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsLoader : MonoBehaviour
{
    public Text     levelNumberText;
    private void Start ()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)                                 // Для того, чтобы защитить от ошибки, что не найден текст номера уровня
        {
            levelNumberText.text = $"LEVEL {SceneManager.GetActiveScene().buildIndex}";    // Вот такой штуке научился в курсе по C#, пока отсутствовал ))) 
        }
    }
    public void StartLevel (int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
    public void RestartLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
