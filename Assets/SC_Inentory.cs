using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Inentory : MonoBehaviour
{
    private bool _isFinish;

    private bool salad;
    private bool _bacon;
    private bool CHEESE;

    private void Awake()
    {
        GameEventSystem.OnPlayerPickUpCollectible += ASD;
    }

    private void OnDestroy()
    {
        GameEventSystem.OnPlayerPickUpCollectible -= ASD;
    }

    private void Update()
    {
        if (!(!salad && !_bacon && !CHEESE))
        {
            _isFinish = true;
            Debug.Log("FINISH!");
            SceneManager.LoadScene("Outro");
        }
    }
    

    public bool IsFinish
    {
        get => 
            _isFinish;
        set 
            => _isFinish 
                = value;
    }

    public bool Salad
    {
        get => salad;
        set {
            salad = value;
            GameEventSystem.UpdateScore("Salad");
        }
    }

    public bool Bacon
    {
        get => _bacon;
        set 
        {
            _bacon = value;
            GameEventSystem.UpdateScore("Bacon");
        }
    }

    public bool ChEESE //when writing this method i was eating some mac&cheese
    {
        get => CHEESE;
        set 
        {
            CHEESE = value;
            GameEventSystem.UpdateScore("Cheese");
        }
    }

    public void ASD(string value)
    {
        //todo maybe later i guess, too tired today, gonna watch some anime
    }
}
