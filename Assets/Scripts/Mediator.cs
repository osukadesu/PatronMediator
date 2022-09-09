using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mediator : MonoBehaviour
{
    [SerializeField]
    private Ingresar _ingresar;

    [SerializeField]
    private Registrar _registrar;

    [SerializeField]
    private Text

            txtRegistrado,
            txtConectado;

    private void Awake()
    {
        _registrar.Configure(this);
        _ingresar.Configure(this);
        _registrar.Hide();
    }

    public void ViewRegistrar()
    {
        _registrar.Show();
        _ingresar.Hide();
    }

    public void ViewIngresar()
    {
        _ingresar.Show();
        _registrar.Hide();
    }

    public void Registrado()
    {
        txtRegistrado.text = "¡Usuario Registrado!";
    }

    public void StartGame()
    {
        txtConectado.text = "¡Usuario Conectado!";
    }
}
