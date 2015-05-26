using UnityEngine;
using System.Collections;

public class LogOutButton : MonoBehaviour {

	public void OnClick() {
		AppManager.s_instance.logOut ();
	}
}
