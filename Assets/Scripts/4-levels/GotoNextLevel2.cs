using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLevel2 : MonoBehaviour {
    [SerializeField] string scenename;
    [SerializeField] NumberField scoreField;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "player2") {
            SceneManager.LoadScene(scenename);    // Input can either be a serial number or a name; here we use name.
        }
    }
}
