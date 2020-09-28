using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TileGameLib.Components;
using TileGameLib.Graphics;

namespace TilePaint
{
    public partial class MainWindow : Form
    {
        private TiledDisplay PaletteDisplay;
        private TiledDisplay TileDisplay;
        private int LeftColor;
        private int RightColor;
        private const int TileWidth = 16;
        private const int TileHeight = 16;

        public MainWindow()
        {
            InitializeComponent();
            StatusLabel.Text = "";
            LeftColor = 0;
            RightColor = 1;

            PaletteDisplay = new TiledDisplay(PalettePanel, 8, 16, 3);
            PaletteDisplay.BorderStyle = BorderStyle.Fixed3D;
            PaletteDisplay.StretchImage = true;
            PaletteDisplay.ShowGrid = false;
            PaletteDisplay.MouseDown += PaletteDisplay_MouseDown;

            TileGraphicsDriver g;

            g = PaletteDisplay.Graphics;
            g.Clear(1);
            int color = 0;

            for (int y = 0; y < g.Rows; y++)
            {
                for (int x = 0; x < g.Cols; x++)
                {
                    g.PutTile(x, y, 0, color, color);
                    color++;
                    if (color >= g.Palette.Size)
                        break;
                }
            }

            TileDisplay = new TiledDisplay(TilePanel, TileWidth, TileHeight, 3);
            TileDisplay.BorderStyle = BorderStyle.Fixed3D;
            TileDisplay.StretchImage = true;
            TileDisplay.ShowGrid = true;
            TileDisplay.Click += TileDisplay_Click;
            TileDisplay.MouseDown += TileDisplay_MouseDown;
            TileDisplay.MouseMove += TileDisplay_MouseMove;
            TileDisplay.MouseLeave += TileDisplay_MouseLeave;

            Clear(1);
            UpdateColorButtons();
        }

        private void PaletteDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            Point cell = PaletteDisplay.GetMouseToCellPos(e.Location);

            if (cell.X >= 0 && cell.Y >= 0 && cell.X < PaletteDisplay.Cols && cell.Y < PaletteDisplay.Rows)
            {
                Tile tile = PaletteDisplay.Graphics.GetTile(cell.X, cell.Y);

                if (e.Button == MouseButtons.Left)
                    LeftColor = tile.ForeColor;
                if (e.Button == MouseButtons.Right)
                    RightColor = tile.ForeColor;

                UpdateColorButtons();
            }
        }

        private void TileDisplay_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = "";
        }

        private void TileDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            HandleTileDisplayMouseEvent(e);
        }

        private void TileDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            HandleTileDisplayMouseEvent(e);
        }

        private void TileDisplay_Click(object sender, EventArgs e)
        {
            HandleTileDisplayMouseEvent(e);
        }

        private void HandleTileDisplayMouseEvent(EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point cell = TileDisplay.GetMouseToCellPos(me.Location);

            if (cell.X >= 0 && cell.Y >= 0 && cell.X < TileDisplay.Cols && cell.Y < TileDisplay.Rows)
            {
                StatusLabel.Text = $"Pixel {cell.X},{cell.Y}";

                if (ModifierKeys.HasFlag(Keys.Control))
                {
                    if (me.Button == MouseButtons.Left)
                        LeftColor = GetPixel(cell.X, cell.Y);
                    else if (me.Button == MouseButtons.Right)
                        RightColor = GetPixel(cell.X, cell.Y);

                    UpdateColorButtons();
                }
                else
                {
                    if (me.Button == MouseButtons.Left)
                        SetPixel(cell.X, cell.Y, LeftColor);
                    else if (me.Button == MouseButtons.Right)
                        SetPixel(cell.X, cell.Y, RightColor);
                }
            }
            else
            {
                StatusLabel.Text = "";
            }
        }

        private void UpdateColorButtons()
        {
            Palette pal = PaletteDisplay.Graphics.Palette;
            LeftBtnPanel.BackColor = pal.GetColorObject(LeftColor);
            RightBtnPanel.BackColor = pal.GetColorObject(RightColor);

            const int threshold = 50;

            if (LeftBtnPanel.BackColor.R < threshold && LeftBtnPanel.BackColor.G < threshold && LeftBtnPanel.BackColor.B < threshold)
                LeftBtnPanel.ForeColor = Color.White;
            else
                LeftBtnPanel.ForeColor = Color.Black;
        
            if (RightBtnPanel.BackColor.R < threshold && RightBtnPanel.BackColor.G < threshold && RightBtnPanel.BackColor.B < threshold)
                RightBtnPanel.ForeColor = Color.White;
            else
                RightBtnPanel.ForeColor = Color.Black;
        }

        private void SetPixel(int x, int y, int color)
        {
            TileDisplay.Graphics.PutTile(x, y, 0, color, color);
            TileDisplay.Refresh();
        }

        private int GetPixel(int x, int y)
        {
            return TileDisplay.Graphics.GetTile(x, y).BackColor;
        }

        private void BtnFillR_Click(object sender, EventArgs e)
        {
            Clear(RightColor);
        }

        private void BtnFillL_Click(object sender, EventArgs e)
        {
            Clear(LeftColor);
        }

        private void BtnFillWhite_Click(object sender, EventArgs e)
        {
            Clear(1);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string file = GetOutputFilePath();
            if (file != null)
                SaveTileImage(file);
        }

        private void Clear(int color)
        {
            TileDisplay.Graphics.Fill(0, color, color);
            TileDisplay.Refresh();
        }

        private string GetOutputFilePath()
        {
            string path = TxtPath.Text.Trim();

            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Enter directory path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            DirectoryInfo dirInfo;

            try
            {
                dirInfo = new DirectoryInfo(path);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (!dirInfo.Exists)
            {
                MessageBox.Show("Directory does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            string filename = TxtFilename.Text.Trim();

            if (string.IsNullOrWhiteSpace(filename))
            {
                MessageBox.Show("Enter filename", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            FileInfo fileInfo;

            try
            {
                fileInfo = new FileInfo(filename);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid filename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return Path.Combine(path, fileInfo.Name);
        }

        private void SaveTileImage(string file)
        {
            try
            {
                if (!file.EndsWith(".png"))
                    file += ".png";

                Bitmap image = ResizeImage(TileDisplay.Graphics.Bitmap, (float)TxtWidth.Value, (float)TxtHeight.Value);
                image.Save(file);
                UpdateFileList();

                MessageBox.Show("File saved to " + file, "Saved OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error saving tile image:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Bitmap ResizeImage(Bitmap original, float width, float height)
        {
            float scale = Math.Min(width / original.Width, height / original.Height);
            Bitmap resized = new Bitmap((int)width, (int)height);
            Graphics g = Graphics.FromImage(resized);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.CompositingQuality = CompositingQuality.HighSpeed;
            g.SmoothingMode = SmoothingMode.None;

            int scaleWidth = (int)(original.Width * scale);
            int scaleHeight = (int)(original.Height * scale);

            g.DrawImage(original, ((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight);

            return resized;
        }

        private void BtnOpenFolder_Click(object sender, EventArgs e)
        {
            string path = GetOutputFilePath();
            if (path != null)
                Process.Start(TxtPath.Text);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            string file = GetOutputFilePath();
            if (file != null)
                LoadTileImage(file);
        }

        private void LoadTileImage(string file)
        {
            try
            {
                if (!file.EndsWith(".png"))
                    file += ".png";

                Bitmap image = ResizeImage((Bitmap)Image.FromFile(file), TileWidth, TileHeight);

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color color = image.GetPixel(x, y);
                        int colorIndex = FindPaletteColor(color);
                        if (colorIndex >= 0)
                            TileDisplay.Graphics.PutTile(x, y, 0, colorIndex, colorIndex);
                    }
                }

                image.Dispose();
                TileDisplay.Refresh();
                TxtPath.Text = new FileInfo(file).DirectoryName;
                TxtFilename.Text = Path.GetFileNameWithoutExtension(new FileInfo(file).Name);
                UpdateFileList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading tile image:\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int FindPaletteColor(Color color)
        {
            Palette pal = PaletteDisplay.Graphics.Palette;

            for (int index = 0; index < pal.Size; index++)
            {
                Color currentColor = pal.GetColorObject(index);
                if (currentColor.Equals(color))
                    return index;
            }

            return -1;
        }

        private void UpdateFileList()
        {
            string path = GetOutputFilePath();
            if (path == null)
                return;

            LstFiles.Items.Clear();
            path = TxtPath.Text.Trim();
            DirectoryInfo info = new DirectoryInfo(path);
            var files = info.EnumerateFiles("*.png");

            foreach (FileInfo file in files)
            {
                LstFiles.Items.Add(file);
            }
        }

        private void LstFiles_DoubleClick(object sender, EventArgs e)
        {
            object item = LstFiles.SelectedItem;
            if (item == null)
                return;

            FileInfo file = (FileInfo)item;
            LoadTileImage(file.FullName);
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            int temp = RightColor;
            RightColor = LeftColor;
            LeftColor = temp;

            UpdateColorButtons();
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will replace in the tile image all pixels of the L color with the R color. Are you sure?", 
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                for (int y = 0; y < TileDisplay.Graphics.Rows; y++)
                {
                    for (int x = 0; x < TileDisplay.Graphics.Cols; x++)
                    {
                        int currentColor = TileDisplay.Graphics.GetTile(x, y).BackColor;
                        int newColor = currentColor == LeftColor ? RightColor : currentColor;
                        TileDisplay.Graphics.PutTile(x, y, 0, newColor, newColor);
                    }
                }

                TileDisplay.Refresh();
            }
        }
    }
}
