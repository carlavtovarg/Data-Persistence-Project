using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public TMP_InputField namePlayer;
    public TMP_Text scoreText;

    public void NewNameEntered(string name) {
        Debug.Log(name);
        MenuHandler.Instance.nameEntered = name;
    }

    // Start is called before the first frame update
    void Start()
    {
        MenuHandler.Instance.ReadName();
        BestScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BestScore() {
        string bestScore = "Best Score: " + MenuHandler.Instance.namePlayer + " : " + MenuHandler.Instance.score;
        scoreText.text = bestScore;
    }
}
