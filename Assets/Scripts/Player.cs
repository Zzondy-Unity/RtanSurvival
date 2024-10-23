using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //�÷��̾ �ʿ��� ��ɵ�

    public PlayerController controller;
    public PlayerCondition condition;

    private void Awake()
    {
        CharacterManager.Instance.Player = this;    //�ܺο��� �÷��̾�� �����ϰ� ���� �� �� �Լ��� ���� ���ٰ���
        controller = GetComponent<PlayerController>();
        condition = GetComponent<PlayerCondition>();
    }


}
