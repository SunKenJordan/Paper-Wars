using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Cancel"))
		{
			SceneManager.LoadScene(0);
		} 
    }
	
	public void LevelOne()
	{
		SceneManager.LoadScene(1);
	}
}
