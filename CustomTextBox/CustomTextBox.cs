using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomTextBox
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:CustomTextBox runat=server></{0}:CustomTextBox>")]
    public class CustomTextBox : TextBox
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string xText
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null)? "[" + this.ID + "]" : s);
            }
 
            set
            {
                ViewState["Text"] = value;
            }
        }

        private RequiredFieldValidator rfv;
        public string NotValid;
        public string EnableClientScript = "true";

        protected override void OnInit(EventArgs e)
        {
            rfv = new RequiredFieldValidator();
            rfv.ControlToValidate = this.ID;
            rfv.ErrorMessage = this.NotValid;
            rfv.EnableClientScript = (this.EnableClientScript.ToLower() != "false");
            Controls.Add(rfv);
        }
 
        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write(xText);
            base.RenderContents(output);
            rfv.RenderControl(output);
        }
    }
}
