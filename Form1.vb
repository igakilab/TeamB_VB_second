Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows フォーム デザイナで生成されたコード "

    Public Sub New()
        MyBase.New()

        ' この呼び出しは Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後に初期化を追加します。

    End Sub

    ' Form は dispose をオーバーライドしてコンポーネント一覧を消去します。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    ' メモ : 以下のプロシージャは、Windows フォーム デザイナで必要です。
    ' Windows フォーム デザイナを使って変更してください。  
    ' コード エディタは使用しないでください。
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents odaMain As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents MainSelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents MainInsertCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents MainUpdateCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents MainDelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ocnSample As System.Data.OleDb.OleDbConnection
    Friend WithEvents odaSub As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SubSelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents SubInsertCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents SubDelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents SubUpdateCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents odaShohin As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents ShohinSelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShohinInsertCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShohinUpdateCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShohinDelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents odaShain As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents ShainSelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShainInsertCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShainUpdateCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShainDelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsSample1 As SampleAppli.dsSample
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileInput As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileStep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileStep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrepare As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrepareShohin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrepareKokyaku As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrepareShain As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTool As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolExportCsv As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolExportXml As System.Windows.Forms.MenuItem
    Friend WithEvents odaKokyaku As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents KokyakuSelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents KokyakuInsertCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents KokyakuUpdateCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents KokyakuDelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileInput = New System.Windows.Forms.MenuItem()
        Me.mnuFileStep1 = New System.Windows.Forms.MenuItem()
        Me.mnuFileFind = New System.Windows.Forms.MenuItem()
        Me.mnuFileStep2 = New System.Windows.Forms.MenuItem()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuPrepare = New System.Windows.Forms.MenuItem()
        Me.mnuPrepareShohin = New System.Windows.Forms.MenuItem()
        Me.mnuPrepareKokyaku = New System.Windows.Forms.MenuItem()
        Me.mnuPrepareShain = New System.Windows.Forms.MenuItem()
        Me.mnuTool = New System.Windows.Forms.MenuItem()
        Me.mnuToolExport = New System.Windows.Forms.MenuItem()
        Me.mnuToolExportCsv = New System.Windows.Forms.MenuItem()
        Me.mnuToolExportXml = New System.Windows.Forms.MenuItem()
        Me.odaMain = New System.Data.OleDb.OleDbDataAdapter()
        Me.MainDelCmd = New System.Data.OleDb.OleDbCommand()
        Me.ocnSample = New System.Data.OleDb.OleDbConnection()
        Me.MainInsertCmd = New System.Data.OleDb.OleDbCommand()
        Me.MainSelCmd = New System.Data.OleDb.OleDbCommand()
        Me.MainUpdateCmd = New System.Data.OleDb.OleDbCommand()
        Me.odaSub = New System.Data.OleDb.OleDbDataAdapter()
        Me.SubDelCmd = New System.Data.OleDb.OleDbCommand()
        Me.SubInsertCmd = New System.Data.OleDb.OleDbCommand()
        Me.SubSelCmd = New System.Data.OleDb.OleDbCommand()
        Me.SubUpdateCmd = New System.Data.OleDb.OleDbCommand()
        Me.odaShohin = New System.Data.OleDb.OleDbDataAdapter()
        Me.ShohinDelCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShohinInsertCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShohinSelCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShohinUpdateCmd = New System.Data.OleDb.OleDbCommand()
        Me.odaShain = New System.Data.OleDb.OleDbDataAdapter()
        Me.ShainDelCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShainInsertCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShainSelCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShainUpdateCmd = New System.Data.OleDb.OleDbCommand()
        Me.DsSample1 = New SampleAppli.dsSample()
        Me.odaKokyaku = New System.Data.OleDb.OleDbDataAdapter()
        Me.KokyakuDelCmd = New System.Data.OleDb.OleDbCommand()
        Me.KokyakuInsertCmd = New System.Data.OleDb.OleDbCommand()
        Me.KokyakuSelCmd = New System.Data.OleDb.OleDbCommand()
        Me.KokyakuUpdateCmd = New System.Data.OleDb.OleDbCommand()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuPrepare, Me.mnuTool})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileInput, Me.mnuFileStep1, Me.mnuFileFind, Me.mnuFileStep2, Me.mnuFileExit})
        Me.mnuFile.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuFile.Text = "ファイル（&F）"
        '
        'mnuFileInput
        '
        Me.mnuFileInput.Index = 0
        Me.mnuFileInput.Text = "伝票入力（&I）"
        '
        'mnuFileStep1
        '
        Me.mnuFileStep1.Index = 1
        Me.mnuFileStep1.Text = "-"
        '
        'mnuFileFind
        '
        Me.mnuFileFind.Index = 2
        Me.mnuFileFind.Text = "顧客検索（&F）"
        '
        'mnuFileStep2
        '
        Me.mnuFileStep2.Index = 3
        Me.mnuFileStep2.Text = "-"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 4
        Me.mnuFileExit.Text = "終了（&X）"
        '
        'mnuPrepare
        '
        Me.mnuPrepare.Index = 1
        Me.mnuPrepare.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPrepareShohin, Me.mnuPrepareKokyaku, Me.mnuPrepareShain})
        Me.mnuPrepare.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuPrepare.Text = "準備（&P）"
        '
        'mnuPrepareShohin
        '
        Me.mnuPrepareShohin.Index = 0
        Me.mnuPrepareShohin.Text = "商品登録（&G）"
        '
        'mnuPrepareKokyaku
        '
        Me.mnuPrepareKokyaku.Index = 1
        Me.mnuPrepareKokyaku.Text = "顧客登録（&C）"
        '
        'mnuPrepareShain
        '
        Me.mnuPrepareShain.Index = 2
        Me.mnuPrepareShain.Text = "社員登録（&E）"
        '
        'mnuTool
        '
        Me.mnuTool.Index = 2
        Me.mnuTool.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuToolExport})
        Me.mnuTool.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuTool.Text = "ツール（&T）"
        '
        'mnuToolExport
        '
        Me.mnuToolExport.Index = 0
        Me.mnuToolExport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuToolExportCsv, Me.mnuToolExportXml})
        Me.mnuToolExport.Text = "エクスポート（&E）"
        '
        'mnuToolExportCsv
        '
        Me.mnuToolExportCsv.Index = 0
        Me.mnuToolExportCsv.Text = "CSV形式（&C）..."
        '
        'mnuToolExportXml
        '
        Me.mnuToolExportXml.Index = 1
        Me.mnuToolExportXml.Text = "XML形式（X）..."
        '
        'odaMain
        '
        Me.odaMain.DeleteCommand = Me.MainDelCmd
        Me.odaMain.InsertCommand = Me.MainInsertCmd
        Me.odaMain.SelectCommand = Me.MainSelCmd
        Me.odaMain.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_メイン", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("注文NO", "注文NO"), New System.Data.Common.DataColumnMapping("日付", "日付"), New System.Data.Common.DataColumnMapping("顧客ID", "顧客ID"), New System.Data.Common.DataColumnMapping("社員ID", "社員ID")})})
        Me.odaMain.UpdateCommand = Me.MainUpdateCmd
        '
        'MainDelCmd
        '
        Me.MainDelCmd.CommandText = "DELETE FROM [T_メイン] WHERE (注文NO = ?) AND (日付 = ? OR ? IS NULL AND 日付 IS NULL)"
        Me.MainDelCmd.Connection = Me.ocnSample
        Me.MainDelCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_注文NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "注文NO", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_日付", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "日付", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_日付1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "日付", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ocnSample
        '
        Me.ocnSample.ConnectionString = resources.GetString("ocnSample.ConnectionString")
        '
        'MainInsertCmd
        '
        Me.MainInsertCmd.CommandText = "INSERT INTO [T_メイン] (注文NO, 日付, 顧客ID, 社員ID) VALUES (?, ?, ?, ?)"
        Me.MainInsertCmd.Connection = Me.ocnSample
        Me.MainInsertCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("注文NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "注文NO", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("日付", System.Data.OleDb.OleDbType.DBDate, 0, "日付"), New System.Data.OleDb.OleDbParameter("顧客ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "顧客ID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("社員ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "社員ID", System.Data.DataRowVersion.Current, Nothing)})
        '
        'MainSelCmd
        '
        Me.MainSelCmd.CommandText = "SELECT 注文NO, 日付, 顧客ID, 社員ID FROM [T_メイン]"
        Me.MainSelCmd.Connection = Me.ocnSample
        '
        'MainUpdateCmd
        '
        Me.MainUpdateCmd.CommandText = "UPDATE [T_メイン] SET 注文NO = ?, 日付 = ?, 顧客ID = ?, 社員ID = ? WHERE (注文NO = ?) AND (日付 " &
    "= ? OR ? IS NULL AND 日付 IS NULL)"
        Me.MainUpdateCmd.Connection = Me.ocnSample
        Me.MainUpdateCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("注文NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "注文NO", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("日付", System.Data.OleDb.OleDbType.DBDate, 0, "日付"), New System.Data.OleDb.OleDbParameter("顧客ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "顧客ID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("社員ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "社員ID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Original_注文NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "注文NO", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_日付", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "日付", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_日付1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "日付", System.Data.DataRowVersion.Original, Nothing)})
        '
        'odaSub
        '
        Me.odaSub.DeleteCommand = Me.SubDelCmd
        Me.odaSub.InsertCommand = Me.SubInsertCmd
        Me.odaSub.SelectCommand = Me.SubSelCmd
        Me.odaSub.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_サブ", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("注文NO", "注文NO"), New System.Data.Common.DataColumnMapping("商品番号", "商品番号"), New System.Data.Common.DataColumnMapping("商品名", "商品名"), New System.Data.Common.DataColumnMapping("単価", "単価"), New System.Data.Common.DataColumnMapping("数量", "数量"), New System.Data.Common.DataColumnMapping("金額", "金額")})})
        Me.odaSub.UpdateCommand = Me.SubUpdateCmd
        '
        'SubDelCmd
        '
        Me.SubDelCmd.CommandText = "DELETE FROM [T_サブ] WHERE (注文NO = ?) AND (商品番号 = ?) AND (数量 = ?)"
        Me.SubDelCmd.Connection = Me.ocnSample
        Me.SubDelCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("注文NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "注文NO", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("商品番号", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品番号", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("数量", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "数量", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SubInsertCmd
        '
        Me.SubInsertCmd.CommandText = "INSERT INTO [T_サブ] (注文NO, 商品番号, 数量) VALUES (?, ?, ?)"
        Me.SubInsertCmd.Connection = Me.ocnSample
        Me.SubInsertCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("注文NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "注文NO", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("商品番号", System.Data.OleDb.OleDbType.VarWChar, 10, "商品番号"), New System.Data.OleDb.OleDbParameter("数量", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "数量", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SubSelCmd
        '
        Me.SubSelCmd.CommandText = "SELECT [T_サブ].注文NO, [T_サブ].商品番号, [T_商品].商品名, [T_商品].単価, [T_サブ].数量, [T_商品].単価 * [T" &
    "_サブ].数量 AS 金額 FROM [T_サブ] INNER JOIN [T_商品] ON [T_サブ].商品番号 = [T_商品].商品番号"
        Me.SubSelCmd.Connection = Me.ocnSample
        '
        'SubUpdateCmd
        '
        Me.SubUpdateCmd.CommandText = "UPDATE [T_サブ] SET 注文NO = ?, 商品番号 = ?, 数量 = ? WHERE (注文NO = ?) AND (商品番号 = ?) AND " &
    "(数量 = ?)"
        Me.SubUpdateCmd.Connection = Me.ocnSample
        Me.SubUpdateCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("注文NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "注文NO", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("商品番号", System.Data.OleDb.OleDbType.VarWChar, 10, "商品番号"), New System.Data.OleDb.OleDbParameter("数量", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "数量", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Original_注文NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "注文NO", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_商品番号", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品番号", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_数量", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "数量", System.Data.DataRowVersion.Original, Nothing)})
        '
        'odaShohin
        '
        Me.odaShohin.DeleteCommand = Me.ShohinDelCmd
        Me.odaShohin.InsertCommand = Me.ShohinInsertCmd
        Me.odaShohin.SelectCommand = Me.ShohinSelCmd
        Me.odaShohin.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_商品", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("商品番号", "商品番号"), New System.Data.Common.DataColumnMapping("商品名", "商品名"), New System.Data.Common.DataColumnMapping("単価", "単価"), New System.Data.Common.DataColumnMapping("商品グループ", "商品グループ")})})
        Me.odaShohin.UpdateCommand = Me.ShohinUpdateCmd
        '
        'ShohinDelCmd
        '
        Me.ShohinDelCmd.CommandText = "DELETE FROM [T_商品] WHERE (商品番号 = ?) AND (単価 = ? OR ? IS NULL AND 単価 IS NULL) AND " &
    "([商品グループ] = ? OR ? IS NULL AND [商品グループ] IS NULL) AND (商品名 = ? OR ? IS NULL AND 商" &
    "品名 IS NULL)"
        Me.ShohinDelCmd.Connection = Me.ocnSample
        Me.ShohinDelCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_商品番号", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品番号", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_単価", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "単価", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_単価1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "単価", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_商品グループ", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品グループ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_商品グループ1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品グループ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_商品名", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品名", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_商品名1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品名", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ShohinInsertCmd
        '
        Me.ShohinInsertCmd.CommandText = "INSERT INTO [T_商品] (商品番号, 商品名, 単価, [商品グループ]) VALUES (?, ?, ?, ?)"
        Me.ShohinInsertCmd.Connection = Me.ocnSample
        Me.ShohinInsertCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("商品番号", System.Data.OleDb.OleDbType.VarWChar, 10, "商品番号"), New System.Data.OleDb.OleDbParameter("商品名", System.Data.OleDb.OleDbType.VarWChar, 20, "商品名"), New System.Data.OleDb.OleDbParameter("単価", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "単価", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("商品グループ", System.Data.OleDb.OleDbType.VarWChar, 10, "商品グループ")})
        '
        'ShohinSelCmd
        '
        Me.ShohinSelCmd.CommandText = "SELECT 商品番号, 商品名, 単価, [商品グループ] FROM [T_商品]"
        Me.ShohinSelCmd.Connection = Me.ocnSample
        '
        'ShohinUpdateCmd
        '
        Me.ShohinUpdateCmd.CommandText = resources.GetString("ShohinUpdateCmd.CommandText")
        Me.ShohinUpdateCmd.Connection = Me.ocnSample
        Me.ShohinUpdateCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("商品番号", System.Data.OleDb.OleDbType.VarWChar, 10, "商品番号"), New System.Data.OleDb.OleDbParameter("商品名", System.Data.OleDb.OleDbType.VarWChar, 20, "商品名"), New System.Data.OleDb.OleDbParameter("単価", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "単価", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("商品グループ", System.Data.OleDb.OleDbType.VarWChar, 10, "商品グループ"), New System.Data.OleDb.OleDbParameter("Original_商品番号", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品番号", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_単価", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "単価", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_単価1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "単価", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_商品グループ", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品グループ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_商品グループ1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品グループ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_商品名", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品名", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_商品名1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "商品名", System.Data.DataRowVersion.Original, Nothing)})
        '
        'odaShain
        '
        Me.odaShain.DeleteCommand = Me.ShainDelCmd
        Me.odaShain.InsertCommand = Me.ShainInsertCmd
        Me.odaShain.SelectCommand = Me.ShainSelCmd
        Me.odaShain.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_社員", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("社員ID", "社員ID"), New System.Data.Common.DataColumnMapping("氏名", "氏名"), New System.Data.Common.DataColumnMapping("フリガナ", "フリガナ")})})
        Me.odaShain.UpdateCommand = Me.ShainUpdateCmd
        '
        'ShainDelCmd
        '
        Me.ShainDelCmd.CommandText = "DELETE FROM [T_社員] WHERE (社員ID = ?) AND (フリガナ = ? OR ? IS NULL AND フリガナ IS NULL) " &
    "AND (氏名 = ? OR ? IS NULL AND 氏名 IS NULL)"
        Me.ShainDelCmd.Connection = Me.ocnSample
        Me.ShainDelCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_社員ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "社員ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_フリガナ", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "フリガナ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_フリガナ1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "フリガナ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_氏名", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "氏名", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_氏名1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "氏名", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ShainInsertCmd
        '
        Me.ShainInsertCmd.CommandText = "INSERT INTO [T_社員] (社員ID, 氏名, フリガナ) VALUES (?, ?, ?)"
        Me.ShainInsertCmd.Connection = Me.ocnSample
        Me.ShainInsertCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("社員ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "社員ID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("氏名", System.Data.OleDb.OleDbType.VarWChar, 20, "氏名"), New System.Data.OleDb.OleDbParameter("フリガナ", System.Data.OleDb.OleDbType.VarWChar, 20, "フリガナ")})
        '
        'ShainSelCmd
        '
        Me.ShainSelCmd.CommandText = "SELECT 社員ID, 氏名, フリガナ FROM [T_社員]"
        Me.ShainSelCmd.Connection = Me.ocnSample
        '
        'ShainUpdateCmd
        '
        Me.ShainUpdateCmd.CommandText = "UPDATE [T_社員] SET 社員ID = ?, 氏名 = ?, フリガナ = ? WHERE (社員ID = ?) AND (フリガナ = ? OR ? " &
    "IS NULL AND フリガナ IS NULL) AND (氏名 = ? OR ? IS NULL AND 氏名 IS NULL)"
        Me.ShainUpdateCmd.Connection = Me.ocnSample
        Me.ShainUpdateCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("社員ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "社員ID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("氏名", System.Data.OleDb.OleDbType.VarWChar, 20, "氏名"), New System.Data.OleDb.OleDbParameter("フリガナ", System.Data.OleDb.OleDbType.VarWChar, 20, "フリガナ"), New System.Data.OleDb.OleDbParameter("Original_社員ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "社員ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_フリガナ", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "フリガナ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_フリガナ1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "フリガナ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_氏名", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "氏名", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_氏名1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "氏名", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DsSample1
        '
        Me.DsSample1.DataSetName = "dsSample"
        Me.DsSample1.Locale = New System.Globalization.CultureInfo("ja-JP")
        Me.DsSample1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'odaKokyaku
        '
        Me.odaKokyaku.DeleteCommand = Me.KokyakuDelCmd
        Me.odaKokyaku.InsertCommand = Me.KokyakuInsertCmd
        Me.odaKokyaku.SelectCommand = Me.KokyakuSelCmd
        Me.odaKokyaku.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_顧客", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("顧客ID", "顧客ID"), New System.Data.Common.DataColumnMapping("氏名", "氏名"), New System.Data.Common.DataColumnMapping("フリガナ", "フリガナ"), New System.Data.Common.DataColumnMapping("郵便番号", "郵便番号"), New System.Data.Common.DataColumnMapping("都道府県", "都道府県"), New System.Data.Common.DataColumnMapping("住所", "住所"), New System.Data.Common.DataColumnMapping("電話番号", "電話番号")})})
        Me.odaKokyaku.UpdateCommand = Me.KokyakuUpdateCmd
        '
        'KokyakuDelCmd
        '
        Me.KokyakuDelCmd.CommandText = resources.GetString("KokyakuDelCmd.CommandText")
        Me.KokyakuDelCmd.Connection = Me.ocnSample
        Me.KokyakuDelCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_顧客ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "顧客ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_フリガナ", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "フリガナ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_フリガナ1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "フリガナ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_住所", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "住所", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_住所1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "住所", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_氏名", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "氏名", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_氏名1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "氏名", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_郵便番号", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "郵便番号", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_郵便番号1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "郵便番号", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_都道府県", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "都道府県", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_都道府県1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "都道府県", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_電話番号", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "電話番号", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_電話番号1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "電話番号", System.Data.DataRowVersion.Original, Nothing)})
        '
        'KokyakuInsertCmd
        '
        Me.KokyakuInsertCmd.CommandText = "INSERT INTO [T_顧客] (顧客ID, 氏名, フリガナ, 郵便番号, 都道府県, 住所, 電話番号) VALUES (?, ?, ?, ?, ?, " &
    "?, ?)"
        Me.KokyakuInsertCmd.Connection = Me.ocnSample
        Me.KokyakuInsertCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("顧客ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "顧客ID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("氏名", System.Data.OleDb.OleDbType.VarWChar, 20, "氏名"), New System.Data.OleDb.OleDbParameter("フリガナ", System.Data.OleDb.OleDbType.VarWChar, 20, "フリガナ"), New System.Data.OleDb.OleDbParameter("郵便番号", System.Data.OleDb.OleDbType.VarWChar, 8, "郵便番号"), New System.Data.OleDb.OleDbParameter("都道府県", System.Data.OleDb.OleDbType.VarWChar, 10, "都道府県"), New System.Data.OleDb.OleDbParameter("住所", System.Data.OleDb.OleDbType.VarWChar, 50, "住所"), New System.Data.OleDb.OleDbParameter("電話番号", System.Data.OleDb.OleDbType.VarWChar, 15, "電話番号")})
        '
        'KokyakuSelCmd
        '
        Me.KokyakuSelCmd.CommandText = "SELECT 顧客ID, 氏名, フリガナ, 郵便番号, 都道府県, 住所, 電話番号 FROM [T_顧客]"
        Me.KokyakuSelCmd.Connection = Me.ocnSample
        '
        'KokyakuUpdateCmd
        '
        Me.KokyakuUpdateCmd.CommandText = resources.GetString("KokyakuUpdateCmd.CommandText")
        Me.KokyakuUpdateCmd.Connection = Me.ocnSample
        Me.KokyakuUpdateCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("顧客ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "顧客ID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("氏名", System.Data.OleDb.OleDbType.VarWChar, 20, "氏名"), New System.Data.OleDb.OleDbParameter("フリガナ", System.Data.OleDb.OleDbType.VarWChar, 20, "フリガナ"), New System.Data.OleDb.OleDbParameter("郵便番号", System.Data.OleDb.OleDbType.VarWChar, 8, "郵便番号"), New System.Data.OleDb.OleDbParameter("都道府県", System.Data.OleDb.OleDbType.VarWChar, 10, "都道府県"), New System.Data.OleDb.OleDbParameter("住所", System.Data.OleDb.OleDbType.VarWChar, 50, "住所"), New System.Data.OleDb.OleDbParameter("電話番号", System.Data.OleDb.OleDbType.VarWChar, 15, "電話番号"), New System.Data.OleDb.OleDbParameter("Original_顧客ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "顧客ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_フリガナ", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "フリガナ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_フリガナ1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "フリガナ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_住所", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "住所", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_住所1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "住所", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_氏名", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "氏名", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_氏名1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "氏名", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_郵便番号", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "郵便番号", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_郵便番号1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "郵便番号", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_都道府県", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "都道府県", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_都道府県1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "都道府県", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_電話番号", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "電話番号", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_電話番号1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "電話番号", System.Data.DataRowVersion.Original, Nothing)})
        '
        'dlgSave
        '
        Me.dlgSave.FileName = "doc1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(736, 505)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "注文管理"
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '-----------------------------------
    '［伝票入力］メニュー
    '
    Private Sub mnuFileInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileInput.Click
        '伝票入力フォームを開く
        Dim fm As New frmDenpyo()
        fm.MdiParent = Me
        fm.Show()
    End Sub

    '
    '［顧客検索］メニュー
    '
    Private Sub mnuFileFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileFind.Click
        '顧客検索フォームを開く
        Dim fm As New frmList()
        fm.MdiParent = Me
        fm.Show()
    End Sub

    '
    '［終了］メニュー
    '
    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        'アプリケーションを終了する
        Application.Exit()
    End Sub

    '-----------------------------------
    '［商品登録］メニュー
    '
    Private Sub mnuPrepareShohin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrepareShohin.Click
        '商品登録フォームを開く
        Dim fm As New frmShohin()
        fm.MdiParent = Me
        fm.Show()
    End Sub

    '
    '［顧客登録］メニュー
    '
    Private Sub mnuPrepareKokyaku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrepareKokyaku.Click
        '顧客登録フォームを開く
        Dim fm As New frmKokyaku()
        fm.MdiParent = Me
        fm.Show()
    End Sub

    '
    '［社員登録］メニュー
    '
    Private Sub mnuPrepareShain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrepareShain.Click
        '社員登録フォームを開く
        Dim fm As New frmShain()
        fm.MdiParent = Me
        fm.Show()
    End Sub

End Class
