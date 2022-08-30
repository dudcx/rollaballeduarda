using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObserverManager
{
   public static Action<int> OnCoinsChanged;

   public static Action<int> OnDiamantesChanged;

   public static void CoinsChanged(int value)
   {
      OnCoinsChanged?.Invoke(value);
   }
   
   public static void DiamantesChanged(int value)
   {
      OnDiamantesChanged?.Invoke(value);
   }
}
