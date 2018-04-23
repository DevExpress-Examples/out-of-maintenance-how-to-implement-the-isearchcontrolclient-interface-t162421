Imports Microsoft.VisualBasic
Imports System
Namespace dxExample
	Partial Public Class SearchForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SearchForm))
			Me.searchControl1 = New DevExpress.XtraEditors.SearchControl()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.memoInformation = New DevExpress.XtraEditors.MemoEdit()
			Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
			Me.txtName = New DevExpress.XtraEditors.TextEdit()
			Me.txtAge = New DevExpress.XtraEditors.TextEdit()
			Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.button = New DevExpress.XtraEditors.SimpleButton()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.searchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.memoInformation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtAge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' searchControl1
			' 
			Me.searchControl1.Location = New System.Drawing.Point(5, 24)
			Me.searchControl1.Name = "searchControl1"
			Me.searchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
			Me.searchControl1.Size = New System.Drawing.Size(190, 20)
			Me.searchControl1.TabIndex = 0
			' 
			' textEdit1
			' 
			Me.textEdit1.EditValue = "textEdit1"
			Me.textEdit1.Location = New System.Drawing.Point(229, 197)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(135, 20)
			Me.textEdit1.TabIndex = 1
			Me.textEdit1.Tag = ""
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(229, 223)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(135, 45)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.gridControl1.Location = New System.Drawing.Point(12, 69)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(200, 315)
			Me.gridControl1.TabIndex = 3
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.searchControl1)
			Me.groupControl1.Location = New System.Drawing.Point(12, 12)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(200, 51)
			Me.groupControl1.TabIndex = 4
			Me.groupControl1.Text = "Search"
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Image = (CType(resources.GetObject("labelControl1.Appearance.Image"), System.Drawing.Image))
			Me.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftBottom
			Me.labelControl1.Location = New System.Drawing.Point(254, 171)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(84, 20)
			Me.labelControl1.TabIndex = 5
			Me.labelControl1.Text = "labelControl1"
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.memoInformation)
			Me.layoutControl1.Controls.Add(Me.txtAddress)
			Me.layoutControl1.Controls.Add(Me.txtName)
			Me.layoutControl1.Controls.Add(Me.txtAge)
			Me.layoutControl1.Controls.Add(Me.txtPhone)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.layoutControl1.Location = New System.Drawing.Point(370, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(231, 396)
			Me.layoutControl1.TabIndex = 6
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' memoInformation
			' 
			Me.memoInformation.EditValue = "memoInformation"
			Me.memoInformation.Location = New System.Drawing.Point(12, 108)
			Me.memoInformation.Name = "memoInformation"
			Me.memoInformation.Size = New System.Drawing.Size(207, 276)
			Me.memoInformation.StyleController = Me.layoutControl1
			Me.memoInformation.TabIndex = 7
			' 
			' txtAddress
			' 
			Me.txtAddress.EditValue = "txtAddress"
			Me.txtAddress.Location = New System.Drawing.Point(12, 84)
			Me.txtAddress.Name = "txtAddress"
			Me.txtAddress.Size = New System.Drawing.Size(207, 20)
			Me.txtAddress.StyleController = Me.layoutControl1
			Me.txtAddress.TabIndex = 10
			' 
			' txtName
			' 
			Me.txtName.EditValue = "txtName"
			Me.txtName.Location = New System.Drawing.Point(12, 12)
			Me.txtName.Name = "txtName"
			Me.txtName.Size = New System.Drawing.Size(207, 20)
			Me.txtName.StyleController = Me.layoutControl1
			Me.txtName.TabIndex = 7
			' 
			' txtAge
			' 
			Me.txtAge.EditValue = "txtAge"
			Me.txtAge.Location = New System.Drawing.Point(12, 36)
			Me.txtAge.Name = "txtAge"
			Me.txtAge.Size = New System.Drawing.Size(207, 20)
			Me.txtAge.StyleController = Me.layoutControl1
			Me.txtAge.TabIndex = 9
			' 
			' txtPhone
			' 
			Me.txtPhone.EditValue = "txtPhone"
			Me.txtPhone.Location = New System.Drawing.Point(12, 60)
			Me.txtPhone.Name = "txtPhone"
			Me.txtPhone.Size = New System.Drawing.Size(207, 20)
			Me.txtPhone.StyleController = Me.layoutControl1
			Me.txtPhone.TabIndex = 8
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem5})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(231, 396)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.txtPhone
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 48)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(211, 24)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.txtAddress
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 72)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(211, 24)
			Me.layoutControlItem4.Text = "layoutControlItem4"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.txtName
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(211, 24)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.txtAge
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(211, 24)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.memoInformation
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 96)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(211, 280)
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' button
			' 
			Me.button.Location = New System.Drawing.Point(229, 274)
			Me.button.Name = "button"
			Me.button.Size = New System.Drawing.Size(135, 45)
			Me.button.TabIndex = 7
			Me.button.Text = "button"
			' 
			' radioGroup1
			' 
			Me.radioGroup1.EditValue = 0
			Me.radioGroup1.Location = New System.Drawing.Point(229, 12)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Contains"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Default"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Equals"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Like (Contains)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "StartsWith")})
            Me.radioGroup1.Size = New System.Drawing.Size(135, 96)
			Me.radioGroup1.TabIndex = 8
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' SearchForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(601, 396)
			Me.Controls.Add(Me.radioGroup1)
			Me.Controls.Add(Me.button)
			Me.Controls.Add(Me.layoutControl1)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.groupControl1)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.textEdit1)
			Me.Name = "SearchForm"
			Me.Text = "SearchForm"
			CType(Me.searchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.memoInformation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtAge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private searchControl1 As DevExpress.XtraEditors.SearchControl
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private memoInformation As DevExpress.XtraEditors.MemoEdit
		Private txtAddress As DevExpress.XtraEditors.TextEdit
		Private txtName As DevExpress.XtraEditors.TextEdit
		Private txtAge As DevExpress.XtraEditors.TextEdit
		Private txtPhone As DevExpress.XtraEditors.TextEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private button As DevExpress.XtraEditors.SimpleButton
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
	End Class
End Namespace