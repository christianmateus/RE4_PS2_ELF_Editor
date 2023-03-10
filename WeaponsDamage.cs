namespace ELFeditor
{
    public enum SLESWeaponsDamage
    {
        punisher = 0x2AD9EC,
        handgun = 0x2ADA08,
        red9 = 0x2ADA24,
        blacktail = 0x2ADA40,
        broken = 0x2ADA5C,
        killer7 = 0x2ADA78,
        shotgun = 0x2ADA94,
        striker = 0x2ADAB0,
        rifle = 0x2ADACC,
        rifleSemiauto = 0x2ADAE8,
        tmp = 0x2ADB04,
        chicago = 0x2ADB20,
        handcannon = 0x2ADB74,
        matilda = 0x2ADBAC,
        riotgun = 0x2ADD6C,
    }
    public enum SLUSWeaponsDamage
    {
        punisher = 0x2AD76C,
        handgun = 0x2AD788,
        red9 = 0x2AD7A4,
        blacktail = 0x2AD7C0,
        broken = 0x2AD7DC,
        killer7 = 0x2AD7F8,
        shotgun = 0x2AD814,
        striker = 0x2AD830,
        rifle = 0x2AD84C,
        rifleSemiauto = 0x2AD868,
        tmp = 0x2AD884,
        chicago = 0x2AD8A0,
        handcannon = 0x2AD8F4,
        matilda = 0x2AD92C,
        riotgun = 0x2ADAEC,
    }
    public class WeaponsDamage
    {
        // Main constants
        public uint SLES_START = 0x2AD750;
        public uint SLUS_START = 0x2AD9D0;
    }
}