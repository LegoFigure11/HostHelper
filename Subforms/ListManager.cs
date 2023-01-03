using HostHelper.Structures;
using Newtonsoft.Json;

namespace HostHelper.Subforms
{
    public partial class ListManager : Form
    {
        private readonly BindingSource bs = new();
        private readonly List<BanlistEntry> Entries = new();
        private readonly string ListName;
        public ListManager(ref List<BanlistEntry> Entries, string ListName)
        {
            InitializeComponent();
            Text = $"List Manager - {ListName}";
            this.Entries = Entries;
            this.ListName = ListName;
            EntryList.DisplayMember = "OT";

            ButtonBan.Enabled = ListName != "Banlist";

            if (EntryList.Items.Count > 0)
            {
                EntryList.SelectedIndex = 0;
                ButtonRemoveAll.Enabled = true;
            }

            ButtonRemove.Enabled = EntryList.SelectedIndex != -1;

            bs.DataSource = Entries;
            EntryList.DataSource = bs;

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            LabelTotal.Text = $"{ListName} Total: {Entries.Count}";
        }

        private void EntryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonRemove.Enabled = EntryList.SelectedIndex >= 0;
            ButtonRemoveAll.Enabled = EntryList.Items.Count > 0;
            if (EntryList.SelectedIndex < 0) return;
            var s = Entries[EntryList.SelectedIndex];
            SelectEntry(s);
            if (MainWindow.BanList.Where(e => e.OT == s.OT && e.ID == s.ID && e.NID == s.NID).Any()) ButtonBan.Enabled = false;
        }

        private void SelectEntry(BanlistEntry b)
        {
            OT.Text = b.OT;
            ID.Text = b.ID;
            NID.Text = b.NID;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (EntryList.Items.Count == 0)
            {
                ButtonRemoveAll.Enabled = false;
                return;
            }
            var idx = EntryList.SelectedIndex;
            Entries.RemoveAt(idx);
            bs.ResetBindings(false);
            UpdateTotal();
        }

        private void ButtonRemoveAll_Click(object sender, EventArgs e)
        {
            Entries.Clear();
            bs.ResetBindings(false);
            UpdateTotal();
            ButtonRemoveAll.Enabled = false;
            ButtonRemove.Enabled = false;
            OT.Text = string.Empty;
            ID.Text = string.Empty;
            NID.Text = string.Empty;
        }

        private void ButtonBan_Click(object sender, EventArgs e)
        {
            if (EntryList.SelectedIndex == -1)
                return;
            var s = Entries[EntryList.SelectedIndex];
            MainWindow.BanList.Add(s);
            ButtonBan.Enabled = false;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ListName == "Banlist")
            {
                MainWindow.BanList = Entries;
            }
            else if (ListName == "Session")
            {
                MainWindow.SessionList = Entries;
            }
            File.WriteAllText(MainWindow.FileName, JsonConvert.SerializeObject(MainWindow.BanList, Formatting.Indented));
            Close();
        }
    }
}
