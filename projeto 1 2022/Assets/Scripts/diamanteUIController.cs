
using System;
using UnityEngine;
using TMPro;

public class diamanteUIController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private TMP_Text diamanteText;

    private void OnEnable()
    {
        PlayerObserverManager.OnDiamantesChanged += UpdatediamanteText;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnDiamantesChanged -= UpdatediamanteText;
    }

    private void UpdatediamanteText(int newdiamanteValue)
    {
        diamanteText.text = newdiamanteValue.ToString();
    }
}
