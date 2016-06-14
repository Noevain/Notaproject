using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour {
    public int PlayerCurrentHP;
    public int Playerstartinghp = 100;
    bool takingdmg;
    bool dead;

	// Use this for initialization
	void Start () {
        PlayerCurrentHP = Playerstartinghp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
