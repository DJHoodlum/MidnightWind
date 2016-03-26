using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	public InputField userText;
	
	private enum States {
		title, approach, stoop, doorbell, knock, handle, search, bush, rocks0, inspectRock, rocks1, mailbox, 
		curtEntrance, curtLivingRoom, curtKitchen, curtDiningRoom, curtFoyer, curtUpstairs, curtYelling,
		lrBookshelf, bookshelfBook, lrPictures, lrTelevision, lrMagazines, lrCouch,
		kWindow, kTable, kFridge, kFridgeInside, kUtensils,
		drTable, drCabinet, drWindow,
		usBedroom, usBathroom, usCarpet,
		END, Quit
		};
	
	private States myState;
	private int doorKey;

	// Use this for initialization
	void Start () {
		myState = States.title;
		doorKey = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.title) 				{state_title();}
		else if (myState == States.approach) 		{state_approach();}
		else if (myState == States.stoop) 			{state_stoop();}
		else if (myState == States.doorbell) 		{state_doorbell();}
		else if (myState == States.knock) 			{state_knock();}
		else if (myState == States.handle) 			{state_handle();}
		else if (myState == States.search) 			{state_search();}
		else if (myState == States.bush) 			{state_bush();}
		else if (myState == States.rocks0) 			{state_rocks0();}
		else if (myState == States.inspectRock) 	{state_inspectRock();}
		else if (myState == States.rocks1) 			{state_rocks1();}
		else if (myState == States.mailbox) 		{state_mailbox();}
		else if (myState == States.curtEntrance) 	{state_curtEntrance();}
		else if (myState == States.curtLivingRoom) 	{state_curtLivingRoom();}
		else if (myState == States.lrBookshelf) 	{state_lrBookshelf();}
		else if (myState == States.bookshelfBook)   {state_bookshelfBook();}
		else if (myState == States.lrMagazines) 	{state_lrMagazines();}
		else if (myState == States.lrPictures) 		{state_lrPictures();}
		else if (myState == States.lrTelevision) 	{state_lrTelevision();}
		else if (myState == States.lrCouch) 		{state_lrCouch();}
		else if (myState == States.curtDiningRoom) 	{state_curtDiningRoom();}
		else if (myState == States.drTable) 		{state_drTable ();}
		else if (myState == States.drCabinet) 		{state_drCabinet ();}
		else if (myState == States.drWindow) 		{state_drWindow ();}
		else if (myState == States.curtKitchen)	 	{state_curtKitchen();}
		else if (myState == States.curtUpstairs) 	{state_curtUpstairs();}
		else if (myState == States.usBedroom) 		{state_usBedroom();		}
		else if (myState == States.usBathroom) 		{state_usBathroom();}
		else if (myState == States.usCarpet) 		{state_usCarpet ();}
		else if (myState == States.curtFoyer) 		{state_curtFoyer();}
		else if (myState == States.curtYelling) 	{state_curtYelling();}
		else if (myState == States.END) 			{state_END();}
		else if (myState == States.Quit)			{state_Quit();}
	}
	void state_title () {
		text.text = "The Midnight Wind. \n\n" +
					"Press Space to Start, or Press Esc at any time to quit";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.approach;
			}		
	}
	void state_approach () {
		text.text = "As you approach the backdoor of the manor, you curse yourself for even coming. The last time you " +
					"talked to Curt it ended badly. You can't remember ever coming to his house, however, save for a dinner or two " +
					"back when you two were still collegues.\n\n" +
					"(Press Enter to advance)";
			if (Input.GetKeyDown (KeyCode.Return)) {
				myState = States.stoop;
			}
	}
	void state_stoop () {
			text.text = "You stand in front of the ornate wooden door, its curved handle gleaming slightly from the evening sun behind you. " +
						"On the door frame itself sits a small doorbell, a vine growing slightly around its plastic frame.\n" +
						"What will you do?\n" +
						"(Press D to ring the doorbell, K to knock on the door, T to try the handle, or L to look around)";
			if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.doorbell;
			}
			else if (Input.GetKeyDown (KeyCode.K)) {
				myState = States.knock;
			}
			else if (Input.GetKeyDown (KeyCode.T)) {
				myState = States.handle;
			}
			else if (Input.GetKeyDown (KeyCode.L)) {
				myState = States.search;
			}			
	}
	void state_doorbell () {
		text.text = "The small button clicks in, and you start to hear the echoing chime play out in the house.\n" +
					"After it finishes however, you're left with nothing but silence once again...\n" +
					"(Press R to return)";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.stoop;
			}
	}
	void state_knock () {
		text.text = "You pound on the wooden door, feeling it shake with each hit.\nTo your frustration however, there is no answer\n" +
					"(Press R to return)";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.stoop;
			}
	}
	void state_handle () {
		if (doorKey == 0) {
			text.text = "You reach down to the gold handle and try to push forward. The door gives slightly with your force, " +
						"but ultimately doesn't open.\n" +
						"(Press R to return)";
				if (Input.GetKeyDown (KeyCode.R)) {
					myState = States.stoop;
				}
		}
		else if (doorKey == 1) {
			text.text = "You slide the old key into the lock and turn it. Luckily, you hear the muffled sound of the deadbolt clicking out of place.\n" +
						"With a sigh of relief, your grab the handle and push the door open.\n" +
						"(Press Enter to look around)";
				if (Input.GetKeyDown (KeyCode.Return)) {
					myState = States.curtEntrance;
				}
		}
	}
	void state_search () {
		text.text = "Looking around, you notice an overgrown beachgrass bush to your right, with a couple rocks at its base. " +
					"On the wall to the right of the door there is a dark green mailbox, its paint chipped away slightly in certain areas.\n" +
					"(Press B to look through the bush, S to inspect the rocks, M to take a look at the mailbox, or R to return)";
			if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.bush;
			}
			else if (Input.GetKeyDown (KeyCode.S)) {
				if (doorKey == 0) {
					myState = States.rocks0;
				}
				else if (doorKey == 1) {
					myState = States.rocks1;
				}
			}
			else if (Input.GetKeyDown (KeyCode.M)) {
				myState = States.mailbox;
			}
			else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.stoop;
			}
	}
	void state_bush () {
		text.text = "You use your arms to comb through the large bush, trying to avoid getting hit in the face. After a minute or so you conclude " +
					"that there's nothing of interest here.\n" +
					"(Press R to return)";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.search;
			}
	}
	void state_rocks0 () {
		text.text = "Glancing down at the rocks, you notice that they each have patches of moss growing on them, except for one.\n" +
					"(Press I to inspect the baren rock, or press R to return)";
			if (Input.GetKeyDown (KeyCode.I)) {
				myState = States.inspectRock;
			}
			else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.search;
			}
	}
	void state_inspectRock () {
		text.text = "Picking up the stone, you notice that it's actually made of plastic, and hear something tumbling around inside it" +
			"After pulling out a rubber cork on the underside of the rock, a small gold key falls into your hand.\n" +
				"(Press R to return)"; 
		doorKey = 1;
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.stoop;
			}
	}
	void state_rocks1 () {
		text.text = "The fake rock and its cork sit there in the dirt, the deep indent where it once sat makes your curious if it's ever been moved." +
					"(Press R to return)";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.stoop;
			}		
	}
	void state_mailbox () {
		text.text = "You open the mailbox and look inside to see it stuffed with mail. As you finger through it you notice that some of these dates " +
					"go back a couple of days. Curt's been known to reclude when he's working in depth on something, so it's not a shock." +
					"(Press R to return)";	
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.search;
			}
	}
	void state_curtEntrance () {
		text.text = "The light floods in from the open door behind you, illuminating an old staircase to your left, as well as a doorway to " +
					"another room. Off to your right is a kitchen, judging by the gleam of a faucet and the faint hum of a refrigerator. " +
					"Lastly, you can make out what looks like a small table directly in front of you. The table is holding up a small vase with flowers in it.\n\n" +
					"What will you do?\n" +
					"(Press L to look around to your left, M to move forwards, R to head into the kitchen, or Y to yell out.)";
			if (Input.GetKeyDown (KeyCode.L)) {
				myState = States.curtLivingRoom;
			}
			else if (Input.GetKeyDown (KeyCode.M)) {
				myState = States.curtFoyer;
			}
			else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.curtKitchen;
			}
			else if (Input.GetKeyDown (KeyCode.Y)) {
				myState = States.curtYelling;
			}
	}
	void state_curtLivingRoom () {
		text.text = "You step into a long room with a patterned, carpeted floor. Pictures of Curt on various vacations and events hang on the walls, the light blue wallpaper underneath slightly peeling along some of the edges." +
					"To your left stands a large bookcase, complete with an entire set of the 1989 World Book. To your right, there is a green full-sized couch sitting directly across from an old RCA tube television. " +
					"A couple magazines are scattered on the floor between the two. Finally, you spot another doorway past the couch which seems to lead to another room.\n" +
					"What will you do?\n" +
					"(Press B to investigate the bookcase, P to look at the pictures on the walls, T to look at the television set, M to inspect the magazines, C to look at the couch, D to walk through to the other doorway, or R to return to the Foyer.)";
			if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.lrBookshelf;
			}
			else if (Input.GetKeyDown (KeyCode.P)) {
				myState = States.lrPictures;
			}
			else if (Input.GetKeyDown (KeyCode.T)) {
				myState = States.lrTelevision;
			}
			else if (Input.GetKeyDown (KeyCode.M)) {
				myState = States.lrMagazines;
			}
			else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.lrCouch;
			}
			else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.curtDiningRoom;
			}
			else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.curtEntrance;
			}
	}
	void state_lrBookshelf () {
		text.text = "Curt always liked having these around, he said that there's nothing more exciting in life than new information. You found them boring however, never quite saw the merit in so much uneeded clutter." +
					"As you run you fingers along the spines of the books, you notice one in particular has a nuch of post-it notes sticking out the top.\n\n" +
					"(Press P to pull the book out, or R to return)";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.curtLivingRoom;
			}
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.bookshelfBook;
		}
	}
	void state_bookshelfBook () {
		text.text = "Book text\n\n" +
				"(Press R to return)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.curtLivingRoom;
		}
	}
	void state_lrPictures () {
		text.text = "Pictures text\n\n" +
					"(Press R to return)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.curtLivingRoom;
		}
	}
	void state_lrMagazines () {
		text.text = "Magazine text\n\n" +
					"(Press R to return)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.curtLivingRoom;
		}
	}
	void state_lrTelevision () {
		text.text = "Television text\n\n" +
					"(Press R to return)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.curtLivingRoom;
		}
	}
	void state_lrCouch () {
		text.text = "Couch text\n\n" +
					"(Press R to return)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.curtLivingRoom;
		}
	}
	void state_curtKitchen () {
		text.text = "You step through the doorway, and into the small kitchen. A single window " +
					"illuminates the room from behind the sink, to the left of which is a doorway. Next to the sink on the right is an offwhite refrigerator, and across from it stands a small breakfast table." +
					"Another doorway stands across from the fridge itself, leading into the Foyer. " +
					"Not much is on the green walls, save for an oversized fork and spoon made out of wood.\n" +
					"What will you do?\n" +
					"(Press T to walk over to the table, W to look at the fork and spoon, S to look at the sink, F to inspect the fridge, D to walk through the doorway next to the sink, or R to walk to the Foyer)";
			if (Input.GetKeyDown (KeyCode.T)) {
				;
			}
			else if (Input.GetKeyDown (KeyCode.W)) {
				;
			}
			else if (Input.GetKeyDown (KeyCode.S)) {
				;
			}
			else if (Input.GetKeyDown (KeyCode.F)) {
				;
			}
			else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.curtDiningRoom;
			}
			else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.curtEntrance;
			}
	}
	void state_curtFoyer () {
		text.text = "You walk forward towards the small table and vase. Along the sides of the vase are various pictures and text seeming to " +
					"depict aspects of Roman lifestyle. The blue color of the drawings contrast nicely against the white and gray marble of the rest of the vase." +
					"Now that you're standing closer to the table, you can spot another doorway hidden to your left, on the side of the staricase. The shadows of the banister " +
					"and upstairs landing seem to mask it somewhat, but you can still make out a gold knob on the door.\n" +
					"What will you do?\n" +
					"(Press D to walk to the doorway, or press R to return to the entranceway.)";
			if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.END;
			}
			else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.curtEntrance;
			}
	}
	void state_curtDiningRoom () {
		text.text = "You recgonize this room almost immediatley as Curt's dining room. " +
					"The burghendy walls look just the same as you remember, as does the dark mohaghany table and chairs. " +
					"Light spills through the two large windows across from you, accenting the silverware in the cabinet to your left." +
					"Finally, there are two doorways in this room, one sits to the left of the cabinet, while the other to the right.\n" +
					"What will you do?\n" +
					"(Press T to walk to the table, C to look at the cabinets, W to inspect the window, R to walk through the right doorway, or L to walk through the left.)";
			if (Input.GetKeyDown (KeyCode.T)) {
				myState = States.drTable;	
			}
			else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.drCabinet;
			}
			else if (Input.GetKeyDown (KeyCode.W)) {
				myState = States.drWindow;
			}
			else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.curtLivingRoom;
			}
			else if (Input.GetKeyDown (KeyCode.L)) {
				myState = States.curtKitchen;
			}
	}
	void state_drTable () {
		text.text = "The table itself is very plain, save for a couple scratches her and there. " +
					"The chairs that line the permiter are all cushioned nicely, and the backs feature a tan woven mesh.\n" +
					"(Press R to return)";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.curtDiningRoom;
		}
	}
	void state_drCabinet () {
		text.text = "The large oak cabinet sits against the wall of the room, its glass doors gleaming from the window directly across from it."	+
					"The shelves inside are lined with sparkling silverware and plates, though they don't look like they've been disturbed recently.\n" +
					"(Press R to return)";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.curtDiningRoom;
			}
		}
	void state_drWindow () {
		text.text = "Window text.\n\n"+
					"(Press R to return)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.curtDiningRoom;
		}
	}
	void state_curtUpstairs () {
		text.text = "You walk up the stairs and are greeted by two doors, one to your left, and the other down the hall a bit to your right. " +
					"A carpet lays on the floor between the two, its colorful design contrasting against the plain wood walls.\n" +
					"What will you do?\n" +
					"(Press L to enter the door to your left, press R for the door on your right, C to look at the carpet, or S to walk back down the stairs.";
			if (Input.GetKeyDown (KeyCode.L)) {
				myState = States.usBedroom;
			}
			else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.usBathroom;
			}
			else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.usCarpet;
			}
			else if (Input.GetKeyDown (KeyCode.S)) {
				myState = States.curtEntrance;
			}
	}
	void state_usBedroom () {
		;
	}
	void state_usBathroom () {
		;
	}
	void state_usCarpet () {
		;
	}
	void state_curtYelling () {
		text.text = "\"Hello?,\" you yell out, \"Curt?\" You can hear your cries echo throughout the old house, but after they die out you're only left with silence.\n" +
					"(Press R to return)";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.curtEntrance;
			}
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