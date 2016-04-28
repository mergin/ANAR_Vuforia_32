using UnityEngine;
using System.Collections;
using Vuforia;

public class RotateVirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject _modelRupestre;
    private GameObject _mapa;
    public int rotationFactor = 0;

    /// <summary>
    /// Called when the scene is loaded
    /// </summary>
    void Start() {

        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i) {
            vbs[i].RegisterEventHandler(this);
        }

        _modelRupestre = transform.FindChild("Lajitas").gameObject;
        _mapa = transform.FindChild("Mapa").gameObject;
        _mapa.SetActive(false);
    }

    void Update() {
        _modelRupestre.transform.Rotate(new Vector3(0, Time.deltaTime * rotationFactor, 0));
    }

    void ShowMap()
    {
        _modelRupestre.SetActive(false);
        _mapa.SetActive(true);
    }

    void ShowModel()
    {
        _mapa.SetActive(false);
        _modelRupestre.SetActive(true);
    }

    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
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

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
    }
}
