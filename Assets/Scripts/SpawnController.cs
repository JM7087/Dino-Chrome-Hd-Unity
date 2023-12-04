using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

	public GameObject barreiraPrefab; // Objeto a ser spawnado
	public float rateSpawn;          // Intervalo de spawn
	private float currentTime;       // Tempo atual
	private int posicao;             // Posição para determinar o spawn

	// Inicialização
	void Start () {
		currentTime = 0; // Define o tempo atual como zero no início
	}
	
	// Atualização é chamada a cada quadro (frame)
	void Update () {

		currentTime += Time.deltaTime; // Adiciona o tempo decorrido desde o último quadro ao tempo atual

		// Verifica se o tempo atual é maior ou igual ao intervalo de spawn
		if(currentTime >= rateSpawn)
		{
			currentTime = 0; // Reinicia o tempo atual

			posicao = Random.Range(1, 100); // Gera um número aleatório entre 1 e 100 para determinar a posição do spawn

			/* Seção estar desativada mas é para mudar o eixo do objeto
			if(posicao > 50)
			{
				x = posA;
			}
			else
			{
				x = posB;
			}*/

			// Cria um objeto a partir do prefab e o instancia como um GameObject
			GameObject tempPreFab = Instantiate(barreiraPrefab) as GameObject;

			// Define a posição do objeto instanciado para a posição atual do SpawnController
			tempPreFab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		}
	}
}
