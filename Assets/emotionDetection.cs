
/*
using UnityEngine;
using System; // Add this line

public class emotionDetection : MonoBehaviour
{
    // Reference to the OVRFaceExpressions component
    public OVRFaceExpressions faceExpressions;

    void Update()
    {
        // Check if facial expressions are valid
        if (faceExpressions.ValidExpressions)
        {
            // Iterate through each face expression
            foreach (OVRFaceExpressions.FaceExpression expression in Enum.GetValues(typeof(OVRFaceExpressions.FaceExpression)))
            {
                // Check if the weight of the expression is above a certain threshold (adjust as needed)
                float expressionWeight = faceExpressions[expression];
                if (expressionWeight > 0.5f)
                {
                    // Print out the detected facial expression
                    Debug.Log($"Detected expression: {expression}, Weight: {expressionWeight}");
                }
            }
        }
    }
}
*/