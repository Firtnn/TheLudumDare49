using UnityEngine;
using UnityEngine.UI;

public class FearManager : MonoBehaviour
{
    public float currentFear = 0f;
    public bool isLighted = false;

    public CameraShake cameraShake;
    public EmotionBar emotionBar;
    private float _fear;

    private void Update()
    {
        if(!isLighted && currentFear < 100)
        {
            _fear = (1f *Time.deltaTime)*14;
            Feared(_fear);
        }
        else if(currentFear > 0f && isLighted)
        {
            _fear = -(1f *Time.deltaTime)*17;
            Feared(_fear);
        }

        if (currentFear > 100)
        {
            HealthManager.instance.Health(-1);
            PlayerController.instance.movementSpeed += 1;
            currentFear = 0;
            emotionBar.ResetBar(0);
            End.instance.Position();
            StartCoroutine(cameraShake.Shake(.15f, .25f));
            
        }
        else if (currentFear < 0)
        {
            currentFear = 0;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        isLighted = false;
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Light"))
        {
            isLighted = true;
        }
    }

    private void Feared(float feared)
    {
        currentFear += feared;
        emotionBar.SetEmotion(feared);
    }
    
}
