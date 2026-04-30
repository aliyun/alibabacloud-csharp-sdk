// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DocumentParseService20260414.Models;

namespace AlibabaCloud.SDK.DocumentParseService20260414
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("documentparseservice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>文档解析测试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocumentParseOnlineApiRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocumentParseOnlineApiResponse
        /// </returns>
        public DocumentParseOnlineApiResponse DocumentParseOnlineApiWithOptions(DocumentParseOnlineApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocumentParseOnlineApi",
                Version = "2026-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocumentParseOnlineApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档解析测试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocumentParseOnlineApiRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocumentParseOnlineApiResponse
        /// </returns>
        public async Task<DocumentParseOnlineApiResponse> DocumentParseOnlineApiWithOptionsAsync(DocumentParseOnlineApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocumentParseOnlineApi",
                Version = "2026-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocumentParseOnlineApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档解析测试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocumentParseOnlineApiRequest
        /// </param>
        /// 
        /// <returns>
        /// DocumentParseOnlineApiResponse
        /// </returns>
        public DocumentParseOnlineApiResponse DocumentParseOnlineApi(DocumentParseOnlineApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DocumentParseOnlineApiWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档解析测试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocumentParseOnlineApiRequest
        /// </param>
        /// 
        /// <returns>
        /// DocumentParseOnlineApiResponse
        /// </returns>
        public async Task<DocumentParseOnlineApiResponse> DocumentParseOnlineApiAsync(DocumentParseOnlineApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DocumentParseOnlineApiWithOptionsAsync(request, runtime);
        }

    }
}
