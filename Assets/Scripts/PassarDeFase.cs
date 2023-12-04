using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class PassarDeFase : MonoBehaviour {
	
	// Update é chamado a cada quadro (frame)
	void Update () {
	
		// Verifica se a pontuação do PlayerController é igual a 50
		if(PlayerController.pontuacao == 50)
		{
			// Carrega a cena "Game2"
			SceneManager.LoadScene("Game2");

			// Define a pontuação do Player2 como a pontuação atual do PlayerController
			Player2.pontuacao = PlayerController.pontuacao;		

			// Reseta a pontuação do PlayerController para um valor específico (-99999)
			PlayerController.pontuacao = -99999;

			// Define a variável voltaAfaseQueEstava do ScriptsMenuDeFases como 2
			ScriptsMenuDeFases.voltaAfaseQueEstava = 2;
		}

		// Verifica se a pontuação do Player2 é igual a 100
		if(Player2.pontuacao == 100)
		{
			// Carrega a cena "Game3"
			SceneManager.LoadScene("Game3");

			// Define a variável voltaAfaseQueEstava do ScriptsMenuDeFases como 3
			ScriptsMenuDeFases.voltaAfaseQueEstava = 3;

			// Incrementa a pontuação do Player2 em 1
			Player2.pontuacao = Player2.pontuacao + 1;
		}
	}
}
