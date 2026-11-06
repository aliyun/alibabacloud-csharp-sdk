// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ada20260701.Models;

namespace AlibabaCloud.SDK.Ada20260701
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "Ada";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ada", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Stops the execution of a session or cancels a specified turn.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If Params._meta.promptId is provided, only that turn is canceled. If omitted, the current execution of the session is canceled. To avoid affecting other turns, use the actual promptId obtained from the response stream instead of the request Id.
        /// A cancellation receipt does not mean the turn has ended, nor does it revoke external operations that have already occurred. After calling this operation, continue reading the original response stream or resume reading through LoadAgentSession to confirm the desired state of the target turn. Disconnecting the stream connection cannot replace a cancellation request.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CancelAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAgentSessionResponse
        /// </returns>
        public CancelAgentSessionResponse CancelAgentSessionWithOptions(CancelAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CancelAgentSessionShrinkRequest request = new CancelAgentSessionShrinkRequest();
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
                Action = "CancelAgentSession",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAgentSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the execution of a session or cancels a specified turn.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If Params._meta.promptId is provided, only that turn is canceled. If omitted, the current execution of the session is canceled. To avoid affecting other turns, use the actual promptId obtained from the response stream instead of the request Id.
        /// A cancellation receipt does not mean the turn has ended, nor does it revoke external operations that have already occurred. After calling this operation, continue reading the original response stream or resume reading through LoadAgentSession to confirm the desired state of the target turn. Disconnecting the stream connection cannot replace a cancellation request.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CancelAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAgentSessionResponse
        /// </returns>
        public async Task<CancelAgentSessionResponse> CancelAgentSessionWithOptionsAsync(CancelAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CancelAgentSessionShrinkRequest request = new CancelAgentSessionShrinkRequest();
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
                Action = "CancelAgentSession",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAgentSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the execution of a session or cancels a specified turn.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If Params._meta.promptId is provided, only that turn is canceled. If omitted, the current execution of the session is canceled. To avoid affecting other turns, use the actual promptId obtained from the response stream instead of the request Id.
        /// A cancellation receipt does not mean the turn has ended, nor does it revoke external operations that have already occurred. After calling this operation, continue reading the original response stream or resume reading through LoadAgentSession to confirm the desired state of the target turn. Disconnecting the stream connection cannot replace a cancellation request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAgentSessionResponse
        /// </returns>
        public CancelAgentSessionResponse CancelAgentSession(CancelAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAgentSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the execution of a session or cancels a specified turn.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If Params._meta.promptId is provided, only that turn is canceled. If omitted, the current execution of the session is canceled. To avoid affecting other turns, use the actual promptId obtained from the response stream instead of the request Id.
        /// A cancellation receipt does not mean the turn has ended, nor does it revoke external operations that have already occurred. After calling this operation, continue reading the original response stream or resume reading through LoadAgentSession to confirm the desired state of the target turn. Disconnecting the stream connection cannot replace a cancellation request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAgentSessionResponse
        /// </returns>
        public async Task<CancelAgentSessionResponse> CancelAgentSessionAsync(CancelAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAgentSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is the unique identifier of the agent within the current tenant. It can contain only letters, digits, underscores (_), and hyphens (-), and must be 1 to 128 characters in length. It cannot be modified after creation.</description></item>
        /// <item><description>Each agent can be bound to only one knowledge base.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public CreateAgentResponse CreateAgentWithOptions(CreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBases))
            {
                body["KnowledgeBases"] = request.KnowledgeBases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skills))
            {
                body["Skills"] = request.Skills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                body["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["Tools"] = request.Tools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgent",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is the unique identifier of the agent within the current tenant. It can contain only letters, digits, underscores (_), and hyphens (-), and must be 1 to 128 characters in length. It cannot be modified after creation.</description></item>
        /// <item><description>Each agent can be bound to only one knowledge base.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public async Task<CreateAgentResponse> CreateAgentWithOptionsAsync(CreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBases))
            {
                body["KnowledgeBases"] = request.KnowledgeBases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skills))
            {
                body["Skills"] = request.Skills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                body["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["Tools"] = request.Tools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgent",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is the unique identifier of the agent within the current tenant. It can contain only letters, digits, underscores (_), and hyphens (-), and must be 1 to 128 characters in length. It cannot be modified after creation.</description></item>
        /// <item><description>Each agent can be bound to only one knowledge base.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is the unique identifier of the agent within the current tenant. It can contain only letters, digits, underscores (_), and hyphens (-), and must be 1 to 128 characters in length. It cannot be modified after creation.</description></item>
        /// <item><description>Each agent can be bound to only one knowledge base.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public async Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a text session for a specified agent and obtains the session ID required for subsequent calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, obtain the name of an agent accessible to the current identity. After the session is created, save <c>JsonRpcResponse.result.sessionId</c> and use it as <c>Params.sessionId</c> for subsequent operations such as <c>PromptAgentSession</c> and <c>LoadAgentSession</c>.
        /// You can set the approval mode during creation. If omitted, the default value is <c>default</c>. The availability of <c>yolo</c> depends on the target agent. If it is not supported, an error is returned. This mode does not change the caller\&quot;s permissions or replace business Q&amp;A. To retry the same creation request, reuse the same <c>clientToken</c> and the same business parameters.</para>
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
                Version = "2026-07-01",
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
        /// <para>Creates a text session for a specified agent and obtains the session ID required for subsequent calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, obtain the name of an agent accessible to the current identity. After the session is created, save <c>JsonRpcResponse.result.sessionId</c> and use it as <c>Params.sessionId</c> for subsequent operations such as <c>PromptAgentSession</c> and <c>LoadAgentSession</c>.
        /// You can set the approval mode during creation. If omitted, the default value is <c>default</c>. The availability of <c>yolo</c> depends on the target agent. If it is not supported, an error is returned. This mode does not change the caller\&quot;s permissions or replace business Q&amp;A. To retry the same creation request, reuse the same <c>clientToken</c> and the same business parameters.</para>
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
                Version = "2026-07-01",
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
        /// <para>Creates a text session for a specified agent and obtains the session ID required for subsequent calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, obtain the name of an agent accessible to the current identity. After the session is created, save <c>JsonRpcResponse.result.sessionId</c> and use it as <c>Params.sessionId</c> for subsequent operations such as <c>PromptAgentSession</c> and <c>LoadAgentSession</c>.
        /// You can set the approval mode during creation. If omitted, the default value is <c>default</c>. The availability of <c>yolo</c> depends on the target agent. If it is not supported, an error is returned. This mode does not change the caller\&quot;s permissions or replace business Q&amp;A. To retry the same creation request, reuse the same <c>clientToken</c> and the same business parameters.</para>
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
        /// <para>Creates a text session for a specified agent and obtains the session ID required for subsequent calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, obtain the name of an agent accessible to the current identity. After the session is created, save <c>JsonRpcResponse.result.sessionId</c> and use it as <c>Params.sessionId</c> for subsequent operations such as <c>PromptAgentSession</c> and <c>LoadAgentSession</c>.
        /// You can set the approval mode during creation. If omitted, the default value is <c>default</c>. The availability of <c>yolo</c> depends on the target agent. If it is not supported, an error is returned. This mode does not change the caller\&quot;s permissions or replace business Q&amp;A. To retry the same creation request, reuse the same <c>clientToken</c> and the same business parameters.</para>
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
        /// <para>Creates a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creation rules:<list type="bullet">
        /// <item><description>Name must be unique within the current tenant and cannot be the same as an official skill.</description></item>
        /// <item><description>Description and Metadata are required. Metadata must and can only contain one valid content source. Different sources cannot be mixed.</description></item>
        /// <item><description>After the skill is created, you can modify it by calling UpdateSkill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description>skillMd: Directly enter the Markdown body. No YAML front matter is required. Use Name and Description for the name and description respectively.</description></item>
        /// <item><description>transitId: Upload and confirm a ZIP file through Transit. The call sequence is as follows:<ol>
        /// <item><description>Call CreateTransitUploadPolicy and pass in FileShowName to obtain TransitId, FilePath, and PolicyInfo.</description></item>
        /// <item><description>Use PolicyInfo and FilePath to upload the ZIP file to Object Storage Service (OSS).</description></item>
        /// <item><description>Call ConfirmTransitUpload and pass in TransitId. Proceed with creation only if Confirmed=true is returned.</description></item>
        /// <item><description>Call CreateSkill and pass the confirmed TransitId in Metadata.transitId.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description>bundleUrl: Pass in a public HTTPS ZIP direct link. The platform downloads and saves it as an artifact. The original URL is not saved or echoed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public CreateSkillResponse CreateSkillWithOptions(CreateSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creation rules:<list type="bullet">
        /// <item><description>Name must be unique within the current tenant and cannot be the same as an official skill.</description></item>
        /// <item><description>Description and Metadata are required. Metadata must and can only contain one valid content source. Different sources cannot be mixed.</description></item>
        /// <item><description>After the skill is created, you can modify it by calling UpdateSkill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description>skillMd: Directly enter the Markdown body. No YAML front matter is required. Use Name and Description for the name and description respectively.</description></item>
        /// <item><description>transitId: Upload and confirm a ZIP file through Transit. The call sequence is as follows:<ol>
        /// <item><description>Call CreateTransitUploadPolicy and pass in FileShowName to obtain TransitId, FilePath, and PolicyInfo.</description></item>
        /// <item><description>Use PolicyInfo and FilePath to upload the ZIP file to Object Storage Service (OSS).</description></item>
        /// <item><description>Call ConfirmTransitUpload and pass in TransitId. Proceed with creation only if Confirmed=true is returned.</description></item>
        /// <item><description>Call CreateSkill and pass the confirmed TransitId in Metadata.transitId.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description>bundleUrl: Pass in a public HTTPS ZIP direct link. The platform downloads and saves it as an artifact. The original URL is not saved or echoed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public async Task<CreateSkillResponse> CreateSkillWithOptionsAsync(CreateSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creation rules:<list type="bullet">
        /// <item><description>Name must be unique within the current tenant and cannot be the same as an official skill.</description></item>
        /// <item><description>Description and Metadata are required. Metadata must and can only contain one valid content source. Different sources cannot be mixed.</description></item>
        /// <item><description>After the skill is created, you can modify it by calling UpdateSkill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description>skillMd: Directly enter the Markdown body. No YAML front matter is required. Use Name and Description for the name and description respectively.</description></item>
        /// <item><description>transitId: Upload and confirm a ZIP file through Transit. The call sequence is as follows:<ol>
        /// <item><description>Call CreateTransitUploadPolicy and pass in FileShowName to obtain TransitId, FilePath, and PolicyInfo.</description></item>
        /// <item><description>Use PolicyInfo and FilePath to upload the ZIP file to Object Storage Service (OSS).</description></item>
        /// <item><description>Call ConfirmTransitUpload and pass in TransitId. Proceed with creation only if Confirmed=true is returned.</description></item>
        /// <item><description>Call CreateSkill and pass the confirmed TransitId in Metadata.transitId.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description>bundleUrl: Pass in a public HTTPS ZIP direct link. The platform downloads and saves it as an artifact. The original URL is not saved or echoed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public CreateSkillResponse CreateSkill(CreateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creation rules:<list type="bullet">
        /// <item><description>Name must be unique within the current tenant and cannot be the same as an official skill.</description></item>
        /// <item><description>Description and Metadata are required. Metadata must and can only contain one valid content source. Different sources cannot be mixed.</description></item>
        /// <item><description>After the skill is created, you can modify it by calling UpdateSkill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description>skillMd: Directly enter the Markdown body. No YAML front matter is required. Use Name and Description for the name and description respectively.</description></item>
        /// <item><description>transitId: Upload and confirm a ZIP file through Transit. The call sequence is as follows:<ol>
        /// <item><description>Call CreateTransitUploadPolicy and pass in FileShowName to obtain TransitId, FilePath, and PolicyInfo.</description></item>
        /// <item><description>Use PolicyInfo and FilePath to upload the ZIP file to Object Storage Service (OSS).</description></item>
        /// <item><description>Call ConfirmTransitUpload and pass in TransitId. Proceed with creation only if Confirmed=true is returned.</description></item>
        /// <item><description>Call CreateSkill and pass the confirmed TransitId in Metadata.transitId.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description>bundleUrl: Pass in a public HTTPS ZIP direct link. The platform downloads and saves it as an artifact. The original URL is not saved or echoed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public async Task<CreateSkillResponse> CreateSkillAsync(CreateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates credentials for direct file upload. Callers can use the returned upload policy to upload files directly to object storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Network</c> can be set to <c>public</c> or <c>internal</c> to generate a public network or same-region internal network upload address, respectively. The default value is <c>public</c>.</description></item>
        /// <item><description>The maximum size of a single file is 50 MiB.</description></item>
        /// <item><description><c>PolicyInfo</c> contains short-term upload authorization information and is only used for the current file upload. Do not log, permanently store, or forward it to other users.</description></item>
        /// <item><description><c>ExpireMs</c> specifies the validity period of the current upload policy and Transit record in milliseconds, not an absolute timestamp. Both the default and maximum values are <c>604800000</c> (7 days), and the minimum value is <c>1000</c> (1 second). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>You can call <c>GetTransitMeta</c> to read <c>ExpireAt</c> and obtain the expiration time of the Transit record. Confirming the upload and querying do not extend the validity period of the record.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTransitUploadPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTransitUploadPolicyResponse
        /// </returns>
        public CreateTransitUploadPolicyResponse CreateTransitUploadPolicyWithOptions(CreateTransitUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMs))
            {
                body["ExpireMs"] = request.ExpireMs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileShowName))
            {
                body["FileShowName"] = request.FileShowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathPrefix))
            {
                body["PathPrefix"] = request.PathPrefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitUploadPolicy",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitUploadPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates credentials for direct file upload. Callers can use the returned upload policy to upload files directly to object storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Network</c> can be set to <c>public</c> or <c>internal</c> to generate a public network or same-region internal network upload address, respectively. The default value is <c>public</c>.</description></item>
        /// <item><description>The maximum size of a single file is 50 MiB.</description></item>
        /// <item><description><c>PolicyInfo</c> contains short-term upload authorization information and is only used for the current file upload. Do not log, permanently store, or forward it to other users.</description></item>
        /// <item><description><c>ExpireMs</c> specifies the validity period of the current upload policy and Transit record in milliseconds, not an absolute timestamp. Both the default and maximum values are <c>604800000</c> (7 days), and the minimum value is <c>1000</c> (1 second). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>You can call <c>GetTransitMeta</c> to read <c>ExpireAt</c> and obtain the expiration time of the Transit record. Confirming the upload and querying do not extend the validity period of the record.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTransitUploadPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTransitUploadPolicyResponse
        /// </returns>
        public async Task<CreateTransitUploadPolicyResponse> CreateTransitUploadPolicyWithOptionsAsync(CreateTransitUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMs))
            {
                body["ExpireMs"] = request.ExpireMs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileShowName))
            {
                body["FileShowName"] = request.FileShowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathPrefix))
            {
                body["PathPrefix"] = request.PathPrefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitUploadPolicy",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitUploadPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates credentials for direct file upload. Callers can use the returned upload policy to upload files directly to object storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Network</c> can be set to <c>public</c> or <c>internal</c> to generate a public network or same-region internal network upload address, respectively. The default value is <c>public</c>.</description></item>
        /// <item><description>The maximum size of a single file is 50 MiB.</description></item>
        /// <item><description><c>PolicyInfo</c> contains short-term upload authorization information and is only used for the current file upload. Do not log, permanently store, or forward it to other users.</description></item>
        /// <item><description><c>ExpireMs</c> specifies the validity period of the current upload policy and Transit record in milliseconds, not an absolute timestamp. Both the default and maximum values are <c>604800000</c> (7 days), and the minimum value is <c>1000</c> (1 second). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>You can call <c>GetTransitMeta</c> to read <c>ExpireAt</c> and obtain the expiration time of the Transit record. Confirming the upload and querying do not extend the validity period of the record.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTransitUploadPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTransitUploadPolicyResponse
        /// </returns>
        public CreateTransitUploadPolicyResponse CreateTransitUploadPolicy(CreateTransitUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitUploadPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates credentials for direct file upload. Callers can use the returned upload policy to upload files directly to object storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Network</c> can be set to <c>public</c> or <c>internal</c> to generate a public network or same-region internal network upload address, respectively. The default value is <c>public</c>.</description></item>
        /// <item><description>The maximum size of a single file is 50 MiB.</description></item>
        /// <item><description><c>PolicyInfo</c> contains short-term upload authorization information and is only used for the current file upload. Do not log, permanently store, or forward it to other users.</description></item>
        /// <item><description><c>ExpireMs</c> specifies the validity period of the current upload policy and Transit record in milliseconds, not an absolute timestamp. Both the default and maximum values are <c>604800000</c> (7 days), and the minimum value is <c>1000</c> (1 second). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>You can call <c>GetTransitMeta</c> to read <c>ExpireAt</c> and obtain the expiration time of the Transit record. Confirming the upload and querying do not extend the validity period of the record.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTransitUploadPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTransitUploadPolicyResponse
        /// </returns>
        public async Task<CreateTransitUploadPolicyResponse> CreateTransitUploadPolicyAsync(CreateTransitUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitUploadPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creators can delete the agents they created.</description></item>
        /// <item><description>After deletion, the agent can no longer be queried, updated, or executed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgentWithOptions(DeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgent",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creators can delete the agents they created.</description></item>
        /// <item><description>After deletion, the agent can no longer be queried, updated, or executed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentWithOptionsAsync(DeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgent",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creators can delete the agents they created.</description></item>
        /// <item><description>After deletion, the agent can no longer be queried, updated, or executed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creators can delete the agents they created.</description></item>
        /// <item><description>After deletion, the agent can no longer be queried, updated, or executed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an idle session that is no longer needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A session cannot be directly deleted while it is being executed or waiting for interaction. You must first call <c>CancelAgentSession</c> and continue reading the original response stream, or resume reading through <c>LoadAgentSession</c>. Delete the session only after confirming that the target turn has ended.
        /// A successful deletion indicates that the session deletion operation is complete, but it does not mean that external operations that have already occurred are rolled back. Deleting a session does not delete the associated agent or assistant.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSessionResponse
        /// </returns>
        public DeleteAgentSessionResponse DeleteAgentSessionWithOptions(DeleteAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAgentSessionShrinkRequest request = new DeleteAgentSessionShrinkRequest();
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
                Action = "DeleteAgentSession",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an idle session that is no longer needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A session cannot be directly deleted while it is being executed or waiting for interaction. You must first call <c>CancelAgentSession</c> and continue reading the original response stream, or resume reading through <c>LoadAgentSession</c>. Delete the session only after confirming that the target turn has ended.
        /// A successful deletion indicates that the session deletion operation is complete, but it does not mean that external operations that have already occurred are rolled back. Deleting a session does not delete the associated agent or assistant.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSessionResponse
        /// </returns>
        public async Task<DeleteAgentSessionResponse> DeleteAgentSessionWithOptionsAsync(DeleteAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAgentSessionShrinkRequest request = new DeleteAgentSessionShrinkRequest();
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
                Action = "DeleteAgentSession",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an idle session that is no longer needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A session cannot be directly deleted while it is being executed or waiting for interaction. You must first call <c>CancelAgentSession</c> and continue reading the original response stream, or resume reading through <c>LoadAgentSession</c>. Delete the session only after confirming that the target turn has ended.
        /// A successful deletion indicates that the session deletion operation is complete, but it does not mean that external operations that have already occurred are rolled back. Deleting a session does not delete the associated agent or assistant.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSessionResponse
        /// </returns>
        public DeleteAgentSessionResponse DeleteAgentSession(DeleteAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAgentSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an idle session that is no longer needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A session cannot be directly deleted while it is being executed or waiting for interaction. You must first call <c>CancelAgentSession</c> and continue reading the original response stream, or resume reading through <c>LoadAgentSession</c>. Delete the session only after confirming that the target turn has ended.
        /// A successful deletion indicates that the session deletion operation is complete, but it does not mean that external operations that have already occurred are rolled back. Deleting a session does not delete the associated agent or assistant.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSessionResponse
        /// </returns>
        public async Task<DeleteAgentSessionResponse> DeleteAgentSessionAsync(DeleteAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAgentSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Soft-deletes a skill that the caller has permission to modify.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deletion permissions:<list type="bullet">
        /// <item><description>Only custom skills that the caller has permission to modify can be deleted.</description></item>
        /// <item><description>The caller must be the creator of the skill or the root account of the tenant that has permission to manage the tenant-level skill. Official skills cannot be deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Deletion results:<list type="bullet">
        /// <item><description>Deletion is performed as a soft delete. After a successful deletion, <c>GetSkill</c> and <c>ListSkills</c> no longer return the skill, and you can create a new skill with the same name.</description></item>
        /// <item><description>Recovery is not supported. You cannot repeatedly delete a skill or delete a non-existent skill.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public DeleteSkillResponse DeleteSkillWithOptions(DeleteSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Soft-deletes a skill that the caller has permission to modify.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deletion permissions:<list type="bullet">
        /// <item><description>Only custom skills that the caller has permission to modify can be deleted.</description></item>
        /// <item><description>The caller must be the creator of the skill or the root account of the tenant that has permission to manage the tenant-level skill. Official skills cannot be deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Deletion results:<list type="bullet">
        /// <item><description>Deletion is performed as a soft delete. After a successful deletion, <c>GetSkill</c> and <c>ListSkills</c> no longer return the skill, and you can create a new skill with the same name.</description></item>
        /// <item><description>Recovery is not supported. You cannot repeatedly delete a skill or delete a non-existent skill.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public async Task<DeleteSkillResponse> DeleteSkillWithOptionsAsync(DeleteSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Soft-deletes a skill that the caller has permission to modify.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deletion permissions:<list type="bullet">
        /// <item><description>Only custom skills that the caller has permission to modify can be deleted.</description></item>
        /// <item><description>The caller must be the creator of the skill or the root account of the tenant that has permission to manage the tenant-level skill. Official skills cannot be deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Deletion results:<list type="bullet">
        /// <item><description>Deletion is performed as a soft delete. After a successful deletion, <c>GetSkill</c> and <c>ListSkills</c> no longer return the skill, and you can create a new skill with the same name.</description></item>
        /// <item><description>Recovery is not supported. You cannot repeatedly delete a skill or delete a non-existent skill.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public DeleteSkillResponse DeleteSkill(DeleteSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Soft-deletes a skill that the caller has permission to modify.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deletion permissions:<list type="bullet">
        /// <item><description>Only custom skills that the caller has permission to modify can be deleted.</description></item>
        /// <item><description>The caller must be the creator of the skill or the root account of the tenant that has permission to manage the tenant-level skill. Official skills cannot be deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Deletion results:<list type="bullet">
        /// <item><description>Deletion is performed as a soft delete. After a successful deletion, <c>GetSkill</c> and <c>ListSkills</c> no longer return the skill, and you can create a new skill with the same name.</description></item>
        /// <item><description>Recovery is not supported. You cannot repeatedly delete a skill or delete a non-existent skill.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public async Task<DeleteSkillResponse> DeleteSkillAsync(DeleteSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries agents visible to the current identity by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can retrieve agents created by yourself, agents visible within the current tenant, and official agents provided by the platform.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public GetAgentResponse GetAgentWithOptions(GetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgent",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries agents visible to the current identity by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can retrieve agents created by yourself, agents visible within the current tenant, and official agents provided by the platform.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public async Task<GetAgentResponse> GetAgentWithOptionsAsync(GetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgent",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries agents visible to the current identity by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can retrieve agents created by yourself, agents visible within the current tenant, and official agents provided by the platform.</description></item>
        /// </list>
        /// </description>
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
            return GetAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries agents visible to the current identity by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can retrieve agents created by yourself, agents visible within the current tenant, and official agents provided by the platform.</description></item>
        /// </list>
        /// </description>
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
            return await GetAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries session details such as the title, associated agent, and core timestamps based on the session ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For <c>Params.sessionId</c>, use the session ID returned by <c>CreateAgentSession</c> or <c>ListAgentSessions</c>. The business result is located in <c>JsonRpcResponse.result</c>, which is of type <c>any</c>. The fields within the object retain their actual casing.
        /// This operation provides a session summary and does not return the complete message history, pending interactions, or the final state of real-time turns. For history and disconnection recovery, use <c>LoadAgentSession</c>. For approvals and Q&amp;A, read from the streaming notifications of <c>PromptAgentSession</c> or <c>LoadAgentSession</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSessionResponse
        /// </returns>
        public GetAgentSessionResponse GetAgentSessionWithOptions(GetAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentSessionShrinkRequest request = new GetAgentSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                query["Jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                query["Params"] = request.ParamsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSession",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries session details such as the title, associated agent, and core timestamps based on the session ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For <c>Params.sessionId</c>, use the session ID returned by <c>CreateAgentSession</c> or <c>ListAgentSessions</c>. The business result is located in <c>JsonRpcResponse.result</c>, which is of type <c>any</c>. The fields within the object retain their actual casing.
        /// This operation provides a session summary and does not return the complete message history, pending interactions, or the final state of real-time turns. For history and disconnection recovery, use <c>LoadAgentSession</c>. For approvals and Q&amp;A, read from the streaming notifications of <c>PromptAgentSession</c> or <c>LoadAgentSession</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSessionResponse
        /// </returns>
        public async Task<GetAgentSessionResponse> GetAgentSessionWithOptionsAsync(GetAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentSessionShrinkRequest request = new GetAgentSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                query["Jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                query["Params"] = request.ParamsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSession",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries session details such as the title, associated agent, and core timestamps based on the session ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For <c>Params.sessionId</c>, use the session ID returned by <c>CreateAgentSession</c> or <c>ListAgentSessions</c>. The business result is located in <c>JsonRpcResponse.result</c>, which is of type <c>any</c>. The fields within the object retain their actual casing.
        /// This operation provides a session summary and does not return the complete message history, pending interactions, or the final state of real-time turns. For history and disconnection recovery, use <c>LoadAgentSession</c>. For approvals and Q&amp;A, read from the streaming notifications of <c>PromptAgentSession</c> or <c>LoadAgentSession</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSessionResponse
        /// </returns>
        public GetAgentSessionResponse GetAgentSession(GetAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries session details such as the title, associated agent, and core timestamps based on the session ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For <c>Params.sessionId</c>, use the session ID returned by <c>CreateAgentSession</c> or <c>ListAgentSessions</c>. The business result is located in <c>JsonRpcResponse.result</c>, which is of type <c>any</c>. The fields within the object retain their actual casing.
        /// This operation provides a session summary and does not return the complete message history, pending interactions, or the final state of real-time turns. For history and disconnection recovery, use <c>LoadAgentSession</c>. For approvals and Q&amp;A, read from the streaming notifications of <c>PromptAgentSession</c> or <c>LoadAgentSession</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSessionResponse
        /// </returns>
        public async Task<GetAgentSessionResponse> GetAgentSessionAsync(GetAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current model and thinking level configuration used by a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use the <c>sessionId</c> returned by CreateAgentSession to query the configuration. This operation does not send messages or replay session history.</description></item>
        /// <item><description>Read the current model from <c>JsonRpcResponse.result.modelId</c>. To modify it, call SetAgentSessionModel.</description></item>
        /// <item><description>The thinking level is an optional advanced configuration. The supported levels and current values are subject to the actual return values of this operation, which may vary across different agents, models, and sessions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetAgentSessionModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSessionModelResponse
        /// </returns>
        public GetAgentSessionModelResponse GetAgentSessionModelWithOptions(GetAgentSessionModelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentSessionModelShrinkRequest request = new GetAgentSessionModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                query["Jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                query["Params"] = request.ParamsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSessionModel",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSessionModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current model and thinking level configuration used by a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use the <c>sessionId</c> returned by CreateAgentSession to query the configuration. This operation does not send messages or replay session history.</description></item>
        /// <item><description>Read the current model from <c>JsonRpcResponse.result.modelId</c>. To modify it, call SetAgentSessionModel.</description></item>
        /// <item><description>The thinking level is an optional advanced configuration. The supported levels and current values are subject to the actual return values of this operation, which may vary across different agents, models, and sessions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetAgentSessionModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSessionModelResponse
        /// </returns>
        public async Task<GetAgentSessionModelResponse> GetAgentSessionModelWithOptionsAsync(GetAgentSessionModelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentSessionModelShrinkRequest request = new GetAgentSessionModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                query["Jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                query["Params"] = request.ParamsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSessionModel",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSessionModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current model and thinking level configuration used by a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use the <c>sessionId</c> returned by CreateAgentSession to query the configuration. This operation does not send messages or replay session history.</description></item>
        /// <item><description>Read the current model from <c>JsonRpcResponse.result.modelId</c>. To modify it, call SetAgentSessionModel.</description></item>
        /// <item><description>The thinking level is an optional advanced configuration. The supported levels and current values are subject to the actual return values of this operation, which may vary across different agents, models, and sessions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSessionModelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSessionModelResponse
        /// </returns>
        public GetAgentSessionModelResponse GetAgentSessionModel(GetAgentSessionModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentSessionModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current model and thinking level configuration used by a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Use the <c>sessionId</c> returned by CreateAgentSession to query the configuration. This operation does not send messages or replay session history.</description></item>
        /// <item><description>Read the current model from <c>JsonRpcResponse.result.modelId</c>. To modify it, call SetAgentSessionModel.</description></item>
        /// <item><description>The thinking level is an optional advanced configuration. The supported levels and current values are subject to the actual return values of this operation, which may vary across different agents, models, and sessions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSessionModelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSessionModelResponse
        /// </returns>
        public async Task<GetAgentSessionModelResponse> GetAgentSessionModelAsync(GetAgentSessionModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentSessionModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the skills visible to the current caller by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query target:<list type="bullet">
        /// <item><description>Queries by <c>Name</c>. Querying by <c>SkillId</c> is not supported.</description></item>
        /// <item><description>Prioritizes returning skills with the same name that are visible to the caller under the current tenant. If no visible records are found, queries official skills with the same name.</description></item>
        /// <item><description>If <c>SkillVersion</c> is omitted, the current skill is returned. This parameter is omitted by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Download URL:<list type="bullet">
        /// <item><description><c>Network</c> supports <c>public</c> and <c>internal</c>. If omitted, no download URL is generated.</description></item>
        /// <item><description>If the skill has an accessible artifact, a temporary <c>DownloadUrl</c> and the corresponding <c>DownloadUrlNetwork</c> are returned.</description></item>
        /// <item><description>If the artifact does not exist, access is denied, or URL generation fails, the skill query can still succeed, but the download URL-related fields may not be returned.</description></item>
        /// <item><description>The original <c>bundleUrl</c> used during creation is not saved and is not returned by this API.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public GetSkillResponse GetSkillWithOptions(GetSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillVersion))
            {
                query["SkillVersion"] = request.SkillVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the skills visible to the current caller by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query target:<list type="bullet">
        /// <item><description>Queries by <c>Name</c>. Querying by <c>SkillId</c> is not supported.</description></item>
        /// <item><description>Prioritizes returning skills with the same name that are visible to the caller under the current tenant. If no visible records are found, queries official skills with the same name.</description></item>
        /// <item><description>If <c>SkillVersion</c> is omitted, the current skill is returned. This parameter is omitted by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Download URL:<list type="bullet">
        /// <item><description><c>Network</c> supports <c>public</c> and <c>internal</c>. If omitted, no download URL is generated.</description></item>
        /// <item><description>If the skill has an accessible artifact, a temporary <c>DownloadUrl</c> and the corresponding <c>DownloadUrlNetwork</c> are returned.</description></item>
        /// <item><description>If the artifact does not exist, access is denied, or URL generation fails, the skill query can still succeed, but the download URL-related fields may not be returned.</description></item>
        /// <item><description>The original <c>bundleUrl</c> used during creation is not saved and is not returned by this API.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public async Task<GetSkillResponse> GetSkillWithOptionsAsync(GetSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillVersion))
            {
                query["SkillVersion"] = request.SkillVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the skills visible to the current caller by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query target:<list type="bullet">
        /// <item><description>Queries by <c>Name</c>. Querying by <c>SkillId</c> is not supported.</description></item>
        /// <item><description>Prioritizes returning skills with the same name that are visible to the caller under the current tenant. If no visible records are found, queries official skills with the same name.</description></item>
        /// <item><description>If <c>SkillVersion</c> is omitted, the current skill is returned. This parameter is omitted by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Download URL:<list type="bullet">
        /// <item><description><c>Network</c> supports <c>public</c> and <c>internal</c>. If omitted, no download URL is generated.</description></item>
        /// <item><description>If the skill has an accessible artifact, a temporary <c>DownloadUrl</c> and the corresponding <c>DownloadUrlNetwork</c> are returned.</description></item>
        /// <item><description>If the artifact does not exist, access is denied, or URL generation fails, the skill query can still succeed, but the download URL-related fields may not be returned.</description></item>
        /// <item><description>The original <c>bundleUrl</c> used during creation is not saved and is not returned by this API.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public GetSkillResponse GetSkill(GetSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the skills visible to the current caller by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query target:<list type="bullet">
        /// <item><description>Queries by <c>Name</c>. Querying by <c>SkillId</c> is not supported.</description></item>
        /// <item><description>Prioritizes returning skills with the same name that are visible to the caller under the current tenant. If no visible records are found, queries official skills with the same name.</description></item>
        /// <item><description>If <c>SkillVersion</c> is omitted, the current skill is returned. This parameter is omitted by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Download URL:<list type="bullet">
        /// <item><description><c>Network</c> supports <c>public</c> and <c>internal</c>. If omitted, no download URL is generated.</description></item>
        /// <item><description>If the skill has an accessible artifact, a temporary <c>DownloadUrl</c> and the corresponding <c>DownloadUrlNetwork</c> are returned.</description></item>
        /// <item><description>If the artifact does not exist, access is denied, or URL generation fails, the skill query can still succeed, but the download URL-related fields may not be returned.</description></item>
        /// <item><description>The original <c>bundleUrl</c> used during creation is not saved and is not returned by this API.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public async Task<GetSkillResponse> GetSkillAsync(GetSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a transit file, such as the upload status, file size, and expiration time, and retrieves a temporary download URL on demand.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of TransitId and FilePath. If both are provided, TransitId takes precedence.</description></item>
        /// <item><description>Use the TransitId returned by CreateTransitUploadPolicy for queries. TransitId is a temporary capability identifier in the file upload process. Do not forward it to irrelevant users.</description></item>
        /// <item><description>FilePath is the opaque object path returned by CreateTransitUploadPolicy. Callers must use it as is and must not parse, modify, or concatenate it.</description></item>
        /// <item><description>When querying by FilePath, an error is returned if the record does not exist or is inaccessible to the current caller.</description></item>
        /// <item><description>ExpireMs specifies the validity period of the download URL in milliseconds. The default value is 900000 (15 minutes). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>ExpireAt indicates the expiration time of the transit record, not the expiration time of the download URL. Querying, generating a download URL, and confirming an upload do not extend the validity period of the record.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTransitMetaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTransitMetaResponse
        /// </returns>
        public GetTransitMetaResponse GetTransitMetaWithOptions(GetTransitMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMs))
            {
                query["ExpireMs"] = request.ExpireMs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitId))
            {
                query["TransitId"] = request.TransitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTransitMeta",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTransitMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a transit file, such as the upload status, file size, and expiration time, and retrieves a temporary download URL on demand.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of TransitId and FilePath. If both are provided, TransitId takes precedence.</description></item>
        /// <item><description>Use the TransitId returned by CreateTransitUploadPolicy for queries. TransitId is a temporary capability identifier in the file upload process. Do not forward it to irrelevant users.</description></item>
        /// <item><description>FilePath is the opaque object path returned by CreateTransitUploadPolicy. Callers must use it as is and must not parse, modify, or concatenate it.</description></item>
        /// <item><description>When querying by FilePath, an error is returned if the record does not exist or is inaccessible to the current caller.</description></item>
        /// <item><description>ExpireMs specifies the validity period of the download URL in milliseconds. The default value is 900000 (15 minutes). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>ExpireAt indicates the expiration time of the transit record, not the expiration time of the download URL. Querying, generating a download URL, and confirming an upload do not extend the validity period of the record.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTransitMetaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTransitMetaResponse
        /// </returns>
        public async Task<GetTransitMetaResponse> GetTransitMetaWithOptionsAsync(GetTransitMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMs))
            {
                query["ExpireMs"] = request.ExpireMs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitId))
            {
                query["TransitId"] = request.TransitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTransitMeta",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTransitMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a transit file, such as the upload status, file size, and expiration time, and retrieves a temporary download URL on demand.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of TransitId and FilePath. If both are provided, TransitId takes precedence.</description></item>
        /// <item><description>Use the TransitId returned by CreateTransitUploadPolicy for queries. TransitId is a temporary capability identifier in the file upload process. Do not forward it to irrelevant users.</description></item>
        /// <item><description>FilePath is the opaque object path returned by CreateTransitUploadPolicy. Callers must use it as is and must not parse, modify, or concatenate it.</description></item>
        /// <item><description>When querying by FilePath, an error is returned if the record does not exist or is inaccessible to the current caller.</description></item>
        /// <item><description>ExpireMs specifies the validity period of the download URL in milliseconds. The default value is 900000 (15 minutes). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>ExpireAt indicates the expiration time of the transit record, not the expiration time of the download URL. Querying, generating a download URL, and confirming an upload do not extend the validity period of the record.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTransitMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTransitMetaResponse
        /// </returns>
        public GetTransitMetaResponse GetTransitMeta(GetTransitMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTransitMetaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a transit file, such as the upload status, file size, and expiration time, and retrieves a temporary download URL on demand.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of TransitId and FilePath. If both are provided, TransitId takes precedence.</description></item>
        /// <item><description>Use the TransitId returned by CreateTransitUploadPolicy for queries. TransitId is a temporary capability identifier in the file upload process. Do not forward it to irrelevant users.</description></item>
        /// <item><description>FilePath is the opaque object path returned by CreateTransitUploadPolicy. Callers must use it as is and must not parse, modify, or concatenate it.</description></item>
        /// <item><description>When querying by FilePath, an error is returned if the record does not exist or is inaccessible to the current caller.</description></item>
        /// <item><description>ExpireMs specifies the validity period of the download URL in milliseconds. The default value is 900000 (15 minutes). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>ExpireAt indicates the expiration time of the transit record, not the expiration time of the download URL. Querying, generating a download URL, and confirming an upload do not extend the validity period of the record.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTransitMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTransitMetaResponse
        /// </returns>
        public async Task<GetTransitMetaResponse> GetTransitMetaAsync(GetTransitMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTransitMetaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries session summary by page, allowing the caller to select or resume existing sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can filter sessions by agent name. Omit Params.NextToken on the first page. For subsequent queries, keep the filter conditions and page size unchanged, and pass the JsonRpcResponse.Result.NextToken returned from the previous page as is to Params.NextToken. Pagination ends when the token is not returned or is empty.
        /// The list returns session summaries such as session ID, title, and time, but does not provide the final state of the turn execution. After selecting a session, you can use GetAgentSession to query details or LoadAgentSession to load history.
        /// Params in the request, and JsonRpcResponse and Result in the response are explicit objects. The pagination field MaxResults is of type integer<int32>, and NextToken is of type string. SessionList retains the any type. For session summary fields, see the supplementary description.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListAgentSessionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSessionsResponse
        /// </returns>
        public ListAgentSessionsResponse ListAgentSessionsWithOptions(ListAgentSessionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAgentSessionsShrinkRequest request = new ListAgentSessionsShrinkRequest();
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
                Action = "ListAgentSessions",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentSessionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries session summary by page, allowing the caller to select or resume existing sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can filter sessions by agent name. Omit Params.NextToken on the first page. For subsequent queries, keep the filter conditions and page size unchanged, and pass the JsonRpcResponse.Result.NextToken returned from the previous page as is to Params.NextToken. Pagination ends when the token is not returned or is empty.
        /// The list returns session summaries such as session ID, title, and time, but does not provide the final state of the turn execution. After selecting a session, you can use GetAgentSession to query details or LoadAgentSession to load history.
        /// Params in the request, and JsonRpcResponse and Result in the response are explicit objects. The pagination field MaxResults is of type integer<int32>, and NextToken is of type string. SessionList retains the any type. For session summary fields, see the supplementary description.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListAgentSessionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSessionsResponse
        /// </returns>
        public async Task<ListAgentSessionsResponse> ListAgentSessionsWithOptionsAsync(ListAgentSessionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAgentSessionsShrinkRequest request = new ListAgentSessionsShrinkRequest();
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
                Action = "ListAgentSessions",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentSessionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries session summary by page, allowing the caller to select or resume existing sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can filter sessions by agent name. Omit Params.NextToken on the first page. For subsequent queries, keep the filter conditions and page size unchanged, and pass the JsonRpcResponse.Result.NextToken returned from the previous page as is to Params.NextToken. Pagination ends when the token is not returned or is empty.
        /// The list returns session summaries such as session ID, title, and time, but does not provide the final state of the turn execution. After selecting a session, you can use GetAgentSession to query details or LoadAgentSession to load history.
        /// Params in the request, and JsonRpcResponse and Result in the response are explicit objects. The pagination field MaxResults is of type integer<int32>, and NextToken is of type string. SessionList retains the any type. For session summary fields, see the supplementary description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSessionsResponse
        /// </returns>
        public ListAgentSessionsResponse ListAgentSessions(ListAgentSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentSessionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries session summary by page, allowing the caller to select or resume existing sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can filter sessions by agent name. Omit Params.NextToken on the first page. For subsequent queries, keep the filter conditions and page size unchanged, and pass the JsonRpcResponse.Result.NextToken returned from the previous page as is to Params.NextToken. Pagination ends when the token is not returned or is empty.
        /// The list returns session summaries such as session ID, title, and time, but does not provide the final state of the turn execution. After selecting a session, you can use GetAgentSession to query details or LoadAgentSession to load history.
        /// Params in the request, and JsonRpcResponse and Result in the response are explicit objects. The pagination field MaxResults is of type integer<int32>, and NextToken is of type string. SessionList retains the any type. For session summary fields, see the supplementary description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSessionsResponse
        /// </returns>
        public async Task<ListAgentSessionsResponse> ListAgentSessionsAsync(ListAgentSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentSessionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for agents visible to the current identity.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>By default, the official agents provided by the platform and the tenant agents visible to the current identity are returned.</description></item>
        /// <item><description>If <c>Scope</c> is set to <c>SYSTEM</c>, only official agents are queried. If <c>Scope</c> is set to <c>CUSTOM</c>, only custom agents are queried.</description></item>
        /// <item><description>Both cursor-based pagination and page number-based pagination are supported. When using cursor-based pagination, pass the <c>NextToken</c> value returned in the previous response to the next request as is, and keep the calling identity, filter conditions, and <c>MaxResults</c> unchanged.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public ListAgentsResponse ListAgentsWithOptions(ListAgentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                query["CreatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Q))
            {
                query["Q"] = request.Q;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequiredRuntime))
            {
                query["RequiredRuntime"] = request.RequiredRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                query["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgents",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for agents visible to the current identity.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>By default, the official agents provided by the platform and the tenant agents visible to the current identity are returned.</description></item>
        /// <item><description>If <c>Scope</c> is set to <c>SYSTEM</c>, only official agents are queried. If <c>Scope</c> is set to <c>CUSTOM</c>, only custom agents are queried.</description></item>
        /// <item><description>Both cursor-based pagination and page number-based pagination are supported. When using cursor-based pagination, pass the <c>NextToken</c> value returned in the previous response to the next request as is, and keep the calling identity, filter conditions, and <c>MaxResults</c> unchanged.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public async Task<ListAgentsResponse> ListAgentsWithOptionsAsync(ListAgentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                query["CreatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Q))
            {
                query["Q"] = request.Q;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequiredRuntime))
            {
                query["RequiredRuntime"] = request.RequiredRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                query["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgents",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for agents visible to the current identity.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>By default, the official agents provided by the platform and the tenant agents visible to the current identity are returned.</description></item>
        /// <item><description>If <c>Scope</c> is set to <c>SYSTEM</c>, only official agents are queried. If <c>Scope</c> is set to <c>CUSTOM</c>, only custom agents are queried.</description></item>
        /// <item><description>Both cursor-based pagination and page number-based pagination are supported. When using cursor-based pagination, pass the <c>NextToken</c> value returned in the previous response to the next request as is, and keep the calling identity, filter conditions, and <c>MaxResults</c> unchanged.</description></item>
        /// </list>
        /// </description>
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
            return ListAgentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for agents visible to the current identity.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>By default, the official agents provided by the platform and the tenant agents visible to the current identity are returned.</description></item>
        /// <item><description>If <c>Scope</c> is set to <c>SYSTEM</c>, only official agents are queried. If <c>Scope</c> is set to <c>CUSTOM</c>, only custom agents are queried.</description></item>
        /// <item><description>Both cursor-based pagination and page number-based pagination are supported. When using cursor-based pagination, pass the <c>NextToken</c> value returned in the previous response to the next request as is, and keep the calling identity, filter conditions, and <c>MaxResults</c> unchanged.</description></item>
        /// </list>
        /// </description>
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
            return await ListAgentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the text models visible to the current caller for selection when setting a session model.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For text sessions, pass <c>ModelType=text</c> and use <c>MaxResults</c> and <c>NextToken</c> for paging. The model identity is obtained from <c>Models[].Id</c> and passed as the <c>Params.modelId</c> for SetAgentSessionModel.</description></item>
        /// <item><description>The visibility of a model in the model catalog does not guarantee that the target session supports the model. After configuration, refer to the SetAgentSessionModel response or the GetAgentSessionModel query result.</description></item>
        /// <item><description><c>ThinkingLevels</c> and <c>ThinkingLevel</c> are used for optional thinking level configurations and do not affect the integration flow when you only select a model.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public ListModelsResponse ListModelsWithOptions(ListModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModels",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the text models visible to the current caller for selection when setting a session model.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For text sessions, pass <c>ModelType=text</c> and use <c>MaxResults</c> and <c>NextToken</c> for paging. The model identity is obtained from <c>Models[].Id</c> and passed as the <c>Params.modelId</c> for SetAgentSessionModel.</description></item>
        /// <item><description>The visibility of a model in the model catalog does not guarantee that the target session supports the model. After configuration, refer to the SetAgentSessionModel response or the GetAgentSessionModel query result.</description></item>
        /// <item><description><c>ThinkingLevels</c> and <c>ThinkingLevel</c> are used for optional thinking level configurations and do not affect the integration flow when you only select a model.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public async Task<ListModelsResponse> ListModelsWithOptionsAsync(ListModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModels",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the text models visible to the current caller for selection when setting a session model.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For text sessions, pass <c>ModelType=text</c> and use <c>MaxResults</c> and <c>NextToken</c> for paging. The model identity is obtained from <c>Models[].Id</c> and passed as the <c>Params.modelId</c> for SetAgentSessionModel.</description></item>
        /// <item><description>The visibility of a model in the model catalog does not guarantee that the target session supports the model. After configuration, refer to the SetAgentSessionModel response or the GetAgentSessionModel query result.</description></item>
        /// <item><description><c>ThinkingLevels</c> and <c>ThinkingLevel</c> are used for optional thinking level configurations and do not affect the integration flow when you only select a model.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public ListModelsResponse ListModels(ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the text models visible to the current caller for selection when setting a session model.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For text sessions, pass <c>ModelType=text</c> and use <c>MaxResults</c> and <c>NextToken</c> for paging. The model identity is obtained from <c>Models[].Id</c> and passed as the <c>Params.modelId</c> for SetAgentSessionModel.</description></item>
        /// <item><description>The visibility of a model in the model catalog does not guarantee that the target session supports the model. After configuration, refer to the SetAgentSessionModel response or the GetAgentSessionModel query result.</description></item>
        /// <item><description><c>ThinkingLevels</c> and <c>ThinkingLevel</c> are used for optional thinking level configurations and do not affect the integration flow when you only select a model.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public async Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query using paging for skills visible to the current invoker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query and filter: <list type="bullet">
        /// <item><description><c>Scope=SYSTEM</c> queries only official skills, and <c>Scope=CUSTOM</c> queries only custom skills. If omitted, both are queried.</description></item>
        /// <item><description>Custom skills with <c>user</c> visibility are visible only to the creator, while skills with <c>tenant</c> visibility are visible to the current tenant.</description></item>
        /// <item><description>You can filter by <c>CreatorId</c>, <c>Q</c>, and <c>Visibility</c>. <c>Q</c> performs a fuzzy match on the skill name or description.</description></item>
        /// <item><description>Results are sorted by update time in descending order by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Pagination: <list type="bullet">
        /// <item><description>Cursor-based pagination uses <c>MaxResults</c> and <c>NextToken</c>. Do not pass <c>NextToken</c> for the first query. For subsequent pages, use the token from the previous response. When using <c>NextToken</c> for subsequent pages, <c>CreatorId</c>, <c>Q</c>, <c>Visibility</c>, <c>Scope</c>, and <c>MaxResults</c> must remain the same as the previous page. If you modify the query conditions, you must query from the first page again.</description></item>
        /// <item><description>Page number-based pagination uses <c>PageNumber</c> and <c>PageSize</c>. If <c>MaxResults</c> is explicitly passed, cursor-based pagination takes precedence. If <c>NextToken</c> is passed, <c>PageNumber</c> is ignored.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Response content: <list type="bullet">
        /// <item><description>This operation returns only skill summaries and does not generate bundle download URLs. To obtain a download URL, call <c>GetSkill</c> and specify <c>Network</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public ListSkillsResponse ListSkillsWithOptions(ListSkillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                query["CreatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Q))
            {
                query["Q"] = request.Q;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                query["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkills",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query using paging for skills visible to the current invoker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query and filter: <list type="bullet">
        /// <item><description><c>Scope=SYSTEM</c> queries only official skills, and <c>Scope=CUSTOM</c> queries only custom skills. If omitted, both are queried.</description></item>
        /// <item><description>Custom skills with <c>user</c> visibility are visible only to the creator, while skills with <c>tenant</c> visibility are visible to the current tenant.</description></item>
        /// <item><description>You can filter by <c>CreatorId</c>, <c>Q</c>, and <c>Visibility</c>. <c>Q</c> performs a fuzzy match on the skill name or description.</description></item>
        /// <item><description>Results are sorted by update time in descending order by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Pagination: <list type="bullet">
        /// <item><description>Cursor-based pagination uses <c>MaxResults</c> and <c>NextToken</c>. Do not pass <c>NextToken</c> for the first query. For subsequent pages, use the token from the previous response. When using <c>NextToken</c> for subsequent pages, <c>CreatorId</c>, <c>Q</c>, <c>Visibility</c>, <c>Scope</c>, and <c>MaxResults</c> must remain the same as the previous page. If you modify the query conditions, you must query from the first page again.</description></item>
        /// <item><description>Page number-based pagination uses <c>PageNumber</c> and <c>PageSize</c>. If <c>MaxResults</c> is explicitly passed, cursor-based pagination takes precedence. If <c>NextToken</c> is passed, <c>PageNumber</c> is ignored.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Response content: <list type="bullet">
        /// <item><description>This operation returns only skill summaries and does not generate bundle download URLs. To obtain a download URL, call <c>GetSkill</c> and specify <c>Network</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public async Task<ListSkillsResponse> ListSkillsWithOptionsAsync(ListSkillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                query["CreatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Q))
            {
                query["Q"] = request.Q;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                query["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkills",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query using paging for skills visible to the current invoker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query and filter: <list type="bullet">
        /// <item><description><c>Scope=SYSTEM</c> queries only official skills, and <c>Scope=CUSTOM</c> queries only custom skills. If omitted, both are queried.</description></item>
        /// <item><description>Custom skills with <c>user</c> visibility are visible only to the creator, while skills with <c>tenant</c> visibility are visible to the current tenant.</description></item>
        /// <item><description>You can filter by <c>CreatorId</c>, <c>Q</c>, and <c>Visibility</c>. <c>Q</c> performs a fuzzy match on the skill name or description.</description></item>
        /// <item><description>Results are sorted by update time in descending order by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Pagination: <list type="bullet">
        /// <item><description>Cursor-based pagination uses <c>MaxResults</c> and <c>NextToken</c>. Do not pass <c>NextToken</c> for the first query. For subsequent pages, use the token from the previous response. When using <c>NextToken</c> for subsequent pages, <c>CreatorId</c>, <c>Q</c>, <c>Visibility</c>, <c>Scope</c>, and <c>MaxResults</c> must remain the same as the previous page. If you modify the query conditions, you must query from the first page again.</description></item>
        /// <item><description>Page number-based pagination uses <c>PageNumber</c> and <c>PageSize</c>. If <c>MaxResults</c> is explicitly passed, cursor-based pagination takes precedence. If <c>NextToken</c> is passed, <c>PageNumber</c> is ignored.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Response content: <list type="bullet">
        /// <item><description>This operation returns only skill summaries and does not generate bundle download URLs. To obtain a download URL, call <c>GetSkill</c> and specify <c>Network</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public ListSkillsResponse ListSkills(ListSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query using paging for skills visible to the current invoker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query and filter: <list type="bullet">
        /// <item><description><c>Scope=SYSTEM</c> queries only official skills, and <c>Scope=CUSTOM</c> queries only custom skills. If omitted, both are queried.</description></item>
        /// <item><description>Custom skills with <c>user</c> visibility are visible only to the creator, while skills with <c>tenant</c> visibility are visible to the current tenant.</description></item>
        /// <item><description>You can filter by <c>CreatorId</c>, <c>Q</c>, and <c>Visibility</c>. <c>Q</c> performs a fuzzy match on the skill name or description.</description></item>
        /// <item><description>Results are sorted by update time in descending order by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Pagination: <list type="bullet">
        /// <item><description>Cursor-based pagination uses <c>MaxResults</c> and <c>NextToken</c>. Do not pass <c>NextToken</c> for the first query. For subsequent pages, use the token from the previous response. When using <c>NextToken</c> for subsequent pages, <c>CreatorId</c>, <c>Q</c>, <c>Visibility</c>, <c>Scope</c>, and <c>MaxResults</c> must remain the same as the previous page. If you modify the query conditions, you must query from the first page again.</description></item>
        /// <item><description>Page number-based pagination uses <c>PageNumber</c> and <c>PageSize</c>. If <c>MaxResults</c> is explicitly passed, cursor-based pagination takes precedence. If <c>NextToken</c> is passed, <c>PageNumber</c> is ignored.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Response content: <list type="bullet">
        /// <item><description>This operation returns only skill summaries and does not generate bundle download URLs. To obtain a download URL, call <c>GetSkill</c> and specify <c>Network</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public async Task<ListSkillsResponse> ListSkillsAsync(ListSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Loads session history, receives subsequent output, or resumes Server-Sent Events (SSE) from a saved read position.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A normal load requires only the session ID. It returns the configuration, history, and output to be continuously received. The response is SSE, not a standard JSON message list.</description></item>
        /// <item><description>When resuming from a disconnection, pass back the actually received cursor, event epoch, and turn ID. History and increments may be returned simultaneously. Existing pages should be rebuilt or deduplicated based on the confirmed cursor. Do not directly append all returned data.</description></item>
        /// <item><description>During the load process, you may receive pending approvals or questions again. Use the interaction notification that is still valid for this session to call ReplyAgentSession.</description></item>
        /// <item><description>For an idle session, <c>stopReason=end_turn</c> may only indicate the end of the current load. It cannot be used to determine the success of a previously interrupted turn. You must associate it with the actual desired state of the target turn. If it cannot be determined, keep the result for verification.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// LoadAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadAgentSessionResponse
        /// </returns>
        public LoadAgentSessionResponse LoadAgentSessionWithOptions(LoadAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            LoadAgentSessionShrinkRequest request = new LoadAgentSessionShrinkRequest();
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
                Action = "LoadAgentSession",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadAgentSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Loads session history, receives subsequent output, or resumes Server-Sent Events (SSE) from a saved read position.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A normal load requires only the session ID. It returns the configuration, history, and output to be continuously received. The response is SSE, not a standard JSON message list.</description></item>
        /// <item><description>When resuming from a disconnection, pass back the actually received cursor, event epoch, and turn ID. History and increments may be returned simultaneously. Existing pages should be rebuilt or deduplicated based on the confirmed cursor. Do not directly append all returned data.</description></item>
        /// <item><description>During the load process, you may receive pending approvals or questions again. Use the interaction notification that is still valid for this session to call ReplyAgentSession.</description></item>
        /// <item><description>For an idle session, <c>stopReason=end_turn</c> may only indicate the end of the current load. It cannot be used to determine the success of a previously interrupted turn. You must associate it with the actual desired state of the target turn. If it cannot be determined, keep the result for verification.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// LoadAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoadAgentSessionResponse
        /// </returns>
        public async Task<LoadAgentSessionResponse> LoadAgentSessionWithOptionsAsync(LoadAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            LoadAgentSessionShrinkRequest request = new LoadAgentSessionShrinkRequest();
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
                Action = "LoadAgentSession",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadAgentSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Loads session history, receives subsequent output, or resumes Server-Sent Events (SSE) from a saved read position.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A normal load requires only the session ID. It returns the configuration, history, and output to be continuously received. The response is SSE, not a standard JSON message list.</description></item>
        /// <item><description>When resuming from a disconnection, pass back the actually received cursor, event epoch, and turn ID. History and increments may be returned simultaneously. Existing pages should be rebuilt or deduplicated based on the confirmed cursor. Do not directly append all returned data.</description></item>
        /// <item><description>During the load process, you may receive pending approvals or questions again. Use the interaction notification that is still valid for this session to call ReplyAgentSession.</description></item>
        /// <item><description>For an idle session, <c>stopReason=end_turn</c> may only indicate the end of the current load. It cannot be used to determine the success of a previously interrupted turn. You must associate it with the actual desired state of the target turn. If it cannot be determined, keep the result for verification.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// LoadAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadAgentSessionResponse
        /// </returns>
        public LoadAgentSessionResponse LoadAgentSession(LoadAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LoadAgentSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Loads session history, receives subsequent output, or resumes Server-Sent Events (SSE) from a saved read position.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A normal load requires only the session ID. It returns the configuration, history, and output to be continuously received. The response is SSE, not a standard JSON message list.</description></item>
        /// <item><description>When resuming from a disconnection, pass back the actually received cursor, event epoch, and turn ID. History and increments may be returned simultaneously. Existing pages should be rebuilt or deduplicated based on the confirmed cursor. Do not directly append all returned data.</description></item>
        /// <item><description>During the load process, you may receive pending approvals or questions again. Use the interaction notification that is still valid for this session to call ReplyAgentSession.</description></item>
        /// <item><description>For an idle session, <c>stopReason=end_turn</c> may only indicate the end of the current load. It cannot be used to determine the success of a previously interrupted turn. You must associate it with the actual desired state of the target turn. If it cannot be determined, keep the result for verification.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// LoadAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// LoadAgentSessionResponse
        /// </returns>
        public async Task<LoadAgentSessionResponse> LoadAgentSessionAsync(LoadAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LoadAgentSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends text to an existing session and continuously receives agent output through Server-Sent Events (SSE).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Pass the session ID returned by CreateAgentSession to <c>Params.sessionId</c> and place the user text in <c>Params.prompt</c>.</description></item>
        /// <item><description>When an execution or pending interaction is already in progress, the default call path rejects new prompts. After receiving an approval or Q&amp;A notification, submit the selection or answer through ReplyAgentSession before continuing to read the original stream.</description></item>
        /// <item><description>A connection interruption does not cancel the execution. If the result is unknown, call LoadAgentSession to resume reading. Submitting duplicate prompts may generate new messages, and duplicate <c>Id</c> values are not deduplicated.</description></item>
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
                Version = "2026-07-01",
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
        /// <para>Sends text to an existing session and continuously receives agent output through Server-Sent Events (SSE).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Pass the session ID returned by CreateAgentSession to <c>Params.sessionId</c> and place the user text in <c>Params.prompt</c>.</description></item>
        /// <item><description>When an execution or pending interaction is already in progress, the default call path rejects new prompts. After receiving an approval or Q&amp;A notification, submit the selection or answer through ReplyAgentSession before continuing to read the original stream.</description></item>
        /// <item><description>A connection interruption does not cancel the execution. If the result is unknown, call LoadAgentSession to resume reading. Submitting duplicate prompts may generate new messages, and duplicate <c>Id</c> values are not deduplicated.</description></item>
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
                Version = "2026-07-01",
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
        /// <para>Sends text to an existing session and continuously receives agent output through Server-Sent Events (SSE).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Pass the session ID returned by CreateAgentSession to <c>Params.sessionId</c> and place the user text in <c>Params.prompt</c>.</description></item>
        /// <item><description>When an execution or pending interaction is already in progress, the default call path rejects new prompts. After receiving an approval or Q&amp;A notification, submit the selection or answer through ReplyAgentSession before continuing to read the original stream.</description></item>
        /// <item><description>A connection interruption does not cancel the execution. If the result is unknown, call LoadAgentSession to resume reading. Submitting duplicate prompts may generate new messages, and duplicate <c>Id</c> values are not deduplicated.</description></item>
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
        /// <para>Sends text to an existing session and continuously receives agent output through Server-Sent Events (SSE).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Pass the session ID returned by CreateAgentSession to <c>Params.sessionId</c> and place the user text in <c>Params.prompt</c>.</description></item>
        /// <item><description>When an execution or pending interaction is already in progress, the default call path rejects new prompts. After receiving an approval or Q&amp;A notification, submit the selection or answer through ReplyAgentSession before continuing to read the original stream.</description></item>
        /// <item><description>A connection interruption does not cancel the execution. If the result is unknown, call LoadAgentSession to resume reading. Submitting duplicate prompts may generate new messages, and duplicate <c>Id</c> values are not deduplicated.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits the approval choice or question answer for the current pending interaction.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Read <c>data.sessionId</c>, <c>data.requestId</c>, and <c>data.options</c> from the <c>permission_request</c> notification of PromptAgentSession or LoadAgentSession. This operation uses the interaction ID, not the tool invoke ID or the server-side RequestId.</description></item>
        /// <item><description>When selecting an action, use the <c>optionId</c> actually provided in the notification. For Q&amp;A scenarios, you must also write the question key and answer text into <c>answers</c>. Do not pass this field for common tool approvals.</description></item>
        /// <item><description><c>accepted=true</c> only indicates that the reply has been accepted. Subsequent output must still be read through Prompt or Load. <c>false</c> indicates that the reply was not adopted this time. You should reload the current interaction and must not automatically change it to approve other requests.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ReplyAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplyAgentSessionResponse
        /// </returns>
        public ReplyAgentSessionResponse ReplyAgentSessionWithOptions(ReplyAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReplyAgentSessionShrinkRequest request = new ReplyAgentSessionShrinkRequest();
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
                Action = "ReplyAgentSession",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplyAgentSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits the approval choice or question answer for the current pending interaction.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Read <c>data.sessionId</c>, <c>data.requestId</c>, and <c>data.options</c> from the <c>permission_request</c> notification of PromptAgentSession or LoadAgentSession. This operation uses the interaction ID, not the tool invoke ID or the server-side RequestId.</description></item>
        /// <item><description>When selecting an action, use the <c>optionId</c> actually provided in the notification. For Q&amp;A scenarios, you must also write the question key and answer text into <c>answers</c>. Do not pass this field for common tool approvals.</description></item>
        /// <item><description><c>accepted=true</c> only indicates that the reply has been accepted. Subsequent output must still be read through Prompt or Load. <c>false</c> indicates that the reply was not adopted this time. You should reload the current interaction and must not automatically change it to approve other requests.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ReplyAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplyAgentSessionResponse
        /// </returns>
        public async Task<ReplyAgentSessionResponse> ReplyAgentSessionWithOptionsAsync(ReplyAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReplyAgentSessionShrinkRequest request = new ReplyAgentSessionShrinkRequest();
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
                Action = "ReplyAgentSession",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplyAgentSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits the approval choice or question answer for the current pending interaction.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Read <c>data.sessionId</c>, <c>data.requestId</c>, and <c>data.options</c> from the <c>permission_request</c> notification of PromptAgentSession or LoadAgentSession. This operation uses the interaction ID, not the tool invoke ID or the server-side RequestId.</description></item>
        /// <item><description>When selecting an action, use the <c>optionId</c> actually provided in the notification. For Q&amp;A scenarios, you must also write the question key and answer text into <c>answers</c>. Do not pass this field for common tool approvals.</description></item>
        /// <item><description><c>accepted=true</c> only indicates that the reply has been accepted. Subsequent output must still be read through Prompt or Load. <c>false</c> indicates that the reply was not adopted this time. You should reload the current interaction and must not automatically change it to approve other requests.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplyAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplyAgentSessionResponse
        /// </returns>
        public ReplyAgentSessionResponse ReplyAgentSession(ReplyAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplyAgentSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits the approval choice or question answer for the current pending interaction.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Read <c>data.sessionId</c>, <c>data.requestId</c>, and <c>data.options</c> from the <c>permission_request</c> notification of PromptAgentSession or LoadAgentSession. This operation uses the interaction ID, not the tool invoke ID or the server-side RequestId.</description></item>
        /// <item><description>When selecting an action, use the <c>optionId</c> actually provided in the notification. For Q&amp;A scenarios, you must also write the question key and answer text into <c>answers</c>. Do not pass this field for common tool approvals.</description></item>
        /// <item><description><c>accepted=true</c> only indicates that the reply has been accepted. Subsequent output must still be read through Prompt or Load. <c>false</c> indicates that the reply was not adopted this time. You should reload the current interaction and must not automatically change it to approve other requests.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReplyAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplyAgentSessionResponse
        /// </returns>
        public async Task<ReplyAgentSessionResponse> ReplyAgentSessionAsync(ReplyAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplyAgentSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the model used by a session and optionally configures the thinking level.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Pass the <c>sessionId</c> returned by CreateAgentSession and the <c>Models[].Id</c> returned by ListModels as <c>Params.sessionId</c> and <c>Params.modelId</c>, respectively. The visibility of a model in the model catalog does not guarantee that the target session supports the model. The final validation is performed by the target session.</description></item>
        /// <item><description><c>modelId</c> is required. When only modifying the model, you can omit <c>thinkingLevel</c>. For details about how to configure the thinking level, see the supplementary description of request parameters.</description></item>
        /// <item><description>This operation only modifies the target session and does not modify the global default model of the agent or account. The session may deny configuration modifications during execution, and switching models during runtime is not guaranteed to be supported.</description></item>
        /// <item><description>The model and thinking level Settings are applied in steps. If the call fails, the model may have already been changed, and a full rollback is not guaranteed. You should call GetAgentSessionModel to query the current configuration before deciding what to do next. After a successful call, you can read the actual effective values from the returned result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SetAgentSessionModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAgentSessionModelResponse
        /// </returns>
        public SetAgentSessionModelResponse SetAgentSessionModelWithOptions(SetAgentSessionModelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetAgentSessionModelShrinkRequest request = new SetAgentSessionModelShrinkRequest();
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
                Action = "SetAgentSessionModel",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAgentSessionModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the model used by a session and optionally configures the thinking level.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Pass the <c>sessionId</c> returned by CreateAgentSession and the <c>Models[].Id</c> returned by ListModels as <c>Params.sessionId</c> and <c>Params.modelId</c>, respectively. The visibility of a model in the model catalog does not guarantee that the target session supports the model. The final validation is performed by the target session.</description></item>
        /// <item><description><c>modelId</c> is required. When only modifying the model, you can omit <c>thinkingLevel</c>. For details about how to configure the thinking level, see the supplementary description of request parameters.</description></item>
        /// <item><description>This operation only modifies the target session and does not modify the global default model of the agent or account. The session may deny configuration modifications during execution, and switching models during runtime is not guaranteed to be supported.</description></item>
        /// <item><description>The model and thinking level Settings are applied in steps. If the call fails, the model may have already been changed, and a full rollback is not guaranteed. You should call GetAgentSessionModel to query the current configuration before deciding what to do next. After a successful call, you can read the actual effective values from the returned result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SetAgentSessionModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAgentSessionModelResponse
        /// </returns>
        public async Task<SetAgentSessionModelResponse> SetAgentSessionModelWithOptionsAsync(SetAgentSessionModelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetAgentSessionModelShrinkRequest request = new SetAgentSessionModelShrinkRequest();
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
                Action = "SetAgentSessionModel",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAgentSessionModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the model used by a session and optionally configures the thinking level.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Pass the <c>sessionId</c> returned by CreateAgentSession and the <c>Models[].Id</c> returned by ListModels as <c>Params.sessionId</c> and <c>Params.modelId</c>, respectively. The visibility of a model in the model catalog does not guarantee that the target session supports the model. The final validation is performed by the target session.</description></item>
        /// <item><description><c>modelId</c> is required. When only modifying the model, you can omit <c>thinkingLevel</c>. For details about how to configure the thinking level, see the supplementary description of request parameters.</description></item>
        /// <item><description>This operation only modifies the target session and does not modify the global default model of the agent or account. The session may deny configuration modifications during execution, and switching models during runtime is not guaranteed to be supported.</description></item>
        /// <item><description>The model and thinking level Settings are applied in steps. If the call fails, the model may have already been changed, and a full rollback is not guaranteed. You should call GetAgentSessionModel to query the current configuration before deciding what to do next. After a successful call, you can read the actual effective values from the returned result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetAgentSessionModelRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAgentSessionModelResponse
        /// </returns>
        public SetAgentSessionModelResponse SetAgentSessionModel(SetAgentSessionModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAgentSessionModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the model used by a session and optionally configures the thinking level.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Pass the <c>sessionId</c> returned by CreateAgentSession and the <c>Models[].Id</c> returned by ListModels as <c>Params.sessionId</c> and <c>Params.modelId</c>, respectively. The visibility of a model in the model catalog does not guarantee that the target session supports the model. The final validation is performed by the target session.</description></item>
        /// <item><description><c>modelId</c> is required. When only modifying the model, you can omit <c>thinkingLevel</c>. For details about how to configure the thinking level, see the supplementary description of request parameters.</description></item>
        /// <item><description>This operation only modifies the target session and does not modify the global default model of the agent or account. The session may deny configuration modifications during execution, and switching models during runtime is not guaranteed to be supported.</description></item>
        /// <item><description>The model and thinking level Settings are applied in steps. If the call fails, the model may have already been changed, and a full rollback is not guaranteed. You should call GetAgentSessionModel to query the current configuration before deciding what to do next. After a successful call, you can read the actual effective values from the returned result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetAgentSessionModelRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAgentSessionModelResponse
        /// </returns>
        public async Task<SetAgentSessionModelResponse> SetAgentSessionModelAsync(SetAgentSessionModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAgentSessionModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of an agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the agent and cannot be modified after creation.</description></item>
        /// <item><description>Each agent can be bound to only one knowledge base.</description></item>
        /// <item><description><c>Tools</c> is updated according to the rules below. If <c>Skills</c> or <c>KnowledgeBases</c> is not passed, the original values are retained. If a non-empty array is passed, the entire list is replaced. If an empty array is passed, the corresponding bindings are removed. Other optional fields retain their original values if not passed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public UpdateAgentResponse UpdateAgentWithOptions(UpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedVersion))
            {
                body["ExpectedVersion"] = request.ExpectedVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBases))
            {
                body["KnowledgeBases"] = request.KnowledgeBases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skills))
            {
                body["Skills"] = request.Skills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                body["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["Tools"] = request.Tools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgent",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of an agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the agent and cannot be modified after creation.</description></item>
        /// <item><description>Each agent can be bound to only one knowledge base.</description></item>
        /// <item><description><c>Tools</c> is updated according to the rules below. If <c>Skills</c> or <c>KnowledgeBases</c> is not passed, the original values are retained. If a non-empty array is passed, the entire list is replaced. If an empty array is passed, the corresponding bindings are removed. Other optional fields retain their original values if not passed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public async Task<UpdateAgentResponse> UpdateAgentWithOptionsAsync(UpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedVersion))
            {
                body["ExpectedVersion"] = request.ExpectedVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBases))
            {
                body["KnowledgeBases"] = request.KnowledgeBases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skills))
            {
                body["Skills"] = request.Skills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                body["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["Tools"] = request.Tools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgent",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of an agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the agent and cannot be modified after creation.</description></item>
        /// <item><description>Each agent can be bound to only one knowledge base.</description></item>
        /// <item><description><c>Tools</c> is updated according to the rules below. If <c>Skills</c> or <c>KnowledgeBases</c> is not passed, the original values are retained. If a non-empty array is passed, the entire list is replaced. If an empty array is passed, the corresponding bindings are removed. Other optional fields retain their original values if not passed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of an agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the agent and cannot be modified after creation.</description></item>
        /// <item><description>Each agent can be bound to only one knowledge base.</description></item>
        /// <item><description><c>Tools</c> is updated according to the rules below. If <c>Skills</c> or <c>KnowledgeBases</c> is not passed, the original values are retained. If a non-empty array is passed, the entire list is replaced. If an empty array is passed, the corresponding bindings are removed. Other optional fields retain their original values if not passed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public async Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Update rules:<list type="bullet">
        /// <item><description>Name is only used to locate the skill and cannot be modified.</description></item>
        /// <item><description>The caller must be the creator of the skill, or the root account of the tenant that has the permission to manage the tenant-level skill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Replacement rules:<list type="bullet">
        /// <item><description>If Description and Visibility are omitted, their original values are retained. Passing <c>null</c> is also treated as omission and cannot be used to clear the original values.</description></item>
        /// <item><description>Metadata is replaced as a whole, not merged incrementally. If Metadata is omitted, the original content is retained. If it is passed, old fields not included in the new object are deleted.</description></item>
        /// <item><description>When modifying only Description or Visibility, do not pass Metadata, and do not pass an empty object <c>{}</c>. An empty object replaces the original metadata with an empty object as a whole.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description>When replacing the body or bundle, you must and can only choose one of skillMd, transitId, or bundleUrl.</description></item>
        /// <item><description>For the field formats of the three sources, the Transit upload confirmation process, and the bundleUrl restrictions, refer to CreateSkill. Finally, pass the selected source in UpdateSkill.Metadata.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public UpdateSkillResponse UpdateSkillWithOptions(UpdateSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedVersion))
            {
                body["ExpectedVersion"] = request.ExpectedVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Update rules:<list type="bullet">
        /// <item><description>Name is only used to locate the skill and cannot be modified.</description></item>
        /// <item><description>The caller must be the creator of the skill, or the root account of the tenant that has the permission to manage the tenant-level skill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Replacement rules:<list type="bullet">
        /// <item><description>If Description and Visibility are omitted, their original values are retained. Passing <c>null</c> is also treated as omission and cannot be used to clear the original values.</description></item>
        /// <item><description>Metadata is replaced as a whole, not merged incrementally. If Metadata is omitted, the original content is retained. If it is passed, old fields not included in the new object are deleted.</description></item>
        /// <item><description>When modifying only Description or Visibility, do not pass Metadata, and do not pass an empty object <c>{}</c>. An empty object replaces the original metadata with an empty object as a whole.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description>When replacing the body or bundle, you must and can only choose one of skillMd, transitId, or bundleUrl.</description></item>
        /// <item><description>For the field formats of the three sources, the Transit upload confirmation process, and the bundleUrl restrictions, refer to CreateSkill. Finally, pass the selected source in UpdateSkill.Metadata.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public async Task<UpdateSkillResponse> UpdateSkillWithOptionsAsync(UpdateSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedVersion))
            {
                body["ExpectedVersion"] = request.ExpectedVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Update rules:<list type="bullet">
        /// <item><description>Name is only used to locate the skill and cannot be modified.</description></item>
        /// <item><description>The caller must be the creator of the skill, or the root account of the tenant that has the permission to manage the tenant-level skill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Replacement rules:<list type="bullet">
        /// <item><description>If Description and Visibility are omitted, their original values are retained. Passing <c>null</c> is also treated as omission and cannot be used to clear the original values.</description></item>
        /// <item><description>Metadata is replaced as a whole, not merged incrementally. If Metadata is omitted, the original content is retained. If it is passed, old fields not included in the new object are deleted.</description></item>
        /// <item><description>When modifying only Description or Visibility, do not pass Metadata, and do not pass an empty object <c>{}</c>. An empty object replaces the original metadata with an empty object as a whole.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description>When replacing the body or bundle, you must and can only choose one of skillMd, transitId, or bundleUrl.</description></item>
        /// <item><description>For the field formats of the three sources, the Transit upload confirmation process, and the bundleUrl restrictions, refer to CreateSkill. Finally, pass the selected source in UpdateSkill.Metadata.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public UpdateSkillResponse UpdateSkill(UpdateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Update rules:<list type="bullet">
        /// <item><description>Name is only used to locate the skill and cannot be modified.</description></item>
        /// <item><description>The caller must be the creator of the skill, or the root account of the tenant that has the permission to manage the tenant-level skill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Replacement rules:<list type="bullet">
        /// <item><description>If Description and Visibility are omitted, their original values are retained. Passing <c>null</c> is also treated as omission and cannot be used to clear the original values.</description></item>
        /// <item><description>Metadata is replaced as a whole, not merged incrementally. If Metadata is omitted, the original content is retained. If it is passed, old fields not included in the new object are deleted.</description></item>
        /// <item><description>When modifying only Description or Visibility, do not pass Metadata, and do not pass an empty object <c>{}</c>. An empty object replaces the original metadata with an empty object as a whole.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description>When replacing the body or bundle, you must and can only choose one of skillMd, transitId, or bundleUrl.</description></item>
        /// <item><description>For the field formats of the three sources, the Transit upload confirmation process, and the bundleUrl restrictions, refer to CreateSkill. Finally, pass the selected source in UpdateSkill.Metadata.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public async Task<UpdateSkillResponse> UpdateSkillAsync(UpdateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSkillWithOptionsAsync(request, runtime);
        }

    }
}
