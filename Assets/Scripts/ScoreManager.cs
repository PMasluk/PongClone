using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    [SerializeField]
    private TextMeshProUGUI scoreTextPlayer;
    [SerializeField]
    private TextMeshProUGUI scoreTextComputer;

    private int scorePlayer;
    private int scoreComputer;

    public void AddPointPlayer()
    {
        scorePlayer++;
        ScorePlayerUpdate();
    }

    private void ScorePlayerUpdate()
    {
        scoreTextPlayer.text = scorePlayer.ToString();
    }

    public void AddPointComputer()
    {
        scoreComputer++;
        ScoreComputerUpdate();
    }

    private void ScoreComputerUpdate()
    {
        scoreTextComputer.text = scoreComputer.ToString();
    }
}
