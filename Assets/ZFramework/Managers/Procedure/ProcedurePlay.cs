﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System.Threading.Tasks;
namespace Zframework
{

    public class ProcedurePlay : ProcedureBase
    {
        
        public override void OnEnter(object userData = null)
        {
            Z.Audio.PlayBackGroundMusic("Assets/GameData/Sounds/menusound.mp3");
        }
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Z.Unit.Release(0, true);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Z.Unit.Release(0, false);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Z.Obs.ForLoop(5, _ => Z.Unit.LoadUnit("Assets/GameData/Prefabs/Attack.prefab"));
            }
        }
    }
}