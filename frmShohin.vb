Public Class frmShohin
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
    Friend WithEvents dbgShohin As System.Windows.Forms.DataGrid
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileLoad As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileStep As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileQuilt As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRecord As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRecordFilter As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRecordSort As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRecordSortAsc As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRecordSortDesc As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRecordReset As System.Windows.Forms.MenuItem
    Friend WithEvents DsSample1 As SampleAppli.dsSample
    Friend WithEvents dvShohin As System.Data.DataView
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dbgShohin = New System.Windows.Forms.DataGrid()
        Me.dvShohin = New System.Data.DataView()
        Me.DsSample1 = New SampleAppli.dsSample()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileLoad = New System.Windows.Forms.MenuItem()
        Me.mnuFileSave = New System.Windows.Forms.MenuItem()
        Me.mnuFileStep = New System.Windows.Forms.MenuItem()
        Me.mnuFileQuilt = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuEditFind = New System.Windows.Forms.MenuItem()
        Me.mnuRecord = New System.Windows.Forms.MenuItem()
        Me.mnuRecordFilter = New System.Windows.Forms.MenuItem()
        Me.mnuRecordSort = New System.Windows.Forms.MenuItem()
        Me.mnuRecordSortAsc = New System.Windows.Forms.MenuItem()
        Me.mnuRecordSortDesc = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.mnuRecordReset = New System.Windows.Forms.MenuItem()
        CType(Me.dbgShohin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvShohin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbgShohin
        '
        Me.dbgShohin.DataMember = ""
        Me.dbgShohin.DataSource = Me.dvShohin
        Me.dbgShohin.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgShohin.Location = New System.Drawing.Point(22, 20)
        Me.dbgShohin.Name = "dbgShohin"
        Me.dbgShohin.Size = New System.Drawing.Size(644, 283)
        Me.dbgShohin.TabIndex = 1
        Me.dbgShohin.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'dvShohin
        '
        Me.dvShohin.Table = Me.DsSample1.T_商品
        '
        'DsSample1
        '
        Me.DsSample1.DataSetName = "dsSample"
        Me.DsSample1.Locale = New System.Globalization.CultureInfo("ja-JP")
        Me.DsSample1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dbgShohin
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "T_商品"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "商品番号"
        Me.DataGridTextBoxColumn1.MappingName = "商品番号"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "商品名"
        Me.DataGridTextBoxColumn2.MappingName = "商品名"
        Me.DataGridTextBoxColumn2.Width = 180
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "###,###"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "単価"
        Me.DataGridTextBoxColumn3.MappingName = "単価"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "商品グループ"
        Me.DataGridTextBoxColumn4.MappingName = "商品グループ"
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuEdit, Me.mnuRecord})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileLoad, Me.mnuFileSave, Me.mnuFileStep, Me.mnuFileQuilt})
        Me.mnuFile.Text = "ファイル（&F）"
        '
        'mnuFileLoad
        '
        Me.mnuFileLoad.Index = 0
        Me.mnuFileLoad.Text = "再ロード（&L）"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Index = 1
        Me.mnuFileSave.Text = "上書き保存（&S）"
        '
        'mnuFileStep
        '
        Me.mnuFileStep.Index = 2
        Me.mnuFileStep.Text = "-"
        '
        'mnuFileQuilt
        '
        Me.mnuFileQuilt.Index = 3
        Me.mnuFileQuilt.Text = "閉じる（&Q）"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEditFind})
        Me.mnuEdit.Text = "編集（&E）"
        '
        'mnuEditFind
        '
        Me.mnuEditFind.Index = 0
        Me.mnuEditFind.Text = "検索（&F）..."
        '
        'mnuRecord
        '
        Me.mnuRecord.Index = 2
        Me.mnuRecord.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRecordFilter, Me.mnuRecordSort, Me.MenuItem13, Me.mnuRecordReset})
        Me.mnuRecord.Text = "レコード（&R）"
        '
        'mnuRecordFilter
        '
        Me.mnuRecordFilter.Index = 0
        Me.mnuRecordFilter.Text = "商品グループのフィルタ（&F）..."
        '
        'mnuRecordSort
        '
        Me.mnuRecordSort.Index = 1
        Me.mnuRecordSort.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRecordSortAsc, Me.mnuRecordSortDesc})
        Me.mnuRecordSort.Text = "単価の並べ替え（&S）"
        '
        'mnuRecordSortAsc
        '
        Me.mnuRecordSortAsc.Index = 0
        Me.mnuRecordSortAsc.Text = "昇順（&A）"
        '
        'mnuRecordSortDesc
        '
        Me.mnuRecordSortDesc.Index = 1
        Me.mnuRecordSortDesc.Text = "降順（&D）"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Text = "-"
        '
        'mnuRecordReset
        '
        Me.mnuRecordReset.Index = 3
        Me.mnuRecordReset.Text = "フィルタ並べ替え解除（&X）"
        '
        'frmShohin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(694, 315)
        Me.Controls.Add(Me.dbgShohin)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmShohin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "商品登録"
        CType(Me.dbgShohin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvShohin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '--------------------------------
    'モジュールレベル変数
    Private m_fm As Form1       'Form1

    '--------------------
    '起動時
    '
    Private Sub frmShohin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form1 を参照
        m_fm = Form1.ActiveForm

        'データ読み込み
        m_fm.odaShohin.Fill(DsSample1, "T_商品")
    End Sub


    '
    '［閉じる］メニュー
    '
    Private Sub mnuFileQuilt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileQuilt.Click
        Me.Close()
    End Sub

End Class
