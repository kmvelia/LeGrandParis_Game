using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class _mysql : MonoBehaviour
{
    public static int question;
    public static int random_id;
    public static string[] answer;

    public GameObject _content;
    public Dropdown _choix_reponse;
    public Text _question_text;
    public Text _enonce_text;
    public Text _enonce_title;
    public Dictionary<int, string> _question_id_string;
    public List<int> _id_question;
    
    string[] value;
    string[] donnee;
    string[] question_donnee;


    string url_data = "http://51.254.114.220/get_math_enonce.php";
    string url_data_answer = "http://51.254.114.220/get_math_enonce_response.php";
    Text _textcontent;

    // Use this for initialization
    void Start()
    {
        _question_id_string = new Dictionary<int, string>();
        _id_question = new List<int>();
        string[] value = new string[2];
        string[] donnee = new string[4];
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
        WWW download = new WWW(url_data, form);

        // Wait until the download is done
        yield return download;
        
        if (!string.IsNullOrEmpty(download.error))
        {
            print("Error downloading: " + download.error);
        }
        else
        {
            int i = 0;
            System.Random random = new System.Random();

            value = download.text.Split('+');
            donnee = value[0].Split(';');
            question_donnee = value[1].Split(';');
            while (i < (question_donnee.Length - 1))
            {
                _question_id_string[int.Parse(question_donnee[i])] = question_donnee[i + 1];
                _id_question.Add(int.Parse(question_donnee[i]));
                i += 2;
            }
            random_id = random.Next(1, (_question_id_string.Count + 1));

            StartCoroutine(download_answer(random_id));
            _question_text.text = _question_id_string[random_id];
            _enonce_title.text = "Enoncé " + donnee[0] + " :";
            _enonce_text.text = donnee[1];
            _textcontent.text = donnee[2];
        }
    }

    IEnumerator download_answer(int id_question)
    {
        // Create a form object for sending high score data to the server
        WWWForm form = new WWWForm();

        // Assuming the perl script manages high scores for different games
        form.AddField("action", "get_response");
        form.AddField("id_question", id_question);

        // Create a download object
        WWW download = new WWW(url_data_answer, form);

        // Wait until the download is done
        yield return download;

        if (!string.IsNullOrEmpty(download.error))
        {
            print("Error downloading: " + download.error);
        }
        else
        {
            int i = 2;
            answer = new string[download.text.Split(';').Length];
            answer = download.text.Split(';');
            while (i < answer.Length - 1)
            {
                _choix_reponse.options.Add(new Dropdown.OptionData() { text = answer[i] });
                i++;
            }
        }
    }


}