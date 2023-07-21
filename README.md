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
