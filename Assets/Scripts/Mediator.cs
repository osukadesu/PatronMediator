using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mediator : MonoBehaviour
{
    [SerializeField]
    private Ingresar _ingresar;

    [SerializeField]
    private Registrar _registrar;

    private void Awake()
    {
        _registrar.Configure(this);
        _ingresar.Configure(this);
        _registrar.Hide();
    }

    public void BackToRegistrar()
    {
        _ingresar.Show();
        _registrar.Hide();
    }

    public void StartGame()
    {
        Debug.Log("¡Usuario Conectado!");
    }

    public void Registrado()
    {
        Debug.Log("¡Usuario Registrado!");
    }

    public void MoveToRegistrar()
    {
        _ingresar.Hide();
        _registrar.Show();
    }
}
