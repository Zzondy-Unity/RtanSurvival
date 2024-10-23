using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //플레이어가 필요한 기능들

    public PlayerController controller;

    private void Awake()
    {
        CharacterManager.Instance.Player = this;    //외부에서 플레이어에게 접근하고 싶을 때 이 함수를 통해 접근가능
        controller = GetComponent<PlayerController>();
    }


}
