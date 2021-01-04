using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class User
    {
		private int age;
		private string login;
		private string mail;

		public int Age
		{
			get
			{
				return age;
			}

			set
			{
				if (value < 18)
				{
					Console.WriteLine("Возраст должен быть не меньше 18");
				}
				else
				{
					age = value;
				}
			}
		}

		public string Login
		{
			get
			{
				return login;
			}

			set
			{
				if (value.Length < 3)
				{
					Console.WriteLine("Длина логина должна быть не менее 3 символов");
				}
				else
				{
					login = value;
				}
			}
		}

		public string Mail
		{
			get
			{
				return mail;
			}

			set
			{
				if (value.Contains("@"))
				{
					mail = value;
				}
				else
				{
					Console.WriteLine("Поле почты должно содержать знак @");
				}
			}
		}
	}
}
