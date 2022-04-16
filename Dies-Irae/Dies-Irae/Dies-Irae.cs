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

namespace Dies_Irae
{
    public partial class Dies_Irae : Form
    {
        BackgroundWorker scanner = new BackgroundWorker();
        BackgroundWorker dumper = new BackgroundWorker();
        Controler.Manager manager = new Controler.Manager();
        Popup.Editor editor = null;
        Search.Search searcher = null;
        Popup.Settings settings = null;

        Profile.Settings.Rootobject profile = null;

        public Dies_Irae(Profile.Settings.Rootobject input_profile)
        {
            InitializeComponent();
            InitializeUi();
            InitializeWorkers();

            profile = input_profile;
        }

        private void InitializeUi()
        {
            Region = Region.FromHrgn(Controler.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void InitializeWorkers()
        {
            scanner.DoWork += new DoWorkEventHandler(scan);
            dumper.DoWork += new DoWorkEventHandler(dump);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_reduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            select_file.ShowDialog();

            if (select_file.FileName != string.Empty)
            {
                button_scan.Enabled = true;
            } else
            {
                if (button_scan.Enabled == true)
                {
                    manager.button(button_scan, false);
                    manager.button(button_browse, false);
                    manager.button(button_scan, false);
                    manager.button(button_editor, false);
                }
            }
        }

        private void scan(object sender, EventArgs e)
        {
            manager.button(button_browse, false);
            manager.button(button_scan, false);
            manager.button(button_dump, false);
            manager.button(button_editor, false);
            manager.button(button_select_dump, false);

            searcher = new Search.Search(select_file.FileName, profile);
            searcher.load();
            searcher.reset();
            editor = new Popup.Editor(searcher.informations.resume);

            manager.button(button_scan, true);
            manager.button(button_browse, true);
            manager.button(button_dump, true);
            manager.button(button_editor, true);
            manager.button(button_select_dump, true);
        }

        private void button_scan_Click(object sender, EventArgs e)
        {
            scanner.RunWorkerAsync();

            while (scanner.IsBusy == true)
            {
                Application.DoEvents();
            }
            scanner.Dispose();
        }

        private void dump(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("hmmssddMMyyyy");

            manager.button(button_browse, false);
            manager.button(button_scan, false);
            manager.button(button_dump, false);
            manager.button(button_editor, false);
            manager.button(button_select_dump, false);

            // NDFF: Neo Data File Format
            File.WriteAllLines($"dump\\{date}.ndff", searcher.informations.resume);

            manager.button(button_browse, true);
            manager.button(button_scan, true);
            manager.button(button_dump, true);
            manager.button(button_editor, true);
            manager.button(button_select_dump, true);
        }

        private void button_dump_Click(object sender, EventArgs e)
        {
            dumper.RunWorkerAsync();

            while (dumper.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            settings = new Popup.Settings(profile);
            settings.ShowDialog();

            profile = settings.profile;
        }

        private void button_editor_Click(object sender, EventArgs e)
        {
            editor.ShowDialog();
        }

        private bool select_dump_event()
        {
            select_dump.ShowDialog();

            if (select_dump.FileName != string.Empty)
            {
                return (true);
            }

            return (false);
        }

        private void button_select_dump_Click(object sender, EventArgs e)
        {
            List<string> data = null;

            if (select_dump_event() == true)
            {
                manager.button(button_editor, true);
                editor = new Popup.Editor(File.ReadAllLines(select_dump.FileName).ToList<string>());
            }
            else
            {
                if (button_editor.Enabled == true)
                {
                    manager.button(button_editor, false);
                }
            }
        }
    }
}
