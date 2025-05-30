// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AIPodcast20250228.Models;

namespace AlibabaCloud.SDK.AIPodcast20250228
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aipodcast", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>ai播客生成任务结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PodcastTaskResultQueryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PodcastTaskResultQueryResponse
        /// </returns>
        public PodcastTaskResultQueryResponse PodcastTaskResultQueryWithOptions(PodcastTaskResultQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PodcastTaskResultQuery",
                Version = "2025-02-28",
                Protocol = "HTTPS",
                Pathname = "/podcast/task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PodcastTaskResultQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai播客生成任务结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PodcastTaskResultQueryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PodcastTaskResultQueryResponse
        /// </returns>
        public async Task<PodcastTaskResultQueryResponse> PodcastTaskResultQueryWithOptionsAsync(PodcastTaskResultQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PodcastTaskResultQuery",
                Version = "2025-02-28",
                Protocol = "HTTPS",
                Pathname = "/podcast/task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PodcastTaskResultQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai播客生成任务结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PodcastTaskResultQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// PodcastTaskResultQueryResponse
        /// </returns>
        public PodcastTaskResultQueryResponse PodcastTaskResultQuery(PodcastTaskResultQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PodcastTaskResultQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai播客生成任务结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PodcastTaskResultQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// PodcastTaskResultQueryResponse
        /// </returns>
        public async Task<PodcastTaskResultQueryResponse> PodcastTaskResultQueryAsync(PodcastTaskResultQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PodcastTaskResultQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai播客生成任务提交</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PodcastTaskSubmitRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PodcastTaskSubmitResponse
        /// </returns>
        public PodcastTaskSubmitResponse PodcastTaskSubmitWithOptions(PodcastTaskSubmitRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PodcastTaskSubmitShrinkRequest request = new PodcastTaskSubmitShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileUrls))
            {
                request.FileUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileUrls, "fileUrls", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Voices))
            {
                request.VoicesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Voices, "voices", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Counts))
            {
                body["counts"] = request.Counts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlsShrink))
            {
                body["fileUrls"] = request.FileUrlsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoicesShrink))
            {
                body["voices"] = request.VoicesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PodcastTaskSubmit",
                Version = "2025-02-28",
                Protocol = "HTTPS",
                Pathname = "/podcast/task/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PodcastTaskSubmitResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai播客生成任务提交</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PodcastTaskSubmitRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PodcastTaskSubmitResponse
        /// </returns>
        public async Task<PodcastTaskSubmitResponse> PodcastTaskSubmitWithOptionsAsync(PodcastTaskSubmitRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PodcastTaskSubmitShrinkRequest request = new PodcastTaskSubmitShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileUrls))
            {
                request.FileUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileUrls, "fileUrls", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Voices))
            {
                request.VoicesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Voices, "voices", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Counts))
            {
                body["counts"] = request.Counts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlsShrink))
            {
                body["fileUrls"] = request.FileUrlsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoicesShrink))
            {
                body["voices"] = request.VoicesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PodcastTaskSubmit",
                Version = "2025-02-28",
                Protocol = "HTTPS",
                Pathname = "/podcast/task/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PodcastTaskSubmitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai播客生成任务提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PodcastTaskSubmitRequest
        /// </param>
        /// 
        /// <returns>
        /// PodcastTaskSubmitResponse
        /// </returns>
        public PodcastTaskSubmitResponse PodcastTaskSubmit(PodcastTaskSubmitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PodcastTaskSubmitWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai播客生成任务提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PodcastTaskSubmitRequest
        /// </param>
        /// 
        /// <returns>
        /// PodcastTaskSubmitResponse
        /// </returns>
        public async Task<PodcastTaskSubmitResponse> PodcastTaskSubmitAsync(PodcastTaskSubmitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PodcastTaskSubmitWithOptionsAsync(request, headers, runtime);
        }

    }
}
