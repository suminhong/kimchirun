using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("텍스처의 스크롤 속도가 얼마나 빨라야 하는가?")]
    public float scrollSpeed;
    [Header("References")]
    public MeshRenderer meshRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime : 이전 프레임부터 현재 프레임까지 몇 초 걸리는지 알려줌
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * GameManager.Instance.CalculateGameSpeed() / 10 * Time.deltaTime, 0);
    }
}
