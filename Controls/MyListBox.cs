using System;
using System.Windows.Forms;
using System.Drawing;

namespace CQE.Controls
{
    public sealed class MyListBox : ListBox
    {
        private ImageList _myImageList;
        public ImageList ImageList
        {
            get { return _myImageList; }
            set { _myImageList = value; }
        }
        public MyListBox()
        {
            // Set owner draw mode
            _myImageList = new ImageList();
            DrawMode = DrawMode.OwnerDrawFixed;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            MyListBoxItem item;
            Rectangle bounds = e.Bounds;
            Size imageSize = _myImageList.ImageSize;
            try
            {
                item = (MyListBoxItem)Items[e.Index];
                if (item.ImageIndex != -1)
                {
                    ImageList.Draw(e.Graphics, bounds.Left, bounds.Top + 2, imageSize.Width, imageSize.Height, item.ImageIndex);
                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor),
                        bounds.Left + imageSize.Width, bounds.Top + 3);
                }
                else
                {
                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor),
                        bounds.Left, bounds.Top + 3);
                }
            }
            catch
            {
                if (e.Index != -1)
                {
                    try
                    {
                        e.Graphics.DrawString(Items[e.Index].ToString(), e.Font,
                            new SolidBrush(e.ForeColor), bounds.Left, bounds.Top + 3);
                    }
                    catch { }
                }
                else
                {
                    e.Graphics.DrawString(Text, e.Font, new SolidBrush(e.ForeColor),
                        bounds.Left, bounds.Top + 3);
                }
            }
            base.OnDrawItem(e);
        }
    }

    public class MyListBoxItem
    {
        private string _myText;
        // properties 

        public string Text
        {
            get { return _myText; }
            set { _myText = value; }
        }

        public int ImageIndex { get; set; }

        //constructor

        public MyListBoxItem(string text, int index)
        {
            _myText = text;
            ImageIndex = index;
        }
        public MyListBoxItem(string text) : this(text, -1) { }
        public MyListBoxItem() : this("") { }
        public override string ToString()
        {
            return _myText;
        }
    }



}