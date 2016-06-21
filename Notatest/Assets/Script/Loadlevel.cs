using UnityEngine;
using System.Collections;

public class Loadlevel : MonoBehaviour {

    public GameObject Loadingscreen;
    public void LoadScene(int scene)
    {
        Loadingscreen.SetActive(true);
        LoadScene(scene);
    }
}
