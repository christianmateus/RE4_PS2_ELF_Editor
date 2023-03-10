namespace ELFeditor
{
    public enum SLESWeaponsReload
    {
        punisher = 0x34B5E4,
        handgun = 0x34B5F0,
        red9 = 0x34B5FC,
        blacktail = 0x34B608,
        broken = 0x34B614,
        killer7 = 0x34B620,
        shotgun = 0x34B62C,
        striker = 0x34B638,
        rifle = 0x34B644,
        rifleSemiauto = 0x34B650,
        tmp = 0x34B65C,
        chicago = 0x34B668,
        minethrower = 0x34B680,
        handcannon = 0x34B68C,
        matilda = 0x34B6A4,
        riotgun = 0x34B764,
        adaBowgun = 0x34B818,
    }
    public enum SLUSWeaponsReload
    {
        punisher = 0x34B344,
        handgun = 0x34B350,
        red9 = 0x34B35C,
        blacktail = 0x34B368,
        broken = 0x34B374,
        killer7 = 0x34B380,
        shotgun = 0x34B38C,
        striker = 0x34B398,
        rifle = 0x34B3A4,
        rifleSemiauto = 0x34B3B0,
        tmp = 0x34B3BC,
        chicago = 0x34B3C8,
        minethrower = 0x34B3E0,
        handcannon = 0x34B3EC,
        matilda = 0x34B404,
        riotgun = 0x34B4C4,
        adaBowgun = 0x34B578,
    }
    public class WeaponsReload
    {
        // Main constants
        public uint SLES_START = 0x335C40;
        public uint SLUS_START = 0x3359C0;
    }
}
