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


    void OnLoginSuccess(LoginResult result) => print("로그인 성공");

    void OnLoginFailure(PlayFabError error) => print("로그인 실패");

    void OnRegisterSuccess(RegisterPlayFabUserResult result) => print("회원가입 성공");

    void OnRegisterFailure(PlayFabError error) => print("회원가입 실패");

}




