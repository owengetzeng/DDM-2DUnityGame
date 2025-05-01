using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameController : MonoBehaviour
{
    int progressAmount;
    public Slider progressSlider;
    public GameObject loadCanvas;


    public GameObject gameOverScreen;
    public TMP_Text survivedText;
    private int survivedLevelsCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        progressAmount = 0;
        Gem.OnGemCollect += IncreaseProgressAmount;
        PlayerHealth.OnPlayedDied += GameOverScreen;
        loadCanvas.SetActive(false);
        gameOverScreen.SetActive(false);
    }

    void IncreaseProgressAmount(int amount)
    {
        progressAmount += amount;
        progressSlider.value = progressAmount;
        if(progressAmount >= 100)
        //Level Complete
        Debug.Log("Level Complete"); 
        
    }

    void GameOverScreen()
    {
        gameOverScreen.SetActive(true);
        survivedText.text = "YOU SURVIVED " + survivedLevelsCount + " LEVEL";
        if(survivedLevelsCount != 1) survivedText.text += "S";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
{
    Gem.OnGemCollect -= IncreaseProgressAmount;
    PlayerHealth.OnPlayedDied -= GameOverScreen;
}
}
