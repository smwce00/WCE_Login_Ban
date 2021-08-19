using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using PlayFab.ServerModels;
using System;

public class BanManager : MonoBehaviour
{

    public InputField IDInput, HourInput, ReasonInput;

    public void RegisterBtn()
    {
        
    PlayFabServerAPI.BanUsers(new BanUsersRequest()
            {
                Bans = new List<BanRequest>() {
            new BanRequest() {
                DurationInHours =uint.Parse(HourInput.text),
                PlayFabId = IDInput.text,
                Reason = ReasonInput.text,
            }
        }
            }, result => {
                print("����");
            }, error => {
                Debug.Log(error.GenerateErrorReport());
            });
        
    }
 }
