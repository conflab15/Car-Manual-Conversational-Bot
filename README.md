# Car-Manual-Conversational-Bot
The implementation of a Car Manual Conversational Bot, developed using Azure's language studio and knowledge base, into a simple MVC Application. 

The assignment brief was to create a conversational bot which solves a complex problem using comtemporary and justified tools, techniques and languages.
To implement a knowledge base for the bot, I found an Owner's Manual for a Volkswagen Golf, and refactored the document to obtain necessary information to allow the knowledge base
to analyse and learn from this document to implement Question and Answer (QnA) pairs. 

![image](https://user-images.githubusercontent.com/43405874/163265762-4b9b4e04-c12f-455e-a0b2-83645899a88b.png)

Once the knowledge base analysed this, I reviewed, and added extra question phrases to maximise the success rate of the bot providing the correct information to the users questions.
When I was happy with the knowledge base, I was able to deploy this to an Azure Web App Bot, which provides a range of deployment channels, including social media chat integrations.
For this deployment, I used a Web Chat, which returned an iframe element I was able to implement into the simple web application as a proof of concept to showcase how a conversational
bot could be implemented into web applications and assist users in diagnosing problems with their vehicles. 

![image](https://user-images.githubusercontent.com/43405874/163266046-673a9c37-3fd9-4ea1-a6b7-53ad1c6ff665.png)
