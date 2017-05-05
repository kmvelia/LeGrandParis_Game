using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class _mysql : MonoBehaviour
{
    public GameObject _content;
    public Text _question_text;
    public Text _enonce_text;
    public Text _enonce_title;
    public static int question;
    public string[] value;

    string url = "http://51.254.114.220/get_math_enonce.php";
    Text _textcontent;

    // Use this for initialization
    void Start()
    {
        string[] value = new string[4];
        question = 1;
        _textcontent = _content.GetComponent<Text>();
        StartCoroutine(download_data());
    }

    IEnumerator download_data()
    {
        // Create a form object for sending high score data to the server
        WWWForm form = new WWWForm();

        // Assuming the perl script manages high scores for different games
        form.AddField("action", "get_enonce");
        form.AddField("id_enonce", question);

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
            value = download.text.Split(';');
            _enonce_title.text = "Enoncé " + value[0] + " :";
            _enonce_text.text = value[1];
            _textcontent.text = value[2];
            _question_text.text = value[3];
        }
    }


}