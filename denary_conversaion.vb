Dim denary As Integer
Dim strBinary As String 

strBinary = InputBox(“A binary number”)

strBinary = StrReverse(strBinary) 

For loopcounter = 0 to (Len(strBinary) - 1)
	If Mid(strBinary, (loopcounter + 1), 1) = “1” Then
		Denary += 2 * loopcounter
	End if
Next

MsgBox(“The denary value is ” & denary)
