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

        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(DoRPCRequest("DescribeInstance", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await DoRPCRequestAsync("DescribeInstance", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2017-05-18", "HTTPS", "POST", "AK", "json", req, runtime));
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
