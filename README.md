# IO.Swagger - the C# library for the API de Salas, Niveles, Dispositivos y Notificaciones

Esta API permite gestionar las entidades:   - Salas: crear, borrar, modificar y consultar.   - Niveles: crear, borrar, modificar y consultar.   - Dispositivos: crear, borrar, modificar y consultar.   - Notificaciones: enviar notificaciones por email mediante los métodos:       • NotificarPresenciaSala       • NotificarUsuarioValido       • NotificarError 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.7.1 or later

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 111.4.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation

Run the following commands to generate the DLL
```
cd src/IO.Swagger
dotnet restore
dotnet build
```

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```

<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            var apiInstance = new DispositivosApi();
            var codigo = 56;  // int? | Código del dispositivo

            try
            {
                // Borrar un dispositivo
                InlineResponse2001 result = apiInstance.BorrarDispositivo(codigo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositivosApi.BorrarDispositivo: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost:8080/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DispositivosApi* | [**BorrarDispositivo**](docs/DispositivosApi.md#borrardispositivo) | **DELETE** /dispositivos/{codigo} | Borrar un dispositivo
*DispositivosApi* | [**ConsultarDispositivo**](docs/DispositivosApi.md#consultardispositivo) | **GET** /dispositivos/{codigo} | Consultar un dispositivo
*DispositivosApi* | [**ModificarDispositivo**](docs/DispositivosApi.md#modificardispositivo) | **PUT** /dispositivos | Modificar un dispositivo existente
*DispositivosApi* | [**NuevoDispositivo**](docs/DispositivosApi.md#nuevodispositivo) | **POST** /dispositivos | Crear un nuevo dispositivo
*NivelesApi* | [**BorrarNivel**](docs/NivelesApi.md#borrarnivel) | **DELETE** /niveles/{nivel} | Borrar un nivel
*NivelesApi* | [**ConsultarNivel**](docs/NivelesApi.md#consultarnivel) | **GET** /niveles/{nivel} | Consultar un nivel
*NivelesApi* | [**ModificarNivel**](docs/NivelesApi.md#modificarnivel) | **PUT** /niveles | Modificar un nivel existente
*NivelesApi* | [**NuevoNivel**](docs/NivelesApi.md#nuevonivel) | **POST** /niveles | Crear un nuevo nivel
*NotificacionesApi* | [**NotificarError**](docs/NotificacionesApi.md#notificarerror) | **POST** /notificaciones/error | Notificar error a un empleado
*NotificacionesApi* | [**NotificarPresenciaSala**](docs/NotificacionesApi.md#notificarpresenciasala) | **POST** /notificaciones/presenciaSala | Notificar presencia en sala
*NotificacionesApi* | [**NotificarUsuarioValido**](docs/NotificacionesApi.md#notificarusuariovalido) | **POST** /notificaciones/usuarioValido | Notificar usuario válido
*SalasApi* | [**BorrarSala**](docs/SalasApi.md#borrarsala) | **DELETE** /salas/{codigoSala} | Borrar una sala por su código
*SalasApi* | [**ConsultarSala**](docs/SalasApi.md#consultarsala) | **GET** /salas/{codigoSala} | Consultar una sala por su código
*SalasApi* | [**ModificarSala**](docs/SalasApi.md#modificarsala) | **PUT** /salas | Modificar una sala existente
*SalasApi* | [**NuevoSala**](docs/SalasApi.md#nuevosala) | **POST** /salas | Crear una nueva sala

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Dispositivo](docs/Dispositivo.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.Nivel](docs/Nivel.md)
 - [Model.NotificacionesErrorBody](docs/NotificacionesErrorBody.md)
 - [Model.NotificacionesUsuarioValidoBody](docs/NotificacionesUsuarioValidoBody.md)
 - [Model.Sala](docs/Sala.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
