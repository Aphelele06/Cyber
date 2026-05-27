namespace Cyber
{
    public class BotMemory
    {
        // USER NAME
        public string UserName { get; set; } = "";

        // NAME CAPTURE FLAG
        public bool NameCaptured { get; set; } = false;

        // LAST QUESTION
        public string LastQuestion { get; set; } = "";

        // FAVOURITE TOPIC
        public string FavoriteTopic { get; set; } = "";

        // LAST CYBERSECURITY TOPIC
        public string LastTopicDiscussed { get; set; } = "";

        // CHECK LAST QUESTION
        public bool HasLastQuestion()
        {
            return !string.IsNullOrWhiteSpace(
                LastQuestion);
        }

        // CHECK FAVOURITE TOPIC
        public bool HasFavoriteTopic()
        {
            return !string.IsNullOrWhiteSpace(
                FavoriteTopic);
        }

        // CHECK LAST TOPIC
        public bool HasLastTopic()
        {
            return !string.IsNullOrWhiteSpace(
                LastTopicDiscussed);
        }
    }
}