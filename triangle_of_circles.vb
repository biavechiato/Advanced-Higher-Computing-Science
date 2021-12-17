Imports System.Drawing

Dim myCanvas As Graphics = Me.CreateGraphics()
Dim myPen = New Pen(Color.Red, 5)
Dim input As Integer

input = InputBox("An integer") 

'' main program
For y_value = 1 to input
	For x_value = 1 to y_value
		myCanvas.drawEllipse(myPen, 20*x_value, 20*y_value, 10, 10)
	Next	
Next

'' extension
Dim x_coordinate As Single

For y_value = 1 to input
	'' 20 times the number of circles plus one so we have a margin of 20
	'' take away the number of circles in that row and divide it by two
	x_coordinate = 20 * (input + 1) - 20 * y_value / 2 
	For x_value = 0 to (y_value - 1)
		'' add 20 times the current circle so x-coordinate of the last circle is increased by 20
		myCanvas.drawEllipse(myPen, x_coordinate + 20 * x_value, 20*y_value, 10, 10)
	Next	
Next
