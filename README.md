# Cybersecurity Awareness Bot
## Project Overview
The Cybersecurity Awareness Bot is a WPF desktop chatbot developed in C# to educate users about cybersecurity and online safety. The application provides interactive conversations, cybersecurity education, memory features, sentiment detection, and a modern graphical user interface.
The bot is designed to promote cybersecurity awareness through meaningful discussions and practical online safety advice.
# Project Objectives
The purpose of this project is to:
- Educate users about cybersecurity threats
- Demonstrate chatbot development using C#
- Implement artificial intelligence concepts
- Create a modern and interactive graphical user interface
- Use memory and conversation flow to improve interaction
- Encourage safer online behaviour
# Technologies Used
The project was developed using:
- C#
- WPF (Windows Presentation Foundation)
- XAML
- .NET
- Visual Studio
# Project Structure
The project consists of the following files:
## 1. MainWindow.xaml
This file contains the graphical user interface.
It defines:
- Window layout
- Background image
- Header
- Chat display area
- User input textbox
- Send button
- Button styling and hover effects
### GUI Features
- Cyber-themed interface
- Rounded panels
- Background image
- Professional styling
- Responsive layout
## 2. MainWindow.xaml.cs
This file controls user interaction and application behaviour.
Responsibilities include:
- Handling Send button clicks
- Processing Enter key input
- Displaying chatbot responses
- Showing typing effect
- Auto-scrolling chat
- Welcome message display
- ASCII bot display
- Exit command handling
### Typing Effect
The chatbot displays:
BOT: typing
before generating responses to simulate a real conversation.
## 3. BotMemory.cs
This file stores chatbot memory and recall data.
It allows the bot to remember:
- User name
- Favourite topic
- Last question
- Last topic discussed
### Memory Functions
The bot can answer:
- "What is my name?"
- "What do I like?"
- "What were we discussing?"
- "What was my last question?"
This improves conversation continuity.
## 4. CyberSecurityData.cs
This file acts as the chatbot knowledge base.
It uses a Dictionary containing cybersecurity keywords and multiple responses.
Topics include:
- Phishing
- Passwords
- Malware
- Ransomware
- VPN
- Antivirus
- Scams
- Social Engineering
- Identity Theft
- Wi-Fi Safety
- Two-Factor Authentication
### Dictionary Usage
Each keyword contains multiple responses.
Example:
```csharp
"phishing"
This allows:
- Keyword recognition
- Randomized responses
- More natural conversations
## 5. BotResponse.cs
This is the chatbot's main decision-making engine.
It processes:
- User input
- Memory
- Sentiment
- Keywords
- Conversation flow
### Features Implemented
## Name Capture
The chatbot asks for the user's name and remembers it.
Example:
User:
Hello
Bot:
Hello John!
## Keyword Recognition
The bot searches user input for cybersecurity keywords.
Example:
User:
Tell me about phishing
Bot:
Phishing attacks trick users into revealing sensitive information.
## Random Responses
Each cybersecurity topic contains multiple replies.
This prevents repetitive conversations.
Example:
Two phishing questions may produce different answers.
## Memory and Recall
The bot remembers user information.
Example:
User:
I like malware
Bot:
I will remember that.
Later:
User:
What do I like?
Bot:
You like malware.
## Sentiment Detection
The bot recognises emotional words.
Detected emotions:
- Happy
- Sad
- Stressed
- Worried
- Confused
- Tired
Example:
User:
I am stressed
Bot:
Stress can make challenges feel larger than they are.
This makes the chatbot more supportive and conversational.
## Conversation Flow
The chatbot asks follow-up questions.
Example:
User:
Tell me about phishing
Bot:
Phishing is
Have you ever received suspicious emails?
This creates interactive conversations.
## Fallback Responses
If input is unclear, the bot generates intelligent fallback replies.
Example:
- Can you explain further?
- Try asking about passwords or malware.
This prevents empty responses.
## 6. SoundManager.cs
This file manages the welcome sound.
Responsibilities:
- Play startup sound
- Handle sound errors
- Display fallback welcome message
### Sound Features
- Startup audio greeting
- Error handling using try-catch
If audio fails, the bot still launches successfully.
# ASCII Bot
The project includes an ASCII chatbot displayed at startup.
This improves presentation and user engagement.
# Background Image
The chatbot includes a cybersecurity background image.
Location:
Images/back.png
Image properties:
Build Action:
Resource
This provides a modern cyber appearance.
# User Commands
Examples of supported input:
## General
- Who are you?
- How are you?
- What can you do?
## Cybersecurity
- Phishing
- Passwords
- Malware
- VPN
- Scam
- Antivirus
- Social engineering
## Memory
- What is my name?
- What do I like?
- What were we discussing?
## Sentiment
- I am happy
- I am sad
- I am stressed
## Exit
- exit
# Error Handling
The application includes exception handling.
Implemented in:
- SoundManager.cs
- Input validation
This prevents crashes and improves reliability.
# Key Features Summary
 Feature                 Implemented 
GUI                      Yes 
WPF                      Yes 
Background Image         Yes 
ASCII Bot                Yes 
Keyword Recognition      Yes 
Dictionary               Yes
Random Responses         Yes 
Memory                   Yes 
Recall                   Yes 
Sentiment Detection      Yes 
Conversation Flow        Yes
Sound                    Yes 
Error Handling           Yes 
# Future Improvements
Possible future enhancements:
- Voice recognition
- Voice output
- AI learning
- Database memory
- User accounts
- Internet-based cybersecurity updates
# Conclusion
The Cybersecurity Awareness Bot demonstrates the use of C#, WPF, and chatbot logic to create an educational cybersecurity assistant.

The system combines cybersecurity knowledge, memory, sentiment detection, and interactive conversation to provide a meaningful and engaging user experience while promoting online safety.
