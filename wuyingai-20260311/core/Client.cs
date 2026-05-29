// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.WuyingAI20260311.Models;

namespace AlibabaCloud.SDK.WuyingAI20260311
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("wuyingai", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>与 JVS Crew 进行流式对话，采用 Server-Sent Events (SSE) 协议实时推送对话内容。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ChatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatResponse
        /// </returns>
        public ChatResponse ChatWithOptions(ChatRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ChatShrinkRequest request = new ChatShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Settings))
            {
                request.SettingsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Settings, "Settings", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamOptions))
            {
                request.StreamOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamOptions, "StreamOptions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorization))
            {
                query["Authorization"] = request.Authorization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUserId))
            {
                body["ExternalUserId"] = request.ExternalUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoutingKey))
            {
                body["RoutingKey"] = request.RoutingKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingsShrink))
            {
                body["Settings"] = request.SettingsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamOptionsShrink))
            {
                body["StreamOptions"] = request.StreamOptionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Chat",
                Version = "2026-03-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>与 JVS Crew 进行流式对话，采用 Server-Sent Events (SSE) 协议实时推送对话内容。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ChatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatResponse
        /// </returns>
        public async Task<ChatResponse> ChatWithOptionsAsync(ChatRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ChatShrinkRequest request = new ChatShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Settings))
            {
                request.SettingsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Settings, "Settings", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamOptions))
            {
                request.StreamOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamOptions, "StreamOptions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorization))
            {
                query["Authorization"] = request.Authorization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUserId))
            {
                body["ExternalUserId"] = request.ExternalUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoutingKey))
            {
                body["RoutingKey"] = request.RoutingKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingsShrink))
            {
                body["Settings"] = request.SettingsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamOptionsShrink))
            {
                body["StreamOptions"] = request.StreamOptionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Chat",
                Version = "2026-03-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>与 JVS Crew 进行流式对话，采用 Server-Sent Events (SSE) 协议实时推送对话内容。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatResponse
        /// </returns>
        public ChatResponse Chat(ChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>与 JVS Crew 进行流式对话，采用 Server-Sent Events (SSE) 协议实时推送对话内容。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatResponse
        /// </returns>
        public async Task<ChatResponse> ChatAsync(ChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户进行对话所需的访问令牌（AccessToken），用于后续调用 Chat 接口进行身份验证。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public GetAccessTokenResponse GetAccessTokenWithOptions(GetAccessTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUserId))
            {
                query["ExternalUserId"] = request.ExternalUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessToken",
                Version = "2026-03-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户进行对话所需的访问令牌（AccessToken），用于后续调用 Chat 接口进行身份验证。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public async Task<GetAccessTokenResponse> GetAccessTokenWithOptionsAsync(GetAccessTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUserId))
            {
                query["ExternalUserId"] = request.ExternalUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessToken",
                Version = "2026-03-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户进行对话所需的访问令牌（AccessToken），用于后续调用 Chat 接口进行身份验证。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户进行对话所需的访问令牌（AccessToken），用于后续调用 Chat 接口进行身份验证。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public async Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessTokenWithOptionsAsync(request, runtime);
        }

    }
}
