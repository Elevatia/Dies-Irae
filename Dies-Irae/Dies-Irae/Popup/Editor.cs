using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dies_Irae.Popup
{
    public partial class Editor : Form
    {
        BackgroundWorker loader = new BackgroundWorker();
        Controler.Manager manager = new Controler.Manager();
        private List<string> content = new List<string>();
        private Dictionary<string, string> result = new Dictionary<string, string>();
        private List<string> types = new List<string>();

        public Editor(List<string> input_content)
        {
            InitializeComponent();
            InitializeWorkers();

            Region = Region.FromHrgn(Controler.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            content = input_content;
        }

        private void InitializeWorkers()
        {
            loader.DoWork += new DoWorkEventHandler(load);
        }

        private string remove_at(string line, int index)
        {
            string buffer = "";

            for (int i = 0; i < line.Length; i++)
            {
                if (i != index)
                {
                    buffer += line[i];
                }
            }

            return (buffer);
        }

        private void interpreter(string line)
        {
            string[] splitted = null;
            string new_line = "";
            bool decode = true;

            if (line.Length > 2)
            {
                line = remove_at(line, 0);
                line = remove_at(line, line.Length - 1);
            }
            line = line.Replace("0x", "=");
            splitted = line.Split('=');
            decode = (splitted[0] != Editors.Tags.magic_tag);
            for (int i = 1; i < splitted.Length; i++)
            {
                if (splitted[i] != string.Empty)
                {
                    if (Editors.Tags.all.Contains(splitted[i]) == false && decode == true)
                    {
                        new_line += (char)(Int32.Parse(splitted[i]));
                    }
                    else
                    {
                        new_line += splitted[i];
                    }
                }
            }
            if (result.ContainsKey(splitted[0]) == false)
                result[splitted[0]] = new_line;
            else
                types.Add(new_line);
        }

        private void load(object sender, EventArgs e)
        {
            foreach (string line in content)
            {
                if (line != null)
                    interpreter(line);
            }

            foreach (KeyValuePair<string, string> item in result)
            {
                if (item.Key == Editors.Tags.magic_tag)
                {
                    manager.set_textbox(box_magic_number, item.Value);
                } else if (item.Key == Editors.Tags.file_bytes_tag)
                {
                    manager.set_textbox(box_total_file_bytes, item.Value);
                } else if (item.Key == Editors.Tags.total_strings_tag)
                {
                    manager.set_textbox(box_total_strings_tag, item.Value);
                }
                else if (item.Key == Editors.Tags.file_path)
                {
                    manager.set_textbox(box_file_path, item.Value);
                }
            }
            foreach (string data in types)
            {
                manager.add_richtext(box_view, data);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Editor_Shown(object sender, EventArgs e)
        {
            loader.RunWorkerAsync();

            while (loader.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
