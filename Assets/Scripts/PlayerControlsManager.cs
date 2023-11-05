using UnityEngine;

public class PlayerControlsManager : MonoBehaviour
{
    private PlayerControls playerControls; // Reference to the PlayerControls script

    private void Awake()
    {
        playerControls = GetComponent<PlayerControls>(); // Get the PlayerControls component attached to the same GameObject
    }

    // Method to enable the PlayerControls script
    public void EnablePlayerControls()
    {
        playerControls.enabled = true; // Enable the PlayerControls script
    }

    // Method to disable the PlayerControls script
    public void DisablePlayerControls()
    {
        playerControls.enabled = false; // Disable the PlayerControls script
    }
}
