﻿#if !DISABLESTEAMWORKS && HE_SYSCORE && (STEAMWORKSNET || FACEPUNCH)
using Steamworks;
using UnityEngine.Events;

namespace HeathenEngineering.SteamworksIntegration
{
    [System.Serializable]
    public class SteamRemotePlaySessionDisconnectedEvent : UnityEvent<SteamRemotePlaySessionDisconnected_t> { }
}
#endif