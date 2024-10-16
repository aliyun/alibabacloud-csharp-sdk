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
        /// <para>授权 SysOM 对某个机器进行诊断</para>
        /// </summary>
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
        /// <para>授权 SysOM 对某个机器进行诊断</para>
        /// </summary>
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
        /// <para>授权 SysOM 对某个机器进行诊断</para>
        /// </summary>
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
        /// <para>授权 SysOM 对某个机器进行诊断</para>
        /// </summary>
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
        /// <para>获取copilot服务的返回结果</para>
        /// </summary>
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
        /// <para>获取copilot服务的返回结果</para>
        /// </summary>
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
        /// <para>获取copilot服务的返回结果</para>
        /// </summary>
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
        /// <para>获取copilot服务的返回结果</para>
        /// </summary>
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
        /// <para>获取节点/Pod不同等级异常事件的数量</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pod))
            {
                query["pod"] = request.Pod;
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
        /// <para>获取节点/Pod不同等级异常事件的数量</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pod))
            {
                query["pod"] = request.Pod;
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
        /// <para>获取节点/Pod不同等级异常事件的数量</para>
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
        /// <para>获取节点/Pod不同等级异常事件的数量</para>
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
        /// <para>获取诊断结果</para>
        /// </summary>
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
        /// <para>获取诊断结果</para>
        /// </summary>
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
        /// <para>获取诊断结果</para>
        /// </summary>
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
        /// <para>获取诊断结果</para>
        /// </summary>
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
        /// <para>获取一段时间的节点/pod健康度比例</para>
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
        /// <para>获取一段时间的节点/pod健康度比例</para>
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
        /// <para>获取一段时间的节点/pod健康度比例</para>
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
        /// <para>获取一段时间的节点/pod健康度比例</para>
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
        /// <para>发起诊断</para>
        /// </summary>
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
        /// <para>发起诊断</para>
        /// </summary>
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
        /// <para>发起诊断</para>
        /// </summary>
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
        /// <para>发起诊断</para>
        /// </summary>
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

    }
}
