# ASP.NET Core 5.0 video streaming server

**Introduction**

This project is just a small prototype to demonstrate how ASP.NET Core could be used as a streaming server. 

It contains a WebAPI endpoint to a video file. This endpoint returns a "PhysicalFile" object which has "enablerangeprocessing" set to true. This allows the endpoint to send the file in chunks instead of just in one big go. 

There's a basic HTML file called streamingexample.html embedded with the source. This is just to show you how to use the WebAPI endpoint with an HTML5 video tag. 


**General Comments**

This project is not production level ready, its basic concept is to demonstrate the ability to create a streaming server. Further development to optimize & secure the platform would be required. **This is not Netflix.**

