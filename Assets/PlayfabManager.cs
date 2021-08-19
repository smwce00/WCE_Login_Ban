using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using PlayFab;
using PlayFab.ClientModels;

public class PlayfabManager : MonoBehaviour
{
    public InputField EmailInPut, PasswordInput, UsernameInput;

    public void LoginBtn()
    {
        var request = new LoginWithEmailAddressRequest { Email = EmailInPut.text, Password = PasswordInput.text };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnLoginFailure);
    }


    public void RegisterBtn()
    {
        var request = new RegisterPlayFabUserRequest { Email = EmailInPut.text, Password = PasswordInput.text, Username = UsernameInput.text };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnRegisterFailure);
    }


    void OnLoginSuccess(LoginResult result) => print("�α��� ����");

    void OnLoginFailure(PlayFabError error) => print("�α��� ����");

    void OnRegisterSuccess(RegisterPlayFabUserResult result) => print("ȸ������ ����");

    void OnRegisterFailure(PlayFabError error) => print("ȸ������ ����");

}




