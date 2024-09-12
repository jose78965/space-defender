using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntuacion : MonoBehaviour
{
    public int score;  // Puntuación actual
    public TMP_Text scoreText;  // Referencia al texto de la puntuación
    public GameObject winnerText;  // Referencia al texto "Winner" (asegúrate de vincularlo en el inspector)

    void Start()
    {
        winnerText.SetActive(false);  // Asegúrate de que el texto "Winner" esté oculto al iniciar el juego
    }

    // Método para actualizar la puntuación
    public void actualizar(int puntos)
    {
        score += puntos;
        scoreText.text = "score: " + score;

        // Verifica si la puntuación ha alcanzado 100
        if (score >= 100)
        {
            MostrarTextoWinner();  // Llama al método para mostrar el texto "Winner"
            PausarJuego();  // Pausa el juego
        }
    }

    // Método para mostrar el texto "Winner"
    void MostrarTextoWinner()
    {
        winnerText.SetActive(true);  // Muestra el texto "Winner"
    }

    // Método para pausar el juego
    void PausarJuego()
    {
        Time.timeScale = 0;  // Pausa el juego
        Debug.Log("¡Puntuación alcanzada! El juego está pausado.");
    }
}
