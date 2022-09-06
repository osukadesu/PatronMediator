using UnityEngine;
using UnityEngine.UI;

public class Ingresar : MonoBehaviour
{
    [SerializeField]
    private Button _btningresar;

    [SerializeField]
    private Button _btnregistrar;

    [SerializeField]
    private GameObject Canvas;

    private Mediator _mediator;

    private void Awake()
    {
        _btningresar.onClick.AddListener(() => _mediator.StartGame());
        _btnregistrar.onClick.AddListener(() => _mediator.MoveToRegistrar());
    }

    public void Configure(Mediator mediator)
    {
        _mediator = mediator;
    }

    public void Show()
    {
        Canvas. SetActive(true);
    }

    public void Hide()
    {
        Canvas. SetActive(false);
    }
}
