using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{  

    public state currentState;
    // Update is called once per frame
    void Update()
    {
                
    }

    private void RunStateMachine(){
        //Run current state which will return the next state
        //Switch to the next state, repeat.
        state nextState = currentState?.RunCurrentState();
        if (nextState !=null){
            //Switch to next state
            SwitchToNextState(nextState);
        }

    }

    private void SwitchToNextState(state nextState){
        currentState =  nextState;
    }
}
