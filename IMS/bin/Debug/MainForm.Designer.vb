<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButtonInsert = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOutgoing = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelComments = New System.Windows.Forms.Label()
        Me.LabelCondition = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButtonGood = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBad = New System.Windows.Forms.RadioButton()
        Me.LabelTech = New System.Windows.Forms.Label()
        Me.LabelSerial = New System.Windows.Forms.Label()
        Me.LabelPartyName = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelDestination = New System.Windows.Forms.Label()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxComments = New System.Windows.Forms.TextBox()
        Me.ComboBoxPart = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTech = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDestination = New System.Windows.Forms.ComboBox()
        Me.TextBoxSerial = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelDataGrid = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(0, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 601)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox5.Location = New System.Drawing.Point(6, 39)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(89, 127)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "Please Select Form:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButtonInsert)
        Me.Panel1.Controls.Add(Me.RadioButtonOutgoing)
        Me.Panel1.Location = New System.Drawing.Point(101, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 127)
        Me.Panel1.TabIndex = 3
        '
        'RadioButtonInsert
        '
        Me.RadioButtonInsert.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButtonInsert.AutoSize = True
        Me.RadioButtonInsert.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonInsert.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonInsert.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RadioButtonInsert.Image = CType(resources.GetObject("RadioButtonInsert.Image"), System.Drawing.Image)
        Me.RadioButtonInsert.Location = New System.Drawing.Point(20, 5)
        Me.RadioButtonInsert.Name = "RadioButtonInsert"
        Me.RadioButtonInsert.Size = New System.Drawing.Size(110, 96)
        Me.RadioButtonInsert.TabIndex = 9
        Me.RadioButtonInsert.UseVisualStyleBackColor = False
        '
        'RadioButtonOutgoing
        '
        Me.RadioButtonOutgoing.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RadioButtonOutgoing.AutoSize = True
        Me.RadioButtonOutgoing.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonOutgoing.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RadioButtonOutgoing.Image = CType(resources.GetObject("RadioButtonOutgoing.Image"), System.Drawing.Image)
        Me.RadioButtonOutgoing.Location = New System.Drawing.Point(195, 5)
        Me.RadioButtonOutgoing.Name = "RadioButtonOutgoing"
        Me.RadioButtonOutgoing.Size = New System.Drawing.Size(110, 96)
        Me.RadioButtonOutgoing.TabIndex = 8
        Me.RadioButtonOutgoing.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.LabelComments, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelCondition, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelTech, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelSerial, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelPartyName, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelDate, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimePicker1, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelDestination, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonSearch, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxComments, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBoxPart, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBoxTech, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBoxDestination, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxSerial, 1, 0)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 172)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(432, 325)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'LabelComments
        '
        Me.LabelComments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelComments.AutoSize = True
        Me.LabelComments.BackColor = System.Drawing.Color.Transparent
        Me.LabelComments.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComments.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelComments.Location = New System.Drawing.Point(3, 275)
        Me.LabelComments.Name = "LabelComments"
        Me.LabelComments.Size = New System.Drawing.Size(92, 19)
        Me.LabelComments.TabIndex = 11
        Me.LabelComments.Text = "Comments:"
        Me.LabelComments.Visible = False
        '
        'LabelCondition
        '
        Me.LabelCondition.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCondition.AutoSize = True
        Me.LabelCondition.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCondition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCondition.Location = New System.Drawing.Point(3, 119)
        Me.LabelCondition.Name = "LabelCondition"
        Me.LabelCondition.Size = New System.Drawing.Size(92, 19)
        Me.LabelCondition.TabIndex = 2
        Me.LabelCondition.Text = "Condition:"
        Me.LabelCondition.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButtonGood)
        Me.Panel2.Controls.Add(Me.RadioButtonBad)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(101, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 67)
        Me.Panel2.TabIndex = 2
        Me.Panel2.Visible = False
        '
        'RadioButtonGood
        '
        Me.RadioButtonGood.AutoSize = True
        Me.RadioButtonGood.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonGood.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RadioButtonGood.Location = New System.Drawing.Point(27, 12)
        Me.RadioButtonGood.Name = "RadioButtonGood"
        Me.RadioButtonGood.Size = New System.Drawing.Size(64, 23)
        Me.RadioButtonGood.TabIndex = 9
        Me.RadioButtonGood.TabStop = True
        Me.RadioButtonGood.Text = "Good"
        Me.RadioButtonGood.UseVisualStyleBackColor = True
        '
        'RadioButtonBad
        '
        Me.RadioButtonBad.AutoSize = True
        Me.RadioButtonBad.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonBad.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RadioButtonBad.Location = New System.Drawing.Point(27, 41)
        Me.RadioButtonBad.Name = "RadioButtonBad"
        Me.RadioButtonBad.Size = New System.Drawing.Size(54, 23)
        Me.RadioButtonBad.TabIndex = 8
        Me.RadioButtonBad.TabStop = True
        Me.RadioButtonBad.Text = "Bad"
        Me.RadioButtonBad.UseVisualStyleBackColor = True
        '
        'LabelTech
        '
        Me.LabelTech.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTech.AutoSize = True
        Me.LabelTech.BackColor = System.Drawing.Color.Transparent
        Me.LabelTech.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTech.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelTech.Location = New System.Drawing.Point(3, 209)
        Me.LabelTech.Name = "LabelTech"
        Me.LabelTech.Size = New System.Drawing.Size(45, 19)
        Me.LabelTech.TabIndex = 8
        Me.LabelTech.Text = "Tech:"
        Me.LabelTech.Visible = False
        '
        'LabelSerial
        '
        Me.LabelSerial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelSerial.AutoSize = True
        Me.LabelSerial.BackColor = System.Drawing.Color.Transparent
        Me.LabelSerial.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSerial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSerial.Location = New System.Drawing.Point(3, 18)
        Me.LabelSerial.Name = "LabelSerial"
        Me.LabelSerial.Size = New System.Drawing.Size(52, 19)
        Me.LabelSerial.TabIndex = 5
        Me.LabelSerial.Text = "Serial:"
        '
        'LabelPartyName
        '
        Me.LabelPartyName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelPartyName.AutoSize = True
        Me.LabelPartyName.BackColor = System.Drawing.Color.Transparent
        Me.LabelPartyName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPartyName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelPartyName.Location = New System.Drawing.Point(3, 64)
        Me.LabelPartyName.Name = "LabelPartyName"
        Me.LabelPartyName.Size = New System.Drawing.Size(86, 19)
        Me.LabelPartyName.TabIndex = 3
        Me.LabelPartyName.Text = "Part Name:"
        '
        'LabelDate
        '
        Me.LabelDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDate.AutoSize = True
        Me.LabelDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelDate.Location = New System.Drawing.Point(3, 246)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(45, 19)
        Me.LabelDate.TabIndex = 10
        Me.LabelDate.Text = "Date:"
        Me.LabelDate.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(101, 240)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(246, 32)
        Me.DateTimePicker1.TabIndex = 11
        Me.DateTimePicker1.Visible = False
        '
        'LabelDestination
        '
        Me.LabelDestination.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelDestination.AutoSize = True
        Me.LabelDestination.BackColor = System.Drawing.Color.Transparent
        Me.LabelDestination.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDestination.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelDestination.Location = New System.Drawing.Point(3, 173)
        Me.LabelDestination.Name = "LabelDestination"
        Me.LabelDestination.Size = New System.Drawing.Size(92, 19)
        Me.LabelDestination.TabIndex = 12
        Me.LabelDestination.Text = "Destination:"
        Me.LabelDestination.Visible = False
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSearch.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSearch.BackgroundImage = CType(resources.GetObject("ButtonSearch.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearch.ForeColor = System.Drawing.Color.Gray
        Me.ButtonSearch.Location = New System.Drawing.Point(353, 3)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.TableLayoutPanel2.SetRowSpan(Me.ButtonSearch, 2)
        Me.ButtonSearch.Size = New System.Drawing.Size(76, 86)
        Me.ButtonSearch.TabIndex = 14
        Me.ButtonSearch.UseVisualStyleBackColor = False
        '
        'TextBoxComments
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.TextBoxComments, 2)
        Me.TextBoxComments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxComments.Location = New System.Drawing.Point(101, 278)
        Me.TextBoxComments.Multiline = True
        Me.TextBoxComments.Name = "TextBoxComments"
        Me.TextBoxComments.Size = New System.Drawing.Size(328, 44)
        Me.TextBoxComments.TabIndex = 15
        Me.TextBoxComments.Visible = False
        '
        'ComboBoxPart
        '
        Me.ComboBoxPart.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPart.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPart.FormattingEnabled = True
        Me.ComboBoxPart.Location = New System.Drawing.Point(101, 59)
        Me.ComboBoxPart.Name = "ComboBoxPart"
        Me.ComboBoxPart.Size = New System.Drawing.Size(246, 30)
        Me.ComboBoxPart.TabIndex = 16
        '
        'ComboBoxTech
        '
        Me.ComboBoxTech.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxTech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTech.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTech.FormattingEnabled = True
        Me.ComboBoxTech.Location = New System.Drawing.Point(101, 204)
        Me.ComboBoxTech.Name = "ComboBoxTech"
        Me.ComboBoxTech.Size = New System.Drawing.Size(246, 30)
        Me.ComboBoxTech.TabIndex = 17
        Me.ComboBoxTech.Visible = False
        '
        'ComboBoxDestination
        '
        Me.ComboBoxDestination.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDestination.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDestination.FormattingEnabled = True
        Me.ComboBoxDestination.Location = New System.Drawing.Point(101, 168)
        Me.ComboBoxDestination.Name = "ComboBoxDestination"
        Me.ComboBoxDestination.Size = New System.Drawing.Size(246, 30)
        Me.ComboBoxDestination.TabIndex = 18
        Me.ComboBoxDestination.Visible = False
        '
        'TextBoxSerial
        '
        Me.TextBoxSerial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSerial.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSerial.Location = New System.Drawing.Point(101, 3)
        Me.TextBoxSerial.Multiline = True
        Me.TextBoxSerial.Name = "TextBoxSerial"
        Me.TextBoxSerial.Size = New System.Drawing.Size(246, 50)
        Me.TextBoxSerial.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonRefresh, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 500)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(438, 98)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSave.BackgroundImage = CType(resources.GetObject("ButtonSave.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSave.ForeColor = System.Drawing.Color.Silver
        Me.ButtonSave.Location = New System.Drawing.Point(3, 3)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(213, 92)
        Me.ButtonSave.TabIndex = 0
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRefresh.BackgroundImage = CType(resources.GetObject("ButtonRefresh.BackgroundImage"), System.Drawing.Image)
        Me.ButtonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonRefresh.Location = New System.Drawing.Point(222, 3)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(213, 92)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.Location = New System.Drawing.Point(447, 36)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(525, 566)
        Me.DataGridView1.TabIndex = 1
        '
        'LabelDataGrid
        '
        Me.LabelDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDataGrid.AutoSize = True
        Me.LabelDataGrid.BackColor = System.Drawing.Color.Transparent
        Me.LabelDataGrid.Font = New System.Drawing.Font("Cambria", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDataGrid.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LabelDataGrid.Location = New System.Drawing.Point(450, 1)
        Me.LabelDataGrid.Name = "LabelDataGrid"
        Me.LabelDataGrid.Size = New System.Drawing.Size(228, 32)
        Me.LabelDataGrid.TabIndex = 2
        Me.LabelDataGrid.Text = "Overall Inventory"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(972, 602)
        Me.Controls.Add(Me.LabelDataGrid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management System created by: Christopher Gill"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonSave As Button
    Friend WithEvents LabelPartyName As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBoxSerial As TextBox
    Friend WithEvents LabelSerial As Label
    Friend WithEvents RadioButtonBad As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButtonGood As RadioButton
    Friend WithEvents LabelTech As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LabelDestination As Label
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButtonInsert As RadioButton
    Friend WithEvents RadioButtonOutgoing As RadioButton
    Friend WithEvents LabelCondition As Label
    Friend WithEvents LabelComments As Label
    Friend WithEvents TextBoxComments As TextBox
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ComboBoxPart As ComboBox
    Friend WithEvents ComboBoxTech As ComboBox
    Friend WithEvents ComboBoxDestination As ComboBox
    Friend WithEvents LabelDataGrid As Label
End Class
