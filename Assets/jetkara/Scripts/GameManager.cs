using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject Rightenemies;
	public GameObject Leftenemies;
	public float currentTime;
	public TextMesh scoreLabel;
	public static float score;
	public float Score
	{
		set
		{
			score = value;

			scoreLabel.text = Score.ToString();
		}
		get
		{
			return score;
		}
	}

	void Start () 
	{
		score = currentTime;

		InvokeRepeating("CreateObjects", 1,2);
		
	}
    public void Update()
    {
		currentTime += 1 * Time.deltaTime;
		Debug.Log(currentTime);
    }
    void CreateObjects()
	{

		Instantiate(Leftenemies, new Vector3(Random.Range(7f, 7f), Random.Range(-3f, 3f), 0), Quaternion.identity);
		Instantiate(Leftenemies, new Vector3(Random.Range(7f, 7f), Random.Range(-3f, 3f), 0), Quaternion.identity);
		Instantiate(Rightenemies, new Vector3(Random.Range(-7f, -7f), Random.Range(-3f, 3f), 0), Quaternion.identity);
		Instantiate(Rightenemies, new Vector3(Random.Range(-7f, -7f), Random.Range(-3f, 3f), 0), Quaternion.identity);

	}
}
