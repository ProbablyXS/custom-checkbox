'////////////////////////////////////////// BY VECR TEAM //////////////////////////////////////////

'//////////////////////////////////////////              //////////////////////////////////////////

Public Class CustomCheckBox

    Dim speed As Integer = 4

    Public Event Ovalclick()

    Public Sub Ovalclick_Click() Handles Button1.Click

        RaiseEvent Ovalclick()

    End Sub

    Dim ovalresultasPicturetrue As Image
    Property A_ovalimagetrue() As Image

        Get

            A_ovalimagetrue = ovalresultasPicturetrue

        End Get

        Set(value As Image)


            Button1.BackgroundImage = value
            ovalresultasPicturetrue = value

        End Set
    End Property

    Dim ovalresultasPicturefalse As Image

    Public Property B_ovalimagefalse() As Image
        Get

            B_ovalimagefalse = ovalresultasPicturefalse

        End Get

        Set(value As Image)


            Button1.BackgroundImage = value
            ovalresultasPicturefalse = value

        End Set
    End Property

    Dim resultasFalse As Color
    Property ovalcolorFalse() As Color

        Get

            ovalcolorFalse = resultasFalse

        End Get

        Set(value As Color)


            Button1.BackColor = value
            resultasFalse = value

        End Set

    End Property

    Dim resultasTrue As Color
    Property ovalcolorTrue() As Color

        Get

            ovalcolorTrue = resultasTrue

        End Get

        Set(value As Color)

            Button1.BackColor = value
            resultasTrue = value

        End Set
    End Property

    Public Property ovalLocation As Point

        Get

            Return Button1.Location

        End Get

        Set(value As Point)

            Button1.Location = value

        End Set
    End Property


    Dim RectangleresultasTrue As Color
    Property A_RectangleovalcolorTrue() As Color

        Get

            A_RectangleovalcolorTrue = RectangleresultasTrue

        End Get

        Set(value As Color)

            Button2.BackColor = value
            RectangleresultasTrue = value

        End Set
    End Property


    Dim RectangleresultasFalse As Color
    Property B_RectangleovalcolorFalse() As Color

        Get

            B_RectangleovalcolorFalse = RectangleresultasFalse

        End Get

        Set(value As Color)

            Button2.BackColor = value
            RectangleresultasFalse = value

        End Set
    End Property

    Dim RectangleborderresultasTrue As Color
    Property RectangleborderovalcolorTrue() As Color

        Get

            RectangleborderovalcolorTrue = RectangleborderresultasTrue

        End Get

        Set(value As Color)

            Button2.FlatAppearance.BorderColor = value
            RectangleborderresultasTrue = value

        End Set
    End Property

    Dim Ovalitsrespond As Boolean
    Public Property Ovalchecked As Boolean

        Get

            Return Ovalitsrespond

        End Get

        Set(value As Boolean)

            If (value = True) Then

                Ovalitsrespond = True
                Button1.Left = 36
                Label1.Left = 10
                Label1.Text = "ON"
                'Button1.BackColor = resultasTrue
                'Button1.BackgroundImage = ovalresultasPicturetrue
                'RectangleShape1.BackColor = RectangleresultasTrue

            ElseIf (value = False) Then

                Ovalitsrespond = False
                Button1.Left = 8
                Label1.Left = 23
                Label1.Text = "OFF"
                'Button1.BackColor = resultasFalse
                'Button1.BackgroundImage = ovalresultasPicturefalse
                'RectangleShape1.BackColor = RectangleresultasFalse

            End If

        End Set
    End Property

    Private Sub OvalShape1(sender As Object, e As EventArgs) Handles Button1.Click

        If (Button1.Left = 8) Then 'gauche

            Timer1.Start()
            Ovalitsrespond = True
            Label1.Visible = False

        End If

        If (Button1.Left = 36) Then 'droite

            Timer2.Start()
            Ovalitsrespond = False
            Label1.Visible = False

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Button1.Left <= 36 Then 'gauche

            Button1.Left += speed

        End If

        If Button1.Left = 36 Then

            'Button1.BackColor = resultasTrue
            'Button1.BackgroundImage = ovalresultasPicturetrue
            'RectangleShape1.BackColor = A_RectangleovalcolorTrue
            'Ovalchecked = True
            Label1.Left = 10
            Label1.Visible = True
            Label1.Text = "ON"
            Timer1.Stop()

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If Button1.Left >= 8 Then 'droite

            Button1.Left -= speed

        End If

        If Button1.Left = 8 Then

            'Button1.BackColor = resultasFalse
            'Button1.BackgroundImage = ovalresultasPicturefalse
            'RectangleShape1.BackColor = B_RectangleovalcolorFalse
            Ovalchecked = False
            Label1.Left = 23
            Label1.Visible = True
            Label1.Text = "OFF"
            Timer2.Stop()

        End If

    End Sub

    Dim resultasLabelColor As Color
    Property LabelColor() As Color

        Get

            LabelColor = resultasLabelColor

        End Get

        Set(value As Color)


            Label1.ForeColor = value
            resultasLabelColor = value

        End Set

    End Property

End Class
