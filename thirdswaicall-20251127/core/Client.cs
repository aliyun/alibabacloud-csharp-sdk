// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ThirdswAicall20251127.Models;

namespace AlibabaCloud.SDK.ThirdswAicall20251127
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("thirdswaicall", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>外呼任务通话列表查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ReadOutboundTaskCallListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadOutboundTaskCallListResponse
        /// </returns>
        public ReadOutboundTaskCallListResponse ReadOutboundTaskCallListWithOptions(ReadOutboundTaskCallListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReadOutboundTaskCallListShrinkRequest request = new ReadOutboundTaskCallListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DisplayStatusList))
            {
                request.DisplayStatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DisplayStatusList, "DisplayStatusList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelTags))
            {
                request.LabelTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelTags, "LabelTags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerNameOrPhone))
            {
                body["CustomerNameOrPhone"] = request.CustomerNameOrPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayStatusListShrink))
            {
                body["DisplayStatusList"] = request.DisplayStatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTagsShrink))
            {
                body["LabelTags"] = request.LabelTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadOutboundTaskCallList",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadOutboundTaskCallListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼任务通话列表查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ReadOutboundTaskCallListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadOutboundTaskCallListResponse
        /// </returns>
        public async Task<ReadOutboundTaskCallListResponse> ReadOutboundTaskCallListWithOptionsAsync(ReadOutboundTaskCallListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReadOutboundTaskCallListShrinkRequest request = new ReadOutboundTaskCallListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DisplayStatusList))
            {
                request.DisplayStatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DisplayStatusList, "DisplayStatusList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelTags))
            {
                request.LabelTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelTags, "LabelTags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerNameOrPhone))
            {
                body["CustomerNameOrPhone"] = request.CustomerNameOrPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayStatusListShrink))
            {
                body["DisplayStatusList"] = request.DisplayStatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTagsShrink))
            {
                body["LabelTags"] = request.LabelTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadOutboundTaskCallList",
                Version = "2025-11-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadOutboundTaskCallListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼任务通话列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadOutboundTaskCallListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadOutboundTaskCallListResponse
        /// </returns>
        public ReadOutboundTaskCallListResponse ReadOutboundTaskCallList(ReadOutboundTaskCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadOutboundTaskCallListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外呼任务通话列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReadOutboundTaskCallListRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadOutboundTaskCallListResponse
        /// </returns>
        public async Task<ReadOutboundTaskCallListResponse> ReadOutboundTaskCallListAsync(ReadOutboundTaskCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadOutboundTaskCallListWithOptionsAsync(request, runtime);
        }

    }
}
