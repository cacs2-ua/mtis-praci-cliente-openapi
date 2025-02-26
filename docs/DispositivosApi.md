# IO.Swagger.Api.DispositivosApi

All URIs are relative to *http://localhost:8080/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BorrarDispositivo**](DispositivosApi.md#borrardispositivo) | **DELETE** /dispositivos/{codigo} | Borrar un dispositivo
[**ConsultarDispositivo**](DispositivosApi.md#consultardispositivo) | **GET** /dispositivos/{codigo} | Consultar un dispositivo
[**ModificarDispositivo**](DispositivosApi.md#modificardispositivo) | **PUT** /dispositivos | Modificar un dispositivo existente
[**NuevoDispositivo**](DispositivosApi.md#nuevodispositivo) | **POST** /dispositivos | Crear un nuevo dispositivo

<a name="borrardispositivo"></a>
# **BorrarDispositivo**
> InlineResponse2001 BorrarDispositivo (int? codigo)

Borrar un dispositivo

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BorrarDispositivoExample
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigo** | **int?**| Código del dispositivo | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="consultardispositivo"></a>
# **ConsultarDispositivo**
> Dispositivo ConsultarDispositivo (int? codigo)

Consultar un dispositivo

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConsultarDispositivoExample
    {
        public void main()
        {
            var apiInstance = new DispositivosApi();
            var codigo = 56;  // int? | Código del dispositivo

            try
            {
                // Consultar un dispositivo
                Dispositivo result = apiInstance.ConsultarDispositivo(codigo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositivosApi.ConsultarDispositivo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigo** | **int?**| Código del dispositivo | 

### Return type

[**Dispositivo**](Dispositivo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="modificardispositivo"></a>
# **ModificarDispositivo**
> InlineResponse200 ModificarDispositivo (Dispositivo body)

Modificar un dispositivo existente

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModificarDispositivoExample
    {
        public void main()
        {
            var apiInstance = new DispositivosApi();
            var body = new Dispositivo(); // Dispositivo | 

            try
            {
                // Modificar un dispositivo existente
                InlineResponse200 result = apiInstance.ModificarDispositivo(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositivosApi.ModificarDispositivo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dispositivo**](Dispositivo.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="nuevodispositivo"></a>
# **NuevoDispositivo**
> Dispositivo NuevoDispositivo (Dispositivo body)

Crear un nuevo dispositivo

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NuevoDispositivoExample
    {
        public void main()
        {
            var apiInstance = new DispositivosApi();
            var body = new Dispositivo(); // Dispositivo | 

            try
            {
                // Crear un nuevo dispositivo
                Dispositivo result = apiInstance.NuevoDispositivo(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DispositivosApi.NuevoDispositivo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dispositivo**](Dispositivo.md)|  | 

### Return type

[**Dispositivo**](Dispositivo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
