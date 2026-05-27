using System.Collections.Generic;

namespace Cyber
{
    public static class CyberSecurityData
    {
        public static Dictionary<string, List<string>> Responses =
            new Dictionary<string, List<string>>()
        {
            {
                "password",
                new List<string>()
                {
                    "Use strong passwords with symbols and numbers.",
                    "Never share your password.",
                    "Change passwords regularly."
                }
            },

            {
                "phishing",
                new List<string>()
                {
                    "Do not click suspicious email links.",
                    "Phishing scams steal personal information.",
                    "Always verify emails before opening them."
                }
            },

            {
                "malware",
                new List<string>()
                {
                    "Install antivirus software.",
                    "Avoid unsafe downloads.",
                    "Malware can damage your computer."
                }
            },

            {
                "vpn",
                new List<string>()
                {
                    "VPNs protect your connection.",
                    "Use VPNs on public Wi-Fi.",
                    "VPNs improve privacy."
                }
            },

            {
                "privacy",
                new List<string>()
                {
                    "Protect your personal information online.",
                    "Review privacy settings regularly.",
                    "Be careful what you share online."
                }
            }
        };
    }
}