using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.model
{
    internal class NotepadService : INotepadService
    {
        String Text = "ciao";

        public string GetText()
        {
            return Text;
        }
    }
}
