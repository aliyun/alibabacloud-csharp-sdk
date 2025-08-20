// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.LingMou20250527.Models;

namespace AlibabaCloud.SDK.LingMou20250527
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("lingmou", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>关闭会话实例session</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CloseChatInstanceSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseChatInstanceSessionsResponse
        /// </returns>
        public CloseChatInstanceSessionsResponse CloseChatInstanceSessionsWithOptions(string instanceId, CloseChatInstanceSessionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CloseChatInstanceSessionsShrinkRequest request = new CloseChatInstanceSessionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionIds))
            {
                request.SessionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionIds, "sessionIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIdsShrink))
            {
                body["sessionIds"] = request.SessionIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseChatInstanceSessions",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sessions/close",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseChatInstanceSessionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭会话实例session</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CloseChatInstanceSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseChatInstanceSessionsResponse
        /// </returns>
        public async Task<CloseChatInstanceSessionsResponse> CloseChatInstanceSessionsWithOptionsAsync(string instanceId, CloseChatInstanceSessionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CloseChatInstanceSessionsShrinkRequest request = new CloseChatInstanceSessionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionIds))
            {
                request.SessionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionIds, "sessionIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIdsShrink))
            {
                body["sessionIds"] = request.SessionIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseChatInstanceSessions",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sessions/close",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseChatInstanceSessionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭会话实例session</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseChatInstanceSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseChatInstanceSessionsResponse
        /// </returns>
        public CloseChatInstanceSessionsResponse CloseChatInstanceSessions(string instanceId, CloseChatInstanceSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloseChatInstanceSessionsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭会话实例session</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseChatInstanceSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseChatInstanceSessionsResponse
        /// </returns>
        public async Task<CloseChatInstanceSessionsResponse> CloseChatInstanceSessionsAsync(string instanceId, CloseChatInstanceSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloseChatInstanceSessionsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字人会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatSessionResponse
        /// </returns>
        public CreateChatSessionResponse CreateChatSessionWithOptions(string id, CreateChatSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.License))
            {
                query["license"] = request.License;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatSession",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/init/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字人会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatSessionResponse
        /// </returns>
        public async Task<CreateChatSessionResponse> CreateChatSessionWithOptionsAsync(string id, CreateChatSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.License))
            {
                query["license"] = request.License;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatSession",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/init/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字人会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatSessionResponse
        /// </returns>
        public CreateChatSessionResponse CreateChatSession(string id, CreateChatSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateChatSessionWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字人会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatSessionResponse
        /// </returns>
        public async Task<CreateChatSessionResponse> CreateChatSessionAsync(string id, CreateChatSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateChatSessionWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话实例session</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryChatInstanceSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChatInstanceSessionsResponse
        /// </returns>
        public QueryChatInstanceSessionsResponse QueryChatInstanceSessionsWithOptions(string instanceId, QueryChatInstanceSessionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryChatInstanceSessionsShrinkRequest request = new QueryChatInstanceSessionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionIds))
            {
                request.SessionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionIds, "sessionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIdsShrink))
            {
                query["sessionIds"] = request.SessionIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChatInstanceSessions",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sessions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChatInstanceSessionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话实例session</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryChatInstanceSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChatInstanceSessionsResponse
        /// </returns>
        public async Task<QueryChatInstanceSessionsResponse> QueryChatInstanceSessionsWithOptionsAsync(string instanceId, QueryChatInstanceSessionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryChatInstanceSessionsShrinkRequest request = new QueryChatInstanceSessionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionIds))
            {
                request.SessionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionIds, "sessionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIdsShrink))
            {
                query["sessionIds"] = request.SessionIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChatInstanceSessions",
                Version = "2025-05-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/chat/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sessions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChatInstanceSessionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话实例session</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChatInstanceSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChatInstanceSessionsResponse
        /// </returns>
        public QueryChatInstanceSessionsResponse QueryChatInstanceSessions(string instanceId, QueryChatInstanceSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryChatInstanceSessionsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话实例session</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChatInstanceSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChatInstanceSessionsResponse
        /// </returns>
        public async Task<QueryChatInstanceSessionsResponse> QueryChatInstanceSessionsAsync(string instanceId, QueryChatInstanceSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryChatInstanceSessionsWithOptionsAsync(instanceId, request, headers, runtime);
        }

    }
}
