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
        Debug.Log(_choix_reponse.value);
        //StartCoroutine(check_answer_user());
    }

    IEnumerator check_answer_user()
    {
        
        // Create a form object for sending high score data to the server
        WWWForm form = new WWWForm();

        // Assuming the perl script manages high scores for different games
        form.AddField("action", "get_response");
        form.AddField("id_enonce", _mysql.question);
        //form.AddField("user_answer", _reponse_user_text.text);

        // Create a download object
        WWW download = new WWW(url, form);

        // Wait until the download is done
        yield return download;

        if (!string.IsNullOrEmpty(download.error))
        {
            print("Error downloading: " + download.error);
        }
        else
        {
            _retour_sur_reponse_user_text.text = download.text;
        }
        Debug.Log(_choix_reponse.value);
    }
}
