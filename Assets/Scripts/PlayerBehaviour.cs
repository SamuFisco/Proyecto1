using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 10f; //para aplicar la fuerza de Salto
    public float moveSpeed = 5f; //para aplicar la fuerza de movimiento 
    public int monedasObtenidas = 0;
    public int coins = 0;
    public TextMeshProUGUI coinsText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }
        Vector3 movement = new Vector3(); //solo se utiliza aquí
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        rb.MovePosition((rb.position + movement) * Time.deltaTime * moveSpeed);
        //rbJugador.Addforce(movement * Time.deltaTime * movimientoPj, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CoinItem"))
        {
            Debug.Log("Tocando una moneda");
            coins = coins + 1;
            //coins++;
        }

        else if (other.CompareTag("SpecialCoin"))
        {
            Debug.Log ("monedasObtenidas");
            coins += 5; //coins = coins +5;
        }

        if (other.tag.Contains("Coin"))
        {
            coinsText.text = coins.ToString(); //ToString ¿?
            other.gameObject.SetActive(false);
        }

        

      
    }

}
