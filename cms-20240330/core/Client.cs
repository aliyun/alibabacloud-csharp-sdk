// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cms20240330.Models;

namespace AlibabaCloud.SDK.Cms20240330
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cms", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建EntityStore相关存储</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEntityStoreResponse
        /// </returns>
        public CreateEntityStoreResponse CreateEntityStoreWithOptions(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEntityStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建EntityStore相关存储</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEntityStoreResponse
        /// </returns>
        public async Task<CreateEntityStoreResponse> CreateEntityStoreWithOptionsAsync(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEntityStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建EntityStore相关存储</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateEntityStoreResponse
        /// </returns>
        public CreateEntityStoreResponse CreateEntityStore(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEntityStoreWithOptions(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建EntityStore相关存储</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateEntityStoreResponse
        /// </returns>
        public async Task<CreateEntityStoreResponse> CreateEntityStoreAsync(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEntityStoreWithOptionsAsync(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Prometheus监控实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrometheusInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusInstanceResponse
        /// </returns>
        public CreatePrometheusInstanceResponse CreatePrometheusInstanceWithOptions(CreatePrometheusInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchiveDuration))
            {
                body["archiveDuration"] = request.ArchiveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeReadPolicy))
            {
                body["authFreeReadPolicy"] = request.AuthFreeReadPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeWritePolicy))
            {
                body["authFreeWritePolicy"] = request.AuthFreeWritePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeRead))
            {
                body["enableAuthFreeRead"] = request.EnableAuthFreeRead;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeWrite))
            {
                body["enableAuthFreeWrite"] = request.EnableAuthFreeWrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthToken))
            {
                body["enableAuthToken"] = request.EnableAuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceName))
            {
                body["prometheusInstanceName"] = request.PrometheusInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageDuration))
            {
                body["storageDuration"] = request.StorageDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrometheusInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrometheusInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Prometheus监控实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrometheusInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusInstanceResponse
        /// </returns>
        public async Task<CreatePrometheusInstanceResponse> CreatePrometheusInstanceWithOptionsAsync(CreatePrometheusInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchiveDuration))
            {
                body["archiveDuration"] = request.ArchiveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeReadPolicy))
            {
                body["authFreeReadPolicy"] = request.AuthFreeReadPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthFreeWritePolicy))
            {
                body["authFreeWritePolicy"] = request.AuthFreeWritePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeRead))
            {
                body["enableAuthFreeRead"] = request.EnableAuthFreeRead;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthFreeWrite))
            {
                body["enableAuthFreeWrite"] = request.EnableAuthFreeWrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthToken))
            {
                body["enableAuthToken"] = request.EnableAuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusInstanceName))
            {
                body["prometheusInstanceName"] = request.PrometheusInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageDuration))
            {
                body["storageDuration"] = request.StorageDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                body["workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrometheusInstance",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/prometheus-instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrometheusInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Prometheus监控实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrometheusInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusInstanceResponse
        /// </returns>
        public CreatePrometheusInstanceResponse CreatePrometheusInstance(CreatePrometheusInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePrometheusInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Prometheus监控实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrometheusInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrometheusInstanceResponse
        /// </returns>
        public async Task<CreatePrometheusInstanceResponse> CreatePrometheusInstanceAsync(CreatePrometheusInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePrometheusInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public CreateServiceResponse CreateServiceWithOptions(string workspace, CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid))
            {
                body["pid"] = request.Pid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                body["serviceStatus"] = request.ServiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                body["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(string workspace, CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid))
            {
                body["pid"] = request.Pid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                body["serviceStatus"] = request.ServiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                body["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public CreateServiceResponse CreateService(string workspace, CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public async Task<CreateServiceResponse> CreateServiceAsync(string workspace, CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Umodel配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUmodelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUmodelResponse
        /// </returns>
        public CreateUmodelResponse CreateUmodelWithOptions(string workspace, CreateUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonSchemaRef))
            {
                body["commonSchemaRef"] = request.CommonSchemaRef;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUmodelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Umodel配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUmodelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUmodelResponse
        /// </returns>
        public async Task<CreateUmodelResponse> CreateUmodelWithOptionsAsync(string workspace, CreateUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonSchemaRef))
            {
                body["commonSchemaRef"] = request.CommonSchemaRef;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUmodelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Umodel配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUmodelResponse
        /// </returns>
        public CreateUmodelResponse CreateUmodel(string workspace, CreateUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUmodelWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Umodel配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUmodelResponse
        /// </returns>
        public async Task<CreateUmodelResponse> CreateUmodelAsync(string workspace, CreateUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUmodelWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除EntityStore相关存储</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityStoreResponse
        /// </returns>
        public DeleteEntityStoreResponse DeleteEntityStoreWithOptions(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEntityStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除EntityStore相关存储</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityStoreResponse
        /// </returns>
        public async Task<DeleteEntityStoreResponse> DeleteEntityStoreWithOptionsAsync(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEntityStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除EntityStore相关存储</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEntityStoreResponse
        /// </returns>
        public DeleteEntityStoreResponse DeleteEntityStore(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEntityStoreWithOptions(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除EntityStore相关存储</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEntityStoreResponse
        /// </returns>
        public async Task<DeleteEntityStoreResponse> DeleteEntityStoreAsync(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEntityStoreWithOptionsAsync(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Service</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public DeleteServiceResponse DeleteServiceWithOptions(string workspace, string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Service</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(string workspace, string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Service</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public DeleteServiceResponse DeleteService(string workspace, string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceWithOptions(workspace, serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Service</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public async Task<DeleteServiceResponse> DeleteServiceAsync(string workspace, string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceWithOptionsAsync(workspace, serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelResponse
        /// </returns>
        public DeleteUmodelResponse DeleteUmodelWithOptions(string workspace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUmodelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelResponse
        /// </returns>
        public async Task<DeleteUmodelResponse> DeleteUmodelWithOptionsAsync(string workspace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUmodelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Umodel配置信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteUmodelResponse
        /// </returns>
        public DeleteUmodelResponse DeleteUmodel(string workspace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUmodelWithOptions(workspace, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Umodel配置信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteUmodelResponse
        /// </returns>
        public async Task<DeleteUmodelResponse> DeleteUmodelAsync(string workspace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUmodelWithOptionsAsync(workspace, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelDataResponse
        /// </returns>
        public DeleteUmodelDataResponse DeleteUmodelDataWithOptions(string workspace, DeleteUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                query["kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/data",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUmodelDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelDataResponse
        /// </returns>
        public async Task<DeleteUmodelDataResponse> DeleteUmodelDataWithOptionsAsync(string workspace, DeleteUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                query["kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/data",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUmodelDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelDataResponse
        /// </returns>
        public DeleteUmodelDataResponse DeleteUmodelData(string workspace, DeleteUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUmodelDataWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUmodelDataResponse
        /// </returns>
        public async Task<DeleteUmodelDataResponse> DeleteUmodelDataAsync(string workspace, DeleteUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUmodelDataWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作空间</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspaceWithOptions(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作空间</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceWithOptionsAsync(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作空间</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspace(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWorkspaceWithOptions(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作空间</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWorkspaceWithOptionsAsync(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取EntityStore相关存储信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreResponse
        /// </returns>
        public GetEntityStoreResponse GetEntityStoreWithOptions(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEntityStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取EntityStore相关存储信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreResponse
        /// </returns>
        public async Task<GetEntityStoreResponse> GetEntityStoreWithOptionsAsync(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEntityStore",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/entitystore",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEntityStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取EntityStore相关存储信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEntityStoreResponse
        /// </returns>
        public GetEntityStoreResponse GetEntityStore(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEntityStoreWithOptions(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取EntityStore相关存储信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEntityStoreResponse
        /// </returns>
        public async Task<GetEntityStoreResponse> GetEntityStoreAsync(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEntityStoreWithOptionsAsync(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定Workspace下的实体和关系数据，返回结果显示某时间区间中的实体数据（返回结果压缩后传输）。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityStoreDataRequest
        /// </param>
        /// <param name="headers">
        /// GetEntityStoreDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreDataResponse
        /// </returns>
        public GetEntityStoreDataResponse GetEntityStoreDataWithOptions(string workspace, GetEntityStoreDataRequest request, GetEntityStoreDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AcceptEncoding))
            {
                realHeaders["acceptEncoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AcceptEncoding);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEntityStoreData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/entitiesAndRelations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEntityStoreDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定Workspace下的实体和关系数据，返回结果显示某时间区间中的实体数据（返回结果压缩后传输）。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityStoreDataRequest
        /// </param>
        /// <param name="headers">
        /// GetEntityStoreDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreDataResponse
        /// </returns>
        public async Task<GetEntityStoreDataResponse> GetEntityStoreDataWithOptionsAsync(string workspace, GetEntityStoreDataRequest request, GetEntityStoreDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AcceptEncoding))
            {
                realHeaders["acceptEncoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AcceptEncoding);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEntityStoreData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/entitiesAndRelations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEntityStoreDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定Workspace下的实体和关系数据，返回结果显示某时间区间中的实体数据（返回结果压缩后传输）。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityStoreDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreDataResponse
        /// </returns>
        public GetEntityStoreDataResponse GetEntityStoreData(string workspace, GetEntityStoreDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEntityStoreDataHeaders headers = new GetEntityStoreDataHeaders();
            return GetEntityStoreDataWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定Workspace下的实体和关系数据，返回结果显示某时间区间中的实体数据（返回结果压缩后传输）。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityStoreDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEntityStoreDataResponse
        /// </returns>
        public async Task<GetEntityStoreDataResponse> GetEntityStoreDataAsync(string workspace, GetEntityStoreDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEntityStoreDataHeaders headers = new GetEntityStoreDataHeaders();
            return await GetEntityStoreDataWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Service</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public GetServiceResponse GetServiceWithOptions(string workspace, string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Service</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(string workspace, string serviceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Service</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public GetServiceResponse GetService(string workspace, string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceWithOptions(workspace, serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Service</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceResponse
        /// </returns>
        public async Task<GetServiceResponse> GetServiceAsync(string workspace, string serviceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceWithOptionsAsync(workspace, serviceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用可观测实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceObservabilityResponse
        /// </returns>
        public GetServiceObservabilityResponse GetServiceObservabilityWithOptions(string workspace, string type, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceObservability",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceObservabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用可观测实例</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceObservabilityResponse
        /// </returns>
        public async Task<GetServiceObservabilityResponse> GetServiceObservabilityWithOptionsAsync(string workspace, string type, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceObservability",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceObservabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用可观测实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceObservabilityResponse
        /// </returns>
        public GetServiceObservabilityResponse GetServiceObservability(string workspace, string type)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceObservabilityWithOptions(workspace, type, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用可观测实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceObservabilityResponse
        /// </returns>
        public async Task<GetServiceObservabilityResponse> GetServiceObservabilityAsync(string workspace, string type)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceObservabilityWithOptionsAsync(workspace, type, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelResponse
        /// </returns>
        public GetUmodelResponse GetUmodelWithOptions(string workspace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUmodelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelResponse
        /// </returns>
        public async Task<GetUmodelResponse> GetUmodelWithOptionsAsync(string workspace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUmodelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Umodel配置信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUmodelResponse
        /// </returns>
        public GetUmodelResponse GetUmodel(string workspace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUmodelWithOptions(workspace, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Umodel配置信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUmodelResponse
        /// </returns>
        public async Task<GetUmodelResponse> GetUmodelAsync(string workspace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUmodelWithOptionsAsync(workspace, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取相关联的 Umodel 图数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelDataResponse
        /// </returns>
        public GetUmodelDataResponse GetUmodelDataWithOptions(string workspace, GetUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/graph",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUmodelDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取相关联的 Umodel 图数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelDataResponse
        /// </returns>
        public async Task<GetUmodelDataResponse> GetUmodelDataWithOptionsAsync(string workspace, GetUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/graph",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUmodelDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取相关联的 Umodel 图数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelDataResponse
        /// </returns>
        public GetUmodelDataResponse GetUmodelData(string workspace, GetUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUmodelDataWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取相关联的 Umodel 图数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUmodelDataResponse
        /// </returns>
        public async Task<GetUmodelDataResponse> GetUmodelDataAsync(string workspace, GetUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUmodelDataWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作空间</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspaceWithOptions(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作空间</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作空间</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspace(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkspaceWithOptions(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作空间</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkspaceWithOptionsAsync(workspaceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询告警动作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertActionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertActionsResponse
        /// </returns>
        public ListAlertActionsResponse ListAlertActionsWithOptions(ListAlertActionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertActionsShrinkRequest request = new ListAlertActionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlertActionIds))
            {
                request.AlertActionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlertActionIds, "alertActionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertActionIdsShrink))
            {
                query["alertActionIds"] = request.AlertActionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertActionName))
            {
                query["alertActionName"] = request.AlertActionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlertActions",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/alertActions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertActionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询告警动作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAlertActionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertActionsResponse
        /// </returns>
        public async Task<ListAlertActionsResponse> ListAlertActionsWithOptionsAsync(ListAlertActionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAlertActionsShrinkRequest request = new ListAlertActionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlertActionIds))
            {
                request.AlertActionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlertActionIds, "alertActionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertActionIdsShrink))
            {
                query["alertActionIds"] = request.AlertActionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertActionName))
            {
                query["alertActionName"] = request.AlertActionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlertActions",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/alertActions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertActionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询告警动作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertActionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertActionsResponse
        /// </returns>
        public ListAlertActionsResponse ListAlertActions(ListAlertActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlertActionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询告警动作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertActionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertActionsResponse
        /// </returns>
        public async Task<ListAlertActionsResponse> ListAlertActionsAsync(ListAlertActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlertActionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public ListServicesResponse ListServicesWithOptions(string workspace, ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(string workspace, ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public ListServicesResponse ListServices(string workspace, ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServicesWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源Service</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public async Task<ListServicesResponse> ListServicesAsync(string workspace, ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServicesWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作空间列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkspacesShrinkRequest request = new ListWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WorkspaceNameList))
            {
                request.WorkspaceNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WorkspaceNameList, "workspaceNameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["workspaceName"] = request.WorkspaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceNameListShrink))
            {
                query["workspaceNameList"] = request.WorkspaceNameListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作空间列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkspacesShrinkRequest request = new ListWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WorkspaceNameList))
            {
                request.WorkspaceNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WorkspaceNameList, "workspaceNameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["workspaceName"] = request.WorkspaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceNameListShrink))
            {
                query["workspaceNameList"] = request.WorkspaceNameListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作空间列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkspacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作空间列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutWorkspaceResponse
        /// </returns>
        public PutWorkspaceResponse PutWorkspaceWithOptions(string workspaceName, PutWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutWorkspaceResponse
        /// </returns>
        public async Task<PutWorkspaceResponse> PutWorkspaceWithOptionsAsync(string workspaceName, PutWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutWorkspace",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// PutWorkspaceResponse
        /// </returns>
        public PutWorkspaceResponse PutWorkspace(string workspaceName, PutWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutWorkspaceWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// PutWorkspaceResponse
        /// </returns>
        public async Task<PutWorkspaceResponse> PutWorkspaceAsync(string workspaceName, PutWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutWorkspaceWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public UpdateServiceResponse UpdateServiceWithOptions(string workspace, string serviceId, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                body["serviceStatus"] = request.ServiceStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(string workspace, string serviceId, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                body["serviceStatus"] = request.ServiceStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/service/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public UpdateServiceResponse UpdateService(string workspace, string serviceId, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceWithOptions(workspace, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateService</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public async Task<UpdateServiceResponse> UpdateServiceAsync(string workspace, string serviceId, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceWithOptionsAsync(workspace, serviceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUmodelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUmodelResponse
        /// </returns>
        public UpdateUmodelResponse UpdateUmodelWithOptions(string workspace, UpdateUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonSchemaRef))
            {
                body["commonSchemaRef"] = request.CommonSchemaRef;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUmodelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUmodelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUmodelResponse
        /// </returns>
        public async Task<UpdateUmodelResponse> UpdateUmodelWithOptionsAsync(string workspace, UpdateUmodelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonSchemaRef))
            {
                body["commonSchemaRef"] = request.CommonSchemaRef;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUmodel",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUmodelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUmodelResponse
        /// </returns>
        public UpdateUmodelResponse UpdateUmodel(string workspace, UpdateUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUmodelWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新Umodel配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUmodelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUmodelResponse
        /// </returns>
        public async Task<UpdateUmodelResponse> UpdateUmodelAsync(string workspace, UpdateUmodelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUmodelWithOptionsAsync(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写入 Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelDataResponse
        /// </returns>
        public UpsertUmodelDataResponse UpsertUmodelDataWithOptions(string workspace, UpsertUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Elements))
            {
                body["elements"] = request.Elements;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpsertUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/data",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpsertUmodelDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写入 Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelDataResponse
        /// </returns>
        public async Task<UpsertUmodelDataResponse> UpsertUmodelDataWithOptionsAsync(string workspace, UpsertUmodelDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Elements))
            {
                body["elements"] = request.Elements;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpsertUmodelData",
                Version = "2024-03-30",
                Protocol = "HTTPS",
                Pathname = "/workspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspace) + "/umodel/data",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpsertUmodelDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写入 Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelDataResponse
        /// </returns>
        public UpsertUmodelDataResponse UpsertUmodelData(string workspace, UpsertUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpsertUmodelDataWithOptions(workspace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写入 Umodel Elements</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertUmodelDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpsertUmodelDataResponse
        /// </returns>
        public async Task<UpsertUmodelDataResponse> UpsertUmodelDataAsync(string workspace, UpsertUmodelDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpsertUmodelDataWithOptionsAsync(workspace, request, headers, runtime);
        }

    }
}
