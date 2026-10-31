using UnityEngine;

public class CageTrigger : MonoBehaviour
{
    public GameLogic GL; // reference GameLogic Scripts
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Rabbit"){
            GL.GameState = "Step6";
            // Step 6 - Show Rabbit / Place Rabbit in Cage
            // Show Finish UI
            // Turn off Rabbit Grabbale
            // Change GameState to Step 6 Wait - End Training Module 
        }
    }
}
