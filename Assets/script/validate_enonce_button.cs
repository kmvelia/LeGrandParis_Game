using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class validate_enonce_button : MonoBehaviour {

    public Button _validate_button;
    public Dropdown _choix_reponse;
    //public Text _reponse_user_text;
    public Text _retour_sur_reponse_user_text;

    string url = "http://51.254.114.220/get_math_enonce_response.php";

    // Use this for initialization
    void Start () {
        _validate_button.onClick.AddListener(OnClickButtonValidate);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClickButtonValidate()
    {
        if (string.Compare(_choix_reponse.GetComponentInChildren<Text>().text, _mysql.answer[1]) == 0)
            _retour_sur_reponse_user_text.text = "Bonne reponse !";
        else
            _retour_sur_reponse_user_text.text = "t nul comme lavan lol !";
    }
}
