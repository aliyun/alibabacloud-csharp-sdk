// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DdosDiversion20230701.Models;

namespace AlibabaCloud.SDK.DdosDiversion20230701
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ddosdiversion", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Configures the advertising of a CIDR block.
         *
         * @param request ConfigNetStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfigNetStatusResponse
         */
        public ConfigNetStatusResponse ConfigNetStatusWithOptions(ConfigNetStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Net))
            {
                query["Net"] = request.Net;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubNets))
            {
                query["SubNets"] = request.SubNets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigNetStatus",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigNetStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Configures the advertising of a CIDR block.
         *
         * @param request ConfigNetStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfigNetStatusResponse
         */
        public async Task<ConfigNetStatusResponse> ConfigNetStatusWithOptionsAsync(ConfigNetStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Net))
            {
                query["Net"] = request.Net;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubNets))
            {
                query["SubNets"] = request.SubNets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigNetStatus",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigNetStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Configures the advertising of a CIDR block.
         *
         * @param request ConfigNetStatusRequest
         * @return ConfigNetStatusResponse
         */
        public ConfigNetStatusResponse ConfigNetStatus(ConfigNetStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigNetStatusWithOptions(request, runtime);
        }

        /**
         * @summary Configures the advertising of a CIDR block.
         *
         * @param request ConfigNetStatusRequest
         * @return ConfigNetStatusResponse
         */
        public async Task<ConfigNetStatusResponse> ConfigNetStatusAsync(ConfigNetStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigNetStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries anti-DDoS diversion instances.
         *
         * @param request ListInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceResponse
         */
        public ListInstanceResponse ListInstanceWithOptions(ListInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstance",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries anti-DDoS diversion instances.
         *
         * @param request ListInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceResponse
         */
        public async Task<ListInstanceResponse> ListInstanceWithOptionsAsync(ListInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstance",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries anti-DDoS diversion instances.
         *
         * @param request ListInstanceRequest
         * @return ListInstanceResponse
         */
        public ListInstanceResponse ListInstance(ListInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries anti-DDoS diversion instances.
         *
         * @param request ListInstanceRequest
         * @return ListInstanceResponse
         */
        public async Task<ListInstanceResponse> ListInstanceAsync(ListInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the CIDR blocks of an anti-DDoS diversion instance.
         *
         * @param request QueryNetListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryNetListResponse
         */
        public QueryNetListResponse QueryNetListWithOptions(QueryNetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainNet))
            {
                query["MainNet"] = request.MainNet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Net))
            {
                query["Net"] = request.Net;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryNetList",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryNetListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the CIDR blocks of an anti-DDoS diversion instance.
         *
         * @param request QueryNetListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryNetListResponse
         */
        public async Task<QueryNetListResponse> QueryNetListWithOptionsAsync(QueryNetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainNet))
            {
                query["MainNet"] = request.MainNet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Net))
            {
                query["Net"] = request.Net;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Num))
            {
                query["Num"] = request.Num;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryNetList",
                Version = "2023-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryNetListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the CIDR blocks of an anti-DDoS diversion instance.
         *
         * @param request QueryNetListRequest
         * @return QueryNetListResponse
         */
        public QueryNetListResponse QueryNetList(QueryNetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryNetListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the CIDR blocks of an anti-DDoS diversion instance.
         *
         * @param request QueryNetListRequest
         * @return QueryNetListResponse
         */
        public async Task<QueryNetListResponse> QueryNetListAsync(QueryNetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryNetListWithOptionsAsync(request, runtime);
        }

    }
}
