using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OnItemClick : MonoBehaviour {

    public Sprite _idfImageClicked;
    public Text _textregion;
    public GameObject _footer;

    bool _begin_timer;
    float _timer;
    SpriteRenderer _thisSprite;

	// Use this for initialization
	void Start () {
        _thisSprite = this.GetComponent<SpriteRenderer>();
        _timer = 0;
        _begin_timer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_begin_timer)
        {
            Debug.Log((Time.time));
            if ((Time.time - _timer) > 3)
                SceneManager.LoadScene("scene_game1debutant_region");
        }
    }

    void OnMouseDown()
    {
        _thisSprite.sprite = _idfImageClicked;
        if (!_begin_timer)
        {
            _timer = Time.time;
            _begin_timer = true;
            _footer.SetActive(true);
            _textregion.text = "Ile-de-France";
        }
    }
}
