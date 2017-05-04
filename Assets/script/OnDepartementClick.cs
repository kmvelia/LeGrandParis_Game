using UnityEngine.UI;
using UnityEngine;

public class OnDepartementClick : MonoBehaviour {

    public Text _textdepartement;
    public GameObject _footer;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	}

    void removeAll_c()
    {
        this.transform.parent.GetChild(9).gameObject.SetActive(false);
        this.transform.parent.GetChild(14).gameObject.SetActive(false);
        this.transform.parent.GetChild(15).gameObject.SetActive(false);
        this.transform.parent.GetChild(13).gameObject.SetActive(false);
        this.transform.parent.GetChild(10).gameObject.SetActive(false);
        this.transform.parent.GetChild(8).gameObject.SetActive(false);
        this.transform.parent.GetChild(12).gameObject.SetActive(false);
        this.transform.parent.GetChild(11).gameObject.SetActive(false);

        this.transform.parent.GetChild(0).gameObject.SetActive(true);
        this.transform.parent.GetChild(1).gameObject.SetActive(true);
        this.transform.parent.GetChild(2).gameObject.SetActive(true);
        this.transform.parent.GetChild(3).gameObject.SetActive(true);
        this.transform.parent.GetChild(4).gameObject.SetActive(true);
        this.transform.parent.GetChild(5).gameObject.SetActive(true);
        this.transform.parent.GetChild(6).gameObject.SetActive(true);
        this.transform.parent.GetChild(7).gameObject.SetActive(true);
    }

    void OnMouseDown()
    {
        removeAll_c();
        switch (this.transform.name)
        {
            case "idf_paris":
                this.gameObject.SetActive(false);
                this.transform.parent.GetChild(9).gameObject.SetActive(true);
                _textdepartement.text = "Paris";
                break;
            case "idf_seinesaintdenis":
                this.gameObject.SetActive(false);
                this.transform.parent.GetChild(14).gameObject.SetActive(true);
                _textdepartement.text = "Seine Saint-Denis";
                break;
            case "idf_valdemarne":
                this.gameObject.SetActive(false);
                this.transform.parent.GetChild(15).gameObject.SetActive(true);
                _textdepartement.text = "Val de Marne";
                break;
            case "idf_hautsdeseine":
                this.gameObject.SetActive(false);
                this.transform.parent.GetChild(13).gameObject.SetActive(true);
                _textdepartement.text = "Hauts de Seine";
                break;
            case "idf_valdoise":
                this.gameObject.SetActive(false);
                this.transform.parent.GetChild(10).gameObject.SetActive(true);
                _textdepartement.text = "Val d'oise";
                break;
            case "idf_yvelines":
                this.gameObject.SetActive(false);
                this.transform.parent.GetChild(8).gameObject.SetActive(true);
                _textdepartement.text = "Yvelines";
                break;
            case "idf_essonne":
                this.gameObject.SetActive(false);
                this.transform.parent.GetChild(12).gameObject.SetActive(true);
                _textdepartement.text = "Essone";
                break;
            case "idf_seineetmarne":
                this.gameObject.SetActive(false);
                this.transform.parent.GetChild(11).gameObject.SetActive(true);
                _textdepartement.text = "Seine et Marne";
                break;
        }
        _footer.SetActive(true);
        footer._timer = Time.time;
    }
}
