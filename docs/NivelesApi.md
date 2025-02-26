# IO.Swagger.Api.NivelesApi

All URIs are relative to *http://localhost:8080/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BorrarNivel**](NivelesApi.md#borrarnivel) | **DELETE** /niveles/{nivel} | Borrar un nivel
[**ConsultarNivel**](NivelesApi.md#consultarnivel) | **GET** /niveles/{nivel} | Consultar un nivel
[**ModificarNivel**](NivelesApi.md#modificarnivel) | **PUT** /niveles | Modificar un nivel existente
[**NuevoNivel**](NivelesApi.md#nuevonivel) | **POST** /niveles | Crear un nuevo nivel

<a name="borrarnivel"></a>
# **BorrarNivel**
> InlineResponse2001 BorrarNivel (int? nivel)

Borrar un nivel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BorrarNivelExample
    {
        public void main()
        {
            var apiInstance = new NivelesApi();
            var nivel = 56;  // int? | Nivel

            try
            {
                // Borrar un nivel
                InlineResponse2001 result = apiInstance.BorrarNivel(nivel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NivelesApi.BorrarNivel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nivel** | **int?**| Nivel | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="consultarnivel"></a>
# **ConsultarNivel**
> Nivel ConsultarNivel (int? nivel)

Consultar un nivel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConsultarNivelExample
    {
        public void main()
        {
            var apiInstance = new NivelesApi();
            var nivel = 56;  // int? | Nivel

            try
            {
                // Consultar un nivel
                Nivel result = apiInstance.ConsultarNivel(nivel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NivelesApi.ConsultarNivel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nivel** | **int?**| Nivel | 

### Return type

[**Nivel**](Nivel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="modificarnivel"></a>
# **ModificarNivel**
> InlineResponse200 ModificarNivel (Nivel body)

Modificar un nivel existente

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModificarNivelExample
    {
        public void main()
        {
            var apiInstance = new NivelesApi();
            var body = new Nivel(); // Nivel | 

            try
            {
                // Modificar un nivel existente
                InlineResponse200 result = apiInstance.ModificarNivel(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NivelesApi.ModificarNivel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Nivel**](Nivel.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="nuevonivel"></a>
# **NuevoNivel**
> Nivel NuevoNivel (Nivel body)

Crear un nuevo nivel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NuevoNivelExample
    {
        public void main()
        {
            var apiInstance = new NivelesApi();
            var body = new Nivel(); // Nivel | 

            try
            {
                // Crear un nuevo nivel
                Nivel result = apiInstance.NuevoNivel(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NivelesApi.NuevoNivel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Nivel**](Nivel.md)|  | 

### Return type

[**Nivel**](Nivel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
