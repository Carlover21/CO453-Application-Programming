using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        public int likes { get; set; }

        public readonly List<String> comments;
        // username of the post's author
        public String Username { get; set; }

        public DateTime Timestamp { get; }

        public Post(string author)
        {
            this.Username = author;

            Timestamp = DateTime.Now;
            likes = 0;

            comments = new List<String>();
        }

        public void Like()
        {
            likes++;
            Display();
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>        
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                //Like();
                Console.WriteLine($"    Likes:  {likes}  people like this.\n");
                //Like();
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    {comments.Count} Comments:");

                ShowComments();

                Console.WriteLine();
            }

            Console.WriteLine(" ------------------------------\n");
        }

        private void ShowComments()
        {
            for (int i = 0; i < comments.Count; i++)
            {
                Console.Write("        \"");

                Console.Write(comments[i]);

                Console.Write("\"\n");
            }
        }

        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}
