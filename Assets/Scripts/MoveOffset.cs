using UnityEngine;
using System.Collections;

public class MoveOffset : MonoBehaviour {

	private Material currentMaterial; // Referência ao material do objeto
	public float speed;              // Velocidade de movimento do offset
	private float offset;            // Valor do deslocamento

	void Start () {
		// Obtém o material do objeto
		currentMaterial = GetComponent<Renderer>().material;
	}

	void Update () {
		// Incrementa o valor do deslocamento com base na velocidade e no tempo decorrido
		offset += speed * Time.deltaTime;

		// Define o deslocamento do material, afetando a textura utilizada
		currentMaterial.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}
}
