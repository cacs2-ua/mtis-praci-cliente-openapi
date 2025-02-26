# IO.Swagger.Api.NotificacionesApi

All URIs are relative to *http://localhost:8080/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotificarError**](NotificacionesApi.md#notificarerror) | **POST** /notificaciones/error | Notificar error a un empleado
[**NotificarPresenciaSala**](NotificacionesApi.md#notificarpresenciasala) | **POST** /notificaciones/presenciaSala | Notificar presencia en sala
[**NotificarUsuarioValido**](NotificacionesApi.md#notificarusuariovalido) | **POST** /notificaciones/usuarioValido | Notificar usuario válido

<a name="notificarerror"></a>
# **NotificarError**
> InlineResponse2001 NotificarError (NotificacionesErrorBody body)

Notificar error a un empleado

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NotificarErrorExample
    {
        public void main()
        {
            var apiInstance = new NotificacionesApi();
            var body = new NotificacionesErrorBody(); // NotificacionesErrorBody | 

            try
            {
                // Notificar error a un empleado
                InlineResponse2001 result = apiInstance.NotificarError(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificacionesApi.NotificarError: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NotificacionesErrorBody**](NotificacionesErrorBody.md)|  | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="notificarpresenciasala"></a>
# **NotificarPresenciaSala**
> InlineResponse2001 NotificarPresenciaSala ()

Notificar presencia en sala

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NotificarPresenciaSalaExample
    {
        public void main()
        {
            var apiInstance = new NotificacionesApi();

            try
            {
                // Notificar presencia en sala
                InlineResponse2001 result = apiInstance.NotificarPresenciaSala();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificacionesApi.NotificarPresenciaSala: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="notificarusuariovalido"></a>
# **NotificarUsuarioValido**
> InlineResponse2001 NotificarUsuarioValido (NotificacionesUsuarioValidoBody body)

Notificar usuario válido

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NotificarUsuarioValidoExample
    {
        public void main()
        {
            var apiInstance = new NotificacionesApi();
            var body = new NotificacionesUsuarioValidoBody(); // NotificacionesUsuarioValidoBody | 

            try
            {
                // Notificar usuario válido
                InlineResponse2001 result = apiInstance.NotificarUsuarioValido(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificacionesApi.NotificarUsuarioValido: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NotificacionesUsuarioValidoBody**](NotificacionesUsuarioValidoBody.md)|  | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
