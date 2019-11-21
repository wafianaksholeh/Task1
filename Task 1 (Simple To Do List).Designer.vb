<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblTasksCount = New System.Windows.Forms.ToolStripLabel()
        Me.buttonadd = New System.Windows.Forms.ToolStripButton()
        Me.AddeachTask = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.buttonedit = New System.Windows.Forms.ToolStripButton()
        Me.buttonremove = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.btnSaveTaskList = New System.Windows.Forms.ToolStripButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbltaskcount = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTasksCount, Me.buttonadd, Me.AddeachTask, Me.ToolStripSeparator1, Me.buttonedit, Me.buttonremove, Me.ToolStripButton4, Me.btnSaveTaskList})
        Me.ToolStrip1.Location = New System.Drawing.Point(307, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(97, 455)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblTasksCount
        '
        Me.lblTasksCount.Name = "lblTasksCount"
        Me.lblTasksCount.Size = New System.Drawing.Size(94, 0)
        '
        'buttonadd
        '
        Me.buttonadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buttonadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonadd.Image = CType(resources.GetObject("buttonadd.Image"), System.Drawing.Image)
        Me.buttonadd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonadd.Name = "buttonadd"
        Me.buttonadd.Size = New System.Drawing.Size(94, 20)
        Me.buttonadd.Text = "Add button"
        '
        'AddeachTask
        '
        Me.AddeachTask.Name = "AddeachTask"
        Me.AddeachTask.Size = New System.Drawing.Size(92, 23)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(94, 6)
        '
        'buttonedit
        '
        Me.buttonedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonedit.Image = CType(resources.GetObject("buttonedit.Image"), System.Drawing.Image)
        Me.buttonedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonedit.Name = "buttonedit"
        Me.buttonedit.Size = New System.Drawing.Size(94, 20)
        Me.buttonedit.Text = "edit button"
        '
        'buttonremove
        '
        Me.buttonremove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonremove.Image = CType(resources.GetObject("buttonremove.Image"), System.Drawing.Image)
        Me.buttonremove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonremove.Name = "buttonremove"
        Me.buttonremove.Size = New System.Drawing.Size(94, 20)
        Me.buttonremove.Text = "button remove"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(94, 20)
        Me.ToolStripButton4.Text = "btnUpdate"
        '
        'btnSaveTaskList
        '
        Me.btnSaveTaskList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveTaskList.Image = CType(resources.GetObject("btnSaveTaskList.Image"), System.Drawing.Image)
        Me.btnSaveTaskList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveTaskList.Name = "btnSaveTaskList"
        Me.btnSaveTaskList.Size = New System.Drawing.Size(94, 20)
        Me.btnSaveTaskList.Text = "ToolStripButton1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 394)
        Me.ListBox1.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'lbltaskcount
        '
        Me.lbltaskcount.AutoSize = True
        Me.lbltaskcount.Location = New System.Drawing.Point(4, 429)
        Me.lbltaskcount.Name = "lbltaskcount"
        Me.lbltaskcount.Size = New System.Drawing.Size(58, 13)
        Me.lbltaskcount.TabIndex = 4
        Me.lbltaskcount.Text = "Total Task"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 455)
        Me.Controls.Add(Me.lbltaskcount)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Simple To Do List"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTasksCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents buttonadd As System.Windows.Forms.ToolStripButton
    Friend WithEvents AddeachTask As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents buttonedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonremove As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbltaskcount As System.Windows.Forms.Label
    Friend WithEvents btnSaveTaskList As System.Windows.Forms.ToolStripButton

End Class
