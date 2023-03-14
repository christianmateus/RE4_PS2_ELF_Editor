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
        public void GetMerchantStock(string regionName)
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));
            MerchantStock merchantStock = new MerchantStock();
            merchantStock.PopulateArrays();

            int merchantIndex = tab8CbMerchant.SelectedIndex; // Option selected on Combobox
            int lineSpacing = 0;
            int tempCounter = 0;
            int slesOffsetDifference = 0;

            // Sets offset difference if SLES region is detected
            if (regionName == "sles")
            { slesOffsetDifference = 0x280; }
            int removeIndex = 1; // Used to remove elements

            // Remove elements (controls)
            foreach (Control item in tabPage7.Controls.OfType<ComboBox>().ToList())
            {
                if (item.Name == $"tab8Item{removeIndex}")
                {
                    tabPage7.Controls.Remove(item);
                    removeIndex++;
                }
            }
            removeIndex = 1;
            foreach (Control item in tabPage7.Controls.OfType<Label>().ToList())
            {
                if (item.Name == $"tab8Lbl{removeIndex}")
                {
                    tabPage7.Controls.Remove(item);
                    removeIndex++;
                }
            }
            removeIndex = 1;
            foreach (Control item in tabPage7.Controls.OfType<NumericUpDown>().ToList())
            {
                if (item.Name == $"tab8SpinBox{removeIndex}")
                {
                    tabPage7.Controls.Remove(item);
                    removeIndex++;
                }
            }
            removeIndex = 1;
            foreach (Control item in tabPage7.Controls.OfType<Label>().ToList())
            {
                if (item.Name == $"tab8LblQuantity{removeIndex}")
                {
                    tabPage7.Controls.Remove(item);
                    removeIndex++;
                }
            }
            removeIndex = 1;

            // Create elements
            for (int z = 0; z < merchantStock.MerchantOffsets[merchantIndex].Length; z++)
            {
                int lblSpacing = 0;
                int cbSpacing = 0;

                // Creates spacing between control elements
                if (z % 2 != 0)
                {
                    lblSpacing = 365;
                    cbSpacing = 375;
                }
                if (tempCounter == 2) { lineSpacing += 50; tempCounter = 0; }

                // Read every offset from the array, based on selected merchant
                br.BaseStream.Position = merchantStock.MerchantOffsets[merchantIndex][z] + slesOffsetDifference;

                // Combobox for Item Name
                ComboBox cb = new ComboBox();
                cb.Name = $"tab8Item{z + 1}";
                cb.Location = new Point(85 + cbSpacing, 120 + lineSpacing);
                cb.Size = new Size(223, 23);
                cb.DropDownStyle = ComboBoxStyle.DropDownList;

                // Add string values from list to each combobox (SLOW!!)
                foreach (var item in merchantStock.ItemList)
                {
                    cb.Items.Add(item.ToUpper());
                }
                cb.SelectedIndex = br.ReadInt16();
                tabPage7.Controls.Add(cb);

                // Label Item ID
                Label lblTitle = new Label();
                lblTitle.Name = $"tab8Lbl{z + 1}";
                lblTitle.Text = $"Item ID {z + 1}";
                lblTitle.ForeColor = Color.FromArgb(230, 230, 230);
                lblTitle.Location = new Point(175 + lblSpacing, 102 + lineSpacing);
                lblTitle.AutoSize = true;
                tabPage7.Controls.Add(lblTitle);

                // Spin Box for Quantity
                NumericUpDown spinBox = new NumericUpDown();
                spinBox.Name = $"tab8SpinBox{z + 1}";
                spinBox.Location = new Point(338 + lblSpacing, 120 + lineSpacing);
                spinBox.Size = new Size(88, 23);
                spinBox.TextAlign = HorizontalAlignment.Center;
                spinBox.Maximum = 65000;
                spinBox.Increment = 1;
                spinBox.Value = br.ReadInt16();
                tabPage7.Controls.Add(spinBox);

                // Label Quantity
                Label lblQuantity = new Label();
                lblQuantity.Name = $"tab8LblQuantity{z + 1}";
                lblQuantity.Text = "Quantity";
                lblQuantity.ForeColor = Color.FromArgb(230, 230, 230);
                lblQuantity.Location = new Point(353 + lblSpacing, 102 + lineSpacing);
                lblQuantity.AutoSize = true;
                tabPage7.Controls.Add(lblQuantity);

                tempCounter++;
            }
            br.Close();
        }
        public void SetMerchantStock(string regionName)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));
            MerchantStock merchantStock = new MerchantStock();
            merchantStock.PopulateArrays();

            int slesOffsetDifference = 0;
            // Sets offset difference if SLES region is detected
            if (regionName == "sles")
            { slesOffsetDifference = 0x280; }
            int cbNumber = 0;
            int merchantIndex = tab8CbMerchant.SelectedIndex; // Option selected on Combobox

            // Iterates through each combobox
            foreach (var item in tabPage7.Controls.OfType<ComboBox>().ToList())
            {
                if (item.Name == $"tab8Item{cbNumber + 1}")
                {
                    bw.BaseStream.Position = merchantStock.MerchantOffsets[merchantIndex][cbNumber] + slesOffsetDifference;
                    bw.Write((short)item.SelectedIndex);
                    cbNumber++;
                }
            }
            cbNumber = 0;

            // Iterates through each spinbox
            foreach (var item in tabPage7.Controls.OfType<NumericUpDown>().ToList())
            {
                if (item.Name == $"tab8SpinBox{cbNumber + 1}")
                {
                    bw.BaseStream.Position = merchantStock.MerchantOffsets[merchantIndex][cbNumber] + slesOffsetDifference + 2;
                    bw.Write((short)item.Value);
                    cbNumber++;
                }
            }
            bw.Close();
        }
        public void GetMerchantUpgradesPrices(string regionName)
        {
            BinaryReader br = new BinaryReader(File.Open(dialog.FileName, FileMode.Open));
            MerchantUpgradesPrices merchantUpgradesPrices = new MerchantUpgradesPrices();

            int weaponIndex = tab10CbMerchantUpgrades.SelectedIndex; // Option selected on Combobox
            int slesOffsetDifference = 0;

            // Applies bytes difference if it's SLES
            if (regionName == "sles")
            { slesOffsetDifference = 0x280; }

            // Throws error if not SLUS neither SLES
            if (regionName != "slus" && regionName != "sles")
            {
                MessageBoxes("regionError");
                br.Close();
                return;
            }

            // Moves to offset and outputs data in the spinboxes
            br.BaseStream.Position = merchantUpgradesPrices.MerchantUpgradesOffsets[weaponIndex][0] + slesOffsetDifference;
            tab10WeaponID.Value = br.ReadInt16();
            tab10Firepower1.Value = br.ReadInt16() * 10;
            tab10Firepower2.Value = br.ReadInt16() * 10;
            tab10Firepower3.Value = br.ReadInt16() * 10;
            tab10Firepower4.Value = br.ReadInt16() * 10;
            tab10Firepower5.Value = br.ReadInt16() * 10;
            tab10Firepower6.Value = br.ReadInt16() * 10;
            br.ReadInt16(); // padding
            tab10Firing1.Value = br.ReadUInt16() * 10;
            tab10Firing2.Value = br.ReadUInt16() * 10;
            br.ReadInt16(); // padding
            tab10Reload1.Value = br.ReadUInt16() * 10;
            tab10Reload2.Value = br.ReadUInt16() * 10;
            br.ReadInt16(); // padding
            tab10Capacity1.Value = br.ReadInt16() * 10;
            tab10Capacity2.Value = br.ReadInt16() * 10;
            tab10Capacity3.Value = br.ReadInt16() * 10;
            tab10Capacity4.Value = br.ReadInt16() * 10;
            tab10Capacity5.Value = br.ReadInt16() * 10;
            tab10Capacity6.Value = br.ReadInt16() * 10;
            br.ReadInt16(); // padding
            br.Close();
        }
        public void SetMerchantUpgradesPrices(string regionName)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));
            MerchantUpgradesPrices merchantUpgradesPrices = new MerchantUpgradesPrices();

            int weaponIndex = tab10CbMerchantUpgrades.SelectedIndex; // Option selected on Combobox
            int slesOffsetDifference = 0;

            // Applies bytes difference if it's SLES
            if (regionName == "sles")
            { slesOffsetDifference = 0x280; }

            // Throws error if not SLUS neither SLES
            if (regionName != "slus" && regionName != "sles")
            {
                MessageBoxes("regionError");
                bw.Close();
                return;
            }

            // Moves to offset and outputs data in the spinboxes
            bw.BaseStream.Position = merchantUpgradesPrices.MerchantUpgradesOffsets[weaponIndex][0] + slesOffsetDifference;
            bw.Write((ushort)tab10WeaponID.Value);
            bw.Write((ushort)(tab10Firepower1.Value / 10));
            bw.Write((ushort)(tab10Firepower2.Value / 10));
            bw.Write((ushort)(tab10Firepower3.Value / 10));
            bw.Write((ushort)(tab10Firepower4.Value / 10));
            bw.Write((ushort)(tab10Firepower5.Value / 10));
            bw.Write((ushort)(tab10Firepower6.Value / 10));
            bw.Write((ushort)0x00); // padding
            bw.Write((ushort)(tab10Firing1.Value / 10));
            bw.Write((ushort)(tab10Firing2.Value / 10));
            bw.Write((ushort)0x00); // padding
            bw.Write((ushort)(tab10Reload1.Value / 10));
            bw.Write((ushort)(tab10Reload2.Value / 10));
            bw.Write((ushort)0x00); // padding
            bw.Write((ushort)(tab10Capacity1.Value / 10));
            bw.Write((ushort)(tab10Capacity2.Value / 10));
            bw.Write((ushort)(tab10Capacity3.Value / 10));
            bw.Write((ushort)(tab10Capacity4.Value / 10));
            bw.Write((ushort)(tab10Capacity5.Value / 10));
            bw.Write((ushort)(tab10Capacity6.Value / 10));
            bw.Write((ushort)0x00); // padding
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

            this.Text = $"RE4 PS2 ELF Editor - {dialog.FileName}";

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
            if (dialog.FileName != "")
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
                    SetMerchantStock("slus");
                    SetMerchantUpgradesPrices("slus");
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
                    SetMerchantStock("sles");
                    SetMerchantUpgradesPrices("sles");
                }
                else if (region == "SLPM")
                {
                    SaveSLPMAcumulator();
                }
                else { return; }
            }
            else
            {
                return;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void extractELFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialog.FileName != "")
            {
                string region = GetDiscRegion();

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
        private void importCustomELFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblRegion.Text != "")
            {
                // Open dialog box for file select
                OpenFileDialog customElf = new OpenFileDialog();
                customElf.Filter = "RE4 Executable File(*.elf;*.34;*.02)|*.elf;*.34;*.02";
                customElf.ShowDialog();

                string region = GetDiscRegion();
                BinaryReader br = new BinaryReader(File.Open(customElf.FileName, FileMode.Open));
                BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));

                // Verifies executable based on its length
                if (br.BaseStream.Length == 0x2F413C)
                {
                    if (region == "SLUS")
                    {
                        bw.BaseStream.Position = acumulator.ELF_START;
                        bw.Write(br.ReadBytes((int)br.BaseStream.Length));
                        MessageBox.Show("SLUS executable file imported successfully!", "Info", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cannot import different region executable, only: SLUS to SLUS or SLES to SLES.",
                            "ERROR: Mismatch region", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (br.BaseStream.Length == 0x2F43BC)
                {
                    if (region == "SLES")
                    {
                        bw.BaseStream.Position = acumulator.ELF_START;
                        bw.Write(br.ReadBytes((int)br.BaseStream.Length));
                        MessageBox.Show("SLES executable file imported successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Cannot import different region executable, only: SLUS to SLUS or SLES to SLES.",
                            "ERROR: Mismatch region", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBoxes("regionError");
                }
                bw.Close();
                br.Close();
            }
            else
            {
                return;
            }
        }
        private void defaultValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialog.FileName != "")
            {
                string region = GetDiscRegion();

                // Message box for confirmation
                DialogResult setToDefault = MessageBox.Show("Set ALL values to default?", "Question", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (setToDefault == DialogResult.Yes)
                {
                    BinaryWriter bw = new BinaryWriter(File.Open(dialog.FileName, FileMode.Open));
                    if (region == "SLUS")
                    {
                        try
                        {
                            BinaryReader br = new BinaryReader(File.Open("Properties/SLUS_211.34", FileMode.Open));
                            bw.BaseStream.Position = acumulator.ELF_START;
                            bw.Write(br.ReadBytes((int)br.BaseStream.Length));
                            br.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Default executable file not found on Properties folder. Re-download the tool to fix it.");
                        }
                    }
                    else if (region == "SLES")
                    {
                        try
                        {
                            BinaryReader br = new BinaryReader(File.Open("Properties/SLES_537.02", FileMode.Open));
                            bw.BaseStream.Position = acumulator.ELF_START;
                            bw.Write(br.ReadBytes((int)br.BaseStream.Length));
                            br.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Default executable file not found on Properties folder. Re-download the tool to fix it.");
                        }
                    }
                    bw.Close();
                }
                else return;
            }
            else
            {
                return;
            }

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
            if (dialog.FileName != "")
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
            else { return; }
        }
        private void tab7CbMerchantPrices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dialog.FileName != "")
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
            else { return; }
        }
        private void tab8CbMerchant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dialog.FileName != "")
            {
                if (GetDiscRegion() == "SLUS")
                {
                    GetMerchantStock("slus");
                }
                else if (GetDiscRegion() == "SLES")
                {
                    GetMerchantStock("sles");
                }
            }
            else { return; }
        }
        private void tab9CbItemsSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dialog.FileName != "")
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
            else { return; }
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
        private void tab10CbMerchantUpgrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dialog.FileName != "")
            {
                if (GetDiscRegion() == "SLUS")
                {
                    GetMerchantUpgradesPrices("slus");
                }
                else if (GetDiscRegion() == "SLES")
                {
                    GetMerchantUpgradesPrices("sles");
                }
            }
            else { return; }
        }
    }
}