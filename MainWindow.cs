using HostHelper.Properties;
using HostHelper.Structures;
using HostHelper.Subforms;
using Newtonsoft.Json;
using PKHeX.Core;
using SysBot.Base;
using System.Buffers.Binary;
using System.Net.Sockets;
using static HostHelper.Structures.Offsets;

namespace HostHelper
{
    public partial class MainWindow : Form
    {
        private readonly static SwitchConnectionConfig Config = new() { Protocol = SwitchProtocol.WiFi, IP = Settings.Default.SwitchIP, Port = 6000 };
        private readonly static SwitchSocketAsync SwitchConnection = new(Config);

        private static string TitleText = string.Empty;

        private static ulong NIDListOffset;

        private bool Stop = false;

        private Color DefaultColor;

        public readonly static string FileName = "Banlist.json";
        public static List<BanlistEntry> SessionList = new();
        public static List<BanlistEntry> BanList = new();

        public MainWindow()
        {
            string build = string.Empty;
#if DEBUG
            var date = File.GetLastWriteTime(System.Reflection.Assembly.GetEntryAssembly()!.Location);
            build = $" (dev-{date:yyyyMMdd})";
#endif
            var v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version!;
            TitleText = "HostHelper v" + v.Major + "." + v.Minor + "." + v.Build + build;

            if (!File.Exists(FileName))
            {
                File.Move("Banlist_template.json", FileName);
            }

            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = TitleText;
            InputSwitchIP.Text = Settings.Default.SwitchIP;
            Guest1OT.Text = string.Empty;
            Guest2OT.Text = string.Empty;
            Guest3OT.Text = string.Empty;
            Guest1ID.Text = string.Empty;
            Guest2ID.Text = string.Empty;
            Guest3ID.Text = string.Empty;
            Guest1NID.Text = string.Empty;
            Guest2NID.Text = string.Empty;
            Guest3NID.Text = string.Empty;
            DefaultColor = Guest1ID.BackColor;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            Guest1OT.Text = string.Empty;
            Guest1OT.BackColor = DefaultColor;
            Guest2OT.Text = string.Empty;
            Guest2OT.BackColor = DefaultColor;
            Guest3OT.Text = string.Empty;
            Guest3OT.BackColor = DefaultColor;
            Guest1ID.Text = string.Empty;
            Guest1ID.BackColor = DefaultColor;
            Guest2ID.Text = string.Empty;
            Guest2ID.BackColor = DefaultColor;
            Guest3ID.Text = string.Empty;
            Guest3ID.BackColor = DefaultColor;
            Guest1NID.Text = string.Empty;
            Guest1NID.BackColor = DefaultColor;
            Guest2NID.Text = string.Empty;
            Guest2NID.BackColor = DefaultColor;
            Guest3NID.Text = string.Empty;
            Guest3NID.BackColor = DefaultColor;
            Guest1Ban.Enabled = false;
            Guest2Ban.Enabled = false;
            Guest3Ban.Enabled = false;
            Guest1Status.Image = Resources.tick;
            Guest2Status.Image = Resources.tick;
            Guest3Status.Image = Resources.tick;
            ButtonConnect.Enabled = false;
            ButtonStop.Enabled = true;
            Stop = false;
            Connect();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            Stop = true;
            ButtonStop.Enabled = false;
            ButtonConnect.Enabled = true;
        }

        private void InputSwitchIP_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "192.168.0.0")
            {
                Settings.Default.SwitchIP = textBox.Text;
                Config.IP = textBox.Text;
            }
            Settings.Default.Save();
        }

        private void ButtonManageSession_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText(FileName);
            BanList = JsonConvert.DeserializeObject<List<BanlistEntry>>(jsonString)!;
            if (SessionList.Count > 0)
            {
                var w = new ListManager(ref SessionList, "Session");
                w.ShowDialog();
            }
            else
            {
                MessageBox.Show("No users in the current session!");
            }
            LabelSession.Text = $"Session Raiders: {SessionList.Count}";
        }


        private void ButtonManageBanlist_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText(FileName);
            BanList = JsonConvert.DeserializeObject<List<BanlistEntry>>(jsonString)!;
            if (BanList.Count > 0)
            {
                var w = new ListManager(ref BanList, "Banlist");
                w.ShowDialog();
            }
            else
            {
                MessageBox.Show("No users in the current banlist!");
            }
        }

        private void Guest1Ban_Click(object sender, EventArgs e)
        {
            Guest1Ban.Enabled = false;
            var bl = new BanlistEntry()
            {
                OT = Guest1OT.Text,
                ID = Guest1ID.Text,
                NID = Guest1NID.Text,
            };
            BanList.Add(bl);
            File.WriteAllText(FileName, JsonConvert.SerializeObject(BanList, Formatting.Indented));
        }

        private void Guest2Ban_Click(object sender, EventArgs e)
        {
            Guest2Ban.Enabled = false;
            var bl = new BanlistEntry()
            {
                OT = Guest2OT.Text,
                ID = Guest2ID.Text,
                NID = Guest2NID.Text,
            };
            BanList.Add(bl);
            File.WriteAllText(FileName, JsonConvert.SerializeObject(BanList, Formatting.Indented));
        }

        private void Guest3Ban_Click(object sender, EventArgs e)
        {
            Guest3Ban.Enabled = false;
            var bl = new BanlistEntry()
            {
                OT = Guest3OT.Text,
                ID = Guest3ID.Text,
                NID = Guest3NID.Text,
            };
            BanList.Add(bl);
            File.WriteAllText(FileName, JsonConvert.SerializeObject(BanList, Formatting.Indented));
        }

        private async void Connect()
        {
            string jsonString = File.ReadAllText(FileName);
            BanList = JsonConvert.DeserializeObject<List<BanlistEntry>>(jsonString)!;
            if (!SwitchConnection.Connected)
            {
                try
                {
                    SwitchConnection.Connect();
                    string id = await GetGameID(CancellationToken.None);
                    if (id is not (ScarletID or VioletID))
                    {
                        MessageBox.Show("Unable to detect Pokémon Scarlet or Pokémon Violet running on your switch!");
                        SwitchConnection.Disconnect();
                    }
                    else
                    {
                        string OT, ID;
                        bool Found1 = false, Found2 = false, Found3 = false;
                        NIDListOffset = await SwitchConnection.PointerAll(NIDListPointer, CancellationToken.None);

                        await ClearNID(NIDListOffset, CancellationToken.None);

                        while (!Stop && SwitchConnection.Connected && !(Found1 && Found2 && Found3))
                        {
                            ulong[] NIDs = await GetNIDs(NIDListOffset, CancellationToken.None);
                            if (!Found1 && NIDs[0] is not 0)
                            {
                                // Guest 1
                                Guest1OT.Text = "Loading...";
                                Guest1ID.Text = "Loading...";
                                Guest1NID.Text = $"{NIDs[0]:X16}";
                                await Task.Delay(4_000);
                                ulong off = await GetPointerAddress(Guest1Pointer, CancellationToken.None);
                                (OT, ID) = await GetTrainerData(off, CancellationToken.None);
                                Guest1OT.Text = OT;
                                Guest1ID.Text = ID;
                                Guest1Ban.Enabled = true;
                                Found1 = true;
                                var e = new BanlistEntry()
                                {
                                    OT = OT,
                                    ID = ID,
                                    NID = $"{NIDs[0]:X16}",
                                };
                                SessionList.Add(e);

                                Color c = DefaultColor;
                                if (SessionList.Where(e => (e.OT == OT && e.ID == ID) || e.NID == $"{NIDs[0]:X16}").Count() > AllowedEntries.Value)
                                {
                                    c = Color.Gold;
                                    Guest1Status.Image = Resources.cross;
                                }
                                if (BanList.Where(e => (e.OT == OT && e.ID == ID) || e.NID == $"{NIDs[0]:X16}").Any())
                                {
                                    c = Color.IndianRed;
                                    Guest1Status.Image = Resources.cross;
                                    Guest1Ban.Enabled = false;
                                }

                                Guest1OT.BackColor = c;
                                Guest1ID.BackColor = c;
                                Guest1NID.BackColor = c;
                            }
                            if (!Found2 && NIDs[1] is not 0)
                            {
                                // Guest 2
                                Guest2OT.Text = "Loading...";
                                Guest2ID.Text = "Loading...";
                                Guest2NID.Text = $"{NIDs[1]:X16}";
                                await Task.Delay(4_000);
                                ulong off = await GetPointerAddress(Guest2Pointer, CancellationToken.None);
                                (OT, ID) = await GetTrainerData(off, CancellationToken.None);
                                Guest2OT.Text = OT;
                                Guest2ID.Text = ID;
                                Guest2Ban.Enabled = true;
                                Found2 = true;
                                var e = new BanlistEntry()
                                {
                                    OT = OT,
                                    ID = ID,
                                    NID = $"{NIDs[1]:X16}",
                                };
                                SessionList.Add(e);

                                Color c = DefaultColor;
                                if (SessionList.Where(e => (e.OT == OT && e.ID == ID) || e.NID == $"{NIDs[1]:X16}").Count() > AllowedEntries.Value)
                                {
                                    c = Color.Gold;
                                    Guest2Status.Image = Resources.cross;
                                }
                                if (BanList.Where(e => (e.OT == OT && e.ID == ID) || e.NID == $"{NIDs[1]:X16}").Any())
                                {
                                    c = Color.IndianRed;
                                    Guest2Status.Image = Resources.cross;
                                    Guest2Ban.Enabled = false;
                                }

                                Guest2OT.BackColor = c;
                                Guest2ID.BackColor = c;
                                Guest2NID.BackColor = c;
                            }
                            if (!Found3 && NIDs[2] is not 0)
                            {
                                // Guest 3
                                Guest3OT.Text = "Loading...";
                                Guest3ID.Text = "Loading...";
                                Guest3NID.Text = $"{NIDs[2]:X16}";
                                await Task.Delay(4_000);
                                ulong off = await GetPointerAddress(Guest3Pointer, CancellationToken.None);
                                (OT, ID) = await GetTrainerData(off, CancellationToken.None);
                                Guest3OT.Text = OT;
                                Guest3ID.Text = ID;
                                Guest3Ban.Enabled = true;
                                Found3 = true;
                                var e = new BanlistEntry()
                                {
                                    OT = OT,
                                    ID = ID,
                                    NID = $"{NIDs[2]:X16}",
                                };
                                SessionList.Add(e);

                                Color c = DefaultColor;
                                if (SessionList.Where(e => (e.OT == OT && e.ID == ID) || e.NID == $"{NIDs[2]:X16}").Count() > AllowedEntries.Value)
                                {
                                    c = Color.Gold;
                                    Guest3Status.Image = Resources.cross;
                                }
                                if (BanList.Where(e => (e.OT == OT && e.ID == ID) || e.NID == $"{NIDs[2]:X16}").Any())
                                {
                                    c = Color.IndianRed;
                                    Guest3Status.Image = Resources.cross;
                                    Guest3Ban.Enabled = false;
                                }

                                Guest3OT.BackColor = c;
                                Guest3ID.BackColor = c;
                                Guest3NID.BackColor = c;
                            }
                            await Task.Delay(1_000);
                        }
                    }
                }
                catch (SocketException err)
                {
                    if (SwitchConnection.Connected)
                    {
                        await SwitchConnection.SendAsync(SwitchCommand.DetachController(true), CancellationToken.None).ConfigureAwait(false);
                        SwitchConnection.Disconnect();
                    }
                    // a bit hacky but it works
                    if (err.Message.Contains("failed to respond") || err.Message.Contains("actively refused"))
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            if (SwitchConnection.Connected) SwitchConnection.Disconnect();
            LabelSession.Text = $"Session Raiders: {SessionList.Count}";
            ButtonConnect.Enabled = true;
            ButtonStop.Enabled = false;
        }

        private static async Task<string> GetGameID(CancellationToken token) => await SwitchConnection.GetTitleID(token).ConfigureAwait(false);

        private static async Task<ulong[]> GetNIDs(ulong offset, CancellationToken token)
        {
            var data = await SwitchConnection.ReadBytesAbsoluteAsync(offset, 8 * 3, token).ConfigureAwait(false);
            return new ulong[] { BitConverter.ToUInt64(data, 0), BitConverter.ToUInt64(data, 8), BitConverter.ToUInt64(data, 16) };
        }

        private static async Task ClearNID(ulong offset, CancellationToken token)
        {
            var data = new byte[24];
            await SwitchConnection.WriteBytesAbsoluteAsync(data, offset, token).ConfigureAwait(false);
        }

        private static async Task<(string, string)> GetTrainerData(ulong offset, CancellationToken token)
        {
            var data = await SwitchConnection.ReadBytesAbsoluteAsync(offset, 32, token).ConfigureAwait(false);
            uint sid = BinaryPrimitives.ReadUInt32LittleEndian(data.AsSpan(0)) / 1_000_000;
            uint tid = BinaryPrimitives.ReadUInt32LittleEndian(data.AsSpan(0)) % 1_000_000;
            string TrainerName = StringConverter8.GetString(data.AsSpan(8, 24));
            return (TrainerName, $"({sid:D4})-{tid:D6}");
        }

        private static async Task<ulong> GetPointerAddress(string pointer, CancellationToken token, bool heaprealtive = false)
        {
            var ptr = pointer;
            if (string.IsNullOrWhiteSpace(ptr) || ptr.IndexOfAny(new char[] { '-', '/', '*' }) != -1)
                return 0;
            while (ptr.Contains("]]"))
                ptr = ptr.Replace("]]", "]+0]");
            uint? finadd = null;
            if (!ptr.EndsWith("]"))
            {
                finadd = Util.GetHexValue(ptr.Split('+').Last());
                ptr = ptr[..ptr.LastIndexOf('+')];
            }
            var jumps = ptr.Replace("main", "").Replace("[", "").Replace("]", "").Split(new[] { "+" }, StringSplitOptions.RemoveEmptyEntries);
            if (jumps.Length == 0)
                return 0;

            var initaddress = Util.GetHexValue(jumps[0].Trim());
            ulong address = BitConverter.ToUInt64(await SwitchConnection.ReadBytesMainAsync(initaddress, 0x8, token).ConfigureAwait(false), 0);
            foreach (var j in jumps)
            {
                var val = Util.GetHexValue(j.Trim());
                if (val == initaddress)
                    continue;
                address = BitConverter.ToUInt64(await SwitchConnection.ReadBytesAbsoluteAsync(address + val, 0x8, token).ConfigureAwait(false), 0);
            }
            if (finadd != null) address += (ulong)finadd;
            if (heaprealtive)
            {
                ulong heap = await SwitchConnection.GetHeapBaseAsync(token);
                address -= heap;
            }
            return address;
        }
    }
}