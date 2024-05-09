namespace webapisample.Domain
{
    public class promotestatus
    {
        public static int GetTargetstatus(int score, int credibility)
        {
            return score/credibility;  
        }
    }

}
