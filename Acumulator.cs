namespace ELFeditor
{
    public enum SLESAcumulator
    {
        Handgun = 0x1ED04,
        Magnum = 0x1ED20,
        Handcannon = 0x1ED34,
        Shotgun = 0x1ED50,
        Shotgun_EASY = 0x1ED54,
        Rifle = 0x1ED8C,
        Rifle_EASY = 0x1ED90,
        TMP_Chicago = 0x1EDAC,
        Minethrower_EASY = 0x1EDEC,
        Minethrower = 0x1EDF0,
        Treasures = 0x1EE4C,
        Items = 0x1EEE8
    }
    public enum SLUSAcumulator
    {
        Handgun = 0x1EB94,
        Magnum = 0x1EBB0,
        Handcannon = 0x1EBC4,
        Shotgun = 0x1EBE0,
        Shotgun_EASY = 0x1EBE4,
        Rifle = 0x1EC1C,
        Rifle_EASY = 0x1EC20,
        TMP_Chicago = 0x1EC3C,
        Minethrower_EASY = 0x1EC7C,
        Minethrower = 0x1EC80,
        Treasures = 0x1ECDC,
        Items = 0x1ED78
    }
    public enum SLPMAcumulator
    {
        Handgun = 0x1EC44,
        Handgun_AMATEUR = 0x1EC68,
        Magnum = 0x1EC84,
        Magnum_Handcannon = 0x1ECA8,
        Shotgun_EASY = 0x1ECD8,
        Shotgun = 0x1ECDC,
        Shotgun_AMATEUR = 0x1ED00,
        Rifle_EASY = 0x1ED30,
        Rifle = 0x1ED34,
        TMP_Chicago = 0x1ED6C,
        TMP_Chicago_AMATEUR = 0x1ED88,
        Handcannon = 0x1EDA8,
        Minethrower_EASY = 0x1EDF4,
        Minethrower = 0x1EDF8,
        Arrows = 0x1EE30,
        Treasures = 0x1EE88,
        Items = 0x1EF24
    }
    public class Acumulator
    {
        // Main constants
        public uint DISC_REGION = 0x8A810;
        public uint ELF_START = 0x8B000;
    }

    public enum ACUMULATOR_DEFAULT
    {
        Handgun_DEFAULT = 50,
        Magnum_DEFAULT = 10,
        Handcannon_DEFAULT = 10,
        Shotgun_DEFAULT = 15,
        Shotgun_EASY_DEFAULT = 25,
        Rifle_DEFAULT = 10,
        Rifle_EASY_DEFAULT = 20,
        TMP_Chicago_DEFAULT = 100,
        Minethrower_EASY_DEFAULT = 10,
        Minethrower_DEFAULT = 5,
        Treasures_DEFAULT = 999,
        Items_DEFAULT = 1
    }
}
