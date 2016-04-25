using UnityEngine;
using System.Collections;
using Vuforia;

public class SimpleVBEventHandler : MonoBehaviour,
                                            IVirtualButtonEventHandler
{


    #region PUBLIC_METHODS

    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("OnButtonPressed for " + vb.name);

    }


    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("OnButtonReleased for " + vb.name);
    }

    #endregion // PUBLIC_METHODS



    #region UNTIY_MONOBEHAVIOUR_METHODS

    void Start()
    {

        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour vb =
                            GetComponentInChildren<VirtualButtonBehaviour>();
        if (vb)
        {
            vb.RegisterEventHandler(this);
        }

    }


    void Update()
    {

    }

    #endregion // UNTIY_MONOBEHAVIOUR_METHODS



    #region PRIVATE_METHODS



    #endregion // PRIVATE_METHODS
}