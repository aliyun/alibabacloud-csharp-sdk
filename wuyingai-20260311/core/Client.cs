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
            this._endpointRule = "regional";
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
        /// <para>Conducts a streaming conversation with JVS Crew, using the Server-Sent Events (SSE) protocol to push conversation content in real time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Features</em>*</para>
        /// <list type="bullet">
        /// <item><description>Real-time streaming response that reduces time to first token.</description></item>
        /// <item><description>Supports multimodal input (text, images, and files).</description></item>
        /// <item><description>Session persistence for multi-turn conversations.</description></item>
        /// <item><description>Event-driven architecture for precise message status control.
        /// <b>Request information</b></description></item>
        /// <item><description><b>Request method</b>: <c>POST</c></description></item>
        /// <item><description><b>Content-Type</b>: <c>application/json</c></description></item>
        /// <item><description><b>Response Content-Type</b>: <c>text/event-stream</c>.</description></item>
        /// </list>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resume))
            {
                body["Resume"] = request.Resume;
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
        /// <para>Conducts a streaming conversation with JVS Crew, using the Server-Sent Events (SSE) protocol to push conversation content in real time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Features</em>*</para>
        /// <list type="bullet">
        /// <item><description>Real-time streaming response that reduces time to first token.</description></item>
        /// <item><description>Supports multimodal input (text, images, and files).</description></item>
        /// <item><description>Session persistence for multi-turn conversations.</description></item>
        /// <item><description>Event-driven architecture for precise message status control.
        /// <b>Request information</b></description></item>
        /// <item><description><b>Request method</b>: <c>POST</c></description></item>
        /// <item><description><b>Content-Type</b>: <c>application/json</c></description></item>
        /// <item><description><b>Response Content-Type</b>: <c>text/event-stream</c>.</description></item>
        /// </list>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resume))
            {
                body["Resume"] = request.Resume;
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
        /// <para>Conducts a streaming conversation with JVS Crew, using the Server-Sent Events (SSE) protocol to push conversation content in real time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Features</em>*</para>
        /// <list type="bullet">
        /// <item><description>Real-time streaming response that reduces time to first token.</description></item>
        /// <item><description>Supports multimodal input (text, images, and files).</description></item>
        /// <item><description>Session persistence for multi-turn conversations.</description></item>
        /// <item><description>Event-driven architecture for precise message status control.
        /// <b>Request information</b></description></item>
        /// <item><description><b>Request method</b>: <c>POST</c></description></item>
        /// <item><description><b>Content-Type</b>: <c>application/json</c></description></item>
        /// <item><description><b>Response Content-Type</b>: <c>text/event-stream</c>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Conducts a streaming conversation with JVS Crew, using the Server-Sent Events (SSE) protocol to push conversation content in real time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Features</em>*</para>
        /// <list type="bullet">
        /// <item><description>Real-time streaming response that reduces time to first token.</description></item>
        /// <item><description>Supports multimodal input (text, images, and files).</description></item>
        /// <item><description>Session persistence for multi-turn conversations.</description></item>
        /// <item><description>Event-driven architecture for precise message status control.
        /// <b>Request information</b></description></item>
        /// <item><description><b>Request method</b>: <c>POST</c></description></item>
        /// <item><description><b>Content-Type</b>: <c>application/json</c></description></item>
        /// <item><description><b>Response Content-Type</b>: <c>text/event-stream</c>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Obtains an access token (AccessToken) for user conversations, which is used to authenticate when invoking the Chat operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Token format</em>*: The AccessToken is a <b>JWT</b> consisting of <b>Header.Payload.Signature</b> segments, each Base64URL-encoded and concatenated with <c>.</c> into a single line. The examples in the following table are masked for illustration purposes. The actual RequestId and JWT segments are longer.
        /// <b>Token validity</b>: The AccessToken <b>is valid for a limited period of time</b>. After it expires, call this operation again to obtain a new token.
        /// <b>Authentication method</b>: POP V1 signature (AK/SK)
        /// <b>Action</b>: <c>GetAccessToken</c>.</para>
        /// </description>
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
        /// <para>Obtains an access token (AccessToken) for user conversations, which is used to authenticate when invoking the Chat operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Token format</em>*: The AccessToken is a <b>JWT</b> consisting of <b>Header.Payload.Signature</b> segments, each Base64URL-encoded and concatenated with <c>.</c> into a single line. The examples in the following table are masked for illustration purposes. The actual RequestId and JWT segments are longer.
        /// <b>Token validity</b>: The AccessToken <b>is valid for a limited period of time</b>. After it expires, call this operation again to obtain a new token.
        /// <b>Authentication method</b>: POP V1 signature (AK/SK)
        /// <b>Action</b>: <c>GetAccessToken</c>.</para>
        /// </description>
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
        /// <para>Obtains an access token (AccessToken) for user conversations, which is used to authenticate when invoking the Chat operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Token format</em>*: The AccessToken is a <b>JWT</b> consisting of <b>Header.Payload.Signature</b> segments, each Base64URL-encoded and concatenated with <c>.</c> into a single line. The examples in the following table are masked for illustration purposes. The actual RequestId and JWT segments are longer.
        /// <b>Token validity</b>: The AccessToken <b>is valid for a limited period of time</b>. After it expires, call this operation again to obtain a new token.
        /// <b>Authentication method</b>: POP V1 signature (AK/SK)
        /// <b>Action</b>: <c>GetAccessToken</c>.</para>
        /// </description>
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
        /// <para>Obtains an access token (AccessToken) for user conversations, which is used to authenticate when invoking the Chat operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Token format</em>*: The AccessToken is a <b>JWT</b> consisting of <b>Header.Payload.Signature</b> segments, each Base64URL-encoded and concatenated with <c>.</c> into a single line. The examples in the following table are masked for illustration purposes. The actual RequestId and JWT segments are longer.
        /// <b>Token validity</b>: The AccessToken <b>is valid for a limited period of time</b>. After it expires, call this operation again to obtain a new token.
        /// <b>Authentication method</b>: POP V1 signature (AK/SK)
        /// <b>Action</b>: <c>GetAccessToken</c>.</para>
        /// </description>
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
