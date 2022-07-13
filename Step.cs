using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clal_HW
{
    class Step 
    {
        public int  Id { get; set; }
        public string OperationName { get; set; }

        public int NextIdIfOutputIsLessThan { get; set; }

        public int NextIdIfOutputIsGreaterThan { get; set; }

    }

}

