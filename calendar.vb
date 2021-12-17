Dim week_days() As String  = ["", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Monday", "Tuesday"]
Dim iteration As Integer = 1
Dim total_days As Integer = 0
Dim y As Integer

For current_month = 1 to 12
	Select Case current_month  
	    Case 2
				y = 28
			Case 4, 6, 9, 11
				y = 30
			Case Else
				y = 31
	End Select
	For current_day = 1 to y
			total_days += 1
			msgBox(current_day & "/" & current_month & "/2020 - " & total_days & " - " & week_days[iteration])
			iteration = If((iteration >= 7), 1, iteration+1)
	Next
Next
