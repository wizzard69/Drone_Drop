using UnityEngine;

public class GameController : MonoBehaviour {

public static GameController instance;

	void Awake()
	{
		if (instance != null)
		{
			return;
		}
		else
		{
			instance = this;
		}
	}
}
