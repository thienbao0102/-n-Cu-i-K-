using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DoAnCuoiKyLTHDT
{
    public partial class GiaoDienSV : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public GiaoDienSV()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Indigo400, MaterialSkin.TextShade.WHITE);
        }

        private void GiaoDienSV_Load(object sender, EventArgs e)
        {
            GiaoDienSV giaoDienSV = sender as GiaoDienSV;
            if (!string.IsNullOrEmpty(giaoDienSV.Text))
            {
                string name = txtinfoName.Text.Split(' ').LastOrDefault();
                giaoDienSV.Text += "" + name +"!";
            }
            
        }
    }
}
