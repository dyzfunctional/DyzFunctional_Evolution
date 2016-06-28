using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SpashScreen : MonoBehaviour
{
    public float timer = 2f;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(DisplayScene());
	}

    IEnumerator DisplayScene()
    {
        yield return new WaitForSeconds(timer);

        SceneManager.LoadScene(1);
    }
}
