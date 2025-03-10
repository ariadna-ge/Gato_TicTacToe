using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gato : MonoBehaviour
{
    public Button btn;
    public Text txtJuego;

    private int[,] matrizGato = new int[3, 3]; //matriz de 3x3 que representa el tablero del juego
    private int turno = 0; // controla el turno del jugador 0=no ha iniciado
    private int ganador = 0, movimientos= 0; //almacena el ganador y número de movimientos

    void Start(){
        IniciarGato(); //llama a la función para inicializar el juego
        txtJuego.text = "JUEGO NUEVO";
    }

    public void AsignaTurno(Button btn){
        if (ObtenValoresMatrizGato(btn.name) == 0 && ganador == 0){
            if (turno == 0){ //inia el juego
                turno = 1; //inicia x
            } else if (turno == 1){
                turno = 2; //continua o
            } else if (turno == 2){
                turno = 1; // continua x
            }

            txtJuego.text = "JUEGO EN CURSO";
            DibujaSimbolo(btn, turno);
            EscribirValorMatrizGato(btn.name, turno);
            movimientos++;
            VerificaGanador();
        }
    }

    private void DibujaSimbolo(Button btn, int t){
        if (t==1){
            btn.GetComponentInChildren<Text>().text = "x";
        } else{
            btn.GetComponentInChildren<Text>().text = "o";
        }
    }

    private int ObtenValoresMatrizGato(string btn){
        int a = -1;
        switch(btn){
            case "G0":
                a = matrizGato[0,0];
            break;
            case "G1":
                a = matrizGato[0,1];
            break;
            case "G2":
                a = matrizGato[0,2];
            break;
            case "G3":
                a = matrizGato[1,0];
            break;
            case "G4":
                a = matrizGato[1,1];
            break;
            case "G5":
                a = matrizGato[1,2];
            break;
            case "G6":
                a = matrizGato[2,0];
            break;
            case "G7":
                a = matrizGato[2,1];
            break;
            case "G8":
                a = matrizGato[2,2];
            break;
        }
        return a;
        //Debug.Log("Botón presionado: " + a.ToString());
    }

    private void EscribirValorMatrizGato(string btn, int t){
        switch(btn){
            case "G0":
                matrizGato[0,0] = t;
            break;
            case "G1":
                matrizGato[0,1] = t;
            break;
            case "G2":
                matrizGato[0,2] = t;
            break;
            case "G3":
                matrizGato[1,0] = t;
            break;
            case "G4":
                matrizGato[1,1] = t;
            break;
            case "G5":
                matrizGato[1,2] = t;
            break;
            case "G6":
                matrizGato[2,0] = t;
            break;
            case "G7":
                matrizGato[2,1] = t;
            break;
            case "G8":
                matrizGato[2,2] = t;
            break;
        }
    }
    
    private void VerificaGanador(){
    for (int i = 0; i < 3; i++) { // Verificar filas
        if (matrizGato[i, 0] == 1 && matrizGato[i, 1] == 1 && matrizGato[i, 2] == 1){
            ganador = 1; // Gana x
        }
        if (matrizGato[i, 0] == 2 && matrizGato[i, 1] == 2 && matrizGato[i, 2] == 2){
            ganador = 2; // Gana o
        }
    }
    for (int i = 0; i < 3; i++) { // Verificar columnas
        if (matrizGato[0, i] == 1 && matrizGato[1, i] == 1 && matrizGato[2, i] == 1){
            ganador = 1; // Gana x
        }
        if (matrizGato[0, i] == 2 && matrizGato[1, i] == 2 && matrizGato[2, i] == 2){
            ganador = 2; // Gana o
        }
    }

    // Verificar diagonal principal
    if (matrizGato[0, 0] == 1 && matrizGato[1, 1] == 1 && matrizGato[2, 2] == 1){
        ganador = 1; // Gana x
    }
    if (matrizGato[0, 0] == 2 && matrizGato[1, 1] == 2 && matrizGato[2, 2] == 2){
        ganador = 2; // Gana o
    }

    // Verificar diagonal inversa
    if (matrizGato[0, 2] == 1 && matrizGato[1, 1] == 1 && matrizGato[2, 0] == 1){
        ganador = 1; // Gana x
    }
    if (matrizGato[0, 2] == 2 && matrizGato[1, 1] == 2 && matrizGato[2, 0] == 2){
        ganador = 2; // Gana o
    }

    if (ganador == 0 && movimientos == 9){
        txtJuego.text = "EMPATE";
    }

    if (ganador == 1){
        txtJuego.text = "GANADOR: X";
    }

    if (ganador == 2){
        txtJuego.text = "GANADOR: O";
    }
    }

    private void IniciarGato(){
        // inicia la matriz en ceros
        for(int i= 0; i<3; i++){
            for(int j=0; j<3; j++){
                matrizGato[i,j] = 0;
            }
        }
        // Limpia los textos de los botones (celdas del tablero)
        GameObject.Find("G0").GetComponentInChildren<Text>().text = "";
        GameObject.Find("G1").GetComponentInChildren<Text>().text = "";
        GameObject.Find("G2").GetComponentInChildren<Text>().text = "";
        GameObject.Find("G3").GetComponentInChildren<Text>().text = "";
        GameObject.Find("G4").GetComponentInChildren<Text>().text = "";
        GameObject.Find("G5").GetComponentInChildren<Text>().text = "";
        GameObject.Find("G6").GetComponentInChildren<Text>().text = "";
        GameObject.Find("G7").GetComponentInChildren<Text>().text = "";
        GameObject.Find("G8").GetComponentInChildren<Text>().text = "";
    }
}
