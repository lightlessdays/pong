using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private int computerScore = 0;
    [SerializeField]
    private Text _text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            if (Time.timeScale != 0)
                Time.timeScale = 0;
            else
                 Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(0);
        }
    }



    public void ComputerScore()
    {
        computerScore++;
        _text.text = computerScore.ToString();
    }
}
