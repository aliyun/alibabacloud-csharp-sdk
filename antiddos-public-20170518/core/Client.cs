// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Antiddos_public20170518.Models;

namespace AlibabaCloud.SDK.Antiddos_public20170518
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("antiddos-public", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DescribeBgpPackByIpResponse DescribeBgpPackByIpWithOptions(DescribeBgpPackByIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpPackByIpResponse>(DoRPCRequest("DescribeBgpPackByIp", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBgpPackByIpResponse> DescribeBgpPackByIpWithOptionsAsync(DescribeBgpPackByIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpPackByIpResponse>(await DoRPCRequestAsync("DescribeBgpPackByIp", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBgpPackByIpResponse DescribeBgpPackByIp(DescribeBgpPackByIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBgpPackByIpWithOptions(request, runtime);
        }

        public async Task<DescribeBgpPackByIpResponse> DescribeBgpPackByIpAsync(DescribeBgpPackByIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBgpPackByIpWithOptionsAsync(request, runtime);
        }

        public DescribeBgpPackElasticThresholdResponse DescribeBgpPackElasticThresholdWithOptions(DescribeBgpPackElasticThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpPackElasticThresholdResponse>(DoRPCRequest("DescribeBgpPackElasticThreshold", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBgpPackElasticThresholdResponse> DescribeBgpPackElasticThresholdWithOptionsAsync(DescribeBgpPackElasticThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpPackElasticThresholdResponse>(await DoRPCRequestAsync("DescribeBgpPackElasticThreshold", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBgpPackElasticThresholdResponse DescribeBgpPackElasticThreshold(DescribeBgpPackElasticThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBgpPackElasticThresholdWithOptions(request, runtime);
        }

        public async Task<DescribeBgpPackElasticThresholdResponse> DescribeBgpPackElasticThresholdAsync(DescribeBgpPackElasticThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBgpPackElasticThresholdWithOptionsAsync(request, runtime);
        }

        public DescribeCapResponse DescribeCapWithOptions(DescribeCapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCapResponse>(DoRPCRequest("DescribeCap", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCapResponse> DescribeCapWithOptionsAsync(DescribeCapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCapResponse>(await DoRPCRequestAsync("DescribeCap", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCapResponse DescribeCap(DescribeCapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCapWithOptions(request, runtime);
        }

        public async Task<DescribeCapResponse> DescribeCapAsync(DescribeCapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCapWithOptionsAsync(request, runtime);
        }

        public DescribeCreditInfoResponse DescribeCreditInfoWithOptions(DescribeCreditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCreditInfoResponse>(DoRPCRequest("DescribeCreditInfo", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCreditInfoResponse> DescribeCreditInfoWithOptionsAsync(DescribeCreditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCreditInfoResponse>(await DoRPCRequestAsync("DescribeCreditInfo", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCreditInfoResponse DescribeCreditInfo(DescribeCreditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCreditInfoWithOptions(request, runtime);
        }

        public async Task<DescribeCreditInfoResponse> DescribeCreditInfoAsync(DescribeCreditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCreditInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDdosCountResponse DescribeDdosCountWithOptions(DescribeDdosCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosCountResponse>(DoRPCRequest("DescribeDdosCount", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDdosCountResponse> DescribeDdosCountWithOptionsAsync(DescribeDdosCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosCountResponse>(await DoRPCRequestAsync("DescribeDdosCount", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDdosCountResponse DescribeDdosCount(DescribeDdosCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosCountWithOptions(request, runtime);
        }

        public async Task<DescribeDdosCountResponse> DescribeDdosCountAsync(DescribeDdosCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosCountWithOptionsAsync(request, runtime);
        }

        public DescribeDdosCreditResponse DescribeDdosCreditWithOptions(DescribeDdosCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosCreditResponse>(DoRPCRequest("DescribeDdosCredit", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDdosCreditResponse> DescribeDdosCreditWithOptionsAsync(DescribeDdosCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosCreditResponse>(await DoRPCRequestAsync("DescribeDdosCredit", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDdosCreditResponse DescribeDdosCredit(DescribeDdosCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosCreditWithOptions(request, runtime);
        }

        public async Task<DescribeDdosCreditResponse> DescribeDdosCreditAsync(DescribeDdosCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosCreditWithOptionsAsync(request, runtime);
        }

        public DescribeDdosEventListResponse DescribeDdosEventListWithOptions(DescribeDdosEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosEventListResponse>(DoRPCRequest("DescribeDdosEventList", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDdosEventListResponse> DescribeDdosEventListWithOptionsAsync(DescribeDdosEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosEventListResponse>(await DoRPCRequestAsync("DescribeDdosEventList", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDdosEventListResponse DescribeDdosEventList(DescribeDdosEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosEventListWithOptions(request, runtime);
        }

        public async Task<DescribeDdosEventListResponse> DescribeDdosEventListAsync(DescribeDdosEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosEventListWithOptionsAsync(request, runtime);
        }

        public DescribeDdosThresholdResponse DescribeDdosThresholdWithOptions(DescribeDdosThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosThresholdResponse>(DoRPCRequest("DescribeDdosThreshold", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDdosThresholdResponse> DescribeDdosThresholdWithOptionsAsync(DescribeDdosThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosThresholdResponse>(await DoRPCRequestAsync("DescribeDdosThreshold", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDdosThresholdResponse DescribeDdosThreshold(DescribeDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosThresholdWithOptions(request, runtime);
        }

        public async Task<DescribeDdosThresholdResponse> DescribeDdosThresholdAsync(DescribeDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosThresholdWithOptionsAsync(request, runtime);
        }

        public DescribeFlexibleProtectionFlowResponse DescribeFlexibleProtectionFlowWithOptions(DescribeFlexibleProtectionFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexibleProtectionFlowResponse>(DoRPCRequest("DescribeFlexibleProtectionFlow", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlexibleProtectionFlowResponse> DescribeFlexibleProtectionFlowWithOptionsAsync(DescribeFlexibleProtectionFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlexibleProtectionFlowResponse>(await DoRPCRequestAsync("DescribeFlexibleProtectionFlow", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlexibleProtectionFlowResponse DescribeFlexibleProtectionFlow(DescribeFlexibleProtectionFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlexibleProtectionFlowWithOptions(request, runtime);
        }

        public async Task<DescribeFlexibleProtectionFlowResponse> DescribeFlexibleProtectionFlowAsync(DescribeFlexibleProtectionFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlexibleProtectionFlowWithOptionsAsync(request, runtime);
        }

        public DescribeFlowgraphResponse DescribeFlowgraphWithOptions(DescribeFlowgraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowgraphResponse>(DoRPCRequest("DescribeFlowgraph", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowgraphResponse> DescribeFlowgraphWithOptionsAsync(DescribeFlowgraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowgraphResponse>(await DoRPCRequestAsync("DescribeFlowgraph", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowgraphResponse DescribeFlowgraph(DescribeFlowgraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowgraphWithOptions(request, runtime);
        }

        public async Task<DescribeFlowgraphResponse> DescribeFlowgraphAsync(DescribeFlowgraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowgraphWithOptionsAsync(request, runtime);
        }

        public DescribeRegionDdosThresholdResponse DescribeRegionDdosThresholdWithOptions(DescribeRegionDdosThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionDdosThresholdResponse>(DoRPCRequest("DescribeRegionDdosThreshold", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionDdosThresholdResponse> DescribeRegionDdosThresholdWithOptionsAsync(DescribeRegionDdosThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionDdosThresholdResponse>(await DoRPCRequestAsync("DescribeRegionDdosThreshold", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionDdosThresholdResponse DescribeRegionDdosThreshold(DescribeRegionDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionDdosThresholdWithOptions(request, runtime);
        }

        public async Task<DescribeRegionDdosThresholdResponse> DescribeRegionDdosThresholdAsync(DescribeRegionDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionDdosThresholdWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeTrafficInfoResponse DescribeTrafficInfoWithOptions(DescribeTrafficInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTrafficInfoResponse>(DoRPCRequest("DescribeTrafficInfo", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTrafficInfoResponse> DescribeTrafficInfoWithOptionsAsync(DescribeTrafficInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTrafficInfoResponse>(await DoRPCRequestAsync("DescribeTrafficInfo", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTrafficInfoResponse DescribeTrafficInfo(DescribeTrafficInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrafficInfoWithOptions(request, runtime);
        }

        public async Task<DescribeTrafficInfoResponse> DescribeTrafficInfoAsync(DescribeTrafficInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrafficInfoWithOptionsAsync(request, runtime);
        }

        public ModifyDdosStatusResponse ModifyDdosStatusWithOptions(ModifyDdosStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDdosStatusResponse>(DoRPCRequest("ModifyDdosStatus", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDdosStatusResponse> ModifyDdosStatusWithOptionsAsync(ModifyDdosStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDdosStatusResponse>(await DoRPCRequestAsync("ModifyDdosStatus", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDdosStatusResponse ModifyDdosStatus(ModifyDdosStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDdosStatusWithOptions(request, runtime);
        }

        public async Task<ModifyDdosStatusResponse> ModifyDdosStatusAsync(ModifyDdosStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDdosStatusWithOptionsAsync(request, runtime);
        }

        public ModifyDefenseThresholdResponse ModifyDefenseThresholdWithOptions(ModifyDefenseThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDefenseThresholdResponse>(DoRPCRequest("ModifyDefenseThreshold", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDefenseThresholdResponse> ModifyDefenseThresholdWithOptionsAsync(ModifyDefenseThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDefenseThresholdResponse>(await DoRPCRequestAsync("ModifyDefenseThreshold", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDefenseThresholdResponse ModifyDefenseThreshold(ModifyDefenseThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefenseThresholdWithOptions(request, runtime);
        }

        public async Task<ModifyDefenseThresholdResponse> ModifyDefenseThresholdAsync(ModifyDefenseThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefenseThresholdWithOptionsAsync(request, runtime);
        }

    }
}
