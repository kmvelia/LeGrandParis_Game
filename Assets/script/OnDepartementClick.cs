using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDepartementClick : MonoBehaviour {

    SpriteRenderer _thisSprite;

    public Sprite _idf_paris_c;
    public Sprite _idf_seinesaintdenis_c;
    public Sprite _idf_valdemarne_c;
    public Sprite _idf_hautsdeseine_c;
    public Sprite _idf_valdoise_c;
    public Sprite _idf_yvelines_c;
    public Sprite _idf_essonne_c;
    public Sprite _idf_seineetmarne_c;

    // Use this for initialization
    void Start ()
    {
        _thisSprite = this.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        switch (this.transform.name)
        {
            case "idf_paris":
                _thisSprite.sprite = _idf_paris_c;
                break;
            case "idf_seinesaintdenis":
                _thisSprite.sprite = _idf_seinesaintdenis_c;
                break;
            case "idf_valdemarne":
                _thisSprite.sprite = _idf_valdemarne_c;
                break;
            case "idf_hautsdeseine":
                _thisSprite.sprite = _idf_hautsdeseine_c;
                break;
            case "idf_valdoise":
                _thisSprite.sprite = _idf_valdoise_c;
                break;
            case "idf_yvelines":
                _thisSprite.sprite = _idf_yvelines_c;
                break;
            case "idf_essonne":
                _thisSprite.sprite = _idf_essonne_c;
                break;
            case "idf_seineetmarne":
                _thisSprite.sprite = _idf_seineetmarne_c;
                break;
        }
    }
}
