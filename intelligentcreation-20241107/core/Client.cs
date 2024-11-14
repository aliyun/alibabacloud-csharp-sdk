// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.IntelligentCreation20241107.Models;

namespace AlibabaCloud.SDK.IntelligentCreation20241107
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("intelligentcreation", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建模型标注任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLabelTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLabelTaskResponse
        /// </returns>
        public CreateLabelTaskResponse CreateLabelTaskWithOptions(CreateLabelTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                body["idempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTemplateId))
            {
                body["labelTemplateId"] = request.LabelTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLabelTask",
                Version = "2024-11-07",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aitag/createLabelTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLabelTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型标注任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLabelTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLabelTaskResponse
        /// </returns>
        public async Task<CreateLabelTaskResponse> CreateLabelTaskWithOptionsAsync(CreateLabelTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                body["idempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTemplateId))
            {
                body["labelTemplateId"] = request.LabelTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLabelTask",
                Version = "2024-11-07",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aitag/createLabelTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLabelTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型标注任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLabelTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLabelTaskResponse
        /// </returns>
        public CreateLabelTaskResponse CreateLabelTask(CreateLabelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLabelTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型标注任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLabelTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLabelTaskResponse
        /// </returns>
        public async Task<CreateLabelTaskResponse> CreateLabelTaskAsync(CreateLabelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLabelTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型标注任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLabelTaskResultResponse
        /// </returns>
        public GetLabelTaskResultResponse GetLabelTaskResultWithOptions(GetLabelTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLabelTaskResult",
                Version = "2024-11-07",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aitag/getLabelTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLabelTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型标注任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLabelTaskResultResponse
        /// </returns>
        public async Task<GetLabelTaskResultResponse> GetLabelTaskResultWithOptionsAsync(GetLabelTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLabelTaskResult",
                Version = "2024-11-07",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aitag/getLabelTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLabelTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型标注任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLabelTaskResultResponse
        /// </returns>
        public GetLabelTaskResultResponse GetLabelTaskResult(GetLabelTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLabelTaskResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型标注任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLabelTaskResultResponse
        /// </returns>
        public async Task<GetLabelTaskResultResponse> GetLabelTaskResultAsync(GetLabelTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLabelTaskResultWithOptionsAsync(request, headers, runtime);
        }

    }
}
