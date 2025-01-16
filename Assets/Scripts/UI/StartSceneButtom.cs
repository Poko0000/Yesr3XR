using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneButtom : MonoBehaviour
{
    public void ToGameButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
