// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Actiontrail20200706.Models;

namespace AlibabaCloud.SDK.Actiontrail20200706
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "actiontrail.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "actiontrail.aliyuncs.com"},
                {"cn-beijing-finance-pop", "actiontrail.aliyuncs.com"},
                {"cn-beijing-gov-1", "actiontrail.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "actiontrail.aliyuncs.com"},
                {"cn-edge-1", "actiontrail.aliyuncs.com"},
                {"cn-fujian", "actiontrail.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-finance", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-test-306", "actiontrail.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "actiontrail.aliyuncs.com"},
                {"cn-qingdao-nebula", "actiontrail.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "actiontrail.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "actiontrail.aliyuncs.com"},
                {"cn-shanghai-inner", "actiontrail.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "actiontrail.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "actiontrail.aliyuncs.com"},
                {"cn-shenzhen-inner", "actiontrail.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "actiontrail.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "actiontrail.aliyuncs.com"},
                {"cn-wuhan", "actiontrail.aliyuncs.com"},
                {"cn-yushanfang", "actiontrail.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "actiontrail.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "actiontrail.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "actiontrail.aliyuncs.com"},
                {"eu-west-1-oxs", "actiontrail.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "actiontrail.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("actiontrail", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public ListDeliveryHistoryJobsResponse ListDeliveryHistoryJobsWithOptions(ListDeliveryHistoryJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDeliveryHistoryJobsResponse>(DoRequest("ListDeliveryHistoryJobs", "HTTPS", "POST", "2020-07-06", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDeliveryHistoryJobsResponse> ListDeliveryHistoryJobsWithOptionsAsync(ListDeliveryHistoryJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDeliveryHistoryJobsResponse>(await DoRequestAsync("ListDeliveryHistoryJobs", "HTTPS", "POST", "2020-07-06", "AK", null, request.ToMap(), runtime));
        }

        public ListDeliveryHistoryJobsResponse ListDeliveryHistoryJobs(ListDeliveryHistoryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeliveryHistoryJobsWithOptions(request, runtime);
        }

        public async Task<ListDeliveryHistoryJobsResponse> ListDeliveryHistoryJobsAsync(ListDeliveryHistoryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeliveryHistoryJobsWithOptionsAsync(request, runtime);
        }

        public CreateDeliveryHistoryJobResponse CreateDeliveryHistoryJobWithOptions(CreateDeliveryHistoryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeliveryHistoryJobResponse>(DoRequest("CreateDeliveryHistoryJob", "HTTPS", "POST", "2020-07-06", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDeliveryHistoryJobResponse> CreateDeliveryHistoryJobWithOptionsAsync(CreateDeliveryHistoryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeliveryHistoryJobResponse>(await DoRequestAsync("CreateDeliveryHistoryJob", "HTTPS", "POST", "2020-07-06", "AK", null, request.ToMap(), runtime));
        }

        public CreateDeliveryHistoryJobResponse CreateDeliveryHistoryJob(CreateDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeliveryHistoryJobWithOptions(request, runtime);
        }

        public async Task<CreateDeliveryHistoryJobResponse> CreateDeliveryHistoryJobAsync(CreateDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeliveryHistoryJobWithOptionsAsync(request, runtime);
        }

        public LookupEventsResponse LookupEventsWithOptions(LookupEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<LookupEventsResponse>(DoRequest("LookupEvents", "HTTPS", "POST", "2020-07-06", "AK", null, request.ToMap(), runtime));
        }

        public async Task<LookupEventsResponse> LookupEventsWithOptionsAsync(LookupEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<LookupEventsResponse>(await DoRequestAsync("LookupEvents", "HTTPS", "POST", "2020-07-06", "AK", null, request.ToMap(), runtime));
        }

        public LookupEventsResponse LookupEvents(LookupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LookupEventsWithOptions(request, runtime);
        }

        public async Task<LookupEventsResponse> LookupEventsAsync(LookupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LookupEventsWithOptionsAsync(request, runtime);
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

    }
}
