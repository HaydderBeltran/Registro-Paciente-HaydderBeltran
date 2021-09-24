using System;

namespace Modelodelparcial
{
	class Program
	{

		struct DATOS
		{
			public int CEDULA;
			public string NOMBRE;
			public int TEL;
			public char SEXO;
			public string DIAGNOSTICO;

		}

		static DATOS[] Pacientes = new DATOS[100];
		static int NRO = 0;




		
		static void CONSULTA_SELECTIVA() { }
		static void ELIMINAR() { }




		static void Main(string[] args)
		{


			char OP = 'S';
			int TIPO;
			while (OP == 'S')
			{
				TIPO = MENU();
				switch (TIPO)
				{
					case 1:
						CREAR();

						break;
					case 2:
						CONSULTA_LISTADO();

						break;
					case 3:
						CONSULTA_SELECTIVA();

						break;
					case 4:
						ELIMINAR();

						break;
					case 5:
						MODIFICAR();

						break;
					case 6:
						OP = 'N';
						break;

				}
			}

		}

		static int MENU()
		{
			int OPCION, CED;
			Console.Clear();
			System.Console.SetCursorPosition(29, 6);
			Console.WriteLine("REGISTRO MEDICO");
			System.Console.SetCursorPosition(32, 8);
			Console.WriteLine("CAPTURA DE DATOS");
			System.Console.SetCursorPosition(25, 10);
			Console.WriteLine("                                                  ");
			System.Console.SetCursorPosition(29, 11);
			Console.WriteLine("1. CAPTURA DE DATOS");
			System.Console.SetCursorPosition(29, 12);
			Console.WriteLine("2. CONSULTA  TIPO LISTADO");
			System.Console.SetCursorPosition(29, 13);
			Console.WriteLine("3. CONSULTA SELECTIVA");
			System.Console.SetCursorPosition(29, 14);
			Console.WriteLine("4. ELIMINAR ");
			System.Console.SetCursorPosition(29, 15);
			Console.WriteLine("5. MODIFICAR ");
			System.Console.SetCursorPosition(29, 17);
			Console.WriteLine("6. SALIR");

			do
			{
				System.Console.SetCursorPosition(22, 20);
				Console.WriteLine("SELECIONE UNA DE LAS ALTERNATIVAS : ");
				System.Console.SetCursorPosition(57, 20); OPCION = int.Parse(Console.ReadLine());
				System.Console.SetCursorPosition(30, 22);
				Console.WriteLine("VALOR FUERA DE RANGO");
			} while ((OPCION < 1) || (OPCION > 6));
			System.Console.SetCursorPosition(30, 22);
			Console.WriteLine("                          ");
			return OPCION;

		}
		static void CREAR()
		{
			char OP = 'S';

			while ((OP == 'S') && (NRO < 100))
			{
				Console.Clear();
				System.Console.SetCursorPosition(15, 6); Console.WriteLine("REGISTRAR PACIENTE");
				System.Console.SetCursorPosition(20, 11); Console.WriteLine("CEDULA   : ");
				System.Console.SetCursorPosition(20, 13); Console.WriteLine("NOMBRE   : ");
				System.Console.SetCursorPosition(20, 15); Console.WriteLine("TELEFONO : ");
				System.Console.SetCursorPosition(20, 17); Console.WriteLine("SEXO     : ");
				System.Console.SetCursorPosition(20, 19); Console.WriteLine("DIAGNOSTICO    : ");
				do
				{
					System.Console.SetCursorPosition(31, 11);
					Pacientes[NRO].CEDULA = int.Parse(Console.ReadLine());

					System.Console.SetCursorPosition(20, 24); Console.WriteLine("Error .... valor fuera de rango ");
				} while (Pacientes[NRO].CEDULA < 0);
				System.Console.SetCursorPosition(20, 24); Console.WriteLine("                                   ");

				System.Console.SetCursorPosition(31, 13);
				Pacientes[NRO].NOMBRE = Console.ReadLine();

				System.Console.SetCursorPosition(31, 13); Console.WriteLine((Pacientes[NRO].NOMBRE));
				do
				{
					System.Console.SetCursorPosition(31, 15);
					Pacientes[NRO].TEL = int.Parse(Console.ReadLine());

					System.Console.SetCursorPosition(20, 24); Console.WriteLine("Error .... valor fuera de rango ");
				} while (Pacientes[NRO].TEL < 0);
				System.Console.SetCursorPosition(20, 24); Console.WriteLine("                                   ");
				do
				{
					System.Console.SetCursorPosition(31, 17); Console.WriteLine(" ");
					System.Console.SetCursorPosition(20, 24); Console.WriteLine(" Digite : M-> Masculino o F -> Femenino ");
					System.Console.SetCursorPosition(31, 17); Pacientes[NRO].SEXO = char.Parse(Console.ReadLine());
					Pacientes[NRO].SEXO = (Pacientes[NRO].SEXO);
				} while ((Pacientes[NRO].SEXO != 'M') && (Pacientes[NRO].SEXO != 'F'));
				System.Console.SetCursorPosition(20, 24); Console.WriteLine("                                              ");

				System.Console.SetCursorPosition(37, 19);
				Pacientes[NRO].DIAGNOSTICO = Console.ReadLine();

				NRO = NRO + 1;
				do
				{
					System.Console.SetCursorPosition(28, 23); Console.WriteLine("DESEA CONTINUAR - S/N - ");
					System.Console.SetCursorPosition(52, 23); OP = char.Parse(Console.ReadLine());

				} while ((OP != 'S') && (OP != 'N'));
			}
		}

    }
}



