using System;
using System.Collections.Generic;

namespace Cyber
{
    public static class BotResponse
    {
        static Random random = new Random();

        public static string GetResponse(
            string input,
            BotMemory memory)
        {
            string lowerInput = input.ToLower();

            // NAME MEMORY
            if (!memory.NameCaptured)
            {
                memory.UserName = input;

                memory.NameCaptured = true;

                return $"Hello {memory.UserName}, ask me anything about cybersecurity.";
            }

            // EXIT
            if (lowerInput == "exit")
            {
                return $"Goodbye {memory.UserName}. Stay safe online!";
            }

            // MEMORY RECALL
            if (lowerInput.Contains("my name"))
            {
                return $"Your name is {memory.UserName}.";
            }

            // SENTIMENT DETECTION
            if (lowerInput.Contains("happy"))
            {
                return "That's great to hear!";
            }

            if (lowerInput.Contains("sad"))
            {
                return "I hope your day gets better.";
            }

            if (lowerInput.Contains("tired"))
            {
                return "Remember to rest and stay safe online.";
            }

            // NORMAL CHAT
            if (lowerInput.Contains("how are you"))
            {
                return "I am functioning correctly and ready to help.";
            }

            // KEYWORD RECOGNITION
            foreach (var keyword in CyberSecurityData.Responses.Keys)
            {
                if (lowerInput.Contains(keyword))
                {
                    List<string> reply =
                        CyberSecurityData.Responses[keyword];

                    int index =
                        random.Next(reply.Count);

                    return reply[index];
                }
            }

            // RANDOM RESPONSE
            List<string> randomReplies =
                new List<string>()
            {
                "Interesting question.",
                "Cybersecurity is important.",
                "Try asking about phishing or passwords.",
                "Stay safe online.",
                "Can you ask differently?"
            };

            int randomIndex =
                random.Next(randomReplies.Count);

            return randomReplies[randomIndex];
        }
    }
}