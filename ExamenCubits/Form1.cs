using System.Globalization;

namespace ExamenCubits
{
    public partial class Calendario : Form
    {
        Captura captura = new Captura();
        int Mes, ano;
        
        public Calendario()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            DisplayDay();
        }
        public void DisplayDay()
        {

            DateTime now = DateTime.Now;
            Mes = now.Month;
            ano = now.Year;
            String mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            lbldate.Text = mesNombre + "  " + ano;

            //Vamos al primer día de inicio del  mes.

            DateTime inicioMes = new DateTime(ano, Mes, 1);
            //  Determinamos los dias por mes

            int dias = DateTime.DaysInMonth(ano, Mes);

            // Determianmos los dias por semana

            int diasSemanas = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            //Creamos un userControl para los dias de la semana y por dia.

            for (int i = 1; i < diasSemanas; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                ContenedorDias.Controls.Add(userControlBlank);


            }
            for (int i = 1; i <= dias; i++)
            {
                UserControlDays userDay = new UserControlDays();

                userDay.day(i);

                /*if (mesNombre == "febrero" || mesNombre == "marzo")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 4 || i == 5 || i == 11 || i == 12 || i == 18 || i == 19 || i == 25 || i == 26)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "abril" || mesNombre == "julio")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 1 || i == 2 || i == 8 || i == 9 || i == 15 || i == 16 || i == 22 || i == 23 || i == 29 || i == 30)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "mayo")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 6 || i == 7 || i == 13 || i == 14 || i == 20 || i == 21 || i == 27 || i == 28)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "junio")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 3 || i == 4 || i == 10 || i == 11 || i == 17 || i == 18 || i == 24 || i == 25)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "agosto")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 5 || i == 6 || i == 12 || i == 13 || i == 19 || i == 20 || i == 26 || i == 27)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "noviembre")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 4 || i == 5 || i == 11 || i == 12 || i == 18 || i == 19 || i == 25 || i == 26)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }*/
                if (mesNombre == "octubre" || mesNombre == "enero")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 1 || i == 7 || i == 8 || i == 14 || i == 15 || i == 21 || i == 22 || i == 28 || i == 29)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                    else if (i == 1)
                    {
                        userDay.BackColor = Color.OrangeRed;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                /*
                if (mesNombre == "septiembre" || mesNombre == "diciembre")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 2 || i == 3 || i == 9 || i == 10 || i == 16 || i == 17 || i == 23 || i == 24 || i == 30 || i == 31)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }*/
                else
                {
                    ContenedorDias.Controls.Add(userDay);
                }

                //ContenedorDias.Controls.Add(userDay);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ContenedorDias.Controls.Clear();
            Mes++;
            String mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            lbldate.Text = mesNombre + "  " + ano;
            DateTime now = DateTime.Now;
            //Vamos al primer día de inicio del  mes.

            DateTime inicioMes = new DateTime(ano, Mes, 1);
            //  Determinamos los dias por mes

            int days = DateTime.DaysInMonth(ano, Mes);

            // Determianmos los dias por semana

            int diasSemanas = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            //Creamos un userControl para los dias de la semana y por dia.

            for (int i = 1; i < diasSemanas; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                ContenedorDias.Controls.Add(userControlBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays userDay = new UserControlDays();
                userDay.day(i);
                ContenedorDias.Controls.Add(userDay);
                if (mesNombre == "febrero" || mesNombre == "marzo")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 4 || i == 5 || i == 11 || i == 12 || i == 18 || i == 19 || i == 25 || i == 26)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                    if (mesNombre == "febrero" && i == 5 || mesNombre == "marzo" && i == 18)
                    {
                        userDay.BackColor = Color.OrangeRed;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "abril" || mesNombre == "julio")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 1 || i == 2 || i == 8 || i == 9 || i == 15 || i == 16 || i == 22 || i == 23 || i == 29 || i == 30)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "mayo")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 6 || i == 7 || i == 13 || i == 14 || i == 20 || i == 21 || i == 27 || i == 28)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                    if (i == 1)
                    {
                        userDay.BackColor = Color.OrangeRed;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "junio")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 3 || i == 4 || i == 10 || i == 11 || i == 17 || i == 18 || i == 24 || i == 25)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "agosto")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 5 || i == 6 || i == 12 || i == 13 || i == 19 || i == 20 || i == 26 || i == 27)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "noviembre")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 4 || i == 5 || i == 11 || i == 12 || i == 18 || i == 19 || i == 25 || i == 26)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                    if (i == 20)
                    {
                        userDay.BackColor = Color.OrangeRed;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "octubre" || mesNombre == "enero")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 1 || i == 7 || i == 8 || i == 14 || i == 15 || i == 21 || i == 22 || i == 28 || i == 29)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "septiembre" || mesNombre == "diciembre")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 2 || i == 3 || i == 9 || i == 10 || i == 16 || i == 17 || i == 23 || i == 24 || i == 30 || i == 31)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                    if (mesNombre == "septiembre" && i == 16 || mesNombre == "diciembre" && i == 25)
                    {
                        userDay.BackColor = Color.OrangeRed;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                else
                {
                    ContenedorDias.Controls.Add(userDay);
                }
            }
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ContenedorDias.Controls.Clear();
            Mes--;
            String mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            lbldate.Text = mesNombre + "  " + ano;
            DateTime now = DateTime.Now;
            //Vamos al primer día de inicio del  mes.

            DateTime inicioMes = new DateTime(ano, Mes, 1);
            //  Determinamos los dias por mes

            int dias = DateTime.DaysInMonth(ano, Mes);

            // Determianmos los dias por semana

            int diasSemanas = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            //Creamos un userControl para los dias de la semana y por dia.

            for (int i = 1; i < diasSemanas; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                ContenedorDias.Controls.Add(userControlBlank);
            }
            for (int i = 1; i <= dias; i++)
            {
                UserControlDays userDay = new UserControlDays();
                userDay.day(i);
                ContenedorDias.Controls.Add(userDay);
                if (mesNombre == "febrero" || mesNombre == "marzo")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 4 || i == 5 || i == 11 || i == 12 || i == 18 || i == 19 || i == 25 || i == 26)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                    if (mesNombre == "febrero" && i == 5 || mesNombre == "marzo" && i == 18)
                    {
                        userDay.BackColor = Color.OrangeRed;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "abril" || mesNombre == "julio")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 1 || i == 2 || i == 8 || i == 9 || i == 15 || i == 16 || i == 22 || i == 23 || i == 29 || i == 30)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "mayo")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 6 || i == 7 || i == 13 || i == 14 || i == 20 || i == 21 || i == 27 || i == 28)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                    if (i == 1)
                    {
                        userDay.BackColor = Color.OrangeRed;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "junio")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 3 || i == 4 || i == 10 || i == 11 || i == 17 || i == 18 || i == 24 || i == 25)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "agosto")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 5 || i == 6 || i == 12 || i == 13 || i == 19 || i == 20 || i == 26 || i == 27)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "noviembre")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 4 || i == 5 || i == 11 || i == 12 || i == 18 || i == 19 || i == 25 || i == 26)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                    if (i == 20)
                    {
                        userDay.BackColor = Color.OrangeRed;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "octubre" || mesNombre == "enero")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 1 || i == 7 || i == 8 || i == 14 || i == 15 || i == 21 || i == 22 || i == 28 || i == 29)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                    if (mesNombre == "enero" && i == 1)
                    {
                        userDay.BackColor = Color.OrangeRed;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                if (mesNombre == "septiembre" || mesNombre == "diciembre")
                {
                    userDay.BackColor = Color.GreenYellow;
                    ContenedorDias.Controls.Add(userDay);

                    if (i == 2 || i == 3 || i == 9 || i == 10 || i == 16 || i == 17 || i == 23 || i == 24 || i == 30 || i == 31)
                    {
                        userDay.BackColor = Color.Yellow;
                        ContenedorDias.Controls.Add(userDay);
                    }
                    if (mesNombre == "septiembre" && i == 16 || mesNombre == "diciembre" && i == 25)
                    {
                        userDay.BackColor = Color.OrangeRed;
                        ContenedorDias.Controls.Add(userDay);
                    }
                }
                else
                {
                    ContenedorDias.Controls.Add(userDay);
                }
            }
        }
    }
}