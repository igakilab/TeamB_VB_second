Public Class frmKokyaku
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
    Friend WithEvents DsSample1 As SampleAppli.dsSample
    Friend WithEvents dvHurigana As System.Data.DataView
    Friend WithEvents dbgKokyaku As System.Windows.Forms.DataGrid
    Friend WithEvents tabHurigana As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileLoad As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileStep As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditFindID As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditFindTel As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileLoad = New System.Windows.Forms.MenuItem()
        Me.mnuFileSave = New System.Windows.Forms.MenuItem()
        Me.mnuFileStep = New System.Windows.Forms.MenuItem()
        Me.mnuFileQuit = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuEditFind = New System.Windows.Forms.MenuItem()
        Me.mnuEditFindID = New System.Windows.Forms.MenuItem()
        Me.mnuEditFindTel = New System.Windows.Forms.MenuItem()
        Me.DsSample1 = New SampleAppli.dsSample()
        Me.dvHurigana = New System.Data.DataView()
        Me.dbgKokyaku = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.tabHurigana = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvHurigana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbgKokyaku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHurigana.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuEdit})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileLoad, Me.mnuFileSave, Me.mnuFileStep, Me.mnuFileQuit})
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
        'mnuFileQuit
        '
        Me.mnuFileQuit.Index = 3
        Me.mnuFileQuit.Text = "閉じる（&Q）"
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
        Me.mnuEditFind.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEditFindID, Me.mnuEditFindTel})
        Me.mnuEditFind.Text = "検索（&F）"
        '
        'mnuEditFindID
        '
        Me.mnuEditFindID.Index = 0
        Me.mnuEditFindID.Text = "顧客ID（&I）..."
        '
        'mnuEditFindTel
        '
        Me.mnuEditFindTel.Index = 1
        Me.mnuEditFindTel.Text = "電話番号（&T）..."
        '
        'DsSample1
        '
        Me.DsSample1.DataSetName = "dsSample"
        Me.DsSample1.Locale = New System.Globalization.CultureInfo("ja-JP")
        Me.DsSample1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dvHurigana
        '
        Me.dvHurigana.Table = Me.DsSample1.T_顧客
        '
        'dbgKokyaku
        '
        Me.dbgKokyaku.DataMember = ""
        Me.dbgKokyaku.DataSource = Me.dvHurigana
        Me.dbgKokyaku.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgKokyaku.Location = New System.Drawing.Point(22, 50)
        Me.dbgKokyaku.Name = "dbgKokyaku"
        Me.dbgKokyaku.Size = New System.Drawing.Size(941, 390)
        Me.dbgKokyaku.TabIndex = 3
        Me.dbgKokyaku.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dbgKokyaku
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "T_顧客"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "顧客ID"
        Me.DataGridTextBoxColumn1.MappingName = "顧客ID"
        Me.DataGridTextBoxColumn1.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "氏名"
        Me.DataGridTextBoxColumn2.MappingName = "氏名"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "フリガナ"
        Me.DataGridTextBoxColumn3.MappingName = "フリガナ"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "〒番号"
        Me.DataGridTextBoxColumn4.MappingName = "郵便番号"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "都道府県"
        Me.DataGridTextBoxColumn5.MappingName = "都道府県"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "住所"
        Me.DataGridTextBoxColumn6.MappingName = "住所"
        Me.DataGridTextBoxColumn6.Width = 160
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "電話番号"
        Me.DataGridTextBoxColumn7.MappingName = "電話番号"
        Me.DataGridTextBoxColumn7.Width = 90
        '
        'tabHurigana
        '
        Me.tabHurigana.Controls.Add(Me.TabPage1)
        Me.tabHurigana.Controls.Add(Me.TabPage2)
        Me.tabHurigana.Controls.Add(Me.TabPage3)
        Me.tabHurigana.Controls.Add(Me.TabPage4)
        Me.tabHurigana.Controls.Add(Me.TabPage5)
        Me.tabHurigana.Controls.Add(Me.TabPage6)
        Me.tabHurigana.Controls.Add(Me.TabPage7)
        Me.tabHurigana.Controls.Add(Me.TabPage8)
        Me.tabHurigana.Controls.Add(Me.TabPage9)
        Me.tabHurigana.Controls.Add(Me.TabPage10)
        Me.tabHurigana.Controls.Add(Me.TabPage11)
        Me.tabHurigana.Location = New System.Drawing.Point(22, 20)
        Me.tabHurigana.Name = "tabHurigana"
        Me.tabHurigana.SelectedIndex = 0
        Me.tabHurigana.Size = New System.Drawing.Size(941, 30)
        Me.tabHurigana.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(933, 1)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "全"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(933, 1)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "あ"
        Me.TabPage2.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(933, 1)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "か"
        Me.TabPage3.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(933, 1)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "さ"
        Me.TabPage4.Visible = False
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(933, 1)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "た"
        Me.TabPage5.Visible = False
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(933, 1)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "な"
        Me.TabPage6.Visible = False
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(933, 1)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "は"
        Me.TabPage7.Visible = False
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(933, 1)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "ま"
        Me.TabPage8.Visible = False
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 25)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(933, 1)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "や"
        Me.TabPage9.Visible = False
        '
        'TabPage10
        '
        Me.TabPage10.Location = New System.Drawing.Point(4, 25)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(933, 1)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "ら"
        Me.TabPage10.Visible = False
        '
        'TabPage11
        '
        Me.TabPage11.Location = New System.Drawing.Point(4, 25)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(933, 1)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "わ"
        Me.TabPage11.Visible = False
        '
        'frmKokyaku
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(704, 369)
        Me.Controls.Add(Me.dbgKokyaku)
        Me.Controls.Add(Me.tabHurigana)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmKokyaku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "顧客登録"
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvHurigana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbgKokyaku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHurigana.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '----------------------
    'モジュールレベル変数
    Private m_fm As Form1


    '---------------
    '起動時
    '
    Private Sub frmKokyaku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form1 を参照
        m_fm = Form1.ActiveForm

        'データ読み込み
        m_fm.odaKokyaku.Fill(DsSample1, "T_顧客")
    End Sub


    '
    '［閉じる］メニュー
    '
    Private Sub mnuFileQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileQuit.Click
        Dim flg As Boolean    '変更されたかどうか
        Dim btn As DialogResult    '選択したボタン

        '編集を終了
        Me.BindingContext(dvHurigana).EndCurrentEdit()

        '変更されたかどうか
        flg = DsSample1.HasChanges()

        '変更されていないとき
        If flg = False Then
            Me.Close()
            Exit Sub
        End If

        '変更されているとき
        btn = MessageBox.Show("編集結果が保存されていません。" _
      & ControlChars.CrLf & "保存して終了しますか？", "顧客登録",
      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        Select Case btn
            Case DialogResult.Yes    'はい
                '保存して終了
                m_fm.odaKokyaku.Update(DsSample1, "T_顧客")
                Me.Close()

            Case DialogResult.No   'いいえ
                '保存せずに終了
                Me.Close()

            Case DialogResult.Cancel 'キャンセル
                '何もしない
        End Select
    End Sub

    Private Sub mnuFileLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileLoad.Click
        Dim btn As DialogResult  '選択したボタン

        '確認
        btn = MessageBox.Show("編集中のデータを破棄して、データを再ロードします。" _
      & ControlChars.CrLf & "よろしいですか", "顧客登録",
      MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        'キャンセルボタンを選択
        If btn = DialogResult.Cancel Then
            Exit Sub
        End If

        'データセットの初期化
        DsSample1.Clear()

        'データ読み込み
        m_fm.odaKokyaku.Fill(DsSample1, "T_顧客")

        'フィルタ解除
        dvHurigana.RowFilter = ""
        tabHurigana.SelectedIndex = 0
    End Sub


    Private Sub mnuEditFindID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditFindID.Click
        Dim fm As New frmDialog()   '検索フォーム
        Dim flg As Boolean    '見つかったかどうか
        Dim i As Integer      'カウンタ

        'キャンセルされたとき
        If fm.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        '値が入力されなかったとき
        If fm.Value = "" Then
            Exit Sub
        End If

        '検索準備
        dvHurigana.RowFilter = ""
        tabHurigana.SelectedIndex = 0

        '検索
        flg = False
        For i = 0 To dvHurigana.Count - 1
            If dvHurigana(i)("顧客ID") = fm.Value Then
                flg = True
                Exit For
            End If
        Next i

        '結果を表示
        If flg = True Then
            Me.BindingContext(dvHurigana).Position = i

        Else
            MessageBox.Show("該当する［顧客ID］はありません", "顧客登録")
        End If
    End Sub

    Private Sub mnuEditFindTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditFindTel.Click
        Dim fm As New frmDialog()   '検索フォーム
        Dim flg As Boolean    '見つかったかどうか
        Dim i As Integer      'カウンタ

        'キャンセルされたとき
        If fm.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        '値が入力されなかったとき
        If fm.Value = "" Then
            Exit Sub
        End If

        '検索準備
        dvHurigana.RowFilter = ""
        tabHurigana.SelectedIndex = 0

        '検索
        flg = False
        For i = 0 To dvHurigana.Count - 1
            If dvHurigana(i)("電話番号") = fm.Value Then
                flg = True
                Exit For
            End If
        Next i

        '結果を表示
        If flg = True Then
            Me.BindingContext(dvHurigana).Position = i

        Else
            MessageBox.Show("該当する［電話番号］はありません", "顧客登録")
        End If
    End Sub

    Private Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        '編集を終了
        Me.BindingContext(dvHurigana).EndCurrentEdit()

        '保存
        m_fm.odaKokyaku.Update(DsSample1, "T_顧客")

    End Sub

    Private Sub tabHurigana_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabHurigana.SelectedIndexChanged
        Select Case tabHurigana.SelectedIndex
            Case 0
                dvHurigana.RowFilter = ""

            Case 1
                dvHurigana.RowFilter = "(フリガナ Like 'ｱ%')" _
                           & " OR (フリガナ Like 'ｲ%')" _
                           & " OR (フリガナ Like 'ｳ%')" _
                           & " OR (フリガナ Like 'ｴ%')" _
                           & " OR (フリガナ Like 'ｵ%')"

            Case 2
                dvHurigana.RowFilter = "(フリガナ Like 'ｶ%') OR (フリガナ Like 'ｶﾞ%')" _
                           & " OR (フリガナ Like 'ｷ%') OR (フリガナ Like 'ｷﾞ%')" _
                           & " OR (フリガナ Like 'ｸ%') OR (フリガナ Like 'ｸﾞ%')" _
                           & " OR (フリガナ Like 'ｹ%') OR (フリガナ Like 'ｹﾞ%')" _
                           & " OR (フリガナ Like 'ｺ%') OR (フリガナ Like 'ｺﾞ%')"

            Case 3
                dvHurigana.RowFilter = "(フリガナ Like 'ｻ%') OR (フリガナ Like 'ｻﾞ%')" _
                           & " OR (フリガナ Like 'ｼ%') OR (フリガナ Like 'ｼﾞ%')" _
                           & " OR (フリガナ Like 'ｽ%') OR (フリガナ Like 'ｽﾞ%')" _
                           & " OR (フリガナ Like 'ｾ%') OR (フリガナ Like 'ｾﾞ%')" _
                           & " OR (フリガナ Like 'ｿ%') OR (フリガナ Like 'ｿﾞ%')"

            Case 4
                dvHurigana.RowFilter = "(フリガナ Like 'ﾀ%') OR (フリガナ Like 'ﾀﾞ%')" _
                           & " OR (フリガナ Like 'ﾁ%') OR (フリガナ Like 'ﾁﾞ%')" _
                           & " OR (フリガナ Like 'ﾂ%') OR (フリガナ Like 'ﾂﾞ%')" _
                           & " OR (フリガナ Like 'ﾃ%') OR (フリガナ Like 'ﾃﾞ%')" _
                           & " OR (フリガナ Like 'ﾄ%') OR (フリガナ Like 'ﾄﾞ%')"

            Case 5
                dvHurigana.RowFilter = "(フリガナ Like 'ﾅ%')" _
                           & " OR (フリガナ Like 'ﾆ%')" _
                           & " OR (フリガナ Like 'ﾇ%')" _
                           & " OR (フリガナ Like 'ﾈ%')" _
                           & " OR (フリガナ Like 'ﾉ%')"

            Case 6
                dvHurigana.RowFilter = "(フリガナ Like 'ﾊ%') OR (フリガナ Like 'ﾊﾞ%')" _
                           & " OR (フリガナ Like 'ﾋ%') OR (フリガナ Like 'ﾋﾞ%')" _
                           & " OR (フリガナ Like 'ﾌ%') OR (フリガナ Like 'ﾌﾞ%')" _
                           & " OR (フリガナ Like 'ﾍ%') OR (フリガナ Like 'ﾍﾞ%')" _
                           & " OR (フリガナ Like 'ﾎ%') OR (フリガナ Like 'ﾎﾞ%')" _
                           & " OR (フリガナ Like 'ﾊﾟ%') OR (フリガナ Like 'ﾋﾟ%')" _
                           & " OR (フリガナ Like 'ﾌﾟ%') OR (フリガナ Like 'ﾍﾟ%')" _
                           & " OR (フリガナ Like 'ﾎﾟ%')"

            Case 7
                dvHurigana.RowFilter = "(フリガナ Like 'ﾏ%')" _
                           & " OR (フリガナ Like 'ﾐ%')" _
                           & " OR (フリガナ Like 'ﾑ%')" _
                           & " OR (フリガナ Like 'ﾒ%')" _
                           & " OR (フリガナ Like 'ﾓ%')"

            Case 8
                dvHurigana.RowFilter = "(フリガナ Like 'ﾔ%')" _
                           & " OR (フリガナ Like 'ﾕ%')" _
                           & " OR (フリガナ Like 'ﾖ%')"

            Case 9
                dvHurigana.RowFilter = "(フリガナ Like 'ﾗ%')" _
                           & " OR (フリガナ Like 'ﾘ%')" _
                           & " OR (フリガナ Like 'ﾙ%')" _
                           & " OR (フリガナ Like 'ﾚ%')" _
                           & " OR (フリガナ Like 'ﾛ%')"

            Case 10
                dvHurigana.RowFilter = "(フリガナ Like 'ﾜ%')" _
                           & " OR (フリガナ Like 'ｦ%')" _
                           & " OR (フリガナ Like 'ﾝ%')"

        End Select
    End Sub
End Class
