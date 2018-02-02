Public Class frmShain
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
    Friend WithEvents dbgShain As System.Windows.Forms.DataGrid
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileLoad As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileStep As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditFind As System.Windows.Forms.MenuItem
    Friend WithEvents DsSample1 As SampleAppli.dsSample
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dbgShain = New System.Windows.Forms.DataGrid()
        Me.DsSample1 = New SampleAppli.dsSample()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileLoad = New System.Windows.Forms.MenuItem()
        Me.mnuFileSave = New System.Windows.Forms.MenuItem()
        Me.mnuFileStep = New System.Windows.Forms.MenuItem()
        Me.mnuFileQuit = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuEditFind = New System.Windows.Forms.MenuItem()
        CType(Me.dbgShain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbgShain
        '
        Me.dbgShain.DataMember = "T_社員"
        Me.dbgShain.DataSource = Me.DsSample1
        Me.dbgShain.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgShain.Location = New System.Drawing.Point(22, 20)
        Me.dbgShain.Name = "dbgShain"
        Me.dbgShain.Size = New System.Drawing.Size(415, 390)
        Me.dbgShain.TabIndex = 1
        '
        'DsSample1
        '
        Me.DsSample1.DataSetName = "dsSample"
        Me.DsSample1.Locale = New System.Globalization.CultureInfo("ja-JP")
        Me.DsSample1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.mnuEditFind.Text = "検索（&F）..."
        '
        'frmShain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(328, 317)
        Me.Controls.Add(Me.dbgShain)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmShain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "社員登録"
        CType(Me.dbgShain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'モジュールレベル変数
    Private m_fm As Form1


    '-----------------------
    '起動時
    '
    Private Sub frmShain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form1 を参照
        m_fm = Form1.ActiveForm

        'データ読み込み
        m_fm.odaShain.Fill(DsSample1, "T_社員")
    End Sub


    '
    '［閉じる］メニュー
    '
    Private Sub mnuFileQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileQuit.Click
        Dim flg As Boolean    '変更されたかどうか
        Dim btn As DialogResult    '選択したボタン

        '編集を終了
        Me.BindingContext(DsSample1, "T_社員").EndCurrentEdit()

        '変更されたかどうか
        flg = DsSample1.HasChanges()

        '変更されていないとき
        If flg = False Then
            Me.Close()
            Exit Sub
        End If

        '変更されているとき
        btn = MessageBox.Show("編集結果が保存されていません。" _
      & ControlChars.CrLf & "保存して終了しますか？", "社員登録",
      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        Select Case btn
            Case DialogResult.Yes    'はい
                '保存して終了
                m_fm.odaShain.Update(DsSample1, "T_社員")
                Me.Close()

            Case DialogResult.No   'いいえ
                '保存せずに終了
                Me.Close()

            Case DialogResult.Cancel 'キャンセル
                '何もしない
        End Select
    End Sub

    Private Sub mnuEditFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditFind.Click
        Dim fm As New frmDialog()   '検索フォーム
        Dim flg As Boolean    '見つかったかどうか
        Dim i As Integer      'カウンタ
        Dim n As Integer      '削除されたレコード数

        'キャンセルされたとき
        If fm.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        '値が入力されなかったとき
        If fm.Value = "" Then
            Exit Sub
        End If

        '検索
        flg = False
        n = 0
        For i = 0 To DsSample1.T_社員.Rows.Count - 1
            'レコードが削除されているとき
            If DsSample1.T_社員.Rows(i).RowState = DataRowState.Deleted Then
                n = n + 1
            Else
                If DsSample1.T_社員.Rows(i)("社員ID") = fm.Value Then
                    flg = True
                    Exit For
                End If
            End If
        Next i


        '結果を表示
        If flg = True Then
            '削除された分の調整
            Me.BindingContext(DsSample1, "T_社員").Position = (i - n)

        Else
            MessageBox.Show("該当する［社員ID］はありません", "社員登録",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub mnuFileLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileLoad.Click
        Dim btn As DialogResult  '選択したボタン

        '確認
        btn = MessageBox.Show("編集中のデータを破棄して、データを再ロードします。" _
      & ControlChars.CrLf & "よろしいですか", "社員登録",
      MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        'キャンセルボタンを選択
        If btn = DialogResult.Cancel Then
            Exit Sub
        End If

        'データセットの初期化
        DsSample1.Clear()

        'データ読み込み
        m_fm.odaShain.Fill(DsSample1, "T_社員")
    End Sub

    Private Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        '編集を終了
        Me.BindingContext(DsSample1, "T_社員").EndCurrentEdit()

        '保存
        m_fm.odaShain.Update(DsSample1, "T_社員")
    End Sub
End Class
