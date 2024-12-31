using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;

namespace CPManagementApp.UserControls.Controls
{
    public class MyTextEditOnlyNumaric : TextEdit
    {
        [ToolboxItem(true)]
        public MyTextEditOnlyNumaric()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
            // Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //Properties.Mask.EditMask = "n2";
            // Properties.Mask.UseMaskAsDisplayFormat = true;

        }
        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
