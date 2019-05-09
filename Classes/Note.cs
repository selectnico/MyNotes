using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes.Classes
{
    public class Note
    {
        // Identifier
        public int ID { get; set; }
        public int ownerID { get; set; }
        // Note Content
        public string title { get; set; }
        public string content { get; set; }
        public bool isChecked { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
