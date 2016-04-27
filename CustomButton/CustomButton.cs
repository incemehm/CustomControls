using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomButton
{
    public partial class CustomButton : Button
    {
        private Color priColor1 = Color.Red;
        private Color priColor2 = Color.Yellow;
        
        public Color Color1
        {
            get { return priColor1; }
            set { priColor1 = value; Invalidate(); }
        }

        public Color Color2
        {
            get { return priColor2; }
            set { priColor2 = value; Invalidate(); }
        }
        
        public string xText
        {
            get { return Text; }
            set { Text = value; Invalidate(); }
        }

        public CustomButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, Color.FromArgb(100, priColor1), Color.FromArgb(100, priColor2), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
            pe.Graphics.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }
    }
}
