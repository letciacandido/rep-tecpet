Imports System.Globalization

Module Module1
    Public diretorio, SQL, resp, ID_func As String
    Public aux_id, nome_func As String
    Public cpf As String
    Public cont As Integer
    Public isUpdating As Boolean = False
    Public rs As New ADODB.Recordset
    Public db As New ADODB.Connection

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-2LB3R17;Initial Catalog=tecpet;User ID=sa;Password=V%S79^69&Ka3")
            'db.Open("Provider=SQLOLEDB;Data Source=rogjr;Initial Catalog=tecpet;User ID=sa;Password=5R$PQ6N58Ru3!ym*#J4#5e")
        Catch
            MsgBox("Erro de conexão", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Sub fechar_banco()
        db.Close()
    End Sub

    Function RemoveMascara(valorComMascara As String) As Double
        Dim valorSemMascara As String

        valorSemMascara = valorComMascara.Replace("R$", "").Replace(".", "").Replace(",", "")

        If valorSemMascara = "" Then

            Return 0

        Else

            Dim valorDouble As Double = Double.Parse(valorSemMascara, CultureInfo.InvariantCulture)
            Return valorDouble / 100

        End If


    End Function

    Function AdicionaMascara(ValorSemMascara As String) As String

        If ValorSemMascara = "" Then
            Return ""

        Else

            Dim ValorComMascara As String = Format(CDbl(ValorSemMascara), "R$#,##0.00")
            Return ValorComMascara

        End If

    End Function
End Module
