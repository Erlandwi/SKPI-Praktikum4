<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Txtteks = New TextBox()
        Txtjumlah = New TextBox()
        Listbox1 = New ListBox()
        Bproses = New Button()
        Bclear = New Button()
        Bkeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(125, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 0
        Label1.Text = "Tulisan Teks"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(125, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 15)
        Label2.TabIndex = 1
        Label2.Text = "Jumlah Pengulangan"
        ' 
        ' Txtteks
        ' 
        Txtteks.Location = New Point(266, 44)
        Txtteks.Name = "Txtteks"
        Txtteks.Size = New Size(277, 23)
        Txtteks.TabIndex = 2
        ' 
        ' Txtjumlah
        ' 
        Txtjumlah.Location = New Point(266, 84)
        Txtjumlah.Name = "Txtjumlah"
        Txtjumlah.Size = New Size(100, 23)
        Txtjumlah.TabIndex = 3
        ' 
        ' Listbox1
        ' 
        Listbox1.FormattingEnabled = True
        Listbox1.ItemHeight = 15
        Listbox1.Location = New Point(125, 169)
        Listbox1.Name = "Listbox1"
        Listbox1.Size = New Size(418, 109)
        Listbox1.TabIndex = 4
        ' 
        ' Bproses
        ' 
        Bproses.BackColor = SystemColors.ActiveCaption
        Bproses.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bproses.Location = New Point(125, 130)
        Bproses.Name = "Bproses"
        Bproses.Size = New Size(418, 33)
        Bproses.TabIndex = 5
        Bproses.Text = "Proses"
        Bproses.UseVisualStyleBackColor = False
        ' 
        ' Bclear
        ' 
        Bclear.BackColor = SystemColors.ActiveCaption
        Bclear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bclear.Location = New Point(125, 305)
        Bclear.Name = "Bclear"
        Bclear.Size = New Size(153, 40)
        Bclear.TabIndex = 6
        Bclear.Text = "Clear"
        Bclear.UseVisualStyleBackColor = False
        ' 
        ' Bkeluar
        ' 
        Bkeluar.BackColor = SystemColors.ActiveCaption
        Bkeluar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bkeluar.Location = New Point(379, 305)
        Bkeluar.Name = "Bkeluar"
        Bkeluar.Size = New Size(164, 40)
        Bkeluar.TabIndex = 7
        Bkeluar.Text = "Keluar"
        Bkeluar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Bkeluar)
        Controls.Add(Bclear)
        Controls.Add(Bproses)
        Controls.Add(Listbox1)
        Controls.Add(Txtjumlah)
        Controls.Add(Txtteks)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Frmpengulanganteks"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtteks As TextBox
    Friend WithEvents Txtjumlah As TextBox
    Friend WithEvents Listbox1 As ListBox
    Friend WithEvents Bproses As Button
    Friend WithEvents Bclear As Button
    Friend WithEvents Bkeluar As Button

End Class
