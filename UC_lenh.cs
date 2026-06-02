using System;
using System.Windows.Forms;
using System.Drawing;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace ADDMS2
{
    public partial class UC_lenh : UserControl
    {
        // Khai báo map
        private GMapControl gmap;

        public UC_lenh()
        {
            InitializeComponent();
            this.Load += UC_lenh_Load;
        }

        // Event Load của UserControl
        private void UC_lenh_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Hàm load map
        private void LoadMap()
        {
            // Tạo map
            gmap = new GMapControl();

            // Full panel
            gmap.Dock = DockStyle.Fill;

            // Map provider
            // Dùng OpenStreetMap ổn định hơn GoogleMap
            gmap.MapProvider = GMapProviders.OpenStreetMap;

            // Online mode
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            // Vị trí mặc định
            gmap.Position = new PointLatLng(10.8231, 106.6297);

            // Zoom
            gmap.MinZoom = 2;
            gmap.MaxZoom = 20;
            gmap.Zoom = 13;

            // UI map
            gmap.ShowCenter = false;
            gmap.CanDragMap = true;
            gmap.DragButton = MouseButtons.Left;

            // Overlay marker
            GMapOverlay markers = new GMapOverlay("markers");

            // Marker UAV
            GMarkerGoogle marker = new GMarkerGoogle(
                new PointLatLng(10.8231, 106.6297),
                GMarkerGoogleType.red_dot
            );

            // Add marker
            markers.Markers.Add(marker);

            // Add overlay
            gmap.Overlays.Add(markers);

            // Add map vào panel
            panelMap.Controls.Add(gmap);

            // Bring front
            gmap.BringToFront();
        }
    }
}