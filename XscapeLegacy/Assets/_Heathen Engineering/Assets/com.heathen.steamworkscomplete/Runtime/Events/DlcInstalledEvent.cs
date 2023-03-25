﻿#if !DISABLESTEAMWORKS && HE_SYSCORE && (STEAMWORKSNET || FACEPUNCH)
using Steamworks;
using UnityEngine.Events;

namespace HeathenEngineering.SteamworksIntegration
{
#if STEAMWORKSNET
    [System.Serializable]
    public class DlcInstalledEvent : UnityEvent<DlcInstalled_t> { }
#elif FACEPUNCH
    [System.Serializable]
    public class DlcInstalledEvent : UnityEvent<AppId> { }
#endif
}
#endif