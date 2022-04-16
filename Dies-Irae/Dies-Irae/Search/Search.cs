using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dies_Irae.Search
{
    class Search
    {
        public class Informations
        {
            public List<byte> magic = new List<byte>();
            public byte[] content = null;
            public List<List<byte>> strings = new List<List<byte>>();
            public string path = null;
            public List<string> resume = new List<string>();
        }

        public class Settings
        {
            public decimal string_minimum = 5;
            public decimal magic_size = 10;
        }

        public Informations informations = new Informations();
        public Settings settings = new Settings();
        private Profile.Settings.Rootobject profile = null;
        private bool magic_added = false;

        public Search(string path, Profile.Settings.Rootobject input_profile)
        {
            if (File.Exists(path) == true)
            {
                profile = input_profile;
                informations.content = File.ReadAllBytes(path);
                informations.path = path;
            }
        }

        private void iterate(string item, List<byte> data)
        {
            informations.resume.Add($"<{item}={get_string(data)}>");
        }

        private string get_string(List<byte> data)
        {
            string buffer = "";

            for (int i = 0; i < data.Count; i++)
            {
                buffer += $"0x{data[i]}";
            }

            return (buffer);
        }

        private void add_header(List<byte> header)
        {
            iterate(Editors.Tags.header_tag, header);
        }

        private void add_magic()
        {
            iterate(Editors.Tags.magic_tag, informations.magic);
        }

        private void variables()
        {
            settings.magic_size = profile.data.numeric_magic;
            settings.string_minimum = profile.data.numeric_string_minimum_size;
        }

        public void load()
        {
            variables();
            get_content();
        }

        public void reset()
        {
            informations.magic.Clear();
            informations.content = null;
        }

        private bool update_magic(int index, byte character)
        {
            if (index < settings.magic_size)
            {
                informations.magic.Add(character);
                return (true);
            }
            else
            {
                if (magic_added == false)
                {
                    add_magic();
                    magic_added = true;
                }
            }
            return (false);
        }

        private List<byte> string_to_bytes(string data)
        {
            List<byte> bytes = new List<byte>();

            for (int i = 0; i < data.Length; i++)
            {
                bytes.Add((byte)data[i]);
            }

            return (bytes);
        }

        private void add_informations(int counter, int total_bytes)
        {
            iterate(Editors.Tags.file_bytes_tag, string_to_bytes($"{total_bytes}"));
            iterate(Editors.Tags.total_strings_tag, string_to_bytes($"{counter}"));
            iterate(Editors.Tags.file_path, string_to_bytes($"{informations.path}"));
        }

        private void get_content()
        {
            int current = 0;
            int counter = 1;
            int total_bytes = 0;
            List<byte> char_buffer = new List<byte>();
            List<byte> header = new List<byte>()
            {
                110,
                100,
                105
            };

            add_header(header);
            foreach (byte character in informations.content)
            {
                if (update_magic(current, character) == true)
                    current++;
                if ((character >= 32 && character <= 126))
                {
                    char_buffer.Add(character);
                }
                else
                {
                    if (char_buffer.Count >= settings.string_minimum)
                    {
                        iterate(Editors.Tags.string_tag, char_buffer);
                        counter++;
                    }
                    char_buffer.Clear();
                }
                total_bytes++;
            }
            if (char_buffer.Count > 0)
                char_buffer.Clear();
            add_informations(counter, total_bytes);
        }
    }
}
