using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebtrendsLogFilePro
{
    class FieldHeaderNode : TreeNode
    {
        // The actual value in the log file
        public string name { get; set; }

        // If I want to put friendly text e.g.: cs-username -> Auth Username
        public string displayName { get; set; }


        public FieldHeaderNode(string name, string displayName) : base(displayName)
        {
            this.name = name;
            this.displayName = displayName;
        }
    }
}
