using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelsLoader : MonoBehaviour
{
    public Text     levelNumberText;
    private void Start ()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)                                 // ��� ����, ����� �������� �� ������, ��� �� ������ ����� ������ ������
        {
            levelNumberText.text = $"LEVEL {SceneManager.GetActiveScene().buildIndex}";    // ��� ����� ����� �������� � ����� �� C#, ���� ������������ ))) 
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
