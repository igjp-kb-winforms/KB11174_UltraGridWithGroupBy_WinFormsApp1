namespace KB11174_UltraGridWithGroupBy_WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
        Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
        ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
        ((System.ComponentModel.ISupportInitialize)ultraGrid1).BeginInit();
        SuspendLayout();
        // 
        // ultraGrid1
        // 
        appearance14.BackColor = SystemColors.Window;
        appearance14.BorderColor = SystemColors.InactiveCaption;
        ultraGrid1.DisplayLayout.Appearance = appearance14;
        ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
        ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
        appearance13.BackColor = SystemColors.ActiveBorder;
        appearance13.BackColor2 = SystemColors.ControlDark;
        appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
        appearance13.BorderColor = SystemColors.Window;
        ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance13;
        appearance12.ForeColor = SystemColors.GrayText;
        ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance12;
        ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
        appearance11.BackColor = SystemColors.ControlLightLight;
        appearance11.BackColor2 = SystemColors.Control;
        appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
        appearance11.ForeColor = SystemColors.GrayText;
        ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance11;
        ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
        ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
        appearance17.BackColor = SystemColors.Window;
        appearance17.ForeColor = SystemColors.ControlText;
        ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance17;
        appearance19.BackColor = SystemColors.Highlight;
        appearance19.ForeColor = SystemColors.HighlightText;
        ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance19;
        ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
        ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
        appearance110.BackColor = SystemColors.Window;
        ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance110;
        appearance18.BorderColor = Color.Silver;
        appearance18.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
        ultraGrid1.DisplayLayout.Override.CellAppearance = appearance18;
        ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
        ultraGrid1.DisplayLayout.Override.CellPadding = 0;
        appearance112.BackColor = SystemColors.Control;
        appearance112.BackColor2 = SystemColors.ControlDark;
        appearance112.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
        appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
        appearance112.BorderColor = SystemColors.Window;
        ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance112;
        appearance111.TextHAlignAsString = "Left";
        ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance111;
        ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
        ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
        appearance15.BackColor = SystemColors.Window;
        appearance15.BorderColor = Color.Silver;
        ultraGrid1.DisplayLayout.Override.RowAppearance = appearance15;
        ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
        appearance16.BackColor = SystemColors.ControlLight;
        ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance16;
        ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
        ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
        ultraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
        ultraGrid1.Dock = DockStyle.Fill;
        ultraGrid1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        ultraGrid1.Location = new Point(0, 0);
        ultraGrid1.Name = "ultraGrid1";
        ultraGrid1.Size = new Size(800, 450);
        ultraGrid1.TabIndex = 0;
        ultraGrid1.Text = "ultraGrid1";
        ultraGrid1.InitializeLayout += ultraGrid1_InitializeLayout;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ultraGrid1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)ultraGrid1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
}
