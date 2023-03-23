using System.Data;

namespace KB11174_UltraGridWithGroupBy_WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ultraGrid1.DataSource = GetData();
    }

    private DataTable GetData()
    {
        DataTable dt = new DataTable();

        // 列
        DataColumn idColumn = dt.Columns.Add("ID", typeof(int));
        dt.Columns.Add("Name", typeof(String));
        dt.Columns.Add("Prefecture", typeof(String));

        // 行
        dt.Rows.Add(new object[] { 0, "毛利 美代子", "愛知県" });
        dt.Rows.Add(new object[] { 1, "白石 和子", "東京都" });
        dt.Rows.Add(new object[] { 2, "岸本 朋之", "大阪府" });
        dt.Rows.Add(new object[] { 3, "稲垣 恵利", "愛知県" });
        dt.Rows.Add(new object[] { 4, "谷口 新太郎", "東京都" });
        dt.Rows.Add(new object[] { 5, "豊田 光", "東京都" });
        dt.Rows.Add(new object[] { 6, "池上 光", "大阪府" });
        dt.Rows.Add(new object[] { 7, "三木 豊子", "大阪府" });
        dt.Rows.Add(new object[] { 8, "塚本 蒼", "東京都" });
        dt.Rows.Add(new object[] { 9, "白石 豊子", "東京都" });
        dt.Rows.Add(new object[] { 10, "桜田 奏音", "愛知県" });
        dt.Rows.Add(new object[] { 11, "梅原 紗奈", "大阪府" });
        dt.Rows.Add(new object[] { 12, "安東 重彦", "東京都" });
        dt.Rows.Add(new object[] { 13, "豊田 柚咲", "東京都" });
        dt.Rows.Add(new object[] { 14, "玉木 竜也", "愛知県" });
        dt.Rows.Add(new object[] { 15, "小野寺 萌香", "神奈川県" });
        dt.Rows.Add(new object[] { 16, "塩田 泰三", "大阪府" });
        dt.Rows.Add(new object[] { 17, "赤塚 宏寿", "大阪府" });
        dt.Rows.Add(new object[] { 18, "玉木 豊子", "大阪府" });
        dt.Rows.Add(new object[] { 19, "土居 花奈子", "東京都" });

        // プライマリーキー
        dt.PrimaryKey = new DataColumn[] { idColumn };

        return dt;
    }

    private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
    {
        // 表示スタイルをOutlookGroupByにする。
        e.Layout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
        // グループ化する列でソートする（※第3引数がグループ化で使用するかどうかのオプション）。
        e.Layout.Bands[0].SortedColumns.Add("Prefecture", false, true);
    }
}
