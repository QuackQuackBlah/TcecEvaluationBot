﻿namespace TcecEvaluationBot.ConsoleUI.Commands
{
    using System.Linq;

    using TcecEvaluationBot.ConsoleUI.Settings;

    public class EvalHelpCommand : BaseCommand
    {
        private readonly Settings settings;

        private readonly Options options;

        public EvalHelpCommand(Settings settings, Options options)
        {
            this.settings = settings;
            this.options = options;
        }

        public override string Execute(string message)
        {
            return $@"commands: 
!eval {{engine({this.settings.Engines.FirstOrDefault()?.Name})}} {{time({this.options.DefaultEvaluationTime})}} • 
!db • !time {{gameNum|last|next}} • !games {{engine}} • !static • !reverse • !rand [min] [max]";
        }
    }
}
