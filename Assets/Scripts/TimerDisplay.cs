using UnityEngine;
using TMPro; // TextMeshPro を使用するための名前空間

public class TimerDisplay : MonoBehaviour
{
    [Header("時間を表示する UI テキスト (TextMeshPro)")]
    public TextMeshProUGUI timerText; // タイマーの残り時間を表示する TextMeshProUGUI

    // カウントダウンの初期時間（秒）
    private float timeRemaining = 60f; // スタート時の残り時間（例：60秒）

    void Update()
    {
        // 残り時間がまだある場合
        if (timeRemaining > 0)
        {
            // 経過時間を減算（1秒ずつではなく、フレームごとに少しずつ減る）
            timeRemaining -= Time.deltaTime;

            // 残り時間を「分」と「秒」に分けて整数として取得
            int minutes = Mathf.FloorToInt(timeRemaining / 60); // 分の値（小数点以下切り捨て）
            int seconds = Mathf.FloorToInt(timeRemaining % 60); // 秒の値（60で割った余り）

            // テキストに mm:ss 形式で表示（ゼロ埋めで2桁表示）
            timerText.text = $"{minutes:D2}:{seconds:D2}";
        }
        else
        {
            // 残り時間が0以下になったら、「00:00」と表示し続ける
            timerText.text = "00:00";
        }
    }
}
