Public Class Form1

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = AddeachTask.Control
    End Sub


    Private Sub buttonadd_Click(sender As Object, e As EventArgs) Handles buttonadd.Click
        'Check if txtAddTaskBox is Null or Empty to avoid adding empty task
        If String.IsNullOrEmpty(AddeachTask.Text) Then
            MsgBox("Write your task before adding it to the Task List", vbCritical, "Empty TaskBox")
        Else
            'Add task in the Task List
            ListBox1.Items.Add(AddeachTask.Text.ToString)
            'Clear the task textbox
            AddeachTask.Clear()
            'Focus the task textbox
            AddeachTask.Focus()
            'Count Due Tasks in the Task List
            lbltaskcount.Text = "Due Tasks: " & ListBox1.Items.Count
        End If
    End Sub

    Private Sub buttonedit_Click(sender As Object, e As EventArgs) Handles buttonedit.Click
        'Declaration'
        Dim selecteditemindex As Integer = ListBox1.Items.IndexOf(ListBox1.SelectedItem)
        'Declaration'
        Dim editaskinput As String
        'Declaration'
        Dim Item As Object = ListBox1.Items.Item(selecteditemindex)
        'Declaration'
        Dim index As Integer = ListBox1.Items.IndexOf(Item)
        'Edit text in the listboxt'
        editaskinput = InputBox("Edit the Task", "Edit selected Task")
        'Removing Task in the listbox'
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        'Insert Text in the listboxt'
        ListBox1.Items.Insert(index, editaskinput)
    End Sub

    Private Sub buttonremove_Click(sender As Object, e As EventArgs) Handles buttonremove.Click
        'Declaration'
        Dim itemfordeletion
        'Selected item listbox'
        itemfordeletion = ListBox1.SelectedItem
        'Removing Task in the listbox'
        ListBox1.Items.Remove(itemfordeletion)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnSaveTaskList_Click(sender As Object, e As EventArgs) Handles btnSaveTaskList.Click
        'im sorry sir, because save button its not ready sir '
    End Sub
End Class
