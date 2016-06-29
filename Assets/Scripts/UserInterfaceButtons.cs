using UnityEngine;
using System.Collections;
using System.IO;
using Vuforia;

public class UserInterfaceButtons : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject _modelRupestre;
    public GameObject _mapa;
    public GameObject _pregunta;
    private AudioSource _sonidoModelo;
    private AudioSource _sonidoMapa;

    // Use this for initialization
    void Start () {

        /* SET */
        _mapa.SetActive(false);
        _pregunta.SetActive(false);

        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i) {
            vbs[i].RegisterEventHandler(this);
        }

        // Argegar archivo de audio a AudioSource usando GetComponent<AudioSource>()
        //_sonidoModelo = _modelRupestre.GetComponentInChildren<AudioSource>();
        //_sonidoMapa = _mapa.GetComponentInChildren<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void CloseAppButton()
    {
        Application.Quit();
    }

    public void ShowMap()
    {
        _modelRupestre.SetActive(false);
        _pregunta.SetActive(false);
        _mapa.SetActive(true);
    }

    public void ShowModel()
    {
        _mapa.SetActive(false);
        _pregunta.SetActive(false);
        _modelRupestre.SetActive(true);
    }

    public void ShowQuestion()
    {
        _mapa.SetActive(false);
        _modelRupestre.SetActive(false);
        _pregunta.SetActive(true);
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
                ShowModel();
                break;

            case "VirtualButton2":
                ShowMap();
                break;

            case "VirtualButton3":
                ShowQuestion();
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
