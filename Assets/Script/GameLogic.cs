using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // Game State Engine for VR Training Module

    public string GameState = "Initialize";

    // Create varible references to Gameobject, Grabbables, UI
    // Grabbables
    public GameObject topHatObj;
    public GameObject wandObj;
    public GameObject bunnyObj;

    // Render Objects
    public GameObject bunnyRenderObj;

    // Sensors
    public GameObject hatSensorObj;
    public GameObject wandSensorObj;
    public GameObject bunnySendorObj;
    public GameObject cageSendorObj;

    // UI Screens
    public GameObject screen0Obj;
    public GameObject screen1Obj;
    public GameObject screen2Obj;
    public GameObject screen3Obj;
    public GameObject screen4Obj;
    public GameObject screen5Obj;

    void Start()
    {
        // Set Initial Step 0 - Start Screen
        // Disable every Grabbable
        topHatObj.GetComponent<Oculus.Interaction.Grabbable>().enabled = false;
        wandObj.GetComponent<Oculus.Interaction.Grabbable>().enabled = false;
        bunnyObj.GetComponent<Oculus.Interaction.Grabbable>().enabled = false;
        // Hide all UI Screens first
        HideAllUIScreens();
        // Show first UI screen with Start Button
        screen0Obj.SetActive(true);
        GameState = "Step0Wait";
    }

    void HideAllUIScreens(){
        screen0Obj.SetActive(false);
        screen1Obj.SetActive(false);
        screen2Obj.SetActive(false);
        screen3Obj.SetActive(false);
        screen4Obj.SetActive(false);
        screen5Obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch(GameState){
            case "Step0Wait":
                // Waiting for Start Button OnClick event
                break;
            case "Step1":
                // Show Step 1 UI screen
                HideAllUIScreens();
                screen1Obj.SetActive(true); // Show Hat UI
                // make Hat Grabbable
                topHatObj.GetComponent<Oculus.Interaction.Grabbable>().enabled = true;
                GameState = "Step1Wait";
                break;
            case "Step1Wait":
                // Waiting for HatTrigger OnExit
                // Lift Hat from Table
                break;
            case "Step2":
                // Could Include Another UI / Feedback here
                GameState = "Step2Wait";
                break;
            case "Step2Wait":
                // Waiting for HatTrigger OnEnter - Return Hat to table
                // make Hat not Grabbable
                topHatObj.GetComponent<Oculus.Interaction.Grabbable>().enabled = false;
                break;
            case "Step3":
                // Show Step 3 UI screen
                HideAllUIScreens();
                screen2Obj.SetActive(true); // Wave Wand UI
                // make Wand Grabbable
                wandObj.GetComponent<Oculus.Interaction.Grabbable>().enabled = true;
                GameState = "Step3Wait";
                break;
            case "Step3Wait":
                // Waiting for WandTrigger OnEnter
                break;
            case "Step4":
                // Show Step 4 UI screen
                HideAllUIScreens();
                screen3Obj.SetActive(true); // Grab Bunny UI
                // make Bunny Grabbable
                bunnyObj.GetComponent<Oculus.Interaction.Grabbable>().enabled = true;
                GameState = "Step4Wait";
                break;
            case "Step4Wait":
                // Waiting for Grab Event
                // Waiting for BunnyTrigger OnExit
                break;
            case "Step5":
                // Make Bunny Visible when it exits hat
                bunnyRenderObj.SetActive(true);
                // Show Step 5 UI screen 
                HideAllUIScreens();
                screen4Obj.SetActive(true); // TA DA! UI
                GameState = "Step5Wait";
                break;
            case "Step5Wait":
                // Waiting for cageTrigger OnEnter
                break;
            case "Step6":
                // Show Step 6 UI screen
                HideAllUIScreens();
                screen5Obj.SetActive(true); // Finish Module! UI
                GameState = "Step6Wait";
                break;
            case "Step6Wait":
                // Waiting for Restart Button
                break;
        }
    }

    // Start Button Click Event
    public void StartVRModule(){
        GameState = "Step1";
    }

    // Bunny Grab Select Event
    public void RabbitSelected(){
        // Play Audio or Show Particle Effect
    }

}
