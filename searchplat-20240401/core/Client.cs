// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Searchplat20240401.Models;

namespace AlibabaCloud.SDK.Searchplat20240401
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"eu-central-1", "searchplat.eu-central-1.aliyuncs.com"},
                {"cn-shanghai", "searchplat.cn-shanghai.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("searchplat", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Stops a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CeaseFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CeaseFunctionInstanceResponse
        /// </returns>
        public CeaseFunctionInstanceResponse CeaseFunctionInstanceWithOptions(string workspaceName, string functionName, string instanceName, CeaseFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CeaseFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/actions/cease",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CeaseFunctionInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CeaseFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CeaseFunctionInstanceResponse
        /// </returns>
        public async Task<CeaseFunctionInstanceResponse> CeaseFunctionInstanceWithOptionsAsync(string workspaceName, string functionName, string instanceName, CeaseFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CeaseFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/actions/cease",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CeaseFunctionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CeaseFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CeaseFunctionInstanceResponse
        /// </returns>
        public CeaseFunctionInstanceResponse CeaseFunctionInstance(string workspaceName, string functionName, string instanceName, CeaseFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CeaseFunctionInstanceWithOptions(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CeaseFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CeaseFunctionInstanceResponse
        /// </returns>
        public async Task<CeaseFunctionInstanceResponse> CeaseFunctionInstanceAsync(string workspaceName, string functionName, string instanceName, CeaseFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CeaseFunctionInstanceWithOptionsAsync(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAsyncTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAsyncTaskResponse
        /// </returns>
        public CreateAsyncTaskResponse CreateAsyncTaskWithOptions(string workspaceName, CreateAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                body["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAsyncTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/async-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAsyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAsyncTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAsyncTaskResponse
        /// </returns>
        public async Task<CreateAsyncTaskResponse> CreateAsyncTaskWithOptionsAsync(string workspaceName, CreateAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["serviceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                body["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAsyncTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/async-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAsyncTaskResponse
        /// </returns>
        public CreateAsyncTaskResponse CreateAsyncTask(string workspaceName, CreateAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAsyncTaskWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAsyncTaskResponse
        /// </returns>
        public async Task<CreateAsyncTaskResponse> CreateAsyncTaskAsync(string workspaceName, CreateAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAsyncTaskWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a knowledge base-related configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCapabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCapabilityResponse
        /// </returns>
        public CreateCapabilityResponse CreateCapabilityWithOptions(string workspaceName, string itemCategory, CreateCapabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemDesc))
            {
                body["itemDesc"] = request.ItemDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemName))
            {
                body["itemName"] = request.ItemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemValue))
            {
                body["itemValue"] = request.ItemValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCapability",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/capabilities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemCategory) + "/items",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCapabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a knowledge base-related configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCapabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCapabilityResponse
        /// </returns>
        public async Task<CreateCapabilityResponse> CreateCapabilityWithOptionsAsync(string workspaceName, string itemCategory, CreateCapabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemDesc))
            {
                body["itemDesc"] = request.ItemDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemName))
            {
                body["itemName"] = request.ItemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemValue))
            {
                body["itemValue"] = request.ItemValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCapability",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/capabilities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemCategory) + "/items",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCapabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a knowledge base-related configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCapabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCapabilityResponse
        /// </returns>
        public CreateCapabilityResponse CreateCapability(string workspaceName, string itemCategory, CreateCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCapabilityWithOptions(workspaceName, itemCategory, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a knowledge base-related configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCapabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCapabilityResponse
        /// </returns>
        public async Task<CreateCapabilityResponse> CreateCapabilityAsync(string workspaceName, string itemCategory, CreateCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCapabilityWithOptionsAsync(workspaceName, itemCategory, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a configuration item in a specified workspace. The prompt and lark types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation allows you to create a configuration for a specific workspace.</description></item>
        /// <item><description>The <c>configType</c> parameter specifies the type of configuration to create. Valid values: <c>prompt</c> and <c>lark</c>.</description></item>
        /// <item><description>When <c>dryRun</c> is set to <c>true</c>, the API operation only validates the request without actually performing the creation.</description></item>
        /// <item><description>The <c>configData</c> field varies depending on the value of <c>configType</c>. Refer to the examples for the specific structure to construct the request body.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigResponse
        /// </returns>
        public CreateConfigResponse CreateConfigWithOptions(string workspaceName, string configType, CreateConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigData))
            {
                body["configData"] = request.ConfigData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfig",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configType),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a configuration item in a specified workspace. The prompt and lark types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation allows you to create a configuration for a specific workspace.</description></item>
        /// <item><description>The <c>configType</c> parameter specifies the type of configuration to create. Valid values: <c>prompt</c> and <c>lark</c>.</description></item>
        /// <item><description>When <c>dryRun</c> is set to <c>true</c>, the API operation only validates the request without actually performing the creation.</description></item>
        /// <item><description>The <c>configData</c> field varies depending on the value of <c>configType</c>. Refer to the examples for the specific structure to construct the request body.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigResponse
        /// </returns>
        public async Task<CreateConfigResponse> CreateConfigWithOptionsAsync(string workspaceName, string configType, CreateConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigData))
            {
                body["configData"] = request.ConfigData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfig",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configType),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a configuration item in a specified workspace. The prompt and lark types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation allows you to create a configuration for a specific workspace.</description></item>
        /// <item><description>The <c>configType</c> parameter specifies the type of configuration to create. Valid values: <c>prompt</c> and <c>lark</c>.</description></item>
        /// <item><description>When <c>dryRun</c> is set to <c>true</c>, the API operation only validates the request without actually performing the creation.</description></item>
        /// <item><description>The <c>configData</c> field varies depending on the value of <c>configType</c>. Refer to the examples for the specific structure to construct the request body.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigResponse
        /// </returns>
        public CreateConfigResponse CreateConfig(string workspaceName, string configType, CreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigWithOptions(workspaceName, configType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a configuration item in a specified workspace. The prompt and lark types are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation allows you to create a configuration for a specific workspace.</description></item>
        /// <item><description>The <c>configType</c> parameter specifies the type of configuration to create. Valid values: <c>prompt</c> and <c>lark</c>.</description></item>
        /// <item><description>When <c>dryRun</c> is set to <c>true</c>, the API operation only validates the request without actually performing the creation.</description></item>
        /// <item><description>The <c>configData</c> field varies depending on the value of <c>configType</c>. Refer to the examples for the specific structure to construct the request body.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigResponse
        /// </returns>
        public async Task<CreateConfigResponse> CreateConfigAsync(string workspaceName, string configType, CreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigWithOptionsAsync(workspaceName, configType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates access credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialsResponse
        /// </returns>
        public CreateCredentialsResponse CreateCredentialsWithOptions(string workspaceName, CreateCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCredentials",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/credentials",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates access credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialsResponse
        /// </returns>
        public async Task<CreateCredentialsResponse> CreateCredentialsWithOptionsAsync(string workspaceName, CreateCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCredentials",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/credentials",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates access credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialsResponse
        /// </returns>
        public CreateCredentialsResponse CreateCredentials(string workspaceName, CreateCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCredentialsWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates access credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialsResponse
        /// </returns>
        public async Task<CreateCredentialsResponse> CreateCredentialsAsync(string workspaceName, CreateCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCredentialsWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates experience data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperienceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperienceDataResponse
        /// </returns>
        public CreateExperienceDataResponse CreateExperienceDataWithOptions(string workspaceName, CreateExperienceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSize))
            {
                body["dataSize"] = request.DataSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["dataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataValue))
            {
                body["dataValue"] = request.DataValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                body["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperienceData",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/experience-data",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperienceDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates experience data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperienceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperienceDataResponse
        /// </returns>
        public async Task<CreateExperienceDataResponse> CreateExperienceDataWithOptionsAsync(string workspaceName, CreateExperienceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSize))
            {
                body["dataSize"] = request.DataSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["dataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataValue))
            {
                body["dataValue"] = request.DataValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                body["serviceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperienceData",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/experience-data",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperienceDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates experience data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperienceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperienceDataResponse
        /// </returns>
        public CreateExperienceDataResponse CreateExperienceData(string workspaceName, CreateExperienceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperienceDataWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates experience data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperienceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperienceDataResponse
        /// </returns>
        public async Task<CreateExperienceDataResponse> CreateExperienceDataAsync(string workspaceName, CreateExperienceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperienceDataWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFunctionInstanceResponse
        /// </returns>
        public CreateFunctionInstanceResponse CreateFunctionInstanceWithOptions(string workspaceName, string functionName, CreateFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParameters))
            {
                body["createParameters"] = request.CreateParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                body["functionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["modelType"] = request.ModelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFunctionInstanceResponse
        /// </returns>
        public async Task<CreateFunctionInstanceResponse> CreateFunctionInstanceWithOptionsAsync(string workspaceName, string functionName, CreateFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParameters))
            {
                body["createParameters"] = request.CreateParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                body["functionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["modelType"] = request.ModelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFunctionInstanceResponse
        /// </returns>
        public CreateFunctionInstanceResponse CreateFunctionInstance(string workspaceName, string functionName, CreateFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFunctionInstanceWithOptions(workspaceName, functionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFunctionInstanceResponse
        /// </returns>
        public async Task<CreateFunctionInstanceResponse> CreateFunctionInstanceAsync(string workspaceName, string functionName, CreateFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFunctionInstanceWithOptionsAsync(workspaceName, functionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service configuration task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFunctionTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFunctionTaskResponse
        /// </returns>
        public CreateFunctionTaskResponse CreateFunctionTaskWithOptions(string workspaceName, string functionName, string instanceName, CreateFunctionTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunctionTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service configuration task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFunctionTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFunctionTaskResponse
        /// </returns>
        public async Task<CreateFunctionTaskResponse> CreateFunctionTaskWithOptionsAsync(string workspaceName, string functionName, string instanceName, CreateFunctionTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunctionTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service configuration task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFunctionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFunctionTaskResponse
        /// </returns>
        public CreateFunctionTaskResponse CreateFunctionTask(string workspaceName, string functionName, string instanceName, CreateFunctionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFunctionTaskWithOptions(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service configuration task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFunctionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFunctionTaskResponse
        /// </returns>
        public async Task<CreateFunctionTaskResponse> CreateFunctionTaskAsync(string workspaceName, string functionName, string instanceName, CreateFunctionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFunctionTaskWithOptionsAsync(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an offline processing task for video retrieval. You can configure the data source, processing parameters, and output destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOfflineTaskResponse
        /// </returns>
        public CreateOfflineTaskResponse CreateOfflineTaskWithOptions(string workspaceName, string type, CreateOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Draft))
            {
                query["draft"] = request.Draft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Meta))
            {
                body["meta"] = request.Meta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processors))
            {
                body["processors"] = request.Processors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sink))
            {
                body["sink"] = request.Sink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOfflineTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an offline processing task for video retrieval. You can configure the data source, processing parameters, and output destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOfflineTaskResponse
        /// </returns>
        public async Task<CreateOfflineTaskResponse> CreateOfflineTaskWithOptionsAsync(string workspaceName, string type, CreateOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Draft))
            {
                query["draft"] = request.Draft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Meta))
            {
                body["meta"] = request.Meta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processors))
            {
                body["processors"] = request.Processors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sink))
            {
                body["sink"] = request.Sink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOfflineTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an offline processing task for video retrieval. You can configure the data source, processing parameters, and output destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOfflineTaskResponse
        /// </returns>
        public CreateOfflineTaskResponse CreateOfflineTask(string workspaceName, string type, CreateOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOfflineTaskWithOptions(workspaceName, type, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an offline processing task for video retrieval. You can configure the data source, processing parameters, and output destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOfflineTaskResponse
        /// </returns>
        public async Task<CreateOfflineTaskResponse> CreateOfflineTaskAsync(string workspaceName, string type, CreateOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOfflineTaskWithOptionsAsync(workspaceName, type, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluation task for the RAG edition.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRagEvaluatorTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRagEvaluatorTaskResponse
        /// </returns>
        public CreateRagEvaluatorTaskResponse CreateRagEvaluatorTaskWithOptions(string workspaceName, CreateRagEvaluatorTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["app_name"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceConfig))
            {
                body["data_source_config"] = request.DataSourceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Emails))
            {
                body["emails"] = request.Emails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluateConfig))
            {
                body["evaluate_config"] = request.EvaluateConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasDataSource))
            {
                body["has_data_source"] = request.HasDataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["task_name"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRagEvaluatorTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/rag-evaluator/v1/api/task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRagEvaluatorTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluation task for the RAG edition.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRagEvaluatorTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRagEvaluatorTaskResponse
        /// </returns>
        public async Task<CreateRagEvaluatorTaskResponse> CreateRagEvaluatorTaskWithOptionsAsync(string workspaceName, CreateRagEvaluatorTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["app_name"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceConfig))
            {
                body["data_source_config"] = request.DataSourceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Emails))
            {
                body["emails"] = request.Emails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluateConfig))
            {
                body["evaluate_config"] = request.EvaluateConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasDataSource))
            {
                body["has_data_source"] = request.HasDataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["task_name"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRagEvaluatorTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/rag-evaluator/v1/api/task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRagEvaluatorTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluation task for the RAG edition.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRagEvaluatorTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRagEvaluatorTaskResponse
        /// </returns>
        public CreateRagEvaluatorTaskResponse CreateRagEvaluatorTask(string workspaceName, CreateRagEvaluatorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRagEvaluatorTaskWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluation task for the RAG edition.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRagEvaluatorTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRagEvaluatorTaskResponse
        /// </returns>
        public async Task<CreateRagEvaluatorTaskResponse> CreateRagEvaluatorTaskAsync(string workspaceName, CreateRagEvaluatorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRagEvaluatorTaskWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                body["engineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                body["engineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific configuration item from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This API operation allows you to delete a specific configuration item by specifying the workspace name, configuration category, and configuration name. Before calling this operation, ensure that you have sufficient permissions (such as the <c>DeleteCapability</c> action in a RAM policy). After a configuration item is deleted, all related data and services may be affected.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCapabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCapabilityResponse
        /// </returns>
        public DeleteCapabilityResponse DeleteCapabilityWithOptions(string workspaceName, string itemCategory, string itemName, DeleteCapabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCapability",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/capabilities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemCategory) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCapabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific configuration item from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This API operation allows you to delete a specific configuration item by specifying the workspace name, configuration category, and configuration name. Before calling this operation, ensure that you have sufficient permissions (such as the <c>DeleteCapability</c> action in a RAM policy). After a configuration item is deleted, all related data and services may be affected.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCapabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCapabilityResponse
        /// </returns>
        public async Task<DeleteCapabilityResponse> DeleteCapabilityWithOptionsAsync(string workspaceName, string itemCategory, string itemName, DeleteCapabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCapability",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/capabilities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemCategory) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCapabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific configuration item from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This API operation allows you to delete a specific configuration item by specifying the workspace name, configuration category, and configuration name. Before calling this operation, ensure that you have sufficient permissions (such as the <c>DeleteCapability</c> action in a RAM policy). After a configuration item is deleted, all related data and services may be affected.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCapabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCapabilityResponse
        /// </returns>
        public DeleteCapabilityResponse DeleteCapability(string workspaceName, string itemCategory, string itemName, DeleteCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCapabilityWithOptions(workspaceName, itemCategory, itemName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific configuration item from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This API operation allows you to delete a specific configuration item by specifying the workspace name, configuration category, and configuration name. Before calling this operation, ensure that you have sufficient permissions (such as the <c>DeleteCapability</c> action in a RAM policy). After a configuration item is deleted, all related data and services may be affected.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCapabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCapabilityResponse
        /// </returns>
        public async Task<DeleteCapabilityResponse> DeleteCapabilityAsync(string workspaceName, string itemCategory, string itemName, DeleteCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCapabilityWithOptionsAsync(workspaceName, itemCategory, itemName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific type of configuration from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigResponse
        /// </returns>
        public DeleteConfigResponse DeleteConfigWithOptions(string workspaceName, string configType, string id, DeleteConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfig",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific type of configuration from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigResponse
        /// </returns>
        public async Task<DeleteConfigResponse> DeleteConfigWithOptionsAsync(string workspaceName, string configType, string id, DeleteConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfig",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific type of configuration from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigResponse
        /// </returns>
        public DeleteConfigResponse DeleteConfig(string workspaceName, string configType, string id, DeleteConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigWithOptions(workspaceName, configType, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific type of configuration from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigResponse
        /// </returns>
        public async Task<DeleteConfigResponse> DeleteConfigAsync(string workspaceName, string configType, string id, DeleteConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigWithOptionsAsync(workspaceName, configType, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialsResponse
        /// </returns>
        public DeleteCredentialsResponse DeleteCredentialsWithOptions(string token, string workspaceName, DeleteCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCredentials",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(token),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialsResponse
        /// </returns>
        public async Task<DeleteCredentialsResponse> DeleteCredentialsWithOptionsAsync(string token, string workspaceName, DeleteCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCredentials",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(token),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialsResponse
        /// </returns>
        public DeleteCredentialsResponse DeleteCredentials(string token, string workspaceName, DeleteCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCredentialsWithOptions(token, workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialsResponse
        /// </returns>
        public async Task<DeleteCredentialsResponse> DeleteCredentialsAsync(string token, string workspaceName, DeleteCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCredentialsWithOptionsAsync(token, workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete experience data</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperienceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperienceDataResponse
        /// </returns>
        public DeleteExperienceDataResponse DeleteExperienceDataWithOptions(string id, string workspaceName, DeleteExperienceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperienceData",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/experience-data/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperienceDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete experience data</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperienceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperienceDataResponse
        /// </returns>
        public async Task<DeleteExperienceDataResponse> DeleteExperienceDataWithOptionsAsync(string id, string workspaceName, DeleteExperienceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperienceData",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/experience-data/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperienceDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete experience data</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperienceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperienceDataResponse
        /// </returns>
        public DeleteExperienceDataResponse DeleteExperienceData(string id, string workspaceName, DeleteExperienceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperienceDataWithOptions(id, workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete experience data</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperienceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperienceDataResponse
        /// </returns>
        public async Task<DeleteExperienceDataResponse> DeleteExperienceDataAsync(string id, string workspaceName, DeleteExperienceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperienceDataWithOptionsAsync(id, workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFunctionInstanceResponse
        /// </returns>
        public DeleteFunctionInstanceResponse DeleteFunctionInstanceWithOptions(string workspaceName, string functionName, string instanceName, DeleteFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFunctionInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFunctionInstanceResponse
        /// </returns>
        public async Task<DeleteFunctionInstanceResponse> DeleteFunctionInstanceWithOptionsAsync(string workspaceName, string functionName, string instanceName, DeleteFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFunctionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFunctionInstanceResponse
        /// </returns>
        public DeleteFunctionInstanceResponse DeleteFunctionInstance(string workspaceName, string functionName, string instanceName, DeleteFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFunctionInstanceWithOptions(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFunctionInstanceResponse
        /// </returns>
        public async Task<DeleteFunctionInstanceResponse> DeleteFunctionInstanceAsync(string workspaceName, string functionName, string instanceName, DeleteFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFunctionInstanceWithOptionsAsync(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOfflineTaskResponse
        /// </returns>
        public DeleteOfflineTaskResponse DeleteOfflineTaskWithOptions(string workspaceName, string type, string taskName, DeleteOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOfflineTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOfflineTaskResponse
        /// </returns>
        public async Task<DeleteOfflineTaskResponse> DeleteOfflineTaskWithOptionsAsync(string workspaceName, string type, string taskName, DeleteOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOfflineTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOfflineTaskResponse
        /// </returns>
        public DeleteOfflineTaskResponse DeleteOfflineTask(string workspaceName, string type, string taskName, DeleteOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteOfflineTaskWithOptions(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOfflineTaskResponse
        /// </returns>
        public async Task<DeleteOfflineTaskResponse> DeleteOfflineTaskAsync(string workspaceName, string type, string taskName, DeleteOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteOfflineTaskWithOptionsAsync(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a RAG evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRagEvaluatorTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRagEvaluatorTaskResponse
        /// </returns>
        public DeleteRagEvaluatorTaskResponse DeleteRagEvaluatorTaskWithOptions(string workspaceName, string taskId, DeleteRagEvaluatorTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRagEvaluatorTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/rag-evaluator/v1/api/task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRagEvaluatorTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a RAG evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRagEvaluatorTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRagEvaluatorTaskResponse
        /// </returns>
        public async Task<DeleteRagEvaluatorTaskResponse> DeleteRagEvaluatorTaskWithOptionsAsync(string workspaceName, string taskId, DeleteRagEvaluatorTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRagEvaluatorTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/rag-evaluator/v1/api/task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRagEvaluatorTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a RAG evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRagEvaluatorTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRagEvaluatorTaskResponse
        /// </returns>
        public DeleteRagEvaluatorTaskResponse DeleteRagEvaluatorTask(string workspaceName, string taskId, DeleteRagEvaluatorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRagEvaluatorTaskWithOptions(workspaceName, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a RAG evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRagEvaluatorTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRagEvaluatorTaskResponse
        /// </returns>
        public async Task<DeleteRagEvaluatorTaskResponse> DeleteRagEvaluatorTaskAsync(string workspaceName, string taskId, DeleteRagEvaluatorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRagEvaluatorTaskWithOptionsAsync(workspaceName, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
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
        public DeleteWorkspaceResponse DeleteWorkspaceWithOptions(string workspaceName, DeleteWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
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
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
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
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceWithOptionsAsync(string workspaceName, DeleteWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
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
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspace(string workspaceName, DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWorkspaceWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(string workspaceName, DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWorkspaceWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the details of a configuration item of a specific category within a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to retrieve specific configuration information based on the provided workspace name, configuration category, and configuration name. Please ensure the parameters in the request path are accurate, especially the three required fields: <c>workspaceName</c>, <c>itemCategory</c>, and <c>itemName</c>. Additionally, please note that <c>itemCategory</c> currently only supports the <c>ai_search_agent</c> category.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCapabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapabilityResponse
        /// </returns>
        public DescribeCapabilityResponse DescribeCapabilityWithOptions(string workspaceName, string itemCategory, string itemName, DescribeCapabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCapability",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/capabilities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemCategory) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCapabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the details of a configuration item of a specific category within a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to retrieve specific configuration information based on the provided workspace name, configuration category, and configuration name. Please ensure the parameters in the request path are accurate, especially the three required fields: <c>workspaceName</c>, <c>itemCategory</c>, and <c>itemName</c>. Additionally, please note that <c>itemCategory</c> currently only supports the <c>ai_search_agent</c> category.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCapabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapabilityResponse
        /// </returns>
        public async Task<DescribeCapabilityResponse> DescribeCapabilityWithOptionsAsync(string workspaceName, string itemCategory, string itemName, DescribeCapabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCapability",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/capabilities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemCategory) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCapabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the details of a configuration item of a specific category within a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to retrieve specific configuration information based on the provided workspace name, configuration category, and configuration name. Please ensure the parameters in the request path are accurate, especially the three required fields: <c>workspaceName</c>, <c>itemCategory</c>, and <c>itemName</c>. Additionally, please note that <c>itemCategory</c> currently only supports the <c>ai_search_agent</c> category.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCapabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapabilityResponse
        /// </returns>
        public DescribeCapabilityResponse DescribeCapability(string workspaceName, string itemCategory, string itemName, DescribeCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCapabilityWithOptions(workspaceName, itemCategory, itemName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the details of a configuration item of a specific category within a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to retrieve specific configuration information based on the provided workspace name, configuration category, and configuration name. Please ensure the parameters in the request path are accurate, especially the three required fields: <c>workspaceName</c>, <c>itemCategory</c>, and <c>itemName</c>. Additionally, please note that <c>itemCategory</c> currently only supports the <c>ai_search_agent</c> category.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCapabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapabilityResponse
        /// </returns>
        public async Task<DescribeCapabilityResponse> DescribeCapabilityAsync(string workspaceName, string itemCategory, string itemName, DescribeCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCapabilityWithOptionsAsync(workspaceName, itemCategory, itemName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeRegions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeRegions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeRegions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeRegions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an asynchronous task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAsyncTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncTaskResponse
        /// </returns>
        public GetAsyncTaskResponse GetAsyncTaskWithOptions(string workspaceName, string id, GetAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/async-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an asynchronous task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAsyncTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncTaskResponse
        /// </returns>
        public async Task<GetAsyncTaskResponse> GetAsyncTaskWithOptionsAsync(string workspaceName, string id, GetAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/async-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an asynchronous task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncTaskResponse
        /// </returns>
        public GetAsyncTaskResponse GetAsyncTask(string workspaceName, string id, GetAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAsyncTaskWithOptions(workspaceName, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an asynchronous task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncTaskResponse
        /// </returns>
        public async Task<GetAsyncTaskResponse> GetAsyncTaskAsync(string workspaceName, string id, GetAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAsyncTaskWithOptionsAsync(workspaceName, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a specific type of configuration from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfigResponse
        /// </returns>
        public GetConfigResponse GetConfigWithOptions(string workspaceName, string configType, string id, GetConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfig",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a specific type of configuration from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfigResponse
        /// </returns>
        public async Task<GetConfigResponse> GetConfigWithOptionsAsync(string workspaceName, string configType, string id, GetConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfig",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a specific type of configuration from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfigResponse
        /// </returns>
        public GetConfigResponse GetConfig(string workspaceName, string configType, string id, GetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConfigWithOptions(workspaceName, configType, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a specific type of configuration from a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfigResponse
        /// </returns>
        public async Task<GetConfigResponse> GetConfigAsync(string workspaceName, string configType, string id, GetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConfigWithOptionsAsync(workspaceName, configType, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialsResponse
        /// </returns>
        public GetCredentialsResponse GetCredentialsWithOptions(string token, string workspaceName, GetCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCredentials",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(token),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialsResponse
        /// </returns>
        public async Task<GetCredentialsResponse> GetCredentialsWithOptionsAsync(string token, string workspaceName, GetCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCredentials",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(token),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialsResponse
        /// </returns>
        public GetCredentialsResponse GetCredentials(string token, string workspaceName, GetCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCredentialsWithOptions(token, workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialsResponse
        /// </returns>
        public async Task<GetCredentialsResponse> GetCredentialsAsync(string token, string workspaceName, GetCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCredentialsWithOptionsAsync(token, workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of experience data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperienceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperienceDataResponse
        /// </returns>
        public GetExperienceDataResponse GetExperienceDataWithOptions(string workspaceName, string id, GetExperienceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperienceData",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/experience-data/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperienceDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of experience data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperienceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperienceDataResponse
        /// </returns>
        public async Task<GetExperienceDataResponse> GetExperienceDataWithOptionsAsync(string workspaceName, string id, GetExperienceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperienceData",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/experience-data/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperienceDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of experience data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperienceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperienceDataResponse
        /// </returns>
        public GetExperienceDataResponse GetExperienceData(string workspaceName, string id, GetExperienceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperienceDataWithOptions(workspaceName, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of experience data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperienceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperienceDataResponse
        /// </returns>
        public async Task<GetExperienceDataResponse> GetExperienceDataAsync(string workspaceName, string id, GetExperienceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperienceDataWithOptionsAsync(workspaceName, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific feature instance in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFunctionInstanceResponse
        /// </returns>
        public GetFunctionInstanceResponse GetFunctionInstanceWithOptions(string workspaceName, string functionName, string instanceName, GetFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["output"] = request.Output;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific feature instance in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFunctionInstanceResponse
        /// </returns>
        public async Task<GetFunctionInstanceResponse> GetFunctionInstanceWithOptionsAsync(string workspaceName, string functionName, string instanceName, GetFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["output"] = request.Output;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific feature instance in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFunctionInstanceResponse
        /// </returns>
        public GetFunctionInstanceResponse GetFunctionInstance(string workspaceName, string functionName, string instanceName, GetFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionInstanceWithOptions(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific feature instance in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFunctionInstanceResponse
        /// </returns>
        public async Task<GetFunctionInstanceResponse> GetFunctionInstanceAsync(string workspaceName, string functionName, string instanceName, GetFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionInstanceWithOptionsAsync(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about an offline node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfflineTaskResponse
        /// </returns>
        public GetOfflineTaskResponse GetOfflineTaskWithOptions(string workspaceName, string type, string taskName, GetOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfflineTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about an offline node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfflineTaskResponse
        /// </returns>
        public async Task<GetOfflineTaskResponse> GetOfflineTaskWithOptionsAsync(string workspaceName, string type, string taskName, GetOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfflineTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about an offline node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOfflineTaskResponse
        /// </returns>
        public GetOfflineTaskResponse GetOfflineTask(string workspaceName, string type, string taskName, GetOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOfflineTaskWithOptions(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about an offline node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOfflineTaskResponse
        /// </returns>
        public async Task<GetOfflineTaskResponse> GetOfflineTaskAsync(string workspaceName, string type, string taskName, GetOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOfflineTaskWithOptionsAsync(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of offline task logs in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation allows you to retrieve offline task logs information by specifying the workspace name, node type, and node name.</description></item>
        /// <item><description>Provide a valid <c>regionId</c> as one of the query parameters to specify the area for the request.</description></item>
        /// <item><description>The returned information includes but is not limited to network configurations (private ES and public ES) and their enabling status, domain names, and IP whitelist groups.</description></item>
        /// <item><description>Note: Ensure that you have sufficient permissions (such as the <c>GetLog</c> action in the RAM policy) to invoke this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOfflineTaskLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfflineTaskLogResponse
        /// </returns>
        public GetOfflineTaskLogResponse GetOfflineTaskLogWithOptions(string workspaceName, string type, string taskName, GetOfflineTaskLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfflineTaskLog",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfflineTaskLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of offline task logs in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation allows you to retrieve offline task logs information by specifying the workspace name, node type, and node name.</description></item>
        /// <item><description>Provide a valid <c>regionId</c> as one of the query parameters to specify the area for the request.</description></item>
        /// <item><description>The returned information includes but is not limited to network configurations (private ES and public ES) and their enabling status, domain names, and IP whitelist groups.</description></item>
        /// <item><description>Note: Ensure that you have sufficient permissions (such as the <c>GetLog</c> action in the RAM policy) to invoke this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOfflineTaskLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfflineTaskLogResponse
        /// </returns>
        public async Task<GetOfflineTaskLogResponse> GetOfflineTaskLogWithOptionsAsync(string workspaceName, string type, string taskName, GetOfflineTaskLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfflineTaskLog",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfflineTaskLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of offline task logs in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation allows you to retrieve offline task logs information by specifying the workspace name, node type, and node name.</description></item>
        /// <item><description>Provide a valid <c>regionId</c> as one of the query parameters to specify the area for the request.</description></item>
        /// <item><description>The returned information includes but is not limited to network configurations (private ES and public ES) and their enabling status, domain names, and IP whitelist groups.</description></item>
        /// <item><description>Note: Ensure that you have sufficient permissions (such as the <c>GetLog</c> action in the RAM policy) to invoke this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOfflineTaskLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOfflineTaskLogResponse
        /// </returns>
        public GetOfflineTaskLogResponse GetOfflineTaskLog(string workspaceName, string type, string taskName, GetOfflineTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOfflineTaskLogWithOptions(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of offline task logs in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation allows you to retrieve offline task logs information by specifying the workspace name, node type, and node name.</description></item>
        /// <item><description>Provide a valid <c>regionId</c> as one of the query parameters to specify the area for the request.</description></item>
        /// <item><description>The returned information includes but is not limited to network configurations (private ES and public ES) and their enabling status, domain names, and IP whitelist groups.</description></item>
        /// <item><description>Note: Ensure that you have sufficient permissions (such as the <c>GetLog</c> action in the RAM policy) to invoke this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOfflineTaskLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOfflineTaskLogResponse
        /// </returns>
        public async Task<GetOfflineTaskLogResponse> GetOfflineTaskLogAsync(string workspaceName, string type, string taskName, GetOfflineTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOfflineTaskLogWithOptionsAsync(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a RAG evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRagEvaluatorTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRagEvaluatorTaskResponse
        /// </returns>
        public GetRagEvaluatorTaskResponse GetRagEvaluatorTaskWithOptions(string workspaceName, string taskId, GetRagEvaluatorTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRagEvaluatorTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/rag-evaluator/v1/api/task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRagEvaluatorTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a RAG evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRagEvaluatorTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRagEvaluatorTaskResponse
        /// </returns>
        public async Task<GetRagEvaluatorTaskResponse> GetRagEvaluatorTaskWithOptionsAsync(string workspaceName, string taskId, GetRagEvaluatorTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRagEvaluatorTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/rag-evaluator/v1/api/task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRagEvaluatorTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a RAG evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRagEvaluatorTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRagEvaluatorTaskResponse
        /// </returns>
        public GetRagEvaluatorTaskResponse GetRagEvaluatorTask(string workspaceName, string taskId, GetRagEvaluatorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRagEvaluatorTaskWithOptions(workspaceName, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a RAG evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRagEvaluatorTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRagEvaluatorTaskResponse
        /// </returns>
        public async Task<GetRagEvaluatorTaskResponse> GetRagEvaluatorTaskAsync(string workspaceName, string taskId, GetRagEvaluatorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRagEvaluatorTaskWithOptionsAsync(workspaceName, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves data table field information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableColumnsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableColumnsResponse
        /// </returns>
        public GetTableColumnsResponse GetTableColumnsWithOptions(string workspaceName, string dataSourceType, GetTableColumnsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableColumns",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceType) + "/columns",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableColumnsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves data table field information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableColumnsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableColumnsResponse
        /// </returns>
        public async Task<GetTableColumnsResponse> GetTableColumnsWithOptionsAsync(string workspaceName, string dataSourceType, GetTableColumnsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableColumns",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceType) + "/columns",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableColumnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves data table field information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableColumnsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableColumnsResponse
        /// </returns>
        public GetTableColumnsResponse GetTableColumns(string workspaceName, string dataSourceType, GetTableColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableColumnsWithOptions(workspaceName, dataSourceType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves data table field information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableColumnsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableColumnsResponse
        /// </returns>
        public async Task<GetTableColumnsResponse> GetTableColumnsAsync(string workspaceName, string dataSourceType, GetTableColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableColumnsWithOptionsAsync(workspaceName, dataSourceType, request, headers, runtime);
        }

        /// <param name="request">
        /// GetTableFieldsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableFieldsResponse
        /// </returns>
        public GetTableFieldsResponse GetTableFieldsWithOptions(string workspaceName, string dataSourceType, GetTableFieldsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawType))
            {
                query["rawType"] = request.RawType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableFields",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceType) + "/fields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableFieldsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetTableFieldsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableFieldsResponse
        /// </returns>
        public async Task<GetTableFieldsResponse> GetTableFieldsWithOptionsAsync(string workspaceName, string dataSourceType, GetTableFieldsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawType))
            {
                query["rawType"] = request.RawType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableFields",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceType) + "/fields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableFieldsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetTableFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableFieldsResponse
        /// </returns>
        public GetTableFieldsResponse GetTableFields(string workspaceName, string dataSourceType, GetTableFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableFieldsWithOptions(workspaceName, dataSourceType, request, headers, runtime);
        }

        /// <param name="request">
        /// GetTableFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableFieldsResponse
        /// </returns>
        public async Task<GetTableFieldsResponse> GetTableFieldsAsync(string workspaceName, string dataSourceType, GetTableFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableFieldsWithOptionsAsync(workspaceName, dataSourceType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves data tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTablesResponse
        /// </returns>
        public GetTablesResponse GetTablesWithOptions(string workspaceName, string dataSourceType, GetTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTables",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceType) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves data tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTablesResponse
        /// </returns>
        public async Task<GetTablesResponse> GetTablesWithOptionsAsync(string workspaceName, string dataSourceType, GetTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTables",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceType) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves data tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTablesResponse
        /// </returns>
        public GetTablesResponse GetTables(string workspaceName, string dataSourceType, GetTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTablesWithOptions(workspaceName, dataSourceType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves data tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTablesResponse
        /// </returns>
        public async Task<GetTablesResponse> GetTablesAsync(string workspaceName, string dataSourceType, GetTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTablesWithOptionsAsync(workspaceName, dataSourceType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
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
        public GetWorkspaceResponse GetWorkspaceWithOptions(string workspaceName, GetWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
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
        /// <para>Retrieves a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
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
        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceName, GetWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
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
        /// <para>Retrieves a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspace(string workspaceName, GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkspaceWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceName, GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkspaceWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of asynchronous tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsyncTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTasksResponse
        /// </returns>
        public ListAsyncTasksResponse ListAsyncTasksWithOptions(string workspaceName, ListAsyncTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
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
                Action = "ListAsyncTasks",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/async-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsyncTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of asynchronous tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsyncTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTasksResponse
        /// </returns>
        public async Task<ListAsyncTasksResponse> ListAsyncTasksWithOptionsAsync(string workspaceName, ListAsyncTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
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
                Action = "ListAsyncTasks",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/async-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsyncTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of asynchronous tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsyncTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTasksResponse
        /// </returns>
        public ListAsyncTasksResponse ListAsyncTasks(string workspaceName, ListAsyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAsyncTasksWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of asynchronous tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsyncTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTasksResponse
        /// </returns>
        public async Task<ListAsyncTasksResponse> ListAsyncTasksAsync(string workspaceName, ListAsyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAsyncTasksWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of configuration items of a specific category in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>You can use this API operation to retrieve the list of configuration items based on the specified workspace name and configuration category. Paged query is supported. Use the <c>pageNumber</c> and <c>pageSize</c> parameters to control the number of results and the page number. The <c>nextToken</c> and <c>maxResults</c> parameters are also provided for paged query when handling large amounts of data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCapabilitiesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCapabilitiesResponse
        /// </returns>
        public ListCapabilitiesResponse ListCapabilitiesWithOptions(string workspaceName, string itemCategory, ListCapabilitiesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCapabilities",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/capabilities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemCategory) + "/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCapabilitiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of configuration items of a specific category in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>You can use this API operation to retrieve the list of configuration items based on the specified workspace name and configuration category. Paged query is supported. Use the <c>pageNumber</c> and <c>pageSize</c> parameters to control the number of results and the page number. The <c>nextToken</c> and <c>maxResults</c> parameters are also provided for paged query when handling large amounts of data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCapabilitiesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCapabilitiesResponse
        /// </returns>
        public async Task<ListCapabilitiesResponse> ListCapabilitiesWithOptionsAsync(string workspaceName, string itemCategory, ListCapabilitiesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCapabilities",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/capabilities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemCategory) + "/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCapabilitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of configuration items of a specific category in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>You can use this API operation to retrieve the list of configuration items based on the specified workspace name and configuration category. Paged query is supported. Use the <c>pageNumber</c> and <c>pageSize</c> parameters to control the number of results and the page number. The <c>nextToken</c> and <c>maxResults</c> parameters are also provided for paged query when handling large amounts of data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCapabilitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCapabilitiesResponse
        /// </returns>
        public ListCapabilitiesResponse ListCapabilities(string workspaceName, string itemCategory, ListCapabilitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCapabilitiesWithOptions(workspaceName, itemCategory, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of configuration items of a specific category in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>You can use this API operation to retrieve the list of configuration items based on the specified workspace name and configuration category. Paged query is supported. Use the <c>pageNumber</c> and <c>pageSize</c> parameters to control the number of results and the page number. The <c>nextToken</c> and <c>maxResults</c> parameters are also provided for paged query when handling large amounts of data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCapabilitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCapabilitiesResponse
        /// </returns>
        public async Task<ListCapabilitiesResponse> ListCapabilitiesAsync(string workspaceName, string itemCategory, ListCapabilitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCapabilitiesWithOptionsAsync(workspaceName, itemCategory, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of configurations of a specific type in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConfigsResponse
        /// </returns>
        public ListConfigsResponse ListConfigsWithOptions(string workspaceName, string configType, ListConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigs",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configType),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of configurations of a specific type in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConfigsResponse
        /// </returns>
        public async Task<ListConfigsResponse> ListConfigsWithOptionsAsync(string workspaceName, string configType, ListConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigs",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configType),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of configurations of a specific type in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConfigsResponse
        /// </returns>
        public ListConfigsResponse ListConfigs(string workspaceName, string configType, ListConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConfigsWithOptions(workspaceName, configType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of configurations of a specific type in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConfigsResponse
        /// </returns>
        public async Task<ListConfigsResponse> ListConfigsAsync(string workspaceName, string configType, ListConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConfigsWithOptionsAsync(workspaceName, configType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of access credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public ListCredentialsResponse ListCredentialsWithOptions(string workspaceName, ListCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCredentials",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/credentials",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of access credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public async Task<ListCredentialsResponse> ListCredentialsWithOptionsAsync(string workspaceName, ListCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCredentials",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/credentials",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of access credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public ListCredentialsResponse ListCredentials(string workspaceName, ListCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCredentialsWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of access credentials.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public async Task<ListCredentialsResponse> ListCredentialsAsync(string workspaceName, ListCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCredentialsWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all experience data in a specified workspace, with support for filtering by service type and data type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation queries all experience data of a user in a specific workspace. The results are sorted by creation time in descending order by default.</description></item>
        /// <item><description>Pagination is not supported. However, you can filter data by using the serviceType and dataType parameters.</description></item>
        /// <item><description>workspaceName is a path parameter and must be specified to indicate the workspace to query.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExperienceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperienceDataResponse
        /// </returns>
        public ListExperienceDataResponse ListExperienceDataWithOptions(string workspaceName, ListExperienceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["dataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
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
                Action = "ListExperienceData",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/experience-data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperienceDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all experience data in a specified workspace, with support for filtering by service type and data type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation queries all experience data of a user in a specific workspace. The results are sorted by creation time in descending order by default.</description></item>
        /// <item><description>Pagination is not supported. However, you can filter data by using the serviceType and dataType parameters.</description></item>
        /// <item><description>workspaceName is a path parameter and must be specified to indicate the workspace to query.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExperienceDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperienceDataResponse
        /// </returns>
        public async Task<ListExperienceDataResponse> ListExperienceDataWithOptionsAsync(string workspaceName, ListExperienceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["dataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
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
                Action = "ListExperienceData",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/experience-data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperienceDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all experience data in a specified workspace, with support for filtering by service type and data type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation queries all experience data of a user in a specific workspace. The results are sorted by creation time in descending order by default.</description></item>
        /// <item><description>Pagination is not supported. However, you can filter data by using the serviceType and dataType parameters.</description></item>
        /// <item><description>workspaceName is a path parameter and must be specified to indicate the workspace to query.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExperienceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExperienceDataResponse
        /// </returns>
        public ListExperienceDataResponse ListExperienceData(string workspaceName, ListExperienceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperienceDataWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all experience data in a specified workspace, with support for filtering by service type and data type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation queries all experience data of a user in a specific workspace. The results are sorted by creation time in descending order by default.</description></item>
        /// <item><description>Pagination is not supported. However, you can filter data by using the serviceType and dataType parameters.</description></item>
        /// <item><description>workspaceName is a path parameter and must be specified to indicate the workspace to query.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExperienceDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExperienceDataResponse
        /// </returns>
        public async Task<ListExperienceDataResponse> ListExperienceDataAsync(string workspaceName, ListExperienceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperienceDataWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of service configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionInstancesResponse
        /// </returns>
        public ListFunctionInstancesResponse ListFunctionInstancesWithOptions(string workspaceName, string functionName, ListFunctionInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                query["functionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionInstances",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of service configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionInstancesResponse
        /// </returns>
        public async Task<ListFunctionInstancesResponse> ListFunctionInstancesWithOptionsAsync(string workspaceName, string functionName, ListFunctionInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                query["functionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionInstances",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of service configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionInstancesResponse
        /// </returns>
        public ListFunctionInstancesResponse ListFunctionInstances(string workspaceName, string functionName, ListFunctionInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionInstancesWithOptions(workspaceName, functionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of service configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionInstancesResponse
        /// </returns>
        public async Task<ListFunctionInstancesResponse> ListFunctionInstancesAsync(string workspaceName, string functionName, ListFunctionInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionInstancesWithOptionsAsync(workspaceName, functionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the restriction items of a feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionRestrictionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionRestrictionsResponse
        /// </returns>
        public ListFunctionRestrictionsResponse ListFunctionRestrictionsWithOptions(string workspaceName, string functionName, string restrictionName, ListFunctionRestrictionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionRestrictions",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/restrictions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(restrictionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionRestrictionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the restriction items of a feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionRestrictionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionRestrictionsResponse
        /// </returns>
        public async Task<ListFunctionRestrictionsResponse> ListFunctionRestrictionsWithOptionsAsync(string workspaceName, string functionName, string restrictionName, ListFunctionRestrictionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionRestrictions",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/restrictions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(restrictionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionRestrictionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the restriction items of a feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionRestrictionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionRestrictionsResponse
        /// </returns>
        public ListFunctionRestrictionsResponse ListFunctionRestrictions(string workspaceName, string functionName, string restrictionName, ListFunctionRestrictionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionRestrictionsWithOptions(workspaceName, functionName, restrictionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the restriction items of a feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionRestrictionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionRestrictionsResponse
        /// </returns>
        public async Task<ListFunctionRestrictionsResponse> ListFunctionRestrictionsAsync(string workspaceName, string functionName, string restrictionName, ListFunctionRestrictionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionRestrictionsWithOptionsAsync(workspaceName, functionName, restrictionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Offline Task Information List</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOfflineTaskResponse
        /// </returns>
        public ListOfflineTaskResponse ListOfflineTaskWithOptions(string workspaceName, string type, ListOfflineTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListOfflineTaskShrinkRequest request = new ListOfflineTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "labels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskStatus))
            {
                request.TaskStatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskStatus, "taskStatus", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["labels"] = request.LabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatusShrink))
            {
                query["taskStatus"] = request.TaskStatusShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOfflineTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Offline Task Information List</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOfflineTaskResponse
        /// </returns>
        public async Task<ListOfflineTaskResponse> ListOfflineTaskWithOptionsAsync(string workspaceName, string type, ListOfflineTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListOfflineTaskShrinkRequest request = new ListOfflineTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "labels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskStatus))
            {
                request.TaskStatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskStatus, "taskStatus", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["labels"] = request.LabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatusShrink))
            {
                query["taskStatus"] = request.TaskStatusShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOfflineTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Offline Task Information List</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOfflineTaskResponse
        /// </returns>
        public ListOfflineTaskResponse ListOfflineTask(string workspaceName, string type, ListOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOfflineTaskWithOptions(workspaceName, type, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Offline Task Information List</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOfflineTaskResponse
        /// </returns>
        public async Task<ListOfflineTaskResponse> ListOfflineTaskAsync(string workspaceName, string type, ListOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOfflineTaskWithOptionsAsync(workspaceName, type, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the error log list of batch tasks in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation retrieves error logs for a specific workspace, node type, and node name.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters allow you to define a custom query time range. If not provided, data from the past hour is queried by default.</description></item>
        /// <item><description>The paging parameters <c>pageNum</c> and <c>pageSize</c> help control the number of returned results and page navigation. They represent the requested page number and the number of log entries per page, with default values of 1 and 10 respectively.</description></item>
        /// <item><description>Note: Ensure that you have obtained the required RAM permissions (Action: ListErrorLogs) before you invoke this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOfflineTaskErrorLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOfflineTaskErrorLogsResponse
        /// </returns>
        public ListOfflineTaskErrorLogsResponse ListOfflineTaskErrorLogsWithOptions(string workspaceName, string type, string taskName, ListOfflineTaskErrorLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOfflineTaskErrorLogs",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/error-logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOfflineTaskErrorLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the error log list of batch tasks in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation retrieves error logs for a specific workspace, node type, and node name.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters allow you to define a custom query time range. If not provided, data from the past hour is queried by default.</description></item>
        /// <item><description>The paging parameters <c>pageNum</c> and <c>pageSize</c> help control the number of returned results and page navigation. They represent the requested page number and the number of log entries per page, with default values of 1 and 10 respectively.</description></item>
        /// <item><description>Note: Ensure that you have obtained the required RAM permissions (Action: ListErrorLogs) before you invoke this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOfflineTaskErrorLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOfflineTaskErrorLogsResponse
        /// </returns>
        public async Task<ListOfflineTaskErrorLogsResponse> ListOfflineTaskErrorLogsWithOptionsAsync(string workspaceName, string type, string taskName, ListOfflineTaskErrorLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOfflineTaskErrorLogs",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/error-logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOfflineTaskErrorLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the error log list of batch tasks in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation retrieves error logs for a specific workspace, node type, and node name.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters allow you to define a custom query time range. If not provided, data from the past hour is queried by default.</description></item>
        /// <item><description>The paging parameters <c>pageNum</c> and <c>pageSize</c> help control the number of returned results and page navigation. They represent the requested page number and the number of log entries per page, with default values of 1 and 10 respectively.</description></item>
        /// <item><description>Note: Ensure that you have obtained the required RAM permissions (Action: ListErrorLogs) before you invoke this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOfflineTaskErrorLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOfflineTaskErrorLogsResponse
        /// </returns>
        public ListOfflineTaskErrorLogsResponse ListOfflineTaskErrorLogs(string workspaceName, string type, string taskName, ListOfflineTaskErrorLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOfflineTaskErrorLogsWithOptions(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the error log list of batch tasks in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation retrieves error logs for a specific workspace, node type, and node name.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters allow you to define a custom query time range. If not provided, data from the past hour is queried by default.</description></item>
        /// <item><description>The paging parameters <c>pageNum</c> and <c>pageSize</c> help control the number of returned results and page navigation. They represent the requested page number and the number of log entries per page, with default values of 1 and 10 respectively.</description></item>
        /// <item><description>Note: Ensure that you have obtained the required RAM permissions (Action: ListErrorLogs) before you invoke this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOfflineTaskErrorLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOfflineTaskErrorLogsResponse
        /// </returns>
        public async Task<ListOfflineTaskErrorLogsResponse> ListOfflineTaskErrorLogsAsync(string workspaceName, string type, string taskName, ListOfflineTaskErrorLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOfflineTaskErrorLogsWithOptionsAsync(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of RAG evaluation tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRagEvaluatorTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRagEvaluatorTasksResponse
        /// </returns>
        public ListRagEvaluatorTasksResponse ListRagEvaluatorTasksWithOptions(string workspaceName, ListRagEvaluatorTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRagEvaluatorTasks",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/rag-evaluator/v1/api/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRagEvaluatorTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of RAG evaluation tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRagEvaluatorTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRagEvaluatorTasksResponse
        /// </returns>
        public async Task<ListRagEvaluatorTasksResponse> ListRagEvaluatorTasksWithOptionsAsync(string workspaceName, ListRagEvaluatorTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRagEvaluatorTasks",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/rag-evaluator/v1/api/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRagEvaluatorTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of RAG evaluation tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRagEvaluatorTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRagEvaluatorTasksResponse
        /// </returns>
        public ListRagEvaluatorTasksResponse ListRagEvaluatorTasks(string workspaceName, ListRagEvaluatorTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRagEvaluatorTasksWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of RAG evaluation tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRagEvaluatorTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRagEvaluatorTasksResponse
        /// </returns>
        public async Task<ListRagEvaluatorTasksResponse> ListRagEvaluatorTasksAsync(string workspaceName, ListRagEvaluatorTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRagEvaluatorTasksWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of services.</para>
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
        public ListServicesResponse ListServicesWithOptions(string workspaceName, ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
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
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/services",
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
        /// <para>Retrieves the list of services.</para>
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
        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(string workspaceName, ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["serviceId"] = request.ServiceId;
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
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/services",
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
        /// <para>Retrieves the list of services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public ListServicesResponse ListServices(string workspaceName, ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServicesWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public async Task<ListServicesResponse> ListServicesAsync(string workspaceName, ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServicesWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
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
                Action = "ListWorkspaces",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces",
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
        /// <para>Retrieves a list of workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
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
                Action = "ListWorkspaces",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces",
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
        /// <para>Retrieves a list of workspaces.</para>
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
        /// <para>Retrieves a list of workspaces.</para>
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
        /// <para>Updates a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOfflineTaskResponse
        /// </returns>
        public ModifyOfflineTaskResponse ModifyOfflineTaskWithOptions(string workspaceName, string type, string taskName, ModifyOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Meta))
            {
                body["meta"] = request.Meta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processors))
            {
                body["processors"] = request.Processors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sink))
            {
                body["sink"] = request.Sink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOfflineTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOfflineTaskResponse
        /// </returns>
        public async Task<ModifyOfflineTaskResponse> ModifyOfflineTaskWithOptionsAsync(string workspaceName, string type, string taskName, ModifyOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Meta))
            {
                body["meta"] = request.Meta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processors))
            {
                body["processors"] = request.Processors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sink))
            {
                body["sink"] = request.Sink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOfflineTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyOfflineTaskResponse
        /// </returns>
        public ModifyOfflineTaskResponse ModifyOfflineTask(string workspaceName, string type, string taskName, ModifyOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyOfflineTaskWithOptions(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyOfflineTaskResponse
        /// </returns>
        public async Task<ModifyOfflineTaskResponse> ModifyOfflineTaskAsync(string workspaceName, string type, string taskName, ModifyOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyOfflineTaskWithOptionsAsync(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network configuration for batch task log scenarios, including enabling or disabling public and private network access and setting IP whitelists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API allows you to adjust network-related configurations for a specific type of batch node within a specified workspace.</description></item>
        /// <item><description>Use this operation to control public or private network access permissions for the ES service and set the corresponding IP whitelists.</description></item>
        /// <item><description>When you need to change any network settings (such as enabling or shutting down public network access or updating IP whitelists), ensure that the <c>network</c> object contains the correct parameters.</description></item>
        /// <item><description>Note: Executing this operation may affect currently running nodes. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyOfflineTaskLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOfflineTaskLogResponse
        /// </returns>
        public ModifyOfflineTaskLogResponse ModifyOfflineTaskLogWithOptions(string workspaceName, string type, string taskName, ModifyOfflineTaskLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOfflineTaskLog",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/log",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOfflineTaskLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network configuration for batch task log scenarios, including enabling or disabling public and private network access and setting IP whitelists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API allows you to adjust network-related configurations for a specific type of batch node within a specified workspace.</description></item>
        /// <item><description>Use this operation to control public or private network access permissions for the ES service and set the corresponding IP whitelists.</description></item>
        /// <item><description>When you need to change any network settings (such as enabling or shutting down public network access or updating IP whitelists), ensure that the <c>network</c> object contains the correct parameters.</description></item>
        /// <item><description>Note: Executing this operation may affect currently running nodes. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyOfflineTaskLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOfflineTaskLogResponse
        /// </returns>
        public async Task<ModifyOfflineTaskLogResponse> ModifyOfflineTaskLogWithOptionsAsync(string workspaceName, string type, string taskName, ModifyOfflineTaskLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOfflineTaskLog",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/log",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOfflineTaskLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network configuration for batch task log scenarios, including enabling or disabling public and private network access and setting IP whitelists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API allows you to adjust network-related configurations for a specific type of batch node within a specified workspace.</description></item>
        /// <item><description>Use this operation to control public or private network access permissions for the ES service and set the corresponding IP whitelists.</description></item>
        /// <item><description>When you need to change any network settings (such as enabling or shutting down public network access or updating IP whitelists), ensure that the <c>network</c> object contains the correct parameters.</description></item>
        /// <item><description>Note: Executing this operation may affect currently running nodes. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyOfflineTaskLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyOfflineTaskLogResponse
        /// </returns>
        public ModifyOfflineTaskLogResponse ModifyOfflineTaskLog(string workspaceName, string type, string taskName, ModifyOfflineTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyOfflineTaskLogWithOptions(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the network configuration for batch task log scenarios, including enabling or disabling public and private network access and setting IP whitelists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API allows you to adjust network-related configurations for a specific type of batch node within a specified workspace.</description></item>
        /// <item><description>Use this operation to control public or private network access permissions for the ES service and set the corresponding IP whitelists.</description></item>
        /// <item><description>When you need to change any network settings (such as enabling or shutting down public network access or updating IP whitelists), ensure that the <c>network</c> object contains the correct parameters.</description></item>
        /// <item><description>Note: Executing this operation may affect currently running nodes. Proceed with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyOfflineTaskLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyOfflineTaskLogResponse
        /// </returns>
        public async Task<ModifyOfflineTaskLogResponse> ModifyOfflineTaskLogAsync(string workspaceName, string type, string taskName, ModifyOfflineTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyOfflineTaskLogWithOptionsAsync(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeFunctionInstanceResponse
        /// </returns>
        public ResumeFunctionInstanceResponse ResumeFunctionInstanceWithOptions(string workspaceName, string functionName, string instanceName, ResumeFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/actions/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeFunctionInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeFunctionInstanceResponse
        /// </returns>
        public async Task<ResumeFunctionInstanceResponse> ResumeFunctionInstanceWithOptionsAsync(string workspaceName, string functionName, string instanceName, ResumeFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/actions/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeFunctionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeFunctionInstanceResponse
        /// </returns>
        public ResumeFunctionInstanceResponse ResumeFunctionInstance(string workspaceName, string functionName, string instanceName, ResumeFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeFunctionInstanceWithOptions(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeFunctionInstanceResponse
        /// </returns>
        public async Task<ResumeFunctionInstanceResponse> ResumeFunctionInstanceAsync(string workspaceName, string functionName, string instanceName, ResumeFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeFunctionInstanceWithOptionsAsync(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a batch task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// StartOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartOfflineTaskResponse
        /// </returns>
        public StartOfflineTaskResponse StartOfflineTaskWithOptions(string workspaceName, string type, string taskName, StartOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                body["parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                body["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/actions/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartOfflineTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a batch task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// StartOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartOfflineTaskResponse
        /// </returns>
        public async Task<StartOfflineTaskResponse> StartOfflineTaskWithOptionsAsync(string workspaceName, string type, string taskName, StartOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                body["parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                body["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/actions/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartOfflineTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a batch task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// StartOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartOfflineTaskResponse
        /// </returns>
        public StartOfflineTaskResponse StartOfflineTask(string workspaceName, string type, string taskName, StartOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartOfflineTaskWithOptions(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a batch task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// StartOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartOfflineTaskResponse
        /// </returns>
        public async Task<StartOfflineTaskResponse> StartOfflineTaskAsync(string workspaceName, string type, string taskName, StartOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartOfflineTaskWithOptionsAsync(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopOfflineTaskResponse
        /// </returns>
        public StopOfflineTaskResponse StopOfflineTaskWithOptions(string workspaceName, string type, string taskName, StopOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                body["parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                body["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/actions/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopOfflineTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopOfflineTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopOfflineTaskResponse
        /// </returns>
        public async Task<StopOfflineTaskResponse> StopOfflineTaskWithOptionsAsync(string workspaceName, string type, string taskName, StopOfflineTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                body["parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                body["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopOfflineTask",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/offline-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/actions/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopOfflineTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopOfflineTaskResponse
        /// </returns>
        public StopOfflineTaskResponse StopOfflineTask(string workspaceName, string type, string taskName, StopOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopOfflineTaskWithOptions(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a batch task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopOfflineTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopOfflineTaskResponse
        /// </returns>
        public async Task<StopOfflineTaskResponse> StopOfflineTaskAsync(string workspaceName, string type, string taskName, StopOfflineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopOfflineTaskWithOptionsAsync(workspaceName, type, taskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a specific configuration item in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation allows you to update a specific configuration item (<c>itemName</c>) under a category (<c>itemCategory</c>) in a specified workspace (<c>workspaceName</c>). By setting the <c>dryRun</c> parameter, you can preview changes without actually applying them. The request body can contain a new configuration description (<c>itemDesc</c>) and configuration content (<c>itemValue</c>). The structure of <c>itemValue</c> must conform to the requirements of the target configuration item.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCapabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCapabilityResponse
        /// </returns>
        public UpdateCapabilityResponse UpdateCapabilityWithOptions(string workspaceName, string itemCategory, string itemName, UpdateCapabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemDesc))
            {
                body["itemDesc"] = request.ItemDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemValue))
            {
                body["itemValue"] = request.ItemValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCapability",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/capabilities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemCategory) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCapabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a specific configuration item in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation allows you to update a specific configuration item (<c>itemName</c>) under a category (<c>itemCategory</c>) in a specified workspace (<c>workspaceName</c>). By setting the <c>dryRun</c> parameter, you can preview changes without actually applying them. The request body can contain a new configuration description (<c>itemDesc</c>) and configuration content (<c>itemValue</c>). The structure of <c>itemValue</c> must conform to the requirements of the target configuration item.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCapabilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCapabilityResponse
        /// </returns>
        public async Task<UpdateCapabilityResponse> UpdateCapabilityWithOptionsAsync(string workspaceName, string itemCategory, string itemName, UpdateCapabilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemDesc))
            {
                body["itemDesc"] = request.ItemDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemValue))
            {
                body["itemValue"] = request.ItemValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCapability",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/capabilities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemCategory) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(itemName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCapabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a specific configuration item in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation allows you to update a specific configuration item (<c>itemName</c>) under a category (<c>itemCategory</c>) in a specified workspace (<c>workspaceName</c>). By setting the <c>dryRun</c> parameter, you can preview changes without actually applying them. The request body can contain a new configuration description (<c>itemDesc</c>) and configuration content (<c>itemValue</c>). The structure of <c>itemValue</c> must conform to the requirements of the target configuration item.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCapabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCapabilityResponse
        /// </returns>
        public UpdateCapabilityResponse UpdateCapability(string workspaceName, string itemCategory, string itemName, UpdateCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCapabilityWithOptions(workspaceName, itemCategory, itemName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a specific configuration item in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation allows you to update a specific configuration item (<c>itemName</c>) under a category (<c>itemCategory</c>) in a specified workspace (<c>workspaceName</c>). By setting the <c>dryRun</c> parameter, you can preview changes without actually applying them. The request body can contain a new configuration description (<c>itemDesc</c>) and configuration content (<c>itemValue</c>). The structure of <c>itemValue</c> must conform to the requirements of the target configuration item.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCapabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCapabilityResponse
        /// </returns>
        public async Task<UpdateCapabilityResponse> UpdateCapabilityAsync(string workspaceName, string itemCategory, string itemName, UpdateCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCapabilityWithOptionsAsync(workspaceName, itemCategory, itemName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specific type in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigResponse
        /// </returns>
        public UpdateConfigResponse UpdateConfigWithOptions(string workspaceName, string configType, UpdateConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigData))
            {
                body["configData"] = request.ConfigData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfig",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configType),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specific type in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigResponse
        /// </returns>
        public async Task<UpdateConfigResponse> UpdateConfigWithOptionsAsync(string workspaceName, string configType, UpdateConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigData))
            {
                body["configData"] = request.ConfigData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfig",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configType),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specific type in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigResponse
        /// </returns>
        public UpdateConfigResponse UpdateConfig(string workspaceName, string configType, UpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConfigWithOptions(workspaceName, configType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specific type in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigResponse
        /// </returns>
        public async Task<UpdateConfigResponse> UpdateConfigAsync(string workspaceName, string configType, UpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConfigWithOptionsAsync(workspaceName, configType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialsResponse
        /// </returns>
        public UpdateCredentialsResponse UpdateCredentialsWithOptions(string token, string workspaceName, UpdateCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCredentials",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(token),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialsResponse
        /// </returns>
        public async Task<UpdateCredentialsResponse> UpdateCredentialsWithOptionsAsync(string token, string workspaceName, UpdateCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCredentials",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(token),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialsResponse
        /// </returns>
        public UpdateCredentialsResponse UpdateCredentials(string token, string workspaceName, UpdateCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCredentialsWithOptions(token, workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an access credential.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialsResponse
        /// </returns>
        public async Task<UpdateCredentialsResponse> UpdateCredentialsAsync(string token, string workspaceName, UpdateCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCredentialsWithOptionsAsync(token, workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFunctionInstanceResponse
        /// </returns>
        public UpdateFunctionInstanceResponse UpdateFunctionInstanceWithOptions(string workspaceName, string functionName, string instanceName, UpdateFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParameters))
            {
                body["createParameters"] = request.CreateParameters;
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
                Action = "UpdateFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFunctionInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFunctionInstanceResponse
        /// </returns>
        public async Task<UpdateFunctionInstanceResponse> UpdateFunctionInstanceWithOptionsAsync(string workspaceName, string functionName, string instanceName, UpdateFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParameters))
            {
                body["createParameters"] = request.CreateParameters;
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
                Action = "UpdateFunctionInstance",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFunctionInstanceResponse
        /// </returns>
        public UpdateFunctionInstanceResponse UpdateFunctionInstance(string workspaceName, string functionName, string instanceName, UpdateFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFunctionInstanceWithOptions(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the service configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFunctionInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFunctionInstanceResponse
        /// </returns>
        public async Task<UpdateFunctionInstanceResponse> UpdateFunctionInstanceAsync(string workspaceName, string functionName, string instanceName, UpdateFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFunctionInstanceWithOptionsAsync(workspaceName, functionName, instanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public UpdateWorkspaceResponse UpdateWorkspaceWithOptions(string workspaceName, UpdateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspace",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceWithOptionsAsync(string workspaceName, UpdateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspace",
                Version = "2024-04-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/platform/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public UpdateWorkspaceResponse UpdateWorkspace(string workspaceName, UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWorkspaceWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(string workspaceName, UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWorkspaceWithOptionsAsync(workspaceName, request, headers, runtime);
        }

    }
}
