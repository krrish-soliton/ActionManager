using GoLib.Common;
using GoLib.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace GoActionManager
{
    public partial class ActionManagerForm : MaterialAnimatedForm
    {
        public ActionManagerForm()
        {
            InitializeComponent();
        }

        private readonly List<ProcessContainer> processContainers = new List<ProcessContainer>();

        private void OnAddClicked(object sender, EventArgs e)
        {
            if (NameBx.Text.IsNullOrEmpty())
            {
                MaterialMessageBox.Show("Invalid Name");
                return;
            }
            if (processContainers.Any(i => i.Text.ToLower() == NameBx.Text.ToLower()))
            {
                MaterialMessageBox.Show("Name already present. Please type different name");
                return;
            }
            var container = CreateContainer();
            container.Name = container.Text = NameBx.Text;
        }

        private ProcessContainer CreateContainer()
        {
            var container = new ProcessContainer() { Dock = DockStyle.Top };
            processContainers.Add(container);
            MainPanel.Controls.Add(container);
            container.DeleteActivated += OnContainerDeleted;
            container.BringToFront();
            return container;
        }

        private void OnContainerDeleted(object sender, EventArgs e)
        {
            if (sender is ProcessContainer container
                && MaterialMessageBox.Show("Do you want to delete the process?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                container.DeleteActivated -= OnContainerDeleted;
                processContainers.Remove(container);
                MainPanel.Controls.Remove(container);
            }
        }

        private void OnLoadClicked(object sender, EventArgs e)
        {
            if (FileOpener.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    var response = JsonConvert.DeserializeObject<List<ProcessContainerData>>(File.ReadAllText(FileOpener.FileName));
                    foreach (var item in response)
                    {
                        var container = CreateContainer();
                        container.Name = container.Text = item.Name;
                        container.SetProcessContainer(item);
                    }
                }
                catch
                {
                    MaterialMessageBox.Show("Unable to read the file.");
                }
            }
        }

        private void OnDownloadClicked(object sender, EventArgs e)
        {
            if (FileSaver.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    var response = JsonConvert.SerializeObject(processContainers.Select(i => i.GetProcessContainerData()).ToList(), Formatting.Indented);
                    File.WriteAllText(FileSaver.FileName, response);
                }
                catch
                {
                    MaterialMessageBox.Show("Unable to write the file.");
                }
            }
        }
    }
}
