<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.LabelConectionStatus = New System.Windows.Forms.Label()
        Me.LabelDateTime = New System.Windows.Forms.Label()
        Me.PanelConnection = New System.Windows.Forms.Panel()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelUserData = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelCountry = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelCity = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxImage = New System.Windows.Forms.GroupBox()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.PanelHead = New System.Windows.Forms.Panel()
        Me.PanelRegistrationandEditUserData = New System.Windows.Forms.Panel()
        Me.PanelReadingTagProcess = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckBoxByID = New System.Windows.Forms.CheckBox()
        Me.CheckBoxByName = New System.Windows.Forms.CheckBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.LabelGetID = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ButtonScanID = New System.Windows.Forms.Button()
        Me.ButtonClearForm = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxCountry = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxCity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TimerTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSerialIn = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBoxStatusConnectio = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSelect = New System.Windows.Forms.PictureBox()
        Me.ButtonRegistration = New System.Windows.Forms.Button()
        Me.ButtonUserData = New System.Windows.Forms.Button()
        Me.ButtonConnection = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxUserImage = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ButtonCloseReadingTag = New System.Windows.Forms.Button()
        Me.PictureBoxImagePreview = New System.Windows.Forms.PictureBox()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelConnection.SuspendLayout()
        Me.PanelUserData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxImage.SuspendLayout()
        Me.PanelRegistrationandEditUserData.SuspendLayout()
        Me.PanelReadingTagProcess.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        CType(Me.PictureBoxStatusConnectio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PictureBoxSelect)
        Me.PanelMenu.Controls.Add(Me.ButtonRegistration)
        Me.PanelMenu.Controls.Add(Me.ButtonUserData)
        Me.PanelMenu.Controls.Add(Me.ButtonConnection)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(432, 713)
        Me.PanelMenu.TabIndex = 0
        '
        'LabelConectionStatus
        '
        Me.LabelConectionStatus.AutoSize = True
        Me.LabelConectionStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConectionStatus.Location = New System.Drawing.Point(440, 5)
        Me.LabelConectionStatus.Name = "LabelConectionStatus"
        Me.LabelConectionStatus.Size = New System.Drawing.Size(236, 15)
        Me.LabelConectionStatus.TabIndex = 1
        Me.LabelConectionStatus.Text = "Estado de Conexion: Desconectado"
        '
        'LabelDateTime
        '
        Me.LabelDateTime.AutoSize = True
        Me.LabelDateTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateTime.Location = New System.Drawing.Point(971, 5)
        Me.LabelDateTime.Name = "LabelDateTime"
        Me.LabelDateTime.Size = New System.Drawing.Size(210, 15)
        Me.LabelDateTime.TabIndex = 5
        Me.LabelDateTime.Text = "Hora 00:00:00 Fecha 00 mm ,00"
        '
        'PanelConnection
        '
        Me.PanelConnection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelConnection.Controls.Add(Me.ButtonConnect)
        Me.PanelConnection.Controls.Add(Me.ComboBoxBaudRate)
        Me.PanelConnection.Controls.Add(Me.Label1)
        Me.PanelConnection.Controls.Add(Me.ComboBoxPort)
        Me.PanelConnection.Controls.Add(Me.ButtonScanPort)
        Me.PanelConnection.Controls.Add(Me.Panel1)
        Me.PanelConnection.Location = New System.Drawing.Point(443, 25)
        Me.PanelConnection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.Size = New System.Drawing.Size(784, 672)
        Me.PanelConnection.TabIndex = 6
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonConnect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonConnect.Location = New System.Drawing.Point(19, 80)
        Me.ButtonConnect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(740, 37)
        Me.ButtonConnect.TabIndex = 9
        Me.ButtonConnect.Text = "Conectar"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(639, 25)
        Me.ComboBoxBaudRate.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(119, 24)
        Me.ComboBoxBaudRate.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(539, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Baud Rate: "
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(177, 25)
        Me.ComboBoxPort.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(352, 24)
        Me.ComboBoxPort.TabIndex = 2
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonScanPort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanPort.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonScanPort.Location = New System.Drawing.Point(19, 25)
        Me.ButtonScanPort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(151, 26)
        Me.ButtonScanPort.TabIndex = 1
        Me.ButtonScanPort.Text = "Escanear Puerto"
        Me.ButtonScanPort.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 6)
        Me.Panel1.TabIndex = 0
        '
        'PanelUserData
        '
        Me.PanelUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelUserData.Controls.Add(Me.GroupBox1)
        Me.PanelUserData.Controls.Add(Me.GroupBoxImage)
        Me.PanelUserData.Controls.Add(Me.PanelHead)
        Me.PanelUserData.Location = New System.Drawing.Point(443, 25)
        Me.PanelUserData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelUserData.Name = "PanelUserData"
        Me.PanelUserData.Size = New System.Drawing.Size(784, 672)
        Me.PanelUserData.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelCountry)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.LabelCity)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LabelAddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.LabelName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 334)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(740, 324)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Datos"
        '
        'LabelCountry
        '
        Me.LabelCountry.AutoSize = True
        Me.LabelCountry.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCountry.Location = New System.Drawing.Point(172, 183)
        Me.LabelCountry.Name = "LabelCountry"
        Me.LabelCountry.Size = New System.Drawing.Size(162, 28)
        Me.LabelCountry.TabIndex = 15
        Me.LabelCountry.Text = "Esperando..."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(141, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 28)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 28)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Correo"
        '
        'LabelCity
        '
        Me.LabelCity.AutoSize = True
        Me.LabelCity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCity.Location = New System.Drawing.Point(172, 134)
        Me.LabelCity.Name = "LabelCity"
        Me.LabelCity.Size = New System.Drawing.Size(162, 28)
        Me.LabelCity.TabIndex = 12
        Me.LabelCity.Text = "Esperando..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(141, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 28)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 28)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Materia"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.Location = New System.Drawing.Point(172, 85)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(162, 28)
        Me.LabelAddress.TabIndex = 9
        Me.LabelAddress.Text = "Esperando..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(141, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 28)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Grupo"
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonClear.Location = New System.Drawing.Point(636, 282)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(91, 26)
        Me.ButtonClear.TabIndex = 6
        Me.ButtonClear.Text = "Limpiar"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(172, 34)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(162, 28)
        Me.LabelName.TabIndex = 5
        Me.LabelName.Text = "Esperando..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(141, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'GroupBoxImage
        '
        Me.GroupBoxImage.Controls.Add(Me.LabelId)
        Me.GroupBoxImage.Controls.Add(Me.PictureBoxUserImage)
        Me.GroupBoxImage.Location = New System.Drawing.Point(275, 14)
        Me.GroupBoxImage.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxImage.Name = "GroupBoxImage"
        Me.GroupBoxImage.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxImage.Size = New System.Drawing.Size(277, 294)
        Me.GroupBoxImage.TabIndex = 1
        Me.GroupBoxImage.TabStop = False
        Me.GroupBoxImage.Text = "Imagen e ID"
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelId.Location = New System.Drawing.Point(33, 247)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(178, 28)
        Me.LabelId.TabIndex = 2
        Me.LabelId.Text = "ID : __________"
        '
        'PanelHead
        '
        Me.PanelHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PanelHead.Location = New System.Drawing.Point(0, 0)
        Me.PanelHead.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelHead.Name = "PanelHead"
        Me.PanelHead.Size = New System.Drawing.Size(784, 6)
        Me.PanelHead.TabIndex = 0
        '
        'PanelRegistrationandEditUserData
        '
        Me.PanelRegistrationandEditUserData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.PanelReadingTagProcess)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox3)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox2)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.GroupBox)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.ButtonClearForm)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.ButtonSave)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxCountry)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label13)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxCity)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label10)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxAddress)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label7)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.TextBoxName)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Label4)
        Me.PanelRegistrationandEditUserData.Controls.Add(Me.Panel4)
        Me.PanelRegistrationandEditUserData.Location = New System.Drawing.Point(443, 25)
        Me.PanelRegistrationandEditUserData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelRegistrationandEditUserData.Name = "PanelRegistrationandEditUserData"
        Me.PanelRegistrationandEditUserData.Size = New System.Drawing.Size(784, 672)
        Me.PanelRegistrationandEditUserData.TabIndex = 11
        '
        'PanelReadingTagProcess
        '
        Me.PanelReadingTagProcess.Controls.Add(Me.PictureBox3)
        Me.PanelReadingTagProcess.Controls.Add(Me.ButtonCloseReadingTag)
        Me.PanelReadingTagProcess.Controls.Add(Me.Label16)
        Me.PanelReadingTagProcess.Location = New System.Drawing.Point(48, 22)
        Me.PanelReadingTagProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelReadingTagProcess.Name = "PanelReadingTagProcess"
        Me.PanelReadingTagProcess.Size = New System.Drawing.Size(352, 203)
        Me.PanelReadingTagProcess.TabIndex = 23
        Me.PanelReadingTagProcess.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(141, 17)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Leyendo Tarjeta..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.PictureBoxImagePreview)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.CheckBoxByID)
        Me.GroupBox3.Controls.Add(Me.CheckBoxByName)
        Me.GroupBox3.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 334)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(740, 324)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Record View"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 68)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(560, 240)
        Me.DataGridView1.TabIndex = 27
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ClearSelectionToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.RefreshToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 114)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(178, 6)
        '
        'CheckBoxByID
        '
        Me.CheckBoxByID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxByID.AutoSize = True
        Me.CheckBoxByID.Location = New System.Drawing.Point(622, 27)
        Me.CheckBoxByID.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxByID.Name = "CheckBoxByID"
        Me.CheckBoxByID.Size = New System.Drawing.Size(110, 20)
        Me.CheckBoxByID.TabIndex = 26
        Me.CheckBoxByID.Text = "Buscar por ID"
        Me.CheckBoxByID.UseVisualStyleBackColor = True
        '
        'CheckBoxByName
        '
        Me.CheckBoxByName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxByName.AutoSize = True
        Me.CheckBoxByName.Checked = True
        Me.CheckBoxByName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxByName.Location = New System.Drawing.Point(466, 27)
        Me.CheckBoxByName.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxByName.Name = "CheckBoxByName"
        Me.CheckBoxByName.Size = New System.Drawing.Size(146, 20)
        Me.CheckBoxByName.TabIndex = 25
        Me.CheckBoxByName.Text = "Buscar por Nombre"
        Me.CheckBoxByName.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSearch.Location = New System.Drawing.Point(133, 25)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(312, 22)
        Me.TextBoxSearch.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 17)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Buscar: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PictureBoxImageInput)
        Me.GroupBox2.Location = New System.Drawing.Point(599, 150)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(160, 160)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Imagen"
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.LabelGetID)
        Me.GroupBox.Controls.Add(Me.Label14)
        Me.GroupBox.Controls.Add(Me.ButtonScanID)
        Me.GroupBox.Location = New System.Drawing.Point(431, 150)
        Me.GroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox.Size = New System.Drawing.Size(160, 160)
        Me.GroupBox.TabIndex = 20
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Obtener ID"
        '
        'LabelGetID
        '
        Me.LabelGetID.AutoSize = True
        Me.LabelGetID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGetID.Location = New System.Drawing.Point(47, 121)
        Me.LabelGetID.Name = "LabelGetID"
        Me.LabelGetID.Size = New System.Drawing.Size(88, 17)
        Me.LabelGetID.TabIndex = 22
        Me.LabelGetID.Text = "__________"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 17)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "ID"
        '
        'ButtonScanID
        '
        Me.ButtonScanID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonScanID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonScanID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonScanID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonScanID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonScanID.Location = New System.Drawing.Point(8, 27)
        Me.ButtonScanID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonScanID.Name = "ButtonScanID"
        Me.ButtonScanID.Size = New System.Drawing.Size(144, 60)
        Me.ButtonScanID.TabIndex = 21
        Me.ButtonScanID.Text = "Escanear"
        Me.ButtonScanID.UseVisualStyleBackColor = False
        '
        'ButtonClearForm
        '
        Me.ButtonClearForm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonClearForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonClearForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonClearForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClearForm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonClearForm.Location = New System.Drawing.Point(136, 250)
        Me.ButtonClearForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonClearForm.Name = "ButtonClearForm"
        Me.ButtonClearForm.Size = New System.Drawing.Size(109, 60)
        Me.ButtonClearForm.TabIndex = 19
        Me.ButtonClearForm.Text = "Limpiar"
        Me.ButtonClearForm.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ButtonSave.Location = New System.Drawing.Point(19, 250)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(109, 60)
        Me.ButtonSave.TabIndex = 18
        Me.ButtonSave.Text = "Guardar"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'TextBoxCountry
        '
        Me.TextBoxCountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCountry.Location = New System.Drawing.Point(100, 123)
        Me.TextBoxCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCountry.Name = "TextBoxCountry"
        Me.TextBoxCountry.Size = New System.Drawing.Size(655, 22)
        Me.TextBoxCountry.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Correo"
        '
        'TextBoxCity
        '
        Me.TextBoxCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCity.Location = New System.Drawing.Point(100, 86)
        Me.TextBoxCity.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCity.Name = "TextBoxCity"
        Me.TextBoxCity.Size = New System.Drawing.Size(655, 22)
        Me.TextBoxCity.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Materia"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxAddress.Location = New System.Drawing.Point(100, 49)
        Me.TextBoxAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(655, 22)
        Me.TextBoxAddress.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Grupo"
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxName.Location = New System.Drawing.Point(100, 12)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(655, 22)
        Me.TextBoxName.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(784, 6)
        Me.Panel4.TabIndex = 0
        '
        'TimerTimeDate
        '
        Me.TimerTimeDate.Enabled = True
        '
        'TimerSerialIn
        '
        Me.TimerSerialIn.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBoxStatusConnectio
        '
        Me.PictureBoxStatusConnectio.Image = Global.rfid_interface_arduino.My.Resources.Resources.status_disconnect
        Me.PictureBoxStatusConnectio.Location = New System.Drawing.Point(715, 5)
        Me.PictureBoxStatusConnectio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxStatusConnectio.Name = "PictureBoxStatusConnectio"
        Me.PictureBoxStatusConnectio.Size = New System.Drawing.Size(16, 15)
        Me.PictureBoxStatusConnectio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxStatusConnectio.TabIndex = 4
        Me.PictureBoxStatusConnectio.TabStop = False
        '
        'PictureBoxSelect
        '
        Me.PictureBoxSelect.Image = Global.rfid_interface_arduino.My.Resources.Resources.seleccion
        Me.PictureBoxSelect.Location = New System.Drawing.Point(0, 238)
        Me.PictureBoxSelect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxSelect.Name = "PictureBoxSelect"
        Me.PictureBoxSelect.Size = New System.Drawing.Size(24, 44)
        Me.PictureBoxSelect.TabIndex = 1
        Me.PictureBoxSelect.TabStop = False
        '
        'ButtonRegistration
        '
        Me.ButtonRegistration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegistration.ForeColor = System.Drawing.Color.White
        Me.ButtonRegistration.Image = Global.rfid_interface_arduino.My.Resources.Resources.user_data_edit
        Me.ButtonRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRegistration.Location = New System.Drawing.Point(29, 341)
        Me.ButtonRegistration.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonRegistration.Name = "ButtonRegistration"
        Me.ButtonRegistration.Size = New System.Drawing.Size(403, 44)
        Me.ButtonRegistration.TabIndex = 3
        Me.ButtonRegistration.Text = "Registrar / Editar datos de usuario"
        Me.ButtonRegistration.UseVisualStyleBackColor = True
        '
        'ButtonUserData
        '
        Me.ButtonUserData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUserData.ForeColor = System.Drawing.Color.White
        Me.ButtonUserData.Image = Global.rfid_interface_arduino.My.Resources.Resources.user
        Me.ButtonUserData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUserData.Location = New System.Drawing.Point(29, 289)
        Me.ButtonUserData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonUserData.Name = "ButtonUserData"
        Me.ButtonUserData.Size = New System.Drawing.Size(403, 44)
        Me.ButtonUserData.TabIndex = 2
        Me.ButtonUserData.Text = "Datos de Usuario"
        Me.ButtonUserData.UseVisualStyleBackColor = True
        '
        'ButtonConnection
        '
        Me.ButtonConnection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ButtonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnection.ForeColor = System.Drawing.Color.White
        Me.ButtonConnection.Image = Global.rfid_interface_arduino.My.Resources.Resources.connect
        Me.ButtonConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConnection.Location = New System.Drawing.Point(29, 236)
        Me.ButtonConnection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonConnection.Name = "ButtonConnection"
        Me.ButtonConnection.Size = New System.Drawing.Size(403, 44)
        Me.ButtonConnection.TabIndex = 1
        Me.ButtonConnection.Text = "Conexion"
        Me.ButtonConnection.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.rfid_interface_arduino.My.Resources.Resources.logo_tesji
        Me.PictureBox1.Location = New System.Drawing.Point(83, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxUserImage
        '
        Me.PictureBoxUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxUserImage.Location = New System.Drawing.Point(24, 30)
        Me.PictureBoxUserImage.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxUserImage.Name = "PictureBoxUserImage"
        Me.PictureBoxUserImage.Size = New System.Drawing.Size(231, 214)
        Me.PictureBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUserImage.TabIndex = 0
        Me.PictureBoxUserImage.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.rfid_interface_arduino.My.Resources.Resources.buscando
        Me.PictureBox3.Location = New System.Drawing.Point(52, 64)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(223, 121)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'ButtonCloseReadingTag
        '
        Me.ButtonCloseReadingTag.BackColor = System.Drawing.Color.White
        Me.ButtonCloseReadingTag.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonCloseReadingTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCloseReadingTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonCloseReadingTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCloseReadingTag.Image = Global.rfid_interface_arduino.My.Resources.Resources.close_tag_read
        Me.ButtonCloseReadingTag.Location = New System.Drawing.Point(299, 6)
        Me.ButtonCloseReadingTag.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCloseReadingTag.Name = "ButtonCloseReadingTag"
        Me.ButtonCloseReadingTag.Size = New System.Drawing.Size(33, 28)
        Me.ButtonCloseReadingTag.TabIndex = 30
        Me.ButtonCloseReadingTag.UseVisualStyleBackColor = False
        '
        'PictureBoxImagePreview
        '
        Me.PictureBoxImagePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImagePreview.Location = New System.Drawing.Point(580, 68)
        Me.PictureBoxImagePreview.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxImagePreview.Name = "PictureBoxImagePreview"
        Me.PictureBoxImagePreview.Size = New System.Drawing.Size(146, 135)
        Me.PictureBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImagePreview.TabIndex = 28
        Me.PictureBoxImagePreview.TabStop = False
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.rfid_interface_arduino.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Image = Global.rfid_interface_arduino.My.Resources.Resources.select_all
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ClearSelectionToolStripMenuItem
        '
        Me.ClearSelectionToolStripMenuItem.Image = Global.rfid_interface_arduino.My.Resources.Resources.deselect
        Me.ClearSelectionToolStripMenuItem.Name = "ClearSelectionToolStripMenuItem"
        Me.ClearSelectionToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ClearSelectionToolStripMenuItem.Text = "Clear Selection"
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Image = Global.rfid_interface_arduino.My.Resources.Resources.refresh2
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'PictureBoxImageInput
        '
        Me.PictureBoxImageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImageInput.Image = Global.rfid_interface_arduino.My.Resources.Resources.search_photo
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(13, 27)
        Me.PictureBoxImageInput.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(133, 123)
        Me.PictureBoxImageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImageInput.TabIndex = 0
        Me.PictureBoxImageInput.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1243, 711)
        Me.Controls.Add(Me.LabelDateTime)
        Me.Controls.Add(Me.PictureBoxStatusConnectio)
        Me.Controls.Add(Me.LabelConectionStatus)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelConnection)
        Me.Controls.Add(Me.PanelUserData)
        Me.Controls.Add(Me.PanelRegistrationandEditUserData)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "RFID TESJI"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        Me.PanelUserData.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxImage.ResumeLayout(False)
        Me.GroupBoxImage.PerformLayout()
        Me.PanelRegistrationandEditUserData.ResumeLayout(False)
        Me.PanelRegistrationandEditUserData.PerformLayout()
        Me.PanelReadingTagProcess.ResumeLayout(False)
        Me.PanelReadingTagProcess.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.PictureBoxStatusConnectio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonConnection As Button
    Friend WithEvents PictureBoxSelect As PictureBox
    Friend WithEvents ButtonRegistration As Button
    Friend WithEvents ButtonUserData As Button
    Friend WithEvents LabelConectionStatus As Label
    Friend WithEvents PictureBoxStatusConnectio As PictureBox
    Friend WithEvents LabelDateTime As Label
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents PanelUserData As Panel
    Friend WithEvents GroupBoxImage As GroupBox
    Friend WithEvents PanelHead As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelId As Label
    Friend WithEvents PictureBoxUserImage As PictureBox
    Friend WithEvents LabelCountry As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelCity As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents LabelName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelRegistrationandEditUserData As Panel
    Friend WithEvents TextBoxCity As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBoxCountry As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ButtonClearForm As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents LabelGetID As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ButtonScanID As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBoxImageInput As PictureBox
    Friend WithEvents CheckBoxByID As CheckBox
    Friend WithEvents CheckBoxByName As CheckBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBoxImagePreview As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelReadingTagProcess As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ButtonCloseReadingTag As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents TimerTimeDate As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TimerSerialIn As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
