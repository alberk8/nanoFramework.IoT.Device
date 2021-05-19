**IMPORTANT**: this needs to be adjusted as well with all the generated bindings

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=nanoframework_lib-nanoFramework.IoT.Device&metric=alert_status)](https://sonarcloud.io/dashboard?id=nanoframework_lib-nanoFramework.IoT.Device) [![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=nanoframework_lib-nanoFramework.IoT.Device&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=nanoframework_lib-nanoFramework.IoT.Device) [![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE) [![NuGet](https://img.shields.io/nuget/dt/nanoFramework.IoT.Device.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/nanoFramework.IoT.Device/) [![#yourfirstpr](https://img.shields.io/badge/first--timers--only-friendly-blue.svg)](https://github.com/nanoframework/Home/blob/main/CONTRIBUTING.md) [![Discord](https://img.shields.io/discord/478725473862549535.svg?logo=discord&logoColor=white&label=Discord&color=7289DA)](https://discord.gg/gCyBu8T)

![nanoFramework logo](https://github.com/nanoframework/Home/blob/main/resources/logo/nanoFramework-repo-logo.png)

-----

# Welcome to the **nanoFramework** IoT.Device Library repository!

This repository contains bindings which can be sensors, small screen and anything else that you can connect to your nanoFramework chip!

## Build status

| Component | Build Status | NuGet Package |
|:-|---|---|
| System.Net.Http | [![Build Status](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_apis/build/status/nanoframework.lib-nanoFramework.IoT.Device?branchName=main)](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_build/latest?definitionId=12?branchName=main) | [![NuGet](https://img.shields.io/nuget/v/nanoFramework.IoT.Device.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/nanoFramework.IoT.Device/) |
| System.Net.Http (preview) | [![Build Status](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_apis/build/status/nanoFramework.IoT.Device?repoName=nanoframework%2FnanoFramework.IoT.Device&branchName=develop)](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_build/latest?definitionId=12&repoName=nanoframework%2FnanoFramework.IoT.Device&branchName=develop) | [![NuGet](https://img.shields.io/nuget/vpre/nanoFramework.IoT.Device.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/nanoFramework.IoT.Device/) |
| System.Net.Http.Client | [![Build Status](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_apis/build/status/nanoframework.lib-nanoFramework.IoT.Device?branchName=main)](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_build/latest?definitionId=12?branchName=main) | [![NuGet](https://img.shields.io/nuget/v/nanoFramework.IoT.Device.Client.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/nanoFramework.IoT.Device.Client/) |
| System.Net.Http.Client (preview) | [![Build Status](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_apis/build/status/nanoFramework.IoT.Device?repoName=nanoframework%2FnanoFramework.IoT.Device&branchName=develop)](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_build/latest?definitionId=12&repoName=nanoframework%2FnanoFramework.IoT.Device&branchName=develop) | [![NuGet](https://img.shields.io/nuget/vpre/nanoFramework.IoT.Device.Client.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/nanoFramework.IoT.Device.Client/) |
| System.Net.Http.Server | [![Build Status](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_apis/build/status/nanoframework.lib-nanoFramework.IoT.Device?branchName=main)](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_build/latest?definitionId=12?branchName=main) | [![NuGet](https://img.shields.io/nuget/v/nanoFramework.IoT.Device.Server.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/nanoFramework.IoT.Device.Server/) |
| System.Net.Http.Server (preview) | [![Build Status](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_apis/build/status/nanoFramework.IoT.Device?repoName=nanoframework%2FnanoFramework.IoT.Device&branchName=develop)](https://dev.azure.com/nanoframework/nanoFramework.IoT.Device/_build/latest?definitionId=12&repoName=nanoframework%2FnanoFramework.IoT.Device&branchName=develop) | [![NuGet](https://img.shields.io/nuget/vpre/nanoFramework.IoT.Device.Server.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/nanoFramework.IoT.Device.Server/) |

## Folder Structure

[/src/devices/](/src/devices/) contains devices that were cleaned up and should be working out of the box.

[/src/devices_generated/](/src/devices_generated/) contains devices that were automatically ported from [the NET Core IoT Libraries devices](https://github.com/dotnet/iot/tree/main/src/devices). They might not work or compile at this point, but are a good starting point if you need support for one of the devices contained here but missing from the [/src/devices/](/src/devices/) folder.

[/src/nanoFramework.IoT.Device.CodeConverter](/src/nanoFramework.IoT.Device.CodeConverter) contains the tool used to generate the devices from [the NET Core IoT Libraries devices](https://github.com/dotnet/iot/tree/main/src/devices).

Other folders in [/src](/src) contain nanoFramework projects that you can reference when creating/updating devices with provide functionality such as a StopWatach, a DelayHelper, BinaryPrimitives or various System.Device.Model Attributes.

## Contributing

**Important:** If you plan to clean up the code in [/src/devices_generated/](/src/devices_generated/), please copy your work to the [/src/devices/](/src/devices/) folder as the content of [/src/devices_generated/](/src/devices_generated/) will be overwritten by the generator tool.

## Feedback and documentation

For documentation, providing feedback, issues and finding out how to contribute please refer to the [Home repo](https://github.com/nanoframework/Home).

Join our Discord community [here](https://discord.gg/gCyBu8T).

## Credits

The list of contributors to this project can be found at [CONTRIBUTORS](https://github.com/nanoframework/Home/blob/main/CONTRIBUTORS.md).

## License

The **nanoFramework** Class Libraries are licensed under the [MIT license](LICENSE.md).

## Code of Conduct

This project has adopted the code of conduct defined by the Contributor Covenant to clarify expected behavior in our community.
For more information see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

### .NET Foundation

This project is supported by the [.NET Foundation](https://dotnetfoundation.org).
