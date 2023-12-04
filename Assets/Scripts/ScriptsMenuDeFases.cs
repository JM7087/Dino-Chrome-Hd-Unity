using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScriptsMenuDeFases : MonoBehaviour
{

	// VARIAVEL QUE RECEBE MENSAGEM DO MENU DE FASE

	public UnityEngine.UI.Text Mensagem;
	public UnityEngine.UI.Text Carregando;

	public static int voltaAfaseQueEstava;

	// BTNS DO MENU PRINCIPAL

	public void IrParaMenu()

	{
		voltaAfaseQueEstava = 0;

		SceneManager.LoadScene("SelecionarFases");

	}

	public void Jogar()

	{
		voltaAfaseQueEstava = 1;

		SceneManager.LoadScene("Game");

	}

	// Fechar o jogo
    public void FecharJogo()
    {
        Application.Quit();
    }

	// BTNS DO MENU DE FASES

	public void MenuPrincipal()

	{
		Carregando.text = ("Carregando");


		SceneManager.LoadScene("Menu");

		voltaAfaseQueEstava = 0;
	}

	public void Fase1()

	{
		Carregando.text = ("Carregando");

		voltaAfaseQueEstava = 1;

		SceneManager.LoadScene("Game");
	}

	public void Fase2()

	{
		if (PlayerPrefs.GetInt("recorde") >= 50)
		{
			Carregando.text = ("Carregando");

			Player2.pontuacao = 0;

			voltaAfaseQueEstava = 2;

			SceneManager.LoadScene("Game2");
		}

		else
		{

			Mensagem.text = ("Seu Recorde Tem Que Ser Maior Que 50");

		}
	}


	public void Fase3()

	{
		if (PlayerPrefs.GetInt("recorde") >= 100)
		{
			Carregando.text = ("Carregando");

			Player2.pontuacao = 0;

			voltaAfaseQueEstava = 3;

			SceneManager.LoadScene("Game3");
		}

		else
		{

			Mensagem.text = ("Seu Recorde Tem Que Ser Maior Que 100");


		}
	}





	// BTN DE JOGAR DE NOVO DA TELA DE GAME-OVER

	public void JogarDeNovo()

	{
		// voltar a fase 3

		if (voltaAfaseQueEstava == 3)
		{
			Carregando.text = ("Carregando");

			voltaAfaseQueEstava = 3;

			SceneManager.LoadScene("Game3");

		}

		else

			// voltar a fase 2

			if (voltaAfaseQueEstava == 2)
		{
			Carregando.text = ("Carregando");

			voltaAfaseQueEstava = 2;

			SceneManager.LoadScene("Game2");

		}

		else

		// voltar a fase 1


		if (voltaAfaseQueEstava == 1)
		{
			Carregando.text = ("Carregando");

			voltaAfaseQueEstava = 1;

			SceneManager.LoadScene("Game");

		}
	}

}