using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.Extras;


[RequireComponent(typeof(SteamVR_LaserPointer))]
public class VRUIInput : MonoBehaviour
{
	private SteamVR_LaserPointer laserPointer;

	private void OnEnable()
	{
		laserPointer = GetComponent<SteamVR_LaserPointer>();
		laserPointer.PointerIn -= HandlePointerIn;
		laserPointer.PointerIn += HandlePointerIn;
		laserPointer.PointerOut -= HandlePointerOut;
		laserPointer.PointerOut += HandlePointerOut;
        laserPointer.PointerClick -= HandlePointerClick;
        laserPointer.PointerClick += HandlePointerClick;
    }

	private void HandlePointerClick(object sender, PointerEventArgs e)
	{
        var button = e.target.GetComponent<Button>();
        if (button != null)
        {
            button.onClick.Invoke();
        }
	}

	private void HandlePointerIn(object sender, PointerEventArgs e)
	{
		var button = e.target.GetComponent<Button>();
		if (button != null)
		{
			button.Select();
			//Debug.Log("HandlePointerIn", e.target.gameObject);
		}
	}

	private void HandlePointerOut(object sender, PointerEventArgs e)
	{

		var button = e.target.GetComponent<Button>();
		if (button != null)
		{
            button.OnDeselect(null);
			//Debug.Log("HandlePointerOut", e.target.gameObject);
		}
	}
}