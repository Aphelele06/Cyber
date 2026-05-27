using System;
using System.Collections.Generic;

namespace Cyber
{
    public static class BotResponse
    {
        static Random random =
            new Random();

        public static string GetResponse(
            string input,
            BotMemory memory)
        {
            string lowerInput =
                input.Trim().ToLower();

            // STORE LAST QUESTION
            memory.LastQuestion =
                input;

            // ==========================
            // NAME CAPTURE
            // ==========================
            if (!memory.NameCaptured)
            {
                memory.UserName =
                    input;

                memory.NameCaptured =
                    true;

                return $"Hello {memory.UserName}! " +
                       "Welcome to the Cybersecurity Awareness Bot. " +
                       "I am here to help you learn about online safety, cyber threats, and smart digital habits.";
            }

            // ==========================
            // EXIT
            // ==========================
            if (lowerInput == "exit")
            {
                return $"Goodbye {memory.UserName}. " +
                       "Remember that cybersecurity starts with awareness and good decisions. Stay safe online!";
            }

            // ==========================
            // PERSONALITY
            // ==========================
            if (lowerInput.Contains("who are you"))
            {
                return "I am a Cybersecurity Awareness Bot designed to educate users about digital safety and cyber threats.";
            }

            if (lowerInput.Contains("what can you do"))
            {
                return "I can explain cybersecurity concepts, remember parts of our conversation, respond to emotions, and help you learn safer online habits.";
            }

            if (lowerInput.Contains("how are you"))
            {
                return "I am functioning well and ready to discuss cybersecurity with you.";
            }

            // ==========================
            // MEMORY & RECALL
            // ==========================
            if (lowerInput.Contains("my name"))
            {
                return $"Your name is {memory.UserName}.";
            }

            if (lowerInput.Contains("last question"))
            {
                if (memory.HasLastQuestion())
                {
                    return $"Your last question was: {memory.LastQuestion}";
                }

                return "I do not remember a previous question.";
            }

            if (lowerInput.Contains("what do i like"))
            {
                if (memory.HasFavoriteTopic())
                {
                    return $"You told me that you like {memory.FavoriteTopic}.";
                }

                return "You have not shared a favourite topic yet.";
            }

            if (lowerInput.Contains(
                "what were we discussing"))
            {
                if (memory.HasLastTopic())
                {
                    return $"We were discussing {memory.LastTopicDiscussed}.";
                }

                return "We have not discussed a cybersecurity topic yet.";
            }

            // ==========================
            // STORE INTERESTS
            // ==========================
            if (lowerInput.StartsWith("i like"))
            {
                string topic =
                    input.Substring(6).Trim();

                memory.FavoriteTopic =
                    topic;

                return $"I will remember that you like {topic}. " +
                       "Learning becomes easier when we discuss topics you enjoy.";
            }

            // ==========================
            // SENTIMENT DETECTION
            // ==========================
            if (lowerInput.Contains("happy"))
            {
                return "That is wonderful to hear. Positive energy helps people learn and solve problems more effectively.";
            }

            if (lowerInput.Contains("sad"))
            {
                return "I am sorry you feel that way. Remember to take care of yourself and give yourself time to recharge.";
            }

            if (lowerInput.Contains("stressed"))
            {
                return "Stress can make challenges feel larger than they are. Taking problems one step at a time often helps.";
            }

            if (lowerInput.Contains("worried"))
            {
                return "Feeling worried about cybersecurity is understandable. Awareness is actually a strength because it encourages safer decisions.";
            }

            if (lowerInput.Contains("confused"))
            {
                return "That is okay. Cybersecurity concepts can be complex, and I am here to explain them more clearly.";
            }

            if (lowerInput.Contains("tired"))
            {
                return "Rest is important. People are more likely to make risky decisions online when they are tired.";
            }

            // ==========================
            // THANK YOU
            // ==========================
            if (lowerInput.Contains("thank"))
            {
                return $"You are welcome, {memory.UserName}. " +
                       "Learning cybersecurity is an investment in your digital safety.";
            }

            // ==========================
            // KEYWORD RECOGNITION
            // ==========================
            foreach (var keyword in
                CyberSecurityData.Responses.Keys)
            {
                if (lowerInput.Contains(keyword))
                {
                    memory.LastTopicDiscussed =
                        keyword;

                    List<string> replies =
                        CyberSecurityData.Responses[keyword];

                    int index =
                        random.Next(
                            replies.Count);

                    string response =
                        replies[index];

                    // CONVERSATION FLOW
                    if (keyword == "phishing")
                    {
                        response +=
                            "\n\nHave you ever received a suspicious email or message?";
                    }

                    if (keyword == "password")
                    {
                        response +=
                            "\n\nDo you use different passwords for different accounts?";
                    }

                    if (keyword == "malware")
                    {
                        response +=
                            "\n\nDo you keep your antivirus software updated?";
                    }

                    if (keyword == "ransomware")
                    {
                        response +=
                            "\n\nDo you keep backups of important files?";
                    }

                    if (keyword == "vpn")
                    {
                        response +=
                            "\n\nHave you ever used a VPN before?";
                    }

                    if (keyword == "2fa" ||
                        keyword == "two factor")
                    {
                        response +=
                            "\n\nHave you enabled two-factor authentication on your accounts?";
                    }

                    if (keyword == "social engineering")
                    {
                        response +=
                            "\n\nHave you encountered suspicious calls or messages before?";
                    }

                    return response;
                }
            }

            // ==========================
            // RANDOM FALLBACK RESPONSES
            // ==========================
            List<string> randomReplies =
                new List<string>()
            {
                $"That is an interesting question, {memory.UserName}. Could you explain a little more?",

                "Cybersecurity is a broad field, and I may need more detail to understand your question.",

                "I may not fully understand yet, but I am always ready to discuss online safety.",

                "Perhaps try asking about phishing, passwords, malware, or scams.",

                "Cybersecurity affects everyone, so every question about online safety matters.",

                "That topic sounds interesting. Let us explore it together."
            };

            int randomIndex =
                random.Next(
                    randomReplies.Count);

            return randomReplies[
                randomIndex];
        }
    }
}