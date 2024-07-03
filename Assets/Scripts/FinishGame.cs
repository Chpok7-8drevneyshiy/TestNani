using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public void Finish()
    {
        SceneManager.LoadScene(0);
    }
}
