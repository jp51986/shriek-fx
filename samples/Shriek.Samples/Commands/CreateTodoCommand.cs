﻿using Shriek.Commands;
using System;

namespace Shriek.Samples.Commands
{
    public class CreateTodoCommand : Command<Guid>
    {
        public CreateTodoCommand(Guid id, int version = 0) : base(id, version)
        {
        }

        public string Name { get; set; }

        public string Desception { get; set; }
        public DateTime FinishTime { get; set; }
    }
}