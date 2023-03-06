namespace JKimAssignment3.Models
{
    public class MovieDetailsVM
    {
        public Movie Movie { get; set; }
        public List<MovieTwitter>? Tweets { get; set; }

        public double OverallAverageSentiment()
        {
            if (Tweets == null) return 0;
            int validTweets = 0;
            double tweetScoreTotal = 0.0;

            foreach (MovieTwitter tweet in Tweets)
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
