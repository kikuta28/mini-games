using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadSpottoScene()
    {
        SceneManager.LoadScene("SpottoScene");
    }
    public void LoadMatoateScene()
    {
        SceneManager.LoadScene("MatoateScene");
    }
    public void LoadSceneSelectorScene()
    {
        SceneManager.LoadScene("SceneSelector");

    }
}
