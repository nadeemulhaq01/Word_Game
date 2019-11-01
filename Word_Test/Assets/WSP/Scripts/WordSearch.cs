using UnityEngine;
using System; 
using System.Collections; 
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

public class WordSearch : MonoBehaviour {

    
   
    public int gridX, gridY; 
    public float sensitivity;
    public float spacing; 
    public GameObject cell, background, current;             
    public Color defaultTint, mouseoverTint, identifiedTint,fillcolor;
    public bool ready = false;
    public string selectedString = "";
    public List<GameObject> selected = new List<GameObject>();

    private List<GameObject> cells = new List<GameObject>();
    private GameObject temporary, backgroundObject;
    private string[,] matrix;
	
	private Ray ray;
    private RaycastHit hit;
	public float timeLeft = 300.0f;
	public Text text;
	public string dic = "dictionary";
	string [] txtContent;

	public GameObject msg;

	float currentTime = 0.0f;
	float startTime = 300.0f;
	public Text _Timer;
	public bool isfill;
	bool istimer;
	private bool isCorrect;
	public int gridValue;
	private string lastStr;
	private string[] alphabets = new string[26]
	{"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
	public Text wordMatchText;
	public GameObject wordList;
	private int y;
	private static WordSearch instance;
    public static WordSearch Instance {
        get {
			return instance;
		}
    }

	
	void Awake()
	{
        instance = this;
	}

    void Start()
	{
		y = 150;
		istimer = false;
		currentTime = startTime;
		TextAsset txtas = (TextAsset)Resources.Load("dictionary");
		txtContent = txtas.text.Split(';');
		
		foreach (var x in txtContent)
		{
			//Debug.LogError("wordslist :" + x.ToLower());
		}

        Mathf.Clamp01(sensitivity);
        matrix = new string[gridX, gridY];
		BackGround();

		for (int i = 0; i < gridX; i++)
		{
			for (int j = 0; j < gridY; j++)
			{
				temporary = Instantiate(cell, new Vector3(i * 1 * cell.transform.localScale.x * spacing, 10, j * 1 * cell.transform.localScale.z * spacing), Quaternion.identity) as GameObject;
				temporary.name = "cell-" + i.ToString() + "-" + j.ToString();
				temporary.transform.eulerAngles = new Vector3(180, 0, 0);
				temporary.transform.parent = backgroundObject.transform;
				BoxCollider boxCollider = temporary.GetComponent<BoxCollider>() as BoxCollider;
				boxCollider.size = new Vector3(sensitivity, 1, sensitivity);
				temporary.GetComponent<Letters>().letter.text = "";
				temporary.GetComponent<Letters>().gridX = i;
				temporary.GetComponent<Letters>().gridY = j;
				cells.Add(cell);
				matrix[i, j] = "";
			}
		}
		Center();
		gridValue = gridX * gridY;
		//Debug.LogError("rtrt"+ gridValue);

		// if you want fill randomly //
		//RandomlyFill();
    }
    private void Center()
	{
        backgroundObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, (Screen.height / 2) + 50, 200));
	}

    private void BackGround()
	{
		if (gridX % 2 != 0 && gridY % 2 == 0) {
			backgroundObject = Instantiate (background, new Vector3 ((cell.transform.localScale.x * spacing)
			* (gridX / 2), 1, (cell.transform.localScale.z * spacing)
			* (gridY / 2) - (cell.transform.localScale.z * spacing)), Quaternion.identity) as GameObject;
		} else if (gridX % 2 == 0 && gridY % 2 != 0) {
			backgroundObject = Instantiate (background, new Vector3 ((cell.transform.localScale.x * spacing) * (gridX / 2)
			- (cell.transform.localScale.x * spacing), 1, (cell.transform.localScale.z * spacing) * (gridY / 2)), Quaternion.identity) as GameObject;
		} else {
			backgroundObject = Instantiate(background, new Vector3 ((cell.transform.localScale.x * spacing) * (gridX / 2) -
				(cell.transform.localScale.x * spacing), 1, (cell.transform.localScale.z * spacing) * (gridY / 2) - (cell.transform.localScale.z * spacing)), Quaternion.identity) as GameObject;
		}
        backgroundObject.transform.eulerAngles = new Vector3(180, 0, 0);
        backgroundObject.transform.localScale = new Vector3(((cell.transform.localScale.x * spacing) * gridX), 1, ((cell.transform.localScale.x * spacing) * gridY));
	} 
    void Update()
	{
		if (istimer== true)
		{
			currentTime -= 1 * Time.deltaTime;
			_Timer.text = currentTime.ToString("0");
		}
		
		if (Input.anyKey)
		{
			msg.SetActive(false);
			istimer = true;
		}

		
			if (Input.GetMouseButton(1))
			{
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					current = hit.transform.gameObject;
				}
				isfill = true;
			}
	
		
		if (Input.GetMouseButton (0))
		{
			if (gridValue == 0)
			{
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					current = hit.transform.gameObject;
				}
				ready = true;
			}
			else
			{
				wordMatchText.gameObject.SetActive(true);
				wordMatchText.text = "Fill all the cells".ToString();
				Invoke("msgOff", 1.5f);
			}
		}

		if (Input.GetMouseButtonUp(0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				current = hit.transform.gameObject;	
			}
			lastStr = selectedString;
			if (lastStr.Length >= 3 && lastStr.Length < 10)
			{
				WordVerify();
			}
			else
			{
				wordMatchText.gameObject.SetActive(true);
				wordMatchText.text = "Minimum length of word is 3 and maximum is 9!".ToString();
				Invoke("msgOff", 1.5f);
			}
		}

	}
	public void WordVerify()
	{
		if (!isCorrect)
		{
			foreach (var x in txtContent)
			{
				if (lastStr.ToLower() == x.ToLower())
				{
					Debug.LogError("Matched" + lastStr.ToString());
					wordMatchText.gameObject.SetActive(true);
					wordMatchText.text = "Word match in current dictionary.".ToString();
					GameObject temp = Instantiate(wordList, new Vector3(-390, y, 0), Quaternion.identity) as GameObject;
					temp.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
					temp.GetComponent<Text>().text = lastStr.ToString();
					Invoke("msgOff", 3.0f);
					isCorrect = true;
					y -= 20;
				}
			}
		}
		selectedString = "";
		selected.Clear();
		isCorrect = false;	
		ready = false;	
	}

	void msgOff()
	{
		wordMatchText.gameObject.SetActive(false);
	}
	private void RandomlyFill()
	{
		for (int i = 0; i < gridX; i++)
		{
			for (int j = 0; j < gridY; j++)
			{
				if (matrix[i, j] == "")
				{
					matrix[i, j] = alphabets[UnityEngine.Random.Range(0, alphabets.Length)];
					GameObject.Find("cell-" + i.ToString() + "-" + j.ToString()).GetComponent<Letters>().letter.text = matrix[i, j];
				}
			}
		}
	}

}