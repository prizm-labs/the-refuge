using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using System.Collections.Generic;

public class RefugeDeck : MonoBehaviour {

	public List<GameObject> myPotentialCardPrefabs;	// = new List<GameObject> ();


	// Use this for initialization
	void Awake () {
		GetComponent<TapGesture>().Tapped += DeckTapped;
	}

	void DeckTapped (object sender, System.EventArgs e)
	{
		DrawRandomCardFromDeck ();
	}

	private void DrawRandomCardFromDeck() {
		int randomCardIndex = UnityEngine.Random.Range (0, myPotentialCardPrefabs.Count - 1);
		GameObject theCardPrefab = myPotentialCardPrefabs[randomCardIndex];

		GameObject newCard = Instantiate (theCardPrefab);

		newCard.transform.position = transform.position + Vector3.up * 3.0f;


		newCard.GetComponent<Card> ().FlipMeOver ();
	}

}
