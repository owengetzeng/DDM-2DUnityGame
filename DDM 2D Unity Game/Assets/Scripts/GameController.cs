using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    int progressAmount;
    public Slider progressSlider;
    public GameObject loadCanvas;


    public GameObject gameOverScreen;
    public TMP_Text survivedText;
    private int survivedLevelsCount;

    [SerializeField] private PlayerMovement movementScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        progressAmount = 0;
        PlayerHealth.OnPlayedDied += GameOverScreen;
        loadCanvas.SetActive(false);
        gameOverScreen.SetActive(false);
    }

    void GameOverScreen()
    {
        gameOverScreen.SetActive(true);

    }


    public void ResetGame()
    {
        gameOverScreen.SetActive(false);
        movementScript.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
