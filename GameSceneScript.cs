using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneScript : MonoBehaviour
{
    // Referenz auf das PlayerController-Skript des Spielers
    public PlayerController player;
    // Referenz auf die Spielkamera
    public Camera gameCamera;

    // Start wird einmal am Anfang des Spiels aufgerufen
    void Start()
    {
        
    }

    // Update wird einmal pro Frame aufgerufen
    void Update()
    {
        // Aktualisiert die Position der Kamera, um dem Spieler zu folgen
        gameCamera.transform.position = new Vector3(
            Mathf.Lerp(gameCamera.transform.position.x, player.transform.position.x, 0.01f),  // Gleitet langsam zur x-Position des Spielers
            player.transform.position.y,  // Setzt die Kamera y-Position auf die y-Position des Spielers
            Mathf.Lerp(gameCamera.transform.position.z, player.transform.position.z - 15, 0.01f)  // Gleitet zur z-Position des Spielers minus 15
        );
    }
}
