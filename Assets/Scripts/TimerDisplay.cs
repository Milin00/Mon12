using UnityEngine;
using TMPro; // TextMeshPro ���g�p���邽�߂̖��O���

public class TimerDisplay : MonoBehaviour
{
    [Header("���Ԃ�\������ UI �e�L�X�g (TextMeshPro)")]
    public TextMeshProUGUI timerText; // �^�C�}�[�̎c�莞�Ԃ�\������ TextMeshProUGUI

    // �J�E���g�_�E���̏������ԁi�b�j
    private float timeRemaining = 60f; // �X�^�[�g���̎c�莞�ԁi��F60�b�j

    void Update()
    {
        // �c�莞�Ԃ��܂�����ꍇ
        if (timeRemaining > 0)
        {
            // �o�ߎ��Ԃ����Z�i1�b���ł͂Ȃ��A�t���[�����Ƃɏ���������j
            timeRemaining -= Time.deltaTime;

            // �c�莞�Ԃ��u���v�Ɓu�b�v�ɕ����Đ����Ƃ��Ď擾
            int minutes = Mathf.FloorToInt(timeRemaining / 60); // ���̒l�i�����_�ȉ��؂�̂āj
            int seconds = Mathf.FloorToInt(timeRemaining % 60); // �b�̒l�i60�Ŋ������]��j

            // �e�L�X�g�� mm:ss �`���ŕ\���i�[�����߂�2���\���j
            timerText.text = $"{minutes:D2}:{seconds:D2}";
        }
        else
        {
            // �c�莞�Ԃ�0�ȉ��ɂȂ�����A�u00:00�v�ƕ\����������
            timerText.text = "00:00";
        }
    }
}
