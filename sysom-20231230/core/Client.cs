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
            this._endpointRule = "";
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
        /// <para>This API is used to authorize SysOM to diagnose ECS instances under your account. You can only invoke the InvokeDiagnosis API to initiate diagnosis on a specific ECS instance after authorizing it through this API.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: The diagnosis feature requires a service-linked role to be created under a Resource Access Management (RAM) user. When you call this API, it automatically checks whether the service-linked role exists. If the role does not exist, the API automatically creates it. This requires the RAM user invoking this API to have the ram:CreateServiceLinkedRole permission.</notice>
        /// When calling this API to authorize SysOM to diagnose ECS instances, note the following:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Each authorization is valid for 7 days. After 7 days, the authorization expires, and you must call this API again to re-authorize.</description></item>
        /// <item><description>If the SysOM service-linked role (AliyunServiceRoleForSysom) does not exist when you call this API, it will be automatically created. This requires the RAM user invoking this API to have the <c>ram:CreateServiceLinkedRole</c> permission.</description></item>
        /// <item><description>When you authorize a specific instance through this API, the system automatically adds the label <c>sysom:diagnosis</c> to the target ECS instance. SysOM can only diagnose instances that have this label.</description></item>
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
        /// <para>This API is used to authorize SysOM to diagnose ECS instances under your account. You can only invoke the InvokeDiagnosis API to initiate diagnosis on a specific ECS instance after authorizing it through this API.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: The diagnosis feature requires a service-linked role to be created under a Resource Access Management (RAM) user. When you call this API, it automatically checks whether the service-linked role exists. If the role does not exist, the API automatically creates it. This requires the RAM user invoking this API to have the ram:CreateServiceLinkedRole permission.</notice>
        /// When calling this API to authorize SysOM to diagnose ECS instances, note the following:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Each authorization is valid for 7 days. After 7 days, the authorization expires, and you must call this API again to re-authorize.</description></item>
        /// <item><description>If the SysOM service-linked role (AliyunServiceRoleForSysom) does not exist when you call this API, it will be automatically created. This requires the RAM user invoking this API to have the <c>ram:CreateServiceLinkedRole</c> permission.</description></item>
        /// <item><description>When you authorize a specific instance through this API, the system automatically adds the label <c>sysom:diagnosis</c> to the target ECS instance. SysOM can only diagnose instances that have this label.</description></item>
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
        /// <para>This API is used to authorize SysOM to diagnose ECS instances under your account. You can only invoke the InvokeDiagnosis API to initiate diagnosis on a specific ECS instance after authorizing it through this API.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: The diagnosis feature requires a service-linked role to be created under a Resource Access Management (RAM) user. When you call this API, it automatically checks whether the service-linked role exists. If the role does not exist, the API automatically creates it. This requires the RAM user invoking this API to have the ram:CreateServiceLinkedRole permission.</notice>
        /// When calling this API to authorize SysOM to diagnose ECS instances, note the following:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Each authorization is valid for 7 days. After 7 days, the authorization expires, and you must call this API again to re-authorize.</description></item>
        /// <item><description>If the SysOM service-linked role (AliyunServiceRoleForSysom) does not exist when you call this API, it will be automatically created. This requires the RAM user invoking this API to have the <c>ram:CreateServiceLinkedRole</c> permission.</description></item>
        /// <item><description>When you authorize a specific instance through this API, the system automatically adds the label <c>sysom:diagnosis</c> to the target ECS instance. SysOM can only diagnose instances that have this label.</description></item>
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
        /// <para>This API is used to authorize SysOM to diagnose ECS instances under your account. You can only invoke the InvokeDiagnosis API to initiate diagnosis on a specific ECS instance after authorizing it through this API.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice: The diagnosis feature requires a service-linked role to be created under a Resource Access Management (RAM) user. When you call this API, it automatically checks whether the service-linked role exists. If the role does not exist, the API automatically creates it. This requires the RAM user invoking this API to have the ram:CreateServiceLinkedRole permission.</notice>
        /// When calling this API to authorize SysOM to diagnose ECS instances, note the following:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Each authorization is valid for 7 days. After 7 days, the authorization expires, and you must call this API again to re-authorize.</description></item>
        /// <item><description>If the SysOM service-linked role (AliyunServiceRoleForSysom) does not exist when you call this API, it will be automatically created. This requires the RAM user invoking this API to have the <c>ram:CreateServiceLinkedRole</c> permission.</description></item>
        /// <item><description>When you authorize a specific instance through this API, the system automatically adds the label <c>sysom:diagnosis</c> to the target ECS instance. SysOM can only diagnose instances that have this label.</description></item>
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
        /// <para>Check whether the target instance is supported by SysOM</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Check whether the target instance is supported by SysOM</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Check whether the target instance is supported by SysOM</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Check whether the target instance is supported by SysOM</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>High-CPU agent streaming API</para>
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
        /// <para>High-CPU agent streaming API</para>
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
        /// <para>High-CPU agent streaming API</para>
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
        /// <para>High-CPU agent streaming API</para>
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
        /// <para>This API is used to create an alert contact for push notifications.</para>
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
        /// <para>This API is used to create an alert contact for push notifications.</para>
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
        /// <para>This API is used to create an alert contact for push notifications.</para>
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
        /// <para>This API is used to create an alert contact for push notifications.</para>
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
        /// <para>Create an alert policy for push notifications</para>
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
        /// <para>Create an alert policy for push notifications</para>
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
        /// <para>Create an alert policy for push notifications</para>
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
        /// <para>Create an alert policy for push notifications</para>
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
        /// <para>创建集群Vpc端点连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>需配合aliyun-tea-openapi-inner包的call_sseapi接口使用</description></item>
        /// <item><description>需要按通用LLM服务输入参数填充参数，转为string后赋给llmParamString</description></item>
        /// <item><description>返回数据需将string转为dict后使用，参考通用LLM服务返回格式</description></item>
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
        /// <para>创建集群Vpc端点连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>需配合aliyun-tea-openapi-inner包的call_sseapi接口使用</description></item>
        /// <item><description>需要按通用LLM服务输入参数填充参数，转为string后赋给llmParamString</description></item>
        /// <item><description>返回数据需将string转为dict后使用，参考通用LLM服务返回格式</description></item>
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
        /// <para>创建集群Vpc端点连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>需配合aliyun-tea-openapi-inner包的call_sseapi接口使用</description></item>
        /// <item><description>需要按通用LLM服务输入参数填充参数，转为string后赋给llmParamString</description></item>
        /// <item><description>返回数据需将string转为dict后使用，参考通用LLM服务返回格式</description></item>
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
        /// <para>创建集群Vpc端点连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>需配合aliyun-tea-openapi-inner包的call_sseapi接口使用</description></item>
        /// <item><description>需要按通用LLM服务输入参数填充参数，转为string后赋给llmParamString</description></item>
        /// <item><description>返回数据需将string转为dict后使用，参考通用LLM服务返回格式</description></item>
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
        /// <para>创建实例巡检</para>
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
        /// <para>创建实例巡检</para>
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
        /// <para>创建实例巡检</para>
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
        /// <para>创建实例巡检</para>
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
        /// <para>This API creates an intelligent breakdown diagnosis task to diagnose the vmcore or dmesg log file provided in the parameters.</para>
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
        /// <para>This API creates an intelligent breakdown diagnosis task to diagnose the vmcore or dmesg log file provided in the parameters.</para>
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
        /// <para>This API creates an intelligent breakdown diagnosis task to diagnose the vmcore or dmesg log file provided in the parameters.</para>
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
        /// <para>This API creates an intelligent breakdown diagnosis task to diagnose the vmcore or dmesg log file provided in the parameters.</para>
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
        /// <para>This API is used to delete an alert contact.</para>
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
        /// <para>This API is used to delete an alert contact.</para>
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
        /// <para>This API is used to delete an alert contact.</para>
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
        /// <para>This API is used to delete an alert contact.</para>
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
        /// <para>User deletes the alert policy for push notifications.</para>
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
        /// <para>User deletes the alert policy for push notifications.</para>
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
        /// <para>User deletes the alert policy for push notifications.</para>
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
        /// <para>User deletes the alert policy for push notifications.</para>
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
        /// <para>Query metrics</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list obtained by this API includes only the machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Query metrics</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list obtained by this API includes only the machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Query metrics</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list obtained by this API includes only the machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Query metrics</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list obtained by this API includes only the machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain the Return Result of the copilot service</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You must fill in the input parameters according to the standard LLM service input parameters, convert them into a string, and assign the result to llmParamString.  </description></item>
        /// <item><description>The returned data must be converted from a string to a dict before use. Refer to the standard LLM service return format.</description></item>
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
        /// <para>Obtain the Return Result of the copilot service</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You must fill in the input parameters according to the standard LLM service input parameters, convert them into a string, and assign the result to llmParamString.  </description></item>
        /// <item><description>The returned data must be converted from a string to a dict before use. Refer to the standard LLM service return format.</description></item>
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
        /// <para>Obtain the Return Result of the copilot service</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You must fill in the input parameters according to the standard LLM service input parameters, convert them into a string, and assign the result to llmParamString.  </description></item>
        /// <item><description>The returned data must be converted from a string to a dict before use. Refer to the standard LLM service return format.</description></item>
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
        /// <para>Obtain the Return Result of the copilot service</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You must fill in the input parameters according to the standard LLM service input parameters, convert them into a string, and assign the result to llmParamString.  </description></item>
        /// <item><description>The returned data must be converted from a string to a dict before use. Refer to the standard LLM service return format.</description></item>
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
        /// <para>Stream Copilot service API</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Must be used together with the call_sseapi API of the aliyun-tea-openapi-inner package.  </description></item>
        /// <item><description>You must populate the input parameters according to the standard LLM service input parameters, convert them into a string, and assign the result to llmParamString.  </description></item>
        /// <item><description>The returned data is a string that you must convert into a dictionary for use, following the standard LLM service response format.</description></item>
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
        /// <para>Stream Copilot service API</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Must be used together with the call_sseapi API of the aliyun-tea-openapi-inner package.  </description></item>
        /// <item><description>You must populate the input parameters according to the standard LLM service input parameters, convert them into a string, and assign the result to llmParamString.  </description></item>
        /// <item><description>The returned data is a string that you must convert into a dictionary for use, following the standard LLM service response format.</description></item>
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
        /// <para>Stream Copilot service API</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Must be used together with the call_sseapi API of the aliyun-tea-openapi-inner package.  </description></item>
        /// <item><description>You must populate the input parameters according to the standard LLM service input parameters, convert them into a string, and assign the result to llmParamString.  </description></item>
        /// <item><description>The returned data is a string that you must convert into a dictionary for use, following the standard LLM service response format.</description></item>
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
        /// <para>Stream Copilot service API</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Must be used together with the call_sseapi API of the aliyun-tea-openapi-inner package.  </description></item>
        /// <item><description>You must populate the input parameters according to the standard LLM service input parameters, convert them into a string, and assign the result to llmParamString.  </description></item>
        /// <item><description>The returned data is a string that you must convert into a dictionary for use, following the standard LLM service response format.</description></item>
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
        /// <para>View AI Infra Analysis Result</para>
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
        /// <para>View AI Infra Analysis Result</para>
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
        /// <para>View AI Infra Analysis Result</para>
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
        /// <para>View AI Infra Analysis Result</para>
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
        /// <para>Obtain the quantity of unprocessed (undiagnosed) anomalous activity at different Levels for edge zones/pods.</para>
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
        /// <para>Obtain the quantity of unprocessed (undiagnosed) anomalous activity at different Levels for edge zones/pods.</para>
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
        /// <para>Obtain the quantity of unprocessed (undiagnosed) anomalous activity at different Levels for edge zones/pods.</para>
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
        /// <para>Obtain the quantity of unprocessed (undiagnosed) anomalous activity at different Levels for edge zones/pods.</para>
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
        /// <para>Retrieve the details of a widget</para>
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
        /// <para>Retrieve the details of a widget</para>
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
        /// <para>Retrieve the details of a widget</para>
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
        /// <para>Retrieve the details of a widget</para>
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
        /// <para>Obtain the task execution status of Agent installation</para>
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
        /// <para>Obtain the task execution status of Agent installation</para>
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
        /// <para>Obtain the task execution status of Agent installation</para>
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
        /// <para>Obtain the task execution status of Agent installation</para>
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
        /// <para>This API is used to obtain the specified alert contact information.</para>
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
        /// <para>This API is used to obtain the specified alert contact information.</para>
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
        /// <para>This API is used to obtain the specified alert contact information.</para>
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
        /// <para>This API is used to obtain the specified alert contact information.</para>
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
        /// <para>Obtain an alert for a user by policy ID.</para>
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
        /// <para>Obtain an alert for a user by policy ID.</para>
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
        /// <para>Obtain an alert for a user by policy ID.</para>
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
        /// <para>Obtain an alert for a user by policy ID.</para>
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
        /// <para>Retrieve copilot chat history</para>
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
        /// <para>Retrieve copilot chat history</para>
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
        /// <para>Retrieve copilot chat history</para>
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
        /// <para>Retrieve copilot chat history</para>
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
        /// <para>Obtain the diagnosis result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnosis flow is asynchronous. Therefore, when you invoke this API, the diagnosis may still be executing and not yet ended. You can check the <c>data.status</c> field in the returned data to determine the status. When <c>data.status == &quot;Success&quot;</c>, it indicates that the diagnosis succeeded, and you can read the diagnosis result from <c>data.result</c>.</para>
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
        /// <para>Obtain the diagnosis result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnosis flow is asynchronous. Therefore, when you invoke this API, the diagnosis may still be executing and not yet ended. You can check the <c>data.status</c> field in the returned data to determine the status. When <c>data.status == &quot;Success&quot;</c>, it indicates that the diagnosis succeeded, and you can read the diagnosis result from <c>data.result</c>.</para>
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
        /// <para>Obtain the diagnosis result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnosis flow is asynchronous. Therefore, when you invoke this API, the diagnosis may still be executing and not yet ended. You can check the <c>data.status</c> field in the returned data to determine the status. When <c>data.status == &quot;Success&quot;</c>, it indicates that the diagnosis succeeded, and you can read the diagnosis result from <c>data.result</c>.</para>
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
        /// <para>Obtain the diagnosis result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The diagnosis flow is asynchronous. Therefore, when you invoke this API, the diagnosis may still be executing and not yet ended. You can check the <c>data.status</c> field in the returned data to determine the status. When <c>data.status == &quot;Success&quot;</c>, it indicates that the diagnosis succeeded, and you can read the diagnosis result from <c>data.result</c>.</para>
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
        /// <para>Obtain the proportion of edge zone/pod health statuses over a period of time</para>
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
        /// <para>Obtain the proportion of edge zone/pod health statuses over a period of time</para>
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
        /// <para>Obtain the proportion of edge zone/pod health statuses over a period of time</para>
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
        /// <para>Obtain the proportion of edge zone/pod health statuses over a period of time</para>
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
        /// <para>Obtain the number of edge zones in a cluster or the number of pods in an edge zone</para>
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
        /// <para>Obtain the number of edge zones in a cluster or the number of pods in an edge zone</para>
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
        /// <para>Obtain the number of edge zones in a cluster or the number of pods in an edge zone</para>
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
        /// <para>Obtain the number of edge zones in a cluster or the number of pods in an edge zone</para>
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
        /// <para>Obtain the list of a specific field under an instance.</para>
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
        /// <para>Obtain the list of a specific field under an instance.</para>
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
        /// <para>Obtain the list of a specific field under an instance.</para>
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
        /// <para>Obtain the list of a specific field under an instance.</para>
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
        /// <para>Obtain hot spot analysis results</para>
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
        /// <para>Obtain hot spot analysis results</para>
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
        /// <para>Obtain hot spot analysis results</para>
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
        /// <para>Obtain hot spot analysis results</para>
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
        /// <para>Obtain hot spot comparison tracing results</para>
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
        /// <para>Obtain hot spot comparison tracing results</para>
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
        /// <para>Obtain hot spot comparison tracing results</para>
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
        /// <para>Obtain hot spot comparison tracing results</para>
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
        /// <para>Obtain the hot spot instance list</para>
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
        /// <para>Obtain the hot spot instance list</para>
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
        /// <para>Obtain the hot spot instance list</para>
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
        /// <para>Obtain the hot spot instance list</para>
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
        /// <para>Obtain the PID list of a specific instance</para>
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
        /// <para>Obtain the PID list of a specific instance</para>
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
        /// <para>Obtain the PID list of a specific instance</para>
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
        /// <para>Obtain the PID list of a specific instance</para>
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
        /// <para>Obtain hot spot tracing results</para>
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
        /// <para>Obtain hot spot tracing results</para>
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
        /// <para>Obtain hot spot tracing results</para>
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
        /// <para>Obtain hot spot tracing results</para>
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
        /// <para>获取巡检报告</para>
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
        /// <para>获取巡检报告</para>
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
        /// <para>获取巡检报告</para>
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
        /// <para>获取巡检报告</para>
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
        /// <para>Obtain real-time cluster/edge zone health degree score</para>
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
        /// <para>Obtain real-time cluster/edge zone health degree score</para>
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
        /// <para>Obtain real-time cluster/edge zone health degree score</para>
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
        /// <para>Obtain real-time cluster/edge zone health degree score</para>
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
        /// <para>AI Infra retrieves the list of analysis records</para>
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
        /// <para>AI Infra retrieves the list of analysis records</para>
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
        /// <para>AI Infra retrieves the list of analysis records</para>
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
        /// <para>AI Infra retrieves the list of analysis records</para>
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
        /// <para>Obtain the proportion of abnormal issues in pods within edge zones or in an edge zone within a cluster over a specified period of time.</para>
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
        /// <para>Obtain the proportion of abnormal issues in pods within edge zones or in an edge zone within a cluster over a specified period of time.</para>
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
        /// <para>Obtain the proportion of abnormal issues in pods within edge zones or in an edge zone within a cluster over a specified period of time.</para>
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
        /// <para>Obtain the proportion of abnormal issues in pods within edge zones or in an edge zone within a cluster over a specified period of time.</para>
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
        /// <para>Retrieve the health score trend</para>
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
        /// <para>Retrieve the health score trend</para>
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
        /// <para>Retrieve the health score trend</para>
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
        /// <para>Retrieve the health score trend</para>
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
        /// <para>Obtain real-time resource usage of clusters or edge zones</para>
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
        /// <para>Obtain real-time resource usage of clusters or edge zones</para>
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
        /// <para>Obtain real-time resource usage of clusters or edge zones</para>
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
        /// <para>Obtain real-time resource usage of clusters or edge zones</para>
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
        /// <para>Obtain Function Modules Configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to retrieve the service configuration status.</para>
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
        /// <para>Obtain Function Modules Configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to retrieve the service configuration status.</para>
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
        /// <para>Obtain Function Modules Configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to retrieve the service configuration status.</para>
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
        /// <para>Obtain Function Modules Configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to retrieve the service configuration status.</para>
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
        /// <para>This API queries the task execution status and diagnosis result based on the job ID.</para>
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
        /// <para>This API queries the task execution status and diagnosis result based on the job ID.</para>
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
        /// <para>This API queries the task execution status and diagnosis result based on the job ID.</para>
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
        /// <para>This API queries the task execution status and diagnosis result based on the job ID.</para>
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
        /// <para>Initialize SysOM and ensure that the service role exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Some SysOM APIs require role assumption based on the <c>AliyunServiceRoleForSysom</c> service role. Therefore, before using SysOM features, you must invoke this API to perform initialization and ensure that the service role has been created.  </para>
        /// <list type="bullet">
        /// <item><description><c>check_only</c>: If this parameter is set to True, the API only checks whether the service role exists and does not create it. If this parameter is set to False or omitted, the API automatically creates the service role if it does not exist.<remarks>
        /// <para>Note: When you invoke this API to initialize the role, you are deemed to have accepted the User Agreement of the operating system console by default. For more information, see <a href="https://help.aliyun.com/zh/alinux/product-overview/os-console-overview?spm=a2c4g.11186623.help-menu-2632541.d_0_7.35a829ffLjQtgg">Overview of the Operating System Console</a> and <a href="https://terms.aliyun.com/legal-agreement/terms/suit_bu1_ali_cloud/suit_bu1_ali_cloud202001091714_51956.html">Alibaba Cloud Service Trial Terms</a>.</para>
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
        /// <para>Initialize SysOM and ensure that the service role exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Some SysOM APIs require role assumption based on the <c>AliyunServiceRoleForSysom</c> service role. Therefore, before using SysOM features, you must invoke this API to perform initialization and ensure that the service role has been created.  </para>
        /// <list type="bullet">
        /// <item><description><c>check_only</c>: If this parameter is set to True, the API only checks whether the service role exists and does not create it. If this parameter is set to False or omitted, the API automatically creates the service role if it does not exist.<remarks>
        /// <para>Note: When you invoke this API to initialize the role, you are deemed to have accepted the User Agreement of the operating system console by default. For more information, see <a href="https://help.aliyun.com/zh/alinux/product-overview/os-console-overview?spm=a2c4g.11186623.help-menu-2632541.d_0_7.35a829ffLjQtgg">Overview of the Operating System Console</a> and <a href="https://terms.aliyun.com/legal-agreement/terms/suit_bu1_ali_cloud/suit_bu1_ali_cloud202001091714_51956.html">Alibaba Cloud Service Trial Terms</a>.</para>
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
        /// <para>Initialize SysOM and ensure that the service role exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Some SysOM APIs require role assumption based on the <c>AliyunServiceRoleForSysom</c> service role. Therefore, before using SysOM features, you must invoke this API to perform initialization and ensure that the service role has been created.  </para>
        /// <list type="bullet">
        /// <item><description><c>check_only</c>: If this parameter is set to True, the API only checks whether the service role exists and does not create it. If this parameter is set to False or omitted, the API automatically creates the service role if it does not exist.<remarks>
        /// <para>Note: When you invoke this API to initialize the role, you are deemed to have accepted the User Agreement of the operating system console by default. For more information, see <a href="https://help.aliyun.com/zh/alinux/product-overview/os-console-overview?spm=a2c4g.11186623.help-menu-2632541.d_0_7.35a829ffLjQtgg">Overview of the Operating System Console</a> and <a href="https://terms.aliyun.com/legal-agreement/terms/suit_bu1_ali_cloud/suit_bu1_ali_cloud202001091714_51956.html">Alibaba Cloud Service Trial Terms</a>.</para>
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
        /// <para>Initialize SysOM and ensure that the service role exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Some SysOM APIs require role assumption based on the <c>AliyunServiceRoleForSysom</c> service role. Therefore, before using SysOM features, you must invoke this API to perform initialization and ensure that the service role has been created.  </para>
        /// <list type="bullet">
        /// <item><description><c>check_only</c>: If this parameter is set to True, the API only checks whether the service role exists and does not create it. If this parameter is set to False or omitted, the API automatically creates the service role if it does not exist.<remarks>
        /// <para>Note: When you invoke this API to initialize the role, you are deemed to have accepted the User Agreement of the operating system console by default. For more information, see <a href="https://help.aliyun.com/zh/alinux/product-overview/os-console-overview?spm=a2c4g.11186623.help-menu-2632541.d_0_7.35a829ffLjQtgg">Overview of the Operating System Console</a> and <a href="https://terms.aliyun.com/legal-agreement/terms/suit_bu1_ali_cloud/suit_bu1_ali_cloud202001091714_51956.html">Alibaba Cloud Service Trial Terms</a>.</para>
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
        /// <para>Install an agent on the specified instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to install an agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the job execution status.</para>
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
        /// <para>Install an agent on the specified instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to install an agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the job execution status.</para>
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
        /// <para>Install an agent on the specified instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to install an agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the job execution status.</para>
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
        /// <para>Install an agent on the specified instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to install an agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the job execution status.</para>
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
        /// <para>Install widgets on a cluster</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install widgets on the specified ACK cluster:  </para>
        /// <ol>
        /// <item><description>When the cluster is first enrolled, widgets are installed on all ECS instances in the cluster (if the cluster contains more than 50 nodes, widgets are installed on only 50 nodes in the first batch).  </description></item>
        /// <item><description>The operating system console periodically checks for scale-in or scale-out events in the enrolled cluster. Whenever new ECS instances are added to the cluster, the operating system console automatically installs widgets on them without requiring user intervention.</description></item>
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
        /// <para>Install widgets on a cluster</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install widgets on the specified ACK cluster:  </para>
        /// <ol>
        /// <item><description>When the cluster is first enrolled, widgets are installed on all ECS instances in the cluster (if the cluster contains more than 50 nodes, widgets are installed on only 50 nodes in the first batch).  </description></item>
        /// <item><description>The operating system console periodically checks for scale-in or scale-out events in the enrolled cluster. Whenever new ECS instances are added to the cluster, the operating system console automatically installs widgets on them without requiring user intervention.</description></item>
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
        /// <para>Install widgets on a cluster</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install widgets on the specified ACK cluster:  </para>
        /// <ol>
        /// <item><description>When the cluster is first enrolled, widgets are installed on all ECS instances in the cluster (if the cluster contains more than 50 nodes, widgets are installed on only 50 nodes in the first batch).  </description></item>
        /// <item><description>The operating system console periodically checks for scale-in or scale-out events in the enrolled cluster. Whenever new ECS instances are added to the cluster, the operating system console automatically installs widgets on them without requiring user intervention.</description></item>
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
        /// <para>Install widgets on a cluster</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you install widgets on the specified ACK cluster:  </para>
        /// <ol>
        /// <item><description>When the cluster is first enrolled, widgets are installed on all ECS instances in the cluster (if the cluster contains more than 50 nodes, widgets are installed on only 50 nodes in the first batch).  </description></item>
        /// <item><description>The operating system console periodically checks for scale-in or scale-out events in the enrolled cluster. Whenever new ECS instances are added to the cluster, the operating system console automatically installs widgets on them without requiring user intervention.</description></item>
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
        /// <para>Initiate diagnosis for anomalous activity</para>
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
        /// <para>Initiate diagnosis for anomalous activity</para>
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
        /// <para>Initiate diagnosis for anomalous activity</para>
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
        /// <para>Initiate diagnosis for anomalous activity</para>
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
        /// <para>Initiate a diagnosis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Diagnosing the target ECS instance has the following requirements:  </para>
        /// <list type="bullet">
        /// <item><description>The instance status of the target ECS instance must be running.  </description></item>
        /// <item><description>The Cloud Assistant Agent must already be installed on the target ECS instance. If it is not installed, install it by referring to <a href="https://help.aliyun.com/zh/ecs/user-guide/install-the-cloud-assistant-agent">Install the Cloud Assistant Agent</a>.  </description></item>
        /// <item><description>You must invoke the AuthDiagnosis API to authorize SysOM to diagnose the target ECS instance. If this authorization is not granted, the API call will fail immediately.  </description></item>
        /// <item><description>This API depends on the existence of the SysOM service-linked role (AliyunServiceRoleForSysom). This API does not create the service-linked role automatically. If the service-linked role does not exist, you must first call AuthDiagnosis to perform authorization, which will create the aforementioned service-linked role.</description></item>
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
        /// <para>Initiate a diagnosis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Diagnosing the target ECS instance has the following requirements:  </para>
        /// <list type="bullet">
        /// <item><description>The instance status of the target ECS instance must be running.  </description></item>
        /// <item><description>The Cloud Assistant Agent must already be installed on the target ECS instance. If it is not installed, install it by referring to <a href="https://help.aliyun.com/zh/ecs/user-guide/install-the-cloud-assistant-agent">Install the Cloud Assistant Agent</a>.  </description></item>
        /// <item><description>You must invoke the AuthDiagnosis API to authorize SysOM to diagnose the target ECS instance. If this authorization is not granted, the API call will fail immediately.  </description></item>
        /// <item><description>This API depends on the existence of the SysOM service-linked role (AliyunServiceRoleForSysom). This API does not create the service-linked role automatically. If the service-linked role does not exist, you must first call AuthDiagnosis to perform authorization, which will create the aforementioned service-linked role.</description></item>
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
        /// <para>Initiate a diagnosis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Diagnosing the target ECS instance has the following requirements:  </para>
        /// <list type="bullet">
        /// <item><description>The instance status of the target ECS instance must be running.  </description></item>
        /// <item><description>The Cloud Assistant Agent must already be installed on the target ECS instance. If it is not installed, install it by referring to <a href="https://help.aliyun.com/zh/ecs/user-guide/install-the-cloud-assistant-agent">Install the Cloud Assistant Agent</a>.  </description></item>
        /// <item><description>You must invoke the AuthDiagnosis API to authorize SysOM to diagnose the target ECS instance. If this authorization is not granted, the API call will fail immediately.  </description></item>
        /// <item><description>This API depends on the existence of the SysOM service-linked role (AliyunServiceRoleForSysom). This API does not create the service-linked role automatically. If the service-linked role does not exist, you must first call AuthDiagnosis to perform authorization, which will create the aforementioned service-linked role.</description></item>
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
        /// <para>Initiate a diagnosis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Diagnosing the target ECS instance has the following requirements:  </para>
        /// <list type="bullet">
        /// <item><description>The instance status of the target ECS instance must be running.  </description></item>
        /// <item><description>The Cloud Assistant Agent must already be installed on the target ECS instance. If it is not installed, install it by referring to <a href="https://help.aliyun.com/zh/ecs/user-guide/install-the-cloud-assistant-agent">Install the Cloud Assistant Agent</a>.  </description></item>
        /// <item><description>You must invoke the AuthDiagnosis API to authorize SysOM to diagnose the target ECS instance. If this authorization is not granted, the API call will fail immediately.  </description></item>
        /// <item><description>This API depends on the existence of the SysOM service-linked role (AliyunServiceRoleForSysom). This API does not create the service-linked role automatically. If the service-linked role does not exist, you must first call AuthDiagnosis to perform authorization, which will create the aforementioned service-linked role.</description></item>
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
        /// <para>Obtain anomalous activity information for clusters, edge zones, or pods within a specified time period.</para>
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
        /// <para>Obtain anomalous activity information for clusters, edge zones, or pods within a specified time period.</para>
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
        /// <para>Obtain anomalous activity information for clusters, edge zones, or pods within a specified time period.</para>
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
        /// <para>Obtain anomalous activity information for clusters, edge zones, or pods within a specified time period.</para>
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
        /// <para>List installation records of the agent</para>
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
        /// <para>List installation records of the agent</para>
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
        /// <para>List installation records of the agent</para>
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
        /// <para>List installation records of the agent</para>
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
        /// <para>Retrieve the Agent List</para>
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
        /// <para>Retrieve the Agent List</para>
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
        /// <para>Retrieve the Agent List</para>
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
        /// <para>Retrieve the Agent List</para>
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
        /// <para>This API is used to obtain the alert contact list.</para>
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
        /// <para>This API is used to obtain the alert contact list.</para>
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
        /// <para>This API is used to obtain the alert contact list.</para>
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
        /// <para>This API is used to obtain the alert contact list.</para>
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
        /// <para>Retrieve all alerting items</para>
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
        /// <para>Retrieve all alerting items</para>
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
        /// <para>Retrieve all alerting items</para>
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
        /// <para>Retrieve all alerting items</para>
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
        /// <para>Used to obtain all alert policies for push notifications of a user</para>
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
        /// <para>Used to obtain all alert policies for push notifications of a user</para>
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
        /// <para>Used to obtain all alert policies for push notifications of a user</para>
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
        /// <para>Used to obtain all alert policies for push notifications of a user</para>
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
        /// <para>This API is used to obtain a list of managed or unmanaged instances along with instance information.</para>
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
        /// <para>This API is used to obtain a list of managed or unmanaged instances along with instance information.</para>
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
        /// <para>This API is used to obtain a list of managed or unmanaged instances along with instance information.</para>
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
        /// <para>This API is used to obtain a list of managed or unmanaged instances along with instance information.</para>
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
        /// <para>Obtain cluster widget installation records</para>
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
        /// <para>Obtain cluster widget installation records</para>
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
        /// <para>Obtain cluster widget installation records</para>
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
        /// <para>Obtain cluster widget installation records</para>
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
        /// <para>Retrieve all clusters managed by the current user</para>
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
        /// <para>Retrieve all clusters managed by the current user</para>
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
        /// <para>Retrieve all clusters managed by the current user</para>
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
        /// <para>Retrieve all clusters managed by the current user</para>
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
        /// <para>Obtain the diagnosis history list.</para>
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
        /// <para>Obtain the diagnosis history list.</para>
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
        /// <para>Obtain the diagnosis history list.</para>
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
        /// <para>Obtain the diagnosis history list.</para>
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
        /// <para>Obtain a list of cluster node or pod health scores within a specified time period.</para>
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
        /// <para>Obtain a list of cluster node or pod health scores within a specified time period.</para>
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
        /// <para>Obtain a list of cluster node or pod health scores within a specified time period.</para>
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
        /// <para>Obtain a list of cluster node or pod health scores within a specified time period.</para>
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
        /// <para>Obtain instance status</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to obtain the list of machines managed by SysOM.</para>
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
        /// <para>Obtain instance status</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to obtain the list of machines managed by SysOM.</para>
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
        /// <para>Obtain instance status</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to obtain the list of machines managed by SysOM.</para>
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
        /// <para>Obtain instance status</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to obtain the list of machines managed by SysOM.</para>
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
        /// <para>Obtain the instance list</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only the machines that have been managed by SysOM. If an ECS instance exists but has not been managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain the instance list</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only the machines that have been managed by SysOM. If an ECS instance exists but has not been managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain the instance list</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only the machines that have been managed by SysOM. If an ECS instance exists but has not been managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain the instance list</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only the machines that have been managed by SysOM. If an ECS instance exists but has not been managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain a list of ECS information, such as the tag list, public IP address list, and so on.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain a list of ECS information, such as the tag list, public IP address list, and so on.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain a list of ECS information, such as the tag list, public IP address list, and so on.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain a list of ECS information, such as the tag list, public IP address list, and so on.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API includes only machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain information about managed or unmanaged instances, including ECS information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API returns a list of instances that have already been managed by SysOM. If an ECS instance exists but has not been managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain information about managed or unmanaged instances, including ECS information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API returns a list of instances that have already been managed by SysOM. If an ECS instance exists but has not been managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain information about managed or unmanaged instances, including ECS information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API returns a list of instances that have already been managed by SysOM. If an ECS instance exists but has not been managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain information about managed or unmanaged instances, including ECS information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The current API returns a list of instances that have already been managed by SysOM. If an ECS instance exists but has not been managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain the list of instances for plugin installation, update, or uninstallation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API consists of machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain the list of instances for plugin installation, update, or uninstallation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API consists of machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain the list of instances for plugin installation, update, or uninstallation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API consists of machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Obtain the list of instances for plugin installation, update, or uninstallation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The instance list returned by this API consists of machines that are already managed by SysOM. If an ECS instance exists but is not managed by SysOM, it will not appear in the list.</para>
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
        /// <para>Retrieve the list of pods in a cluster or instance</para>
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
        /// <para>Retrieve the list of pods in a cluster or instance</para>
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
        /// <para>Retrieve the list of pods in a cluster or instance</para>
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
        /// <para>Retrieve the list of pods in a cluster or instance</para>
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
        /// <para>List all areas where machines are managed</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API retrieves the list of areas where the current user has machines managed by SysOM. If the user has ECS instances in an area but those instances are not managed by SysOM, that area will not appear in the API response.</para>
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
        /// <para>List all areas where machines are managed</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API retrieves the list of areas where the current user has machines managed by SysOM. If the user has ECS instances in an area but those instances are not managed by SysOM, that area will not appear in the API response.</para>
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
        /// <para>List all areas where machines are managed</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API retrieves the list of areas where the current user has machines managed by SysOM. If the user has ECS instances in an area but those instances are not managed by SysOM, that area will not appear in the API response.</para>
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
        /// <para>List all areas where machines are managed</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API retrieves the list of areas where the current user has machines managed by SysOM. If the user has ECS instances in an area but those instances are not managed by SysOM, that area will not appear in the API response.</para>
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
        /// <para>Query the history list of breakdown diagnosis jobs.</para>
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
        /// <para>Query the history list of breakdown diagnosis jobs.</para>
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
        /// <para>Query the history list of breakdown diagnosis jobs.</para>
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
        /// <para>Query the history list of breakdown diagnosis jobs.</para>
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
        /// <para>Start an AI job analysis.</para>
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
        /// <para>Start an AI job analysis.</para>
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
        /// <para>Start an AI job analysis.</para>
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
        /// <para>Start an AI job analysis.</para>
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
        /// <para>Start AI Infra differential analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis between different steps under the same AI Infra analysis record and the same pid is supported.</para>
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
        /// <para>Start AI Infra differential analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis between different steps under the same AI Infra analysis record and the same pid is supported.</para>
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
        /// <para>Start AI Infra differential analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis between different steps under the same AI Infra analysis record and the same pid is supported.</para>
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
        /// <para>Start AI Infra differential analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Currently, only comparative analysis between different steps under the same AI Infra analysis record and the same pid is supported.</para>
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
        /// <para>Uninstall a specified version of the widget</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to uninstall an Agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the execution status of the job.</para>
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
        /// <para>Uninstall a specified version of the widget</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to uninstall an Agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the execution status of the job.</para>
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
        /// <para>Uninstall a specified version of the widget</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to uninstall an Agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the execution status of the job.</para>
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
        /// <para>Uninstall a specified version of the widget</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to uninstall an Agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the execution status of the job.</para>
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
        /// <para>Uninstall a widget from a cluster</para>
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
        /// <para>Uninstall a widget from a cluster</para>
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
        /// <para>Uninstall a widget from a cluster</para>
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
        /// <para>Uninstall a widget from a cluster</para>
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
        /// <para>This API is used to update an alert contact.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
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
        /// <para>This API is used to update an alert contact.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
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
        /// <para>This API is used to update an alert contact.</para>
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
        /// <para>This API is used to update an alert contact.</para>
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
        /// <para>User updates the status of a push alert policy</para>
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
        /// <para>User updates the status of a push alert policy</para>
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
        /// <para>User updates the status of a push alert policy</para>
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
        /// <para>User updates the status of a push alert policy</para>
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
        /// <para>Update push alert policy</para>
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
        /// <para>Update push alert policy</para>
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
        /// <para>Update push alert policy</para>
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
        /// <para>Update push alert policy</para>
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
        /// <para>Update the follow level of an anomalous activity to adjust the sensitivity of the anomaly detection algorithm by modifying the follow level.</para>
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
        /// <para>Update the follow level of an anomalous activity to adjust the sensitivity of the anomaly detection algorithm by modifying the follow level.</para>
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
        /// <para>Update the follow level of an anomalous activity to adjust the sensitivity of the anomaly detection algorithm by modifying the follow level.</para>
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
        /// <para>Update the follow level of an anomalous activity to adjust the sensitivity of the anomaly detection algorithm by modifying the follow level.</para>
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
        /// <para>Update the service function module configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You must fill in the parameters according to the input parameters of the general LLM service, convert them to a string, and assign the result to <c>llmParamString</c>.  </description></item>
        /// <item><description>To use the returned data, convert the string back to a dictionary, following the response format of the general LLM service.</description></item>
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
        /// <para>Update the service function module configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You must fill in the parameters according to the input parameters of the general LLM service, convert them to a string, and assign the result to <c>llmParamString</c>.  </description></item>
        /// <item><description>To use the returned data, convert the string back to a dictionary, following the response format of the general LLM service.</description></item>
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
        /// <para>Update the service function module configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You must fill in the parameters according to the input parameters of the general LLM service, convert them to a string, and assign the result to <c>llmParamString</c>.  </description></item>
        /// <item><description>To use the returned data, convert the string back to a dictionary, following the response format of the general LLM service.</description></item>
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
        /// <para>Update the service function module configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You must fill in the parameters according to the input parameters of the general LLM service, convert them to a string, and assign the result to <c>llmParamString</c>.  </description></item>
        /// <item><description>To use the returned data, convert the string back to a dictionary, following the response format of the general LLM service.</description></item>
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
        /// <para>Update the version of the installed widget to the specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to update the Agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the execution status of the job.</para>
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
        /// <para>Update the version of the installed widget to the specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to update the Agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the execution status of the job.</para>
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
        /// <para>Update the version of the installed widget to the specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to update the Agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the execution status of the job.</para>
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
        /// <para>Update the version of the installed widget to the specified version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API call to update the Agent is asynchronous. After invoking this API, a task_id is returned. You can use this ID to invoke the GetAgentTask API to retrieve the execution status of the job.</para>
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
        /// <para>Update widget for cluster</para>
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
        /// <para>Update widget for cluster</para>
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
        /// <para>Update widget for cluster</para>
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
        /// <para>Update widget for cluster</para>
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

    }
}
