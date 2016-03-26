using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	public InputField userText;
	
	private enum States {
		title, wakeUp, waterfallShrine, pondShrine, houseShrine, shellShrine, graveShrine, 
		END, Quit
		};
	
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.title;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.title) {
			state_title ();
		} else if (myState == States.waterfallShrine) {
			state_waterfallShrine ();
		} else if (myState == States.pondShrine) {
			state_pondShrine ();
		} else if (myState == States.houseShrine) {
			state_houseShrine();
		} else if (myState == States.END) {
			state_END ();
		} else if (myState == States.Quit) {
			state_Quit ();
		}
	}
	void state_title () {
		text.text = "The Midnight Wind. \n\n" +
					"Press Space to Start, or Press Esc at any time to quit";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.approach;
			}		
	}
	void state_wakeUp () {
		text.text = "";
	}
	void state_waterfallShrine () {
		text.text = "";
	}
	void state_END () {
		text.text = "You carefully step down the stairs, wading further and further into the darkness. Fumbling around on the wall you feel a small " +
					"switch. As you flick it on, what lies in front of you causes you to stop in your tracks... \n\n" +
					"You've reached the end... for now.";
	}
	void state_Quit () {
		text.text = "Are you sure you want to quit?\n\n" +
				"(Press Y to quit, or press N to return)";
		if (Input.GetKeyDown (KeyCode.Y)) {
			Application.Quit();
		}
	}
}