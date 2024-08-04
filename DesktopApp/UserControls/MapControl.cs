using DesktopApp.Model;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.UserControls
{
    public partial class MapControl : UserControl
    {
        SharedDataModel sharedDataModel;
        public MapControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();
        }
        public void InitCalculate()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InitializeMap();
            }
            catch(Exception ex){
                MessageBox.Show("Nahi chala :", ex.Message);
            }
        }

        private void InitializeMap()
        {
            GMapControl gMapControl = new GMapControl
            {
                Dock = DockStyle.Fill,
                MapProvider = GMapProviders.GoogleMap,
                Position = new PointLatLng(34.0522, -118.2437),
                MinZoom = 2,
                MaxZoom = 18,
                Zoom = 10,
                CacheLocation = @"C:\GMapCache" // Set your cache location
                //Manag = AccessMode.CacheOnly // Offline mode
            };
            this.Controls.Add(gMapControl);

            // Preload map tiles for offline use
            PreloadMapTiles(gMapControl);
        }

        private void PreloadMapTiles(GMapControl gMapControl)
        {
            // Define the area to preload
            RectLatLng area = new RectLatLng(34.0522, -118.2437, 0.1, 0.1);

            // Specify zoom levels to preload
            //for (int zoom = 2; zoom <= 18; zoom++)
            //{
            //    for (double lat = area.Top; lat >= area.Bottom; lat -= 0.01)
            //    {
            //        for (double lng = area.Left; lng <= area.Right; lng += 0.01)
            //        {
            //            gMapControl.Manager.GetTileIma(
            //                GMapProviders.GoogleMap,
            //                new GPoint(lng, lat),
            //                zoom,
            //                CacheUsage.First);
            //        }
            //    }
            }
        }
}
