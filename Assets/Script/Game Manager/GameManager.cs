using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player,game_over;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void Update()
    {
        if (!player)
        {
            Time.timeScale = 0;
            game_over.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
