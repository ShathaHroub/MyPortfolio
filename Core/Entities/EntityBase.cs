﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class EntityBase
    {

        public Guid Id { get; set; }

		public EntityBase()
		{
			Id = Guid.NewGuid();
		}
	}

}
