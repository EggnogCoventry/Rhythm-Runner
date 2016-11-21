using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour
{

    public Canvas MainMenu;
    public Canvas DifficultyMenu;
    public bool EasyDifficulty = false;
    public bool MediumDifficulty = false;
    public bool HardDifficulty = false;

    // Use this for initialization
    void Start()
    {
        hidedifficultymenu();
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void PauseButton()
    {
        Time.timescale = 0.0f;
        MainMenu.enabled = true;
     }
    
    public void PlayButton()
    {
        Time.timescale = 1.0f;
        DifficultyMenu.enabled = false;
        MainMenu.enabled = false;
    }
    public void showdifficultymenu()
    {
        DifficultyMenu.enabled = true;
        MainMenu.enabled = false;
    }

    public void hidedifficultymenu()
    {
        DifficultyMenu.enabled = false;
        MainMenu.enabled = true;
    }

    public void optionsbuttonpressed()
    {
        showdifficultymenu();
    }

    public void easydifficulty()
    {
        EasyDifficulty = true;
        hidedifficultymenu();
    }

    public void mediumdifficulty()
    {
        MediumDifficulty = true;
        hidedifficultymenu();
    }

    public void harddifficulty()
    {
        HardDifficulty = true;
        hidedifficultymenu();
    }
}
