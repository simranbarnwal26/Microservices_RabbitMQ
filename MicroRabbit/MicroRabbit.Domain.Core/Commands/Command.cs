﻿using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { set; protected get; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
