Imports Microsoft.VisualBasic
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace dxExample
	Partial Public Class SearchForm
		Inherits Form
		Implements ISearchControlClient
		Public Sub New()
			InitializeComponent()
			searchControl1.Client = Me
			gridControl1.DataSource = GetData(10)
		End Sub

		#Region "ISearchControlClient implementation"
        Public Sub ApplyFindFilter(ByVal searchInfo As SearchInfoBase) Implements ISearchControlClient.ApplyFindFilter
            ResetPrevControls()
            If searchInfo Is Nothing OrElse searchInfo.SearchText = String.Empty Then
                Return
            End If
            Dim matchedControls As New List(Of Control)()
            Dim info As FormSearchInfo = TryCast(searchInfo, FormSearchInfo)
            FindControls(Me, matchedControls, info.SearchText, info.FilterCondition)
            For Each control As Control In matchedControls
                RemoveHandler control.Paint, AddressOf control_Paint
                AddHandler control.Paint, AddressOf control_Paint
                control.Invalidate()
            Next control
            prevControls = matchedControls
        End Sub

        Public Function CreateSearchProvider() As SearchControlProviderBase Implements ISearchControlClient.CreateSearchProvider
            Return New FormSearchProvider()
        End Function

        Public ReadOnly Property IsAttachedToSearchControl() As Boolean Implements ISearchControlClient.IsAttachedToSearchControl
            Get
                Return srchControl IsNot Nothing
            End Get
        End Property

        Public Sub SetSearchControl(ByVal searchControl As ISearchControl) Implements ISearchControlClient.SetSearchControl
            If srchControl Is searchControl Then
                Return
            End If
            srchControl = searchControl
            ApplyFindFilter(Nothing)
        End Sub
		#End Region

		Private srchControl As ISearchControl
		Private prevControls As List(Of Control)
		Private Sub ResetPrevControls()
			If prevControls IsNot Nothing Then
				For Each control As Control In prevControls
					RemoveHandler control.Paint, AddressOf control_Paint
					control.Invalidate()
				Next control
			End If
		End Sub

		Private Function CheckControlName(ByVal controlName As String, ByVal searchString As String, ByVal condition As FilterCondition) As Boolean
			Select Case condition
				Case FilterCondition.Contains
					Return controlName.Contains(searchString)
				Case FilterCondition.StartsWith
					Return controlName.StartsWith(searchString)
				Case FilterCondition.Like
					Return controlName.Contains(searchString)
				Case FilterCondition.Default
					Return controlName.Contains(searchString)
				Case FilterCondition.Equals
					Return controlName = searchString
				Case Else
					Return False
			End Select
		End Function

		Public Sub FindControls(ByVal owner As Control, ByVal list As List(Of Control), ByVal name As String, ByVal condition As FilterCondition)
			For Each c As Control In owner.Controls
				If CheckControlName(c.Name.ToLower(), name.ToLower(), condition) Then
					list.Add(c)
				End If
				If c.HasChildren Then
					FindControls(c, list, name, condition)
				End If
			Next c
		End Sub

		Private Sub control_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
			Using brush As New SolidBrush(Color.FromArgb(55, 255, 0, 0))
				e.Graphics.FillRectangle(brush, e.ClipRectangle)
			End Using
		End Sub

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			Select Case radioGroup1.SelectedIndex
				Case 2
					searchControl1.Properties.FilterCondition = FilterCondition.Equals
				Case 4
					searchControl1.Properties.FilterCondition = FilterCondition.StartsWith
				Case Else
					searchControl1.Properties.FilterCondition = FilterCondition.Contains
			End Select
		End Sub

		Private Function GetData(ByVal rows As Integer) As DataTable
			Dim dt As New DataTable()
			dt.Columns.Add("ID", GetType(Integer))
			dt.Columns.Add("Info", GetType(String))
			For i As Integer = 0 To rows - 1
				dt.Rows.Add(i, "Info" & i)
			Next i
			Return dt
		End Function
	End Class
End Namespace
