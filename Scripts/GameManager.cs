using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager instance;// �޸𸮿� �ø�
  public Player player;
  void Awake()
  {
    instance = this;
  }

}