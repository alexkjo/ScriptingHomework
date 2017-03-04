using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {

    public string BluePlayer;
    public string RedPlayer;
    public string LockedDoor;
    public string Key;

	// Use this for initialization
	public void Start () {
		
        if (string == BluePlayer && string == RedPlayer)
        {
            print("Spawned both Players");
        }

        if (string == BluePlayer || string == RedPlayer)
        {
            print("One Player Spawned");
        }

        if (string != BluePlayer || string != RedPlayer)
        {
            print("Something went wrong");
        }

        if (string != BluePlayer && string != RedPlayer)
        {
            print("No Players spawned");
        }

        if (string == LockedDoor && string == Key)
        {
            print("Door is unlocked.");
        }

        if (string == LockedDoor || string == Key)
        {
            print("Door didn't Budge");
        }

        if (string != LockedDoor && string != Key)
        {
            print("What are you trying to do?");
        }

	}
}
