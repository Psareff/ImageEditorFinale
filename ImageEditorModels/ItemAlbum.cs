using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditorFinale
{
    internal class ItemAlbum
    {
        private List<ImageEditorItem> _items;
        public ItemAlbum()
        {
            _items = new List<ImageEditorItem>();
        }

        public List<ImageEditorItem> Items

        {
            get => _items;
            set => _items = value;
        }
    }
}
