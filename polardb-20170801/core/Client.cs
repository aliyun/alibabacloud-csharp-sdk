// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Polardb20170801.Models;

namespace AlibabaCloud.SDK.Polardb20170801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "polardb.aliyuncs.com"},
                {"cn-beijing", "polardb.aliyuncs.com"},
                {"cn-hangzhou", "polardb.aliyuncs.com"},
                {"cn-shanghai", "polardb.aliyuncs.com"},
                {"cn-shenzhen", "polardb.aliyuncs.com"},
                {"cn-hongkong", "polardb.aliyuncs.com"},
                {"ap-southeast-1", "polardb.aliyuncs.com"},
                {"us-west-1", "polardb.aliyuncs.com"},
                {"us-east-1", "polardb.aliyuncs.com"},
                {"cn-hangzhou-finance", "polardb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "polardb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "polardb.aliyuncs.com"},
                {"ap-northeast-2-pop", "polardb.aliyuncs.com"},
                {"cn-beijing-finance-1", "polardb.aliyuncs.com"},
                {"cn-beijing-finance-pop", "polardb.aliyuncs.com"},
                {"cn-beijing-gov-1", "polardb.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "polardb.aliyuncs.com"},
                {"cn-edge-1", "polardb.aliyuncs.com"},
                {"cn-fujian", "polardb.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "polardb.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "polardb.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "polardb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "polardb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "polardb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "polardb.aliyuncs.com"},
                {"cn-hangzhou-test-306", "polardb.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "polardb.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "polardb.aliyuncs.com"},
                {"cn-north-2-gov-1", "polardb.aliyuncs.com"},
                {"cn-qingdao-nebula", "polardb.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "polardb.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "polardb.aliyuncs.com"},
                {"cn-shanghai-inner", "polardb.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "polardb.aliyuncs.com"},
                {"cn-shenzhen-inner", "polardb.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "polardb.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "polardb.aliyuncs.com"},
                {"cn-wuhan", "polardb.aliyuncs.com"},
                {"cn-wulanchabu", "polardb.aliyuncs.com"},
                {"cn-yushanfang", "polardb.aliyuncs.com"},
                {"cn-zhangbei", "polardb.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "polardb.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "polardb.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "polardb.aliyuncs.com"},
                {"eu-west-1-oxs", "polardb.aliyuncs.com"},
                {"rus-west-1-pop", "polardb.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("polardb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ModifyDBClusterMonitorResponse ModifyDBClusterMonitorWithOptions(ModifyDBClusterMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterMonitorResponse>(DoRPCRequest("ModifyDBClusterMonitor", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBClusterMonitorResponse> ModifyDBClusterMonitorWithOptionsAsync(ModifyDBClusterMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBClusterMonitorResponse>(await DoRPCRequestAsync("ModifyDBClusterMonitor", "2017-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBClusterMonitorResponse ModifyDBClusterMonitor(ModifyDBClusterMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterMonitorWithOptions(request, runtime);
        }

        public async Task<ModifyDBClusterMonitorResponse> ModifyDBClusterMonitorAsync(ModifyDBClusterMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterMonitorWithOptionsAsync(request, runtime);
        }

    }
}
