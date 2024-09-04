// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.TrafficFxOpen20240815.Models;

namespace AlibabaCloud.SDK.TrafficFxOpen20240815
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("trafficfxopen", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary 转换联登链接
         *
         * @param request ConvertUrlRequest
         * @param headers ConvertUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConvertUrlResponse
         */
        public ConvertUrlResponse ConvertUrlWithOptions(ConvertUrlRequest request, ConvertUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCallingCode))
            {
                body["countryCallingCode"] = request.CountryCallingCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JumpUrl))
            {
                body["jumpUrl"] = request.JumpUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdId))
            {
                body["thirdId"] = request.ThirdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Xenv))
            {
                body["xenv"] = request.Xenv;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["xAcsAirticketAccessToken"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["xAcsAirticketLanguage"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertUrl",
                Version = "2024-08-15",
                Protocol = "HTTPS",
                Pathname = "/v1/distribution/trade/convertUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 转换联登链接
         *
         * @param request ConvertUrlRequest
         * @param headers ConvertUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConvertUrlResponse
         */
        public async Task<ConvertUrlResponse> ConvertUrlWithOptionsAsync(ConvertUrlRequest request, ConvertUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCallingCode))
            {
                body["countryCallingCode"] = request.CountryCallingCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JumpUrl))
            {
                body["jumpUrl"] = request.JumpUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdId))
            {
                body["thirdId"] = request.ThirdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Xenv))
            {
                body["xenv"] = request.Xenv;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["xAcsAirticketAccessToken"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["xAcsAirticketLanguage"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertUrl",
                Version = "2024-08-15",
                Protocol = "HTTPS",
                Pathname = "/v1/distribution/trade/convertUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 转换联登链接
         *
         * @param request ConvertUrlRequest
         * @return ConvertUrlResponse
         */
        public ConvertUrlResponse ConvertUrl(ConvertUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConvertUrlHeaders headers = new ConvertUrlHeaders();
            return ConvertUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 转换联登链接
         *
         * @param request ConvertUrlRequest
         * @return ConvertUrlResponse
         */
        public async Task<ConvertUrlResponse> ConvertUrlAsync(ConvertUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConvertUrlHeaders headers = new ConvertUrlHeaders();
            return await ConvertUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建token
         *
         * @param request GetTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTokenResponse
         */
        public GetTokenResponse GetTokenWithOptions(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["appSecret"] = request.AppSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2024-08-15",
                Protocol = "HTTPS",
                Pathname = "/v1/distribution/trade/getToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建token
         *
         * @param request GetTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTokenResponse
         */
        public async Task<GetTokenResponse> GetTokenWithOptionsAsync(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                query["appSecret"] = request.AppSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2024-08-15",
                Protocol = "HTTPS",
                Pathname = "/v1/distribution/trade/getToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建token
         *
         * @param request GetTokenRequest
         * @return GetTokenResponse
         */
        public GetTokenResponse GetToken(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建token
         *
         * @param request GetTokenRequest
         * @return GetTokenResponse
         */
        public async Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分销报价接口
         *
         * @param request SearchRequest
         * @param headers SearchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchResponse
         */
        public SearchResponse SearchWithOptions(SearchRequest request, SearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParam))
            {
                body["searchParam"] = request.SearchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Terminal))
            {
                body["terminal"] = request.Terminal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["xAcsAirticketAccessToken"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["xAcsAirticketLanguage"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Search",
                Version = "2024-08-15",
                Protocol = "HTTPS",
                Pathname = "/v1/distribution/trade/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 分销报价接口
         *
         * @param request SearchRequest
         * @param headers SearchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchResponse
         */
        public async Task<SearchResponse> SearchWithOptionsAsync(SearchRequest request, SearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParam))
            {
                body["searchParam"] = request.SearchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Terminal))
            {
                body["terminal"] = request.Terminal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketAccessToken))
            {
                realHeaders["xAcsAirticketAccessToken"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAirticketLanguage))
            {
                realHeaders["xAcsAirticketLanguage"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAirticketLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Search",
                Version = "2024-08-15",
                Protocol = "HTTPS",
                Pathname = "/v1/distribution/trade/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 分销报价接口
         *
         * @param request SearchRequest
         * @return SearchResponse
         */
        public SearchResponse Search(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchHeaders headers = new SearchHeaders();
            return SearchWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分销报价接口
         *
         * @param request SearchRequest
         * @return SearchResponse
         */
        public async Task<SearchResponse> SearchAsync(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchHeaders headers = new SearchHeaders();
            return await SearchWithOptionsAsync(request, headers, runtime);
        }

    }
}
