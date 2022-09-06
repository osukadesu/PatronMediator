using UnityEngine;
using UnityEngine.UI;

public class Registrar : MonoBehaviour
{
    [SerializeField]
    private Button _btnGuardar;

    [SerializeField]
    private GameObject Canvas;

    private Mediator _mediator;

    private void Awake()
    {
        _btnGuardar.onClick.AddListener(() => _mediator.BackToRegistrar());
        _btnGuardar.onClick.AddListener(() => _mediator.Registrado());
    }

    public void Configure(Mediator mediator)
    {
        _mediator = mediator;
    }

    public void Show()
    {
        Canvas.SetActive(true);
    }

    public void Hide()
    {
        Canvas.SetActive(false);
    }
}
