using UnityEngine;

public class ArticulationHandManualInput : MonoBehaviour
{
    public GameObject hand;

    // INPUT HELPERS

    static GripState GripStateForInput(float input)
    {
        if (input > 0)
        {
            return GripState.Closing;
        }
        else if (input < 0)
        {
            return GripState.Opening;
        }
        else
        {
            return GripState.Fixed;
        }
    }

    void Update()
    {
        // manual input
        float input = Input.GetAxis("Fingers");
        PincherController pincherController = hand.GetComponent<PincherController>();
        pincherController.gripState = GripStateForInput(input);
    }
}