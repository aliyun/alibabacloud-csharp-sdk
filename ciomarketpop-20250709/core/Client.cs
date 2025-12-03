// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CioMarketPop20250709.Models;

namespace AlibabaCloud.SDK.CioMarketPop20250709
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ciomarketpop", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>全员营销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEveryOneSellsFormListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEveryOneSellsFormListResponse
        /// </returns>
        public GetEveryOneSellsFormListResponse GetEveryOneSellsFormListWithOptions(GetEveryOneSellsFormListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEveryOneSellsFormList",
                Version = "2025-07-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetEveryOneSellsFormListResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全员营销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEveryOneSellsFormListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEveryOneSellsFormListResponse
        /// </returns>
        public async Task<GetEveryOneSellsFormListResponse> GetEveryOneSellsFormListWithOptionsAsync(GetEveryOneSellsFormListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEveryOneSellsFormList",
                Version = "2025-07-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetEveryOneSellsFormListResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全员营销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEveryOneSellsFormListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEveryOneSellsFormListResponse
        /// </returns>
        public GetEveryOneSellsFormListResponse GetEveryOneSellsFormList(GetEveryOneSellsFormListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEveryOneSellsFormListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全员营销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEveryOneSellsFormListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEveryOneSellsFormListResponse
        /// </returns>
        public async Task<GetEveryOneSellsFormListResponse> GetEveryOneSellsFormListAsync(GetEveryOneSellsFormListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEveryOneSellsFormListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送钉钉消息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushEveryOneSellMsgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushEveryOneSellMsgResponse
        /// </returns>
        public PushEveryOneSellMsgResponse PushEveryOneSellMsgWithOptions(PushEveryOneSellMsgRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushEveryOneSellMsgShrinkRequest request = new PushEveryOneSellMsgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DingIdList))
            {
                request.DingIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DingIdList, "DingIdList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIdListShrink))
            {
                body["DingIdList"] = request.DingIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushMsg))
            {
                body["PushMsg"] = request.PushMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                body["PushType"] = request.PushType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushEveryOneSellMsg",
                Version = "2025-07-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "string",
            };
            return TeaModel.ToObject<PushEveryOneSellMsgResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送钉钉消息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushEveryOneSellMsgRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushEveryOneSellMsgResponse
        /// </returns>
        public async Task<PushEveryOneSellMsgResponse> PushEveryOneSellMsgWithOptionsAsync(PushEveryOneSellMsgRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushEveryOneSellMsgShrinkRequest request = new PushEveryOneSellMsgShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DingIdList))
            {
                request.DingIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DingIdList, "DingIdList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIdListShrink))
            {
                body["DingIdList"] = request.DingIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushMsg))
            {
                body["PushMsg"] = request.PushMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                body["PushType"] = request.PushType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushEveryOneSellMsg",
                Version = "2025-07-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "string",
            };
            return TeaModel.ToObject<PushEveryOneSellMsgResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送钉钉消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushEveryOneSellMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// PushEveryOneSellMsgResponse
        /// </returns>
        public PushEveryOneSellMsgResponse PushEveryOneSellMsg(PushEveryOneSellMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushEveryOneSellMsgWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送钉钉消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushEveryOneSellMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// PushEveryOneSellMsgResponse
        /// </returns>
        public async Task<PushEveryOneSellMsgResponse> PushEveryOneSellMsgAsync(PushEveryOneSellMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushEveryOneSellMsgWithOptionsAsync(request, runtime);
        }

    }
}
