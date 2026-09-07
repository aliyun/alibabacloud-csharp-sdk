// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.SasClaw20260626.Models;

namespace AlibabaCloud.SDK.SasClaw20260626
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("sasclaw", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Claw SSE Chat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatUserSecAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatUserSecAgentResponse
        /// </returns>
        public ChatUserSecAgentResponse ChatUserSecAgentWithOptions(ChatUserSecAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Agent))
            {
                body["Agent"] = request.Agent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentStagingId))
            {
                body["AttachmentStagingId"] = request.AttachmentStagingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attachments))
            {
                body["Attachments"] = request.Attachments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                body["ExecutionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseLanguage))
            {
                body["ResponseLanguage"] = request.ResponseLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skill))
            {
                body["Skill"] = request.Skill;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["Stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TalkId))
            {
                body["TalkId"] = request.TalkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInputInfo))
            {
                body["UserInputInfo"] = request.UserInputInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatUserSecAgent",
                Version = "2026-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "string",
            };
            return TeaModel.ToObject<ChatUserSecAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Claw SSE Chat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatUserSecAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatUserSecAgentResponse
        /// </returns>
        public async Task<ChatUserSecAgentResponse> ChatUserSecAgentWithOptionsAsync(ChatUserSecAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Agent))
            {
                body["Agent"] = request.Agent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentStagingId))
            {
                body["AttachmentStagingId"] = request.AttachmentStagingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attachments))
            {
                body["Attachments"] = request.Attachments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                body["ExecutionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseLanguage))
            {
                body["ResponseLanguage"] = request.ResponseLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skill))
            {
                body["Skill"] = request.Skill;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["Stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TalkId))
            {
                body["TalkId"] = request.TalkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInputInfo))
            {
                body["UserInputInfo"] = request.UserInputInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatUserSecAgent",
                Version = "2026-06-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "string",
            };
            return TeaModel.ToObject<ChatUserSecAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Claw SSE Chat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatUserSecAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatUserSecAgentResponse
        /// </returns>
        public ChatUserSecAgentResponse ChatUserSecAgent(ChatUserSecAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatUserSecAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Claw SSE Chat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatUserSecAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatUserSecAgentResponse
        /// </returns>
        public async Task<ChatUserSecAgentResponse> ChatUserSecAgentAsync(ChatUserSecAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatUserSecAgentWithOptionsAsync(request, runtime);
        }

    }
}
