﻿//////////////////////////////////////////////////////
//製作者　名越大樹
//クラス名　タイムゲイザーアスタのスキルクラス
//////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGeyserAsta : CharacterSkill
{
    [SerializeField]
    SummonStatus parentObj;
    [SerializeField]
    int recoveryValue;

    public override void ActiveSkill()
    {
        Recovery();
    }

    public override void MoveEnd()
    {
        Recovery();
    }

    public override SummonStatus GetCharacter()
    {
        return parentObj;
    }
    void Recovery()
    {

        if (parentObj.GetIsSkillActive() && parentObj.GetSkillCount() <= 0)
        {
            int playernumber = parentObj.GetPlayer();
            MassStatus massstatus = parentObj.GetAttachMass();
            int massnumber = massstatus.GetMaterialNumber();
            if(massnumber != playernumber)
            {
                return;
            }
            Debug.Log("タイムゲイザーアスタのスキル発動");
            SkillManager skillmanager = parentObj.GetSkillManager();
            List<MassStatus> masslist = skillmanager.GetSearchPlayerMass(playernumber);
            for (int count = 0; count < masslist.Count; count++)
            {
                GameObject character = masslist[count].GetCharacterObj();
                if (character != null)
                {
                    SummonStatus status = character.GetComponent<SummonStatus>();
                    if (status.GetPlayer() == playernumber)
                    {
                        Debug.Log("味方キャラクターを発見");
                        status.RecoveryHp(recoveryValue);
                    }
                }
            }
        }
    }

}
