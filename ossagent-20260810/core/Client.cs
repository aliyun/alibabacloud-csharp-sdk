// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OssAgent20260810.Models;

namespace AlibabaCloud.SDK.OssAgent20260810
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ossagent", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>A2A接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// A2aRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// A2aResponse
        /// </returns>
        public A2aResponse A2aWithOptions(A2aRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                body["jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "a2a",
                Version = "2026-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "any",
            };
            return TeaModel.ToObject<A2aResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A2A接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// A2aRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// A2aResponse
        /// </returns>
        public async Task<A2aResponse> A2aWithOptionsAsync(A2aRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                body["jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "a2a",
                Version = "2026-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "any",
            };
            return TeaModel.ToObject<A2aResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A2A接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// A2aRequest
        /// </param>
        /// 
        /// <returns>
        /// A2aResponse
        /// </returns>
        public A2aResponse A2a(A2aRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return A2aWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A2A接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// A2aRequest
        /// </param>
        /// 
        /// <returns>
        /// A2aResponse
        /// </returns>
        public async Task<A2aResponse> A2aAsync(A2aRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await A2aWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agent_Card</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgentCardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgentCardResponse
        /// </returns>
        public AgentCardResponse Agent_cardWithOptions(AgentCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "agent_card",
                Version = "2026-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "any",
            };
            return TeaModel.ToObject<AgentCardResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agent_Card</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgentCardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AgentCardResponse
        /// </returns>
        public async Task<AgentCardResponse> Agent_cardWithOptionsAsync(AgentCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "agent_card",
                Version = "2026-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "any",
            };
            return TeaModel.ToObject<AgentCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agent_Card</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgentCardRequest
        /// </param>
        /// 
        /// <returns>
        /// AgentCardResponse
        /// </returns>
        public AgentCardResponse Agent_card(AgentCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Agent_cardWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Agent_Card</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AgentCardRequest
        /// </param>
        /// 
        /// <returns>
        /// AgentCardResponse
        /// </returns>
        public async Task<AgentCardResponse> Agent_cardAsync(AgentCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Agent_cardWithOptionsAsync(request, runtime);
        }

    }
}
