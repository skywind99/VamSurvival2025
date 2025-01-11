using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager instance;// 메모리에 올림
  public Player player;
  void Awake()
  {
    instance = this;
  }

}