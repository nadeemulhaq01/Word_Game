using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Letters : MonoBehaviour {
	
    public bool utilized = false;
    public bool identified = false;
	public TextMesh letter;
	public int gridX, gridY;

	

    void Start()
	{
        GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
    }
    
    void Update()
	{
		
		if (letter.text.Length == 0)
		{
			if (Input.GetKey(KeyCode.A) && WordSearch.Instance.isfill)
			{
				if (WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;
					letter.text = "A";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.B) && WordSearch.Instance.isfill)
			{				
				if (WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "B";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.C) && WordSearch.Instance.isfill)
			{				
				if (WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "C";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.D) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "D";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.E) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "E";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.F) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "F";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.G) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "G";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.H) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "H";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.I) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "I";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.J) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "J";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.K) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "K";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.L) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "L";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.M) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "M";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.N) && WordSearch.Instance.isfill)
			{				
				if (WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "N";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.O) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "O";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.P) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "P";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.Q) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "Q";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.R) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "R";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.S) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "S";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.T) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "T";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.U) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "U";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.V) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "V";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.W) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "W";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.X) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;					
					letter.text = "X";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.Y) && WordSearch.Instance.isfill)
			{				
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;				
					letter.text = "Y";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
			if (Input.GetKey(KeyCode.Z) && WordSearch.Instance.isfill)
			{
				if ( WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;
					WordSearch.Instance.selectedString += letter.text;
					letter.text = "Z";
					WordSearch.Instance.gridValue -= 1;
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
				}
			}
		}

		if (WordSearch.Instance.gridValue ==0 && letter.text.Length != 0)
		{
			if (WordSearch.Instance.ready)
			{
				if (!utilized && WordSearch.Instance.current == gameObject)
				{
					WordSearch.Instance.selected.Add(this.gameObject);
					GetComponent<Renderer>().materials[0].color = WordSearch.Instance.mouseoverTint;
					WordSearch.Instance.selectedString += letter.text;
					utilized = true;
				}
			}
		}

		if (identified)
		{
			if (GetComponent<Renderer>().materials[0].color != WordSearch.Instance.identifiedTint) {
				GetComponent<Renderer>().materials[0].color = WordSearch.Instance.identifiedTint;
			} 
			return;
        }

        if (Input.GetMouseButtonUp(0)) {
            utilized = false;
			if (GetComponent<Renderer>().materials[0].color != WordSearch.Instance.defaultTint)
			{
				GetComponent<Renderer>().materials[0].color = WordSearch.Instance.defaultTint;
			}
        }
	}
}
