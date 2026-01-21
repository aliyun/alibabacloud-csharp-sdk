// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Bsn20150512.Models;

namespace AlibabaCloud.SDK.Bsn20150512
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("bsn", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <param name="request">
        /// GetBsnByResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBsnByResourceResponse
        /// </returns>
        public GetBsnByResourceResponse GetBsnByResourceWithOptions(GetBsnByResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aliuid))
            {
                query["aliuid"] = request.Aliuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBsnByResource",
                Version = "2015-05-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBsnByResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetBsnByResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBsnByResourceResponse
        /// </returns>
        public async Task<GetBsnByResourceResponse> GetBsnByResourceWithOptionsAsync(GetBsnByResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aliuid))
            {
                query["aliuid"] = request.Aliuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBsnByResource",
                Version = "2015-05-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBsnByResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetBsnByResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBsnByResourceResponse
        /// </returns>
        public GetBsnByResourceResponse GetBsnByResource(GetBsnByResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBsnByResourceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetBsnByResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBsnByResourceResponse
        /// </returns>
        public async Task<GetBsnByResourceResponse> GetBsnByResourceAsync(GetBsnByResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBsnByResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权服务码，供虚商使用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantBsnCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantBsnCodeResponse
        /// </returns>
        public GrantBsnCodeResponse GrantBsnCodeWithOptions(GrantBsnCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantToAliuid))
            {
                query["GrantToAliuid"] = request.GrantToAliuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notes))
            {
                query["Notes"] = request.Notes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantBsnCode",
                Version = "2015-05-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantBsnCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权服务码，供虚商使用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantBsnCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantBsnCodeResponse
        /// </returns>
        public async Task<GrantBsnCodeResponse> GrantBsnCodeWithOptionsAsync(GrantBsnCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantToAliuid))
            {
                query["GrantToAliuid"] = request.GrantToAliuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notes))
            {
                query["Notes"] = request.Notes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantBsnCode",
                Version = "2015-05-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantBsnCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权服务码，供虚商使用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantBsnCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantBsnCodeResponse
        /// </returns>
        public GrantBsnCodeResponse GrantBsnCode(GrantBsnCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantBsnCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权服务码，供虚商使用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantBsnCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantBsnCodeResponse
        /// </returns>
        public async Task<GrantBsnCodeResponse> GrantBsnCodeAsync(GrantBsnCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantBsnCodeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ProductBindBsnRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProductBindBsnResponse
        /// </returns>
        public ProductBindBsnResponse ProductBindBsnWithOptions(ProductBindBsnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aliuid))
            {
                query["aliuid"] = request.Aliuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProductBindBsn",
                Version = "2015-05-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProductBindBsnResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ProductBindBsnRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProductBindBsnResponse
        /// </returns>
        public async Task<ProductBindBsnResponse> ProductBindBsnWithOptionsAsync(ProductBindBsnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aliuid))
            {
                query["aliuid"] = request.Aliuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProductBindBsn",
                Version = "2015-05-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProductBindBsnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ProductBindBsnRequest
        /// </param>
        /// 
        /// <returns>
        /// ProductBindBsnResponse
        /// </returns>
        public ProductBindBsnResponse ProductBindBsn(ProductBindBsnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProductBindBsnWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ProductBindBsnRequest
        /// </param>
        /// 
        /// <returns>
        /// ProductBindBsnResponse
        /// </returns>
        public async Task<ProductBindBsnResponse> ProductBindBsnAsync(ProductBindBsnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProductBindBsnWithOptionsAsync(request, runtime);
        }

    }
}
