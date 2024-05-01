﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Company.PL.ViewModels
{
	public class LoginViewModel
	{
		[Required(ErrorMessage ="Email is Required")]
		[EmailAddress(ErrorMessage ="Invalid Email")]
		public string Email {  get; set; }
		[Required(ErrorMessage = "Password is Required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}
