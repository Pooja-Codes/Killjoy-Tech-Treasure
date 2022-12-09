# Killjoy Tech Treasure -> [Play](https://pooja-codes.github.io/Killjoy-Tech-Treasure/)
The tech treasure game project for [echo3D](https://www.echo3d.com/) as part of Fall 2022 Software Developer Internship. 🎮 
<p align="center">
  <img align="center" style="width:80%;height:0;padding-bottom:182%;position:relative;" alt="PoojaPatelEcho3D"src="https://github.com/Pooja-Codes/Killjoy-Tech-Treasure/blob/main/ReadMedia/Pooja%20Patel.png">
</p>

## Killjoy Tech Treasure Video
https://user-images.githubusercontent.com/87775823/206806141-a33e329f-f049-4859-956d-b4d24819f4a3.mp4

## Killjoy Tech Treasure Victory Or Defeat

<table>
 <tr>
    <td><img src="https://user-images.githubusercontent.com/87775823/206806549-64000a7f-95a9-41d9-9d9c-9ded81898368.jpg" alt="KilljoyTechTreasure Victory Image" width="600"/></td>
    <td><img src="https://user-images.githubusercontent.com/87775823/206806567-f806251d-8392-4a26-9e3f-903f81e5c739.jpg" alt="KilljoyTechTreasure Defeat Image" width="600"/></td>
  </tr>
</table>

## Setup
* Built with Unity 2021.3.9f1  _(Note: The echo3D Unity SDK is supported in 2020.3.25 and higher.)_
* Register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).
* [Add the Unity SDK](https://medium.com/r/?url=https%3A%2F%2Fdocs.echo3d.co%2Funity%2Finstallation). Troubleshoot [here](https://docs.echo3d.com/unity/troubleshooting#im-getting-a-newtonsoft.json.dll-error-in-unity).
* Clone this repo. 

## Steps
* [Add](https://docs.echo3D.co/quickstart/add-a-3d-model) the models and [upload](https://docs.echo3d.com/upload) the metadata file from [ContentManagerEcho3D folder](https://github.com/Pooja-Codes/Killjoy-Tech-Treasure/blob/main/Killjoy-Tech-Treasure/ContentManagerEcho3D.zip) to the [echo3D console](https://console.echo3d.com/#/pages/contentmanager).
<table>
 <tr>
    <td><img src="https://github.com/Pooja-Codes/Killjoy-Tech-Treasure/blob/main/ReadMedia/ContentManagerObjs1.png" alt="ContentManagerObjs1 Image" width="600"/></td>
    <td><img src="https://github.com/Pooja-Codes/Killjoy-Tech-Treasure/blob/main/ReadMedia/ContentManagerObjs2.png" alt="ContentManagerObjs2 Image" width="600"/></td>
  </tr>
   <tr>
    <td><img src="https://github.com/Pooja-Codes/Killjoy-Tech-Treasure/blob/main/ReadMedia/ContentManagerMetaData1.png" alt="ContentManagerMetaData1 Image" width="600"/></td>
    <td><img src="https://github.com/Pooja-Codes/Killjoy-Tech-Treasure/blob/main/ReadMedia/ContentManagerMetaData2.png" alt="ContentManagerMetaData2 Image" width="600"/></td>
  </tr>
</table>

* Open the Killjoy-Tech-Treasure sub folder in Unity.
<table>
 <tr>
    <td><img src="https://user-images.githubusercontent.com/87775823/206810018-c2e6f37e-0439-430e-8104-ebecd37e3967.jpg" alt="OpenInUnity" width="300"/></td>
  </tr>
</table>


* Open the _SampleScene_ scene in Unity.
* [Set the API key](https://docs.echo3d.co/quickstart/access-the-console) and Entry IDs for those same models in the Inspector. <br>
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/195749269-f7a43477-b67a-49e8-a212-6abdb9c948fd.png)<br>
<table>
 <tr>
    <td><img src="https://user-images.githubusercontent.com/99516371/205407613-b746840f-8e8a-4ec8-b056-a680395dfab4.png" alt="NEWAPIKeyandEntryID" width="600"/></td>
    <td><img src="https://user-images.githubusercontent.com/87775823/206807169-9a32880e-4595-43f0-acac-4c50080cdd94.png" alt="KilljoyTechTreasure NEWAPIKeyandEntryID" width="600"/></td>
  </tr>
</table>

* [Type your Secret Key](https://docs.echo3d.co/web-console/deliver-pages/security-page#secret-key) as the value for the parameter secKey in the file Packages/co.echo3D.unity/Runtime/Echo3DHologram.cs. _(Note: Secret Key only matters if you have the Security Key enabled). You can turn it off in the Security options in your echo3D console._
![NEWSecKey2](https://user-images.githubusercontent.com/99516371/195749308-b2349a3b-7e43-4d3c-8f09-fbfa9d3cb0be.png)<br>

## Run
Simply press the _Play_ button in Unity and enjoy Killjoy Tech Treasure Game!

### Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Troubleshooting
Visit our troubleshooting guide [here](https://docs.echo3d.co/unity/troubleshooting#im-getting-a-newtonsoft.json.dll-error-in-unity).
