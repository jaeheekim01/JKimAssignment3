namespace JKimAssignment3.Models
{
    public class ActorDetailsVM
    {
        public Actor Actor { get; set; }
        public List<ActorTwitter>? Tweets { get; set; }
        public double OverallAverageSentiment()
        {
            if (Tweets == null) return 0;
            int validTweets = 0;
            double tweetScoreTotal = 0.0;

            foreach (ActorTwitter tweet in Tweets)
            {
                if (tweet.Sentiment != 0)
                {
                    validTweets++;
                    tweetScoreTotal += tweet.Sentiment;
                }
            }
            double average = tweetScoreTotal / Tweets.Count;
            double rounded = Math.Round(average, 2);

            return rounded;
        }
    }
}
