using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QRCoder;
using System.Drawing.Imaging;
using System.IO;

namespace QRCoderDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //   comboBoxECC.SelectedIndex = 0; //Pre-select ECC level "L"
            //    RenderQrCode();

            LoadComo();

        }


        #region Patholab
        private void patholab_CreateImage_Click(object sender, EventArgs e)
        {
            Render_patholab_QrCode();
        }

        private Bitmap btp;
        private void Render_patholab_QrCode()
        {
            string level = "Q";// = "H";// comboBoxECC.SelectedItem.ToString();
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(patho_barcode_text.Text, eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {


                        btp = qrCode.GetGraphic(300,1, Color.Black, Color.White,
                        null, 0);

                    //    btp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                      //       btp.RotateFlip(RotateFlipType.Rotate180FlipNone);//RotateFlipType.Rotate180FlipNone);
                      

                      patholab_WriteTextToImage(patho_above_text.Text);

                    }
                }
            }



            var d = DateTime.Now.ToString("yyMMddhhmmss");
            string path = "C:\\QRCode\\" + d + ".bmp";
            patholab_picture.Image.Save(path, ImageFormat.Bmp);
        }







        public Bitmap ResizeImage(Bitmap image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        public void patholab_WriteTextToImage(string text2Write)
        {
          //  var ca = text2Write.ToCharArray();
          //  Array.Reverse(ca);
          //text2Write = new string(ca);
            PointF textPoint = new PointF(0, 0);
            SizeF textSize = new SizeF(200, 30);
            RectangleF rectf = new RectangleF(textPoint, textSize);
            Graphics g = Graphics.FromImage(btp);

        //    g.SmoothingMode = SmoothingMode.AntiAlias;
          //  g.InterpolationMode = InterpolationMode.HighQualityBicubic;
         //   g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawString(text2Write, new Font("Tahoma", 14), Brushes.Black, rectf);
            btp.RotateFlip(RotateFlipType.Rotate180FlipNone);//RotateFlipType.Rotate180FlipNone);

            g.Flush();
      //  btp.RotateFlip(RotateFlipType.Rotate180FlipNone);//RotateFlipType.Rotate180FlipNone);
            patholab_picture.Image = btp;
        }


        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += patholab_PrintPage;
            //    pd.PrinterSettings.paperbin
            pd.Print();
        }

        private void patholab_PrintPage(object o, PrintPageEventArgs e)
        {

            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(btp, loc);
        }




        PrintDocument printDoc;
        private void button1_Click(object sender, EventArgs e)
        {

            // Set the paper size based upon the selection in the combo box.

            if (comboPaperSize.SelectedIndex != -1)
            {
                printDoc.DefaultPageSettings.PaperSize =
                    printDoc.PrinterSettings.PaperSizes[comboPaperSize.SelectedIndex];
            }

            // Set the paper source based upon the selection in the combo box.
            if (comboPaperSource.SelectedIndex != -1)
            {
                printDoc.DefaultPageSettings.PaperSource =
                    printDoc.PrinterSettings.PaperSources[comboPaperSource.SelectedIndex];
            }

            // Set the printer resolution based upon the selection in the combo box.
            if (comboPrintResolution.SelectedIndex != -1)
            {
                printDoc.DefaultPageSettings.PrinterResolution =
                    printDoc.PrinterSettings.PrinterResolutions[comboPrintResolution.SelectedIndex];
            }

            // Print the document with the specified paper size, source, and print resolution.
            printDoc.Print();
        }
        private void  LoadComo()
        {
            
            try
            {
                printDoc=new PrintDocument();
                // Add list of supported paper sizes found on the printer. 
                // The DisplayMember property is used to identify the property that will provide the display string.
                comboPaperSize.DisplayMember = "PaperName";

                PaperSize pkSize;
                for (int i = 0; i < printDoc.PrinterSettings.PaperSizes.Count; i++)
                {
                    pkSize = printDoc.PrinterSettings.PaperSizes[i];
                    comboPaperSize.Items.Add(pkSize);
                }

                // Create a PaperSize and specify the custom paper size through the constructor and add to combobox.
                PaperSize pkCustomSize1 = new PaperSize("First custom size", 100, 200);

                comboPaperSize.Items.Add(pkCustomSize1);


                // Add list of paper sources found on the printer to the combo box.
                // The DisplayMember property is used to identify the property that will provide the display string.
                comboPaperSource.DisplayMember = "SourceName";

                PaperSource pkSource;
                for (int i = 0; i < printDoc.PrinterSettings.PaperSources.Count; i++)
                {
                    pkSource = printDoc.PrinterSettings.PaperSources[i];
                    comboPaperSource.Items.Add(pkSource);
                  
                }

                // Add list of printer resolutions found on the printer to the combobox.
                // The PrinterResolution's ToString() method will be used to provide the display string.

                PrinterResolution pkResolution;
                for (int i = 0; i < printDoc.PrinterSettings.PrinterResolutions.Count; i++)
                {
                    pkResolution = printDoc.PrinterSettings.PrinterResolutions[i];
                    comboPrintResolution.Items.Add(pkResolution);
                }
            }
            catch (Exception e)
            {


            }
        }

        private void comboPaperSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
