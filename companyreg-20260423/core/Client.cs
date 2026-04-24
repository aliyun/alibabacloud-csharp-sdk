// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Companyreg20260423.Models;

namespace AlibabaCloud.SDK.Companyreg20260423
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "companyreg.aliyuncs.com"},
                {"ap-northeast-2-pop", "companyreg.aliyuncs.com"},
                {"ap-south-1", "companyreg.aliyuncs.com"},
                {"ap-southeast-1", "companyreg.aliyuncs.com"},
                {"ap-southeast-2", "companyreg.aliyuncs.com"},
                {"ap-southeast-3", "companyreg.aliyuncs.com"},
                {"ap-southeast-5", "companyreg.aliyuncs.com"},
                {"cn-beijing", "companyreg.aliyuncs.com"},
                {"cn-beijing-finance-1", "companyreg.aliyuncs.com"},
                {"cn-beijing-finance-pop", "companyreg.aliyuncs.com"},
                {"cn-beijing-gov-1", "companyreg.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "companyreg.aliyuncs.com"},
                {"cn-chengdu", "companyreg.aliyuncs.com"},
                {"cn-edge-1", "companyreg.aliyuncs.com"},
                {"cn-fujian", "companyreg.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-finance", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-test-306", "companyreg.aliyuncs.com"},
                {"cn-hongkong", "companyreg.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "companyreg.aliyuncs.com"},
                {"cn-huhehaote", "companyreg.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "companyreg.aliyuncs.com"},
                {"cn-north-2-gov-1", "companyreg.aliyuncs.com"},
                {"cn-qingdao", "companyreg.aliyuncs.com"},
                {"cn-qingdao-nebula", "companyreg.aliyuncs.com"},
                {"cn-shanghai", "companyreg.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "companyreg.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "companyreg.aliyuncs.com"},
                {"cn-shanghai-finance-1", "companyreg.aliyuncs.com"},
                {"cn-shanghai-inner", "companyreg.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "companyreg.aliyuncs.com"},
                {"cn-shenzhen", "companyreg.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "companyreg.aliyuncs.com"},
                {"cn-shenzhen-inner", "companyreg.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "companyreg.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "companyreg.aliyuncs.com"},
                {"cn-wuhan", "companyreg.aliyuncs.com"},
                {"cn-wulanchabu", "companyreg.aliyuncs.com"},
                {"cn-yushanfang", "companyreg.aliyuncs.com"},
                {"cn-zhangbei", "companyreg.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "companyreg.aliyuncs.com"},
                {"cn-zhangjiakou", "companyreg.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "companyreg.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "companyreg.aliyuncs.com"},
                {"eu-central-1", "companyreg.aliyuncs.com"},
                {"eu-west-1", "companyreg.aliyuncs.com"},
                {"eu-west-1-oxs", "companyreg.aliyuncs.com"},
                {"me-east-1", "companyreg.aliyuncs.com"},
                {"rus-west-1-pop", "companyreg.aliyuncs.com"},
                {"us-east-1", "companyreg.aliyuncs.com"},
                {"us-west-1", "companyreg.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("companyreg", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>查询已备案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySuccessIcpDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySuccessIcpDataResponse
        /// </returns>
        public QuerySuccessIcpDataResponse QuerySuccessIcpDataWithOptions(QuerySuccessIcpDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySuccessIcpData",
                Version = "2026-04-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySuccessIcpDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已备案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySuccessIcpDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySuccessIcpDataResponse
        /// </returns>
        public async Task<QuerySuccessIcpDataResponse> QuerySuccessIcpDataWithOptionsAsync(QuerySuccessIcpDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySuccessIcpData",
                Version = "2026-04-23",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySuccessIcpDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已备案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySuccessIcpDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySuccessIcpDataResponse
        /// </returns>
        public QuerySuccessIcpDataResponse QuerySuccessIcpData(QuerySuccessIcpDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySuccessIcpDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已备案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySuccessIcpDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySuccessIcpDataResponse
        /// </returns>
        public async Task<QuerySuccessIcpDataResponse> QuerySuccessIcpDataAsync(QuerySuccessIcpDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySuccessIcpDataWithOptionsAsync(request, runtime);
        }

    }
}
