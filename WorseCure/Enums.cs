using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Enums
{
    [Flags]
    public enum LoginStatus
    {
        CharacterLoginScreen = 0,
        Loading = 1,
        LoggedIn = 2
    }

    public enum Statuses
    {
        KO = 0,
        Weak = 1,
        Sleep = 2,
        Poison = 3,
        Para = 4,
        Silence = 6,
        Petrified = 7,
        Curse = 9,
        Stun = 10,
        Bind = 11,
        Weight = 12,
        Slow = 13,
        Doom = 15,
        Amnesia = 16,
        Charm = 17,
        Asleep = 19,
        Addled = 21,
        Terror = 28,
        Muted = 29,
        Plagued = 31,
        Haste = 33,
        Stoneskin = 37,
        Aquaveil = 39,
        Regen = 42,
        Refresh = 43,
        Berserk = 56,
        Defender = 57,
        Aggressor = 58,
        Warcry = 68,
        Reraise = 113,
        Phalanx = 116,
        Firestorm = 178,
        Hailstorm = 179,
        Windstorm = 180,
        Sandstorm = 181,
        Thunderstorm = 182,
        Rainstorm = 183,
        Aurorastorm = 184,
        Voidstorm = 185,
        SubActive = 187,
        SubComplete = 188,
        Enlight = 274,
        Crusade = 289,
        Hasso = 353,
        LightArts = 358,
        DarkArts = 359,
        [Description("Velocity Shot")]
        VelocityShot = 371,
        WhiteAddendum = 401,
        BlackAddendum = 402,
        Reprisal = 403,
        Klimaform = 407,
        Enlightened = 416,
        AfflatusSolace = 417,
        Composure = 419,
        Favor1 = 422,
        Favor2 = 423,
        Favor3 = 424,
        Favor4 = 425,
        Favor5 = 426,
        Favor6 = 427,
        Favor7 = 428,
        Favor8 = 429,
        Favor9 = 430,
        Favor10 = 431,
        Temper = 432,
        [Description("Double Shot")]
        DoubleShot = 433,
        [Description("Triple Shot")]
        TripleShot = 467,
        Muddle = 473,
        Swordplay = 532,
        [Description("Indi-Regen")]
        IndiRegen = 539,
        [Description("Indi-Refresh")]
        IndiRefresh = 541,
        [Description("Indi-STR")]
        IndiSTR = 542,
        [Description("Indi-DEX")]
        IndiDEX = 543,
        [Description("Indi-VIT")]
        IndiVIT = 545,
        [Description("Indi-AGI")]
        IndiAGI = 545,
        [Description("Indi-INT")]
        IndiINT = 546,
        [Description("Indi-Fury")]
        IndiFury = 549,
        [Description("Indi-Barrier")]
        IndiBarrier = 550,
        [Description("Indi-Acumen")]
        IndiAcumen = 551,
        [Description("Indi-Fend")]
        IndiFend = 552,
        [Description("Indi-Precision")]
        IndiPrecision = 553,
        [Description("Indi-Voidance")]
        IndiVoidance = 554,
        [Description("Indi-Focus")]
        IndiFocus = 555,
        [Description("Indi-Attunement")]
        IndiAttune = 556,
        Battuta = 570,
        [Description("Indi-Haste")]
        IndiHaste = 580,
        Firestorm2 = 589,
        Hailstorm2 = 590,
        Windstorm2 = 591,
        Sandstorm2 = 592,
        Thunderstorm2 = 593,
        Rainstorm2 = 594,
        Aurorastorm2 = 595,
        Voidstorm2 = 596,
        ColureActive = 612
    }
    public enum Jobs
    {
        WAR = 1,
        MNK = 2,
        WHM = 3,
        BLM = 4,
        RDM = 5,
        THF = 6,
        PLD = 7,
        DRK = 8,
        BST = 9,
        BRD = 10,
        RNG = 11,
        SAM = 12,
        NIN = 13,
        DRG = 14,
        SMN = 15,
        BLU = 16,
        COR = 17,
        PUP = 18,
        DNC = 19,
        SCH = 20,
        GEO = 21,
        RUN = 22
    }
    public enum Maneuvers
    {
        None = 0,
        [Description("Light Maneuver")]
        Light = 1,
        [Description("Dark Maneuver")]
        Dark = 2,
        [Description("Fire Maneuver")]
        Fire = 3,
        [Description("Ice Maneuver")]
        Ice = 4,
        [Description("Wind Maneuver")]
        Wind = 5,
        [Description("Earth Maneuver")]
        Earth = 6,
        [Description("Thunder Maneuver")]
        Thunder = 7,
        [Description("Water Maneuver")]
        Water = 8
    }
}
