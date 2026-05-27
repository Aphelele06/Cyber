using System.Collections.Generic;

namespace Cyber
{
    public static class CyberSecurityData
    {
        public static Dictionary<string,
            List<string>> Responses =
                new Dictionary<string,
                    List<string>>()
        {
            // PHISHING
            {
                "phishing",
                new List<string>()
                {
                    "Phishing attacks trick users into sharing sensitive information through fake emails or websites.",
                    "Phishing often relies on urgency and fear to manipulate users into clicking malicious links.",
                    "Before clicking links in emails or messages, always verify the sender and website."
                }
            },

            // PASSWORDS
            {
                "password",
                new List<string>()
                {
                    "Strong passwords should be long, unique, and difficult to guess.",
                    "Using the same password across many accounts increases security risks.",
                    "Password managers can help generate and safely store complex passwords."
                }
            },

            // MALWARE
            {
                "malware",
                new List<string>()
                {
                    "Malware is harmful software that can damage devices or steal information.",
                    "Malware infections often come from unsafe downloads or suspicious attachments.",
                    "Keeping software and antivirus tools updated reduces malware risks."
                }
            },

            // RANSOMWARE
            {
                "ransomware",
                new List<string>()
                {
                    "Ransomware locks files or systems and demands payment for access.",
                    "Regular backups are one of the strongest defenses against ransomware.",
                    "Paying ransom does not guarantee that files will be recovered."
                }
            },

            // VPN
            {
                "vpn",
                new List<string>()
                {
                    "A VPN encrypts internet traffic and improves privacy online.",
                    "VPNs are especially useful when using public Wi-Fi networks.",
                    "A VPN improves privacy but should still be combined with safe browsing habits."
                }
            },

            // 2FA
            {
                "2fa",
                new List<string>()
                {
                    "Two-factor authentication adds an extra layer of security beyond passwords.",
                    "2FA helps protect accounts even if passwords are stolen.",
                    "Authentication apps are generally safer than SMS verification."
                }
            },

            {
                "two factor",
                new List<string>()
                {
                    "Two-factor authentication improves account protection significantly.",
                    "2FA requires an additional verification step during login.",
                    "Security experts strongly recommend enabling 2FA whenever possible."
                }
            },

            // ANTIVIRUS
            {
                "antivirus",
                new List<string>()
                {
                    "Antivirus software detects and removes harmful programs.",
                    "Keeping antivirus software updated improves protection against new threats.",
                    "Antivirus tools work best when combined with cautious online behaviour."
                }
            },

            // SOCIAL ENGINEERING
            {
                "social engineering",
                new List<string>()
                {
                    "Social engineering manipulates people into revealing sensitive information.",
                    "Attackers often pretend to be trusted individuals or organisations.",
                    "Critical thinking and caution are powerful defenses against social engineering."
                }
            },

            // SCAMS
            {
                "scam",
                new List<string>()
                {
                    "Online scams often create urgency or promise unrealistic rewards.",
                    "If something appears too good to be true, it usually deserves caution.",
                    "Always verify requests involving money or sensitive information."
                }
            },

            // IDENTITY THEFT
            {
                "identity theft",
                new List<string>()
                {
                    "Identity theft occurs when criminals steal and misuse personal information.",
                    "Monitoring financial and online accounts helps detect suspicious activity.",
                    "Protecting personal information is an important cybersecurity habit."
                }
            },

            // WIFI SAFETY
            {
                "wifi",
                new List<string>()
                {
                    "Public Wi-Fi networks can expose users to security risks.",
                    "Avoid entering sensitive information on unsecured networks.",
                    "VPNs help improve privacy when using public Wi-Fi."
                }
            }
        };
    }
}