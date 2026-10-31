using UnityEngine;

public class BunnyTrigger : MonoBehaviour
{
    public GameLogic GL; // reference GameLogic Scripts

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Rabbit"){
            GL.GameState = "Step5";
            // Step 5 - Grab Rabbit from Hat
            // Show Next UI
            // Show Rabbit GameObject Visible
            // Change GameState to Step 5 Wait - Show Rabbit to Audience
        }
    }
}
