// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.SysOM20231230.Models;

namespace AlibabaCloud.SDK.SysOM20231230
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("sysom", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Authorizes SysOM to diagnose ECS instances under the current account. You must call this operation to authorize diagnostics on a specific ECS instance before you can call the InvokeDiagnosis operation to initiate diagnostics on it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: The diagnostics feature requires a service-linked role to be created under the Resource Access Management (RAM) user. Invoking this operation automatically checks whether the service-linked role exists and creates it if it does not. The RAM user that invokes this operation must have the ram:CreateServiceLinkedRole permission.</notice>
        /// Note the following when you invoke this operation to authorize SysOM to diagnose ECS instances:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Each authorization is valid for 7 days. After 7 days, the authorization expires and you must invoke this operation again to re-authorize.</description></item>
        /// <item><description>If the SysOM service-linked role (AliyunServiceRoleForSysom) does not exist when you invoke this operation, automatic creation is performed. The Resource Access Management (RAM) user that invokes this operation must have the <c>ram:CreateServiceLinkedRole</c> permission.</description></item>
        /// <item><description>When you invoke this operation to authorize diagnostics on a specific instance, the label <c>sysom:diagnosis</c> is automatically associated with the target ECS instance. SysOM only allows diagnostics on instances that have this label.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthDiagnosisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthDiagnosisResponse
        /// </returns>
        public AuthDiagnosisResponse AuthDiagnosisWithOptions(AuthDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateRole))
            {
                body["autoCreateRole"] = request.AutoCreateRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstallAgent))
            {
                body["autoInstallAgent"] = request.AutoInstallAgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthDiagnosis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/diagnosis/auth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorizes SysOM to diagnose ECS instances under the current account. You must call this operation to authorize diagnostics on a specific ECS instance before you can call the InvokeDiagnosis operation to initiate diagnostics on it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: The diagnostics feature requires a service-linked role to be created under the Resource Access Management (RAM) user. Invoking this operation automatically checks whether the service-linked role exists and creates it if it does not. The RAM user that invokes this operation must have the ram:CreateServiceLinkedRole permission.</notice>
        /// Note the following when you invoke this operation to authorize SysOM to diagnose ECS instances:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Each authorization is valid for 7 days. After 7 days, the authorization expires and you must invoke this operation again to re-authorize.</description></item>
        /// <item><description>If the SysOM service-linked role (AliyunServiceRoleForSysom) does not exist when you invoke this operation, automatic creation is performed. The Resource Access Management (RAM) user that invokes this operation must have the <c>ram:CreateServiceLinkedRole</c> permission.</description></item>
        /// <item><description>When you invoke this operation to authorize diagnostics on a specific instance, the label <c>sysom:diagnosis</c> is automatically associated with the target ECS instance. SysOM only allows diagnostics on instances that have this label.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthDiagnosisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthDiagnosisResponse
        /// </returns>
        public async Task<AuthDiagnosisResponse> AuthDiagnosisWithOptionsAsync(AuthDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateRole))
            {
                body["autoCreateRole"] = request.AutoCreateRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstallAgent))
            {
                body["autoInstallAgent"] = request.AutoInstallAgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthDiagnosis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/diagnosis/auth",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorizes SysOM to diagnose ECS instances under the current account. You must call this operation to authorize diagnostics on a specific ECS instance before you can call the InvokeDiagnosis operation to initiate diagnostics on it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: The diagnostics feature requires a service-linked role to be created under the Resource Access Management (RAM) user. Invoking this operation automatically checks whether the service-linked role exists and creates it if it does not. The RAM user that invokes this operation must have the ram:CreateServiceLinkedRole permission.</notice>
        /// Note the following when you invoke this operation to authorize SysOM to diagnose ECS instances:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Each authorization is valid for 7 days. After 7 days, the authorization expires and you must invoke this operation again to re-authorize.</description></item>
        /// <item><description>If the SysOM service-linked role (AliyunServiceRoleForSysom) does not exist when you invoke this operation, automatic creation is performed. The Resource Access Management (RAM) user that invokes this operation must have the <c>ram:CreateServiceLinkedRole</c> permission.</description></item>
        /// <item><description>When you invoke this operation to authorize diagnostics on a specific instance, the label <c>sysom:diagnosis</c> is automatically associated with the target ECS instance. SysOM only allows diagnostics on instances that have this label.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthDiagnosisResponse
        /// </returns>
        public AuthDiagnosisResponse AuthDiagnosis(AuthDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AuthDiagnosisWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorizes SysOM to diagnose ECS instances under the current account. You must call this operation to authorize diagnostics on a specific ECS instance before you can call the InvokeDiagnosis operation to initiate diagnostics on it.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: The diagnostics feature requires a service-linked role to be created under the Resource Access Management (RAM) user. Invoking this operation automatically checks whether the service-linked role exists and creates it if it does not. The RAM user that invokes this operation must have the ram:CreateServiceLinkedRole permission.</notice>
        /// Note the following when you invoke this operation to authorize SysOM to diagnose ECS instances:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Each authorization is valid for 7 days. After 7 days, the authorization expires and you must invoke this operation again to re-authorize.</description></item>
        /// <item><description>If the SysOM service-linked role (AliyunServiceRoleForSysom) does not exist when you invoke this operation, automatic creation is performed. The Resource Access Management (RAM) user that invokes this operation must have the <c>ram:CreateServiceLinkedRole</c> permission.</description></item>
        /// <item><description>When you invoke this operation to authorize diagnostics on a specific instance, the label <c>sysom:diagnosis</c> is automatically associated with the target ECS instance. SysOM only allows diagnostics on instances that have this label.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AuthDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthDiagnosisResponse
        /// </returns>
        public async Task<AuthDiagnosisResponse> AuthDiagnosisAsync(AuthDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AuthDiagnosisWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether resources such as clusters and nodes support the current configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckAgentConfigSupportedRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckAgentConfigSupportedResponse
        /// </returns>
        public CheckAgentConfigSupportedResponse CheckAgentConfigSupportedWithOptions(CheckAgentConfigSupportedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clusters))
            {
                query["clusters"] = request.Clusters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["configId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckAgentConfigSupported",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/checkAgentConfigSupported",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAgentConfigSupportedResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether resources such as clusters and nodes support the current configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckAgentConfigSupportedRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckAgentConfigSupportedResponse
        /// </returns>
        public async Task<CheckAgentConfigSupportedResponse> CheckAgentConfigSupportedWithOptionsAsync(CheckAgentConfigSupportedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckType))
            {
                query["checkType"] = request.CheckType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clusters))
            {
                query["clusters"] = request.Clusters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["configId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckAgentConfigSupported",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/checkAgentConfigSupported",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAgentConfigSupportedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether resources such as clusters and nodes support the current configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckAgentConfigSupportedRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckAgentConfigSupportedResponse
        /// </returns>
        public CheckAgentConfigSupportedResponse CheckAgentConfigSupported(CheckAgentConfigSupportedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckAgentConfigSupportedWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether resources such as clusters and nodes support the current configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckAgentConfigSupportedRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckAgentConfigSupportedResponse
        /// </returns>
        public async Task<CheckAgentConfigSupportedResponse> CheckAgentConfigSupportedAsync(CheckAgentConfigSupportedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckAgentConfigSupportedWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether target instances are supported by SysOM.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only instances that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckInstanceSupportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckInstanceSupportResponse
        /// </returns>
        public CheckInstanceSupportResponse CheckInstanceSupportWithOptions(CheckInstanceSupportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInstanceSupport",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/supportInstanceList/checkInstanceSupport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInstanceSupportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether target instances are supported by SysOM.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only instances that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckInstanceSupportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckInstanceSupportResponse
        /// </returns>
        public async Task<CheckInstanceSupportResponse> CheckInstanceSupportWithOptionsAsync(CheckInstanceSupportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInstanceSupport",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/supportInstanceList/checkInstanceSupport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInstanceSupportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether target instances are supported by SysOM.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only instances that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckInstanceSupportRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckInstanceSupportResponse
        /// </returns>
        public CheckInstanceSupportResponse CheckInstanceSupport(CheckInstanceSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckInstanceSupportWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether target instances are supported by SysOM.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only instances that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckInstanceSupportRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckInstanceSupportResponse
        /// </returns>
        public async Task<CheckInstanceSupportResponse> CheckInstanceSupportAsync(CheckInstanceSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckInstanceSupportWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes the CPU high agent streaming SSE interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CpuHighAgentStreamResponseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CpuHighAgentStreamResponseResponse
        /// </returns>
        public CpuHighAgentStreamResponseResponse CpuHighAgentStreamResponseWithOptions(CpuHighAgentStreamResponseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmParamString))
            {
                body["llmParamString"] = request.LlmParamString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CpuHighAgentStreamResponse",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/highCpuAgent/streamResponse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CpuHighAgentStreamResponseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes the CPU high agent streaming SSE interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CpuHighAgentStreamResponseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CpuHighAgentStreamResponseResponse
        /// </returns>
        public async Task<CpuHighAgentStreamResponseResponse> CpuHighAgentStreamResponseWithOptionsAsync(CpuHighAgentStreamResponseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmParamString))
            {
                body["llmParamString"] = request.LlmParamString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CpuHighAgentStreamResponse",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/highCpuAgent/streamResponse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CpuHighAgentStreamResponseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes the CPU high agent streaming SSE interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CpuHighAgentStreamResponseRequest
        /// </param>
        /// 
        /// <returns>
        /// CpuHighAgentStreamResponseResponse
        /// </returns>
        public CpuHighAgentStreamResponseResponse CpuHighAgentStreamResponse(CpuHighAgentStreamResponseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CpuHighAgentStreamResponseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes the CPU high agent streaming SSE interface.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CpuHighAgentStreamResponseRequest
        /// </param>
        /// 
        /// <returns>
        /// CpuHighAgentStreamResponseResponse
        /// </returns>
        public async Task<CpuHighAgentStreamResponseResponse> CpuHighAgentStreamResponseAsync(CpuHighAgentStreamResponseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CpuHighAgentStreamResponseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a component configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentConfigResponse
        /// </returns>
        public CreateAgentConfigResponse CreateAgentConfigWithOptions(CreateAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                body["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/createAgentConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a component configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentConfigResponse
        /// </returns>
        public async Task<CreateAgentConfigResponse> CreateAgentConfigWithOptionsAsync(CreateAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                body["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/createAgentConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a component configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentConfigResponse
        /// </returns>
        public CreateAgentConfigResponse CreateAgentConfig(CreateAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAgentConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a component configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentConfigResponse
        /// </returns>
        public async Task<CreateAgentConfigResponse> CreateAgentConfigAsync(CreateAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAgentConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a contact for alert notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertDestinationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertDestinationResponse
        /// </returns>
        public CreateAlertDestinationResponse CreateAlertDestinationWithOptions(CreateAlertDestinationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["app_id"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                body["app_secret"] = request.AppSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imbot))
            {
                body["imbot"] = request.Imbot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlertDestination",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/createDestination",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlertDestinationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a contact for alert notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertDestinationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertDestinationResponse
        /// </returns>
        public async Task<CreateAlertDestinationResponse> CreateAlertDestinationWithOptionsAsync(CreateAlertDestinationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["app_id"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                body["app_secret"] = request.AppSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imbot))
            {
                body["imbot"] = request.Imbot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlertDestination",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/createDestination",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlertDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a contact for alert notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertDestinationResponse
        /// </returns>
        public CreateAlertDestinationResponse CreateAlertDestination(CreateAlertDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAlertDestinationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a contact for alert notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertDestinationResponse
        /// </returns>
        public async Task<CreateAlertDestinationResponse> CreateAlertDestinationAsync(CreateAlertDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAlertDestinationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alert policy for push notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertStrategyResponse
        /// </returns>
        public CreateAlertStrategyResponse CreateAlertStrategyWithOptions(CreateAlertStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sLabel))
            {
                body["k8sLabel"] = request.K8sLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                body["strategy"] = request.Strategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlertStrategy",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/createStrategy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlertStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alert policy for push notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertStrategyResponse
        /// </returns>
        public async Task<CreateAlertStrategyResponse> CreateAlertStrategyWithOptionsAsync(CreateAlertStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sLabel))
            {
                body["k8sLabel"] = request.K8sLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                body["strategy"] = request.Strategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlertStrategy",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/createStrategy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAlertStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alert policy for push notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertStrategyResponse
        /// </returns>
        public CreateAlertStrategyResponse CreateAlertStrategy(CreateAlertStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAlertStrategyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alert policy for push notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAlertStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAlertStrategyResponse
        /// </returns>
        public async Task<CreateAlertStrategyResponse> CreateAlertStrategyAsync(CreateAlertStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAlertStrategyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC endpoint connection for a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use this operation together with the call_sseapi operation in the aliyun-tea-openapi-inner package.</description></item>
        /// <item><description>Populate the parameters based on the input parameters of the general LLM service, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned string to a dictionary before use. Refer to the response format of the general LLM service.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClusterVpcEndpointConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterVpcEndpointConnectionResponse
        /// </returns>
        public CreateClusterVpcEndpointConnectionResponse CreateClusterVpcEndpointConnectionWithOptions(CreateClusterVpcEndpointConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["clusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterVpcEndpointConnection",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/k8sProxy/access/createClusterVpcEndpointConnection",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterVpcEndpointConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC endpoint connection for a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use this operation together with the call_sseapi operation in the aliyun-tea-openapi-inner package.</description></item>
        /// <item><description>Populate the parameters based on the input parameters of the general LLM service, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned string to a dictionary before use. Refer to the response format of the general LLM service.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClusterVpcEndpointConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterVpcEndpointConnectionResponse
        /// </returns>
        public async Task<CreateClusterVpcEndpointConnectionResponse> CreateClusterVpcEndpointConnectionWithOptionsAsync(CreateClusterVpcEndpointConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["clusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterVpcEndpointConnection",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/k8sProxy/access/createClusterVpcEndpointConnection",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterVpcEndpointConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC endpoint connection for a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use this operation together with the call_sseapi operation in the aliyun-tea-openapi-inner package.</description></item>
        /// <item><description>Populate the parameters based on the input parameters of the general LLM service, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned string to a dictionary before use. Refer to the response format of the general LLM service.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClusterVpcEndpointConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterVpcEndpointConnectionResponse
        /// </returns>
        public CreateClusterVpcEndpointConnectionResponse CreateClusterVpcEndpointConnection(CreateClusterVpcEndpointConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateClusterVpcEndpointConnectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC endpoint connection for a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use this operation together with the call_sseapi operation in the aliyun-tea-openapi-inner package.</description></item>
        /// <item><description>Populate the parameters based on the input parameters of the general LLM service, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned string to a dictionary before use. Refer to the response format of the general LLM service.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClusterVpcEndpointConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterVpcEndpointConnectionResponse
        /// </returns>
        public async Task<CreateClusterVpcEndpointConnectionResponse> CreateClusterVpcEndpointConnectionAsync(CreateClusterVpcEndpointConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateClusterVpcEndpointConnectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a SysOM instance inspection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceInspectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceInspectionResponse
        /// </returns>
        public CreateInstanceInspectionResponse CreateInstanceInspectionWithOptions(CreateInstanceInspectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                body["items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricSource))
            {
                body["metricSource"] = request.MetricSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceInspection",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/inspection/createInstanceInspection",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceInspectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a SysOM instance inspection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceInspectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceInspectionResponse
        /// </returns>
        public async Task<CreateInstanceInspectionResponse> CreateInstanceInspectionWithOptionsAsync(CreateInstanceInspectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                body["items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricSource))
            {
                body["metricSource"] = request.MetricSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceInspection",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/inspection/createInstanceInspection",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceInspectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a SysOM instance inspection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceInspectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceInspectionResponse
        /// </returns>
        public CreateInstanceInspectionResponse CreateInstanceInspection(CreateInstanceInspectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceInspectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a SysOM instance inspection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceInspectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceInspectionResponse
        /// </returns>
        public async Task<CreateInstanceInspectionResponse> CreateInstanceInspectionAsync(CreateInstanceInspectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceInspectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an intelligent breakdown diagnostic node to diagnose the vmcore or dmesg log file specified in the input parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVmcoreDiagnosisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVmcoreDiagnosisTaskResponse
        /// </returns>
        public CreateVmcoreDiagnosisTaskResponse CreateVmcoreDiagnosisTaskWithOptions(CreateVmcoreDiagnosisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebuginfoCommonUrl))
            {
                body["debuginfoCommonUrl"] = request.DebuginfoCommonUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebuginfoUrl))
            {
                body["debuginfoUrl"] = request.DebuginfoUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmesgUrl))
            {
                body["dmesgUrl"] = request.DmesgUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VmcoreUrl))
            {
                body["vmcoreUrl"] = request.VmcoreUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVmcoreDiagnosisTask",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crashAgent/diagnosis/createDiagnosisTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVmcoreDiagnosisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an intelligent breakdown diagnostic node to diagnose the vmcore or dmesg log file specified in the input parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVmcoreDiagnosisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVmcoreDiagnosisTaskResponse
        /// </returns>
        public async Task<CreateVmcoreDiagnosisTaskResponse> CreateVmcoreDiagnosisTaskWithOptionsAsync(CreateVmcoreDiagnosisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebuginfoCommonUrl))
            {
                body["debuginfoCommonUrl"] = request.DebuginfoCommonUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebuginfoUrl))
            {
                body["debuginfoUrl"] = request.DebuginfoUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmesgUrl))
            {
                body["dmesgUrl"] = request.DmesgUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VmcoreUrl))
            {
                body["vmcoreUrl"] = request.VmcoreUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVmcoreDiagnosisTask",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crashAgent/diagnosis/createDiagnosisTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVmcoreDiagnosisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an intelligent breakdown diagnostic node to diagnose the vmcore or dmesg log file specified in the input parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVmcoreDiagnosisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVmcoreDiagnosisTaskResponse
        /// </returns>
        public CreateVmcoreDiagnosisTaskResponse CreateVmcoreDiagnosisTask(CreateVmcoreDiagnosisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVmcoreDiagnosisTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an intelligent breakdown diagnostic node to diagnose the vmcore or dmesg log file specified in the input parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVmcoreDiagnosisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVmcoreDiagnosisTaskResponse
        /// </returns>
        public async Task<CreateVmcoreDiagnosisTaskResponse> CreateVmcoreDiagnosisTaskAsync(CreateVmcoreDiagnosisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVmcoreDiagnosisTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a component configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentConfigResponse
        /// </returns>
        public DeleteAgentConfigResponse DeleteAgentConfigWithOptions(DeleteAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["configId"] = request.ConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/deleteAgentConfig",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a component configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentConfigResponse
        /// </returns>
        public async Task<DeleteAgentConfigResponse> DeleteAgentConfigWithOptionsAsync(DeleteAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["configId"] = request.ConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/deleteAgentConfig",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a component configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentConfigResponse
        /// </returns>
        public DeleteAgentConfigResponse DeleteAgentConfig(DeleteAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAgentConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a component configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentConfigResponse
        /// </returns>
        public async Task<DeleteAgentConfigResponse> DeleteAgentConfigAsync(DeleteAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAgentConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlertDestinationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertDestinationResponse
        /// </returns>
        public DeleteAlertDestinationResponse DeleteAlertDestinationWithOptions(DeleteAlertDestinationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlertDestination",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/deleteDestination",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlertDestinationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlertDestinationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertDestinationResponse
        /// </returns>
        public async Task<DeleteAlertDestinationResponse> DeleteAlertDestinationWithOptionsAsync(DeleteAlertDestinationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlertDestination",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/deleteDestination",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlertDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlertDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertDestinationResponse
        /// </returns>
        public DeleteAlertDestinationResponse DeleteAlertDestination(DeleteAlertDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAlertDestinationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlertDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertDestinationResponse
        /// </returns>
        public async Task<DeleteAlertDestinationResponse> DeleteAlertDestinationAsync(DeleteAlertDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAlertDestinationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert policy for push alerting.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlertStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertStrategyResponse
        /// </returns>
        public DeleteAlertStrategyResponse DeleteAlertStrategyWithOptions(DeleteAlertStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlertStrategy",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/deleteStrategy",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlertStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert policy for push alerting.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlertStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertStrategyResponse
        /// </returns>
        public async Task<DeleteAlertStrategyResponse> DeleteAlertStrategyWithOptionsAsync(DeleteAlertStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlertStrategy",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/deleteStrategy",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAlertStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert policy for push alerting.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlertStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertStrategyResponse
        /// </returns>
        public DeleteAlertStrategyResponse DeleteAlertStrategy(DeleteAlertStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAlertStrategyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert policy for push alerting.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAlertStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAlertStrategyResponse
        /// </returns>
        public async Task<DeleteAlertStrategyResponse> DeleteAlertStrategyAsync(DeleteAlertStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAlertStrategyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries metric data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMetricListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricListResponse
        /// </returns>
        public DescribeMetricListResponse DescribeMetricListWithOptions(DescribeMetricListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["metricName"] = request.MetricName;
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
                Action = "DescribeMetricList",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/get/describeMetricList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries metric data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMetricListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricListResponse
        /// </returns>
        public async Task<DescribeMetricListResponse> DescribeMetricListWithOptionsAsync(DescribeMetricListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["metricName"] = request.MetricName;
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
                Action = "DescribeMetricList",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/get/describeMetricList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries metric data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMetricListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricListResponse
        /// </returns>
        public DescribeMetricListResponse DescribeMetricList(DescribeMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeMetricListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries metric data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMetricListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMetricListResponse
        /// </returns>
        public async Task<DescribeMetricListResponse> DescribeMetricListAsync(DescribeMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeMetricListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the response result from the Copilot service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Populate parameters according to the standard LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned data from a string to a dict before use. Refer to the standard LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCopilotResponseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCopilotResponseResponse
        /// </returns>
        public GenerateCopilotResponseResponse GenerateCopilotResponseWithOptions(GenerateCopilotResponseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmParamString))
            {
                body["llmParamString"] = request.LlmParamString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCopilotResponse",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/copilot/generate_copilot_response",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCopilotResponseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the response result from the Copilot service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Populate parameters according to the standard LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned data from a string to a dict before use. Refer to the standard LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCopilotResponseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCopilotResponseResponse
        /// </returns>
        public async Task<GenerateCopilotResponseResponse> GenerateCopilotResponseWithOptionsAsync(GenerateCopilotResponseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmParamString))
            {
                body["llmParamString"] = request.LlmParamString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCopilotResponse",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/copilot/generate_copilot_response",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCopilotResponseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the response result from the Copilot service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Populate parameters according to the standard LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned data from a string to a dict before use. Refer to the standard LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCopilotResponseRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCopilotResponseResponse
        /// </returns>
        public GenerateCopilotResponseResponse GenerateCopilotResponse(GenerateCopilotResponseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateCopilotResponseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the response result from the Copilot service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Populate parameters according to the standard LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned data from a string to a dict before use. Refer to the standard LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCopilotResponseRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCopilotResponseResponse
        /// </returns>
        public async Task<GenerateCopilotResponseResponse> GenerateCopilotResponseAsync(GenerateCopilotResponseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateCopilotResponseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a streaming SSE interface for the OS Copilot service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use this operation together with the call_sseapi interface in the aliyun-tea-openapi-inner package.</description></item>
        /// <item><description>Populate the parameters based on the standard LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned string data to a dict before use. Refer to the standard LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCopilotStreamResponseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCopilotStreamResponseResponse
        /// </returns>
        public GenerateCopilotStreamResponseResponse GenerateCopilotStreamResponseWithOptions(GenerateCopilotStreamResponseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmParamString))
            {
                body["llmParamString"] = request.LlmParamString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCopilotStreamResponse",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/copilot/generate_copilot_stream_response",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCopilotStreamResponseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a streaming SSE interface for the OS Copilot service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use this operation together with the call_sseapi interface in the aliyun-tea-openapi-inner package.</description></item>
        /// <item><description>Populate the parameters based on the standard LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned string data to a dict before use. Refer to the standard LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCopilotStreamResponseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCopilotStreamResponseResponse
        /// </returns>
        public async Task<GenerateCopilotStreamResponseResponse> GenerateCopilotStreamResponseWithOptionsAsync(GenerateCopilotStreamResponseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmParamString))
            {
                body["llmParamString"] = request.LlmParamString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCopilotStreamResponse",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/copilot/generate_copilot_stream_response",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCopilotStreamResponseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a streaming SSE interface for the OS Copilot service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use this operation together with the call_sseapi interface in the aliyun-tea-openapi-inner package.</description></item>
        /// <item><description>Populate the parameters based on the standard LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned string data to a dict before use. Refer to the standard LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCopilotStreamResponseRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCopilotStreamResponseResponse
        /// </returns>
        public GenerateCopilotStreamResponseResponse GenerateCopilotStreamResponse(GenerateCopilotStreamResponseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateCopilotStreamResponseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a streaming SSE interface for the OS Copilot service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use this operation together with the call_sseapi interface in the aliyun-tea-openapi-inner package.</description></item>
        /// <item><description>Populate the parameters based on the standard LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned string data to a dict before use. Refer to the standard LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateCopilotStreamResponseRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCopilotStreamResponseResponse
        /// </returns>
        public async Task<GenerateCopilotStreamResponseResponse> GenerateCopilotStreamResponseAsync(GenerateCopilotStreamResponseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateCopilotStreamResponseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AI Infra analysis results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAIQueryResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAIQueryResultResponse
        /// </returns>
        public GetAIQueryResultResponse GetAIQueryResultWithOptions(GetAIQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisId))
            {
                body["analysisId"] = request.AnalysisId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAIQueryResult",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/app_observ/aiAnalysis/query_result",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAIQueryResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AI Infra analysis results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAIQueryResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAIQueryResultResponse
        /// </returns>
        public async Task<GetAIQueryResultResponse> GetAIQueryResultWithOptionsAsync(GetAIQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisId))
            {
                body["analysisId"] = request.AnalysisId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAIQueryResult",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/app_observ/aiAnalysis/query_result",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAIQueryResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AI Infra analysis results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAIQueryResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAIQueryResultResponse
        /// </returns>
        public GetAIQueryResultResponse GetAIQueryResult(GetAIQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAIQueryResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AI Infra analysis results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAIQueryResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAIQueryResultResponse
        /// </returns>
        public async Task<GetAIQueryResultResponse> GetAIQueryResultAsync(GetAIQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAIQueryResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of unprocessed (undiagnosed) abnormal events at different severity levels for a node or pod.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAbnormalEventsCountRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAbnormalEventsCountResponse
        /// </returns>
        public GetAbnormalEventsCountResponse GetAbnormalEventsCountWithOptions(GetAbnormalEventsCountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pod))
            {
                query["pod"] = request.Pod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowPod))
            {
                query["showPod"] = request.ShowPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAbnormalEventsCount",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/abnormaly_events_count",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAbnormalEventsCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of unprocessed (undiagnosed) abnormal events at different severity levels for a node or pod.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAbnormalEventsCountRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAbnormalEventsCountResponse
        /// </returns>
        public async Task<GetAbnormalEventsCountResponse> GetAbnormalEventsCountWithOptionsAsync(GetAbnormalEventsCountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pod))
            {
                query["pod"] = request.Pod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowPod))
            {
                query["showPod"] = request.ShowPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAbnormalEventsCount",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/abnormaly_events_count",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAbnormalEventsCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of unprocessed (undiagnosed) abnormal events at different severity levels for a node or pod.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAbnormalEventsCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAbnormalEventsCountResponse
        /// </returns>
        public GetAbnormalEventsCountResponse GetAbnormalEventsCount(GetAbnormalEventsCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAbnormalEventsCountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of unprocessed (undiagnosed) abnormal events at different severity levels for a node or pod.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAbnormalEventsCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAbnormalEventsCountResponse
        /// </returns>
        public async Task<GetAbnormalEventsCountResponse> GetAbnormalEventsCountAsync(GetAbnormalEventsCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAbnormalEventsCountWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public GetAgentResponse GetAgentWithOptions(GetAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agent_id"] = request.AgentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgent",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/get_agent",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public async Task<GetAgentResponse> GetAgentWithOptionsAsync(GetAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agent_id"] = request.AgentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgent",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/get_agent",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public GetAgentResponse GetAgent(GetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public async Task<GetAgentResponse> GetAgentAsync(GetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves component configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentConfigResponse
        /// </returns>
        public GetAgentConfigResponse GetAgentConfigWithOptions(GetAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["configId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/getAgentConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves component configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentConfigResponse
        /// </returns>
        public async Task<GetAgentConfigResponse> GetAgentConfigWithOptionsAsync(GetAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["configId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/getAgentConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves component configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentConfigResponse
        /// </returns>
        public GetAgentConfigResponse GetAgentConfig(GetAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves component configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentConfigResponse
        /// </returns>
        public async Task<GetAgentConfigResponse> GetAgentConfigAsync(GetAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the execution status of an Agent installation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentTaskResponse
        /// </returns>
        public GetAgentTaskResponse GetAgentTaskWithOptions(GetAgentTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentTask",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/get_agent_task",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the execution status of an Agent installation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentTaskResponse
        /// </returns>
        public async Task<GetAgentTaskResponse> GetAgentTaskWithOptionsAsync(GetAgentTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentTask",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/get_agent_task",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the execution status of an Agent installation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentTaskResponse
        /// </returns>
        public GetAgentTaskResponse GetAgentTask(GetAgentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the execution status of an Agent installation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentTaskResponse
        /// </returns>
        public async Task<GetAgentTaskResponse> GetAgentTaskAsync(GetAgentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves diagnostic results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be in progress. Check the <c>data.status</c> field in the response to determine the current state. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic results from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAifgResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAifgResultResponse
        /// </returns>
        public GetAifgResultResponse GetAifgResultWithOptions(GetAifgResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAifgResult",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aifg/getAifgResult",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAifgResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves diagnostic results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be in progress. Check the <c>data.status</c> field in the response to determine the current state. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic results from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAifgResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAifgResultResponse
        /// </returns>
        public async Task<GetAifgResultResponse> GetAifgResultWithOptionsAsync(GetAifgResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAifgResult",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aifg/getAifgResult",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAifgResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves diagnostic results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be in progress. Check the <c>data.status</c> field in the response to determine the current state. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic results from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAifgResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAifgResultResponse
        /// </returns>
        public GetAifgResultResponse GetAifgResult(GetAifgResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAifgResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves diagnostic results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be in progress. Check the <c>data.status</c> field in the response to determine the current state. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic results from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAifgResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAifgResultResponse
        /// </returns>
        public async Task<GetAifgResultResponse> GetAifgResultAsync(GetAifgResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAifgResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the URL link of a diagnostic result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be in progress. You can check the <c>data.status</c> field in the response data to determine the current state. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic result from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAifgUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAifgUrlResponse
        /// </returns>
        public GetAifgUrlResponse GetAifgUrlWithOptions(GetAifgUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAifgUrl",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aifg/getAifgUrl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAifgUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the URL link of a diagnostic result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be in progress. You can check the <c>data.status</c> field in the response data to determine the current state. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic result from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAifgUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAifgUrlResponse
        /// </returns>
        public async Task<GetAifgUrlResponse> GetAifgUrlWithOptionsAsync(GetAifgUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAifgUrl",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aifg/getAifgUrl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAifgUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the URL link of a diagnostic result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be in progress. You can check the <c>data.status</c> field in the response data to determine the current state. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic result from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAifgUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAifgUrlResponse
        /// </returns>
        public GetAifgUrlResponse GetAifgUrl(GetAifgUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAifgUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the URL link of a diagnostic result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be in progress. You can check the <c>data.status</c> field in the response data to determine the current state. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic result from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAifgUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAifgUrlResponse
        /// </returns>
        public async Task<GetAifgUrlResponse> GetAifgUrlAsync(GetAifgUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAifgUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of a specified alert contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertDestinationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlertDestinationResponse
        /// </returns>
        public GetAlertDestinationResponse GetAlertDestinationWithOptions(GetAlertDestinationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlertDestination",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/getDestination",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlertDestinationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of a specified alert contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertDestinationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlertDestinationResponse
        /// </returns>
        public async Task<GetAlertDestinationResponse> GetAlertDestinationWithOptionsAsync(GetAlertDestinationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlertDestination",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/getDestination",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlertDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of a specified alert contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlertDestinationResponse
        /// </returns>
        public GetAlertDestinationResponse GetAlertDestination(GetAlertDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlertDestinationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of a specified alert contact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlertDestinationResponse
        /// </returns>
        public async Task<GetAlertDestinationResponse> GetAlertDestinationAsync(GetAlertDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlertDestinationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an alert rule of a user by policy ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlertStrategyResponse
        /// </returns>
        public GetAlertStrategyResponse GetAlertStrategyWithOptions(GetAlertStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlertStrategy",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/getStrategy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlertStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an alert rule of a user by policy ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlertStrategyResponse
        /// </returns>
        public async Task<GetAlertStrategyResponse> GetAlertStrategyWithOptionsAsync(GetAlertStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlertStrategy",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/getStrategy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlertStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an alert rule of a user by policy ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlertStrategyResponse
        /// </returns>
        public GetAlertStrategyResponse GetAlertStrategy(GetAlertStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlertStrategyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an alert rule of a user by policy ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlertStrategyResponse
        /// </returns>
        public async Task<GetAlertStrategyResponse> GetAlertStrategyAsync(GetAlertStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlertStrategyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves configuration information by configuration name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigByNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfigByNameResponse
        /// </returns>
        public GetConfigByNameResponse GetConfigByNameWithOptions(GetConfigByNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["configType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["entityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseGlobalUid))
            {
                query["useGlobalUid"] = request.UseGlobalUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigByName",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/configManage/config/getConfigByName",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigByNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves configuration information by configuration name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigByNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfigByNameResponse
        /// </returns>
        public async Task<GetConfigByNameResponse> GetConfigByNameWithOptionsAsync(GetConfigByNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["configType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["entityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseGlobalUid))
            {
                query["useGlobalUid"] = request.UseGlobalUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigByName",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/configManage/config/getConfigByName",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigByNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves configuration information by configuration name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigByNameRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfigByNameResponse
        /// </returns>
        public GetConfigByNameResponse GetConfigByName(GetConfigByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConfigByNameWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves configuration information by configuration name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigByNameRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfigByNameResponse
        /// </returns>
        public async Task<GetConfigByNameResponse> GetConfigByNameAsync(GetConfigByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConfigByNameWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the historical chat records of Copilot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCopilotHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCopilotHistoryResponse
        /// </returns>
        public GetCopilotHistoryResponse GetCopilotHistoryWithOptions(GetCopilotHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCopilotHistory",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/copilot/get_copilot_history",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCopilotHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the historical chat records of Copilot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCopilotHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCopilotHistoryResponse
        /// </returns>
        public async Task<GetCopilotHistoryResponse> GetCopilotHistoryWithOptionsAsync(GetCopilotHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCopilotHistory",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/copilot/get_copilot_history",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCopilotHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the historical chat records of Copilot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCopilotHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCopilotHistoryResponse
        /// </returns>
        public GetCopilotHistoryResponse GetCopilotHistory(GetCopilotHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCopilotHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the historical chat records of Copilot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCopilotHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCopilotHistoryResponse
        /// </returns>
        public async Task<GetCopilotHistoryResponse> GetCopilotHistoryAsync(GetCopilotHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCopilotHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hotfixes and compatible packages for a CVE.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries published hotfixes in batches by CVE ID. You can filter the results by full kernel version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCveHotfixRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCveHotfixResponse
        /// </returns>
        public GetCveHotfixResponse GetCveHotfixWithOptions(GetCveHotfixRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CveIds))
            {
                body["cveIds"] = request.CveIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KernelVersions))
            {
                body["kernelVersions"] = request.KernelVersions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCveHotfix",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/hotfixManager/hotfixes/cve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCveHotfixResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hotfixes and compatible packages for a CVE.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries published hotfixes in batches by CVE ID. You can filter the results by full kernel version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCveHotfixRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCveHotfixResponse
        /// </returns>
        public async Task<GetCveHotfixResponse> GetCveHotfixWithOptionsAsync(GetCveHotfixRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CveIds))
            {
                body["cveIds"] = request.CveIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KernelVersions))
            {
                body["kernelVersions"] = request.KernelVersions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCveHotfix",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/hotfixManager/hotfixes/cve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCveHotfixResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hotfixes and compatible packages for a CVE.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries published hotfixes in batches by CVE ID. You can filter the results by full kernel version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCveHotfixRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCveHotfixResponse
        /// </returns>
        public GetCveHotfixResponse GetCveHotfix(GetCveHotfixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCveHotfixWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hotfixes and compatible packages for a CVE.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries published hotfixes in batches by CVE ID. You can filter the results by full kernel version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCveHotfixRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCveHotfixResponse
        /// </returns>
        public async Task<GetCveHotfixResponse> GetCveHotfixAsync(GetCveHotfixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCveHotfixWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves diagnostic results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be running. You can check the <c>data.status</c> field in the response to determine the status. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic results from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDiagnosisResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDiagnosisResultResponse
        /// </returns>
        public GetDiagnosisResultResponse GetDiagnosisResultWithOptions(GetDiagnosisResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnosisResult",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/diagnosis/get_diagnosis_results",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiagnosisResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves diagnostic results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be running. You can check the <c>data.status</c> field in the response to determine the status. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic results from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDiagnosisResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDiagnosisResultResponse
        /// </returns>
        public async Task<GetDiagnosisResultResponse> GetDiagnosisResultWithOptionsAsync(GetDiagnosisResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnosisResult",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/diagnosis/get_diagnosis_results",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiagnosisResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves diagnostic results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be running. You can check the <c>data.status</c> field in the response to determine the status. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic results from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDiagnosisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDiagnosisResultResponse
        /// </returns>
        public GetDiagnosisResultResponse GetDiagnosisResult(GetDiagnosisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDiagnosisResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves diagnostic results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnostic process is asynchronous. When you call this operation, the diagnosis may still be running. You can check the <c>data.status</c> field in the response to determine the status. When <c>data.status == Success</c>, the diagnosis is complete and you can read the diagnostic results from <c>data.result</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDiagnosisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDiagnosisResultResponse
        /// </returns>
        public async Task<GetDiagnosisResultResponse> GetDiagnosisResultAsync(GetDiagnosisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDiagnosisResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the GPU cluster parameter list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component for the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterArgsOptionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterArgsOptionsResponse
        /// </returns>
        public GetGpuClusterArgsOptionsResponse GetGpuClusterArgsOptionsWithOptions(GetGpuClusterArgsOptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterType))
            {
                query["filterType"] = request.FilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValues))
            {
                query["filterValues"] = request.FilterValues;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGpuClusterArgsOptions",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiTopology/topology/listClusterTopologyOptions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGpuClusterArgsOptionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the GPU cluster parameter list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component for the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterArgsOptionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterArgsOptionsResponse
        /// </returns>
        public async Task<GetGpuClusterArgsOptionsResponse> GetGpuClusterArgsOptionsWithOptionsAsync(GetGpuClusterArgsOptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterType))
            {
                query["filterType"] = request.FilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValues))
            {
                query["filterValues"] = request.FilterValues;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGpuClusterArgsOptions",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiTopology/topology/listClusterTopologyOptions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGpuClusterArgsOptionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the GPU cluster parameter list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component for the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterArgsOptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterArgsOptionsResponse
        /// </returns>
        public GetGpuClusterArgsOptionsResponse GetGpuClusterArgsOptions(GetGpuClusterArgsOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGpuClusterArgsOptionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the GPU cluster parameter list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component for the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterArgsOptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterArgsOptionsResponse
        /// </returns>
        public async Task<GetGpuClusterArgsOptionsResponse> GetGpuClusterArgsOptionsAsync(GetGpuClusterArgsOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGpuClusterArgsOptionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of GPU cluster alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>When a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only the first 50 nodes are processed in the first batch.</description></item>
        /// <item><description>The operating system console periodically checks the scaling status of managed clusters. When a new ECS instance is added to a cluster, the console automatically installs the component on it without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterListAlarmRecordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterListAlarmRecordResponse
        /// </returns>
        public GetGpuClusterListAlarmRecordResponse GetGpuClusterListAlarmRecordWithOptions(GetGpuClusterListAlarmRecordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmCluster))
            {
                query["alarmCluster"] = request.AlarmCluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmExtInfo))
            {
                query["alarmExtInfo"] = request.AlarmExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTask))
            {
                query["alarmTask"] = request.AlarmTask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTime))
            {
                query["alarmTime"] = request.AlarmTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmType))
            {
                query["alarmType"] = request.AlarmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGpuClusterListAlarmRecord",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiTopology/topology/listAlarmRecord",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGpuClusterListAlarmRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of GPU cluster alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>When a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only the first 50 nodes are processed in the first batch.</description></item>
        /// <item><description>The operating system console periodically checks the scaling status of managed clusters. When a new ECS instance is added to a cluster, the console automatically installs the component on it without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterListAlarmRecordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterListAlarmRecordResponse
        /// </returns>
        public async Task<GetGpuClusterListAlarmRecordResponse> GetGpuClusterListAlarmRecordWithOptionsAsync(GetGpuClusterListAlarmRecordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmCluster))
            {
                query["alarmCluster"] = request.AlarmCluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmExtInfo))
            {
                query["alarmExtInfo"] = request.AlarmExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTask))
            {
                query["alarmTask"] = request.AlarmTask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmTime))
            {
                query["alarmTime"] = request.AlarmTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmType))
            {
                query["alarmType"] = request.AlarmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGpuClusterListAlarmRecord",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiTopology/topology/listAlarmRecord",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGpuClusterListAlarmRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of GPU cluster alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>When a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only the first 50 nodes are processed in the first batch.</description></item>
        /// <item><description>The operating system console periodically checks the scaling status of managed clusters. When a new ECS instance is added to a cluster, the console automatically installs the component on it without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterListAlarmRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterListAlarmRecordResponse
        /// </returns>
        public GetGpuClusterListAlarmRecordResponse GetGpuClusterListAlarmRecord(GetGpuClusterListAlarmRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGpuClusterListAlarmRecordWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of GPU cluster alerts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>When a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only the first 50 nodes are processed in the first batch.</description></item>
        /// <item><description>The operating system console periodically checks the scaling status of managed clusters. When a new ECS instance is added to a cluster, the console automatically installs the component on it without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterListAlarmRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterListAlarmRecordResponse
        /// </returns>
        public async Task<GetGpuClusterListAlarmRecordResponse> GetGpuClusterListAlarmRecordAsync(GetGpuClusterListAlarmRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGpuClusterListAlarmRecordWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the GPU cluster topology.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install the component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>When a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only the first 50 nodes are processed in the first batch.</description></item>
        /// <item><description>The operating system console periodically checks the scaling status of managed clusters. When a new ECS instance is added to a cluster, the console automatically installs the component on it without requiring manual intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterTopologyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterTopologyResponse
        /// </returns>
        public GetGpuClusterTopologyResponse GetGpuClusterTopologyWithOptions(GetGpuClusterTopologyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["channelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["clusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunicationId))
            {
                query["communicationId"] = request.CommunicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["instanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodList))
            {
                query["podList"] = request.PodList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdList))
            {
                query["taskIdList"] = request.TaskIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopoType))
            {
                query["topoType"] = request.TopoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGpuClusterTopology",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiTopology/topology/clusterTopology",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGpuClusterTopologyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the GPU cluster topology.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install the component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>When a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only the first 50 nodes are processed in the first batch.</description></item>
        /// <item><description>The operating system console periodically checks the scaling status of managed clusters. When a new ECS instance is added to a cluster, the console automatically installs the component on it without requiring manual intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterTopologyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterTopologyResponse
        /// </returns>
        public async Task<GetGpuClusterTopologyResponse> GetGpuClusterTopologyWithOptionsAsync(GetGpuClusterTopologyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["channelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["clusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunicationId))
            {
                query["communicationId"] = request.CommunicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["instanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodList))
            {
                query["podList"] = request.PodList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdList))
            {
                query["taskIdList"] = request.TaskIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopoType))
            {
                query["topoType"] = request.TopoType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGpuClusterTopology",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiTopology/topology/clusterTopology",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGpuClusterTopologyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the GPU cluster topology.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install the component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>When a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only the first 50 nodes are processed in the first batch.</description></item>
        /// <item><description>The operating system console periodically checks the scaling status of managed clusters. When a new ECS instance is added to a cluster, the console automatically installs the component on it without requiring manual intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterTopologyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterTopologyResponse
        /// </returns>
        public GetGpuClusterTopologyResponse GetGpuClusterTopology(GetGpuClusterTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGpuClusterTopologyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the GPU cluster topology.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install the component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>When a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster has more than 50 nodes, only the first 50 nodes are processed in the first batch.</description></item>
        /// <item><description>The operating system console periodically checks the scaling status of managed clusters. When a new ECS instance is added to a cluster, the console automatically installs the component on it without requiring manual intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGpuClusterTopologyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGpuClusterTopologyResponse
        /// </returns>
        public async Task<GetGpuClusterTopologyResponse> GetGpuClusterTopologyAsync(GetGpuClusterTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGpuClusterTopologyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health status distribution of nodes or pods over a specified time period.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHealthPercentageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHealthPercentageResponse
        /// </returns>
        public GetHealthPercentageResponse GetHealthPercentageWithOptions(GetHealthPercentageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHealthPercentage",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/health_percentage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHealthPercentageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health status distribution of nodes or pods over a specified time period.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHealthPercentageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHealthPercentageResponse
        /// </returns>
        public async Task<GetHealthPercentageResponse> GetHealthPercentageWithOptionsAsync(GetHealthPercentageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHealthPercentage",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/health_percentage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHealthPercentageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health status distribution of nodes or pods over a specified time period.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHealthPercentageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHealthPercentageResponse
        /// </returns>
        public GetHealthPercentageResponse GetHealthPercentage(GetHealthPercentageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHealthPercentageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health status distribution of nodes or pods over a specified time period.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHealthPercentageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHealthPercentageResponse
        /// </returns>
        public async Task<GetHealthPercentageResponse> GetHealthPercentageAsync(GetHealthPercentageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHealthPercentageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of nodes or node Pods in a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHostCountRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHostCountResponse
        /// </returns>
        public GetHostCountResponse GetHostCountWithOptions(GetHostCountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHostCount",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/host_count",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHostCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of nodes or node Pods in a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHostCountRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHostCountResponse
        /// </returns>
        public async Task<GetHostCountResponse> GetHostCountWithOptionsAsync(GetHostCountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHostCount",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/host_count",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHostCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of nodes or node Pods in a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHostCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHostCountResponse
        /// </returns>
        public GetHostCountResponse GetHostCount(GetHostCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHostCountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the number of nodes or node Pods in a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHostCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHostCountResponse
        /// </returns>
        public async Task<GetHostCountResponse> GetHostCountAsync(GetHostCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHostCountWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of a specific field under an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotSpotUniqListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotSpotUniqListResponse
        /// </returns>
        public GetHotSpotUniqListResponse GetHotSpotUniqListWithOptions(GetHotSpotUniqListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegEnd))
            {
                body["beg_end"] = request.BegEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegStart))
            {
                body["beg_start"] = request.BegStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid))
            {
                body["pid"] = request.Pid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uniq))
            {
                body["uniq"] = request.Uniq;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotSpotUniqList",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/livetrace_proxy/hotspot_uniq_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotSpotUniqListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of a specific field under an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotSpotUniqListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotSpotUniqListResponse
        /// </returns>
        public async Task<GetHotSpotUniqListResponse> GetHotSpotUniqListWithOptionsAsync(GetHotSpotUniqListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegEnd))
            {
                body["beg_end"] = request.BegEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegStart))
            {
                body["beg_start"] = request.BegStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid))
            {
                body["pid"] = request.Pid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uniq))
            {
                body["uniq"] = request.Uniq;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotSpotUniqList",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/livetrace_proxy/hotspot_uniq_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotSpotUniqListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of a specific field under an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotSpotUniqListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotSpotUniqListResponse
        /// </returns>
        public GetHotSpotUniqListResponse GetHotSpotUniqList(GetHotSpotUniqListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHotSpotUniqListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of a specific field under an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotSpotUniqListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotSpotUniqListResponse
        /// </returns>
        public async Task<GetHotSpotUniqListResponse> GetHotSpotUniqListAsync(GetHotSpotUniqListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHotSpotUniqListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task for CVE hotfixes on a node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The hotfix task process is asynchronous. When you call this operation, the task may still be running. You can check the <c>data.status</c> field in the response to determine the task status. If <c>data.status</c> is <c>Success</c>, the task succeeded, and you can obtain the task result from the <c>data.result</c> field.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetHotfixTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotfixTaskResponse
        /// </returns>
        public GetHotfixTaskResponse GetHotfixTaskWithOptions(GetHotfixTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotfixTask",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/hotfix_manager/task/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotfixTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task for CVE hotfixes on a node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The hotfix task process is asynchronous. When you call this operation, the task may still be running. You can check the <c>data.status</c> field in the response to determine the task status. If <c>data.status</c> is <c>Success</c>, the task succeeded, and you can obtain the task result from the <c>data.result</c> field.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetHotfixTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotfixTaskResponse
        /// </returns>
        public async Task<GetHotfixTaskResponse> GetHotfixTaskWithOptionsAsync(GetHotfixTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotfixTask",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/hotfix_manager/task/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotfixTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task for CVE hotfixes on a node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The hotfix task process is asynchronous. When you call this operation, the task may still be running. You can check the <c>data.status</c> field in the response to determine the task status. If <c>data.status</c> is <c>Success</c>, the task succeeded, and you can obtain the task result from the <c>data.result</c> field.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetHotfixTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotfixTaskResponse
        /// </returns>
        public GetHotfixTaskResponse GetHotfixTask(GetHotfixTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHotfixTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task for CVE hotfixes on a node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The hotfix task process is asynchronous. When you call this operation, the task may still be running. You can check the <c>data.status</c> field in the response to determine the task status. If <c>data.status</c> is <c>Success</c>, the task succeeded, and you can obtain the task result from the <c>data.result</c> field.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetHotfixTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotfixTaskResponse
        /// </returns>
        public async Task<GetHotfixTaskResponse> GetHotfixTaskAsync(GetHotfixTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHotfixTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves hot spot analysis results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotAnalysisResponse
        /// </returns>
        public GetHotspotAnalysisResponse GetHotspotAnalysisWithOptions(GetHotspotAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegEnd))
            {
                body["beg_end"] = request.BegEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegStart))
            {
                body["beg_start"] = request.BegStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid))
            {
                body["pid"] = request.Pid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotspotAnalysis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/livetrace_hotspot_analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotspotAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves hot spot analysis results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotAnalysisResponse
        /// </returns>
        public async Task<GetHotspotAnalysisResponse> GetHotspotAnalysisWithOptionsAsync(GetHotspotAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["appType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegEnd))
            {
                body["beg_end"] = request.BegEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegStart))
            {
                body["beg_start"] = request.BegStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid))
            {
                body["pid"] = request.Pid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotspotAnalysis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/livetrace_hotspot_analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotspotAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves hot spot analysis results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotAnalysisResponse
        /// </returns>
        public GetHotspotAnalysisResponse GetHotspotAnalysis(GetHotspotAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHotspotAnalysisWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves hot spot analysis results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotAnalysisResponse
        /// </returns>
        public async Task<GetHotspotAnalysisResponse> GetHotspotAnalysisAsync(GetHotspotAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHotspotAnalysisWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the results of a hot spot comparison trace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotCompareRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotCompareResponse
        /// </returns>
        public GetHotspotCompareResponse GetHotspotCompareWithOptions(GetHotspotCompareRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Beg1End))
            {
                body["beg1_end"] = request.Beg1End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Beg1Start))
            {
                body["beg1_start"] = request.Beg1Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Beg2End))
            {
                body["beg2_end"] = request.Beg2End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Beg2Start))
            {
                body["beg2_start"] = request.Beg2Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotType))
            {
                body["hot_type"] = request.HotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance1))
            {
                body["instance1"] = request.Instance1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance2))
            {
                body["instance2"] = request.Instance2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid1))
            {
                body["pid1"] = request.Pid1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid2))
            {
                body["pid2"] = request.Pid2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotspotCompare",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/livetrace_hotspot_compare",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotspotCompareResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the results of a hot spot comparison trace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotCompareRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotCompareResponse
        /// </returns>
        public async Task<GetHotspotCompareResponse> GetHotspotCompareWithOptionsAsync(GetHotspotCompareRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Beg1End))
            {
                body["beg1_end"] = request.Beg1End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Beg1Start))
            {
                body["beg1_start"] = request.Beg1Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Beg2End))
            {
                body["beg2_end"] = request.Beg2End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Beg2Start))
            {
                body["beg2_start"] = request.Beg2Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotType))
            {
                body["hot_type"] = request.HotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance1))
            {
                body["instance1"] = request.Instance1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance2))
            {
                body["instance2"] = request.Instance2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid1))
            {
                body["pid1"] = request.Pid1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid2))
            {
                body["pid2"] = request.Pid2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotspotCompare",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/livetrace_hotspot_compare",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotspotCompareResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the results of a hot spot comparison trace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotCompareRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotCompareResponse
        /// </returns>
        public GetHotspotCompareResponse GetHotspotCompare(GetHotspotCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHotspotCompareWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the results of a hot spot comparison trace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotCompareRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotCompareResponse
        /// </returns>
        public async Task<GetHotspotCompareResponse> GetHotspotCompareAsync(GetHotspotCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHotspotCompareWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of hot spot instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotInstanceListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotInstanceListResponse
        /// </returns>
        public GetHotspotInstanceListResponse GetHotspotInstanceListWithOptions(GetHotspotInstanceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegEnd))
            {
                body["beg_end"] = request.BegEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegStart))
            {
                body["beg_start"] = request.BegStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotspotInstanceList",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/livetrace_hotspot_instance_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotspotInstanceListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of hot spot instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotInstanceListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotInstanceListResponse
        /// </returns>
        public async Task<GetHotspotInstanceListResponse> GetHotspotInstanceListWithOptionsAsync(GetHotspotInstanceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegEnd))
            {
                body["beg_end"] = request.BegEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegStart))
            {
                body["beg_start"] = request.BegStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotspotInstanceList",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/livetrace_hotspot_instance_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotspotInstanceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of hot spot instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotInstanceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotInstanceListResponse
        /// </returns>
        public GetHotspotInstanceListResponse GetHotspotInstanceList(GetHotspotInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHotspotInstanceListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of hot spot instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotInstanceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotInstanceListResponse
        /// </returns>
        public async Task<GetHotspotInstanceListResponse> GetHotspotInstanceListAsync(GetHotspotInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHotspotInstanceListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the PID list of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotPidListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotPidListResponse
        /// </returns>
        public GetHotspotPidListResponse GetHotspotPidListWithOptions(GetHotspotPidListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegEnd))
            {
                body["beg_end"] = request.BegEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegStart))
            {
                body["beg_start"] = request.BegStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotspotPidList",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/livetrace_hotspot_pid_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotspotPidListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the PID list of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotPidListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotPidListResponse
        /// </returns>
        public async Task<GetHotspotPidListResponse> GetHotspotPidListWithOptionsAsync(GetHotspotPidListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegEnd))
            {
                body["beg_end"] = request.BegEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegStart))
            {
                body["beg_start"] = request.BegStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotspotPidList",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/livetrace_hotspot_pid_list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotspotPidListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the PID list of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotPidListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotPidListResponse
        /// </returns>
        public GetHotspotPidListResponse GetHotspotPidList(GetHotspotPidListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHotspotPidListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the PID list of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotPidListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotPidListResponse
        /// </returns>
        public async Task<GetHotspotPidListResponse> GetHotspotPidListAsync(GetHotspotPidListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHotspotPidListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves hot spot tracking results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotTrackingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotTrackingResponse
        /// </returns>
        public GetHotspotTrackingResponse GetHotspotTrackingWithOptions(GetHotspotTrackingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegEnd))
            {
                body["beg_end"] = request.BegEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegStart))
            {
                body["beg_start"] = request.BegStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotType))
            {
                body["hot_type"] = request.HotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid))
            {
                body["pid"] = request.Pid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotspotTracking",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/livetrace_hotspot_tracking",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotspotTrackingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves hot spot tracking results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotTrackingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotTrackingResponse
        /// </returns>
        public async Task<GetHotspotTrackingResponse> GetHotspotTrackingWithOptionsAsync(GetHotspotTrackingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegEnd))
            {
                body["beg_end"] = request.BegEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegStart))
            {
                body["beg_start"] = request.BegStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotType))
            {
                body["hot_type"] = request.HotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pid))
            {
                body["pid"] = request.Pid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotspotTracking",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/livetrace_hotspot_tracking",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotspotTrackingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves hot spot tracking results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotTrackingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotTrackingResponse
        /// </returns>
        public GetHotspotTrackingResponse GetHotspotTracking(GetHotspotTrackingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHotspotTrackingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves hot spot tracking results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotspotTrackingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotspotTrackingResponse
        /// </returns>
        public async Task<GetHotspotTrackingResponse> GetHotspotTrackingAsync(GetHotspotTrackingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHotspotTrackingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a SysOM inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectionReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInspectionReportResponse
        /// </returns>
        public GetInspectionReportResponse GetInspectionReportWithOptions(GetInspectionReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["reportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInspectionReport",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/inspection/getInspectionReport",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInspectionReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a SysOM inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectionReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInspectionReportResponse
        /// </returns>
        public async Task<GetInspectionReportResponse> GetInspectionReportWithOptionsAsync(GetInspectionReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["reportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInspectionReport",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/inspection/getInspectionReport",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInspectionReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a SysOM inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectionReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInspectionReportResponse
        /// </returns>
        public GetInspectionReportResponse GetInspectionReport(GetInspectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInspectionReportWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a SysOM inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectionReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInspectionReportResponse
        /// </returns>
        public async Task<GetInspectionReportResponse> GetInspectionReportAsync(GetInspectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInspectionReportWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time health score of a cluster or node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstantScoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstantScoreResponse
        /// </returns>
        public GetInstantScoreResponse GetInstantScoreWithOptions(GetInstantScoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstantScore",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/instant/score",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstantScoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time health score of a cluster or node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstantScoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstantScoreResponse
        /// </returns>
        public async Task<GetInstantScoreResponse> GetInstantScoreWithOptionsAsync(GetInstantScoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstantScore",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/instant/score",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstantScoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time health score of a cluster or node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstantScoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstantScoreResponse
        /// </returns>
        public GetInstantScoreResponse GetInstantScore(GetInstantScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstantScoreWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time health score of a cluster or node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstantScoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstantScoreResponse
        /// </returns>
        public async Task<GetInstantScoreResponse> GetInstantScoreAsync(GetInstantScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstantScoreWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of GPU clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component for the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster contains more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component on it without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetListGpuClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetListGpuClusterResponse
        /// </returns>
        public GetListGpuClusterResponse GetListGpuClusterWithOptions(GetListGpuClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRegion))
            {
                query["timeRegion"] = request.TimeRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetListGpuCluster",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiTopology/topology/listCluster",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetListGpuClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of GPU clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component for the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster contains more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component on it without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetListGpuClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetListGpuClusterResponse
        /// </returns>
        public async Task<GetListGpuClusterResponse> GetListGpuClusterWithOptionsAsync(GetListGpuClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRegion))
            {
                query["timeRegion"] = request.TimeRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetListGpuCluster",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiTopology/topology/listCluster",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetListGpuClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of GPU clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component for the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster contains more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component on it without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetListGpuClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetListGpuClusterResponse
        /// </returns>
        public GetListGpuClusterResponse GetListGpuCluster(GetListGpuClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetListGpuClusterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of GPU clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After installing the component for the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when a cluster is managed for the first time, the component is installed on all ECS instances currently in the cluster. If the cluster contains more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component on it without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetListGpuClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetListGpuClusterResponse
        /// </returns>
        public async Task<GetListGpuClusterResponse> GetListGpuClusterAsync(GetListGpuClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetListGpuClusterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of AI Infra analysis records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListRecordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetListRecordResponse
        /// </returns>
        public GetListRecordResponse GetListRecordWithOptions(GetListRecordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisId))
            {
                query["analysisId"] = request.AnalysisId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                query["customId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetListRecord",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/app_observ/aiAnalysis/list_record",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetListRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of AI Infra analysis records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListRecordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetListRecordResponse
        /// </returns>
        public async Task<GetListRecordResponse> GetListRecordWithOptionsAsync(GetListRecordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisId))
            {
                query["analysisId"] = request.AnalysisId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                query["customId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetListRecord",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/app_observ/aiAnalysis/list_record",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetListRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of AI Infra analysis records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetListRecordResponse
        /// </returns>
        public GetListRecordResponse GetListRecord(GetListRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetListRecordWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of AI Infra analysis records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetListRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetListRecordResponse
        /// </returns>
        public async Task<GetListRecordResponse> GetListRecordAsync(GetListRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetListRecordWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the proportion of anomaly issues for nodes in a cluster or pods in a node within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProblemPercentageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProblemPercentageResponse
        /// </returns>
        public GetProblemPercentageResponse GetProblemPercentageWithOptions(GetProblemPercentageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProblemPercentage",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/problem_percentage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProblemPercentageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the proportion of anomaly issues for nodes in a cluster or pods in a node within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProblemPercentageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProblemPercentageResponse
        /// </returns>
        public async Task<GetProblemPercentageResponse> GetProblemPercentageWithOptionsAsync(GetProblemPercentageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProblemPercentage",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/problem_percentage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProblemPercentageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the proportion of anomaly issues for nodes in a cluster or pods in a node within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProblemPercentageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProblemPercentageResponse
        /// </returns>
        public GetProblemPercentageResponse GetProblemPercentage(GetProblemPercentageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProblemPercentageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the proportion of anomaly issues for nodes in a cluster or pods in a node within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProblemPercentageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProblemPercentageResponse
        /// </returns>
        public async Task<GetProblemPercentageResponse> GetProblemPercentageAsync(GetProblemPercentageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProblemPercentageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health score trend.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRangeScoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRangeScoreResponse
        /// </returns>
        public GetRangeScoreResponse GetRangeScoreWithOptions(GetRangeScoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRangeScore",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/score",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRangeScoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health score trend.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRangeScoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRangeScoreResponse
        /// </returns>
        public async Task<GetRangeScoreResponse> GetRangeScoreWithOptionsAsync(GetRangeScoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRangeScore",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/score",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRangeScoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health score trend.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRangeScoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRangeScoreResponse
        /// </returns>
        public GetRangeScoreResponse GetRangeScore(GetRangeScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRangeScoreWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health score trend.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRangeScoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRangeScoreResponse
        /// </returns>
        public async Task<GetRangeScoreResponse> GetRangeScoreAsync(GetRangeScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRangeScoreWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time resource usage of a cluster or node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourcesResponse
        /// </returns>
        public GetResourcesResponse GetResourcesWithOptions(GetResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
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
                Action = "GetResources",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/instant/resource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time resource usage of a cluster or node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourcesResponse
        /// </returns>
        public async Task<GetResourcesResponse> GetResourcesWithOptionsAsync(GetResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
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
                Action = "GetResources",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/instant/resource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time resource usage of a cluster or node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourcesResponse
        /// </returns>
        public GetResourcesResponse GetResources(GetResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time resource usage of a cluster or node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourcesResponse
        /// </returns>
        public async Task<GetResourcesResponse> GetResourcesAsync(GetResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration of a feature module.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the service configuration status.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetServiceFuncStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceFuncStatusResponse
        /// </returns>
        public GetServiceFuncStatusResponse GetServiceFuncStatusWithOptions(GetServiceFuncStatusRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetServiceFuncStatusShrinkRequest request = new GetServiceFuncStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "params", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                query["params"] = request.ParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["service_name"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceFuncStatus",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/func-switch/get-service-func-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceFuncStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration of a feature module.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the service configuration status.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetServiceFuncStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceFuncStatusResponse
        /// </returns>
        public async Task<GetServiceFuncStatusResponse> GetServiceFuncStatusWithOptionsAsync(GetServiceFuncStatusRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetServiceFuncStatusShrinkRequest request = new GetServiceFuncStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "params", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                query["params"] = request.ParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["service_name"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceFuncStatus",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/func-switch/get-service-func-status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceFuncStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration of a feature module.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the service configuration status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceFuncStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceFuncStatusResponse
        /// </returns>
        public GetServiceFuncStatusResponse GetServiceFuncStatus(GetServiceFuncStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceFuncStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration of a feature module.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the service configuration status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceFuncStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceFuncStatusResponse
        /// </returns>
        public async Task<GetServiceFuncStatusResponse> GetServiceFuncStatusAsync(GetServiceFuncStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceFuncStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution status and diagnostic result of a diagnostic task by task ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVmcoreDiagnosisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVmcoreDiagnosisTaskResponse
        /// </returns>
        public GetVmcoreDiagnosisTaskResponse GetVmcoreDiagnosisTaskWithOptions(GetVmcoreDiagnosisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVmcoreDiagnosisTask",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crashAgent/diagnosis/queryTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVmcoreDiagnosisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution status and diagnostic result of a diagnostic task by task ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVmcoreDiagnosisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVmcoreDiagnosisTaskResponse
        /// </returns>
        public async Task<GetVmcoreDiagnosisTaskResponse> GetVmcoreDiagnosisTaskWithOptionsAsync(GetVmcoreDiagnosisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVmcoreDiagnosisTask",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crashAgent/diagnosis/queryTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVmcoreDiagnosisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution status and diagnostic result of a diagnostic task by task ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVmcoreDiagnosisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVmcoreDiagnosisTaskResponse
        /// </returns>
        public GetVmcoreDiagnosisTaskResponse GetVmcoreDiagnosisTask(GetVmcoreDiagnosisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVmcoreDiagnosisTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution status and diagnostic result of a diagnostic task by task ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVmcoreDiagnosisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVmcoreDiagnosisTaskResponse
        /// </returns>
        public async Task<GetVmcoreDiagnosisTaskResponse> GetVmcoreDiagnosisTaskAsync(GetVmcoreDiagnosisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVmcoreDiagnosisTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initializes SysOM to ensure that the service-linked role exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Some SysOM API operations require role assumption based on the <c>AliyunServiceRoleForSysom</c> service-linked role. Before using SysOM features, invoke this operation to perform initialization and ensure that the service-linked role has been created.</para>
        /// <list type="bullet">
        /// <item><description><c>check_only</c>: If this parameter is set to True, only a check is performed to determine whether the service-linked role exists. The service-linked role is not created. If this parameter is set to False or left empty, automatic creation of the service-linked role is performed if it does not exist.<remarks>
        /// <para>Note: When you call this operation to initialize the role, you agree to the user agreement of the operating system console by default. For more information, see <a href="https://www.alibabacloud.com/help/en/alinux/product-overview/os-console-overview">Operating system console overview</a> and <a href="https://terms.aliyun.com/legal-agreement/terms/suit_bu1_ali_cloud/suit_bu1_ali_cloud202001091714_51956.html">Alibaba Cloud Service Trial Terms</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InitialSysomRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitialSysomResponse
        /// </returns>
        public InitialSysomResponse InitialSysomWithOptions(InitialSysomRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOnly))
            {
                body["check_only"] = request.CheckOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitialSysom",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/initial",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitialSysomResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initializes SysOM to ensure that the service-linked role exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Some SysOM API operations require role assumption based on the <c>AliyunServiceRoleForSysom</c> service-linked role. Before using SysOM features, invoke this operation to perform initialization and ensure that the service-linked role has been created.</para>
        /// <list type="bullet">
        /// <item><description><c>check_only</c>: If this parameter is set to True, only a check is performed to determine whether the service-linked role exists. The service-linked role is not created. If this parameter is set to False or left empty, automatic creation of the service-linked role is performed if it does not exist.<remarks>
        /// <para>Note: When you call this operation to initialize the role, you agree to the user agreement of the operating system console by default. For more information, see <a href="https://www.alibabacloud.com/help/en/alinux/product-overview/os-console-overview">Operating system console overview</a> and <a href="https://terms.aliyun.com/legal-agreement/terms/suit_bu1_ali_cloud/suit_bu1_ali_cloud202001091714_51956.html">Alibaba Cloud Service Trial Terms</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InitialSysomRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitialSysomResponse
        /// </returns>
        public async Task<InitialSysomResponse> InitialSysomWithOptionsAsync(InitialSysomRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckOnly))
            {
                body["check_only"] = request.CheckOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitialSysom",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/initial",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitialSysomResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initializes SysOM to ensure that the service-linked role exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Some SysOM API operations require role assumption based on the <c>AliyunServiceRoleForSysom</c> service-linked role. Before using SysOM features, invoke this operation to perform initialization and ensure that the service-linked role has been created.</para>
        /// <list type="bullet">
        /// <item><description><c>check_only</c>: If this parameter is set to True, only a check is performed to determine whether the service-linked role exists. The service-linked role is not created. If this parameter is set to False or left empty, automatic creation of the service-linked role is performed if it does not exist.<remarks>
        /// <para>Note: When you call this operation to initialize the role, you agree to the user agreement of the operating system console by default. For more information, see <a href="https://www.alibabacloud.com/help/en/alinux/product-overview/os-console-overview">Operating system console overview</a> and <a href="https://terms.aliyun.com/legal-agreement/terms/suit_bu1_ali_cloud/suit_bu1_ali_cloud202001091714_51956.html">Alibaba Cloud Service Trial Terms</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InitialSysomRequest
        /// </param>
        /// 
        /// <returns>
        /// InitialSysomResponse
        /// </returns>
        public InitialSysomResponse InitialSysom(InitialSysomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InitialSysomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initializes SysOM to ensure that the service-linked role exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Some SysOM API operations require role assumption based on the <c>AliyunServiceRoleForSysom</c> service-linked role. Before using SysOM features, invoke this operation to perform initialization and ensure that the service-linked role has been created.</para>
        /// <list type="bullet">
        /// <item><description><c>check_only</c>: If this parameter is set to True, only a check is performed to determine whether the service-linked role exists. The service-linked role is not created. If this parameter is set to False or left empty, automatic creation of the service-linked role is performed if it does not exist.<remarks>
        /// <para>Note: When you call this operation to initialize the role, you agree to the user agreement of the operating system console by default. For more information, see <a href="https://www.alibabacloud.com/help/en/alinux/product-overview/os-console-overview">Operating system console overview</a> and <a href="https://terms.aliyun.com/legal-agreement/terms/suit_bu1_ali_cloud/suit_bu1_ali_cloud202001091714_51956.html">Alibaba Cloud Service Trial Terms</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InitialSysomRequest
        /// </param>
        /// 
        /// <returns>
        /// InitialSysomResponse
        /// </returns>
        public async Task<InitialSysomResponse> InitialSysomAsync(InitialSysomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InitialSysomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an agent on a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to install an agent is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetAgentTask operation to query the task execution status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentResponse
        /// </returns>
        public InstallAgentResponse InstallAgentWithOptions(InstallAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallType))
            {
                body["install_type"] = request.InstallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallAgent",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/install_agent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an agent on a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to install an agent is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetAgentTask operation to query the task execution status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentResponse
        /// </returns>
        public async Task<InstallAgentResponse> InstallAgentWithOptionsAsync(InstallAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallType))
            {
                body["install_type"] = request.InstallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallAgent",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/install_agent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an agent on a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to install an agent is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetAgentTask operation to query the task execution status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentResponse
        /// </returns>
        public InstallAgentResponse InstallAgent(InstallAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallAgentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an agent on a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to install an agent is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetAgentTask operation to query the task execution status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentResponse
        /// </returns>
        public async Task<InstallAgentResponse> InstallAgentAsync(InstallAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallAgentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a component on an ACK cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install a component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when the cluster is managed for the first time, the component is installed on all existing ECS instances in the cluster. If the cluster contains more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component on the instance without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentForClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentForClusterResponse
        /// </returns>
        public InstallAgentForClusterResponse InstallAgentForClusterWithOptions(InstallAgentForClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                body["config_id"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayscaleConfig))
            {
                body["grayscale_config"] = request.GrayscaleConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallAgentForCluster",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/install_agent_by_cluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAgentForClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a component on an ACK cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install a component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when the cluster is managed for the first time, the component is installed on all existing ECS instances in the cluster. If the cluster contains more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component on the instance without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentForClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentForClusterResponse
        /// </returns>
        public async Task<InstallAgentForClusterResponse> InstallAgentForClusterWithOptionsAsync(InstallAgentForClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                body["config_id"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayscaleConfig))
            {
                body["grayscale_config"] = request.GrayscaleConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallAgentForCluster",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/install_agent_by_cluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAgentForClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a component on an ACK cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install a component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when the cluster is managed for the first time, the component is installed on all existing ECS instances in the cluster. If the cluster contains more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component on the instance without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentForClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentForClusterResponse
        /// </returns>
        public InstallAgentForClusterResponse InstallAgentForCluster(InstallAgentForClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallAgentForClusterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a component on an ACK cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install a component on the target ACK cluster:</para>
        /// <ol>
        /// <item><description>First, when the cluster is managed for the first time, the component is installed on all existing ECS instances in the cluster. If the cluster contains more than 50 nodes, only 50 instances are included in the first batch.</description></item>
        /// <item><description>Then, the operating system console periodically checks the scaling status of the managed cluster. When a new ECS instance is added to the cluster, the operating system console automatically installs the component on the instance without user intervention.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentForClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentForClusterResponse
        /// </returns>
        public async Task<InstallAgentForClusterResponse> InstallAgentForClusterAsync(InstallAgentForClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallAgentForClusterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an Agent on a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to install an Agent is asynchronous. After the call, a task_id is returned. You can use this ID to call the GetAgentTask operation to check the task execution status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentWithTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentWithTypeResponse
        /// </returns>
        public InstallAgentWithTypeResponse InstallAgentWithTypeWithOptions(InstallAgentWithTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                body["configId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallAgentWithType",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/installAgent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAgentWithTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an Agent on a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to install an Agent is asynchronous. After the call, a task_id is returned. You can use this ID to call the GetAgentTask operation to check the task execution status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentWithTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentWithTypeResponse
        /// </returns>
        public async Task<InstallAgentWithTypeResponse> InstallAgentWithTypeWithOptionsAsync(InstallAgentWithTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                body["configId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallAgentWithType",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/installAgent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAgentWithTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an Agent on a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to install an Agent is asynchronous. After the call, a task_id is returned. You can use this ID to call the GetAgentTask operation to check the task execution status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentWithTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentWithTypeResponse
        /// </returns>
        public InstallAgentWithTypeResponse InstallAgentWithType(InstallAgentWithTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallAgentWithTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an Agent on a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to install an Agent is asynchronous. After the call, a task_id is returned. You can use this ID to call the GetAgentTask operation to check the task execution status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAgentWithTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAgentWithTypeResponse
        /// </returns>
        public async Task<InstallAgentWithTypeResponse> InstallAgentWithTypeAsync(InstallAgentWithTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallAgentWithTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs CVE hotfixes asynchronously on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation asynchronously installs the agent. After the operation is called, a task ID is returned. You can use this ID to call the GetHotfixTask operation to query the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallHotfixRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallHotfixResponse
        /// </returns>
        public InstallHotfixResponse InstallHotfixWithOptions(InstallHotfixRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CveId))
            {
                body["cveId"] = request.CveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallHotfix",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/hotfix_manager/hotfix/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallHotfixResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs CVE hotfixes asynchronously on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation asynchronously installs the agent. After the operation is called, a task ID is returned. You can use this ID to call the GetHotfixTask operation to query the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallHotfixRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallHotfixResponse
        /// </returns>
        public async Task<InstallHotfixResponse> InstallHotfixWithOptionsAsync(InstallHotfixRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CveId))
            {
                body["cveId"] = request.CveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallHotfix",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/hotfix_manager/hotfix/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallHotfixResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs CVE hotfixes asynchronously on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation asynchronously installs the agent. After the operation is called, a task ID is returned. You can use this ID to call the GetHotfixTask operation to query the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallHotfixRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallHotfixResponse
        /// </returns>
        public InstallHotfixResponse InstallHotfix(InstallHotfixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallHotfixWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs CVE hotfixes asynchronously on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation asynchronously installs the agent. After the operation is called, a task ID is returned. You can use this ID to call the GetHotfixTask operation to query the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallHotfixRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallHotfixResponse
        /// </returns>
        public async Task<InstallHotfixResponse> InstallHotfixAsync(InstallHotfixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallHotfixWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an anomaly diagnosis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeAnomalyDiagnosisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeAnomalyDiagnosisResponse
        /// </returns>
        public InvokeAnomalyDiagnosisResponse InvokeAnomalyDiagnosisWithOptions(InvokeAnomalyDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeAnomalyDiagnosis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/diagnosis/invoke_anomaly_diagnose",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeAnomalyDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an anomaly diagnosis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeAnomalyDiagnosisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeAnomalyDiagnosisResponse
        /// </returns>
        public async Task<InvokeAnomalyDiagnosisResponse> InvokeAnomalyDiagnosisWithOptionsAsync(InvokeAnomalyDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeAnomalyDiagnosis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/diagnosis/invoke_anomaly_diagnose",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeAnomalyDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an anomaly diagnosis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeAnomalyDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeAnomalyDiagnosisResponse
        /// </returns>
        public InvokeAnomalyDiagnosisResponse InvokeAnomalyDiagnosis(InvokeAnomalyDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvokeAnomalyDiagnosisWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an anomaly diagnosis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeAnomalyDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeAnomalyDiagnosisResponse
        /// </returns>
        public async Task<InvokeAnomalyDiagnosisResponse> InvokeAnomalyDiagnosisAsync(InvokeAnomalyDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvokeAnomalyDiagnosisWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a diagnostic task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The following requirements must be met to diagnose a target ECS instance:</para>
        /// <list type="bullet">
        /// <item><description>The target ECS instance status must be Running.</description></item>
        /// <item><description>Cloud Assistant must be installed on the target ECS instance. If it is not installed, refer to <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/install-the-cloud-assistant-agent">Install the Cloud Assistant Agent</a> for installation.</description></item>
        /// <item><description>You must invoke the AuthDiagnosis operation to authorize SysOM to diagnose the target ECS instance. If authorization is not granted, this operation directly fails.</description></item>
        /// <item><description>This operation depends on the SysOM service-linked role (AliyunServiceRoleForSysom) being created. This operation does not automatically create the service-linked role. If the service-linked role does not exist, first invoke AuthDiagnosis to associate the authorization. That operation creates the aforementioned service-linked role.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InvokeDiagnosisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeDiagnosisResponse
        /// </returns>
        public InvokeDiagnosisResponse InvokeDiagnosisWithOptions(InvokeDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["service_name"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeDiagnosis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/diagnosis/invoke_diagnosis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a diagnostic task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The following requirements must be met to diagnose a target ECS instance:</para>
        /// <list type="bullet">
        /// <item><description>The target ECS instance status must be Running.</description></item>
        /// <item><description>Cloud Assistant must be installed on the target ECS instance. If it is not installed, refer to <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/install-the-cloud-assistant-agent">Install the Cloud Assistant Agent</a> for installation.</description></item>
        /// <item><description>You must invoke the AuthDiagnosis operation to authorize SysOM to diagnose the target ECS instance. If authorization is not granted, this operation directly fails.</description></item>
        /// <item><description>This operation depends on the SysOM service-linked role (AliyunServiceRoleForSysom) being created. This operation does not automatically create the service-linked role. If the service-linked role does not exist, first invoke AuthDiagnosis to associate the authorization. That operation creates the aforementioned service-linked role.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InvokeDiagnosisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeDiagnosisResponse
        /// </returns>
        public async Task<InvokeDiagnosisResponse> InvokeDiagnosisWithOptionsAsync(InvokeDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["service_name"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeDiagnosis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/diagnosis/invoke_diagnosis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a diagnostic task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The following requirements must be met to diagnose a target ECS instance:</para>
        /// <list type="bullet">
        /// <item><description>The target ECS instance status must be Running.</description></item>
        /// <item><description>Cloud Assistant must be installed on the target ECS instance. If it is not installed, refer to <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/install-the-cloud-assistant-agent">Install the Cloud Assistant Agent</a> for installation.</description></item>
        /// <item><description>You must invoke the AuthDiagnosis operation to authorize SysOM to diagnose the target ECS instance. If authorization is not granted, this operation directly fails.</description></item>
        /// <item><description>This operation depends on the SysOM service-linked role (AliyunServiceRoleForSysom) being created. This operation does not automatically create the service-linked role. If the service-linked role does not exist, first invoke AuthDiagnosis to associate the authorization. That operation creates the aforementioned service-linked role.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InvokeDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeDiagnosisResponse
        /// </returns>
        public InvokeDiagnosisResponse InvokeDiagnosis(InvokeDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvokeDiagnosisWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a diagnostic task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The following requirements must be met to diagnose a target ECS instance:</para>
        /// <list type="bullet">
        /// <item><description>The target ECS instance status must be Running.</description></item>
        /// <item><description>Cloud Assistant must be installed on the target ECS instance. If it is not installed, refer to <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/install-the-cloud-assistant-agent">Install the Cloud Assistant Agent</a> for installation.</description></item>
        /// <item><description>You must invoke the AuthDiagnosis operation to authorize SysOM to diagnose the target ECS instance. If authorization is not granted, this operation directly fails.</description></item>
        /// <item><description>This operation depends on the SysOM service-linked role (AliyunServiceRoleForSysom) being created. This operation does not automatically create the service-linked role. If the service-linked role does not exist, first invoke AuthDiagnosis to associate the authorization. That operation creates the aforementioned service-linked role.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InvokeDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeDiagnosisResponse
        /// </returns>
        public async Task<InvokeDiagnosisResponse> InvokeDiagnosisAsync(InvokeDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvokeDiagnosisWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves anomaly event information for a cluster, node, or pod within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAbnormalyEventsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAbnormalyEventsResponse
        /// </returns>
        public ListAbnormalyEventsResponse ListAbnormalyEventsWithOptions(ListAbnormalyEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                query["event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pod))
            {
                query["pod"] = request.Pod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowPod))
            {
                query["showPod"] = request.ShowPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAbnormalyEvents",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/abnormaly_events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAbnormalyEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves anomaly event information for a cluster, node, or pod within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAbnormalyEventsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAbnormalyEventsResponse
        /// </returns>
        public async Task<ListAbnormalyEventsResponse> ListAbnormalyEventsWithOptionsAsync(ListAbnormalyEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                query["event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pod))
            {
                query["pod"] = request.Pod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowPod))
            {
                query["showPod"] = request.ShowPod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAbnormalyEvents",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/abnormaly_events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAbnormalyEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves anomaly event information for a cluster, node, or pod within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAbnormalyEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAbnormalyEventsResponse
        /// </returns>
        public ListAbnormalyEventsResponse ListAbnormalyEvents(ListAbnormalyEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAbnormalyEventsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves anomaly event information for a cluster, node, or pod within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAbnormalyEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAbnormalyEventsResponse
        /// </returns>
        public async Task<ListAbnormalyEventsResponse> ListAbnormalyEventsAsync(ListAbnormalyEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAbnormalyEventsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the installation records of an Agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentInstallRecordsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentInstallRecordsResponse
        /// </returns>
        public ListAgentInstallRecordsResponse ListAgentInstallRecordsWithOptions(ListAgentInstallRecordsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instance_id"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["plugin_id"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginVersion))
            {
                query["plugin_version"] = request.PluginVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentInstallRecords",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/list_agent_install_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentInstallRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the installation records of an Agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentInstallRecordsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentInstallRecordsResponse
        /// </returns>
        public async Task<ListAgentInstallRecordsResponse> ListAgentInstallRecordsWithOptionsAsync(ListAgentInstallRecordsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instance_id"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["plugin_id"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginVersion))
            {
                query["plugin_version"] = request.PluginVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentInstallRecords",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/list_agent_install_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentInstallRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the installation records of an Agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentInstallRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentInstallRecordsResponse
        /// </returns>
        public ListAgentInstallRecordsResponse ListAgentInstallRecords(ListAgentInstallRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentInstallRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the installation records of an Agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentInstallRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentInstallRecordsResponse
        /// </returns>
        public async Task<ListAgentInstallRecordsResponse> ListAgentInstallRecordsAsync(ListAgentInstallRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentInstallRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of Agents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public ListAgentsResponse ListAgentsWithOptions(ListAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "ListAgents",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/list_agents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of Agents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public async Task<ListAgentsResponse> ListAgentsWithOptionsAsync(ListAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "ListAgents",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/list_agents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of Agents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of Agents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public async Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of diagnostic tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of regions where the current user has machines managed by SysOM. If the user has ECS instances in a region but those instances are not managed by SysOM, that region does not appear in the results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAifgJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAifgJobsResponse
        /// </returns>
        public ListAifgJobsResponse ListAifgJobsWithOptions(ListAifgJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAifgJobs",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aifg/listAifgJobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAifgJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of diagnostic tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of regions where the current user has machines managed by SysOM. If the user has ECS instances in a region but those instances are not managed by SysOM, that region does not appear in the results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAifgJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAifgJobsResponse
        /// </returns>
        public async Task<ListAifgJobsResponse> ListAifgJobsWithOptionsAsync(ListAifgJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAifgJobs",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aifg/listAifgJobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAifgJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of diagnostic tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of regions where the current user has machines managed by SysOM. If the user has ECS instances in a region but those instances are not managed by SysOM, that region does not appear in the results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAifgJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAifgJobsResponse
        /// </returns>
        public ListAifgJobsResponse ListAifgJobs(ListAifgJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAifgJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of diagnostic tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of regions where the current user has machines managed by SysOM. If the user has ECS instances in a region but those instances are not managed by SysOM, that region does not appear in the results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAifgJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAifgJobsResponse
        /// </returns>
        public async Task<ListAifgJobsResponse> ListAifgJobsAsync(ListAifgJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAifgJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of alert contacts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertDestinationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertDestinationsResponse
        /// </returns>
        public ListAlertDestinationsResponse ListAlertDestinationsWithOptions(ListAlertDestinationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListAlertDestinations",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/listDestinations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertDestinationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of alert contacts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertDestinationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertDestinationsResponse
        /// </returns>
        public async Task<ListAlertDestinationsResponse> ListAlertDestinationsWithOptionsAsync(ListAlertDestinationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListAlertDestinations",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/listDestinations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertDestinationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of alert contacts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertDestinationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertDestinationsResponse
        /// </returns>
        public ListAlertDestinationsResponse ListAlertDestinations(ListAlertDestinationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlertDestinationsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of alert contacts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertDestinationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertDestinationsResponse
        /// </returns>
        public async Task<ListAlertDestinationsResponse> ListAlertDestinationsAsync(ListAlertDestinationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlertDestinationsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all alert metrics.</para>
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
        /// ListAlertItemsResponse
        /// </returns>
        public ListAlertItemsResponse ListAlertItemsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlertItems",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/listItems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all alert metrics.</para>
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
        /// ListAlertItemsResponse
        /// </returns>
        public async Task<ListAlertItemsResponse> ListAlertItemsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlertItems",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/listItems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all alert metrics.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAlertItemsResponse
        /// </returns>
        public ListAlertItemsResponse ListAlertItems()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlertItemsWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all alert metrics.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAlertItemsResponse
        /// </returns>
        public async Task<ListAlertItemsResponse> ListAlertItemsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlertItemsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all alert policies configured by the user for push notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertStrategiesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertStrategiesResponse
        /// </returns>
        public ListAlertStrategiesResponse ListAlertStrategiesWithOptions(ListAlertStrategiesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListAlertStrategies",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/listStrategies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertStrategiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all alert policies configured by the user for push notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertStrategiesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlertStrategiesResponse
        /// </returns>
        public async Task<ListAlertStrategiesResponse> ListAlertStrategiesWithOptionsAsync(ListAlertStrategiesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListAlertStrategies",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/listStrategies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertStrategiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all alert policies configured by the user for push notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertStrategiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertStrategiesResponse
        /// </returns>
        public ListAlertStrategiesResponse ListAlertStrategies(ListAlertStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlertStrategiesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all alert policies configured by the user for push notifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlertStrategiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlertStrategiesResponse
        /// </returns>
        public async Task<ListAlertStrategiesResponse> ListAlertStrategiesAsync(ListAlertStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlertStrategiesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of managed and unmanaged instances along with their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllInstancesResponse
        /// </returns>
        public ListAllInstancesResponse ListAllInstancesWithOptions(ListAllInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagedType))
            {
                query["managedType"] = request.ManagedType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllInstances",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/listAllInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of managed and unmanaged instances along with their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllInstancesResponse
        /// </returns>
        public async Task<ListAllInstancesResponse> ListAllInstancesWithOptionsAsync(ListAllInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagedType))
            {
                query["managedType"] = request.ManagedType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllInstances",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/listAllInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of managed and unmanaged instances along with their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllInstancesResponse
        /// </returns>
        public ListAllInstancesResponse ListAllInstances(ListAllInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAllInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of managed and unmanaged instances along with their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllInstancesResponse
        /// </returns>
        public async Task<ListAllInstancesResponse> ListAllInstancesAsync(ListAllInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAllInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the installation records of cluster components.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClusterAgentInstallRecordsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClusterAgentInstallRecordsResponse
        /// </returns>
        public ListClusterAgentInstallRecordsResponse ListClusterAgentInstallRecordsWithOptions(ListClusterAgentInstallRecordsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentConfigId))
            {
                query["agent_config_id"] = request.AgentConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["plugin_id"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginVersion))
            {
                query["plugin_version"] = request.PluginVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterAgentInstallRecords",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/list_cluster_agent_install_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterAgentInstallRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the installation records of cluster components.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClusterAgentInstallRecordsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClusterAgentInstallRecordsResponse
        /// </returns>
        public async Task<ListClusterAgentInstallRecordsResponse> ListClusterAgentInstallRecordsWithOptionsAsync(ListClusterAgentInstallRecordsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentConfigId))
            {
                query["agent_config_id"] = request.AgentConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["plugin_id"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginVersion))
            {
                query["plugin_version"] = request.PluginVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterAgentInstallRecords",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/list_cluster_agent_install_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterAgentInstallRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the installation records of cluster components.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClusterAgentInstallRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClusterAgentInstallRecordsResponse
        /// </returns>
        public ListClusterAgentInstallRecordsResponse ListClusterAgentInstallRecords(ListClusterAgentInstallRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClusterAgentInstallRecordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the installation records of cluster components.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClusterAgentInstallRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClusterAgentInstallRecordsResponse
        /// </returns>
        public async Task<ListClusterAgentInstallRecordsResponse> ListClusterAgentInstallRecordsAsync(ListClusterAgentInstallRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClusterAgentInstallRecordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all managed clusters for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClustersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public ListClustersResponse ListClustersWithOptions(ListClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterStatus))
            {
                query["cluster_status"] = request.ClusterStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "ListClusters",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/cluster/list_clusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClustersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all managed clusters for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClustersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public async Task<ListClustersResponse> ListClustersWithOptionsAsync(ListClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterStatus))
            {
                query["cluster_status"] = request.ClusterStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "ListClusters",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/cluster/list_clusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all managed clusters for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClustersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public ListClustersResponse ListClusters(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClustersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all managed clusters for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClustersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClustersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of diagnostic history records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDiagnosisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDiagnosisResponse
        /// </returns>
        public ListDiagnosisResponse ListDiagnosisWithOptions(ListDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["service_name"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiagnosis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/diagnosis/list_diagnosis",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of diagnostic history records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDiagnosisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDiagnosisResponse
        /// </returns>
        public async Task<ListDiagnosisResponse> ListDiagnosisWithOptionsAsync(ListDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["service_name"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiagnosis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/diagnosis/list_diagnosis",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of diagnostic history records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDiagnosisResponse
        /// </returns>
        public ListDiagnosisResponse ListDiagnosis(ListDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDiagnosisWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of diagnostic history records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDiagnosisResponse
        /// </returns>
        public async Task<ListDiagnosisResponse> ListDiagnosisAsync(ListDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDiagnosisWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health status list of cluster nodes or pods within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceHealthRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceHealthResponse
        /// </returns>
        public ListInstanceHealthResponse ListInstanceHealthWithOptions(ListInstanceHealthRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceHealth",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/instance_health_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceHealthResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health status list of cluster nodes or pods within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceHealthRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceHealthResponse
        /// </returns>
        public async Task<ListInstanceHealthResponse> ListInstanceHealthWithOptionsAsync(ListInstanceHealthRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                query["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceHealth",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/cluster_health/range/instance_health_list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceHealthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health status list of cluster nodes or pods within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceHealthRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceHealthResponse
        /// </returns>
        public ListInstanceHealthResponse ListInstanceHealth(ListInstanceHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceHealthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the health status list of cluster nodes or pods within a specified time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceHealthRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceHealthResponse
        /// </returns>
        public async Task<ListInstanceHealthResponse> ListInstanceHealthAsync(ListInstanceHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceHealthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all values of a specific type of instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceInfoResponse
        /// </returns>
        public ListInstanceInfoResponse ListInstanceInfoWithOptions(ListInstanceInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfoType))
            {
                query["infoType"] = request.InfoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagedType))
            {
                query["managedType"] = request.ManagedType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceInfo",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/listInstanceInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all values of a specific type of instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceInfoResponse
        /// </returns>
        public async Task<ListInstanceInfoResponse> ListInstanceInfoWithOptionsAsync(ListInstanceInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfoType))
            {
                query["infoType"] = request.InfoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagedType))
            {
                query["managedType"] = request.ManagedType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["pluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceInfo",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/listInstanceInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all values of a specific type of instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceInfoResponse
        /// </returns>
        public ListInstanceInfoResponse ListInstanceInfo(ListInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves all values of a specific type of instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceInfoResponse
        /// </returns>
        public async Task<ListInstanceInfoResponse> ListInstanceInfoAsync(ListInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the instance status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the list of machines managed by SysOM.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceStatusResponse
        /// </returns>
        public ListInstanceStatusResponse ListInstanceStatusWithOptions(ListInstanceStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceStatus",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/list_instance_status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the instance status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the list of machines managed by SysOM.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceStatusResponse
        /// </returns>
        public async Task<ListInstanceStatusResponse> ListInstanceStatusWithOptionsAsync(ListInstanceStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceStatus",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/list_instance_status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the instance status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the list of machines managed by SysOM.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceStatusResponse
        /// </returns>
        public ListInstanceStatusResponse ListInstanceStatus(ListInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the instance status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the list of machines managed by SysOM.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceStatusResponse
        /// </returns>
        public async Task<ListInstanceStatusResponse> ListInstanceStatusAsync(ListInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of managed instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of instances that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/list_instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of managed instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of instances that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/list_instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of managed instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of instances that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of managed instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of instances that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves ECS information lists for instances, such as tag lists and public IP address lists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesEcsInfoListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesEcsInfoListResponse
        /// </returns>
        public ListInstancesEcsInfoListResponse ListInstancesEcsInfoListWithOptions(ListInstancesEcsInfoListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfoType))
            {
                query["info_type"] = request.InfoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instance_id"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagedType))
            {
                query["managed_type"] = request.ManagedType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["plugin_id"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancesEcsInfoList",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/listInstancesEcsInfoList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesEcsInfoListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves ECS information lists for instances, such as tag lists and public IP address lists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesEcsInfoListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesEcsInfoListResponse
        /// </returns>
        public async Task<ListInstancesEcsInfoListResponse> ListInstancesEcsInfoListWithOptionsAsync(ListInstancesEcsInfoListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfoType))
            {
                query["info_type"] = request.InfoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instance_id"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagedType))
            {
                query["managed_type"] = request.ManagedType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["plugin_id"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancesEcsInfoList",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/listInstancesEcsInfoList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesEcsInfoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves ECS information lists for instances, such as tag lists and public IP address lists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesEcsInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesEcsInfoListResponse
        /// </returns>
        public ListInstancesEcsInfoListResponse ListInstancesEcsInfoList(ListInstancesEcsInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesEcsInfoListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves ECS information lists for instances, such as tag lists and public IP address lists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesEcsInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesEcsInfoListResponse
        /// </returns>
        public async Task<ListInstancesEcsInfoListResponse> ListInstancesEcsInfoListAsync(ListInstancesEcsInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesEcsInfoListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about managed and unmanaged instances, including ECS information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListInstancesWithEcsInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesWithEcsInfoResponse
        /// </returns>
        public ListInstancesWithEcsInfoResponse ListInstancesWithEcsInfoWithOptions(ListInstancesWithEcsInfoRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListInstancesWithEcsInfoShrinkRequest request = new ListInstancesWithEcsInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceTag))
            {
                request.InstanceTagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceTag, "instance_tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthStatus))
            {
                query["health_status"] = request.HealthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instance_id"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdName))
            {
                query["instance_id_name"] = request.InstanceIdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["instance_name"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTagShrink))
            {
                query["instance_tag"] = request.InstanceTagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsManaged))
            {
                query["is_managed"] = request.IsManaged;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsName))
            {
                query["os_name"] = request.OsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIp))
            {
                query["private_ip"] = request.PrivateIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIp))
            {
                query["public_ip"] = request.PublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resource_group_id"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdName))
            {
                query["resource_group_id_name"] = request.ResourceGroupIdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["resource_group_name"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancesWithEcsInfo",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/listInstancesWithEcsInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesWithEcsInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about managed and unmanaged instances, including ECS information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListInstancesWithEcsInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesWithEcsInfoResponse
        /// </returns>
        public async Task<ListInstancesWithEcsInfoResponse> ListInstancesWithEcsInfoWithOptionsAsync(ListInstancesWithEcsInfoRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListInstancesWithEcsInfoShrinkRequest request = new ListInstancesWithEcsInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceTag))
            {
                request.InstanceTagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceTag, "instance_tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthStatus))
            {
                query["health_status"] = request.HealthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instance_id"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdName))
            {
                query["instance_id_name"] = request.InstanceIdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["instance_name"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTagShrink))
            {
                query["instance_tag"] = request.InstanceTagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsManaged))
            {
                query["is_managed"] = request.IsManaged;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsName))
            {
                query["os_name"] = request.OsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIp))
            {
                query["private_ip"] = request.PrivateIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIp))
            {
                query["public_ip"] = request.PublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resource_group_id"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdName))
            {
                query["resource_group_id_name"] = request.ResourceGroupIdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["resource_group_name"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancesWithEcsInfo",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/listInstancesWithEcsInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesWithEcsInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about managed and unmanaged instances, including ECS information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesWithEcsInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesWithEcsInfoResponse
        /// </returns>
        public ListInstancesWithEcsInfoResponse ListInstancesWithEcsInfo(ListInstancesWithEcsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithEcsInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about managed and unmanaged instances, including ECS information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesWithEcsInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesWithEcsInfoResponse
        /// </returns>
        public async Task<ListInstancesWithEcsInfoResponse> ListInstancesWithEcsInfoAsync(ListInstancesWithEcsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithEcsInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of instances for plug-in installation, update, or uninstallation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPluginsInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPluginsInstancesResponse
        /// </returns>
        public ListPluginsInstancesResponse ListPluginsInstancesWithOptions(ListPluginsInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdName))
            {
                query["instance_id_name"] = request.InstanceIdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTag))
            {
                query["instance_tag"] = request.InstanceTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["operation_type"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["plugin_id"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPluginsInstances",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/listPluginsInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPluginsInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of instances for plug-in installation, update, or uninstallation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPluginsInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPluginsInstancesResponse
        /// </returns>
        public async Task<ListPluginsInstancesResponse> ListPluginsInstancesWithOptionsAsync(ListPluginsInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdName))
            {
                query["instance_id_name"] = request.InstanceIdName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTag))
            {
                query["instance_tag"] = request.InstanceTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["operation_type"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["plugin_id"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPluginsInstances",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/listPluginsInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPluginsInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of instances for plug-in installation, update, or uninstallation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPluginsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPluginsInstancesResponse
        /// </returns>
        public ListPluginsInstancesResponse ListPluginsInstances(ListPluginsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPluginsInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of instances for plug-in installation, update, or uninstallation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list retrieved by this operation contains only machines that are managed by SysOM. If an ECS instance exists but is not managed by SysOM, it does not appear in the list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPluginsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPluginsInstancesResponse
        /// </returns>
        public async Task<ListPluginsInstancesResponse> ListPluginsInstancesAsync(ListPluginsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPluginsInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of pods in a cluster or instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPodsOfInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPodsOfInstanceResponse
        /// </returns>
        public ListPodsOfInstanceResponse ListPodsOfInstanceWithOptions(ListPodsOfInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
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
                Action = "ListPodsOfInstance",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/list_pod_of_instance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPodsOfInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of pods in a cluster or instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPodsOfInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPodsOfInstanceResponse
        /// </returns>
        public async Task<ListPodsOfInstanceResponse> ListPodsOfInstanceWithOptionsAsync(ListPodsOfInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                query["instance"] = request.Instance;
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
                Action = "ListPodsOfInstance",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/list_pod_of_instance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPodsOfInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of pods in a cluster or instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPodsOfInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPodsOfInstanceResponse
        /// </returns>
        public ListPodsOfInstanceResponse ListPodsOfInstance(ListPodsOfInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPodsOfInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of pods in a cluster or instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPodsOfInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPodsOfInstanceResponse
        /// </returns>
        public async Task<ListPodsOfInstanceResponse> ListPodsOfInstanceAsync(ListPodsOfInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPodsOfInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all regions that contain managed instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of regions where the current user has instances managed by SysOM. If a user has ECS instances in a region but none of them are managed by SysOM, that region is not included in the response.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegionsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/list_regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all regions that contain managed instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of regions where the current user has instances managed by SysOM. If a user has ECS instances in a region but none of them are managed by SysOM, that region is not included in the response.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/instance/list_regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all regions that contain managed instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of regions where the current user has instances managed by SysOM. If a user has ECS instances in a region but none of them are managed by SysOM, that region is not included in the response.</para>
        /// </description>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRegionsWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all regions that contain managed instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the list of regions where the current user has instances managed by SysOM. If a user has ECS instances in a region but none of them are managed by SysOM, that region is not included in the response.</para>
        /// </description>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRegionsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of historical down diagnosis tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVmcoreDiagnosisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVmcoreDiagnosisTaskResponse
        /// </returns>
        public ListVmcoreDiagnosisTaskResponse ListVmcoreDiagnosisTaskWithOptions(ListVmcoreDiagnosisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["days"] = request.Days;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVmcoreDiagnosisTask",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crashAgent/diagnosis/queryTaskList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVmcoreDiagnosisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of historical down diagnosis tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVmcoreDiagnosisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVmcoreDiagnosisTaskResponse
        /// </returns>
        public async Task<ListVmcoreDiagnosisTaskResponse> ListVmcoreDiagnosisTaskWithOptionsAsync(ListVmcoreDiagnosisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["days"] = request.Days;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVmcoreDiagnosisTask",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crashAgent/diagnosis/queryTaskList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVmcoreDiagnosisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of historical down diagnosis tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVmcoreDiagnosisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVmcoreDiagnosisTaskResponse
        /// </returns>
        public ListVmcoreDiagnosisTaskResponse ListVmcoreDiagnosisTask(ListVmcoreDiagnosisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVmcoreDiagnosisTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of historical down diagnosis tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVmcoreDiagnosisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVmcoreDiagnosisTaskResponse
        /// </returns>
        public async Task<ListVmcoreDiagnosisTaskResponse> ListVmcoreDiagnosisTaskAsync(ListVmcoreDiagnosisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVmcoreDiagnosisTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the CVE hotfix status on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The call to this operation to install the agent is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetHotfixTask operation to obtain the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryHotfixStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHotfixStatusResponse
        /// </returns>
        public QueryHotfixStatusResponse QueryHotfixStatusWithOptions(QueryHotfixStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CveId))
            {
                body["cveId"] = request.CveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHotfixStatus",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/hotfix_manager/hotfix/query_status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotfixStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the CVE hotfix status on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The call to this operation to install the agent is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetHotfixTask operation to obtain the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryHotfixStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHotfixStatusResponse
        /// </returns>
        public async Task<QueryHotfixStatusResponse> QueryHotfixStatusWithOptionsAsync(QueryHotfixStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CveId))
            {
                body["cveId"] = request.CveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHotfixStatus",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/hotfix_manager/hotfix/query_status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotfixStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the CVE hotfix status on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The call to this operation to install the agent is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetHotfixTask operation to obtain the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryHotfixStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHotfixStatusResponse
        /// </returns>
        public QueryHotfixStatusResponse QueryHotfixStatus(QueryHotfixStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryHotfixStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the CVE hotfix status on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The call to this operation to install the agent is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetHotfixTask operation to obtain the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryHotfixStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHotfixStatusResponse
        /// </returns>
        public async Task<QueryHotfixStatusResponse> QueryHotfixStatusAsync(QueryHotfixStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryHotfixStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts AI job analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAIAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAIAnalysisResponse
        /// </returns>
        public StartAIAnalysisResponse StartAIAnalysisWithOptions(StartAIAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisTool))
            {
                body["analysisTool"] = request.AnalysisTool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisParams))
            {
                body["analysis_params"] = request.AnalysisParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comms))
            {
                body["comms"] = request.Comms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedBy))
            {
                body["created_by"] = request.CreatedBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instance_type"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IterationFunc))
            {
                body["iteration_func"] = request.IterationFunc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IterationMod))
            {
                body["iteration_mod"] = request.IterationMod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IterationRange))
            {
                body["iteration_range"] = request.IterationRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pids))
            {
                body["pids"] = request.Pids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAIAnalysis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/start_ai_analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAIAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts AI job analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAIAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAIAnalysisResponse
        /// </returns>
        public async Task<StartAIAnalysisResponse> StartAIAnalysisWithOptionsAsync(StartAIAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisTool))
            {
                body["analysisTool"] = request.AnalysisTool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisParams))
            {
                body["analysis_params"] = request.AnalysisParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comms))
            {
                body["comms"] = request.Comms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedBy))
            {
                body["created_by"] = request.CreatedBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                body["instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instance_type"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IterationFunc))
            {
                body["iteration_func"] = request.IterationFunc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IterationMod))
            {
                body["iteration_mod"] = request.IterationMod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IterationRange))
            {
                body["iteration_range"] = request.IterationRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pids))
            {
                body["pids"] = request.Pids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAIAnalysis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/start_ai_analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAIAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts AI job analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAIAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAIAnalysisResponse
        /// </returns>
        public StartAIAnalysisResponse StartAIAnalysis(StartAIAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartAIAnalysisWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts AI job analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAIAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAIAnalysisResponse
        /// </returns>
        public async Task<StartAIAnalysisResponse> StartAIAnalysisAsync(StartAIAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartAIAnalysisWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an AI Infra differential analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis of the same PID across different steps within the same AI Infra analysis record is supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAIDiffAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAIDiffAnalysisResponse
        /// </returns>
        public StartAIDiffAnalysisResponse StartAIDiffAnalysisWithOptions(StartAIDiffAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task1))
            {
                body["task1"] = request.Task1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task2))
            {
                body["task2"] = request.Task2;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAIDiffAnalysis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/appObserv/aiAnalysis/diffAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAIDiffAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an AI Infra differential analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis of the same PID across different steps within the same AI Infra analysis record is supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAIDiffAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAIDiffAnalysisResponse
        /// </returns>
        public async Task<StartAIDiffAnalysisResponse> StartAIDiffAnalysisWithOptionsAsync(StartAIDiffAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task1))
            {
                body["task1"] = request.Task1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task2))
            {
                body["task2"] = request.Task2;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAIDiffAnalysis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/appObserv/aiAnalysis/diffAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAIDiffAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an AI Infra differential analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis of the same PID across different steps within the same AI Infra analysis record is supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAIDiffAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAIDiffAnalysisResponse
        /// </returns>
        public StartAIDiffAnalysisResponse StartAIDiffAnalysis(StartAIDiffAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartAIDiffAnalysisWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an AI Infra differential analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis of the same PID across different steps within the same AI Infra analysis record is supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAIDiffAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAIDiffAnalysisResponse
        /// </returns>
        public async Task<StartAIDiffAnalysisResponse> StartAIDiffAnalysisAsync(StartAIDiffAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartAIDiffAnalysisWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers AI application diagnostics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis of the same PID across different steps within the same AI Infra analysis record is supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAifgAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAifgAnalysisResponse
        /// </returns>
        public StartAifgAnalysisResponse StartAifgAnalysisWithOptions(StartAifgAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAifgAnalysis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aifg/startAifgAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAifgAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers AI application diagnostics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis of the same PID across different steps within the same AI Infra analysis record is supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAifgAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAifgAnalysisResponse
        /// </returns>
        public async Task<StartAifgAnalysisResponse> StartAifgAnalysisWithOptionsAsync(StartAifgAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAifgAnalysis",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aifg/startAifgAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAifgAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers AI application diagnostics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis of the same PID across different steps within the same AI Infra analysis record is supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAifgAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAifgAnalysisResponse
        /// </returns>
        public StartAifgAnalysisResponse StartAifgAnalysis(StartAifgAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartAifgAnalysisWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers AI application diagnostics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis of the same PID across different steps within the same AI Infra analysis record is supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartAifgAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAifgAnalysisResponse
        /// </returns>
        public async Task<StartAifgAnalysisResponse> StartAifgAnalysisAsync(StartAifgAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartAifgAnalysisWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a specified version of a component.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to uninstall an Agent is asynchronous. After the call, a task_id is returned. You can use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentResponse
        /// </returns>
        public UninstallAgentResponse UninstallAgentWithOptions(UninstallAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallAgent",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/uninstall_agent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a specified version of a component.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to uninstall an Agent is asynchronous. After the call, a task_id is returned. You can use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentResponse
        /// </returns>
        public async Task<UninstallAgentResponse> UninstallAgentWithOptionsAsync(UninstallAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallAgent",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/uninstall_agent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a specified version of a component.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to uninstall an Agent is asynchronous. After the call, a task_id is returned. You can use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentResponse
        /// </returns>
        public UninstallAgentResponse UninstallAgent(UninstallAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UninstallAgentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a specified version of a component.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to uninstall an Agent is asynchronous. After the call, a task_id is returned. You can use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentResponse
        /// </returns>
        public async Task<UninstallAgentResponse> UninstallAgentAsync(UninstallAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UninstallAgentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a component from a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallAgentForClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentForClusterResponse
        /// </returns>
        public UninstallAgentForClusterResponse UninstallAgentForClusterWithOptions(UninstallAgentForClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["cluster_id"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallAgentForCluster",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/uninstall_agent_by_cluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallAgentForClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a component from a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallAgentForClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentForClusterResponse
        /// </returns>
        public async Task<UninstallAgentForClusterResponse> UninstallAgentForClusterWithOptionsAsync(UninstallAgentForClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["cluster_id"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallAgentForCluster",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/uninstall_agent_by_cluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallAgentForClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a component from a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallAgentForClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentForClusterResponse
        /// </returns>
        public UninstallAgentForClusterResponse UninstallAgentForCluster(UninstallAgentForClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UninstallAgentForClusterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a component from a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallAgentForClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentForClusterResponse
        /// </returns>
        public async Task<UninstallAgentForClusterResponse> UninstallAgentForClusterAsync(UninstallAgentForClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UninstallAgentForClusterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a specified version of a component.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to uninstall an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAgentWithTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentWithTypeResponse
        /// </returns>
        public UninstallAgentWithTypeResponse UninstallAgentWithTypeWithOptions(UninstallAgentWithTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallAgentWithType",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/uninstallAgent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallAgentWithTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a specified version of a component.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to uninstall an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAgentWithTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentWithTypeResponse
        /// </returns>
        public async Task<UninstallAgentWithTypeResponse> UninstallAgentWithTypeWithOptionsAsync(UninstallAgentWithTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallAgentWithType",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/uninstallAgent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallAgentWithTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a specified version of a component.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to uninstall an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAgentWithTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentWithTypeResponse
        /// </returns>
        public UninstallAgentWithTypeResponse UninstallAgentWithType(UninstallAgentWithTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UninstallAgentWithTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a specified version of a component.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to uninstall an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallAgentWithTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallAgentWithTypeResponse
        /// </returns>
        public async Task<UninstallAgentWithTypeResponse> UninstallAgentWithTypeAsync(UninstallAgentWithTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UninstallAgentWithTypeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously uninstalls CVE hotfixes from the specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetHotfixTask operation to query the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallHotfixRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallHotfixResponse
        /// </returns>
        public UninstallHotfixResponse UninstallHotfixWithOptions(UninstallHotfixRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CveId))
            {
                body["cveId"] = request.CveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallHotfix",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/hotfix_manager/hotfix/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallHotfixResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously uninstalls CVE hotfixes from the specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetHotfixTask operation to query the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallHotfixRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallHotfixResponse
        /// </returns>
        public async Task<UninstallHotfixResponse> UninstallHotfixWithOptionsAsync(UninstallHotfixRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CveId))
            {
                body["cveId"] = request.CveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallHotfix",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/hotfix_manager/hotfix/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallHotfixResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously uninstalls CVE hotfixes from the specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetHotfixTask operation to query the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallHotfixRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallHotfixResponse
        /// </returns>
        public UninstallHotfixResponse UninstallHotfix(UninstallHotfixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UninstallHotfixWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously uninstalls CVE hotfixes from the specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is asynchronous. After you call this operation, a task_id is returned. You can use this ID to call the GetHotfixTask operation to query the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallHotfixRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallHotfixResponse
        /// </returns>
        public async Task<UninstallHotfixResponse> UninstallHotfixAsync(UninstallHotfixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UninstallHotfixWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the component configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the configuration is updated, the new configuration is delivered to all resources that use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentConfigResponse
        /// </returns>
        public UpdateAgentConfigResponse UpdateAgentConfigWithOptions(UpdateAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                body["configId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/updateAgentConfig",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the component configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the configuration is updated, the new configuration is delivered to all resources that use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentConfigResponse
        /// </returns>
        public async Task<UpdateAgentConfigResponse> UpdateAgentConfigWithOptionsAsync(UpdateAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                body["configId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/updateAgentConfig",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the component configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the configuration is updated, the new configuration is delivered to all resources that use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentConfigResponse
        /// </returns>
        public UpdateAgentConfigResponse UpdateAgentConfig(UpdateAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAgentConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the component configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the configuration is updated, the new configuration is delivered to all resources that use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentConfigResponse
        /// </returns>
        public async Task<UpdateAgentConfigResponse> UpdateAgentConfigAsync(UpdateAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAgentConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>、</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAlertDestinationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertDestinationResponse
        /// </returns>
        public UpdateAlertDestinationResponse UpdateAlertDestinationWithOptions(UpdateAlertDestinationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["app_id"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                body["app_secret"] = request.AppSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imbot))
            {
                body["imbot"] = request.Imbot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlertDestination",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/updateDestination",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlertDestinationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>、</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAlertDestinationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertDestinationResponse
        /// </returns>
        public async Task<UpdateAlertDestinationResponse> UpdateAlertDestinationWithOptionsAsync(UpdateAlertDestinationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["app_id"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                body["app_secret"] = request.AppSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["group_id"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imbot))
            {
                body["imbot"] = request.Imbot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlertDestination",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/updateDestination",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlertDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>、</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAlertDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertDestinationResponse
        /// </returns>
        public UpdateAlertDestinationResponse UpdateAlertDestination(UpdateAlertDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAlertDestinationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>、</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAlertDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertDestinationResponse
        /// </returns>
        public async Task<UpdateAlertDestinationResponse> UpdateAlertDestinationAsync(UpdateAlertDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAlertDestinationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of a push alert policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertEnabledRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertEnabledResponse
        /// </returns>
        public UpdateAlertEnabledResponse UpdateAlertEnabledWithOptions(UpdateAlertEnabledRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlertEnabled",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/updateEnabled",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlertEnabledResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of a push alert policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertEnabledRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertEnabledResponse
        /// </returns>
        public async Task<UpdateAlertEnabledResponse> UpdateAlertEnabledWithOptionsAsync(UpdateAlertEnabledRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlertEnabled",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/updateEnabled",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlertEnabledResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of a push alert policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertEnabledRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertEnabledResponse
        /// </returns>
        public UpdateAlertEnabledResponse UpdateAlertEnabled(UpdateAlertEnabledRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAlertEnabledWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of a push alert policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertEnabledRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertEnabledResponse
        /// </returns>
        public async Task<UpdateAlertEnabledResponse> UpdateAlertEnabledAsync(UpdateAlertEnabledRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAlertEnabledWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a push alert policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertStrategyResponse
        /// </returns>
        public UpdateAlertStrategyResponse UpdateAlertStrategyWithOptions(UpdateAlertStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sLabel))
            {
                body["k8sLabel"] = request.K8sLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                body["strategy"] = request.Strategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlertStrategy",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/updateStrategy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlertStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a push alert policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertStrategyResponse
        /// </returns>
        public async Task<UpdateAlertStrategyResponse> UpdateAlertStrategyWithOptionsAsync(UpdateAlertStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sLabel))
            {
                body["k8sLabel"] = request.K8sLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                body["strategy"] = request.Strategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlertStrategy",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/alertPusher/alert/updateStrategy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAlertStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a push alert policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertStrategyResponse
        /// </returns>
        public UpdateAlertStrategyResponse UpdateAlertStrategy(UpdateAlertStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAlertStrategyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a push alert policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAlertStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAlertStrategyResponse
        /// </returns>
        public async Task<UpdateAlertStrategyResponse> UpdateAlertStrategyAsync(UpdateAlertStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAlertStrategyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a cluster component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClusterAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterAgentConfigResponse
        /// </returns>
        public UpdateClusterAgentConfigResponse UpdateClusterAgentConfigWithOptions(UpdateClusterAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["clusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                body["configId"] = request.ConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClusterAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/updateClusterAgentConfig",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClusterAgentConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a cluster component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClusterAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterAgentConfigResponse
        /// </returns>
        public async Task<UpdateClusterAgentConfigResponse> UpdateClusterAgentConfigWithOptionsAsync(UpdateClusterAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["clusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                body["configId"] = request.ConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClusterAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/updateClusterAgentConfig",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClusterAgentConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a cluster component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClusterAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterAgentConfigResponse
        /// </returns>
        public UpdateClusterAgentConfigResponse UpdateClusterAgentConfig(UpdateClusterAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateClusterAgentConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a cluster component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClusterAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterAgentConfigResponse
        /// </returns>
        public async Task<UpdateClusterAgentConfigResponse> UpdateClusterAgentConfigAsync(UpdateClusterAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateClusterAgentConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attention level of an anomaly item. Adjusting the attention level affects the sensitivity of the anomaly detection algorithm.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEventsAttentionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventsAttentionResponse
        /// </returns>
        public UpdateEventsAttentionResponse UpdateEventsAttentionWithOptions(UpdateEventsAttentionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Range))
            {
                body["range"] = request.Range;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventsAttention",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/cluster_update_events_attention",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventsAttentionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attention level of an anomaly item. Adjusting the attention level affects the sensitivity of the anomaly detection algorithm.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEventsAttentionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventsAttentionResponse
        /// </returns>
        public async Task<UpdateEventsAttentionResponse> UpdateEventsAttentionWithOptionsAsync(UpdateEventsAttentionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Range))
            {
                body["range"] = request.Range;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventsAttention",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/openapi/proxy/post/cluster_update_events_attention",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventsAttentionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attention level of an anomaly item. Adjusting the attention level affects the sensitivity of the anomaly detection algorithm.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEventsAttentionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventsAttentionResponse
        /// </returns>
        public UpdateEventsAttentionResponse UpdateEventsAttention(UpdateEventsAttentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEventsAttentionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the attention level of an anomaly item. Adjusting the attention level affects the sensitivity of the anomaly detection algorithm.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEventsAttentionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventsAttentionResponse
        /// </returns>
        public async Task<UpdateEventsAttentionResponse> UpdateEventsAttentionAsync(UpdateEventsAttentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEventsAttentionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a service feature module.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Populate parameters according to the general LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned data from a string to a dict before use. Refer to the general LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateFuncSwitchRecordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFuncSwitchRecordResponse
        /// </returns>
        public UpdateFuncSwitchRecordResponse UpdateFuncSwitchRecordWithOptions(UpdateFuncSwitchRecordRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFuncSwitchRecordShrinkRequest request = new UpdateFuncSwitchRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "params", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                query["params"] = request.ParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["service_name"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFuncSwitchRecord",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/func-switch/update-service-func-switch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFuncSwitchRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a service feature module.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Populate parameters according to the general LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned data from a string to a dict before use. Refer to the general LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateFuncSwitchRecordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFuncSwitchRecordResponse
        /// </returns>
        public async Task<UpdateFuncSwitchRecordResponse> UpdateFuncSwitchRecordWithOptionsAsync(UpdateFuncSwitchRecordRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFuncSwitchRecordShrinkRequest request = new UpdateFuncSwitchRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "params", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                query["params"] = request.ParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["service_name"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFuncSwitchRecord",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/func-switch/update-service-func-switch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFuncSwitchRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a service feature module.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Populate parameters according to the general LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned data from a string to a dict before use. Refer to the general LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFuncSwitchRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFuncSwitchRecordResponse
        /// </returns>
        public UpdateFuncSwitchRecordResponse UpdateFuncSwitchRecord(UpdateFuncSwitchRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFuncSwitchRecordWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a service feature module.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Populate parameters according to the general LLM service input parameters, convert them to a string, and assign the string to llmParamString.</description></item>
        /// <item><description>Convert the returned data from a string to a dict before use. Refer to the general LLM service response format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFuncSwitchRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFuncSwitchRecordResponse
        /// </returns>
        public async Task<UpdateFuncSwitchRecordResponse> UpdateFuncSwitchRecordAsync(UpdateFuncSwitchRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFuncSwitchRecordWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the component configuration of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAgentConfigResponse
        /// </returns>
        public UpdateInstanceAgentConfigResponse UpdateInstanceAgentConfigWithOptions(UpdateInstanceAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                body["configId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/updateInstanceAgentConfig",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceAgentConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the component configuration of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceAgentConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAgentConfigResponse
        /// </returns>
        public async Task<UpdateInstanceAgentConfigResponse> UpdateInstanceAgentConfigWithOptionsAsync(UpdateInstanceAgentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                body["configId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceAgentConfig",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/updateInstanceAgentConfig",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceAgentConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the component configuration of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAgentConfigResponse
        /// </returns>
        public UpdateInstanceAgentConfigResponse UpdateInstanceAgentConfig(UpdateInstanceAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceAgentConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the component configuration of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceAgentConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAgentConfigResponse
        /// </returns>
        public async Task<UpdateInstanceAgentConfigResponse> UpdateInstanceAgentConfigAsync(UpdateInstanceAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceAgentConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an installed component to a specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to update an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentResponse
        /// </returns>
        public UpgradeAgentResponse UpgradeAgentWithOptions(UpgradeAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeAgent",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/upgrade_agent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an installed component to a specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to update an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentResponse
        /// </returns>
        public async Task<UpgradeAgentResponse> UpgradeAgentWithOptionsAsync(UpgradeAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeAgent",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/upgrade_agent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an installed component to a specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to update an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentResponse
        /// </returns>
        public UpgradeAgentResponse UpgradeAgent(UpgradeAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeAgentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an installed component to a specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to update an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentResponse
        /// </returns>
        public async Task<UpgradeAgentResponse> UpgradeAgentAsync(UpgradeAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeAgentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a component for a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeAgentForClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentForClusterResponse
        /// </returns>
        public UpgradeAgentForClusterResponse UpgradeAgentForClusterWithOptions(UpgradeAgentForClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["cluster_id"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeAgentForCluster",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/upgrade_agent_by_cluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeAgentForClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a component for a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeAgentForClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentForClusterResponse
        /// </returns>
        public async Task<UpgradeAgentForClusterResponse> UpgradeAgentForClusterWithOptionsAsync(UpgradeAgentForClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agent_version"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["cluster_id"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeAgentForCluster",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/upgrade_agent_by_cluster",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeAgentForClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a component for a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeAgentForClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentForClusterResponse
        /// </returns>
        public UpgradeAgentForClusterResponse UpgradeAgentForCluster(UpgradeAgentForClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeAgentForClusterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a component for a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeAgentForClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentForClusterResponse
        /// </returns>
        public async Task<UpgradeAgentForClusterResponse> UpgradeAgentForClusterAsync(UpgradeAgentForClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeAgentForClusterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version of an installed component to a specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to update an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAgentWithTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentWithTypeResponse
        /// </returns>
        public UpgradeAgentWithTypeResponse UpgradeAgentWithTypeWithOptions(UpgradeAgentWithTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeAgentWithType",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/upgradeAgent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeAgentWithTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version of an installed component to a specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to update an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAgentWithTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentWithTypeResponse
        /// </returns>
        public async Task<UpgradeAgentWithTypeResponse> UpgradeAgentWithTypeWithOptionsAsync(UpgradeAgentWithTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["agentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeAgentWithType",
                Version = "2023-12-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/am/agent/upgradeAgent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeAgentWithTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version of an installed component to a specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to update an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAgentWithTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentWithTypeResponse
        /// </returns>
        public UpgradeAgentWithTypeResponse UpgradeAgentWithType(UpgradeAgentWithTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeAgentWithTypeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version of an installed component to a specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calling this operation to update an Agent is asynchronous. After the call, a task_id is returned. Use this ID to call the GetAgentTask operation to retrieve the execution status of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeAgentWithTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeAgentWithTypeResponse
        /// </returns>
        public async Task<UpgradeAgentWithTypeResponse> UpgradeAgentWithTypeAsync(UpgradeAgentWithTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeAgentWithTypeWithOptionsAsync(request, headers, runtime);
        }

    }
}
