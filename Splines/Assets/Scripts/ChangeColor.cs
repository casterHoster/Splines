using DG.Tweening;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] SpriteRenderer _spriteRenderer;
    [SerializeField] Color _color;
    [SerializeField] float _duration;

    private void Start()
    {
        _spriteRenderer.DOFade(_color.a, _duration);
        _spriteRenderer.DOColor(_color, _duration);
    }
}
