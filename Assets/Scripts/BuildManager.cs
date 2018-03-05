using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	void Awake(){
		if (instance!=null) {
			Debug.Log ("More than one BuildManger in scene!");
		}
		instance = this;
	}

	public GameObject standartTurretPrefab;

	private GameObject turretToBuild;

	void Start(){
		turretToBuild = standartTurretPrefab;
	}
	public GameObject GetTurretToBuild(){
		return turretToBuild;
	}

}
