using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PauseManager : MonoBehaviour
{
    // Array to hold GameObjects to check for active status
    public GameObject[] objectsToCheck;

    // Type of MonoBehaviour component to disable when any of the objectsToCheck is active
    public MonoBehaviour componentToDisable;

    void Update()
    {
        // Iterate through each object in objectsToCheck array
        foreach (GameObject obj in objectsToCheck)
        {
            // Check if the object is active
            if (obj.activeInHierarchy)
            {
                // Check if the componentToDisable is not null
                if (componentToDisable != null)
                {
                    // Disable the component on specified GameObject
                    componentToDisable.enabled = false;
                    // Exit the loop after disabling component on the first active object
                    return;
                }
                else
                {
                    Debug.LogWarning("Component to disable is not assigned.");
                    return;
                }
            }
        }

        // If none of the objects are active, enable the component
        if (componentToDisable != null)
        {
            componentToDisable.enabled = true;
        }
    }
}
