using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobyRecover
{
    public partial class FormMain : Form
    {
        List<TobyData> DataList = new List<TobyData>();
        TobyData Data;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataList.Clear();
            cbHistory.Items.Clear();
            lbLists.Items.Clear();
            lvCards.Items.Clear();

            OpenFileDialog diag = new OpenFileDialog() { CheckFileExists = true };
            if (diag.ShowDialog() != DialogResult.OK)
                return;

            FileStream fs = new FileStream(diag.FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs, Encoding.UTF8);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                int begin = 0, end = 0;
                while ((begin = line.IndexOf("\\\"lists\\\"", end)) >= 0)
                {
                    begin -= 1;
                    end = line.IndexOf("}}\"", begin);
                    if (end < 0)
                        break;
                    end += 1;
                    int size = end - begin + 1;

                    string json = line.Substring(begin, size);
                    json = json.Replace("\\\\", "\\");
                    json = json.Replace("\\\"", "\"");

                    try
                    {
                        TobyData data = JsonConvert.DeserializeObject<TobyData>(json);
                        DataList.Add(data);
                        cbHistory.Items.Add(cbHistory.Items.Count + 1);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            reader.Close();
            fs.Close();
        }
        
        private void lbLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLists.SelectedIndex < 0)
                return;

            lvCards.Items.Clear();
            var cards = Data.lists[lbLists.SelectedIndex].cards;
            foreach (var card in cards)
            {
                TobyCard c = Data.cards[card];
                ListViewItem item = new ListViewItem(c.id.ToString());
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = c.title, Name = "Title" });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = c.url, Name = "Url" });
                lvCards.Items.Add(item);
            }
        }

        private void cbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLists.Items.Clear();
            lvCards.Items.Clear();
            Data = DataList[cbHistory.SelectedIndex];
            foreach (var list in Data.lists)
                lbLists.Items.Add(list.title);
        }
    }
}
