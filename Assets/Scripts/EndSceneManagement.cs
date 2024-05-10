using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneManagement : MonoBehaviour
{
    public float timerDuration = 60f;
    private float currentTimer;
    public string endSceneBad;

    void Start()
    {
        currentTimer = timerDuration;
        // Start your timer mechanism here (Coroutine or InvokeRepeating)
    }

    void Update()
    {
        currentTimer -= Time.deltaTime; // Update the timer countdown

        if (currentTimer == 0f)
        {
            ChangeEndScene();
        }
    }

    void ChangeEndScene()
    {
        SceneManager.LoadScene(endSceneBad);
    }
}
