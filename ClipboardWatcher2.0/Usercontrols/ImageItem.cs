using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClipboardWatcher
{
    public partial class ImageItem : UserControl
    {

        private Bitmap picture;
        private string pictureName;
        private static int id = 0;
        private bool selected;
        private string pathToImage;
        public ImageItem(string pictureName, Bitmap picture)
        {
            InitializeComponent();
            this.pictureName = pictureName;
            this.picture = picture;
            id++;
            
            //If the picture doesn't fit in the picturebox, stretch it. Otherwise, set it as an image instead of an backgroundimage,
            //so the property SizeMode.CenterImage centers it. (Requires Image instead of Backgroundimage)
            if (picture.Size.Width > pbPicture.Size.Width || picture.Size.Height > pbPicture.Size.Height)
            {
                pbPicture.BackgroundImageLayout = ImageLayout.Stretch;
                pbPicture.BackgroundImage = picture;
            }
            else
                pbPicture.Image = picture;

            lblPictureName.Text = pictureName;
        }

        public string Path
        {
            set { pathToImage = value; }
            get { return pathToImage; }
        }
        private void ImageItem_Load(object sender, EventArgs e)
        {

        }
       
        public string Title
        {
            get { return lblPictureName.Text; }
            set
            {                
                lblPictureName.Text = value;

                //Update ImageItem.Path aswell
                pathToImage = System.IO.Path.GetDirectoryName(pathToImage) + "\\" + lblPictureName.Text;
            }
        }
        /// <summary>
        /// Get's the ID of the ImageItem
        /// </summary>
        public int ID
        {
            get { return id; }
        }

        public void ReloadImage()
        {
            Image img;           
            using (Bitmap bmpTemp = new Bitmap(Path))
            {
                img = new Bitmap(bmpTemp);
            }

            pbPicture.BackgroundImage.Dispose(); //Let's not create a memory leak
            pbPicture.BackgroundImage = img;            
        }
        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                if(selected)                
                    this.BackColor = Color.LightBlue;                
                else
                    this.BackColor = Color.Transparent;
            }
        }

        
    }
}
