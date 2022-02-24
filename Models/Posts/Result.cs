namespace oj.fe.Models.Posts;

public class Result
{
       public int id { get; set; }
        public CreatedBy created_by { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime create_time { get; set; }
        public DateTime last_update_time { get; set; }
        public bool visible { get; set; }
}