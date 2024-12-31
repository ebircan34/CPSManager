
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;

public class CustomGridControl : GridControl
{
    [ToolboxItem(true)]
    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        // Özelleştirmeleri burada yapabiliriz
        CustomizeAppearance();
    }

    private void CustomizeAppearance()
    {
        // Görünüm özelleştirmelerini burada tanımlayabiliriz
        GridView view = this.MainView as GridView;
        if (view != null)
        {
            view.Appearance.Row.BackColor = System.Drawing.Color.AliceBlue;
            view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.SteelBlue;
            view.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            view.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            // Diğer özelleştirmeler burada
        }
    }
}