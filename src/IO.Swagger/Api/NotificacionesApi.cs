/* 
 * API de Salas, Niveles, Dispositivos y Notificaciones
 *
 * Esta API permite gestionar las entidades:   - Salas: crear, borrar, modificar y consultar.   - Niveles: crear, borrar, modificar y consultar.   - Dispositivos: crear, borrar, modificar y consultar.   - Notificaciones: enviar notificaciones por email mediante los métodos:       • NotificarPresenciaSala       • NotificarUsuarioValido       • NotificarError 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface INotificacionesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Notificar error a un empleado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 NotificarError (NotificacionesErrorBody body);

        /// <summary>
        /// Notificar error a un empleado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> NotificarErrorWithHttpInfo (NotificacionesErrorBody body);
        /// <summary>
        /// Notificar presencia en sala
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 NotificarPresenciaSala ();

        /// <summary>
        /// Notificar presencia en sala
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> NotificarPresenciaSalaWithHttpInfo ();
        /// <summary>
        /// Notificar usuario válido
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 NotificarUsuarioValido (NotificacionesUsuarioValidoBody body);

        /// <summary>
        /// Notificar usuario válido
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> NotificarUsuarioValidoWithHttpInfo (NotificacionesUsuarioValidoBody body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Notificar error a un empleado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> NotificarErrorAsync (NotificacionesErrorBody body);

        /// <summary>
        /// Notificar error a un empleado
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> NotificarErrorAsyncWithHttpInfo (NotificacionesErrorBody body);
        /// <summary>
        /// Notificar presencia en sala
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> NotificarPresenciaSalaAsync ();

        /// <summary>
        /// Notificar presencia en sala
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> NotificarPresenciaSalaAsyncWithHttpInfo ();
        /// <summary>
        /// Notificar usuario válido
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> NotificarUsuarioValidoAsync (NotificacionesUsuarioValidoBody body);

        /// <summary>
        /// Notificar usuario válido
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> NotificarUsuarioValidoAsyncWithHttpInfo (NotificacionesUsuarioValidoBody body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class NotificacionesApi : INotificacionesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacionesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificacionesApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacionesApi"/> class
        /// </summary>
        /// <returns></returns>
        public NotificacionesApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacionesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NotificacionesApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Notificar error a un empleado 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 NotificarError (NotificacionesErrorBody body)
        {
             ApiResponse<InlineResponse2001> localVarResponse = NotificarErrorWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Notificar error a un empleado 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > NotificarErrorWithHttpInfo (NotificacionesErrorBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling NotificacionesApi->NotificarError");

            var localVarPath = "/notificaciones/error";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NotificarError", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Notificar error a un empleado 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> NotificarErrorAsync (NotificacionesErrorBody body)
        {
             ApiResponse<InlineResponse2001> localVarResponse = await NotificarErrorAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Notificar error a un empleado 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> NotificarErrorAsyncWithHttpInfo (NotificacionesErrorBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling NotificacionesApi->NotificarError");

            var localVarPath = "/notificaciones/error";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NotificarError", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Notificar presencia en sala 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 NotificarPresenciaSala ()
        {
             ApiResponse<InlineResponse2001> localVarResponse = NotificarPresenciaSalaWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Notificar presencia en sala 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > NotificarPresenciaSalaWithHttpInfo ()
        {

            var localVarPath = "/notificaciones/presenciaSala";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NotificarPresenciaSala", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Notificar presencia en sala 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> NotificarPresenciaSalaAsync ()
        {
             ApiResponse<InlineResponse2001> localVarResponse = await NotificarPresenciaSalaAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Notificar presencia en sala 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> NotificarPresenciaSalaAsyncWithHttpInfo ()
        {

            var localVarPath = "/notificaciones/presenciaSala";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NotificarPresenciaSala", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Notificar usuario válido 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 NotificarUsuarioValido (NotificacionesUsuarioValidoBody body)
        {
             ApiResponse<InlineResponse2001> localVarResponse = NotificarUsuarioValidoWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Notificar usuario válido 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > NotificarUsuarioValidoWithHttpInfo (NotificacionesUsuarioValidoBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling NotificacionesApi->NotificarUsuarioValido");

            var localVarPath = "/notificaciones/usuarioValido";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NotificarUsuarioValido", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Notificar usuario válido 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> NotificarUsuarioValidoAsync (NotificacionesUsuarioValidoBody body)
        {
             ApiResponse<InlineResponse2001> localVarResponse = await NotificarUsuarioValidoAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Notificar usuario válido 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> NotificarUsuarioValidoAsyncWithHttpInfo (NotificacionesUsuarioValidoBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling NotificacionesApi->NotificarUsuarioValido");

            var localVarPath = "/notificaciones/usuarioValido";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NotificarUsuarioValido", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

    }
}
