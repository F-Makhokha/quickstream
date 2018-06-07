﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.CodeFirst;

namespace DAL
{
	public class Message
	{
		[Autoincrement]
		[Key]
		public uint Id { get; set; }

		[Required]
		public byte[] Content { get; set; }
	}
}
