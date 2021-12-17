Dim denary As Integer
Dim strBinary As String  = “”
Dim counter As Integer = 7
Dim value As Integer = 0

denary = InputBox(“A denary number”)
array = 255

Do 
	Counter2 += 1
  Array += 2 ^ counter2
Loop while array < denary

Do
	If (2 ^ counter) < denary And value + (2 ^ counter) <= denary Then
		value += (2 ^ counter)
		strBinary &= “1”
	Else
		strBinary &= “0”
	End if
	counter -= 1
Loop while value <> denary And counter >= 0

If Len(strBinary) < 8 Then
	For loopcounter = 1 to (8 – Len(strBinary))
		strBinary &= “0”
	Next
End If

MsgBox(“The binary value is ” & strBinary)
