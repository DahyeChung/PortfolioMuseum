using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string sceneName;
    public Material deemphasizedMat;
    public Material emphasizedMat;
    public GameObject player;

    private MeshRenderer meshRenderer;



    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, player.transform.position));

        // compare tag and if the player is close to the door, emphasize it
        if (Vector3.Distance(transform.position, player.transform.position) < 25)
        {
            Debug.Log("문 감지 머티리얼 변경");
            Emphasize();
        }
        else
        {
            Deemphasize();
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("트리거 발동");
            Open();
        }
    }

    public void Emphasize()
    {
        meshRenderer.material = emphasizedMat;
    }

    public void Deemphasize()
    {
        meshRenderer.material = deemphasizedMat;
    }

    public void Open()
    {
        SceneManager.LoadScene(sceneName);
    }
}
