using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance = null;

    //public float money;
    public GameObject Player;
    public Transform respawnPoint;
    //public GameObject playerPrefab;

    public int score;

    public Text ScoreText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        else if (Instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        ScoreText.text = ("Score: " + score);
    }

    //public void CoinCollected()
    //{
        //money += 1;
    //}

    public void Respawn()
    {
        MobileHealthController.Instance.Health();


        Player.transform.position = respawnPoint.position;
    }
}