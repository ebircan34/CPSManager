using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;

namespace CPManagementApp.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCalcEdit : CalcEdit
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "n2";

        }
        public override bool EnterMoveNextControl { get; set; } = true;




    }
}
