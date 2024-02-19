// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Edas20160816.Models;

namespace AlibabaCloud.SDK.Edas20160816
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "edas.ap-northeast-1.aliyuncs.com"},
                {"ap-south-1", "edas.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-3", "edas.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-5", "edas.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "edas.aliyuncs.com"},
                {"cn-beijing-finance-pop", "edas.aliyuncs.com"},
                {"cn-beijing-gov-1", "edas.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "edas.aliyuncs.com"},
                {"cn-chengdu", "edas.aliyuncs.com"},
                {"cn-edge-1", "edas.aliyuncs.com"},
                {"cn-fujian", "edas.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "edas.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "edas.aliyuncs.com"},
                {"cn-hangzhou-finance", "edas.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "edas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "edas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "edas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "edas.aliyuncs.com"},
                {"cn-hangzhou-test-306", "edas.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "edas.aliyuncs.com"},
                {"cn-huhehaote", "edas.aliyuncs.com"},
                {"cn-qingdao-nebula", "edas.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "edas.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "edas.aliyuncs.com"},
                {"cn-shanghai-finance-1", "edas.aliyuncs.com"},
                {"cn-shanghai-inner", "edas.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "edas.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "edas.aliyuncs.com"},
                {"cn-shenzhen-inner", "edas.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "edas.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "edas.aliyuncs.com"},
                {"cn-wuhan", "edas.aliyuncs.com"},
                {"cn-yushanfang", "edas.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "edas.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "edas.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "edas.aliyuncs.com"},
                {"eu-west-1", "edas.ap-northeast-1.aliyuncs.com"},
                {"eu-west-1-oxs", "edas.ap-northeast-1.aliyuncs.com"},
                {"me-east-1", "edas.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "edas.ap-northeast-1.aliyuncs.com"},
                {"us-west-1", "edas.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("edas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public EdasRefundResponse EdasRefundWithOptions(EdasRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EdasRefund",
                Version = "2016-08-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EdasRefundResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EdasRefundResponse> EdasRefundWithOptionsAsync(EdasRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EdasRefund",
                Version = "2016-08-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EdasRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EdasRefundResponse EdasRefund(EdasRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EdasRefundWithOptions(request, runtime);
        }

        public async Task<EdasRefundResponse> EdasRefundAsync(EdasRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EdasRefundWithOptionsAsync(request, runtime);
        }

    }
}
