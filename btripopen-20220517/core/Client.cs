// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.BtripOpen20220517.Models;

namespace AlibabaCloud.SDK.BtripOpen20220517
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("btripopen", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public TakeAccessTokenResponse TakeAccessToken(TakeAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TakeAccessTokenWithOptions(request, headers, runtime);
        }

        public async Task<TakeAccessTokenResponse> TakeAccessTokenAsync(TakeAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TakeAccessTokenWithOptionsAsync(request, headers, runtime);
        }

        public TakeAccessTokenResponse TakeAccessTokenWithOptions(TakeAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["app_key"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["app_secret"] = request.AppSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TakeAccessToken",
                Version = "2022-05-17",
                Protocol = "HTTPS",
                Pathname = "/btrip/open/access-token/take",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TakeAccessTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TakeAccessTokenResponse> TakeAccessTokenWithOptionsAsync(TakeAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["app_key"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["app_secret"] = request.AppSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TakeAccessToken",
                Version = "2022-05-17",
                Protocol = "HTTPS",
                Pathname = "/btrip/open/access-token/take",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TakeAccessTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
