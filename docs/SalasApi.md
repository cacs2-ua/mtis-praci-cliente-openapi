# IO.Swagger.Api.SalasApi

All URIs are relative to *http://localhost:8080/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BorrarSala**](SalasApi.md#borrarsala) | **DELETE** /salas/{codigoSala} | Borrar una sala por su código
[**ConsultarSala**](SalasApi.md#consultarsala) | **GET** /salas/{codigoSala} | Consultar una sala por su código
[**ModificarSala**](SalasApi.md#modificarsala) | **PUT** /salas | Modificar una sala existente
[**NuevoSala**](SalasApi.md#nuevosala) | **POST** /salas | Crear una nueva sala

<a name="borrarsala"></a>
# **BorrarSala**
> InlineResponse2001 BorrarSala (int? codigoSala)

Borrar una sala por su código

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BorrarSalaExample
    {
        public void main()
        {
            var apiInstance = new SalasApi();
            var codigoSala = 56;  // int? | Código de la sala

            try
            {
                // Borrar una sala por su código
                InlineResponse2001 result = apiInstance.BorrarSala(codigoSala);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalasApi.BorrarSala: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoSala** | **int?**| Código de la sala | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="consultarsala"></a>
# **ConsultarSala**
> Sala ConsultarSala (int? codigoSala)

Consultar una sala por su código

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConsultarSalaExample
    {
        public void main()
        {
            var apiInstance = new SalasApi();
            var codigoSala = 56;  // int? | Código de la sala

            try
            {
                // Consultar una sala por su código
                Sala result = apiInstance.ConsultarSala(codigoSala);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalasApi.ConsultarSala: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codigoSala** | **int?**| Código de la sala | 

### Return type

[**Sala**](Sala.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="modificarsala"></a>
# **ModificarSala**
> InlineResponse200 ModificarSala (Sala body)

Modificar una sala existente

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModificarSalaExample
    {
        public void main()
        {
            var apiInstance = new SalasApi();
            var body = new Sala(); // Sala | 

            try
            {
                // Modificar una sala existente
                InlineResponse200 result = apiInstance.ModificarSala(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalasApi.ModificarSala: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Sala**](Sala.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="nuevosala"></a>
# **NuevoSala**
> Sala NuevoSala (Sala body)

Crear una nueva sala

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NuevoSalaExample
    {
        public void main()
        {
            var apiInstance = new SalasApi();
            var body = new Sala(); // Sala | 

            try
            {
                // Crear una nueva sala
                Sala result = apiInstance.NuevoSala(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalasApi.NuevoSala: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Sala**](Sala.md)|  | 

### Return type

[**Sala**](Sala.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
