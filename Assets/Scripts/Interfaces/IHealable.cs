﻿using System.Collections.Generic;
using UnityEngine;

public interface IHealable
{
    void Heal(int healing);
    GameObject GetGameObject();
}