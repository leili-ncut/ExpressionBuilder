﻿using System;
using System.Collections.Generic;

namespace ExpressionBuilder.Models
{
	public enum PersonGender
	{
		Male,
		Female
	}
	
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public PersonGender Gender { get; set; }
		public BirthData Birth { get; set; }
		public List<Contact> Contacts { get; private set; }
		
		public Person()
		{
			Contacts = new List<Contact>();
			Birth = new BirthData();
		}
		
		public class BirthData
		{
			public DateTime Date { get; set; }
			public string Country { get; set; }
			
			public override string ToString()
			{
				return string.Format("Born at {0} in {1}", Date.ToShortDateString(), Country);
			}

		}
	}
}