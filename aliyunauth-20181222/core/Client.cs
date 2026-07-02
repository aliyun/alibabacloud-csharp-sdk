// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AliyunAuth20181222.Models;

namespace AlibabaCloud.SDK.AliyunAuth20181222
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aliyunauth", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// AuthenticateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthenticateResponse
        /// </returns>
        public AuthenticateResponse AuthenticateWithOptions(AuthenticateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Authenticate",
                Version = "2018-12-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthenticateResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthenticateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthenticateResponse
        /// </returns>
        public async Task<AuthenticateResponse> AuthenticateWithOptionsAsync(AuthenticateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Authenticate",
                Version = "2018-12-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthenticateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AuthenticateRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthenticateResponse
        /// </returns>
        public AuthenticateResponse Authenticate(AuthenticateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthenticateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AuthenticateRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthenticateResponse
        /// </returns>
        public async Task<AuthenticateResponse> AuthenticateAsync(AuthenticateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthenticateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetDetailByOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDetailByOrderResponse
        /// </returns>
        public GetDetailByOrderResponse GetDetailByOrderWithOptions(GetDetailByOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acceptor))
            {
                query["Acceptor"] = request.Acceptor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizNo))
            {
                query["BizNo"] = request.BizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckAuthItems))
            {
                query["CheckAuthItems"] = request.CheckAuthItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmpId))
            {
                query["EmpId"] = request.EmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptSource))
            {
                query["OptSource"] = request.OptSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDetailByOrder",
                Version = "2018-12-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDetailByOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetDetailByOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDetailByOrderResponse
        /// </returns>
        public async Task<GetDetailByOrderResponse> GetDetailByOrderWithOptionsAsync(GetDetailByOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acceptor))
            {
                query["Acceptor"] = request.Acceptor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizNo))
            {
                query["BizNo"] = request.BizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckAuthItems))
            {
                query["CheckAuthItems"] = request.CheckAuthItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmpId))
            {
                query["EmpId"] = request.EmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptSource))
            {
                query["OptSource"] = request.OptSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDetailByOrder",
                Version = "2018-12-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDetailByOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetDetailByOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDetailByOrderResponse
        /// </returns>
        public GetDetailByOrderResponse GetDetailByOrder(GetDetailByOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDetailByOrderWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetDetailByOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDetailByOrderResponse
        /// </returns>
        public async Task<GetDetailByOrderResponse> GetDetailByOrderAsync(GetDetailByOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDetailByOrderWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAuthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAuthResponse
        /// </returns>
        public QueryAuthResponse QueryAuthWithOptions(QueryAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuth",
                Version = "2018-12-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuthResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAuthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAuthResponse
        /// </returns>
        public async Task<QueryAuthResponse> QueryAuthWithOptionsAsync(QueryAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuth",
                Version = "2018-12-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAuthResponse
        /// </returns>
        public QueryAuthResponse QueryAuth(QueryAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAuthWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAuthResponse
        /// </returns>
        public async Task<QueryAuthResponse> QueryAuthAsync(QueryAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAuthWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryInEffectQuthOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInEffectQuthOrderResponse
        /// </returns>
        public QueryInEffectQuthOrderResponse QueryInEffectQuthOrderWithOptions(QueryInEffectQuthOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInEffectQuthOrder",
                Version = "2018-12-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInEffectQuthOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryInEffectQuthOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInEffectQuthOrderResponse
        /// </returns>
        public async Task<QueryInEffectQuthOrderResponse> QueryInEffectQuthOrderWithOptionsAsync(QueryInEffectQuthOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInEffectQuthOrder",
                Version = "2018-12-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInEffectQuthOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryInEffectQuthOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInEffectQuthOrderResponse
        /// </returns>
        public QueryInEffectQuthOrderResponse QueryInEffectQuthOrder(QueryInEffectQuthOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInEffectQuthOrderWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryInEffectQuthOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInEffectQuthOrderResponse
        /// </returns>
        public async Task<QueryInEffectQuthOrderResponse> QueryInEffectQuthOrderAsync(QueryInEffectQuthOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInEffectQuthOrderWithOptionsAsync(request, runtime);
        }

    }
}
