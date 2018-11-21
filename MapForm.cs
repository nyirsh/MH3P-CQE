using System;
using System.Drawing;
using System.Windows.Forms;
using CQE.Classes;

namespace CQE
{
    public sealed partial class MapForm : Form
    {
        public string MapName;
        

        public MapForm(int X, int Y, string mapString)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = (Point) new Size(X, Y);
            MapName = mapString;
            Text = Language.Dictionary["menu"]["map"] + ": " + mapString;
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            switch (MapName)
            {
                case "Isola":
                    MapPictureBox.Image = MapResources.Map_DesertedIsland;
                    return;

                case "Pianure":
                    MapPictureBox.Image = MapResources.Map_SandyPlains;
                    return;

                case "Foresta":
                    MapPictureBox.Image = MapResources.Map_FloodedForest;
                    return;

                case "Tundra":
                    MapPictureBox.Image = MapResources.Map_Tundra;
                    return;

                case "Vulcano":
                    MapPictureBox.Image = MapResources.Map_Volcano;
                    return;

                case "Cascate":
                    MapPictureBox.Image = MapResources.Map_MountainStream;
                    return;

                case "Grande Deserto":
                    MapPictureBox.Image = MapResources.Map_GreatDesert;
                    return;

                case "Canyon di Lava":
                    MapPictureBox.Image = MapResources.Map_LavaCanyon;
                    return;

                case "Arena":
                    MapPictureBox.Image = MapResources.Map_LandArena;
                    return;

                case "Arena Piccola":
                    MapPictureBox.Image = MapResources.Map_SmallLandArena;
                    return;

                case "Terra Sacra":
                    MapPictureBox.Image = MapResources.Map_SacredLand;
                    return;

                case "Zona Polare":
                    MapPictureBox.Image = MapResources.Map_PolarZone;
                    return;

                case "Cima Montagna":
                    MapPictureBox.Image = MapResources.Map_MountainSummit;
                    return;

                default:
                    return;
            }
        }
    }
}
