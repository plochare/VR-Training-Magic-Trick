using UnityEngine;

public class HatTrigger : MonoBehaviour
{
    public GameLogic GL; // reference GameLogic Scripts

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Tophat" && GL.GameState == "Step2Wait"){
            GL.GameState = "Step3";
            // Step 3 : Return Hat to table
            // Show UI
            // Disable Hat Movavble
            // Change GameState to Step 3 Wait
        }
    }
    
}

