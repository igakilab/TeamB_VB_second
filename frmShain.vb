Public Class frmShain
    Inherits System.Windows.Forms.Form

#Region " Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h "

    Public Sub New()
        MyBase.New()

        ' ���̌Ăяo���� Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
        InitializeComponent()

        ' InitializeComponent() �Ăяo���̌�ɏ�������ǉ����܂��B

    End Sub

    ' Form �� dispose ���I�[�o�[���C�h���ăR���|�[�l���g�ꗗ���������܂��B
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
    Private components As System.ComponentModel.IContainer

    ' ���� : �ȉ��̃v���V�[�W���́AWindows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
    ' Windows �t�H�[�� �f�U�C�i���g���ĕύX���Ă��������B  
    ' �R�[�h �G�f�B�^�͎g�p���Ȃ��ł��������B
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
        Me.dbgShain.DataMember = "T_�Ј�"
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
        Me.mnuFile.Text = "�t�@�C���i&F�j"
        '
        'mnuFileLoad
        '
        Me.mnuFileLoad.Index = 0
        Me.mnuFileLoad.Text = "�ă��[�h�i&L�j"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Index = 1
        Me.mnuFileSave.Text = "�㏑���ۑ��i&S�j"
        '
        'mnuFileStep
        '
        Me.mnuFileStep.Index = 2
        Me.mnuFileStep.Text = "-"
        '
        'mnuFileQuit
        '
        Me.mnuFileQuit.Index = 3
        Me.mnuFileQuit.Text = "����i&Q�j"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEditFind})
        Me.mnuEdit.Text = "�ҏW�i&E�j"
        '
        'mnuEditFind
        '
        Me.mnuEditFind.Index = 0
        Me.mnuEditFind.Text = "�����i&F�j..."
        '
        'frmShain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(328, 317)
        Me.Controls.Add(Me.dbgShain)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmShain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "�Ј��o�^"
        CType(Me.dbgShain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '���W���[�����x���ϐ�
    Private m_fm As Form1


    '-----------------------
    '�N����
    '
    Private Sub frmShain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form1 ���Q��
        m_fm = Form1.ActiveForm

        '�f�[�^�ǂݍ���
        m_fm.odaShain.Fill(DsSample1, "T_�Ј�")
    End Sub


    '
    '�m����n���j���[
    '
    Private Sub mnuFileQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileQuit.Click
        Dim flg As Boolean    '�ύX���ꂽ���ǂ���
        Dim btn As DialogResult    '�I�������{�^��

        '�ҏW���I��
        Me.BindingContext(DsSample1, "T_�Ј�").EndCurrentEdit()

        '�ύX���ꂽ���ǂ���
        flg = DsSample1.HasChanges()

        '�ύX����Ă��Ȃ��Ƃ�
        If flg = False Then
            Me.Close()
            Exit Sub
        End If

        '�ύX����Ă���Ƃ�
        btn = MessageBox.Show("�ҏW���ʂ��ۑ�����Ă��܂���B" _
      & ControlChars.CrLf & "�ۑ����ďI�����܂����H", "�Ј��o�^",
      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        Select Case btn
            Case DialogResult.Yes    '�͂�
                '�ۑ����ďI��
                m_fm.odaShain.Update(DsSample1, "T_�Ј�")
                Me.Close()

            Case DialogResult.No   '������
                '�ۑ������ɏI��
                Me.Close()

            Case DialogResult.Cancel '�L�����Z��
                '�������Ȃ�
        End Select
    End Sub

    Private Sub mnuEditFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditFind.Click
        Dim fm As New frmDialog()   '�����t�H�[��
        Dim flg As Boolean    '�����������ǂ���
        Dim i As Integer      '�J�E���^
        Dim n As Integer      '�폜���ꂽ���R�[�h��

        '�L�����Z�����ꂽ�Ƃ�
        If fm.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        '�l�����͂���Ȃ������Ƃ�
        If fm.Value = "" Then
            Exit Sub
        End If

        '����
        flg = False
        n = 0
        For i = 0 To DsSample1.T_�Ј�.Rows.Count - 1
            '���R�[�h���폜����Ă���Ƃ�
            If DsSample1.T_�Ј�.Rows(i).RowState = DataRowState.Deleted Then
                n = n + 1
            Else
                If DsSample1.T_�Ј�.Rows(i)("�Ј�ID") = fm.Value Then
                    flg = True
                    Exit For
                End If
            End If
        Next i


        '���ʂ�\��
        If flg = True Then
            '�폜���ꂽ���̒���
            Me.BindingContext(DsSample1, "T_�Ј�").Position = (i - n)

        Else
            MessageBox.Show("�Y������m�Ј�ID�n�͂���܂���", "�Ј��o�^",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub mnuFileLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileLoad.Click
        Dim btn As DialogResult  '�I�������{�^��

        '�m�F
        btn = MessageBox.Show("�ҏW���̃f�[�^��j�����āA�f�[�^���ă��[�h���܂��B" _
      & ControlChars.CrLf & "��낵���ł���", "�Ј��o�^",
      MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        '�L�����Z���{�^����I��
        If btn = DialogResult.Cancel Then
            Exit Sub
        End If

        '�f�[�^�Z�b�g�̏�����
        DsSample1.Clear()

        '�f�[�^�ǂݍ���
        m_fm.odaShain.Fill(DsSample1, "T_�Ј�")
    End Sub

    Private Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        '�ҏW���I��
        Me.BindingContext(DsSample1, "T_�Ј�").EndCurrentEdit()

        '�ۑ�
        m_fm.odaShain.Update(DsSample1, "T_�Ј�")
    End Sub
End Class
