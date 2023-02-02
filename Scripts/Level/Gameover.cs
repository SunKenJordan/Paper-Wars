using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
	public GameObject player;
	public GameObject gameover;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<Health>().dead == true)
		{
			gameover.SetActive(true);
		}
    }
	
	public void restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
