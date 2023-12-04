using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public Animator Anim;                    // Referência para o componente Animator
    public Rigidbody2D PlayerRigidbody;      // Referência para o Rigidbody2D do jogador
    public int ForceJump;                    // Força do pulo

    // VERIFICA O CHÃO
    public Transform GroundChek;             // Posição do objeto que verifica se está no chão
    public bool VerificaOchao;               // Flag para verificar se está no chão
    public LayerMask OqueEchao;              // Máscara para identificar o que é chão

    // Áudio
    public new AudioSource audio;                // Referência ao componente AudioSource
    public AudioClip somJump;                // Som de pulo

    // Pontuação
    public UnityEngine.UI.Text textPontuacao;// Referência ao texto de pontuação na interface
    public static int pontuacao;             // Pontuação do jogador (variável estática)

    // Use this for initialization
    void Start () {
        // Inicializa a pontuação no início do jogo
        pontuacao = 0;
        Player2.pontuacao = 0; // Define a pontuação do segundo jogador como 0
    }

    // Update is called once per frame
    void Update () {
        textPontuacao.text = pontuacao.ToString(); // Atualiza o texto de pontuação na interface

        // Se o botão de pulo for apertado e estiver no chão, aplique força para o pulo
        if (Input.GetButtonDown("Jump") && VerificaOchao == true) {
            PlayerRigidbody.AddForce(new Vector2(0, ForceJump)); // Aplica força para o pulo
            audio.PlayOneShot(somJump); // Toca o som de pulo
        }

        // Verifica se está no chão usando um círculo de colisão
        VerificaOchao = Physics2D.OverlapCircle(GroundChek.position, 0.2f, OqueEchao);

        // Define a variável do Animator para controlar a animação de pulo
        Anim.SetBool("Jump", !VerificaOchao); // Define a animação de pulo com base no estado do chão
    }

    void OnTriggerEnter2D() {
        // Salva a pontuação atual
        PlayerPrefs.SetInt("pontuacao", pontuacao);

        // Verifica e salva o recorde se a pontuação atual for maior
        if (pontuacao > PlayerPrefs.GetInt("recorde")) {
            PlayerPrefs.SetInt("recorde", pontuacao);
        }

        // Carrega a cena de Game Over
        SceneManager.LoadScene("GameOver");
    }
}
