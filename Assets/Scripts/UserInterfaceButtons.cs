using UnityEngine;
using System.Collections;
using System.IO;
using Vuforia;

public class UserInterfaceButtons : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject _modelRupestre;
    private GameObject _mapa;
    private AudioSource _sonidoModelo;
    private AudioSource _sonidoMapa;
    public float rotationSpeed = 70.0f;
    bool repeatRotateLeft = false;
    bool repeatRotateRight = false;

    // Use this for initialization
    void Start () {

        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i) {
            vbs[i].RegisterEventHandler(this);
        }

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

    /// Called when the virtual button has just been pressed:
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {

        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);

        // Add the material corresponding to this virtual button
        // to the active material list:
        switch (vb.VirtualButtonName)
        {
            case "VirtualButton1":
                //rotationFactor = 30;
                ShowModel();
                break;

            case "VirtualButton2":
                //rotationFactor = 0;
                ShowMap();
                break;

            default:
                throw new UnityException("Button not supported: " + vb.VirtualButtonName);
                break;
        }
    }

    /// Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
    }
}
