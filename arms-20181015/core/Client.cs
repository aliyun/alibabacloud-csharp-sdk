// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ARMS20181015.Models;

namespace AlibabaCloud.SDK.ARMS20181015
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "arms.aliyuncs.com"},
                {"cn-beijing-finance-1", "arms.aliyuncs.com"},
                {"cn-beijing-finance-pop", "arms.aliyuncs.com"},
                {"cn-beijing-gov-1", "arms.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "arms.aliyuncs.com"},
                {"cn-edge-1", "arms.aliyuncs.com"},
                {"cn-fujian", "arms.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "arms.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "arms.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "arms.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "arms.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "arms.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "arms.aliyuncs.com"},
                {"cn-hangzhou-test-306", "arms.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "arms.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "arms.aliyuncs.com"},
                {"cn-qingdao-nebula", "arms.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "arms.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "arms.aliyuncs.com"},
                {"cn-shanghai-inner", "arms.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "arms.aliyuncs.com"},
                {"cn-shenzhen-inner", "arms.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "arms.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "arms.aliyuncs.com"},
                {"cn-wuhan", "arms.aliyuncs.com"},
                {"cn-yushanfang", "arms.aliyuncs.com"},
                {"cn-zhangbei", "arms.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "arms.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "arms.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "arms.aliyuncs.com"},
                {"eu-west-1-oxs", "arms.aliyuncs.com"},
                {"me-east-1", "arms.aliyuncs.com"},
                {"rus-west-1-pop", "arms.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("arms", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// ARMSQueryDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ARMSQueryDataSetResponse
        /// </returns>
        public ARMSQueryDataSetResponse ARMSQueryDataSetWithOptions(ARMSQueryDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateStr))
            {
                query["DateStr"] = request.DateStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HackerUserId))
            {
                query["HackerUserId"] = request.HackerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HungryMode))
            {
                query["HungryMode"] = request.HungryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntervalInSec))
            {
                query["IntervalInSec"] = request.IntervalInSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDrillDown))
            {
                query["IsDrillDown"] = request.IsDrillDown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTime))
            {
                query["MaxTime"] = request.MaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Measures))
            {
                query["Measures"] = request.Measures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTime))
            {
                query["MinTime"] = request.MinTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionalDims))
            {
                query["OptionalDims"] = request.OptionalDims;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByKey))
            {
                query["OrderByKey"] = request.OrderByKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReduceTail))
            {
                query["ReduceTail"] = request.ReduceTail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequiredDims))
            {
                query["RequiredDims"] = request.RequiredDims;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ARMSQueryDataSet",
                Version = "2018-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ARMSQueryDataSetResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ARMSQueryDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ARMSQueryDataSetResponse
        /// </returns>
        public async Task<ARMSQueryDataSetResponse> ARMSQueryDataSetWithOptionsAsync(ARMSQueryDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateStr))
            {
                query["DateStr"] = request.DateStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HackerUserId))
            {
                query["HackerUserId"] = request.HackerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HungryMode))
            {
                query["HungryMode"] = request.HungryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntervalInSec))
            {
                query["IntervalInSec"] = request.IntervalInSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDrillDown))
            {
                query["IsDrillDown"] = request.IsDrillDown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTime))
            {
                query["MaxTime"] = request.MaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Measures))
            {
                query["Measures"] = request.Measures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTime))
            {
                query["MinTime"] = request.MinTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionalDims))
            {
                query["OptionalDims"] = request.OptionalDims;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByKey))
            {
                query["OrderByKey"] = request.OrderByKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReduceTail))
            {
                query["ReduceTail"] = request.ReduceTail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequiredDims))
            {
                query["RequiredDims"] = request.RequiredDims;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ARMSQueryDataSet",
                Version = "2018-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ARMSQueryDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ARMSQueryDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ARMSQueryDataSetResponse
        /// </returns>
        public ARMSQueryDataSetResponse ARMSQueryDataSet(ARMSQueryDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ARMSQueryDataSetWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ARMSQueryDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ARMSQueryDataSetResponse
        /// </returns>
        public async Task<ARMSQueryDataSetResponse> ARMSQueryDataSetAsync(ARMSQueryDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ARMSQueryDataSetWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// MetricQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MetricQueryResponse
        /// </returns>
        public MetricQueryResponse MetricQueryWithOptions(MetricQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HackerUserId))
            {
                query["HackerUserId"] = request.HackerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IintervalInSec))
            {
                query["IintervalInSec"] = request.IintervalInSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Measures))
            {
                query["Measures"] = request.Measures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                query["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MetricQuery",
                Version = "2018-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MetricQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// MetricQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MetricQueryResponse
        /// </returns>
        public async Task<MetricQueryResponse> MetricQueryWithOptionsAsync(MetricQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HackerUserId))
            {
                query["HackerUserId"] = request.HackerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IintervalInSec))
            {
                query["IintervalInSec"] = request.IintervalInSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Measures))
            {
                query["Measures"] = request.Measures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                query["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MetricQuery",
                Version = "2018-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MetricQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// MetricQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// MetricQueryResponse
        /// </returns>
        public MetricQueryResponse MetricQuery(MetricQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MetricQueryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// MetricQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// MetricQueryResponse
        /// </returns>
        public async Task<MetricQueryResponse> MetricQueryAsync(MetricQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MetricQueryWithOptionsAsync(request, runtime);
        }

    }
}
