﻿using System.Collections.Generic;
using Evento;

namespace Infrastructure.Tests.Fakes
{
    internal class CreateFakeCommand : Command
    {
        public string TestString { get; }
        public IDictionary<string, string> Metadata { get; }

        public CreateFakeCommand(string testString, IDictionary<string, string> metadata)
        {
            TestString = testString;
            Metadata = metadata;
        }
    }
}
