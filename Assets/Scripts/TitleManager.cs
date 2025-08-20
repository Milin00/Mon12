using UnityEngine;
using UnityEngine.SceneManagement; // シーン遷移する為に必要
using UnityEngine.UI; // UIの為に必要

public class TitleManager : MonoBehaviour
{
    [Header("スタートボタン")]
    public Button StartButton; // ゲーム開始時に押すボタン

    /// <summary>
    /// ゲーム起動後、最初に一度だけ呼ばれる処理
    /// </summary>
    void Start()
    {
        // スタートボタンが押されたときに、指定したシーンを読み込む
        StartButton.onClick.AddListener(() =>
        {
            // シーン名 を読み込んで移行
            SceneManager.LoadScene("practice");
        });
    }
}
