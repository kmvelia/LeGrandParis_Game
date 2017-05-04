using UnityEngine;
using System.Collections;

public class _mysql : MonoBehaviour
{
    string highscore_url = "http://51.254.114.220/get_math_enonce.php";
    string playName = "Player 1";
    int score = -1;

    // Use this for initialization
    IEnumerator Start()
    {
        // Create a form object for sending high score data to the server
        WWWForm form = new WWWForm();
        // Assuming the perl script manages high scores for different games
        form.AddField("action", "get_enonce");
        // The name of the player submitting the scores
        //form.AddField("playerName", playName);
        // The score
        //form.AddField("score", score);

        // Create a download object
        WWW download = new WWW(highscore_url, form);

        // Wait until the download is done
        yield return download;

        if (!string.IsNullOrEmpty(download.error))
        {
            print("Error downloading: " + download.error);
        }
        else
        {
            // show the highscores
            Debug.Log(download.text);
        }
    }
}