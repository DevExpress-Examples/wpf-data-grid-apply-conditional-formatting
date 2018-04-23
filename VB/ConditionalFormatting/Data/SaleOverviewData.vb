Imports Microsoft.VisualBasic
Imports System.ComponentModel.DataAnnotations

Namespace ConditionalFormatting
	Public Class SaleOverviewData
		Public Sub New(ByVal state As String, ByVal sales As Double, ByVal salesVsTarget As Double, ByVal profit As Double, ByVal customersSatisfaction As Double, ByVal markerShare As Double)
			Me.State = state
			Me.Sales = sales
			Me.Profit = profit
			Me.SalesVsTarget = salesVsTarget
			Me.CustomersSatisfaction = customersSatisfaction
			Me.MarketShare = markerShare
		End Sub
		Private privateState As String
		Public Property State() As String
			Get
				Return privateState
			End Get
			Set(ByVal value As String)
				privateState = value
			End Set
		End Property

		Private privateSales As Double
		<DisplayFormat(DataFormatString := "#,##0,,M")> _
		Public Property Sales() As Double
			Get
				Return privateSales
			End Get
			Set(ByVal value As Double)
				privateSales = value
			End Set
		End Property

		Private privateProfit As Double
		<DisplayFormat(DataFormatString := "#,##0,,M")> _
		Public Property Profit() As Double
			Get
				Return privateProfit
			End Get
			Set(ByVal value As Double)
				privateProfit = value
			End Set
		End Property

		Private privateSalesVsTarget As Double
		<DisplayFormat(DataFormatString := "p", ApplyFormatInEditMode := True), Display(Name := "Sales vs Target")> _
		Public Property SalesVsTarget() As Double
			Get
				Return privateSalesVsTarget
			End Get
			Set(ByVal value As Double)
				privateSalesVsTarget = value
			End Set
		End Property

		Private privateMarketShare As Double
		<DisplayFormat(DataFormatString := "p0", ApplyFormatInEditMode := True)> _
		Public Property MarketShare() As Double
			Get
				Return privateMarketShare
			End Get
			Set(ByVal value As Double)
				privateMarketShare = value
			End Set
		End Property

		Private privateCustomersSatisfaction As Double
		<Display(Name := "Cust Satisfaction")> _
		Public Property CustomersSatisfaction() As Double
			Get
				Return privateCustomersSatisfaction
			End Get
			Set(ByVal value As Double)
				privateCustomersSatisfaction = value
			End Set
		End Property

	End Class
End Namespace
