
using UnityEngine;
public class AnimaedSprites : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spritRenderer;
    private int frame;
    private void Awake()
    {
        spritRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        Invoke(nameof(Animate), 0f);
    }

    private void OnDesable() {
        CancelInvoke();
    }

    private void Animate() {
        frame++;
        if(frame >= sprites.Length) {
            frame = 0;
        }

        if(frame >= 0 && frame < sprites.Length) {
             spritRenderer.sprite = sprites[frame];
        }

        Invoke(nameof(Animate), 1f / GameManager.Instance.gameSpeed);



        
    }

   
}
