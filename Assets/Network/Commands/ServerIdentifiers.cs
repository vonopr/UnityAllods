﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum ServerIdentifiers
{
    // login
    ClientAuth,
    RequestDownloadStart,
    RequestDownloadContinue,
    RequestGamestate,

    // map
    ChatMessage,
    MoveUnit,
    AttackUnit,
    CastToUnit,
    CastToArea,

    RespawnAvatar,

    ItemMove,

    UnitPickup,

    UseStructure,
    LeaveStructure,

    ShopCancel,
    ShopBuy,
    ShopSell
}