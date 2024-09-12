using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntuacion : MonoBehaviour
{
    public int score;  // Puntuaci�n actual
    public TMP_Text scoreText;  // Referencia al texto de la puntuaci�n
    public GameObject winnerText;  // Referencia al texto "Winner" (aseg�rate de vincularlo en el inspector)

    void Start()
    {
        winnerText.SetActive(false);  // Aseg�rate de que el texto "Winner" est� oculto al iniciar el juego
    }

    // M�todo para actualizar la puntuaci�n
    public void actualizar(int puntos)
    {
        score += puntos;
        scoreText.text = "score: " + score;

        // Verifica si la puntuaci�n ha alcanzado 100
        if (score >= 100)
        {
            MostrarTextoWinner();  // Llama al m�todo para mostrar el texto "Winner"
            PausarJuego();  // Pausa el juego
        }
    }

    // M�todo para mostrar el texto "Winner"
    void MostrarTextoWinner()
    {
        winnerText.SetActive(true);  // Muestra el texto "Winner"
    }

    // M�todo para pausar el juego
    void PausarJuego()
    {
        Time.timeScale = 0;  // Pausa el juego
        Debug.Log("�Puntuaci�n alcanzada! El juego est� pausado.");
    }
}
