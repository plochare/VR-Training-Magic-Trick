using UnityEngine;

public class WandTrigger : MonoBehaviour
{
    public GameLogic GL; // reference GameLogic Scripts
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "MagicWand"){
            GL.GameState = "Step4";
            // Step 4 : Wave Wand Over Hat
            // Show Next UI
            // Enable Rabbit Movavble
            // Change GameState to Step 4 Wait- Grab Rabbit from Hat
        }
    }
}
