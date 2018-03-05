using UnityEngine;

public class Node : MonoBehaviour {

	public Color hoverColor;

	public Vector3 positionOffset;
	private GameObject turret;


	private Renderer rend;
	private Color startColor;

	void Start(){
		rend = GetComponent <Renderer> ();
		startColor = rend.material.color;
	}

	void OnMouseEnter(){
		rend.material.color = hoverColor;
		if (turret != null) 
			rend.material.color = Color.red ;
	}

	void OnMouseExit(){
		rend.material.color = startColor;
	}

	void OnMouseDown(){
		if (turret != null) {
			Debug.Log ("Cant build there! -TODO : Display on screen");
			return;
		}
		//Build a turret.
		GameObject turretToBuild=BuildManager.instance.GetTurretToBuild ();
		turret=(GameObject)Instantiate (turretToBuild,transform.position+positionOffset,transform.rotation);
	}
}
