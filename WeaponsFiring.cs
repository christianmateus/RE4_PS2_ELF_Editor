namespace ELFeditor
{
    public enum SLESWeaponsFiring
    {
        punisher = 0x34BA8C,
        handgun = 0x34BAA0,
        red9 = 0x34BAB4,
        blacktail = 0x34BAC8,
        broken = 0x34BADC,
        killer7 = 0x34BAF0,
        shotgun = 0x34BB04,
        striker = 0x34BB18,
        rifle = 0x34BB2C,
        rifleSemiauto = 0x34BB40,
        tmp = 0x34BB54,
        chicago = 0x34BB68,
        minethrower = 0x34BB90,
        handcannon = 0x34BBA4,
        // matilda = 0x34B6A4, NOT FOUND
        riotgun = 0x34BD0C,
        adaBowgun = 0x34BE38,
    }
    public enum SLUSWeaponsFiring
    {
        punisher = 0x34B7EC,
        handgun = 0x34B800,
        red9 = 0x34B814,
        blacktail = 0x34B828,
        broken = 0x34B83C,
        killer7 = 0x34B850,
        shotgun = 0x34B864,
        striker = 0x34B878,
        rifle = 0x34B88C,
        rifleSemiauto = 0x34B8A0,
        tmp = 0x34B8B4,
        chicago = 0x34B8C8,
        minethrower = 0x34B8F0,
        handcannon = 0x34B904,
        // matilda = 0x34B93C, NOT SURE 
        riotgun = 0x34BA6C,
        adaBowgun = 0x34BB98,
    }
    public class WeaponsFiring
    {
        // Main constants
        public uint SLES_START = 0x335C40;
        public uint SLUS_START = 0x3359C0;
    }
}
