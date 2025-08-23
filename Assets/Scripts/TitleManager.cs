using UnityEngine;
using UnityEngine.SceneManagement; // �V�[���J�ڂ���ׂɕK�v
using UnityEngine.UI; // UI�ׂ̈ɕK�v
using UnityEngine.EventSystems;

public class TitleManager : MonoBehaviour
{
    [Header("�X�^�[�g�{�^��")]
    public Button StartButton; // �Q�[���J�n���ɉ����{�^��

    /// <summary>
    /// �Q�[���N����A�ŏ��Ɉ�x�����Ă΂�鏈��
    /// </summary>
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(StartButton.gameObject);

        // �X�^�[�g�{�^���������ꂽ�Ƃ��ɁA�w�肵���V�[����ǂݍ���
        StartButton.onClick.AddListener(() =>
        {
            // �V�[���� ��ǂݍ���ňڍs
            SceneManager.LoadScene("practice");
        });
    }
}
