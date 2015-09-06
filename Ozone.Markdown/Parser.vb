Imports com.github.rjeschke.txtmark

Public Class Parser
    'Wrapper developed by Ryan O'Day


    ''' <summary>
    ''' Converts the entered markdown to Html
    ''' </summary>
    ''' <param name="markdown">The markdown text to be converted</param>
    ''' <returns>A string containing the Html equivalent</returns>
    ''' <remarks></remarks>
    Public Shared Function ParseMarkdown(ByVal markdown As String) As String
        Return Processor.process(markdown)
    End Function

End Class
