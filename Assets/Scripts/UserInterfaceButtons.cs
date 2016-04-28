using UnityEngine;
using System.Collections;
using System.IO;

public class UserInterfaceButtons : MonoBehaviour {

    public float rotationSpeed = 70.0f;
    private GameObject _modelRupestre;
    private GameObject _mapa;

    // Use this for initialization
    void Start () {
        _modelRupestre = GameObject.FindWithTag("Model");
        _mapa = GameObject.FindWithTag("Map");
        _mapa.SetActive(false);
        Debug.Log("MODEL: " + _modelRupestre);
        Debug.Log("MAP: " + _mapa);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CloseAppButton()
    {
        Application.Quit();
    }

    public void RotationRightButton()
    {
        //GameObject.FindWithTag("Model").transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        _modelRupestre.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
    }

    public void RotationLeftButton()
    {
        //GameObject.FindWithTag("Model").transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        _modelRupestre.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    public void ShowMap()
    {
        //GameObject.FindWithTag("Model").SetActive(false);
        //GameObject.FindWithTag("Map").SetActive(true);
        _modelRupestre.SetActive(false);
        _mapa.SetActive(true);
    }

    public void ShowModel()
    {
        //GameObject.FindWithTag("Map").SetActive(false);
        //GameObject.FindWithTag("Model").SetActive(true);
        _mapa.SetActive(false);
        _modelRupestre.SetActive(true);
    }
}
