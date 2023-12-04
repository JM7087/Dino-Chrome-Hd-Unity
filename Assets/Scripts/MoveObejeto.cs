using UnityEngine;
using System.Collections;

public class MoveObejeto : MonoBehaviour {

	public  float speed;      // Velocidade de movimento do objeto
	private float x;          // Posição horizontal do objeto
	public GameObject Player; // Referência ao objeto do jogador
	private bool pomtuado;    // Verifica se o objeto já foi pontuado

	// Use this for initialization
	void Start () {

		// Encontra o objeto do jogador com o nome "Player"
		Player = GameObject.Find("Player") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {

		// Obtém a posição atual do objeto no eixo x
		x = transform.position.x;

		// Move o objeto na direção do eixo x usando a velocidade e o tempo
		x += speed * Time.deltaTime;

		// Define a nova posição do objeto
		transform.position = new Vector3(x, transform.position.y, transform.position.z);

		// Verifica se o objeto saiu da tela pela esquerda
		if(x <= -2)
		{
			// Destroi o objeto
			Destroy(transform.gameObject);
		}

		// Verifica se o objeto passou pelo jogador
		if(x < Player.transform.position.x && pomtuado == false)
		{
			pomtuado = true; // Marca o objeto como pontuado para evitar repetições
			
			// Incrementa a pontuação dos jogadores (PlayerController e Player2) em 1 ponto
			PlayerController.pontuacao += 1;
			Player2.pontuacao += 1;
		}
	}
}
