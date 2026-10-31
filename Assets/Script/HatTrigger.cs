using UnityEngine;

public class HatTrigger : MonoBehaviour
{
    public GameLogic GL; // reference GameLogic Scripts

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Tophat"){
            GL.GameState = "Step2";
            // Step 2 : Show Hat to Audience
            // Show UI
            // Change GameState to Step 2 Wait
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Tophat"){
            GL.GameState = "Step3";
            // Step 3 : Return Hat to table
            // Show UI
            // Disable Hat Movavble
            // Change GameState to Step 3 Wait
        }
    }
}

