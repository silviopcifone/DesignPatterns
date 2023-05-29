using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.model
{
    internal class NotepadProxy : INotepadService
    {
        private INotepadService service;
        private string CachedText = "";
        private bool refreshIsNeeded;

        public NotepadProxy(INotepadService service) {
            this.service = service;
        }

        public string GetText()
        {
            if(CachedText == null || CachedText.Length == 0 || refreshIsNeeded)
            {
                CachedText = service.GetText();
            }

            return CachedText;
        }
    }
}
