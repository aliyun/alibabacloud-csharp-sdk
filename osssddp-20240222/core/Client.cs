// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OssSddp20240222.Models;

namespace AlibabaCloud.SDK.OssSddp20240222
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("osssddp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 查看用户的敏感数据保护版本信息
         *
         * @param request GetSddpVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSddpVersionResponse
         */
        public GetSddpVersionResponse GetSddpVersionWithOptions(GetSddpVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSddpVersion",
                Version = "2024-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSddpVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看用户的敏感数据保护版本信息
         *
         * @param request GetSddpVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSddpVersionResponse
         */
        public async Task<GetSddpVersionResponse> GetSddpVersionWithOptionsAsync(GetSddpVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSddpVersion",
                Version = "2024-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSddpVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看用户的敏感数据保护版本信息
         *
         * @param request GetSddpVersionRequest
         * @return GetSddpVersionResponse
         */
        public GetSddpVersionResponse GetSddpVersion(GetSddpVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSddpVersionWithOptions(request, runtime);
        }

        /**
         * @summary 查看用户的敏感数据保护版本信息
         *
         * @param request GetSddpVersionRequest
         * @return GetSddpVersionResponse
         */
        public async Task<GetSddpVersionResponse> GetSddpVersionAsync(GetSddpVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSddpVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 升级敏感数据保护版本
         *
         * @param request UpgradeSddpVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeSddpVersionResponse
         */
        public UpgradeSddpVersionResponse UpgradeSddpVersionWithOptions(UpgradeSddpVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssVersion))
            {
                query["OssVersion"] = request.OssVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeSddpVersion",
                Version = "2024-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeSddpVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 升级敏感数据保护版本
         *
         * @param request UpgradeSddpVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeSddpVersionResponse
         */
        public async Task<UpgradeSddpVersionResponse> UpgradeSddpVersionWithOptionsAsync(UpgradeSddpVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssVersion))
            {
                query["OssVersion"] = request.OssVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeSddpVersion",
                Version = "2024-02-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeSddpVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 升级敏感数据保护版本
         *
         * @param request UpgradeSddpVersionRequest
         * @return UpgradeSddpVersionResponse
         */
        public UpgradeSddpVersionResponse UpgradeSddpVersion(UpgradeSddpVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeSddpVersionWithOptions(request, runtime);
        }

        /**
         * @summary 升级敏感数据保护版本
         *
         * @param request UpgradeSddpVersionRequest
         * @return UpgradeSddpVersionResponse
         */
        public async Task<UpgradeSddpVersionResponse> UpgradeSddpVersionAsync(UpgradeSddpVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeSddpVersionWithOptionsAsync(request, runtime);
        }

    }
}
