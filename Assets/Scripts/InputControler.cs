using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControler : MonoBehaviour
{
    private AnimationControler animationControler;
    private GameplayControler gameplayControler;


    private string playerChoice;


    void Awake()
    {
        animationControler = GetComponent<AnimationControler>();
        gameplayControler = GetComponent<GameplayControler>();
    }

    public void GetChoice()
    {
        string choiceName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        GameChoices selectedChoice  = GameChoices.NONE;

        switch (choiceName)
        {
            case "Rock":
                selectedChoice = GameChoices.ROCK;
                break;

            case "Paper":
                selectedChoice = GameChoices.PAPER;
                break;

            case "Scissors":
                selectedChoice = GameChoices.SCISSORS;
                break;

    
        }


        gameplayControler.SetChoices(selectedChoice);
        
        animationControler.PlayerMadeChoice();
    }






}
