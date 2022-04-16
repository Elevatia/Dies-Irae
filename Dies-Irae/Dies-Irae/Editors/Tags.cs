using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dies_Irae.Editors
{
    public class Tags
    {
        // Types
        public static string string_tag = "string";
        public static string bytes_tag = "bytes";
        public static string int_tag = "int";

        public static List<string> types = new List<string>()
        {
            string_tag,
            bytes_tag,
            int_tag
        };

        // Editor
        public static string header_tag = "header";
        public static string information_tag = "information";
        public static string magic_tag = "magic";
        public static string file_bytes_tag = "file bytes";
        public static string total_strings_tag = "total strings";
        public static string file_path = "path file";

        public static List<string> editor = new List<string>()
        {
            header_tag,
            information_tag,
            magic_tag,
            file_bytes_tag,
            total_strings_tag,
            file_path
        };

        // ALL

        public static List<string> all = new List<string>()
        {
            string_tag,
            bytes_tag,
            int_tag,
            header_tag,
            information_tag,
            magic_tag
        };
    }
}
