using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;
using System.IO;
using System.Diagnostics;

namespace ClipboardWatcher
{
    public partial class UCImages : UserControl
    {
        //displays below the image
        private int imageCount = 1;

        //The current amount of images next to eachother in a row. [] = 1,   []  [] = 2,     []  []  [] = 3
        private int imagesInRow = 0;

        //The amount of vertical rows down of images (3 images per row)
        private int imageRows = 0;

        //List of all the ImageItem objects
        private List<ImageItem> addedImages = new List<ImageItem>();

        //Same logic as in allowClipboard. See allowClipboard.allowClipboard
        private bool allowClipboard = true;
        
        public UCImages()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds an image to the view of images
        /// </summary>
        /// <param name="image">The image that will be added</param>
        public void AddImage(Bitmap image)
        {
            if (!allowClipboard)
            {
                image.Dispose();
                return;
            }


            string pathToImage = BLSettings.Settings.SaveImagePath + "\\" + DateTime.Now.Year + "\\" + GetStringMonth() + "\\" + DateTime.Now.Day + " " + GetStringMonth() + "\\" + imageCount + " (" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ").png";

            //If for some reason (maybe the user did this for fun) the file 3.png or 4.png etc already exists, give it a new name
            int existsCounter = 0;
            while(File.Exists(pathToImage))
            {
                existsCounter++;
                pathToImage = BLSettings.Settings.SaveImagePath + "\\" + DateTime.Now.Year + "\\" + GetStringMonth() + "\\" + DateTime.Now.Day + " " + GetStringMonth() + "\\" + (imageCount+ existsCounter) + " (" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ").png";
            }

            //Save the image locally
            String test = Path.GetDirectoryName(pathToImage);
            if (!Directory.Exists(pathToImage))
                Directory.CreateDirectory(Path.GetDirectoryName(pathToImage));

            
            image.Save(pathToImage);
            
            ImageItem img = new ImageItem(""+(imageCount + existsCounter) + " (" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ").png", image);
            img.Path = pathToImage;
            //Add the image to the control and re-position it
            pnlImages.Controls.Add(img);
            img.Location = CalculateNewImagePosition();

            //Add the image to the collection of all images
            addedImages.Add(img);

            //Apply event handlers to the newly created ImageItem
            img.MouseClick += imgObject_Click;
            img.lblPictureName.MouseClick += imgLabel_Click;
            img.pbPicture.MouseClick += imgPicture_Click;

            img.DoubleClick += imgObject_DoubleClick;
            img.lblPictureName.DoubleClick += imgLabel_DoubleClick;
            img.pbPicture.DoubleClick += imgPicture_DoubleClick;

            allowClipboard = false;
            tmrImageTimeout.Start();

            //Increase the imageCount which displays below the image
            imageCount++;

            //Start watching for changes
            Watch(img.Path);
        }

        private void imgObject_DoubleClick(object sender, EventArgs e)
        {
            ImageItem img = (ImageItem)sender;

            Process.Start(img.Path);
        }

        private void imgPicture_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ImageItem img = (ImageItem)pb.Parent;

            Process.Start(img.Path);

        }

        private void imgLabel_DoubleClick(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            ImageItem img = (ImageItem)lbl.Parent.Parent;

            Process.Start(img.Path);
        }

        private string GetStringMonth()
        {
            switch (DateTime.Now.Month)
            {
                case 1:
                    return "January";                    
                case 2:
                    return "February";                    
                case 3:
                    return "March";                    
                case 4:
                    return "April";                    
                case 5:
                    return "May";                    
                case 6:
                    return "June";                    
                case 7:
                    return "July";                    
                case 8:
                    return "August";                    
                case 9:
                    return "September";                    
                case 10:
                    return "October";                    
                case 11:
                    return "November";                    
                case 12:
                    return "December";
                default: return null;
            }
        }


        /// <summary>
        /// Calculates the position the next image should be placed at
        /// </summary>
        /// <returns>The position the next image should be placed at</returns>
        private Point CalculateNewImagePosition()
        {       
            //Calculate the location for the new image. If it is the first image, it will be at 25 pixels, to have some padding.
            //If it's the second, it will be (width of an ImageItem) * the amount of images in the row, so if there are 2 images, 2 * width + padding 
            //which will place it after the second one. Y coördinates are the same, (amount of vertical rows) * (height of item) + padding (10)
            Point point = new Point(imagesInRow * 215 + 25 + pnlImages.AutoScrollPosition.X, (imageRows * 150) + 10 + pnlImages.AutoScrollPosition.Y);

            //If imagesInRow exceeds 3, reset it to 0 because the maximum amount of images next to eachother is 3.
            imagesInRow++;

            //3 Images in a row? Set it to 0 again, since the maximum of images horizontally is 3.
            if (imagesInRow >= 3)
            {
                imagesInRow = 0;
                imageRows++;
            }


            return point;
        }

        private void DeselectAllImagesExcept(ImageItem itm)
        {
            foreach(ImageItem item in addedImages)
            {
                if (item != itm)
                    item.Selected = false;
            }
        }

        private void imgPicture_Click(object sender, MouseEventArgs e)
        {       
            PictureBox pb = (PictureBox)sender;
            ImageItem img = (ImageItem)pb.Parent;

            if (!File.Exists(img.Path)) //File doesnt exist anymore
            {                
                addedImages.Remove(img); 
                img.Dispose();
                ReArrangeImages();
                return;
            }

            if (e.Button == MouseButtons.Right) //Right mouse button clicked. Show option menu / highlight but NOT de-highlight
            {
                if (!img.Selected)
                    img.Selected = true;                

                imageContextMenuStrip.Show(Cursor.Position);

                return;
            }            

            if ( (ModifierKeys & Keys.Control) != Keys.Control)
                DeselectAllImagesExcept((ImageItem)pb.Parent);

           
            img.Selected = !img.Selected;
        }

        private void imgObject_Click(object sender, MouseEventArgs e)
        {
            ImageItem img = (ImageItem)sender;

            if(!File.Exists(img.Path)) //File doesnt exist anymore
            {                
                addedImages.Remove(img);
                img.Dispose();
                ReArrangeImages();
                return;
            }

            if (e.Button == MouseButtons.Right) //Right mouse button clicked. Show option menu / highlight but NOT de-highlight
            {
                if (!img.Selected)
                    img.Selected = true;

                imageContextMenuStrip.Show(Cursor.Position);

                return;
            }

            if ((ModifierKeys & Keys.Control) != Keys.Control)
                DeselectAllImagesExcept(img);

            img.Selected = !img.Selected;
        }     

        private void imgLabel_Click(object sender, MouseEventArgs e)
        {            
            Label lbl = (Label)sender;
            ImageItem img = (ImageItem)lbl.Parent.Parent;

            if (!File.Exists(img.Path)) //File doesnt exist anymore
            {                
                addedImages.Remove(img); 
                img.Dispose();
                ReArrangeImages();
                return;
            }

            if (e.Button == MouseButtons.Right) //Right mouse button clicked. Show option menu / highlight but NOT de-highlight
            {
                if (!img.Selected)
                    img.Selected = true;

                imageContextMenuStrip.Show(Cursor.Position);

                return;
            }

            if ((ModifierKeys & Keys.Control) != Keys.Control)
                DeselectAllImagesExcept((ImageItem)lbl.Parent.Parent);

            
            img.Selected = !img.Selected;
        }

        private void pnlImages_Click(object sender, EventArgs e)
        {
            DeselectAllImagesExcept(null);
        }

        private void UCImages_KeyUp(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Delete)
            {
                ImageItem itm = (ImageItem)sender;
                addedImages.Remove(itm);
                itm.Dispose();
            }*/
        }
        private List<ImageItem> GetSelectedImages()
        {
            return addedImages.Where(img => img.Selected).ToList();            
        }
        private void tmrImageTimeout_Tick(object sender, EventArgs e)
        {
            //After 10 miliseconds, allow it again and stop the timer
            allowClipboard = true;
            tmrImageTimeout.Stop();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ImageItem> selectedImages = GetSelectedImages();
            if (selectedImages.Count > 0)
            {
                //Ask the user for a new filename
                string newFileName = Prompt.Show("Enter a new file name:", selectedImages[0].Title);
                //User closed out or didnt enter anything
                if (string.IsNullOrWhiteSpace(newFileName))
                    return;

                int counter = 1;//Multiple images selected? Rename them to image~1.png, image~2.png, etc
                foreach (ImageItem itm in selectedImages)
                {
                    if (selectedImages.Count > 1)
                    {
                        File.Move(itm.Path, Path.GetDirectoryName(itm.Path) + "\\" + newFileName + "~" + counter + ".png");
                        itm.Title = newFileName + "~" + counter + ".png";
                    }
                    else
                    {
                        File.Move(itm.Path, Path.GetDirectoryName(itm.Path) + "\\" + newFileName + ".png");
                        itm.Title = newFileName + ".png";
                    }
                    counter++;
                }
            }            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Process paint = new Process();
            foreach (ImageItem img in GetSelectedImages())
            {                
                paint.StartInfo.FileName = @"C:\Windows\System32\mspaint.exe";
                paint.StartInfo.Arguments = string.Format("\"{0}\"", img.Path); 
                paint.Start();                
            }             
        }


        /// <summary>
        /// Starts watching a file for changes
        /// </summary>
        /// <param name="path">The path to the file</param>
        private void Watch(string path)
        {
            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(path);
            /* Watch for changes in LastAccess and LastWrite times, and 
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size;
            // Only watch png files.
            watcher.Filter = "*.png";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnImageChanged);            
            watcher.Deleted += new FileSystemEventHandler(OnImageDeleted);;
            watcher.Renamed += new RenamedEventHandler(OnImageRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        private void OnImageRenamed(object sender, RenamedEventArgs e)
        {
            try
            {
                ImageItem changedItem = addedImages.Where(i => i.Path == e.OldFullPath).SingleOrDefault();

                if (changedItem == null)
                    return;

                changedItem.Invoke((MethodInvoker)(() =>
                {
                    changedItem.Path = e.FullPath;
                    changedItem.Title = Path.GetFileName(e.FullPath);
                }));
            }
            catch (Exception) { }
           
        }

        private void OnImageChanged(object sender, FileSystemEventArgs e)
        {
            ImageItem changedItem = addedImages.Where(i => i.Path == e.FullPath).SingleOrDefault();

            try
            {
                if (changedItem == null)
                    return;

                changedItem.Invoke((MethodInvoker)(() =>
                {
                    changedItem.ReloadImage();
                }));
            }
            catch (Exception) { }                               
        }

        private void OnImageDeleted(object sender, FileSystemEventArgs e)
        {
            try
            {
                ImageItem changedItem = addedImages.Where(i => i.Path == e.FullPath).SingleOrDefault();              

                //This caused weird issues, and made deleting images really buggy, placing them on all kinds of places, scrolling the panel, it looked very weird.
                //This event would automatically delete the ImageItem from the panel if it was deleted externally( like from windows explorer ), instead now it just deletes it
                //when the user attempts to click it

                //addedImages.Remove(changedItem);
                //changedItem.Dispose();
                //ReArrangeImages();

            }
            catch (Exception) { }
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (GetSelectedImages().Count > 0)
            {                            
                foreach (ImageItem img in GetSelectedImages())
                {                    
                    if (File.Exists(img.Path)) //imageString + img = path to the image.png
                    {                        
                        File.Delete(img.Path);                        
                        addedImages.Remove(img);

                        if (img.pbPicture.BackgroundImage != null)
                            img.pbPicture.BackgroundImage.Dispose();

                        if(img.pbPicture.Image != null)
                            img.pbPicture.Image.Dispose();


                        img.Dispose();
                    }
                }
                ReArrangeImages();
                //remove from [] [] []
                //            []  X []
                // works with dispose, now re-arrange all the images
            }
             
        }

        private void openContainingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start( Path.GetDirectoryName(GetSelectedImages()[0].Path) );
        }

        /// <summary>
        /// Re-arrange the grid of images after an image has been deleted
        /// </summary>
        private void ReArrangeImages()
        {
            //Re-set all variables to 0, clear the panel and re-add them one by one. Easy solution, although shifting images after the delete position one back would be more efficient
            imagesInRow = 0;
            imageCount = 0;
            imageRows = 0;

            /*pnlImages.Invoke((MethodInvoker)(() =>
            {
               
            }));*/
            pnlImages.Controls.Clear();
            foreach (ImageItem img in addedImages)
            {
                img.Location = CalculateNewImagePosition();
                pnlImages.Controls.Add(img);
            }            
        }

        private void UCImages_Load(object sender, EventArgs e)
        {            
            //Fix the issue where the scroll position is not 0, so pictures will be placed on a wrong location when the user scrolled inside the panel
            pnlImages.AutoScrollPosition = new Point(pnlImages.AutoScrollPosition.X, 0);                    
        }

    
    }
}
