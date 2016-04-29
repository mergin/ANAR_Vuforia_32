using UnityEngine;
using System.Collections;
using System.IO;

public class UserInterfaceButtons : MonoBehaviour {

    private GameObject _modelRupestre;
    private GameObject _mapa;
    private AudioSource _sonidoModelo;
    private AudioSource _sonidoMapa;
    public float rotationSpeed = 70.0f;
    bool repeatRotateLeft = false;
    bool repeatRotateRight = false;

    // Use this for initialization
    void Start () {
        _modelRupestre = GameObject.FindWithTag("Model");
        _mapa = GameObject.FindWithTag("Map");
        _mapa.SetActive(false);

        // Argegar archivo de audio a AudioSource usando GetComponent<AudioSource>()
        _sonidoModelo = _modelRupestre.GetComponentInChildren<AudioSource>();
        _sonidoMapa = _mapa.GetComponentInChildren<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (repeatRotateRight) {
            RotationRightButton();
        }

        if (repeatRotateLeft) {
            RotationLeftButton();
        }
    }

    public void CloseAppButton()
    {
        Application.Quit();
    }

    public void RotationRightButton()
    {
        _modelRupestre.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        _mapa.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
    }

    public void RotationLeftButton()
    {
        _modelRupestre.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        _mapa.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    public void RotationRightButtonRepeat()
    {
        repeatRotateRight = true;
    }

    public void RotationLeftButtonRepeat()
    {
        repeatRotateLeft = true;
    }

    public void RotateLeftButtonOff()
    {
        repeatRotateLeft = false;
    }

    public void RotateRightButtonOff()
    {
        repeatRotateRight = false;
    }

    public void ShowMap()
    {
        _modelRupestre.SetActive(false);
        _mapa.SetActive(true);
    }

    public void ShowModel()
    {
        _mapa.SetActive(false);
        _modelRupestre.SetActive(true);
    }

    public void PlaySoundModel()
    {
        _sonidoModelo.Play();
        _sonidoMapa.Stop();
    }

    public void StopSoundModel()
    {
        _sonidoModelo.Stop();
    }
}
