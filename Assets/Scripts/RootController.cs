using UnityEngine;
using UnityEngine.SceneManagement;

public class RootController : MonoBehaviour {
    private static RootController instance; //Singleton
    private AudioSource Audio;
    private bool controlsEnabled;

    public static RootController Instance
    {
        get { return instance; }
    }

    public void Quit()
    {
        Application.Quit();
    }

    void Awake()
    {
        instance = this;
        Audio = GameObject.Find("Audio").GetComponent<AudioSource>();
    }

    public AudioSource AudioController()
    {
        return Audio;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void EnableControls()
    {
        controlsEnabled = true;
    }

    public void DisableControls()
    {
        controlsEnabled = false;
    }
}