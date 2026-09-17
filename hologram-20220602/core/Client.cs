// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Hologram20220602.Models;

namespace AlibabaCloud.SDK.Hologram20220602
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("hologram", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>用于创建一个新的Agent会话并返回会话ID。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于创建一个新的 Agent 会话。</description></item>
        /// <item><description>通过 <c>_meta.agent.agentName</c> 指定绑定的 Agent 名称，这是必填项。</description></item>
        /// <item><description>可以通过 <c>_meta.config.sessionSource</c> 透传会话来源标识，便于后续按来源检索。</description></item>
        /// <item><description>支持通过 <c>_meta.config.sessionTags[].sessionTagCode</c> 传入会话标签。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSessionResponse
        /// </returns>
        public CreateAgentSessionResponse CreateAgentSessionWithOptions(CreateAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentSessionShrinkRequest request = new CreateAgentSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                body["Jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                body["Params"] = request.ParamsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentSession",
                Version = "2022-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建一个新的Agent会话并返回会话ID。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于创建一个新的 Agent 会话。</description></item>
        /// <item><description>通过 <c>_meta.agent.agentName</c> 指定绑定的 Agent 名称，这是必填项。</description></item>
        /// <item><description>可以通过 <c>_meta.config.sessionSource</c> 透传会话来源标识，便于后续按来源检索。</description></item>
        /// <item><description>支持通过 <c>_meta.config.sessionTags[].sessionTagCode</c> 传入会话标签。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSessionResponse
        /// </returns>
        public async Task<CreateAgentSessionResponse> CreateAgentSessionWithOptionsAsync(CreateAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentSessionShrinkRequest request = new CreateAgentSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                body["Jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                body["Params"] = request.ParamsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentSession",
                Version = "2022-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建一个新的Agent会话并返回会话ID。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于创建一个新的 Agent 会话。</description></item>
        /// <item><description>通过 <c>_meta.agent.agentName</c> 指定绑定的 Agent 名称，这是必填项。</description></item>
        /// <item><description>可以通过 <c>_meta.config.sessionSource</c> 透传会话来源标识，便于后续按来源检索。</description></item>
        /// <item><description>支持通过 <c>_meta.config.sessionTags[].sessionTagCode</c> 传入会话标签。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSessionResponse
        /// </returns>
        public CreateAgentSessionResponse CreateAgentSession(CreateAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgentSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于创建一个新的Agent会话并返回会话ID。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于创建一个新的 Agent 会话。</description></item>
        /// <item><description>通过 <c>_meta.agent.agentName</c> 指定绑定的 Agent 名称，这是必填项。</description></item>
        /// <item><description>可以通过 <c>_meta.config.sessionSource</c> 透传会话来源标识，便于后续按来源检索。</description></item>
        /// <item><description>支持通过 <c>_meta.config.sessionTags[].sessionTagCode</c> 传入会话标签。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSessionResponse
        /// </returns>
        public async Task<CreateAgentSessionResponse> CreateAgentSessionAsync(CreateAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgentSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向指定会话发送用户Prompt，并以SSE方式流式接收Agent响应。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于向指定的会话 ID 发送用户的 Prompt，并以 SSE（Server-Sent Events）流式方式接收来自 Agent 的响应。</description></item>
        /// <item><description>响应可能包括消息分片、思考过程、工具调用状态更新等信息。</description></item>
        /// <item><description>如果指定的会话不存在，将通过 SSE 错误帧返回 400 错误。</description></item>
        /// <item><description><c>stopReason</c>字段指示了 Agent 停止本轮对话的原因。</description></item>
        /// <item><description>可选地提供额外元信息<c>Meta</c>来传递更多上下文给服务端。</description></item>
        /// <item><description>返回的内容符合开源协议 Agent Client Protocol (ACP) 的规范。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PromptAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PromptAgentSessionResponse
        /// </returns>
        public PromptAgentSessionResponse PromptAgentSessionWithOptions(PromptAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PromptAgentSessionShrinkRequest request = new PromptAgentSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerContext))
            {
                body["Caller-Context"] = request.CallerContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                body["Jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                body["Params"] = request.ParamsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PromptAgentSession",
                Version = "2022-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PromptAgentSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向指定会话发送用户Prompt，并以SSE方式流式接收Agent响应。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于向指定的会话 ID 发送用户的 Prompt，并以 SSE（Server-Sent Events）流式方式接收来自 Agent 的响应。</description></item>
        /// <item><description>响应可能包括消息分片、思考过程、工具调用状态更新等信息。</description></item>
        /// <item><description>如果指定的会话不存在，将通过 SSE 错误帧返回 400 错误。</description></item>
        /// <item><description><c>stopReason</c>字段指示了 Agent 停止本轮对话的原因。</description></item>
        /// <item><description>可选地提供额外元信息<c>Meta</c>来传递更多上下文给服务端。</description></item>
        /// <item><description>返回的内容符合开源协议 Agent Client Protocol (ACP) 的规范。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PromptAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PromptAgentSessionResponse
        /// </returns>
        public async Task<PromptAgentSessionResponse> PromptAgentSessionWithOptionsAsync(PromptAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PromptAgentSessionShrinkRequest request = new PromptAgentSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerContext))
            {
                body["Caller-Context"] = request.CallerContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                body["Jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                body["Params"] = request.ParamsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PromptAgentSession",
                Version = "2022-06-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PromptAgentSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向指定会话发送用户Prompt，并以SSE方式流式接收Agent响应。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于向指定的会话 ID 发送用户的 Prompt，并以 SSE（Server-Sent Events）流式方式接收来自 Agent 的响应。</description></item>
        /// <item><description>响应可能包括消息分片、思考过程、工具调用状态更新等信息。</description></item>
        /// <item><description>如果指定的会话不存在，将通过 SSE 错误帧返回 400 错误。</description></item>
        /// <item><description><c>stopReason</c>字段指示了 Agent 停止本轮对话的原因。</description></item>
        /// <item><description>可选地提供额外元信息<c>Meta</c>来传递更多上下文给服务端。</description></item>
        /// <item><description>返回的内容符合开源协议 Agent Client Protocol (ACP) 的规范。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PromptAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// PromptAgentSessionResponse
        /// </returns>
        public PromptAgentSessionResponse PromptAgentSession(PromptAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PromptAgentSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向指定会话发送用户Prompt，并以SSE方式流式接收Agent响应。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该 API 用于向指定的会话 ID 发送用户的 Prompt，并以 SSE（Server-Sent Events）流式方式接收来自 Agent 的响应。</description></item>
        /// <item><description>响应可能包括消息分片、思考过程、工具调用状态更新等信息。</description></item>
        /// <item><description>如果指定的会话不存在，将通过 SSE 错误帧返回 400 错误。</description></item>
        /// <item><description><c>stopReason</c>字段指示了 Agent 停止本轮对话的原因。</description></item>
        /// <item><description>可选地提供额外元信息<c>Meta</c>来传递更多上下文给服务端。</description></item>
        /// <item><description>返回的内容符合开源协议 Agent Client Protocol (ACP) 的规范。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PromptAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// PromptAgentSessionResponse
        /// </returns>
        public async Task<PromptAgentSessionResponse> PromptAgentSessionAsync(PromptAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PromptAgentSessionWithOptionsAsync(request, runtime);
        }

    }
}
