﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.CodeFirst;

namespace DAL
{
	public class MsgQueue : IEntity
	{
		[Autoincrement]
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public int TopMsgIdx { get; set; }

		public virtual List<Message> Messages { get; set; }

		public virtual List<Reader> Readers { get; set; }

		[ForeignKey("UserId")]
		public virtual User User { get; set; }
		public int UserId { get; set; }
	}
}
