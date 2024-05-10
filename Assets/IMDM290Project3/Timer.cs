using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;

    private float countdownDuration = 240f; // 4 minutes in seconds
    private float remainingTime;

    private void Start()
    {
        remainingTime = countdownDuration;
        UpdateTimerDisplay();
        UpdateLifepointsText();
    }

    private void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            UpdateTimerDisplay();
            UpdateLifepointsText();
        }
        else
        {
            Debug.Log("Timer reached zero!");
        }
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void UpdateLifepointsText()
    {
        // Find the GameObject with the name "LifepointsText" in the scene
        GameObject lifepointsObject = GameObject.Find("lifepointsText");

        // Check if the lifepointsObject is not null and has a TextMeshProUGUI component
        if (lifepointsObject != null)
        {
            TextMeshProUGUI lifepointsText = lifepointsObject.GetComponent<TextMeshProUGUI>();

            // Check if lifepointsText is not null before updating
            if (lifepointsText != null)
            {
                // Update lifepoints text based on remaining time
                if (remainingTime <= 30)
                {
                    lifepointsText.text = "0";
                }
                else if (remainingTime <= 60)
                {
                    lifepointsText.text = "1";
                }
                else
                {
                    lifepointsText.text = "2";
                }
            }
        }
    }

    public float GetRemainingTime()
    {
        return remainingTime;
    }
}
