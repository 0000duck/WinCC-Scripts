Sub ShowNameOfFirstSelectedObject()
'VBA339
    'Select all objects in the picture:
    ActiveDocument.Selection.SelectAll
    'Get the name of the first object of the selection:
    MsgBox ActiveDocument.Selection(1).ObjectName
End Sub