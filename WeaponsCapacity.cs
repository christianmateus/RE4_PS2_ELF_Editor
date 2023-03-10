﻿namespace ELFeditor
{
    public enum SLESWeaponsCapacity
    {
        handgun = 0x335C40,
        handgunSilencer = 0x335C56,
        red9 = 0x335C6C,
        red9Stock = 0x335C82,
        matilda = 0x335C98,
        punisher = 0x335CAE,
        punisherMedalion = 0x335CC4,
        blacktail = 0x335CDA,
        broken = 0x335CF0,
        shotgun = 0x335D06,
        striker = 0x335D1C,
        rifle = 0x335D32,
        rifleScope = 0x335D48,
        rifleInfrared = 0x335D5E,
        rifleSemiauto = 0x335D74,
        rifleSemiautoScope = 0x335D8A,
        rifleSemiautoInfrared = 0x335DA0,
        tmp = 0x335DB6,
        tmpStock = 0x335DCC,
        minethrower = 0x335DE2,
        minethrowerScope = 0x335DF8,
        killer7 = 0x335E0E,
        chicago = 0x335E24,
        bazooka = 0x335E3A,
        bazookaSpecial = 0x335E50,
        bazookaInfinite = 0x335E66,
        handcannon = 0x335E7C,
        knife = 0x335E92,
        grenadeExplosive = 0x335EA8,
        grenadeIncendiary = 0x335EBE,
        grenadeFlash = 0x335ED4,
        eggWhite = 0x335F00,
        eggBrown = 0x335F16,
        eggGolden = 0x335F2C,
        riotgun = 0x335F42,
        krauserBow = 0x335F58,
        hunkTmp = 0x335F6E,
        prl = 0x335F84,
        adaBowgun = 0x335FB0,
        adaShotgun = 0x335FC6,
        adaChicago = 0x335FDC,
    }
    public enum SLUSWeaponsCapacity
    {
        handgun = 0x3359C0,
        handgunSilencer = 0x3359D6,
        red9 = 0x3359EC,
        red9Stock = 0x335A03,
        matilda = 0x335A18,
        punisher = 0x335A2E,
        punisherMedalion = 0x335A44,
        blacktail = 0x335A5A,
        broken = 0x335A70,
        shotgun = 0x335A86,
        striker = 0x335A9C,
        rifle = 0x335AB2,
        rifleScope = 0x335AC8,
        rifleInfrared = 0x335ADE,
        rifleSemiauto = 0x335AF4,
        rifleSemiautoScope = 0x335B0A,
        rifleSemiautoInfrared = 0x335B20,
        tmp = 0x335B36,
        tmpStock = 0x335B4C,
        minethrower = 0x335B62,
        minethrowerScope = 0x335B78,
        killer7 = 0x335B8E,
        chicago = 0x335BA4,
        bazooka = 0x335BBA,
        bazookaSpecial = 0x335BD0,
        bazookaInfinite = 0x335BE6,
        handcannon = 0x335BFC,
        knife = 0x335C12,
        grenadeExplosive = 0x335C28,
        grenadeIncendiary = 0x335C3E,
        grenadeFlash = 0x335C54,
        eggWhite = 0x335C80,
        eggBrown = 0x335C96,
        eggGolden = 0x335CAC,
        riotgun = 0x335CC2,
        krauserBow = 0x335CD8,
        hunkTmp = 0x335CEE,
        prl = 0x335D04,
        adaBowgun = 0x335D30,
        adaShotgun = 0x335D46,
        adaChicago = 0x335D5C,
    }
    public class WeaponsCapacity
    {
        // Main constants
        public uint SLES_START = 0x335C40;
        public uint SLUS_START = 0x3359C0;
    }
}
