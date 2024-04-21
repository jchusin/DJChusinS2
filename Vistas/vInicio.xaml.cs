namespace DJChusinS2.Vistas;

public partial class vInicio : ContentPage
{
    public vInicio(string usuario)
    {
        InitializeComponent();
        lblusuario.Text = "Usuario conectado: " + usuario;
    }

    private void txtSeguimiento_TextChanged(object sender, TextChangedEventArgs e)
    {

        if (!string.IsNullOrEmpty(txtSeguimiento.Text))
        {
            string valorIngresado = txtSeguimiento.Text;

            if (double.TryParse(valorIngresado, out double valorNumerico))
            {
                if (valorNumerico >= 0 && valorNumerico <= 10)
                {
                    // El valor está dentro del rango permitido
                }
                else
                {
                    // El valor está fuera del rango permitido, se muestra un mensaje de error
                    DisplayAlert("Error", "El valor debe estar entre 0,1 y 10. Solo utilizar coma(,)", "Aceptar");
                    txtSeguimiento.Text = string.Empty;
                }
            }
            else
            {
                // El valor ingresado no es numérico, se muestra un mensaje de error
                DisplayAlert("Error", "Debe ingresar un valor numérico válido", "Aceptar");
                txtSeguimiento.Text = string.Empty;
            }
        }

        CalcularNotaParcial();
    }

    private void txtExamen_TextChanged(object sender, TextChangedEventArgs e)
    {

        if (!string.IsNullOrEmpty(txtExamen.Text))
        {
            string valorIngresado = txtExamen.Text;

            if (double.TryParse(valorIngresado, out double valorNumerico))
            {
                if (valorNumerico >= 0 && valorNumerico <= 10)
                {
                    // El valor está dentro del rango permitido
                }
                else
                {
                    // El valor está fuera del rango permitido, se muestra un mensaje de error
                    DisplayAlert("Error", "El valor debe estar entre 0,1 y 10. Solo utilizar coma(,)", "Aceptar");
                    txtExamen.Text = string.Empty;
                }
            }
            else
            {
                // El valor ingresado no es numérico, se muestra un mensaje de error
                DisplayAlert("Error", "Debe ingresar un valor numérico válido", "Aceptar");
                txtExamen.Text = string.Empty;
            }
        }
        CalcularNotaParcial();
    }

    private void CalcularNotaParcial()
    {
        if (!string.IsNullOrEmpty(txtSeguimiento.Text) && !string.IsNullOrEmpty(txtExamen.Text))
        {
            if (double.TryParse(txtSeguimiento.Text, out double notaSeguimiento) &&
                double.TryParse(txtExamen.Text, out double notaExamen))
            {
                // Realizar los cálculos según las reglas especificadas
                double notaFinal = (notaSeguimiento * 0.3) + (notaExamen * 0.2);

                // Actualizar el valor del cuadro de texto txtNota
                txtNota.Text = notaFinal.ToString("N2"); // Mostrar el resultado con dos decimales
            }
        }
        else
        {
            // Si alguno de los cuadros de texto está vacío, dejar txtNota vacío también
            txtNota.Text = string.Empty;
        }
    }

    private void txtExamen2_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrEmpty(txtExamen2.Text))
        {
            string valorIngresado = txtExamen2.Text;

            if (double.TryParse(valorIngresado, out double valorNumerico))
            {
                if (valorNumerico >= 0 && valorNumerico <= 10)
                {
                    // El valor está dentro del rango permitido
                }
                else
                {
                    // El valor está fuera del rango permitido, se muestra un mensaje de error
                    DisplayAlert("Error", "El valor debe estar entre 0,1 y 10. Solo utilizar coma(,)", "Aceptar");
                    txtExamen2.Text = string.Empty;
                }
            }
            else
            {
                // El valor ingresado no es numérico, se muestra un mensaje de error
                DisplayAlert("Error", "Debe ingresar un valor numérico válido", "Aceptar");
                txtExamen2.Text = string.Empty;
            }
        }
        CalcularNotaParcial2();
    }

    private void txtSeguimiento2_TextChanged(object sender, TextChangedEventArgs e)
    {

        if (!string.IsNullOrEmpty(txtSeguimiento2.Text))
        {
            string valorIngresado = txtSeguimiento2.Text;

            if (double.TryParse(valorIngresado, out double valorNumerico))
            {
                if (valorNumerico >= 0 && valorNumerico <= 10)
                {
                    // El valor está dentro del rango permitido
                }
                else
                {
                    // El valor está fuera del rango permitido, se muestra un mensaje de error
                    DisplayAlert("Error", "El valor debe estar entre 0,1 y 10. Solo utilizar coma(,)", "Aceptar");
                    txtSeguimiento2.Text = string.Empty;
                }
            }
            else
            {
                // El valor ingresado no es numérico, se muestra un mensaje de error
                DisplayAlert("Error", "Debe ingresar un valor numérico válido", "Aceptar");
                txtSeguimiento2.Text = string.Empty;
            }
        }

        CalcularNotaParcial2();

    }

    private void CalcularNotaParcial2()
    {
        if (!string.IsNullOrEmpty(txtSeguimiento2.Text) && !string.IsNullOrEmpty(txtExamen2.Text))
        {
            if (double.TryParse(txtSeguimiento2.Text, out double notaSeguimiento) &&
                double.TryParse(txtExamen2.Text, out double notaExamen))
            {
                // Realizar los cálculos según las reglas especificadas
                double notaFinal = (notaSeguimiento * 0.3) + (notaExamen * 0.2);

                // Actualizar el valor del cuadro de texto txtNota
                txtNota2.Text = notaFinal.ToString("N2"); // Mostrar el resultado con dos decimales
            }
        }
        else
        {
            // Si alguno de los cuadros de texto está vacío, dejar txtNota vacío también
            txtNota2.Text = string.Empty;
        }
    }

    private void btnCalculo_Clicked(object sender, EventArgs e)
    {

        // Obtener el nombre del estudiante seleccionado en el Picker pkestudiantes
        string nombreEstudiante = pkEstudiantes.SelectedItem?.ToString();

        // Obtener la nota del primer cuadro de texto txtNota
        double nota1;
        bool nota1Parsed = double.TryParse(txtNota.Text, out nota1);

        // Obtener la nota del segundo cuadro de texto txtNota2
        double nota2;
        bool nota2Parsed = double.TryParse(txtNota2.Text, out nota2);

        // Calcular la suma de las notas
        double notaFinal = nota1 + nota2;

        txtNotaf.Text = notaFinal.ToString();

        // Determinar el estado de la nota
        string estadoNota = string.Empty;
        if (nota1Parsed && nota2Parsed)
        {
            if (notaFinal > 1 && notaFinal < 6)
            {
                estadoNota = "REPROBADO";
            }
            else if (notaFinal >= 6 && notaFinal <= 6.9)
            {
                estadoNota = "COMPLEMENTARIO";
            }
            else if (notaFinal >= 7)
            {
                estadoNota = "APROBADO";
            }
        }

        // Obtener la fecha seleccionada en el DatePicker dpfecha
        DateTime fecha = dpFecha.Date;

        // Construir el mensaje
        string mensaje = $"Estudiante: {nombreEstudiante}\n" +
                         $"Nota 1: {txtNota.Text}\n" +
                         $"Nota 2: {txtNota2.Text}\n" +
                         $"Nota Final: {notaFinal}\n" +
                         $"Estado: {estadoNota}\n" +
                         $"Fecha: {fecha.ToShortDateString()}";

        // Mostrar el mensaje en pantalla
        DisplayAlert("Resultado", mensaje, "OK");
    }

}

    