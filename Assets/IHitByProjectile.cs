﻿using System;
using UnityEngine;

public interface IHitByProjectile {

   void OnHitByProjectile(int damageReceived, BulletType bulletType, int bulletDirX);

}
