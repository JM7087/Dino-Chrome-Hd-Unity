using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public UnityEngine.UI.Text pontos;  // Referência ao texto dos pontos na interface do usuário
	public UnityEngine.UI.Text recorde; // Referência ao texto do recorde na interface do usuário

	// Use this for initialization
	void Start () {
	
		// Define o texto dos pontos usando o valor salvo no PlayerPrefs, convertido para string
		pontos.text = PlayerPrefs.GetInt("pontuacao").ToString();

		// Define o texto do recorde usando o valor salvo no PlayerPrefs, convertido para string
		recorde.text = PlayerPrefs.GetInt("recorde").ToString();
	}

}
