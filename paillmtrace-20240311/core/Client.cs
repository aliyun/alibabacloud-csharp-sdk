// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PaiLLMTrace20240311.Models;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("paillmtrace", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates a trace evaluation task. The system will sample some data from the user\&quot;s trace data based on the task\&quot;s configuration. Then, an LLM is used to evaluate the performance of these traces, and the evaluation results are recorded.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOnlineEvalTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOnlineEvalTaskResponse
        /// </returns>
        public CreateOnlineEvalTaskResponse CreateOnlineEvalTaskWithOptions(CreateOnlineEvalTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOnlineEvalTaskShrinkRequest request = new CreateOnlineEvalTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOnlineEvalTask",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOnlineEvalTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trace evaluation task. The system will sample some data from the user\&quot;s trace data based on the task\&quot;s configuration. Then, an LLM is used to evaluate the performance of these traces, and the evaluation results are recorded.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOnlineEvalTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOnlineEvalTaskResponse
        /// </returns>
        public async Task<CreateOnlineEvalTaskResponse> CreateOnlineEvalTaskWithOptionsAsync(CreateOnlineEvalTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOnlineEvalTaskShrinkRequest request = new CreateOnlineEvalTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOnlineEvalTask",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOnlineEvalTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trace evaluation task. The system will sample some data from the user\&quot;s trace data based on the task\&quot;s configuration. Then, an LLM is used to evaluate the performance of these traces, and the evaluation results are recorded.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOnlineEvalTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOnlineEvalTaskResponse
        /// </returns>
        public CreateOnlineEvalTaskResponse CreateOnlineEvalTask(CreateOnlineEvalTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOnlineEvalTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trace evaluation task. The system will sample some data from the user\&quot;s trace data based on the task\&quot;s configuration. Then, an LLM is used to evaluate the performance of these traces, and the evaluation results are recorded.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOnlineEvalTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOnlineEvalTaskResponse
        /// </returns>
        public async Task<CreateOnlineEvalTaskResponse> CreateOnlineEvalTaskAsync(CreateOnlineEvalTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOnlineEvalTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role required for the PaiLLMTrace service.</para>
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
        /// CreateServiceIdentityRoleResponse
        /// </returns>
        public CreateServiceIdentityRoleResponse CreateServiceIdentityRoleWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceIdentityRole",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/ServiceIdentityRole",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceIdentityRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role required for the PaiLLMTrace service.</para>
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
        /// CreateServiceIdentityRoleResponse
        /// </returns>
        public async Task<CreateServiceIdentityRoleResponse> CreateServiceIdentityRoleWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceIdentityRole",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/ServiceIdentityRole",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceIdentityRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role required for the PaiLLMTrace service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateServiceIdentityRoleResponse
        /// </returns>
        public CreateServiceIdentityRoleResponse CreateServiceIdentityRole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceIdentityRoleWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role required for the PaiLLMTrace service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateServiceIdentityRoleResponse
        /// </returns>
        public async Task<CreateServiceIdentityRoleResponse> CreateServiceIdentityRoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceIdentityRoleWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete an online evaluation task</para>
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
        /// DeleteOnlineEvalTaskResponse
        /// </returns>
        public DeleteOnlineEvalTaskResponse DeleteOnlineEvalTaskWithOptions(string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOnlineEvalTask",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOnlineEvalTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete an online evaluation task</para>
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
        /// DeleteOnlineEvalTaskResponse
        /// </returns>
        public async Task<DeleteOnlineEvalTaskResponse> DeleteOnlineEvalTaskWithOptionsAsync(string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOnlineEvalTask",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOnlineEvalTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete an online evaluation task</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteOnlineEvalTaskResponse
        /// </returns>
        public DeleteOnlineEvalTaskResponse DeleteOnlineEvalTask(string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteOnlineEvalTaskWithOptions(TaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete an online evaluation task</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteOnlineEvalTaskResponse
        /// </returns>
        public async Task<DeleteOnlineEvalTaskResponse> DeleteOnlineEvalTaskAsync(string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteOnlineEvalTaskWithOptionsAsync(TaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Evaluates a specified piece of trace data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvaluateTraceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EvaluateTraceResponse
        /// </returns>
        public EvaluateTraceResponse EvaluateTraceWithOptions(string TraceId, EvaluateTraceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationConfig))
            {
                body["EvaluationConfig"] = request.EvaluationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationId))
            {
                body["EvaluationId"] = request.EvaluationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTime))
            {
                body["MaxTime"] = request.MaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTime))
            {
                body["MinTime"] = request.MinTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                body["ModelConfig"] = request.ModelConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EvaluateTrace",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/eval/trace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TraceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluateTraceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Evaluates a specified piece of trace data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvaluateTraceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EvaluateTraceResponse
        /// </returns>
        public async Task<EvaluateTraceResponse> EvaluateTraceWithOptionsAsync(string TraceId, EvaluateTraceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationConfig))
            {
                body["EvaluationConfig"] = request.EvaluationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationId))
            {
                body["EvaluationId"] = request.EvaluationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTime))
            {
                body["MaxTime"] = request.MaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTime))
            {
                body["MinTime"] = request.MinTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                body["ModelConfig"] = request.ModelConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EvaluateTrace",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/eval/trace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TraceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluateTraceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Evaluates a specified piece of trace data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvaluateTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// EvaluateTraceResponse
        /// </returns>
        public EvaluateTraceResponse EvaluateTrace(string TraceId, EvaluateTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EvaluateTraceWithOptions(TraceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Evaluates a specified piece of trace data.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvaluateTraceRequest
        /// </param>
        /// 
        /// <returns>
        /// EvaluateTraceResponse
        /// </returns>
        public async Task<EvaluateTraceResponse> EvaluateTraceAsync(string TraceId, EvaluateTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EvaluateTraceWithOptionsAsync(TraceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the content of prompt templates used for evaluation</para>
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
        /// GetEvaluationTemplatesResponse
        /// </returns>
        public GetEvaluationTemplatesResponse GetEvaluationTemplatesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvaluationTemplates",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/eval/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEvaluationTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the content of prompt templates used for evaluation</para>
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
        /// GetEvaluationTemplatesResponse
        /// </returns>
        public async Task<GetEvaluationTemplatesResponse> GetEvaluationTemplatesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvaluationTemplates",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/eval/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEvaluationTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the content of prompt templates used for evaluation</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEvaluationTemplatesResponse
        /// </returns>
        public GetEvaluationTemplatesResponse GetEvaluationTemplates()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEvaluationTemplatesWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the content of prompt templates used for evaluation</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEvaluationTemplatesResponse
        /// </returns>
        public async Task<GetEvaluationTemplatesResponse> GetEvaluationTemplatesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEvaluationTemplatesWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the details of an online evaluation task</para>
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
        /// GetOnlineEvalTaskResponse
        /// </returns>
        public GetOnlineEvalTaskResponse GetOnlineEvalTaskWithOptions(string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOnlineEvalTask",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOnlineEvalTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the details of an online evaluation task</para>
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
        /// GetOnlineEvalTaskResponse
        /// </returns>
        public async Task<GetOnlineEvalTaskResponse> GetOnlineEvalTaskWithOptionsAsync(string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOnlineEvalTask",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOnlineEvalTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the details of an online evaluation task</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetOnlineEvalTaskResponse
        /// </returns>
        public GetOnlineEvalTaskResponse GetOnlineEvalTask(string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOnlineEvalTaskWithOptions(TaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the details of an online evaluation task</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetOnlineEvalTaskResponse
        /// </returns>
        public async Task<GetOnlineEvalTaskResponse> GetOnlineEvalTaskAsync(string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOnlineEvalTaskWithOptionsAsync(TaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information related to the service-linked role.</para>
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
        /// GetServiceIdentityRoleResponse
        /// </returns>
        public GetServiceIdentityRoleResponse GetServiceIdentityRoleWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceIdentityRole",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/ServiceIdentityRole",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceIdentityRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information related to the service-linked role.</para>
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
        /// GetServiceIdentityRoleResponse
        /// </returns>
        public async Task<GetServiceIdentityRoleResponse> GetServiceIdentityRoleWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceIdentityRole",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/ServiceIdentityRole",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceIdentityRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information related to the service-linked role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceIdentityRoleResponse
        /// </returns>
        public GetServiceIdentityRoleResponse GetServiceIdentityRole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceIdentityRoleWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information related to the service-linked role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceIdentityRoleResponse
        /// </returns>
        public async Task<GetServiceIdentityRoleResponse> GetServiceIdentityRoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceIdentityRoleWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token used in the Xtrace service and the endpoint required for uploading trace data.</para>
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
        /// GetXtraceTokenResponse
        /// </returns>
        public GetXtraceTokenResponse GetXtraceTokenWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetXtraceToken",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/XtraceToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetXtraceTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token used in the Xtrace service and the endpoint required for uploading trace data.</para>
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
        /// GetXtraceTokenResponse
        /// </returns>
        public async Task<GetXtraceTokenResponse> GetXtraceTokenWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetXtraceToken",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/XtraceToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetXtraceTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token used in the Xtrace service and the endpoint required for uploading trace data.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetXtraceTokenResponse
        /// </returns>
        public GetXtraceTokenResponse GetXtraceToken()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetXtraceTokenWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token used in the Xtrace service and the endpoint required for uploading trace data.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetXtraceTokenResponse
        /// </returns>
        public async Task<GetXtraceTokenResponse> GetXtraceTokenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetXtraceTokenWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of results for trace evaluation. This API is used together with EvaluateTrace. EvaluateTrace starts the evaluation. ListEvalResults obtains the results.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListEvalResultsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEvalResultsResponse
        /// </returns>
        public ListEvalResultsResponse ListEvalResultsWithOptions(ListEvalResultsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListEvalResultsShrinkRequest request = new ListEvalResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordIds))
            {
                request.RecordIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordIds, "RecordIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationId))
            {
                query["EvaluationId"] = request.EvaluationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordIdsShrink))
            {
                query["RecordIds"] = request.RecordIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEvalResults",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/eval/results",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvalResultsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of results for trace evaluation. This API is used together with EvaluateTrace. EvaluateTrace starts the evaluation. ListEvalResults obtains the results.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListEvalResultsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEvalResultsResponse
        /// </returns>
        public async Task<ListEvalResultsResponse> ListEvalResultsWithOptionsAsync(ListEvalResultsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListEvalResultsShrinkRequest request = new ListEvalResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordIds))
            {
                request.RecordIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordIds, "RecordIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationId))
            {
                query["EvaluationId"] = request.EvaluationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordIdsShrink))
            {
                query["RecordIds"] = request.RecordIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEvalResults",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/eval/results",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvalResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of results for trace evaluation. This API is used together with EvaluateTrace. EvaluateTrace starts the evaluation. ListEvalResults obtains the results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvalResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEvalResultsResponse
        /// </returns>
        public ListEvalResultsResponse ListEvalResults(ListEvalResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEvalResultsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of results for trace evaluation. This API is used together with EvaluateTrace. EvaluateTrace starts the evaluation. ListEvalResults obtains the results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvalResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEvalResultsResponse
        /// </returns>
        public async Task<ListEvalResultsResponse> ListEvalResultsAsync(ListEvalResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEvalResultsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List the results of online evaluation tasks that meet the criteria</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListOnlineEvalTaskResultsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineEvalTaskResultsResponse
        /// </returns>
        public ListOnlineEvalTaskResultsResponse ListOnlineEvalTaskResultsWithOptions(ListOnlineEvalTaskResultsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListOnlineEvalTaskResultsShrinkRequest request = new ListOnlineEvalTaskResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TraceIds))
            {
                request.TraceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TraceIds, "TraceIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationId))
            {
                query["EvaluationId"] = request.EvaluationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MostRecentResultsOnly))
            {
                query["MostRecentResultsOnly"] = request.MostRecentResultsOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIdsShrink))
            {
                query["TraceIds"] = request.TraceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOnlineEvalTaskResults",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltaskresults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOnlineEvalTaskResultsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List the results of online evaluation tasks that meet the criteria</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListOnlineEvalTaskResultsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineEvalTaskResultsResponse
        /// </returns>
        public async Task<ListOnlineEvalTaskResultsResponse> ListOnlineEvalTaskResultsWithOptionsAsync(ListOnlineEvalTaskResultsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListOnlineEvalTaskResultsShrinkRequest request = new ListOnlineEvalTaskResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TraceIds))
            {
                request.TraceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TraceIds, "TraceIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationId))
            {
                query["EvaluationId"] = request.EvaluationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MostRecentResultsOnly))
            {
                query["MostRecentResultsOnly"] = request.MostRecentResultsOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIdsShrink))
            {
                query["TraceIds"] = request.TraceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOnlineEvalTaskResults",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltaskresults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOnlineEvalTaskResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List the results of online evaluation tasks that meet the criteria</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOnlineEvalTaskResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineEvalTaskResultsResponse
        /// </returns>
        public ListOnlineEvalTaskResultsResponse ListOnlineEvalTaskResults(ListOnlineEvalTaskResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOnlineEvalTaskResultsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List the results of online evaluation tasks that meet the criteria</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOnlineEvalTaskResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineEvalTaskResultsResponse
        /// </returns>
        public async Task<ListOnlineEvalTaskResultsResponse> ListOnlineEvalTaskResultsAsync(ListOnlineEvalTaskResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOnlineEvalTaskResultsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>View online evaluation tasks that meet the criteria</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOnlineEvalTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineEvalTasksResponse
        /// </returns>
        public ListOnlineEvalTasksResponse ListOnlineEvalTasksWithOptions(ListOnlineEvalTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTime))
            {
                query["MaxTime"] = request.MaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTime))
            {
                query["MinTime"] = request.MinTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOnlineEvalTasks",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOnlineEvalTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>View online evaluation tasks that meet the criteria</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOnlineEvalTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineEvalTasksResponse
        /// </returns>
        public async Task<ListOnlineEvalTasksResponse> ListOnlineEvalTasksWithOptionsAsync(ListOnlineEvalTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTime))
            {
                query["MaxTime"] = request.MaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTime))
            {
                query["MinTime"] = request.MinTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOnlineEvalTasks",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOnlineEvalTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>View online evaluation tasks that meet the criteria</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOnlineEvalTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineEvalTasksResponse
        /// </returns>
        public ListOnlineEvalTasksResponse ListOnlineEvalTasks(ListOnlineEvalTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOnlineEvalTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>View online evaluation tasks that meet the criteria</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOnlineEvalTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineEvalTasksResponse
        /// </returns>
        public async Task<ListOnlineEvalTasksResponse> ListOnlineEvalTasksAsync(ListOnlineEvalTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOnlineEvalTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of trace data based on specified criteria.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTracesDatasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTracesDatasResponse
        /// </returns>
        public ListTracesDatasResponse ListTracesDatasWithOptions(ListTracesDatasRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTracesDatasShrinkRequest request = new ListTracesDatasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filters))
            {
                request.FiltersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filters, "Filters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SpanIds))
            {
                request.SpanIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SpanIds, "SpanIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TraceIds))
            {
                request.TraceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TraceIds, "TraceIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FiltersShrink))
            {
                query["Filters"] = request.FiltersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasEvents))
            {
                query["HasEvents"] = request.HasEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasStatusMessage))
            {
                query["HasStatusMessage"] = request.HasStatusMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmAppName))
            {
                query["LlmAppName"] = request.LlmAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDuration))
            {
                query["MaxDuration"] = request.MaxDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTime))
            {
                query["MaxTime"] = request.MaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDuration))
            {
                query["MinDuration"] = request.MinDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTime))
            {
                query["MinTime"] = request.MinTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpentelemetryCompatible))
            {
                query["OpentelemetryCompatible"] = request.OpentelemetryCompatible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerSubId))
            {
                query["OwnerSubId"] = request.OwnerSubId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpanIdsShrink))
            {
                query["SpanIds"] = request.SpanIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpanName))
            {
                query["SpanName"] = request.SpanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIdsShrink))
            {
                query["TraceIds"] = request.TraceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceReduceMethod))
            {
                query["TraceReduceMethod"] = request.TraceReduceMethod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTracesDatas",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/TracesDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTracesDatasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of trace data based on specified criteria.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTracesDatasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTracesDatasResponse
        /// </returns>
        public async Task<ListTracesDatasResponse> ListTracesDatasWithOptionsAsync(ListTracesDatasRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTracesDatasShrinkRequest request = new ListTracesDatasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filters))
            {
                request.FiltersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filters, "Filters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SpanIds))
            {
                request.SpanIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SpanIds, "SpanIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TraceIds))
            {
                request.TraceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TraceIds, "TraceIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FiltersShrink))
            {
                query["Filters"] = request.FiltersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasEvents))
            {
                query["HasEvents"] = request.HasEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasStatusMessage))
            {
                query["HasStatusMessage"] = request.HasStatusMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmAppName))
            {
                query["LlmAppName"] = request.LlmAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDuration))
            {
                query["MaxDuration"] = request.MaxDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTime))
            {
                query["MaxTime"] = request.MaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDuration))
            {
                query["MinDuration"] = request.MinDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTime))
            {
                query["MinTime"] = request.MinTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpentelemetryCompatible))
            {
                query["OpentelemetryCompatible"] = request.OpentelemetryCompatible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerSubId))
            {
                query["OwnerSubId"] = request.OwnerSubId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpanIdsShrink))
            {
                query["SpanIds"] = request.SpanIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpanName))
            {
                query["SpanName"] = request.SpanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIdsShrink))
            {
                query["TraceIds"] = request.TraceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceReduceMethod))
            {
                query["TraceReduceMethod"] = request.TraceReduceMethod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTracesDatas",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/TracesDatas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTracesDatasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of trace data based on specified criteria.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTracesDatasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTracesDatasResponse
        /// </returns>
        public ListTracesDatasResponse ListTracesDatas(ListTracesDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTracesDatasWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of trace data based on specified criteria.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTracesDatasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTracesDatasResponse
        /// </returns>
        public async Task<ListTracesDatasResponse> ListTracesDatasAsync(ListTracesDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTracesDatasWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stop the execution of an online evaluation task</para>
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
        /// StopOnlineEvalTaskResponse
        /// </returns>
        public StopOnlineEvalTaskResponse StopOnlineEvalTaskWithOptions(string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopOnlineEvalTask",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopOnlineEvalTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stop the execution of an online evaluation task</para>
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
        /// StopOnlineEvalTaskResponse
        /// </returns>
        public async Task<StopOnlineEvalTaskResponse> StopOnlineEvalTaskWithOptionsAsync(string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopOnlineEvalTask",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopOnlineEvalTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stop the execution of an online evaluation task</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopOnlineEvalTaskResponse
        /// </returns>
        public StopOnlineEvalTaskResponse StopOnlineEvalTask(string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopOnlineEvalTaskWithOptions(TaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stop the execution of an online evaluation task</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopOnlineEvalTaskResponse
        /// </returns>
        public async Task<StopOnlineEvalTaskResponse> StopOnlineEvalTaskAsync(string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopOnlineEvalTaskWithOptionsAsync(TaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the configuration of a trace evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOnlineEvalTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOnlineEvalTaskResponse
        /// </returns>
        public UpdateOnlineEvalTaskResponse UpdateOnlineEvalTaskWithOptions(string TaskId, UpdateOnlineEvalTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationConfig))
            {
                body["EvaluationConfig"] = request.EvaluationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                body["ModelConfig"] = request.ModelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingFrequencyMinutes))
            {
                body["SamplingFrequencyMinutes"] = request.SamplingFrequencyMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRatio))
            {
                body["SamplingRatio"] = request.SamplingRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOnlineEvalTask",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOnlineEvalTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the configuration of a trace evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOnlineEvalTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOnlineEvalTaskResponse
        /// </returns>
        public async Task<UpdateOnlineEvalTaskResponse> UpdateOnlineEvalTaskWithOptionsAsync(string TaskId, UpdateOnlineEvalTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationConfig))
            {
                body["EvaluationConfig"] = request.EvaluationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                body["ModelConfig"] = request.ModelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingFrequencyMinutes))
            {
                body["SamplingFrequencyMinutes"] = request.SamplingFrequencyMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRatio))
            {
                body["SamplingRatio"] = request.SamplingRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOnlineEvalTask",
                Version = "2024-03-11",
                Protocol = "HTTPS",
                Pathname = "/api/v1/PAILLMTrace/onlineevaltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOnlineEvalTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the configuration of a trace evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOnlineEvalTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOnlineEvalTaskResponse
        /// </returns>
        public UpdateOnlineEvalTaskResponse UpdateOnlineEvalTask(string TaskId, UpdateOnlineEvalTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateOnlineEvalTaskWithOptions(TaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the configuration of a trace evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOnlineEvalTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOnlineEvalTaskResponse
        /// </returns>
        public async Task<UpdateOnlineEvalTaskResponse> UpdateOnlineEvalTaskAsync(string TaskId, UpdateOnlineEvalTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateOnlineEvalTaskWithOptionsAsync(TaskId, request, headers, runtime);
        }

    }
}
