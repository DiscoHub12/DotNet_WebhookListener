# Webhook_ListenerDotNet

## Description
Project developed in .NET Core, provides a controller that aims to behave like a listener. <br>
Therefore, if you have a public ip, any application that sends json to the specific route <br>
(therefore sends data in the body), this is able to take the data, and for simulation print <br>
them in the corresponding project startup terminal.

### Notes and Tool used
To test the correct functioning of the project, the tunnel was used through the Visual Studio 2022 IDE, <br>
which allows you to offer a public test route at project start-up, so that, by placing the route in a <br>
specific service that sends json every 60 seconds, this will be received by the controller.

### Example Photos
1) Example of a web app that sends a request to the specific json route (test) every 60 seconds:<br>
![Screenshot 2023-07-21 125104](https://github.com/DiscoHub12/DotNet_WebhookListener/assets/96992944/9d45a022-cab1-49b9-bd66-747523c57e6f)
2) Example of arriving json to project controller and printing data(json) to terminal: <br>
![Screenshot 2023-07-21 125316](https://github.com/DiscoHub12/DotNet_WebhookListener/assets/96992944/7f91469b-99d2-434f-8cc3-28dd80b4ccaf)

