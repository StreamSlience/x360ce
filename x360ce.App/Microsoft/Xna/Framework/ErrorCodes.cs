﻿namespace Microsoft.Xna.Framework
{
    using System;

    internal enum ErrorCodes : uint
    {
        AccessDenied = 5,
        AlreadyExists = 0xb7,
        Busy = 170,
        D3DERR_CONFLICTINGRENDERSTATE = 0x88760821,
        D3DERR_CONFLICTINGTEXTUREFILTER = 0x8876081e,
        D3DERR_DEVICELOST = 0x88760868,
        D3DERR_DEVICENOTRESET = 0x88760869,
        D3DERR_DRIVERINTERNALERROR = 0x88760827,
        D3DERR_INVALIDCALL = 0x88760872,
        D3DERR_INVALIDDEVICE = 0x88760871,
        D3DERR_MOREDATA = 0x88760867,
        D3DERR_NOTAVAILABLE = 0x88760870,
        D3DERR_NOTFOUND = 0x88760866,
        D3DERR_OUTOFVIDEOMEMORY = 0x8876017c,
        D3DERR_TOOMANYOPERATIONS = 0x8876081d,
        D3DERR_UNSUPPORTEDALPHAARG = 0x8876081c,
        D3DERR_UNSUPPORTEDALPHAOPERATION = 0x8876081b,
        D3DERR_UNSUPPORTEDCOLORARG = 0x8876081a,
        D3DERR_UNSUPPORTEDCOLOROPERATION = 0x88760819,
        D3DERR_UNSUPPORTEDFACTORVALUE = 0x8876081f,
        D3DERR_UNSUPPORTEDTEXTUREFILTER = 0x88760822,
        D3DERR_WRONGTEXTUREFORMAT = 0x88760818,
        E_ABORT = 0x80004004,
        E_ACCESSDENIED = 0x80070005,
        E_FAIL = 0x80004005,
        E_INVALIDARG = 0x80070057,
        E_NOTIMPL = 0x80004001,
        E_OUTOFMEMORY = 0x8007000e,
        Empty = 0x10d2,
        ERROR_SHARING_VIOLATION = 0x80070020,
        NotConnected = 0x48f,
        Pending = 0x3e5,
        REGDB_E_CLASSNOTREG = 0x80040154,
        Success = 0,
        VFW_E_NO_AUDIO_HARDWARE = 0x80040256,
        XACTENGINE_E_ALREADYINITIALIZED = 0x8ac70001,
        XACTENGINE_E_AUDITION_CREATEDIRECTORYFAILED = 0x8ac70108,
        XACTENGINE_E_AUDITION_INVALIDDSPINDEX = 0x8ac70106,
        XACTENGINE_E_AUDITION_INVALIDRPCINDEX = 0x8ac70103,
        XACTENGINE_E_AUDITION_INVALIDSESSION = 0x8ac70109,
        XACTENGINE_E_AUDITION_MISSINGDATA = 0x8ac70104,
        XACTENGINE_E_AUDITION_MISSINGWAVE = 0x8ac70107,
        XACTENGINE_E_AUDITION_NOSOUNDBANK = 0x8ac70102,
        XACTENGINE_E_AUDITION_UNKNOWNCOMMAND = 0x8ac70105,
        XACTENGINE_E_AUDITION_WRITEFILE = 0x8ac70101,
        XACTENGINE_E_EXPIRED = 0x8ac70003,
        XACTENGINE_E_INCALLBACK = 0x8ac70012,
        XACTENGINE_E_INSTANCELIMITFAILTOPLAY = 0x8ac70008,
        XACTENGINE_E_INVALIDCATEGORY = 0x8ac7000b,
        XACTENGINE_E_INVALIDCUEINDEX = 0x8ac7000c,
        XACTENGINE_E_INVALIDDATA = 0x8ac70007,
        XACTENGINE_E_INVALIDENTRYCOUNT = 0x8ac70018,
        XACTENGINE_E_INVALIDSOUNDOFFSETORINDEX = 0x8ac7000f,
        XACTENGINE_E_INVALIDTRACKINDEX = 0x8ac7000e,
        XACTENGINE_E_INVALIDUSAGE = 0x8ac70006,
        XACTENGINE_E_INVALIDVARIABLEINDEX = 0x8ac7000a,
        XACTENGINE_E_INVALIDWAVEINDEX = 0x8ac7000d,
        XACTENGINE_E_MULTIPLEAUDITIONENGINES = 0x8ac70015,
        XACTENGINE_E_NOGLOBALSETTINGS = 0x8ac70009,
        XACTENGINE_E_NONOTIFICATIONCALLBACK = 0x8ac70004,
        XACTENGINE_E_NORENDERER = 0x8ac70017,
        XACTENGINE_E_NOTIFICATIONREGISTERED = 0x8ac70005,
        XACTENGINE_E_NOTINITIALIZED = 0x8ac70002,
        XACTENGINE_E_NOWAVEBANK = 0x8ac70013,
        XACTENGINE_E_READFILE = 0x8ac70010,
        XACTENGINE_E_SEEKTIMEBEYONDCUEEND = 0x8ac70019,
        XACTENGINE_E_SELECTVARIATION = 0x8ac70014,
        XACTENGINE_E_UNKNOWNEVENT = 0x8ac70011,
        XACTENGINE_E_WAVEBANKNOTPREPARED = 0x8ac70016,
        ZDKSYSTEM_E_AUDIO_INSTANCELIMIT = 0x8bad0001,
        ZDKSYSTEM_E_AUDIO_INVALIDDATA = 0x8bad0003,
        ZDKSYSTEM_E_AUDIO_INVALIDSTATE = 0x8bad0002
    }
}

