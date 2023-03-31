using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class SocialNetwork : NewsFeed
    {
        public NewsFeed news = new NewsFeed();

        public int SearchPosts { get; set; }

        public string Search { get; set; }
        public string Username { get; set; }

        public const int MaxLength = 100;

        public const int MinLength = 1;

        private char input;

        public const string AllowedChars = @"^[0-9a-zA-Z!@#$%&*()_\-+={[}\]|:;'<,>.?~` ]*$";

        private bool postNow = false;

        public void DisplayMenu()
        {
            Console.Clear();
            ConsoleHelper.OutputHeading("News Feed");
            string[] choices = new string[]
            {
                "Post Message", "Post Image",
                "Display All Posts", "Display by Author",
                "Like a Post","Unlike a post","Remove the post", "Add a comment","Quit"
            };

            bool wantToQuit = false;

            do
            {
                Console.WriteLine("\n      Main Menu \n" +
                                    "          ---------\n");

                int choice = ConsoleHelper.SelectChoice(choices);

                postNow = false;

                switch (choice)
                {
                    case 1:
                        PostMessage();
                        break;

                    case 2:
                        PostImage();
                        break;

                    case 3:
                        DisaplayAllPost();
                        break;

                    case 4:
                        DisplayPostsByUser();
                        break;

                    case 5:
                        LikeByAuthor();
                        break;

                    case 6:
                        DisLikeByAuthor();
                        break;

                    case 7:
                        wantToQuit = true;
                        break;

                    default:
                        break;
                }

            } while (!wantToQuit);
        }

        public void DisaplayAllPost()
        {
            news.Display();
        }

        public void PostMessage()
        {
            Console.Clear();

            Console.Write("Author name > ");

            Username = Console.ReadLine();

            news.Author = Username;

            Console.Write("Type your message > ");

            string message = Console.ReadLine();

            if (Username.Length > 0 && message.Length > 0 && message.Length <= MaxLength)
            {
                MessagePost post = new MessagePost(Username, message);

                news.AddMessagePost(post);
                //usernames.Add(Username);

                Console.WriteLine("\n-- Your message has been posted! --\n");
            }
            else
            {
                Console.WriteLine($"\n-- Name and message must not be empty and message must be between 1 and {MaxLength} characters --\n");
            }

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
            Console.Clear();
        }
        public void PostImage()
        {
            Console.Clear();

            Console.Write("Author name > ");

            Username = Console.ReadLine();

            news.Author = Username;

            Console.Write("\n    Enter image filename > ");

            string filename = Console.ReadLine();

            Console.Write("\n    Enter image caption > ");

            string caption = Console.ReadLine();

            PhotoPost photopost = new PhotoPost(Username, filename, caption);

            news.AddPhotoPost(photopost);

            Console.WriteLine("\n -- Your image has been posted ! --\n");

            Console.Clear();
        }

        public void DisplayPostsByUser()
        {
            Console.Clear();
            Console.Write("Enter the username to search for: ");
            string username = Console.ReadLine();

            Console.WriteLine($"Showing posts by {username}:\n");

            news.DisplayUser(username);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public void DisplayByDate(string date)
        {
            if (news == null || news.Posts == null || news.Posts.Count == 0)
            {
                Console.WriteLine("\n    -- No posts to display --\n");
                return;
            }

            int searchPosts = 0;

            foreach (Post post in news.Posts)
            {
                if (post.Timestamp.Year.ToString() == date)
                {
                    searchPosts++;
                }
            }

            if (searchPosts > 0)
            {
                int i = 0;

                foreach (Post post in news.Posts)
                {
                    if (post.Timestamp.Year.ToString() == date)
                    {
                        i++;
                        DisplayResults(i, post);
                    }
                }
            }
            else
            {
                Console.WriteLine("\n    -- No posts found --\n");
            }
        }


        private void DisplayResults(int i, Post post)
        {
            Console.WriteLine($"\n    -- Showing {i}/{SearchPosts} posts --");

            post.Display();

            if (i == SearchPosts)
            {
                Console.WriteLine("    -- End of posts --\n");
            }
        }
        public void LikeByAuthor()
        {
            Console.Write("Enter the author's name: ");
            string username = Console.ReadLine();
            if (username == Username)
            {
                Post post = new Post(Username);
                post.Like();
                Console.WriteLine("User liked this post");
            }
        }

        public void DisLikeByAuthor()
        {
            Console.Write("Enter the author's name: ");
            string username = Console.ReadLine();
            if (username == Username)
            {
                Post post = new Post(Username);
                post.Unlike();
                Console.WriteLine("User unliked this post");
            }
        }
    }
}
