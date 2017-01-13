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
        // Order in which this node sits in the space delimited log file
        private int order { get; }

        private string displayName { get; set; }

        private string name { get; set; }

        public FieldHeaderNode(int order, string name, string displayName) : base(displayName)
        {
            
        }
    }
}
