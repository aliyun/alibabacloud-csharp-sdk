// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Actiontrail20171204.Models;

namespace AlibabaCloud.SDK.Actiontrail20171204
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
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

        public CreateTrailResponse CreateTrailWithOptions(CreateTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTrailResponse>(DoRPCRequest("CreateTrail", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTrailResponse> CreateTrailWithOptionsAsync(CreateTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTrailResponse>(await DoRPCRequestAsync("CreateTrail", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTrailResponse CreateTrail(CreateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrailWithOptions(request, runtime);
        }

        public async Task<CreateTrailResponse> CreateTrailAsync(CreateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrailWithOptionsAsync(request, runtime);
        }

        public DeleteTrailResponse DeleteTrailWithOptions(DeleteTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTrailResponse>(DoRPCRequest("DeleteTrail", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTrailResponse> DeleteTrailWithOptionsAsync(DeleteTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTrailResponse>(await DoRPCRequestAsync("DeleteTrail", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTrailResponse DeleteTrail(DeleteTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrailWithOptions(request, runtime);
        }

        public async Task<DeleteTrailResponse> DeleteTrailAsync(DeleteTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrailWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        public DescribeTrailsResponse DescribeTrailsWithOptions(DescribeTrailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTrailsResponse>(DoRPCRequest("DescribeTrails", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTrailsResponse> DescribeTrailsWithOptionsAsync(DescribeTrailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTrailsResponse>(await DoRPCRequestAsync("DescribeTrails", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrailsWithOptions(request, runtime);
        }

        public async Task<DescribeTrailsResponse> DescribeTrailsAsync(DescribeTrailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrailsWithOptionsAsync(request, runtime);
        }

        public GetTrailStatusResponse GetTrailStatusWithOptions(GetTrailStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrailStatusResponse>(DoRPCRequest("GetTrailStatus", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTrailStatusResponse> GetTrailStatusWithOptionsAsync(GetTrailStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTrailStatusResponse>(await DoRPCRequestAsync("GetTrailStatus", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTrailStatusWithOptions(request, runtime);
        }

        public async Task<GetTrailStatusResponse> GetTrailStatusAsync(GetTrailStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTrailStatusWithOptionsAsync(request, runtime);
        }

        public LookupEventsResponse LookupEventsWithOptions(LookupEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LookupEventsResponse>(DoRPCRequest("LookupEvents", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LookupEventsResponse> LookupEventsWithOptionsAsync(LookupEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LookupEventsResponse>(await DoRPCRequestAsync("LookupEvents", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StartLoggingResponse StartLoggingWithOptions(StartLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartLoggingResponse>(DoRPCRequest("StartLogging", "2017-12-04", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StartLoggingResponse> StartLoggingWithOptionsAsync(StartLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartLoggingResponse>(await DoRPCRequestAsync("StartLogging", "2017-12-04", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StartLoggingResponse StartLogging(StartLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartLoggingWithOptions(request, runtime);
        }

        public async Task<StartLoggingResponse> StartLoggingAsync(StartLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartLoggingWithOptionsAsync(request, runtime);
        }

        public StopLoggingResponse StopLoggingWithOptions(StopLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopLoggingResponse>(DoRPCRequest("StopLogging", "2017-12-04", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StopLoggingResponse> StopLoggingWithOptionsAsync(StopLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopLoggingResponse>(await DoRPCRequestAsync("StopLogging", "2017-12-04", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StopLoggingResponse StopLogging(StopLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopLoggingWithOptions(request, runtime);
        }

        public async Task<StopLoggingResponse> StopLoggingAsync(StopLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopLoggingWithOptionsAsync(request, runtime);
        }

        public UpdateTrailResponse UpdateTrailWithOptions(UpdateTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTrailResponse>(DoRPCRequest("UpdateTrail", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTrailResponse> UpdateTrailWithOptionsAsync(UpdateTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTrailResponse>(await DoRPCRequestAsync("UpdateTrail", "2017-12-04", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTrailResponse UpdateTrail(UpdateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTrailWithOptions(request, runtime);
        }

        public async Task<UpdateTrailResponse> UpdateTrailAsync(UpdateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTrailWithOptionsAsync(request, runtime);
        }

    }
}
