using System;

namespace DeploymentPortfolio.Core
{
    public static class GreetingService
    {
        public static string CreateGreeting(string name)
        {
            var visitor = string.IsNullOrWhiteSpace(name) ? "student" : name.Trim();
            return $"Hello, {visitor}. Your WiX deployment application is running.";
        }
    }
}
