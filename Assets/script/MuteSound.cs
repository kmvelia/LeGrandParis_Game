using UnityEngine;
using UnityEngine.UI;

public class MuteSound : MonoBehaviour
{

	public Button btnSound;
	public Sprite spriteBtnOn;
	public Sprite spriteBtnOff;
	public int counter = 0;

	// Use this for initialization
	void Start()
	{
		Button btnMute = btnSound.GetComponent<Button>();
		btnMute.onClick.AddListener(muteSound);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void muteSound() {
		AudioListener.pause = false;
		counter++;
		if (counter % 2 == 0)
		{
			btnSound.image.overrideSprite = spriteBtnOn;
			AudioListener.pause = false;
		} 
		else {
			btnSound.image.overrideSprite = spriteBtnOff;
			AudioListener.pause = true;
		}
	}
}