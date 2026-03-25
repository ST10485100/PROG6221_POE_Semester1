using System;
using System.Collections.Generic;
using System.Text;

namespace PROG6221_POE
{
    internal class Chatbot
    {
        //This is where you can make Question and Answer combinations
        private StoreQuestionandAnswer[] knowledgeBase = new StoreQuestionandAnswer[]
        {
            new StoreQuestionandAnswer("how are you", "I'm doing great! Ready to talk cybersecurity."),
            new StoreQuestionandAnswer("purpose", "I am here to help you understand online safety."),
            new StoreQuestionandAnswer("password safety", "Use unique passwords and a password manager."),
            new StoreQuestionandAnswer("phishing", "Verify the sender's email address before clicking links."),
            new StoreQuestionandAnswer("safe browsing", "Always look for the padlock icon (HTTPS) in your browser.")
        };

        //This is basically the chatbots search engine, it searches for answers to questions stored.
        public void GetResponse(string userInput)
        {
            bool found = false;
            string lowerInput = userInput.ToLower();

            foreach (var item in knowledgeBase)
            {
                if (lowerInput.Contains(item.Question))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n[CyberBot]: " + item.Answer);
                    Console.ResetColor();
                    found = true;
                    break;
                }
            }if (!found)
            {
                Console.WriteLine("\n[CyberBot]: I'm not sure about that. Try asking about another topic within Cybersecurity I'm sure I can answer it!");
            }
        }
}
}    
