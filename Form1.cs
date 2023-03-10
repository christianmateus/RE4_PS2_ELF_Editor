using System.Diagnostics;
using System.Text;

namespace ELFeditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Acumulator acumulator = new Acumulator();
        OpenFileDialog dialog = new OpenFileDialog();
        byte[] region = new byte[4];

        public string GetDiscRegion()
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            // Getting disc region
            br.BaseStream.Position = acumulator.DISC_REGION;
            region = br.ReadBytes(4);
            lblRegion.Text = Encoding.ASCII.GetString(region);
            br.Close();

            return Encoding.ASCII.GetString(region);
        }
        public void HideFields(string regionName)
        {
            // Used to show or hide some filds based on region
            bool isJapaneseVersion = false;
            if (regionName == "slpm")
            {
                isJapaneseVersion = true;
            }

            // Setting elements to visible 
            handgunAmateurAmmo.Visible = isJapaneseVersion;
            magnumAmateurAmmo.Visible = isJapaneseVersion;
            shotgunAmateurAmmo.Visible = isJapaneseVersion;
            tmpAmateurAmmo.Visible = isJapaneseVersion;
            arrowsAmmo.Visible = isJapaneseVersion;
            SLPMlabel1.Visible = isJapaneseVersion;
            SLPMlabel2.Visible = isJapaneseVersion;
            SLPMlabel3.Visible = isJapaneseVersion;
            SLPMlabel4.Visible = isJapaneseVersion;
            SLPMlabel5.Visible = isJapaneseVersion;
        }
        public void ReadSLUSAcumulator()
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            // Getting values from ISO/ELF
            br.BaseStream.Position = (uint)SLUSAcumulator.Handgun + acumulator.ELF_START;
            handgunAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.Magnum + acumulator.ELF_START;
            magnumAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.Handcannon + acumulator.ELF_START;
            handcannonAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.Shotgun + acumulator.ELF_START;
            shotgunAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.Shotgun_EASY + acumulator.ELF_START;
            shotgunEasyAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.Rifle + acumulator.ELF_START;
            rifleAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.Rifle_EASY + acumulator.ELF_START;
            rifleEasyAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.TMP_Chicago + acumulator.ELF_START;
            tmpAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.Minethrower_EASY + acumulator.ELF_START;
            minethrowerEasyAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.Minethrower + acumulator.ELF_START;
            minethrowerAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.Treasures + acumulator.ELF_START;
            treasuresAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLUSAcumulator.Items + acumulator.ELF_START;
            itemsAmmo.Value = br.ReadUInt16();

            br.Close();
            br.Dispose();
        }
        public void ReadSLESAcumulator()
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            // Getting disc region
            br.BaseStream.Position = acumulator.DISC_REGION;
            region = br.ReadBytes(4);
            lblRegion.Text = Encoding.ASCII.GetString(region);

            // Getting values from ISO/ELF
            br.BaseStream.Position = (uint)SLESAcumulator.Handgun + acumulator.ELF_START;
            handgunAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.Magnum + acumulator.ELF_START;
            magnumAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.Handcannon + acumulator.ELF_START;
            handcannonAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.Shotgun + acumulator.ELF_START;
            shotgunAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.Shotgun_EASY + acumulator.ELF_START;
            shotgunEasyAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.Rifle + acumulator.ELF_START;
            rifleAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.Rifle_EASY + acumulator.ELF_START;
            rifleEasyAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.TMP_Chicago + acumulator.ELF_START;
            tmpAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.Minethrower_EASY + acumulator.ELF_START;
            minethrowerEasyAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.Minethrower + acumulator.ELF_START;
            minethrowerAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.Treasures + acumulator.ELF_START;
            treasuresAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLESAcumulator.Items + acumulator.ELF_START;
            itemsAmmo.Value = br.ReadUInt16();

            br.Close();
            br.Dispose();
        }
        public void ReadSLPMAcumulator()
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            // Getting values from ISO/ELF
            br.BaseStream.Position = (uint)SLPMAcumulator.Handgun + acumulator.ELF_START;
            handgunAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Handgun_AMATEUR + acumulator.ELF_START;
            handgunAmateurAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Magnum + acumulator.ELF_START;
            magnumAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Magnum_Handcannon + acumulator.ELF_START;
            magnumAmateurAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Shotgun_EASY + acumulator.ELF_START;
            shotgunEasyAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Shotgun + acumulator.ELF_START;
            shotgunAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Shotgun_AMATEUR + acumulator.ELF_START;
            shotgunAmateurAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Rifle_EASY + acumulator.ELF_START;
            rifleEasyAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Rifle + acumulator.ELF_START;
            rifleAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.TMP_Chicago + acumulator.ELF_START;
            tmpAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.TMP_Chicago_AMATEUR + acumulator.ELF_START;
            tmpAmateurAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Handcannon + acumulator.ELF_START;
            handcannonAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Minethrower_EASY + acumulator.ELF_START;
            minethrowerEasyAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Minethrower + acumulator.ELF_START;
            minethrowerAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Arrows + acumulator.ELF_START;
            arrowsAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Treasures + acumulator.ELF_START;
            treasuresAmmo.Value = br.ReadUInt16();

            br.BaseStream.Position = (uint)SLPMAcumulator.Items + acumulator.ELF_START;
            itemsAmmo.Value = br.ReadUInt16();

            br.Close();
            br.Dispose();
        }
        public void SaveSLUSAcumulator()
        {
            if (dialog.FileName != "")
            {
                BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

                // Getting values from ISO/ELF
                bw.BaseStream.Position = (uint)SLUSAcumulator.Handgun + acumulator.ELF_START;
                bw.Write((ushort)handgunAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.Magnum + acumulator.ELF_START;
                bw.Write((ushort)magnumAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.Handcannon + acumulator.ELF_START;
                bw.Write((ushort)handcannonAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.Shotgun + acumulator.ELF_START;
                bw.Write((ushort)shotgunAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.Shotgun_EASY + acumulator.ELF_START;
                bw.Write((ushort)shotgunEasyAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.Rifle + acumulator.ELF_START;
                bw.Write((ushort)rifleAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.Rifle_EASY + acumulator.ELF_START;
                bw.Write((ushort)rifleEasyAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.TMP_Chicago + acumulator.ELF_START;
                bw.Write((ushort)tmpAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.Minethrower_EASY + acumulator.ELF_START;
                bw.Write((ushort)minethrowerEasyAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.Minethrower + acumulator.ELF_START;
                bw.Write((ushort)minethrowerAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.Treasures + acumulator.ELF_START;
                bw.Write((ushort)treasuresAmmo.Value);

                bw.BaseStream.Position = (uint)SLUSAcumulator.Items + acumulator.ELF_START;
                bw.Write((ushort)itemsAmmo.Value);

                MessageBoxes("save");
                bw.Close();
            }
            else
            {
                return;
            }
        }
        public void SaveSLESAcumulator()
        {
            if (dialog.FileName != "")
            {
                BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

                // Getting values from ISO/ELF
                bw.BaseStream.Position = (uint)SLESAcumulator.Handgun + acumulator.ELF_START;
                bw.Write((ushort)handgunAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.Magnum + acumulator.ELF_START;
                bw.Write((ushort)magnumAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.Handcannon + acumulator.ELF_START;
                bw.Write((ushort)handcannonAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.Shotgun + acumulator.ELF_START;
                bw.Write((ushort)shotgunAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.Shotgun_EASY + acumulator.ELF_START;
                bw.Write((ushort)shotgunEasyAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.Rifle + acumulator.ELF_START;
                bw.Write((ushort)rifleAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.Rifle_EASY + acumulator.ELF_START;
                bw.Write((ushort)rifleEasyAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.TMP_Chicago + acumulator.ELF_START;
                bw.Write((ushort)tmpAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.Minethrower_EASY + acumulator.ELF_START;
                bw.Write((ushort)minethrowerEasyAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.Minethrower + acumulator.ELF_START;
                bw.Write((ushort)minethrowerAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.Treasures + acumulator.ELF_START;
                bw.Write((ushort)treasuresAmmo.Value);

                bw.BaseStream.Position = (uint)SLESAcumulator.Items + acumulator.ELF_START;
                bw.Write((ushort)itemsAmmo.Value);

                MessageBoxes("save");
                bw.Close();
            }
            else
            {
                return;
            }
        }
        public void SaveSLPMAcumulator()
        {
            if (dialog.FileName != "")
            {
                BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

                // Getting values from ISO/ELF
                bw.BaseStream.Position = (uint)SLPMAcumulator.Handgun + acumulator.ELF_START;
                bw.Write((ushort)handgunAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Handgun_AMATEUR + acumulator.ELF_START;
                bw.Write((ushort)handgunAmateurAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Magnum + acumulator.ELF_START;
                bw.Write((ushort)magnumAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Magnum_Handcannon + acumulator.ELF_START;
                bw.Write((ushort)magnumAmateurAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Shotgun_EASY + acumulator.ELF_START;
                bw.Write((ushort)shotgunEasyAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Shotgun + acumulator.ELF_START;
                bw.Write((ushort)shotgunAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Shotgun_AMATEUR + acumulator.ELF_START;
                bw.Write((ushort)shotgunAmateurAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Rifle_EASY + acumulator.ELF_START;
                bw.Write((ushort)rifleEasyAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Rifle + acumulator.ELF_START;
                bw.Write((ushort)rifleAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.TMP_Chicago + acumulator.ELF_START;
                bw.Write((ushort)tmpAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.TMP_Chicago_AMATEUR + acumulator.ELF_START;
                bw.Write((ushort)tmpAmateurAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Handcannon + acumulator.ELF_START;
                bw.Write((ushort)handcannonAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Minethrower_EASY + acumulator.ELF_START;
                bw.Write((ushort)minethrowerEasyAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Minethrower + acumulator.ELF_START;
                bw.Write((ushort)minethrowerAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Arrows + acumulator.ELF_START;
                bw.Write((ushort)arrowsAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Treasures + acumulator.ELF_START;
                bw.Write((ushort)treasuresAmmo.Value);

                bw.BaseStream.Position = (uint)SLPMAcumulator.Items + acumulator.ELF_START;
                bw.Write((ushort)itemsAmmo.Value);

                bw.Close();
                bw.Dispose();
            }
            else
            {
                return;
            }
        }
        public void GetWeaponsCapacity(string regionName)
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab2CbWeapons.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSWeaponsCapacity)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        tab2WeaponID.Value = br.ReadUInt16();
                        br.ReadByte(); // skips 1 byte
                        tab2Model.Value = br.ReadByte();
                        br.ReadByte(); // skips 1 byte
                        tab2Attachment.Value = br.ReadByte();
                        tab2AmmoUsed.Value = br.ReadUInt16();
                        tab2Capacity1.Value = br.ReadUInt16();
                        tab2Capacity2.Value = br.ReadUInt16();
                        tab2Capacity3.Value = br.ReadUInt16();
                        tab2Capacity4.Value = br.ReadUInt16();
                        tab2Capacity5.Value = br.ReadUInt16();
                        tab2Capacity6.Value = br.ReadUInt16();
                        tab2Exclusive.Value = br.ReadUInt16();
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESWeaponsCapacity)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        tab2WeaponID.Value = br.ReadUInt16();
                        br.ReadByte(); // skips 1 byte
                        tab2Model.Value = br.ReadByte();
                        br.ReadByte(); // skips 1 byte
                        tab2Attachment.Value = br.ReadByte();
                        tab2AmmoUsed.Value = br.ReadUInt16();
                        tab2Capacity1.Value = br.ReadUInt16();
                        tab2Capacity2.Value = br.ReadUInt16();
                        tab2Capacity3.Value = br.ReadUInt16();
                        tab2Capacity4.Value = br.ReadUInt16();
                        tab2Capacity5.Value = br.ReadUInt16();
                        tab2Capacity6.Value = br.ReadUInt16();
                        tab2Exclusive.Value = br.ReadUInt16();
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            br.Close();
        }
        public void SetWeaponsCapacity(string regionName)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab2CbWeapons.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSWeaponsCapacity)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((ushort)tab2WeaponID.Value);
                        bw.BaseStream.Position = bw.BaseStream.Position + 1;
                        bw.Write((byte)tab2Model.Value);
                        bw.BaseStream.Position = bw.BaseStream.Position + 1;
                        bw.Write((byte)tab2Attachment.Value);
                        bw.Write((ushort)tab2AmmoUsed.Value);
                        bw.Write((ushort)tab2Capacity1.Value);
                        bw.Write((ushort)tab2Capacity2.Value);
                        bw.Write((ushort)tab2Capacity3.Value);
                        bw.Write((ushort)tab2Capacity4.Value);
                        bw.Write((ushort)tab2Capacity5.Value);
                        bw.Write((ushort)tab2Capacity6.Value);
                        bw.Write((ushort)tab2Exclusive.Value);
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESWeaponsCapacity)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((ushort)tab2WeaponID.Value);
                        bw.BaseStream.Position = bw.BaseStream.Position + 1;
                        bw.Write((byte)tab2Model.Value);
                        bw.BaseStream.Position = bw.BaseStream.Position + 1;
                        bw.Write((byte)tab2Attachment.Value);
                        bw.Write((ushort)tab2AmmoUsed.Value);
                        bw.Write((ushort)tab2Capacity1.Value);
                        bw.Write((ushort)tab2Capacity2.Value);
                        bw.Write((ushort)tab2Capacity3.Value);
                        bw.Write((ushort)tab2Capacity4.Value);
                        bw.Write((ushort)tab2Capacity5.Value);
                        bw.Write((ushort)tab2Capacity6.Value);
                        bw.Write((ushort)tab2Exclusive.Value);
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            bw.Close();
        }
        public void GetWeaponsDamage(string regionName)
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab3CbDamage.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSWeaponsDamage)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        Console.WriteLine(i.ToString("X"));
                        tab3Damage1.Value = (decimal)br.ReadSingle();
                        tab3Damage2.Value = (decimal)br.ReadSingle();
                        tab3Damage3.Value = (decimal)br.ReadSingle();
                        tab3Damage4.Value = (decimal)br.ReadSingle();
                        tab3Damage5.Value = (decimal)br.ReadSingle();
                        tab3Damage6.Value = (decimal)br.ReadSingle();
                        tab3Damage7.Value = (decimal)br.ReadSingle();
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESWeaponsDamage)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        Console.WriteLine("Encontrou o index");
                        br.BaseStream.Position = i;
                        tab3Damage1.Value = (decimal)br.ReadSingle();
                        tab3Damage2.Value = (decimal)br.ReadSingle();
                        tab3Damage3.Value = (decimal)br.ReadSingle();
                        tab3Damage4.Value = (decimal)br.ReadSingle();
                        tab3Damage5.Value = (decimal)br.ReadSingle();
                        tab3Damage6.Value = (decimal)br.ReadSingle();
                        tab3Damage7.Value = (decimal)br.ReadSingle();
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            br.Close();
        }
        public void SetWeaponsDamage(string regionName)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab3CbDamage.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSWeaponsDamage)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((float)tab3Damage1.Value);
                        bw.Write((float)tab3Damage2.Value);
                        bw.Write((float)tab3Damage3.Value);
                        bw.Write((float)tab3Damage4.Value);
                        bw.Write((float)tab3Damage5.Value);
                        bw.Write((float)tab3Damage6.Value);
                        bw.Write((float)tab3Damage7.Value);
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESWeaponsDamage)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((float)tab3Damage1.Value);
                        bw.Write((float)tab3Damage2.Value);
                        bw.Write((float)tab3Damage3.Value);
                        bw.Write((float)tab3Damage4.Value);
                        bw.Write((float)tab3Damage5.Value);
                        bw.Write((float)tab3Damage6.Value);
                        bw.Write((float)tab3Damage7.Value);
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            bw.Close();
        }
        public void GetWeaponsReload(string regionName)
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab4CbReloadSpeed.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSWeaponsReload)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        tab4Reload1.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab4Reload2.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab4Reload3.Value = (decimal)br.ReadSingle() / 3 / 10;
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESWeaponsReload)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        tab4Reload1.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab4Reload2.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab4Reload3.Value = (decimal)br.ReadSingle() / 3 / 10;
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            br.Close();
        }
        public void SetWeaponsReload(string regionName)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab4CbReloadSpeed.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSWeaponsReload)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((float)tab4Reload1.Value * 3 * 10);
                        bw.Write((float)tab4Reload2.Value * 3 * 10);
                        bw.Write((float)tab4Reload3.Value * 3 * 10);
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESWeaponsReload)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((float)tab4Reload1.Value * 3 * 10);
                        bw.Write((float)tab4Reload2.Value * 3 * 10);
                        bw.Write((float)tab4Reload3.Value * 3 * 10);
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            bw.Close();
        }
        public void GetWeaponsFiring(string regionName)
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab5CbFiringSpeed.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSWeaponsFiring)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        tab5Firing1.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab5Firing2.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab5Firing3.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab5Firing4.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab5Firing5.Value = (decimal)br.ReadSingle() / 3 / 10;
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESWeaponsFiring)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        tab5Firing1.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab5Firing2.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab5Firing3.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab5Firing4.Value = (decimal)br.ReadSingle() / 3 / 10;
                        tab5Firing5.Value = (decimal)br.ReadSingle() / 3 / 10;
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            br.Close();
        }
        public void SetWeaponsFiring(string regionName)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab5CbFiringSpeed.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSWeaponsFiring)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write(tab5Firing1.Value / 3 / 10);
                        bw.Write(tab5Firing2.Value / 3 / 10);
                        bw.Write(tab5Firing3.Value / 3 / 10);
                        bw.Write(tab5Firing4.Value / 3 / 10);
                        bw.Write(tab5Firing5.Value / 3 / 10);
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESWeaponsFiring)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write(tab5Firing1.Value / 3 / 10);
                        bw.Write(tab5Firing2.Value / 3 / 10);
                        bw.Write(tab5Firing3.Value / 3 / 10);
                        bw.Write(tab5Firing4.Value / 3 / 10);
                        bw.Write(tab5Firing5.Value / 3 / 10);
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            bw.Close();
        }
        public void GetUpgradesAvailable(string regionName)
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab6CbUpgrades.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSUpgradesAvailable)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        tab6WeaponID.Value = (ushort)br.ReadUInt16();
                        tab6Firepower.Value = (byte)br.ReadByte();
                        tab6FiringSpeed.Value = (byte)br.ReadByte();
                        tab6ReloadSpeed.Value = (byte)br.ReadByte();
                        tab6Capacity.Value = (byte)br.ReadByte();
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESUpgradesAvailable)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        tab6WeaponID.Value = (ushort)br.ReadUInt16();
                        tab6Firepower.Value = (byte)br.ReadByte();
                        tab6FiringSpeed.Value = (byte)br.ReadByte();
                        tab6ReloadSpeed.Value = (byte)br.ReadByte();
                        tab6Capacity.Value = (byte)br.ReadByte();
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            br.Close();
        }
        public void SetUpgradesAvailable(string regionName)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab6CbUpgrades.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSUpgradesAvailable)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((ushort)tab6WeaponID.Value);
                        bw.Write((byte)tab6Firepower.Value);
                        bw.Write((byte)tab6FiringSpeed.Value);
                        bw.Write((byte)tab6ReloadSpeed.Value);
                        bw.Write((byte)tab6Capacity.Value);
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESUpgradesAvailable)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((ushort)tab6WeaponID.Value);
                        bw.Write((byte)tab6Firepower.Value);
                        bw.Write((byte)tab6FiringSpeed.Value);
                        bw.Write((byte)tab6ReloadSpeed.Value);
                        bw.Write((byte)tab6Capacity.Value);
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            bw.Close();
        }
        public void GetMerchantPrices(string regionName)
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab7CbMerchantPrices.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSMerchantBuyPrices)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        tab7WeaponID.Value = br.ReadInt16();
                        tab7PriceBox.Value = br.ReadInt16() * 10;
                        tab7Quantity.Value = br.ReadInt16();
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESMerchantBuyPrices)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        br.BaseStream.Position = i;
                        tab7WeaponID.Value = br.ReadInt16();
                        tab7PriceBox.Value = br.ReadInt16() * 10;
                        tab7Quantity.Value = br.ReadInt16();
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            br.Close();
        }
        public void SetMerchantPrices(string regionName)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab7CbMerchantPrices.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSMerchantBuyPrices)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((short)tab7WeaponID.Value);
                        bw.Write((short)tab7PriceBox.Value / 10);
                        bw.Write((short)tab7Quantity.Value);
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESMerchantBuyPrices)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((short)tab7WeaponID.Value);
                        bw.Write((short)tab7PriceBox.Value / 10);
                        bw.Write((short)tab7Quantity.Value);
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            bw.Close();
        }
        public void GetItemsSlots(string regionName)
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab9CbItemsSlots.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSItemsSlots)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        Console.WriteLine(i.ToString("X"));
                        br.BaseStream.Position = i;
                        tab9ItemID.Value = br.ReadInt16();
                        br.ReadUInt16(); // Skips 2 bytes
                        tab9Horizontal.Value = br.ReadByte();
                        tab9Vertical.Value = br.ReadByte();
                        br.ReadUInt16(); // Skips 2 bytes
                        tab9XCoordinate.Value = (decimal)br.ReadSingle();
                        tab9YCoordinate.Value = (decimal)br.ReadSingle();
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESItemsSlots)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        Console.WriteLine(i.ToString("X"));
                        br.BaseStream.Position = i;
                        tab9ItemID.Value = br.ReadInt16();
                        br.ReadUInt16(); // Skips 2 bytes
                        tab9Horizontal.Value = br.ReadByte();
                        tab9Vertical.Value = br.ReadByte();
                        br.ReadUInt16(); // Skips 2 bytes
                        tab9XCoordinate.Value = (decimal)br.ReadSingle();
                        tab9YCoordinate.Value = (decimal)br.ReadSingle();
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            br.Close();
        }
        public void SetItemsSlots(string regionName)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

            int weaponIndex = tab9CbItemsSlots.SelectedIndex; // Option selected on Combobox
            int tempIndex = 0; // Temporary index used on each iteration
            if (regionName == "slus")
            {
                foreach (int i in Enum.GetValues(typeof(SLUSItemsSlots)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((ushort)tab9ItemID.Value);
                        bw.BaseStream.Position += 2;
                        bw.Write((byte)tab9Horizontal.Value);
                        bw.Write((byte)tab9Vertical.Value);
                        bw.BaseStream.Position += 2;
                        bw.Write((float)tab9XCoordinate.Value);
                        bw.Write((float)tab9YCoordinate.Value);

                        // Zeroes all block bytes before adding the 0x31
                        for (int j = 0; j < 0x48; j++)
                        {
                            bw.Write((byte)0x00);
                        }

                        bw.BaseStream.Position = i + 0x10;
                        // Writes 0x31 data according to desired slots quantity
                        for (int x = 0; x < tab9Horizontal.Value * tab9Vertical.Value; x++)
                        {
                            bw.Write((byte)0x31);
                            if (x >= 0x48)
                            {
                                MessageBox.Show("Slot size reached max allowed, please use a smaller value.", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                bw.Close();
                                return;
                            }
                        }
                    }
                    tempIndex++;
                }
            }
            else if (regionName == "sles")
            {
                foreach (int i in Enum.GetValues(typeof(SLESItemsSlots)))
                {
                    if (tempIndex == weaponIndex)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write((ushort)tab9ItemID.Value);
                        bw.BaseStream.Position += 2;
                        bw.Write((byte)tab9Horizontal.Value);
                        bw.Write((byte)tab9Vertical.Value);
                        bw.BaseStream.Position += 2;
                        bw.Write((float)tab9XCoordinate.Value);
                        bw.Write((float)tab9YCoordinate.Value);

                        // Zeroes all block bytes before adding the 0x31
                        for (int j = 0; j < 0x48; j++)
                        {
                            bw.Write((byte)0x00);
                        }

                        bw.BaseStream.Position = i + 0x10;
                        // Writes 0x31 data according to desired slots quantity
                        for (int x = 0; x < tab9Horizontal.Value * tab9Vertical.Value; x++)
                        {
                            bw.Write((byte)0x31);
                            if (x >= 0x48)
                            {
                                MessageBox.Show("Slot size reached max allowed, please use a smaller value.", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                    }
                    tempIndex++;
                }
            }
            else
            {
                MessageBoxes("regionError");
            }
            bw.Close();
        }
        public void MessageBoxes(string status)
        {
            switch (status)
            {
                case "save":
                    MessageBox.Show("File saved successfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "regionError":
                    MessageBox.Show("Disc region not found/supported, this tool supports SLES and SLUS versions.",
                   "REGION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "elfExtracted":
                    MessageBox.Show("ELF file extracted successfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "isSLPM":
                    MessageBox.Show("Japanese version detected, ONLY ACUMULATOR is available for this version.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }

        }

        // MENU METHODS
        private void openISOFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open dialog box for file selecting
            dialog.Filter = "PS2 ISO Files(*.iso)|*.iso";
            dialog.ShowDialog();

            if (GetDiscRegion() == "SLUS")
            {
                HideFields("slus");
                ReadSLUSAcumulator();
            }
            else if (GetDiscRegion() == "SLES")
            {
                HideFields("sles");
                ReadSLESAcumulator();
            }
            else if (GetDiscRegion() == "SLPM")
            {
                HideFields("slpm");
                ReadSLPMAcumulator();
                MessageBoxes("isSLPM");
            }
            else
            {
                MessageBoxes("regionError");
            }

        }
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string region = GetDiscRegion();

            if (region == "SLUS")
            {
                SaveSLUSAcumulator();
                SetWeaponsCapacity("slus");
                SetWeaponsDamage("slus");
                SetWeaponsReload("slus");
                SetWeaponsFiring("slus");
                SetUpgradesAvailable("slus");
                SetMerchantPrices("slus");
                SetItemsSlots("slus");
            }
            else if (region == "SLES")
            {
                SaveSLESAcumulator();
                SetWeaponsCapacity("sles");
                SetWeaponsDamage("sles");
                SetWeaponsReload("sles");
                SetWeaponsFiring("sles");
                SetUpgradesAvailable("sles");
                SetMerchantPrices("sles");
                SetItemsSlots("sles");
            }
            else if (region == "SLPM")
            {
                SaveSLPMAcumulator();
            }
            else { return; }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void extractELFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string region = GetDiscRegion();

            if (dialog.FileName != "")
            {
                BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));
                br.BaseStream.Position = acumulator.ELF_START;

                if (region == "SLUS")
                {
                    BinaryWriter bw = new BinaryWriter(File.Open("SLUS_211.34", FileMode.Create));
                    bw.Write(br.ReadBytes(0x2F413C));
                    bw.Close();
                    MessageBoxes("elfExtracted");
                }
                else if (region == "SLES")
                {

                    BinaryWriter bw = new BinaryWriter(File.Open("SLES_537.02", FileMode.Create));
                    bw.Write(br.ReadBytes(0x2F43BC));
                    bw.Close();
                    MessageBoxes("elfExtracted");
                }
                else if (region == "SLPM")
                {
                    BinaryWriter bw = new BinaryWriter(File.Open("SLPM_662.13", FileMode.Create));
                    bw.Write(br.ReadBytes(0x2F4DBC));
                    bw.Close();
                    MessageBoxes("elfExtracted");
                }
                else
                {
                    MessageBoxes("regionError");
                }
                br.Close();

            }
            else
            {
                return;
            }
        }
        private void defaultValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handgunAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Handgun_DEFAULT;
            magnumAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Magnum_DEFAULT;
            handcannonAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Handcannon_DEFAULT;
            shotgunAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Shotgun_DEFAULT;
            shotgunEasyAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Shotgun_EASY_DEFAULT;
            rifleAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Rifle_DEFAULT;
            rifleEasyAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Rifle_EASY_DEFAULT;
            tmpAmmo.Value = (decimal)ACUMULATOR_DEFAULT.TMP_Chicago_DEFAULT;
            minethrowerEasyAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Minethrower_EASY_DEFAULT;
            minethrowerAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Minethrower_DEFAULT;
            treasuresAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Treasures_DEFAULT;
            itemsAmmo.Value = (decimal)ACUMULATOR_DEFAULT.Items_DEFAULT;
        }
        private void nullAllValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemsAmmo.Value = 0; handgunAmmo.Value = 0; magnumAmmo.Value = 0;
            handcannonAmmo.Value = 0; shotgunAmmo.Value = 0; shotgunEasyAmmo.Value = 0;
            rifleAmmo.Value = 0; rifleEasyAmmo.Value = 0; tmpAmmo.Value = 0;
            minethrowerEasyAmmo.Value = 0; minethrowerAmmo.Value = 0; treasuresAmmo.Value = 0;
        }
        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var creditsForm = new Form2();
            creditsForm.Show();
        }
        private void rEModdingForumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://residentevilmodding.boards.net/board/51/re4-modding-tutorials") { UseShellExecute = true });
        }

        // TAB METHODS
        private void tab2CbCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetDiscRegion() == "SLUS")
            {
                GetWeaponsCapacity("slus");
            }
            else if (GetDiscRegion() == "SLES")
            {
                GetWeaponsCapacity("sles");
            }
        }
        private void tab3CbDamage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetDiscRegion() == "SLUS")
            {
                GetWeaponsDamage("slus");
            }
            else if (GetDiscRegion() == "SLES")
            {
                GetWeaponsDamage("sles");
            }
        }
        private void tab4CbReloadSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetDiscRegion() == "SLUS")
            {
                GetWeaponsReload("slus");
            }
            else if (GetDiscRegion() == "SLES")
            {
                GetWeaponsReload("sles");
            }
        }
        private void tab5CbFiringSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetDiscRegion() == "SLUS")
            {
                GetWeaponsFiring("slus");
            }
            else if (GetDiscRegion() == "SLES")
            {
                GetWeaponsFiring("sles");
            }
        }
        private void tab6CbUpgrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetDiscRegion() == "SLUS")
            {
                GetUpgradesAvailable("slus");
            }
            else if (GetDiscRegion() == "SLES")
            {
                GetUpgradesAvailable("sles");
            }
        }
        private void tab7CbMerchantPrices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetDiscRegion() == "SLUS")
            {
                GetMerchantPrices("slus");
            }
            else if (GetDiscRegion() == "SLES")
            {
                GetMerchantPrices("sles");
            }
        }
        private void tab9CbItemsSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetDiscRegion() == "SLUS")
            {
                GetItemsSlots("slus");
            }
            else if (GetDiscRegion() == "SLES")
            {
                GetItemsSlots("sles");
            }
        }
        private void tab9Vertical_ValueChanged(object sender, EventArgs e)
        {
            tab9VerticalLabel.Text = tab9Vertical.Value.ToString();
            if (tab9Vertical.Value * tab9Horizontal.Value >= 0x48)
            {
                MessageBox.Show("Slot size reached max allowed, please use a smaller value.", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tab9Vertical.Value--;
            }
            int tempValue = (int)(tab9Vertical.Value * tab9Horizontal.Value);
            tab9Result.Text = tempValue.ToString();
        }
        private void tab9Horizontal_ValueChanged(object sender, EventArgs e)
        {
            tab9HorizontalLabel.Text = tab9Horizontal.Value.ToString();
            if (tab9Vertical.Value * tab9Horizontal.Value >= 0x48)
            {
                MessageBox.Show("Slot size reached max allowed, please use a smaller value.", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tab9Horizontal.Value--;
            }
            int tempValue = (int)(tab9Vertical.Value * tab9Horizontal.Value);
            tab9Result.Text = tempValue.ToString();
        }
    }
}